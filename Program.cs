using System;

namespace MenuPracticeHarjoitus
{
    class Program
    {
        //Koodi console appille johon ohjelma aukeaa
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit the program");
            Console.Write("\r\nSelect an option: ");

            //määrittää mikä koodi seuraavana ajetaan, riippuen siitä minkä kayttäjä valitsee
            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    RemoveWhiteSpace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        
        private static string CaptureInput()
        {
            //Pyytää käyttäjää antamaan haluamansa stringing jota muokataan
            Console.Write("Enter the string you wish to modify: ");
            return Console.ReadLine();
        }

        //ReverseString kirjoittaa käyttäjän antaman stringing/tekstin takaperin
        private static void ReverseString()
        {
            //Ohjelma vahvistaa käyttäjän valitseman toiminnon
            Console.Clear();
            Console.WriteLine("Reverse String");

            //Muuttaa ReadLine komennon vastaanottaman string arvon array muotoon
            char[] charArray = CaptureInput().ToCharArray();
            //kääntää arrayn takaperin
            Array.Reverse(charArray);
            //käyttää alempana kirjoitettua koodia ettei tarviste käyttää WriteLine komentoa erikseen
            DisplayResult(String.Concat(charArray));
        }

        //RemoveWhiteSpace poistaa välit stringigstä/tekstistä
        private static void RemoveWhiteSpace()
        {
            //Ohjelma vahvistaa käyttäjän valitseman toiminnon
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        //DisplayResult sisältää molempien vaihtoehtojen perus output, johon sitten lisätään joko ReserveString/RemoveWhiteSpace ohjelmien tulokset
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter-key to return to Main Menu.");
            Console.ReadLine();
        }
    }
}
