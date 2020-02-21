﻿using System;
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
            "1 out of 3 ships (Choose wisely, each ship has different stats).";
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
            "but the drawback is that cannot\nhold that much cargo.\nFuel Space: 7500 Fuel / Storage Space: 500\n");
            Console.WriteLine("Ship 2: This ship comes from the Equilibrium District of your home planet. It was used to help the planet's" +
             " farmers \ntravel to and from markets selling goods to support their families. If you choose this ship, you will " +
             "have an equal\nstorage space-to-fuel ratio, so you can travel a fair amount of distance and hold a fair amount of goods."
             + "\nFuel Space: 6000 Fuel / Storage Space: 1000\n");
            Console.WriteLine("Ship 3: This ship comes from what was once the wealthiest district, Diamondia, it was " +
            "used to transport weatlthy\nfamilies to and from the parties they would attend. If you choose this ship, you will have less"
            + " fuel but a luxurious\namount of storage space to carry all of your space products.\nFuel Space: 5000 Fuel / Storage Space: 1500\n");
        }

        public string Menu(int x)
        {
            string menu1 = ($"1. Buy Products\n2. Sell Products\n3. Travel to Another Planet\n4. Refuel");
            string menu2 = ($"1. Buy Products\n2. Sell Products\n3. Travel to Another Planet\n4. Refuel\n5. Buy Planet's Ship");
            if (x == 1)
            {
                return menu1;
            }
            else
            {
                return menu2;
            }

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
            while (Int32.TryParse(check, out caseSwitch) == false || Int32.Parse(check) <= 0 || Int32.Parse(check) >= 4)
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
                    fuel = 7500;
                    storage = 500;
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
                    fuel = 6000;
                    storage = 1000;
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
                    fuel = 5000;
                    storage = 1500;
                    break;
            }
            return caseSwitch; 
        }
    }


    public class Item
    {
        public string name;
        public int price;
        public int weight;
        public int sellsFor;
        public int storage;
        public int productType;
    }

    public class Planets
    {
        public int nextLocation;
        public double money;
        public int storage;
        public int fuel;
        public int maxStorage;
        public int maxFuel;
        public int[] inventory = { 0, 0, 0, 0, 0, 0 }; //This is how the invetory works: index 0 = wheat, 1=space beans, 2 = space goo, 3=alien chicken,4=space rocks, 5=titanium

        public int increaseStorage(int storage, int numOfProducts, int weightOfProduct)
        {
            return storage += numOfProducts * weightOfProduct;

        }

        public int decreaseStorage(int storage, int numOfProducts, int weightOfProduct)
        {
            if (storage - numOfProducts * weightOfProduct < 0)
            {
                Console.WriteLine("You do not have enough storage for that purchase");
            }
            else
            {
                storage -= numOfProducts * weightOfProduct;
            }
            return storage;
        }

        public double buyProducts(double money, int productType, int numOfProduct, double costOfProduct, int weightOfProduct)
        {
            if (money - numOfProduct * costOfProduct < 0)
            {
                Console.WriteLine("You do not have enough money to purchase that!");
            }
            else if(this.storage - (weightOfProduct*numOfProduct) < 0)
            {
                Console.WriteLine("You have enough money, but not enough storage for this purchase!");
            }
            else
            {
                money -= (numOfProduct * costOfProduct);
                this.inventory[productType] = this.inventory[productType] + numOfProduct;
            }
            return money;
        }

        public double sellProducts(double money, int productType, int numOfProduct, double buyPrice)
        {
            if (this.inventory[productType] < numOfProduct)
            {
                Console.WriteLine("You do not have enough of that product to sell that many!");
            }
            else
            {
                money += (numOfProduct * buyPrice);
                this.inventory[productType] = this.inventory[productType] - numOfProduct;
            }
            return money;
        }

        public int refillFuel()
        {
            if (this.money > ((this.maxFuel - this.fuel) * 2))
            {
                this.money -= ((this.maxFuel - this.fuel) * 2);
                this.fuel = this.maxFuel;
                Console.WriteLine($"Your fuel is now {this.fuel}");
                Console.WriteLine($"Your money is now {this.money}");
            }
            else
            {
                Console.WriteLine("You do not have enough money to refill your tank, sell some items and try again!");
            }
            return this.fuel;
        }
        public virtual void planetMenu()
        {
            Console.WriteLine($"1. Buy Products\n2. Sell Products\n3. Travel to Another Planet\n4. Refuel\n5. Buy Planet's Ship");
        }

    }

    public class Garthar : Planets
    {
        public Garthar(double money, int storage, int fuel, int maxStorage, int maxFuel, int[] inventory)
        {
            this.money = money;
            this.storage = storage;
            this.fuel = fuel;
            this.maxFuel = maxFuel;
            this.maxStorage = maxStorage;
            this.inventory = inventory;
        }
        public override void planetMenu()
        {
            Item item1 = new Item();
            item1.name = "Wheat";
            item1.price = 1;
            item1.sellsFor = 10;
            item1.weight = 1;
            item1.productType = 0;
            int caseSwitch = 0;

            do
            {
                Console.WriteLine($"Fuel: {this.fuel}\nStorage: {this.storage}\nMoney: ${this.money}");
                Console.WriteLine($"1. Buy Products\n2. Sell Products\n3. Travel to Another Planet\n4. Refuel\n");
                string test = Console.ReadLine();
                int x;
                while(Int32.TryParse(test, out x) == false || x < 1 || x > 4)
                {
                    Console.WriteLine("Please enter a valid menu option");
                    test = Console.ReadLine();
                }
                int amt = 0;
                switch (x)
                {
                    case 1:
                        Console.WriteLine($"1. {item1.name}");
                        test = Console.ReadLine();
                        int y;
                        while (Int32.TryParse(test, out y) == false || y != 1)
                        {
                            Console.WriteLine("Please enter a valid menu option");
                            test = Console.ReadLine();
                        }
                        switch (y)
                        {
                            case 1:
                                caseSwitch = 1;
                                Console.WriteLine($"The price of {item1.name} is ${item1.price}");
                                Console.WriteLine("How many would you like to buy?");
                                test = Console.ReadLine();
                                while (!int.TryParse(test, out amt))
                                {
                                    Console.WriteLine("Please enter a valid integer.");
                                    test = Console.ReadLine();
                                }
                                this.money = buyProducts(this.money, item1.productType, amt, item1.price,item1.weight);
                                Console.WriteLine($"Your money amount is ${this.money}");
                                this.storage = decreaseStorage(this.storage, amt, item1.weight);
                                Console.WriteLine($"Your storage amount is {this.storage}");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;
                    case 2:
                        caseSwitch = 2;
                        Console.WriteLine("Garthar doesn't buy products from you, returning to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        caseSwitch = 3;
                        Console.WriteLine("1. Eduthear");
                        test = Console.ReadLine();
                        while (test != "1")
                        {
                            Console.WriteLine("You have not entered a valid menu option!");
                            test = Console.ReadLine();
                        }
                        if (this.fuel - 3000 < 0)
                        {
                            Console.WriteLine("You do not have enough fuel to travel! Returning to the main menu");
                            caseSwitch = 1;
                        }
                        else
                        {
                            Console.WriteLine($"Are you sure you want to travel to Eduthear? It will cost 3000 fuel. You have {this.fuel}"); 
                            test = Console.ReadLine();
                            while (test != " ")
                            {
                                if (test.ToLower() == "yes")
                                {
                                    this.fuel -= 3000;
                                    Console.WriteLine("Traveling........");
                                    this.nextLocation = 1;
                                    break;
                                }
                                else if (test.ToLower() == "no")
                                {
                                    Console.Write("Okay, returning to the planet menu!");
                                    caseSwitch = 1;
                                    break;
                                }
                                else
                                {
                                    Console.Write("You have not entered yes or no, please try again: ");
                                    test = Console.ReadLine();
                                }
                            }
                        }
                        Console.Clear();
                        break;
                    case 4:
                        caseSwitch = 4;
                        if (this.fuel == this.maxFuel)
                        {
                            Console.WriteLine("Your tank is already full, returning you to the main menu");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Would you like to refill your fuel? The cost is going to be ${(this.maxFuel - this.fuel) * 2}\nEnter Yes or No");
                            test = Console.ReadLine();
                            while (test != " ")
                            {
                                if (test.ToLower() == "yes")
                                {
                                    this.fuel = refillFuel();
                                    break;
                                }
                                else if (test.ToLower() == "no")
                                {
                                    Console.Write("Okay, returning to the planet menu!");
                                    break;
                                }
                                else
                                {
                                    Console.Write("You have not entered yes or no, please try again: ");
                                    test = Console.ReadLine();
                                }
                            }
                            Console.Clear();
                            break;
                        }


                }
            } while (caseSwitch > 0 && caseSwitch < 5 && caseSwitch != 3);
        }

        public void Deconstruct(out double money, out int storage, out int fuel, out int maxStorage, out int maxFuel, out int[] inventory, out int nextLocation)
        {
            money = this.money;
            storage = this.storage;
            fuel = this.fuel;
            maxStorage = this.maxStorage;
            maxFuel = this.maxFuel;
            inventory = this.inventory;
            nextLocation = this.nextLocation;
        }
    }

    public class Eduthear : Planets
    {
        public Eduthear(double money, int storage, int fuel, int maxStorage, int maxFuel, int[] inventory)
        {
            this.money = money;
            this.storage = storage;
            this.fuel = fuel;
            this.maxFuel = maxFuel;
            this.maxStorage = maxStorage;
            this.inventory = inventory;
        }
        public override void planetMenu()
        {
            Item item1 = new Item();
            item1.name = "Wheat";
            item1.price = 1;
            item1.sellsFor = 10;
            item1.weight = 1;
            item1.productType = 0;

            Item item2 = new Item();
            item2.name = "Space Beans";
            item2.price = 3;
            item2.weight = 2;
            item2.productType = 1;
            item2.sellsFor = 30;

            int caseSwitch = 0;
            Console.WriteLine("Welcome to Eduthear, here you can buy Space Beans and sell Wheat! You can also travel to Solanium or back to Garthar!\n");
            do
            {
                Console.WriteLine($"Fuel: {this.fuel}\nStorage: {this.storage}\nMoney: {this.money}");
                Console.WriteLine($"1. Buy Products\n2. Sell Products\n3. Travel to Another Planet\n4. Refuel\n");
                string test = Console.ReadLine();
                int x;
                while (Int32.TryParse(test, out x) == false || x < 1 || x > 4)
                {
                    Console.WriteLine("Please enter a valid menu option");
                    test = Console.ReadLine();
                }
                int amt = 0;
                switch (x)
                {
                    case 1:
                        Console.WriteLine($"1. {item2.name}");
                        test = Console.ReadLine();
                        int y;
                        while (Int32.TryParse(test, out y) == false || y != 1)
                        {
                            Console.WriteLine("Please enter a valid menu option");
                            test = Console.ReadLine();
                        }
                        switch (y)
                        {
                            case 1:
                                caseSwitch = 1;
                                Console.WriteLine($"The price of {item2.name} is ${item2.price}");
                                Console.WriteLine("How many would you like to buy?");
                                test = Console.ReadLine();
                                while (!int.TryParse(test, out amt))
                                {
                                    Console.WriteLine("Please enter a valid integer.");
                                    test = Console.ReadLine();
                                }
                                this.money = buyProducts(this.money, item2.productType, amt, item2.price, item2.weight);
                                Console.WriteLine($"Your money amount is ${this.money}");
                                this.storage = decreaseStorage(this.storage, amt, item2.weight);
                                Console.WriteLine($"Your storage amount is {this.storage}");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"1. {item1.name}");
                        test = Console.ReadLine();
                        int z ;
                        while (Int32.TryParse(test, out z) == false || z != 1)
                        {
                            Console.WriteLine("Please enter a valid menu option");
                            test = Console.ReadLine();
                        }
                        switch (z)
                        {
                            case 1:
                                caseSwitch = 1;
                                Console.WriteLine($"The selling price of {item1.name} is ${item1.sellsFor}");
                                Console.WriteLine("How many would you like to sell?");
                                test = Console.ReadLine();
                                while (!int.TryParse(test, out amt))
                                {
                                    Console.WriteLine("Please enter a valid integer.");
                                    test = Console.ReadLine();
                                }
                                double testMoney = this.money;
                                this.money = sellProducts(this.money, item1.productType, amt, item1.sellsFor);
                                Console.WriteLine($"Your money amount is ${this.money}");
                                if (testMoney < this.money)
                                {
                                    this.storage = increaseStorage(this.storage, amt, item1.weight);
                                }
                                else
                                {
                                    continue;
                                }
                                Console.WriteLine($"Your storage amount is {this.storage}");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;
                    case 3:
                        caseSwitch = 3;
                        Console.WriteLine("1. Garthar\n2. Solanium");
                        test = Console.ReadLine();
                        while (test != "1" || test != "2")
                        {
                            Console.WriteLine("You have not entered a valid menu option!");
                            test = Console.ReadLine();
                        }
                        if (test == "1")
                        {
                            if(this.fuel < 3000)
                            {
                                Console.WriteLine("You do not have enough fuel to travel that far! Returning to the main menu");
                                caseSwitch = 1;
                            }
                            else
                            {
                                Console.WriteLine($"Are you sure you want to travel back to Garthar? It will cost 3000 fuel. You have {this.fuel}");
                                test = Console.ReadLine();
                                while (test != " ")
                                {
                                    if (test.ToLower() == "yes")
                                    {
                                        this.fuel -= 3000;
                                        Console.WriteLine("Traveling.........");
                                        this.nextLocation = 0;
                                        break;
                                    }
                                    else if (test.ToLower() == "no")
                                    {
                                        Console.Write("Okay, returning to the planet menu!");
                                        caseSwitch = 1;
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("You have not entered yes or no, please try again: ");
                                        test = Console.ReadLine();
                                    }
                                }
                            }

                        }
                        else if (test == "2")
                        {
                            if (this.fuel < 4000)
                            {
                                Console.WriteLine("You do not have enough fuel to travel that far! Returning to the main menu");
                                caseSwitch = 1;
                            }
                            else
                            {
                                Console.WriteLine($"Are you sure you want to travel to Solanium? It will cost 4000 fuel. You have {this.fuel}");
                                test = Console.ReadLine();
                                while (test != " ")
                                {
                                    if (test.ToLower() == "yes")
                                    {
                                        this.fuel -= 4000;
                                        Console.WriteLine("Traveling.........");
                                        this.nextLocation = 2;
                                        break;
                                    }
                                    else if (test.ToLower() == "no")
                                    {
                                        Console.Write("Okay, returning to the planet menu!");
                                        caseSwitch = 1;
                                        break;
                                    }
                                    else
                                    {
                                        Console.Write("You have not entered yes or no, please try again: ");
                                        test = Console.ReadLine();
                                    }
                                }
                            }
                        }
                        Console.Clear();
                        break;
                    case 4:
                        caseSwitch = 4;
                        if (this.fuel == this.maxFuel)
                        {
                            Console.WriteLine("Your tank is already full, returning you to the main menu");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Would you like to refill your fuel? The cost is going to be ${(this.maxFuel - this.fuel) * 2}\nEnter Yes or No");
                            test = Console.ReadLine();
                            while (test != " ")
                            {
                                if (test.ToLower() == "yes")
                                {
                                    this.fuel = refillFuel();
                                    break;
                                }
                                else if (test.ToLower() == "no")
                                {
                                    Console.Write("Okay, returning to the planet menu!");
                                }
                                else
                                {
                                    Console.Write("You have not entered yes or no, please try again: ");
                                    test = Console.ReadLine();
                                }
                            }
                            Console.Clear();
                            break;
                        }


                }
            } while (caseSwitch > 0 && caseSwitch < 5 && caseSwitch != 3);
        }
        

        public void Deconstruct(out double money, out int storage, out int fuel, out int maxStorage, out int maxFuel, out int[] inventory, out int nextLocation)
        {
            money = this.money;
            storage = this.storage;
            fuel = this.fuel;
            maxStorage = this.maxStorage;
            maxFuel = this.maxFuel;
            inventory = this.inventory;
            nextLocation = this.nextLocation;
        }
    }
}
