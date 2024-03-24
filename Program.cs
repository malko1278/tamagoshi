// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

// using System.Security.Cryptography.X509Certificates;
using App;

namespace App {
	class Program {
		public static int alimentation = 0, menu_action = 0, type_animal = 0, restart = 1;
		public static Animal? animal = null;
		// The program is executed by a "Main" function
		static void Main(string[] args) {
			// 
			Console.WriteLine("Beginning of the Game Тамагочи...)");
			do {
				play_game();
			} while(restart == 1);
			Console.WriteLine("#####  Thank you for Playing our game  #####");
		}

		static void play_game() {
			do {
				Console.WriteLine("Please select a type of animals :");
				Console.WriteLine("Dog : 1");
				Console.WriteLine("Cat  : 2");
				type_animal = isRealValue(Console.ReadLine()!, 0);
			} while((type_animal != 1) && (type_animal != 2));
			Console.WriteLine("Give a name for your pet : ");
			String? animNam = Console.ReadLine();
			
			animal = new Animal();
			animal.Name = animNam;
			
			tamagochiBoard();
			bool continu = true;
			do{
				stateAnimal();
				MyTamagochi();
				if(menu_action == 4) {
					continu = false;
					alimentation = 0;
					restart = 0;
				} else {
					if(animal.Heath == 0) {
						continu = false;
						Console.WriteLine("Game over !!!");
						Console.WriteLine("Your health is very bad");
						lastMenu();
					}
				}
			} while(continu == true);
		}

		static void tamagochiBoard() {
		    // code to be executed
			Console.WriteLine("\n#######################################################################");
			if(type_animal == 1)   Console.WriteLine("###########################       CAT       ###########################");
			else   Console.WriteLine("###########################       DOG       ###########################");
			Console.WriteLine("#######################################################################");
		}

		static void MyTamagochi() {
		    // code to be executed
			Console.WriteLine("\nSelect the action");
		    Console.WriteLine("1. Feed");
		    Console.WriteLine("2. Play");
		    Console.WriteLine("3. Sleep");
		    Console.WriteLine("4. Stopping the Game");
		    menu_action = isRealValue(Console.ReadLine()!, 1);
			#pragma warning disable CS8602 // Dereference of a possibly null reference.
            switch (menu_action)  {
				case 1 :   
					if(animal.Hunger == 0)	 Console.WriteLine("#####  You can't feed yourself yet, you're fed enough  #####");
					else {
						animal.Hunger -= 1;
						alimentation += 1;
						if(alimentation > 7)   animal.Heath -= 1;
					}
					break;
				case 2 :   
					if(animal.Fatigue == 10)	Console.WriteLine("#####  You can't play anymore. Take a rest  #####");
					else {
						animal.Fatigue += 1;
						if(animal.Fatigue > 7) {
							animal.Heath -= 1;
							animal.Hunger += 1;
							Console.WriteLine("#####  You are very tired. Remember to rest  #####");
						}
					}
					break;
				case 3 :   
					if(animal.Fatigue == 0)	Console.WriteLine("#####  Sorry, it's not possible for you to sleep right now  #####");
					else {
						animal.Fatigue = 0;
						if(animal.Heath < 10)    animal.Heath += 1;
						animal.Hunger += 1;
					}
					break;
				default :   break;
		    }
		}

		static void lastMenu() {
			alimentation = 0;
			Console.WriteLine("Do you want to start playing again ?");
			Console.WriteLine("1. Yes");
			Console.WriteLine("0. No");
			restart = (int.Parse(Console.ReadLine()!));
		}

		static void stateAnimal() {
		    // code to be executed
			Console.WriteLine("\n#######################################################################");
			Console.WriteLine("###  NAME    : {0}  ###################################################", animal.Name);
			getHeath();
			getHunger();
			getFatigue();
		}

