using System.Globalization;
using System.Text.Json.Serialization;

namespace La_1100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄\r\n██ ▄▄▀█ ▄▄▀█ ▄▄▀█ ▄▀█▀▄▄▀█ ▄▀▄ ████ ▀██ █ ██ █ ▄▀▄ █ ▄▄▀█ ▄▄█ ▄▄▀████ ▄▄ █ ▄▄█ ▄▄▀█ ▄▄█ ▄▄▀█ ▄▄▀█▄ ▄█▀▄▄▀█ ▄▄▀\r\n██ ▀▀▄█ ▀▀ █ ██ █ █ █ ██ █ █▄█ ████ █ █ █ ██ █ █▄█ █ ▄▄▀█ ▄▄█ ▀▀▄████ █▀▀█ ▄▄█ ██ █ ▄▄█ ▀▀▄█ ▀▀ ██ ██ ██ █ ▀▀▄\r\n██ ██ █▄██▄█▄██▄█▄▄███▄▄██▄███▄████ ██▄ ██▄▄▄█▄███▄█▄▄▄▄█▄▄▄█▄█▄▄████ ▀▀▄█▄▄▄█▄██▄█▄▄▄█▄█▄▄█▄██▄██▄███▄▄██▄█▄▄\r\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀\r\n");
            Console.WriteLine("");
            bool anfang = false;

            bool Antwort = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Möchten sie ein Spiel spielen? [True/False]");
            Console.ResetColor();
            while (!anfang)
                try
                {
                    Antwort = Convert.ToBoolean(Console.ReadLine());
                    anfang = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Das habe ich leider nicht verstanden.");
                    Console.ResetColor();
                }
            if (Antwort)

            {
                int i = 0;
                Console.ForegroundColor= ConsoleColor.DarkGreen;
                Console.WriteLine("Okey fangen wir an. ");
                Console.ResetColor();
                Console.WriteLine("Ich habe eine zufällige Zahl zwischen 1-100 generiert.");
                Console.WriteLine("Versuche die Zahl herauszufinden, indem du eine zahl zwischen 1 -100 eingibst.");
                Console.WriteLine("Ich werde dir dann Tips geben, indem ich sage ob meine Zahl grösser oder kleiner als deine ist.");
                Console.WriteLine("Bereit? [True/False]");
                bool Bereit1 = false;
                bool Bereit = false;
                while (!Bereit1)
                    try
                    {

                        Bereit = Convert.ToBoolean(Console.ReadLine());
                        Bereit1 = true;

                    }catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Das habe ich nicht verstanden.");
                        Console.ResetColor();
                        
                    }
                if (Bereit == true)
                {
                    Random rand = new Random();
                    int Zufallszahl = rand.Next(1, 101);
                    bool ResultatGefunden = false;
                    while (!ResultatGefunden)
                    {
                        Console.WriteLine("Geben Sie eine Zahl ein.");
                        int Zahl = Convert.ToInt32(Console.ReadLine());
                        if (Zahl > Zufallszahl)
                        {
                            Console.WriteLine("Deine Zahl ist zu gross.");
                            Console.WriteLine("------------------------");
                            i++;
                        }


                        else if (Zahl < Zufallszahl)
                        {

                            Console.WriteLine("Deine Zahl ist zu klein ");
                            Console.WriteLine("--------------------------");
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("--------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Du hast gewonnen.");
                            i++;
                            Console.WriteLine("Es hat dich " + i + " versuche gebraucht.");
                            Console.ResetColor();
                            ResultatGefunden = true;
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Möchtest du eine Runde auf 1000 spielen ?[True/False]");
                            bool AntwortSchwer = false;
                            bool AnfangSchwer = false;
                            while (!AnfangSchwer)
                            {
                                try
                                {
                                    AntwortSchwer = Convert.ToBoolean(Console.ReadLine());
                                    AnfangSchwer = true;
                                }
                                catch
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Das habe ich leider nicht verstanden.");
                                    Console.ResetColor();

                                }
                            }
                            if (AntwortSchwer)
                            {
                                Random rnd = new Random();
                                int ZufallszahlSchwer = rnd.Next(1, 1001);
                                bool ResultatSchwer = false;
                                int j = 0;
                                while (!ResultatSchwer)
                                {
                                    Console.WriteLine("Geben sie eine Zahl ein.");
                                    int ZahlSchwer = Convert.ToInt32(Console.ReadLine());
                                    if (ZahlSchwer < ZufallszahlSchwer)

                                    {
                                        Console.WriteLine("Deine Zahl ist zu klein.");
                                        Console.WriteLine("----------------------------");
                                        j++;

                                    }
                                    else if (ZahlSchwer > ZufallszahlSchwer)
                                    {
                                        Console.WriteLine("Deine Zahl ist zu gross.");
                                        Console.WriteLine("---------------------------");
                                        j++;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Du hast gewonnen.");
                                        j++;
                                        Console.WriteLine("Es hat dich " + j + " versuche gebraucht.");
                                        Console.ResetColor();
                                        ResultatSchwer = true;
                                    }


                                }
                            }












                        }

                    }
                }
                else if (Bereit == false)
                {
                    Console.WriteLine("Schade");
                }
            }
            else if (Antwort == false)
            {
                Console.WriteLine("Schade");
            }


        }
    }
}