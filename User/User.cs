using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_C_Sharp.User
{
    public class User
    {
        public int id { get; set; }
        public string premierNom { get; set; }
        public string deuxiemeNom { get; set; }
        public int age { get; set; }
        public double Salaire { get; set; }
        public double capital { get; set; }
        public double taxe { get; set; }
        public int annee { get; set; }
        public double taux { get; set; }

        public void Person(string premierNom, int age)
        {
            Console.WriteLine($"{premierNom} à {age} ans");
        }

        public void interetCompose(double capital, int annee, double taux)
        {
            Console.WriteLine($"Votre capital est de {capital}€");
            Console.WriteLine($"Vous souhaitez le laisser pendant {annee} années");
            Console.WriteLine($"Le taux est de {taux}");

            int i = 0;

            while (i < annee) 
            {
                i++;
                capital = capital + (capital * taux);
                Console.WriteLine($"Votre capital actuel est de{capital}€");
            }

            Console.WriteLine($"Votre capital final est de {capital}€");
        }
    }
}
