using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameFunctions
{
    public class Dialogue
    {
        public string intro()
        {
            string intro = "Welcome to Space Salvation! You are an alien from the species Garthar on your home-planet, " +
            "Doom, located in the Medusa\nMerger. Your planet’s atmosphere is slowly deteriorating and becoming" +
            " uninhabitable for you and your species. You have\nbeen tasked by the Master Garthar to sell and " +
            "barter your planet’s goods to buy a ship manufactured by the Apocalite\nSpace Corporation on the planet " +
            "Apocalypsis, to be able to transport your species into a new galaxy. You will be able\nto choose " +
            "1 out of 3 ships (Choose wisely, each ship has different stats). You will begin with (TBD) amount of fuel " +
            "and\n$(TBD) in space currency.";
            return intro;
        }

        public string characterName()
        {
            string check;
            string name;
            Console.Write("\nPlease enter your Garthar's name: ");
            name = Console.ReadLine();
            Console.Write($"Are you sure you want to keep this name?: {name}\nEnter Yes or No: ");
            check = Console.ReadLine();
            while (check != " ")
            {
                if (check.ToLower() == "yes")
                {
                    Console.WriteLine($"Hello, {name}. Prepare for an adventure!");
                    break;
                }
                else if (check.ToLower() == "no")
                {
                    Console.Write("Okay, please enter your correct name: ");
                    name = Console.ReadLine();
                    Console.Write($"Are you sure you want to keep this name?: {name}\nEnter Yes or No: ");
                    check = Console.ReadLine();
                }
                else
                {
                    Console.Write("You have not entered yes or no, please try again: ");
                    check = Console.ReadLine();
                }
            }
            return name;
        }

        public string shipName()
        {
            string check;
            string shipName;
            Console.Write("\nPlease enter your Ship's name: ");
            shipName = Console.ReadLine();
            Console.Write($"Are you sure you want to keep this ship name?: {shipName}\nEnter Yes or No: ");
            check = Console.ReadLine();
            while (check != " ")
            {
                if (check.ToLower() == "yes")
                {
                    Console.WriteLine($"Your ship has been named {shipName}!\n");
                    Console.ReadKey();
                    break;
                }
                else if (check.ToLower() == "no")
                {
                    Console.Write("Okay, please enter your correct name: ");
                    shipName = Console.ReadLine();
                    Console.Write($"Are you sure you want to keep this name?: {shipName}\nEnter Yes or No: ");
                    check = Console.ReadLine();
                }
                else
                {
                    Console.Write("You have not entered yes or no, please try again: ");
                    check = Console.ReadLine();
                }
            }
            return shipName;
        }

        public void beginnerShip()
        {
            Console.Write("Its time to choose your ship for your adventure!\n");
            Console.WriteLine("Ship 1: Known for its fuel tank and lack of storage space, this ship comes from the Decanter" +
            " District from your home\nplanet. It was used to travel far distances to trade immaculate jewels to other planets."
            + "If you choose this ship you\nwill be able to traverse far into the galaxy and not have to worry about fuel " +
            "but the drawback is that cannot\nhold that much cargo.\nFuel Space: 7500 Fuel / Storage Space: 000\n");
            Console.WriteLine("Ship 2: This ship comes from the Equilibrium District of your home planet. It was used to help the planet's" +
             " farmers \ntravel to and from markets selling goods to support their families. If you choose this ship, you will " +
             "have an equal\nstorage space-to-fuel ratio, so you can travel a fair amount of distance and hold a fair amount of goods."
             + "\nFuel Space: 6000 Fuel / Storage Space: 000\n");
            Console.WriteLine("Ship 3: This ship comes from what was once the wealthiest district, Diamondia, it was " +
            "used to transport weatlthy\nfamilies to and from the parties they would attend. If you choose this ship, you will have less"
            + " fuel but a luxurious\namount of storage space to carry all of your space products.\nFuel Space: 5000 Fuel / Storage Space:00\n");
        }
    }



    public class SpaceShips
    {
        public int storage;
        public int fuel;

        public int chooseFirstShip()
        {
            string check;
            int caseSwitch;
            check = Console.ReadLine();
            while (Int32.TryParse(check, out caseSwitch) == false || Int32.Parse(check) <= 0 || Int32.Parse(check) >=4)
            {
                Console.WriteLine("You have not entered a value to choose a Spaceship! Please try again");
                check = Console.ReadLine();
            }
            switch (caseSwitch)
            {

                case 1:
                    Console.Write($"Are you sure you want to use Ship 1?\nEnter Yes or No: ");
                    check = Console.ReadLine();
                    while (check != " ")
                    {
                        if (check.ToLower() == "yes")
                        {
                            Console.WriteLine($"Let us begin your Space Salvation Adventure!\n");
                            break;
                        }
                        else if (check.ToLower() == "no")
                        {
                            Console.Write("Okay, please enter your correct name: ");
                            check = Console.ReadLine();
                            Console.Write($"Are you sure you want to keep this name?: \nEnter Yes or No: ");
                            check = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("You have not entered yes or no, please try again: ");
                            check = Console.ReadLine();
                        }
                    }
                    break;
                case 2:
                    Console.Write($"Are you sure you want to use Ship 2?\nEnter Yes or No: ");
                    check = Console.ReadLine();
                    while (check != " ")
                    {
                        if (check.ToLower() == "yes")
                        {
                            Console.WriteLine($"Let us begin your Space Salvation Adventure!\n");
                            break;
                        }
                        else if (check.ToLower() == "no")
                        {
                            Console.Write("Okay, please enter your correct name: ");
                            check = Console.ReadLine();
                            Console.Write($"Are you sure you want to keep this name?: \nEnter Yes or No: ");
                            check = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("You have not entered yes or no, please try again: ");
                            check = Console.ReadLine();
                        }
                    }
                    break;
                case 3:
                    Console.Write($"Are you sure you want to use Ship 3?\nEnter Yes or No: ");
                    check = Console.ReadLine();
                    while (check != " ")
                    {
                        if (check.ToLower() == "yes")
                        {
                            Console.WriteLine($"Let us begin your Space Salvation Adventure!\n");
                            break;
                        }
                        else if (check.ToLower() == "no")
                        {
                            Console.Write("Okay, please enter your correct name: ");
                            check = Console.ReadLine();
                            Console.Write($"Are you sure you want to keep this name?: \nEnter Yes or No: ");
                            check = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("You have not entered yes or no, please try again: ");
                            check = Console.ReadLine();
                        }
                    }
                    break;
            }
            return caseSwitch;
            
        }  
        class Wallet
            
    {
            int balance = 0;     
            public int deposit()
            {
                int NewBalance;
                int deposit;
                Console.WriteLine("Please enter your amount to deposit");
                deposit = Int32.Parse(Console.ReadLine());              
                NewBalance = balance + deposit;
                return NewBalance;
            }
            public int withdraw()
            {
               
                    int NewBalance;
                    int withdraw;
                    Console.WriteLine("Please enter your amount to withdraw");
                    withdraw = Int32.Parse(Console.ReadLine());               
                    NewBalance = balance - withdraw;
                    return NewBalance;
                                   
            }
           
           

        
        static void Main(string[] args)
        {
            
            int NewBalance;
            string bal;
            Wallet funds = new Wallet();

            int balance = 0;
            Console.WriteLine("Your current balance is {0}", balance);
            Console.WriteLine("Press d to deposit, and w to withdraw or qto quit.");


            bal = Console.ReadLine();


            while(bal != "d,w")
            {
                if (bal == "d")
                {
                    NewBalance = funds.deposit();
                    Console.WriteLine($"Your new balance is {NewBalance}");
                }
                else if (bal == "w")
                {
                    NewBalance = funds.withdraw();
                    Console.WriteLine($"Your new balance is {NewBalance}");
                }

                else if (bal != "d, w,")
                {
                    Console.WriteLine("Your current balance is {0}", balance);
                    Console.WriteLine("Press d to deposit, and w to withdraw.");
                    
                }
               
                Console.ReadLine();
            }
            if (bal == "d")
            {
                NewBalance = funds.deposit();
                Console.WriteLine($"Your new balance is {NewBalance}");
            }
            else if (bal == "w")
            {
                NewBalance = funds.withdraw();
                Console.WriteLine($"Your new balance is {NewBalance}");
            }
            
            else if(bal != "d, w,")
            {
                Console.WriteLine("You did not enter a provided option. Try again.");
            }
         
            
            Console.ReadLine();
        }
    
    }
}
