namespace Kalulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei og velommen til kalkulator!");
            Console.WriteLine("Hva er ditt første tall du vil addere?");
            string Tall1 = Console.ReadLine();
            

                if (Tall1 == "") {
                    Console.WriteLine("Denne metoden returnerer ingenting");
                }
                else { 
                Console.WriteLine("Hva skal dette tallet adderes med?");
                string Tall2 = Console.ReadLine();
                if (Tall2 == "")
                {
                    Console.WriteLine("Denne metoden returnerer ingenting");
                }
                else
                {

                    try
                    {
                        int Tall11 = Int32.Parse(Tall1);
                        int Tall22 = Int32.Parse(Tall2);
                        Console.WriteLine("Dette er summen:" + (Tall11 + Tall22));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Dette er summen:" + (Tall1 + Tall2));
                        

                    }
                }
            }
        }
    }
}