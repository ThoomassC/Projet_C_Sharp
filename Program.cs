﻿using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        if (args.Length < 2)
        {
            Console.WriteLine("Erreur : veuillez spécifier le salaire brut annuel et le taux d'imposition en arguments.");
            return;
        }

        if (!double.TryParse(args[0], out double salaireBrutAnnuel) || !double.TryParse(args[1], out double tauxImpots))
        {
            Console.WriteLine("Erreur : les arguments doivent être des nombres.");
            return;
        }

        double prime = 0.10;
        double salaireBrutMensuel = salaireBrutAnnuel / 12;
        double salaireNetAnnuel = salaireBrutAnnuel * tauxImpots;
        double salaireNetMensuel = salaireNetAnnuel / 12;

        Console.WriteLine("Le salaire brut annuel est de {0:C}, le salaire brut mensuel est de {1:C}, le salaire net annuel est de {2:C} et le salaire net mensuel est de {3:C}.", salaireBrutAnnuel, salaireBrutMensuel, salaireNetAnnuel, salaireNetMensuel);

        switch (true)
        {
            case var _ when salaireBrutAnnuel > 50000:
                Console.WriteLine("Faites des dons pour réduire vos impôts !");
                break;
            case var _ when salaireBrutMensuel < 1500:
                Console.WriteLine("C'est normal pour un alternant.");
                break;
            case var _ when 30000 < salaireBrutAnnuel && salaireBrutAnnuel < 40000:
                Console.WriteLine("Venez à CESI faire un Bac +5 !");
                break;
            default:
                Console.WriteLine("Aucune action recommandée.");
                break;
        }

        Console.WriteLine("salaireNetAnnuel :" + salaireNetAnnuel);

        Console.WriteLine("salaireNetMensuelTaux :" + salaireNetMensuel);
        /*string name = "Rollon Normand";
        double percentage = 10.23;
        char gender = 'M';
        bool isVerified = true;
        Console.WriteLine("Id:" + number);
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Percentage:" + percentage); Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Verified:" + isVerified);*/
        Console.ReadLine();
    }
}
