using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controle10_10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018, 10, 27);

            Participant Milan = new Participant("Milan", date);
            Participant Amine = new Participant("Amine", date);

            Tri triMilan = new Tri("S", 750, 20000, 5000);
            Tri triAmine = new Tri("M", 1500, 40000, 10000);

            Epreuve natationMilan = new Epreuve("Natation", 750);
            Epreuve VeloMilan = new Epreuve("Velo", 20000);
            Epreuve CourseMilan = new Epreuve("Course", 5000);
            Epreuve natationAmine = new Epreuve("Natation", 1500);
            Epreuve VeloAmine = new Epreuve("Velo", 40000);
            Epreuve CourseAmine = new Epreuve("Course", 10000);


            Resultat resultatNatation = new Resultat(Milan, natationMilan, 30);
            Resultat resultatVelo = new Resultat(Milan, VeloMilan, 60);
            Resultat resultatCourse = new Resultat(Milan, CourseMilan, 40);
            Resultat resultatNatationAmine = new Resultat(Amine, natationAmine, 60);
            Resultat resultatVeloAmine = new Resultat(Amine, VeloAmine, 110);
            Resultat resultatCourseAmine = new Resultat(Amine, CourseAmine, 60);

            Milan.Add(natationMilan, 45);
            Milan.Add(VeloMilan, 60);
            Amine.Add(VeloAmine, 75);
            Amine.Add(CourseAmine, 65);

            VeloMilan.SetTempsEliminatoire(200);  //On modifie le temps Eliminatoire afin que le participant ne soit pas hors délai
            natationMilan.SetTempsEliminatoire(300); //On modifie le temps Eliminatoire afin que le participant ne soit pas hors délai


            //Participant Milan

            bool resultatV = Milan.resultatPresent(VeloMilan);

            if (resultatV == false)
            {
                Console.WriteLine("Pour l'épreuve de cyclisme {0} n'a pas de resultat", Milan.GetNom());
            }
            else
            {
                foreach (Resultat unResultat in Milan.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == VeloMilan.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de cylisme: {1} min", Milan.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            bool resultatN = Milan.resultatPresent(natationMilan);

            if (resultatN == false)
            {
                Console.WriteLine("Pour l'épreuve de natation {0} n'a pas de resultat", Milan.GetNom());
            }
            else
            {
                foreach (Resultat unResultat in Milan.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == natationMilan.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de Natation: {1} min", Milan.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            bool resultatC = Milan.resultatPresent(CourseMilan);

            if (resultatC == false)
            {
                Console.WriteLine("Pour l'épreuve de course {0} n'a pas de resultat", Milan.GetNom());
            }
            else
            {
                foreach (Resultat unResultat in Milan.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == CourseMilan.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de Course: {1} min", Milan.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            Console.WriteLine("Le temps total de {0} est de {1} minutes", Milan.GetNom(), Milan.GetTempsTotal());


            bool horsDelai = Milan.HorsDelai();

            if (horsDelai == true)
            {
                Console.WriteLine("Le participant {0} est hors delai", Milan.GetNom());
            }
            else
            {
                Console.WriteLine("Le participant {0} n'est pas hors delai", Milan.GetNom());
            }

            Console.WriteLine("La distance totale du triathlon des trois épreuves est  : {0} mètres \n \n", triMilan.GetDistanceTotale());

            //Participant Amine


            bool resultatVa = Amine.resultatPresent(VeloAmine);

            if (resultatVa == false)
            {
                Console.WriteLine("Pour l'épreuve de cyclisme {0} n'a pas de resultat", Amine.GetNom());
            }
            else
            {
                foreach (Resultat unResultat in Amine.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == VeloAmine.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de cylisme: {1} min", Amine.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            bool resultatNa = Amine.resultatPresent(natationMilan);

            if (resultatNa == false)
            {
                Console.WriteLine("Pour l'épreuve de natation {0} n'a pas de resultat", Amine.GetNom());
            }
            else
            {
                foreach (Resultat unResultat in Amine.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == natationAmine.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de Natation: {1} min", Amine.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            bool resultatCa = Amine.resultatPresent(CourseAmine);

            if (resultatCa == false)
            {
                Console.WriteLine("Pour l'épreuve de course {0} n'a pas de resultat", Amine.GetNom());
            }
            else
            {
                foreach (Resultat unResultat in Amine.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == CourseAmine.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de Course: {1} min", Amine.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            Console.WriteLine("Le temps total de {0} est de {1} min", Amine.GetNom(), Amine.GetTempsTotal());


            bool horsDelaiAmine = Amine.HorsDelai();

            if (horsDelaiAmine == true)
            {
                Console.WriteLine("Le participant {0} est hors delai", Amine.GetNom());
            }
            else
            {
                Console.WriteLine("Le participant {0} n'est pas hors delai", Amine.GetNom());
            }

            Console.WriteLine("La distance totale du triathlon des trois épreuves est  : {0} mètres", triAmine.GetDistanceTotale());


            Console.ReadLine();
        }
    }
}
