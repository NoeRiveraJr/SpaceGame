using System;
using SpaceGameFunctions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class SpaceSalvation
    {
        static void Main()
        {

            Dialogue dialogue = new Dialogue();
            SpaceShips firstShip = new SpaceShips();
            string name, shipName;
            Console.WriteLine(dialogue.intro());
            name = dialogue.characterName();
            shipName = dialogue.shipName();
            Console.Clear();
            dialogue.beginnerShip();
            Console.Write("Please enter the number of the ship that you want: ");
            firstShip.chooseFirstShip();

            //these variables are utilized to carry over values between Planets
            int fuel = firstShip.fuel;
            int maxFuel = firstShip.fuel;
            int storage = firstShip.storage;
            int maxStorage = firstShip.storage;
            double money = 15000;
            int gameMaster = 0;
            int nextLocation;
            int[] inventory = { 0, 0, 0, 0, 0}; //This is how the invetory works: index 0 = wheat, 1=space beans, 2 = space goo, 3=alien chicken,4=space rocks
            Console.Clear();

            while (gameMaster != 1) //gameMaster++ will end the game
            {
                //first 2 objects iterate through their menu outside of the whle-switch 
                Garthar garthar = new Garthar(money, storage, fuel, maxStorage, maxFuel, inventory);
                garthar.planetMenu();
                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = garthar;
                Eduthear eduthear = new Eduthear(money, storage, fuel, maxStorage, maxFuel, inventory);
                eduthear.planetMenu();
                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = eduthear;
                Solanium solanium = new Solanium(money, storage, fuel, maxStorage, maxFuel, inventory);
                Hochienus hochienus = new Hochienus(money, storage, fuel, maxStorage, maxFuel, inventory);
                Nauter nauter = new Nauter(money, storage, fuel, maxStorage, maxFuel, inventory);
                Apocolypsis apocolypsis = new Apocolypsis(money, storage, fuel, maxStorage, maxFuel, inventory);
                while (nextLocation >= 0 && nextLocation <= 5)
                {
                    if (maxFuel == 78111101) //Noe in computer alphabet
                    {
                        gameMaster++; //ends game
                        nextLocation = 6; //exists the while loop
                    }
                    else
                    {
                        switch (nextLocation) //nextLocation determinded by case 3 in every planets menu
                        {
                            case 0:
                                garthar.money = money;
                                garthar.storage = storage;
                                garthar.fuel = fuel;
                                garthar.maxStorage = maxStorage;
                                garthar.maxFuel = maxFuel;
                                garthar.inventory = inventory;
                                garthar.planetMenu();
                                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = garthar;
                                break;
                            case 1:
                                eduthear.money = money;
                                eduthear.storage = storage;
                                eduthear.fuel = fuel;
                                eduthear.maxStorage = maxStorage;
                                eduthear.maxFuel = maxFuel;
                                eduthear.inventory = inventory;
                                eduthear.planetMenu();
                                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = eduthear;
                                break;
                            case 2:
                                solanium.money = money;
                                solanium.storage = storage;
                                solanium.fuel = fuel;
                                solanium.maxStorage = maxStorage;
                                solanium.maxFuel = maxFuel;
                                solanium.inventory = inventory;
                                solanium.planetMenu();
                                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = solanium;
                                break;
                            case 3:
                                hochienus.money = money;
                                hochienus.storage = storage;
                                hochienus.fuel = fuel;
                                hochienus.maxStorage = maxStorage;
                                hochienus.maxFuel = maxFuel;
                                hochienus.inventory = inventory;
                                hochienus.planetMenu();
                                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = hochienus;
                                break;
                            case 4:
                                nauter.money = money;
                                nauter.storage = storage;
                                nauter.fuel = fuel;
                                nauter.maxStorage = maxStorage;
                                nauter.maxFuel = maxFuel;
                                nauter.inventory = inventory;
                                nauter.planetMenu();
                                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = nauter;
                                break;
                            case 5:
                                apocolypsis.money = money;
                                apocolypsis.storage = storage;
                                apocolypsis.fuel = fuel;
                                apocolypsis.maxStorage = maxStorage;
                                apocolypsis.maxFuel = maxFuel;
                                apocolypsis.inventory = inventory;
                                apocolypsis.planetMenu();
                                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = apocolypsis;
                                break;
                        }
                    }
                }
            }


            Console.WriteLine("After returning to Garthar with the final ship, you have boarded your entire species and have merely escaped the damnation of your planet!\n +" +
                "You will forever be remebered as a hero by the Gartharians!");

        }
    }
}
