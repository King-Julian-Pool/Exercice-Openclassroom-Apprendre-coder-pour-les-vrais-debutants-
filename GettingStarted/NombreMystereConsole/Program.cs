using System;

namespace NombreMystereConsole
{
    class Program
    {
        static void Main(string[] args)
        { 
            NouvellePartie();

            YouWin();
        }
        static void NouvellePartie ()
        {
            int NumMys = GenereNombreAleatoire();

            Console.WriteLine("Quel est le numéro mystère ?");

            int PropNum = ChoisirUnNombre();


            while (PropNum != NumMys)
            {
                PropNum = TryAgain(PropNum, NumMys);
            }
        }
        static int GenereNombreAleatoire ()
        {
            return new Random().Next(1, 20);
        }
        static int ChoisirUnNombre()
        {
            string Prop = Console.ReadLine();
            int PropNum;

            while (int.TryParse(Prop, out PropNum) == false)
            {
                Console.WriteLine("Ceci n'est pas un nombre. Faites un petit effort!");
                Prop = Console.ReadLine();
            }
            return PropNum;
        }
        static int TryAgain (int PropNum, int NumMys)
        {
            if (PropNum < NumMys)
            {
                Console.WriteLine("c'est plus");
            }
            else if (PropNum > NumMys)
            {
                Console.WriteLine("c'est moins");
            }

            PropNum = ChoisirUnNombre();
            return PropNum;
        }
        static void YouWin ()
        {
            Console.WriteLine("Bravo tu as gagné !");
        }

    }
}