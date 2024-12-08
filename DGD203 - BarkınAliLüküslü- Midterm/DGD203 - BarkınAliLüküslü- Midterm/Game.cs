namespace EscapingFromAlien
{
    public class Game
    {
        public void GameStarter() 
        {
            Console.WriteLine("Welcome to the Escaping From Alien!");
            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nHello, {playerName}! You are aboard the spaceship Nostromo. An unknown alien creature has infiltrated the ship. Your mission: survive the creature’s attack and escape to safety. Every decision counts—choose wisely!");

            Console.WriteLine("\nAlarms blare as you wake up in your quarters. A strange scratching sound comes from outside your door.");
            Console.WriteLine("1 - Open the door and investigate the hallway.\n2 - Lock the door and hide under your bed.");
            Console.Write("Please make your selection by entering the number... ");
            string choice1 = Console.ReadLine();

            if (choice1 == "1")
            {
                Console.WriteLine("\nYou cautiously open the door and step into the dimly lit hallway. The walls are smeared with what looks like organic material. In the distance, you hear a faint growl.");
                Console.WriteLine("1 - Follow the sound toward the control room.\n2 - Head to the storage bay to look for supplies.");
                Console.Write("Please make your selection by entering the number... ");
                string choice2 = Console.ReadLine();

                if (choice2 == "1")
                {
                    Console.WriteLine("\nYou reach the control room and find a console displaying an option to activate a distress beacon. However, the controls are sticky with a viscous green fluid.");
                    Console.WriteLine("1 - Activate the distress beacon and call for help.\n2 - Disable the beacon to avoid attracting attention.");
                    Console.Write("Please make your selection by entering the number... ");
                    string choice3 = Console.ReadLine();

                    if (choice3 == "1")
                    {
                        Console.WriteLine("\nThe beacon starts transmitting. Moments later, you hear heavy footsteps behind you.");
                        Console.WriteLine("1 - Hide behind a console.\n2 - Turn around and face the source of the sound.");
                        Console.Write("Please make your selection by entering the number... ");
                        string choice4 = Console.ReadLine();

                        if (choice4 == "1")
                        {
                            Console.WriteLine("You hide just in time as the alien enters the room. It searches briefly before leaving. You survive... for now.");
                            Console.WriteLine("Congratulations, you win!");
                        }
                        else if (choice4 == "2")
                        {
                            Console.WriteLine("You turn to face the noise, but the alien is faster. You are overpowered. Game Over.");
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice. Game Over.");
                        }
                    }
                    else if (choice3 == "2")
                    {
                        Console.WriteLine("You disable the beacon and remain hidden in the control room. The alien eventually leaves, but you have no rescue coming. Days later, you die alone. Game Over.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice. Game Over.");
                    }
                }
                else if (choice2 == "2")
                {
                    Console.WriteLine("\nYou enter the storage bay and find emergency supplies, including a small toolkit. Suddenly, the lights flicker, and you hear a growl.");
                    Console.WriteLine("1 - Use the toolkit to secure the door.\n2 - Hide inside a storage crate.");
                    Console.Write("Please make your selection by entering the number... ");
                    string choice5 = Console.ReadLine();

                    if (choice5 == "1")
                    {
                        Console.WriteLine("The alien breaks through the door, and you can’t hold it off. Game Over.");
                    }
                    else if (choice5 == "2")
                    {
                        Console.WriteLine("You hide successfully and survive another day. Congratulations, you win!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice. Game Over.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong choice. Game Over.");
                }
            }
            else if (choice1 == "2")
            {
                Console.WriteLine("\nYou stay hidden, but after hours of waiting, you hear the door’s electronic lock being bypassed.");
                Console.WriteLine("1 - Stay hidden and hold your breath.\n2 - Grab a metal pipe nearby and prepare to attack.");
                Console.Write("Please make your selection by entering the number... ");
                string choice6 = Console.ReadLine();

                if (choice6 == "1")
                {
                    Console.WriteLine("The alien finds you anyway and attacks. Game Over.");
                }
                else if (choice6 == "2")
                {
                    Console.WriteLine("You surprise the alien and escape the room. Congratulations, you survive... for now.");
                }
                else
                {
                    Console.WriteLine("Wrong choice. Game Over.");
                }
            }
            else
            {
                Console.WriteLine("Wrong choice. Game Over.");
            }
        }
    }
}
