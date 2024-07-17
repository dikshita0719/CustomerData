
class Konto
{
    //objects
    private string vorname;
    private string nachname;
    private int kontostand = 1000;

    //konstruktoren
    public Konto(string vor, string nach)
    {
        vorname = vor;
        nachname = nach;
    }
    //methoden
    public void Einzahlen()
    {
        Console.WriteLine("Betrag: ");
        int betrag = Convert.ToInt32(Console.ReadLine());
        kontostand= kontostand + betrag;
        Console.WriteLine("Kontoihaber " + vorname + " " + nachname + " hat " + betrag + "abgehoben");
        Console.WriteLine("Neuer Kontostand: " + kontostand);
    }

    public void auszahlen()
    {
        Console.WriteLine("Betrag: ");
        int ausbetrag = Convert.ToInt32(Console.ReadLine());
        if (ausbetrag > kontostand)
        {
            Console.WriteLine("Keine Auszahlung möglich");
        }
        else
        {
            Console.WriteLine("Kontoihaber " + vorname + " " + nachname + " hat " + ausbetrag + "abgehoben");
            kontostand = kontostand - ausbetrag;
        }
    }
}
    internal class Program
{

    public static int[] ArrayFuellen(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
           
            Random rng = new Random();
            arr[i] = rng.Next(1, 50);
        }
        return arr;
    }
    private static void Main(string[] args)
    {
        bool nochmal = true;
        do
        {
            Console.WriteLine("Wählen Sie: \n1. Zufallszahlen(z) \n 2.BankKonto(b)");
            string antwort = Console.ReadLine();
            switch (antwort)
            {
                case "z":
                    Console.WriteLine("Geben Sie ein Interger ein: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    ArrayFuellen(n);

                    break;

                case "b":

                    Console.Write("Vorname: ");
                    string vorname = Console.ReadLine();
                    Console.Write("Nachname: ");
                    string nachname = Console.ReadLine();
                    Konto meins = new Konto(vorname, nachname);
                    Console.WriteLine("Möchten Sie Einzahlen(e) oder Ausheben(a)?");
                    string wunsch = Console.ReadLine();
                    switch (wunsch)
                    {
                        case "e":
                            meins.Einzahlen();
                            break;
                        case "a":
                            meins.auszahlen();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!!");
                    break;
            }
            Console.WriteLine("möchten Sie nochamal machen?(j/n)");
            string nochmall = Console.ReadLine();
            if (nochmall == "n")
            {
                nochmal = false;
            }
        } while (nochmal == true);
    }
}