		static void getHeath() {
		    // code to be executed
			// Console.WriteLine("###  Heath  : {0}  ####", animal.Heath);
			switch(animal.Heath) {
				case 10:   Console.WriteLine("###  HEATH   : ++++++++++  ############################################");
					break;
				case 9:   Console.WriteLine("###  HEATH   : +++++++++_  ############################################");
					break;
				case 8:   Console.WriteLine("###  HEATH   : ++++++++__  ############################################");
					break;
				case 7:   Console.WriteLine("###  HEATH   : +++++++___  ############################################");
					break;
				case 6:   Console.WriteLine("###  HEATH   : ++++++____  ############################################");
					break;
				case 5:   Console.WriteLine("###  HEATH   : +++++_____  ############################################");
					break;
				case 4:   Console.WriteLine("###  HEATH   : ++++______  ############################################");
					break;
				case 3:   Console.WriteLine("###  HEATH   : +++_______  ############################################");
					break;
				case 2:   Console.WriteLine("###  HEATH   : ++________  ############################################");
					break;
				case 1:   Console.WriteLine("###  HEATH   : +_________  ############################################");
					break;
				case 0:   Console.WriteLine("###  HEATH   : __________  ############################################");
					break;
			}
		}

		static void getHunger() {
		    // code to be executed
			switch(animal.Hunger) {
				case 10:   Console.WriteLine("###  HUNGER  : ++++++++++  ############################################");
					break;
				case 9:   Console.WriteLine("###  HUNGER  : +++++++++_  ############################################");
					break;
				case 8:   Console.WriteLine("###  HUNGER  : ++++++++__  ############################################");
					break;
				case 7:   Console.WriteLine("###  HUNGER  : +++++++___  ############################################");
					break;
				case 6:   Console.WriteLine("###  HUNGER  : ++++++____  ############################################");
					break;
				case 5:   Console.WriteLine("###  HUNGER  : +++++_____  ############################################");
					break;
				case 4:   Console.WriteLine("###  HUNGER  : ++++______  ############################################");
					break;
				case 3:   Console.WriteLine("###  HUNGER  : +++_______  ############################################");
					break;
				case 2:   Console.WriteLine("###  HUNGER  : ++________  ############################################");
					break;
				case 1:   Console.WriteLine("###  HUNGER  : +_________  ############################################");
					break;
				case 0:   Console.WriteLine("###  HUNGER  : __________  ############################################");
					break;
			}
		}

		static void getFatigue() {
		    // code to be executed
			switch(animal.Fatigue) {
				case 10:   Console.WriteLine("###  FATIGUE : ++++++++++  ############################################");
					break;
				case 9:   Console.WriteLine("###  FATIGUE : +++++++++_  ############################################");
					break;
				case 8:   Console.WriteLine("###  FATIGUE : ++++++++__  ############################################");
					break;
				case 7:   Console.WriteLine("###  FATIGUE : +++++++___  ############################################");
					break;
				case 6:   Console.WriteLine("###  FATIGUE : ++++++____  ############################################");
					break;
				case 5:   Console.WriteLine("###  FATIGUE : +++++_____  ############################################");
					break;
				case 4:   Console.WriteLine("###  FATIGUE : ++++______  ############################################");
					break;
				case 3:   Console.WriteLine("###  FATIGUE : +++_______  ############################################");
					break;
				case 2:   Console.WriteLine("###  FATIGUE : ++________  ############################################");
					break;
				case 1:   Console.WriteLine("###  FATIGUE : +_________  ############################################");
					break;
				case 0:   Console.WriteLine("###  FATIGUE : __________  ############################################");
					break;
			}
		}

		static int isRealValue(String val, int intVal) {
			if(intVal == 0) {
				if((val != "1") && (val != "2")) {
					Console.WriteLine("#####  Please, write a real value...  #####\n");
					return 0;
				} else   return int.Parse(val);
			} else {
				if(intVal == 1) {
					if((val != "1") && (val != "2") && (val != "3") && (val != "4")) {
						Console.WriteLine("#####  Select a real value from the menu...  #####");
						return 0;
					} else   return int.Parse(val);
				} else   return 0;
			}
		}
	}
}