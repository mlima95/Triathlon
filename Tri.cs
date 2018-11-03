using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Tri
    {
        private string nature;
        private Epreuve natation, velo, course;
        List<Participant> lesParticipants = new List<Participant>();

        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("natation", distanceNatation);
            this.velo = new Epreuve("velo", distanceVelo);
            this.course = new Epreuve("course", distanceCourse);
            this.lesParticipants = new List<Participant>();
        }

        public void AddParticipant(Participant unParticipant)
        {
            this.lesParticipants.Add(unParticipant);
        }

        public int GetDistanceTotale()
        {
            return natation.GetDistance() + velo.GetDistance() + course.GetDistance();
        }

        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return this.natation;
                case "vélo":
                    return this.velo;
                default:
                    return this.course;

            }
        }

        public List<Participant> GetLesTemps()
        {
            List<Participant> pasHorsDelai = new List<Participant>();
            foreach (Participant unParticipant in lesParticipants)
            {
                if (unParticipant.HorsDelai() == false)
                {
                    pasHorsDelai.Add(unParticipant);
                }
            }
            return pasHorsDelai;
        }

        public string GetNature()
        {
            return this.nature;
        }

        public Participant GetParticipantById(int id)
        {
            
            foreach(Participant unParticipant in lesParticipants)
            {
                if (unParticipant.GetId()==id)
                {
                    return unParticipant;
                }
            }
            return null;
        }
    }
}
