namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is our variables
            int matches = 7;
            int turn = 0;

            //this keeps the game going
            while (matches > 0)
            {
                //This decides if its my turn
                if (turn % 2 == 0)
                {
                    //user interface
                    Console.WriteLine("Det er din tur");
                    int bruger = int.Parse(Console.ReadLine());
                    //This is to make sure the user cant select 3 if there is 2 matches left
                    if (matches == 2)
                    {                     
                        if (bruger == 2)
                        {
                            matches -= 2;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (bruger == 1)
                        {
                            matches -= 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (bruger > 2)
                        {
                            Console.WriteLine("Du kan ikke vælge flere end " + matches);
                            turn--;
                        }
                        
                    }
                    //This is to make sure the user cant select any amount of matches above 1
                    else if (matches == 1)
                    {
                        if (bruger == 1)
                        {
                            matches -= 1;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Desværre. Du tabte...");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (bruger > 1)
                        {
                            Console.WriteLine("Du kan ikke vælge mere end " + matches);
                            turn--;
                        }
                        
                    }
                    //This is if there is more matches than 3 left
                    else
                    {
                        if (bruger > 3)
                        {
                            Console.WriteLine("Du kan ikke trække flere end 3!");
                        }
                        else if (bruger == 3)
                        {
                            matches -= 3;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (bruger == 2)
                        {
                            matches -= 2;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (bruger == 1)
                        {
                            matches -= 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Thread.Sleep(1000);    
                    
                }
                //This is the interface for our bot
                else
                {
                    //This is the best choice if the user picks 1 match
                    if (matches == 6)
                    {
                        matches -= 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Botten valgte 1 tændstik");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    //This is the best choice if the user picks 2 matches
                    else if (matches == 5)
                    {
                        matches -= 2;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Botten valgte 2 tændstik");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    //This is the best choice if the user picks 3 matches
                    else if (matches == 4)
                    {
                        matches -= 3;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Botten valgte 3 tændstik");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    //This is the best choice if the user picks 4 matches
                    else if (matches == 3)
                    {
                        matches -= 2;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Botten valgte 2 tændstik");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    //This is the best choice if the user picks 5 matches
                    else if (matches == 2)
                    {
                        matches -= 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Botten valgte 1 tændstik");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Der er " + matches + " tændstikker tilbage");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    //This if for when the bot loses
                    else if (matches == 1)
                    {
                        matches -= 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Botten valgte 1 tændstik");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Tillykke! Du har vundet!");
                    }
                }               
                turn++;               
            }
            Console.Read();
        }
    }
}