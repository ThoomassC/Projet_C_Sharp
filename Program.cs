using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        double salaireBrut = Double.Parse(args[0]);
        double tauxImpots = Double.Parse(args[1]);
        double salaireNetAnnuel = salaireBrut * tauxImpots;
        double salaireNetMensuel = salaireNetAnnuel / 12;
        Console.WriteLine("Etape 1 :");
        Console.WriteLine("salaireNetAnnuel :" + salaireNetAnnuel);
        Console.WriteLine("Etape 2 :");
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
