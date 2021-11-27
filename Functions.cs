using System;
using System.IO;
using System.Threading;
using System.Windows.Input;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
// All copyright© of SilverAtom. All rights reserved.

namespace DRAGONLake
{
	public partial class Functions
	{
		//variables & objects
		public class Fighter
		{
			public string name = "", STATUS = "Fine";
			public float HEARTS = 0, HP = 0, ATK = 0, SPE = 0, EXP = 0, EXPNeed = 0, level = 1;
		}

		public static float EXP = 0, EXPNeed = 2000, SPE = 18, HP = 20, HEARTS = 20, ATK = 5, GOLD = 500, bountyNeed = 5/*how many bounties to next level*/, bountyCollected = 0, bountiesCleared = 0, bountyCost = 0;
		public static int level = 1, WILL = 0, re = 0, newDeathCounter = 30, regular, bountyLevel = 1/*1 = easyOnly, 2 = medium & easy, 3 hard, medium, & easy, 4 = miniBosses and all others*/, area = 1;
		public static string[] inventory = {"potion", "potion", "potion", "null", "null", "null", "null", "null", "null", "null", "null"/*not used until endgame*/}, go1 = {"springs", "hills", "forests", "debug"}, storage = {"null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null"};

		public static string option = "N/A", name = "Samuel", team = name, Choose, STATUS = "Fine";
		public static bool noCabin = false, stop = false, dodge = false, debug = true, stop2 = false, inventoryFull = false, stupidBool = true, quickEnd = false, hasBounty = false, stop3 = false, newgame = true, hasStarted = false, goAnyway = false;
		public static bool[] firstTime = {true/*SPECIAL*/, true/*attacking, grabbing, running*/, true/*options*/, true/*enter*/, true/*shopping*/, true/*bounty board*/, true/*apartments*/, true/*hunt zone*/}, From = {false/*springs 2*/, false/*hills*/, false/*forest Mountains*/, false/*forest hills*/, false/*springs 1*/}, ending = {false/*first*/, false/*second, final*/}, bounties = {false/*easyEnemy*/, false/*easyEnemy*/, false/*easyEnemy*/, false/*medium enemy*/, false/*medium enemy*/, false/*medium enemy*/, false/*hard enemy*/, false/*hard enemy*/, false/*hard enemy*/, false/*miniboss enemy*/}, storyEventFM = {true/*Dinner*/, true, true, true, true, true}, playedWith = {true, false, false, false};

		//static Object[] Mark = new Object[] {45/*hp, 0*/, 25/*speed, 1*/, 23/*attack, 2*/, "Mark Conjure"/*name, 3*/};
		public static Fighter Mark = new Fighter() {HEARTS = 50, HP = 50, ATK = 23, SPE = 25, name = "Mark Conjure", EXP = 0, EXPNeed = 2000}, Breys = new Fighter() {HEARTS = 80, HP = 80, ATK = 40, SPE = 90, name = "Breys Swolder", EXP = 0, EXPNeed = 10000}, Sapphire = new Fighter() {HEARTS = 100, HP = 100, ATK = 45, SPE = 70, name = "Sapphire Jewls", EXP = 0, EXPNeed = 9000}, Captain = new Fighter() {HEARTS = 250, HP = 250, ATK = 50, SPE = 50, name = "Captain"};

		public static Fighter enemy = new Fighter() {HP = 40, ATK = 15, SPE = 35};
		
		public static int[] Bounty1 = {0/*1 = easy, 2 = medium, 3 = hard*/, 0, 0, 0/* if one, also miniboss*/},Bounty2 = {0/*1 = easy, 2 = medium, 3 = hard*/, 0, 0, 0/* if one, also miniboss*/}, Bounty3 = {0/*1 = easy, 2 = medium, 3 = hard*/, 0, 0, 0/* if one, also miniboss*/};
		public static float[] bountyCostings = {0, 0, 0};//How much the bounties cost
		
		public static Random rando = new Random();
		public static Random monRand = new Random();

		public static float fMark_1 = Mark.HEARTS;
		public static float fMark0 = Mark.HP;
		public static float fMark1 = Mark.SPE;
		public static float fMark2 = Mark.ATK;
		public static string fMark3 = Mark.name;
		public static float fMark4 = Mark.level;
		public static float fMark5 = Mark.EXP;
		public static float fMark6 = Mark.EXPNeed;
		//Binary Saving
		public static Stream stream;
		public static BinaryFormatter bf = new BinaryFormatter();
		
		//functions
		public static void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			//throw new NotImplementedException();
			info.AddValue("HP", HP);
			info.AddValue("ATK", ATK);
			info.AddValue("SPE", SPE);
			info.AddValue("EXP", EXP);
			info.AddValue("EXPNeed", EXPNeed);
			info.AddValue("level", level);
			info.AddValue("name", name);
			for(int i = 0; i < inventory.Length; i++)
			{
				info.AddValue("inventory " + i, inventory[i]);
			}
			info.AddValue("newgame", newgame);
			info.AddValue("area", area);
			info.AddValue("Choose", Choose);
			for(int i = 0; i < ending.Length; i++)
			{
				info.AddValue("ending " + i, ending[i]);
			}
			for(int i = 0; i < firstTime.Length; i++)
			{
				info.AddValue("firstTime " + i, firstTime[i]);
			}
			info.AddValue("goAnyway", goAnyway);
		}

		public static void SaveInfo(SerializationInfo info, StreamingContext context)
		{
			HP = (float)info.GetValue("HP", typeof(float));
			ATK = (float)info.GetValue("ATK", typeof(float));
			SPE = (float)info.GetValue("SPE", typeof(float));
			EXP = (float)info.GetValue("EXP", typeof(float));
			EXPNeed = (float)info.GetValue("EXPNeed", typeof(float));
			level = (int)info.GetValue("level", typeof(int));
			name = (string)info.GetValue("name", typeof(string));
			for(int i = 0; i < inventory.Length; i++)
			{
				inventory[i]  = (string)info.GetValue("inventory " + i, typeof(string));
			}
			newgame = (bool)info.GetValue("newgame", typeof(bool));
			area = (int)info.GetValue("area", typeof(bool));
			Choose = (string)info.GetValue("Choose", typeof(string));
			for(int i = 0; i < ending.Length; i++)
			{
				ending[i] = (bool)info.GetValue("ending " + i, typeof(bool));
			}
			for(int i = 0; i < firstTime.Length; i++)
			{
				firstTime[i] = (bool)info.GetValue("firstTime " + i, typeof(bool));
			}
			goAnyway = (bool)info.GetValue("goAnyway", typeof(bool));
		}

		public static void Save()
		{
			stream = File.Open("SaveData.dat", FileMode.Create);
			bf = new BinaryFormatter();
			
			bf.Serialize(stream, HP);
			bf.Serialize(stream, ATK);
			bf.Serialize(stream, SPE);
			bf.Serialize(stream, EXP);
			bf.Serialize(stream, EXPNeed);
			bf.Serialize(stream, level);
			bf.Serialize(stream, name);
			for(int i = 0; i < inventory.Length; i++)
			{
				bf.Serialize(stream, inventory[i]);
			}
			bf.Serialize(stream, newgame);
			bf.Serialize(stream, area);
			bf.Serialize(stream, Choose);
			for(int i = 0; i < ending.Length; i++)
			{
				bf.Serialize(stream, ending[i]);
			}
			for(int i = 0; i < firstTime.Length; i++)
			{
				bf.Serialize(stream, firstTime[i]);
			}
			bf.Serialize(stream, goAnyway);
			stream.Close();
		}

		public static void Read()
		{
			//Read
			stream = File.Open("SaveData.dat", FileMode.Open);
			bf = new BinaryFormatter();

			HP = (float)bf.Deserialize(stream);
			ATK = (float)bf.Deserialize(stream);
			SPE = (float)bf.Deserialize(stream);
			EXP = (float)bf.Deserialize(stream);
			EXPNeed = (float)bf.Deserialize(stream);
			level = (int)bf.Deserialize(stream);
			name = (string)bf.Deserialize(stream);
			for(int i = 0; i < inventory.Length; i++)
			{
				inventory[i] = (string)bf.Deserialize(stream);
			}
			newgame = (bool)bf.Deserialize(stream);
			area = (int)bf.Deserialize(stream);
			Choose = (string)bf.Deserialize(stream);
			for(int i = 0; i < ending.Length; i++)
			{
				ending[i] = (bool)bf.Deserialize(stream);
			}
			for(int i = 0; i < firstTime.Length; i++)
			{
				firstTime[i] = (bool)bf.Deserialize(stream);
			}
			goAnyway = (bool)bf.Deserialize(stream);
			stream.Close();
		}

		public static void GetObjectData2(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("hasStarted", hasStarted);
		}

		public static void SaveInfo2(SerializationInfo info, StreamingContext context)
		{
			hasStarted = (bool)info.GetValue("hasStarted", typeof(bool));
		}

		public static void CertainSerial()
		{			
			stream = File.Open("SaveData2.dat", FileMode.Open);
			bf = new BinaryFormatter();

			hasStarted = (bool)bf.Deserialize(stream);
			stream.Close();
		}

		public static void CertainSerialSave()
		{
			stream = File.Open("SaveData2.dat", FileMode.Create);
			bf = new BinaryFormatter();
			
			bf.Serialize(stream, hasStarted);
			stream.Close();
		}

    public static void Space(int spaces = 1) 
		{

      switch(spaces) 
			{

        case 1:
        	Writer(" ");
        break;
        
        case 2:
        	Writer(" ");
        	Writer(" ");
        break;
        
        case 3:
        	Writer(" ");
        	Writer(" ");
        	Writer(" ");
        break;
        
        case 4:
        	Writer(" ");
        	Writer(" ");
        	Writer(" ");
        	Writer(" ");
        break;

				case 5:
					Writer(" ");
					Writer(" ");
					Writer(" ");
					Writer(" ");
					Writer(" ");
				break;

        default:
        	Writer(" ");
        break;
      }

    }

    public static void ErrorWrite() 
		{
      Color("red");
			Writer("Remember to write exactly as it appears in the terminal. Otherwise it won't work!");
      Color("null");
			Space();
    }

		public static void End(int ExitCode = 0)	
		{
			System.Environment.Exit(ExitCode);  
		}

		public static void Enter()
		{
			Space();
			bool o = false;
			if(firstTime[3] == true)
			{
				Writer("Press ENTER to continue. You can also press ENTER when you see '>'. Or press 'U' to use an item.");
				Writer("Press Enter Here (or when you see '>'): ", 2);
				firstTime[3] = false;
			}
			else if(firstTime[3] != true)
			{
				Writer("> ", 2);
			}
			while(o != true)
			{
				switch(Console.ReadKey().Key)
				{
					case ConsoleKey.Enter:
						o = true;
					break;

					case ConsoleKey.U:
						ItemUser();
						Space();
						Writer("> ", 2);
					break;

					default:
						Space();
						Writer("Press Enter: ", 2);
					break;
				}
				Space();
			}
		}

		public static void Color(string color = "null")
		{
			switch(color)
			{
				case "null":
					Writer("[0m", 2);
				break;

				case "bold":
					Writer("[0;1m", 2);
				break;

				case "red":
					Writer("[1;31m", 2);
				break;

				case "yellow":
					Writer("[1;33m", 2);
				break;

				case "blue":
					Writer("[1;34m", 2);
				break;

				case "green":
					Writer("[1;32m", 2);
				break;

				case "cyan":
					Writer("[1;36m", 2);
				break;

				case "pink":
					Writer("[1;31m", 2);
				break;

				case "purple":
					Writer("[1;35m", 2);
				break;

				case "gray":
				case "grey":
					Writer("[0;37m", 2);
				break;

				case "black":
					Writer("[0;30m", 2);
				break;
			}
		}
		
		public static void Use(float potions = 200, float potions_plus = 600, float ATK_UPs = 1000, float EXP_UPs = 400, float HEARTS = 1500)
		{
			bool ond = false, kend = false;
			Writer("Will you shop?");
			Space();
			Writer("yes");
			Writer("no");
			Space();
			option = Reader();
			//yes/no
			while(!ond)
			{
				switch(option)
				{
				case "1":
				case "YES":
				case "Yes":
				case "yes":
					Space();
					if(firstTime[4] == true)
					{
						Space();
						Color("yellow");
						Writer("It's time to do some ", 2);
						Color("green");
						Writer("cash money!", 2);
						Space();
						Enter();
						Color("bold");
						Writer("When shopping, you should always assume that you're gonna need a lot of stuff. After all, monsters aren't always nice!");
						Enter();
						Writer("There are also many types of Items; I'll tell you about all of them!");
						Enter();
						Color("blue");
						Writer("potion: These useful tools heal 20HP. And when you have 20 - 39 HP, these can suffice. You can check HP in the beginning and end of each battle!");
						Enter();
						Writer("potion +: A more powerful version of the standard potion. This one heals three times as much, healing 60HP! Although it is 2x as expencive. These are good for those who have an HP level of 40 - 199. So these are the best type!");
						Enter();
						Color("pink");
						Writer("ATK UP: Time to power up! the ATK UP increases your ATK by 3 points! Alone they can be insegnificant, but multiple of these can make you as powerful as ever!");
						Enter();
						Color("green");
						Writer("EXP UP: Gain some EXP with an EXP UP! Gain Another level in clutch situations to pull through on the battlefield!");
						Enter();
						Color("red");
						Writer("heart: Beat strong with a heart! This, unlike potions, increase your Max HP, making you even more tanky! These Items are great, although expencive. Sometimes it may be best for one to rely on leveling up instead.");
						Enter();
						Color("bold");
						Writer("No that you know about all the items in the shop, you can shop intelligently! just remember to Leave when you're done and sell when you're full on items! See ya!");
						Enter();
						firstTime[4] = false;
					}
					Writer("CabinMaster: Great! potions, EXP UPs, hearts! It's yours, my friend! As long as you have enough GOLD!");
					while(!ond)
					{
						kend = false;
						Space();
						if(inventory[0] == "null" || inventory[1] == "null" || inventory[2] == "null" || inventory[3] == "null" || inventory[4] == "null" || inventory[5] == "null" || inventory[6] == "null" || inventory[7] == "null" || inventory[8] == "null" || inventory[9] == "null" || inventory[10] == "null" && From[2] == true)
						{
							inventoryFull = false;
						}
						if(inventory[0] == "null" || inventory[1] == "null" || inventory[2] == "null" || 	inventory[3] == "null" || inventory[4] == "null" || inventory[5] == "null" || 	inventory[6] == "null" || inventory[7] == "null" || inventory[8] == "null" || inventory[9] == "null" && From[2] != true)
						{
							inventoryFull = false;
						}
						if(inventory[0] != "null" && inventory[1] != "null" && inventory[2] != "null" && inventory[3] != "null" && inventory[4] != "null" && inventory[5] != "null" && inventory[6] != "null" && inventory[7] != "null" && inventory[8] != "null" && inventory[9] != "null" && inventory[10] != "null" && From[2] == true)
						{
							inventoryFull = true;
							Writer("Your inventory is full!");
						}
						if(inventory[0] != "null" && inventory[1] != "null" && inventory[2] != "null" && inventory[3] != "null" && inventory[4] != "null" && inventory[5] != "null" && inventory[6] != "null" && inventory[7] != "null" && inventory[8] != "null" && inventory[9] != "null" && From[2] != true)
						{
							inventoryFull = true;
							Writer("Your inventory is full!");
						}	
						Color("yellow");
						Writer("You have " + GOLD + " GOLD left. Buy wisely!");
						Color("null");
						Space();
						Writer("1: potion, G" + potions);
						Writer("2: potion +, G" + potions_plus);
						Writer("3: EXP UP, G" + EXP_UPs);
						Writer("4: ATK UP, G" + ATK_UPs);
						Writer("5: heart, G" + HEARTS);
						Space();
						Writer("6: Leave");
						Writer("7: Sell");
						Space();
						option = Reader();
						switch(option)
						{
							case "1":
							case "1:":
							case "Potion":
							case "potion":
								if(GOLD >= potions && inventoryFull == false)
								{
									Space();
									Writer("You bought a potion!");
									GOLD -= potions;
									Space();
									Writer("Do you want to use it?");
									Space();
									Writer("yes");
									Writer("no");
									Space();
									option = Reader();
									if(option == "yes" || option == "1") 
									{
										Space();
										Writer("You gained 20 HP!");
										HP += 20;
										if(HP > HEARTS)
										{
											HP = HP + 2;
										}
									}
									else
									{
										for(int i = 0; i < inventory.Length; i++)
										{
											if(inventory[i] == "null")
											{
												inventory[i] = "null";
												break;
											}
											if(i == 10 && From[2] != true)
											{
												break;
											}
										}
									}
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "1":
											case "yes":
												Space();
												Writer("CabinMaster: See ya!");
												Space();
												ond = true;
												kend = true;
											break;

											case "2":
											case "no":
												kend = true;
											break;

											default:
												ErrorWrite();
											break;
										}
									}
								}

								else if(GOLD < potions)
								{
									Space();
									Writer("CabinMaster: Sorry, " + name + ", but I can't give credit!");
								}

								if(inventoryFull == true)
								{
									Writer("CabinMaster: Your inventory is full!");
								}
							break;

							case "2":
							case "2:":
							case "Potion +":
							case "potion plus":
							case "Potion Plus":
							case "potion +":
								if(GOLD >= potions_plus && inventoryFull == false)
								{
									Space();
									Writer("You bought a potion +!");
									GOLD -= potions_plus;
									Space();
									Writer("Do you want to use it?");
									Space();
									Writer("yes");
									Writer("no");
									Space();
									option = Reader();
									if(option == "yes" || option == "1") 
									{
										Space();
										Writer("You gained 60 HP!");
										HP += 60;
										if(HP > HEARTS)
										{
											HP = HP + 6;
										}
									}

									else
									{	
										if(inventory[0] == "null")
										{
											inventory[0] = "potion +";
										}
										else if(inventory[1] == "null")
										{
											inventory[1] = "potion +";
										}
										else if(inventory[2] == "null")
										{
											inventory[2] = "potion +";
										}
										else if(inventory[3] == "null")
										{
											inventory[3] = "potion +";
										}
										else if(inventory[4] == "null")
										{
											inventory[4] = "potion +";
										}
										else if(inventory[5] == "null")
										{
											inventory[5] = "potion +";
										}
										else if(inventory[6] == "null")
										{
											inventory[6] = "potion +";
										}
										else if(inventory[7] == "null")
										{
											inventory[7] = "potion +";
										}
										else if(inventory[8] == "null")
										{
											inventory[8] = "potion +";
										}	
										else if(inventory[9] == "null")
										{
											inventory[9] = "potion +";
										}
										else if(inventory[10] == "null" && From[2] == true)
										{
											inventory[10] = "potion +";
										}
									}
									
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "1":
											case "yes":
												ond = true;
												kend = true;
											break;

											case "2":
											case "no":
												kend = true;
											break;

											default:
												ErrorWrite();
												Space();
												option = Reader();
											break;
										}
									}
								}
								else if(GOLD < potions_plus)
								{
									Space();
									Writer("CabinMaster: Sorry, " + name + ", but I can't give credit!");
								}
							break;

							case "3":
							case "3:":
							case "exp up":
							case "Exp Up":
							case "EXP UP":
								if(GOLD >= EXP_UPs && inventoryFull == false)
								{
									Space();
									Writer("You bought a EXP UP!");
									GOLD -= EXP_UPs;
									Space();
									Writer("Do you want to use it?");
									Space();
									Writer("yes");
									Writer("no");
									Space();
									option = Reader();
									if(option == "yes" || option == "1") 
									{
										Space();
										Writer("You gained 1500 EXP!");
										EXP += 1500;
									}
									else
									{
										if(inventory[0] == "null")
										{
											inventory[0] = "EXP UP";
										}
										else if(inventory[1] == "null")
										{
											inventory[1] = "EXP UP";
										}		
										else if(inventory[2] == "null")
										{
											inventory[2] = "EXP UP";
										}
										else if(inventory[3] == "null")
										{
											inventory[3] = "EXP UP";
										}
										else if(inventory[4] == "null")
										{
											inventory[4] = "EXP UP";
										}
										else if(inventory[5] == "null")
										{
											inventory[5] = "EXP UP";
										}
										else if(inventory[6] == "null")
										{
											inventory[6] = "EXP UP";
										}
										else if(inventory[7] == "null")
										{
											inventory[7] = "EXP UP";
										}
										else if(inventory[8] == "null")
										{
											inventory[8] = "EXP UP";
										}
										else if(inventory[9] == "null")
										{
											inventory[9] = "EXP UP";
										}
										else if(inventory[10] == "null" && From[2] == true)
										{
											inventory[10] = "EXP UP";
										}
									}
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "1":
											case "yes":
												ond = true;
												kend = true;
											break;

											case "2":
											case "no":
												kend = true;
											break;

											default:
												ErrorWrite();
												Space();
												option = Reader();
											break;
										}
									}
								}
								
								else if(GOLD < EXP_UPs)
								{
									Space();
									Writer("CabinMaster: Sorry, " + name + ", but I can't give credit!");
								}

								if(inventoryFull == true)
								{
									Writer("CabinMaster: Your inventory is full!");
								}
							break;

							case "4":
							case "4:":
							case "atk up":
							case "Atk Up":
							case "ATK UP":
								if(GOLD >= ATK_UPs && inventoryFull == false)
								{
									Space();
									Writer("You bought a ATK UP!");
									GOLD -= ATK_UPs;
									Space();
									Writer("Do you want to use it?");
									Space();
									Writer("yes");
									Writer("no");
									Space();
									option = Reader();
									if(option == "yes" || option == "1") 
									{
										Space();
										Writer("You gained 5 ATK!");
										ATK += 5;
									}

									else
									{
										if(inventory[0] == "null")
										{
											inventory[0] = "ATK UP";
										}
										else if(inventory[1] == "null")
										{
											inventory[1] = "ATK UP";
										}
										else if(inventory[2] == "null")
										{
											inventory[2] = "ATK UP";
										}
										else if(inventory[3] == "null")
										{
											inventory[3] = "ATK UP";
										}
										else if(inventory[4] == "null")
										{
											inventory[4] = "ATK UP";
										}
										else if(inventory[5] == "null")
										{
											inventory[5] = "ATK UP";
										}
										else if(inventory[6] == "null")
										{
											inventory[6] = "ATK UP";
										}
										else if(inventory[7] == "null")
										{
											inventory[7] = "ATK UP";
										}
										else if(inventory[8] == "null")
										{
											inventory[8] = "ATK UP";
										}
										else if(inventory[9] == "null")
										{
											inventory[9] = "ATK UP";
										}
										else if(inventory[10] == "null" && From[2] == true)
										{
											inventory[10] = "ATK UP";
										}
									}
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "1":
											case "yes":
												ond = true;
												kend = true;
											break;

											case "2":
											case "no":
												kend = true;
											break;

											default:
												ErrorWrite();
												Space();
												option = Reader();
											break;
										}
									}
								}
								else if(GOLD < ATK_UPs)
								{
									Space();
									Writer("CabinMaster: Sorry, " + name + ", but I can't give credit!");
								}

								if(inventoryFull == true)
								{
									Writer("CabinMaster: Your inventory is full!");
								}
							break;

							case "5":
							case "5:":
							case "Heart":
							case "heart":
							case "HEART":
								if(GOLD >= HEARTS && inventoryFull == false)
								{
									Space();
									Writer("You bought a heart!");
									GOLD -= HEARTS;
									Space();
									Writer("Do you want to use it?");
									Space();
									Writer("yes");
									Writer("no");
									Space();
									option = Reader();
									if(option == "yes" || option == "1") 
									{
										Space();
										Writer("You gained 10 more MAX HP!");
										HEARTS += 10;
										HP += 10;
									}
									else
									{
										if(inventory[0] == "null")
										{
											inventory[0] = "heart";
										}
										else if(inventory[1] == "null")
										{
											inventory[1] = "heart";
										}
										else if(inventory[2] == "null")
										{
											inventory[2] = "heart";
										}
										else if(inventory[3] == "null")
										{
											inventory[3] = "heart";
										}
										else if(inventory[4] == "null")
										{
											inventory[4] = "heart";
										}	
										else if(inventory[5] == "null")
										{
											inventory[5] = "heart";
										}	
										else if(inventory[6] == "null")
										{
											inventory[6] = "hear";
										}	
										else if(inventory[7] == "null")
										{
											inventory[7] = "heart";
										}
										else if(inventory[8] == "null")
										{
											inventory[8] = "heart";
										}	
										else if(inventory[9] == "null")
										{
											inventory[9] = "heart";
										}
									}
								
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "1":
											case "yes":
												ond = true;
												kend = true;
											break;

											case "2":
											case "no":
												kend = true;
											break;

											default:
												ErrorWrite();
												Space();
												option = Reader();
											break;
										}
									}
								}
								else if(GOLD < HEARTS)
								{
									Space();
									Writer("CabinMaster: Sorry, " + name + ", but I can't give credit!");
								}

								if(inventoryFull == true)
								{
									Writer("CabinMaster: Your inventory is full!");
								}
							break;

							case "6":
							case "6:":
							case "LEAVE":
							case "leave":
							case "Leave":
								Space();
								Writer("CabinMaster: Ok! See ya!");
								Enter();
								ond = true;
							break;

							case "7":
							case "7:":
							case "SELL":
							case "Sell":
							case "sell":
								Space();
								if(From[2] == false)
								{
									Writer("What shall you sell? (0 - 9)");
								}
								else
								{
									Writer("What shall you sell? (0 - 10)");
								}
								Space();
								//Logic (help)
								Writer(inventory[0] + ", 0");
								Writer(inventory[1] + ", 1");
								Writer(inventory[2] + ", 2");
								Writer(inventory[3] + ", 3");
								Writer(inventory[4] + ", 4");
								Writer(inventory[5] + ", 5");
								Writer(inventory[6] + ", 6");
								Writer(inventory[7] + ", 7");
								Writer(inventory[8] + ", 8");
								Writer(inventory[9] + ", 9");
								if(From[2] == true)
								{
									Writer(inventory[10] + ", 10");
									Space();
									Writer("END, 11");
								}
								else
								{
									Space();
									Writer("END, 10");
								}
								Space();
								option = Reader();
								Space();
								stop = false;
								while(stop != true)
								{
									switch(option)
									{
										case "0":
											if(inventory[0] == "potion")
											{
												Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[0] = "null";
											}
											if(inventory[0] == "potion +")
											{
												Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[0] = "null";
											}
											if(inventory[0] == "EXP UP")
											{
												Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[0] = "null";
											}
											if(inventory[0] == "ATK UP")
											{
												Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[0] = "null";
											}
											if(inventory[0] == "heart")
											{
												Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[0] = "null";
											}
											if(inventory[0] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[0] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[0] = "null";
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "1":
											if(inventory[1] == "potion")
											{
												Writer("You sold your " + inventory[1] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[1] = "null";
											}
											if(inventory[1] == "potion +")
											{
												Writer("You sold your " + inventory[1] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[1] = "null";
											}
											if(inventory[1] == "EXP UP")
											{
												Writer("You sold your " + inventory[1] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[1] = "null";
											}
											if(inventory[1] == "ATK UP")
											{
												Writer("You sold your " + inventory[1] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[1] = "null";
											}
											if(inventory[1] == "heart")
											{
												Writer("You sold your " + inventory[1] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[1] = "null";
											}
											if(inventory[1] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[1] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[1] = "null";
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "2":
											if(inventory[2] == "potion")
											{
												Writer("You sold your " + inventory[2] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[2] = "null";
											}
											if(inventory[2] == "potion +")
											{
												Writer("You sold your " + inventory[2] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[2] = "null";
											}
											if(inventory[2] == "EXP UP")
											{
												Writer("You sold your " + inventory[2] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[2] = "null";
											}
											if(inventory[2] == "ATK UP")
											{
												Writer("You sold your " + inventory[2] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[2] = "null";
											}
											if(inventory[2] == "heart")
											{
												Writer("You sold your " + inventory[2] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[2] = "null";
											}
											if(inventory[2] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[2] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[2] = "null";
											}
											if(inventory[2] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "3":
											if(inventory[3] == "potion")
											{
												Writer("You sold your " + inventory[3] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[3] = "null";
											}
											if(inventory[3] == "potion +")
											{
												Writer("You sold your " + inventory[3] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[3] = "null";
											}
											if(inventory[3] == "EXP UP")
											{
												Writer("You sold your " + inventory[3] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[3] = "null";
											}
											if(inventory[3] == "ATK UP")
											{
												Writer("You sold your " + inventory[3] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[3] = "null";
											}
											if(inventory[3] == "heart")
											{
												Writer("You sold your " + inventory[3] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[3] = "null";
											}
											if(inventory[3] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[3] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[3] = "null";
											}
											if(inventory[3] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "4":
											if(inventory[4] == "potion")
											{
												Writer("You sold your " + inventory[4] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[4] = "null";
											}
											if(inventory[4] == "potion +")
											{
												Writer("You sold your " + inventory[4] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[4] = "null";
											}
											if(inventory[4] == "EXP UP")
											{
												Writer("You sold your " + inventory[4] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[4] = "null";
											}
											if(inventory[4] == "ATK UP")
											{
												Writer("You sold your " + inventory[4] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[4] = "null";
											}
											if(inventory[4] == "heart")
											{
												Writer("You sold your " + inventory[4] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[4] = "null";
											}
											if(inventory[4] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[4] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[4] = "null";
											}
											if(inventory[4] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "5":
											if(inventory[5] == "potion")
											{
												Writer("You sold your " + inventory[5] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[5] = "null";
											}
											if(inventory[5] == "potion +")
											{
												Writer("You sold your " + inventory[5] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[5] = "null";
											}
											if(inventory[5] == "EXP UP")
											{
												Writer("You sold your " + inventory[5] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[5] = "null";
											}
											if(inventory[5] == "ATK UP")
											{
												Writer("You sold your " + inventory[5] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[5] = "null";
											}
											if(inventory[5] == "heart")
											{
												Writer("You sold your " + inventory[5] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[5] = "null";
											}
											if(inventory[5] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[5] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[5] = "null";
											}
											if(inventory[5] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "6":
											if(inventory[6] == "potion")
											{
												Writer("You sold your " + inventory[6] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[6] = "null";
											}
											if(inventory[6] == "potion +")
											{
												Writer("You sold your " + inventory[6] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[6] = "null";
											}
											if(inventory[6] == "EXP UP")
											{
												Writer("You sold your " + inventory[6] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[6] = "null";
											}
											if(inventory[6] == "ATK UP")
											{
												Writer("You sold your " + inventory[6] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[6] = "null";
											}
											if(inventory[6] == "heart")
											{
												Writer("You sold your " + inventory[6] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[6] = "null";
											}
											if(inventory[6] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[6] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[6] = "null";
											}
											if(inventory[6] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "7":
											if(inventory[7] == "potion")
											{
												Writer("You sold your " + inventory[7] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[7] = "null";
											}
											if(inventory[7] == "potion +")
											{
												Writer("You sold your " + inventory[7] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[7] = "null";
											}
											if(inventory[7] == "EXP UP")
											{
												Writer("You sold your " + inventory[7] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[7] = "null";
											}
											if(inventory[7] == "ATK UP")
											{
												Writer("You sold your " + inventory[7] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[7] = "null";
											}
											if(inventory[7] == "heart")
											{
												Writer("You sold your " + inventory[7] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[7] = "null";
											}
											if(inventory[7] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[7] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[7] = "null";
											}
											if(inventory[7] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "8":
											if(inventory[8] == "potion")
											{
												Writer("You sold your " + inventory[8] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[8] = "null";
											}
											if(inventory[8] == "potion +")
											{
												Writer("You sold your " + inventory[8] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[8] = "null";
											}
											if(inventory[8] == "EXP UP")
											{
												Writer("You sold your " + inventory[8] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[8] = "null";
											}
											if(inventory[8] == "ATK UP")
											{
												Writer("You sold your " + inventory[8] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[8] = "null";
											}
											if(inventory[8] == "heart")
											{
												Writer("You sold your " + inventory[8] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[8] = "null";
											}
											if(inventory[8] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[8] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[8] = "null";
											}
											if(inventory[8] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "9":
											if(inventory[9] == "potion")
											{
												Writer("You sold your " + inventory[9] + "! That'll be worth " + Math.Round(potions/2) + "!");
												Writer("You gained " + Math.Round(potions/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[9] = "null";
											}
											if(inventory[9] == "potion +")
											{
												Writer("You sold your " + inventory[9] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
												Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
												GOLD += (float) Math.Round(potions_plus/2);
												inventory[9] = "null";
											}
											if(inventory[9] == "EXP UP")
											{
												Writer("You sold your " + inventory[9] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
												Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(EXP_UPs/2);
												inventory[9] = "null";
											}
											if(inventory[9] == "ATK UP")
											{
												Writer("You sold your " + inventory[9] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
												Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
												GOLD += (float) Math.Round(ATK_UPs/2);
												inventory[9] = "null";
											}
											if(inventory[9] == "heart")
											{
												Writer("You sold your " + inventory[9] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
												Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
												GOLD += (float) Math.Round(HEARTS/2);
												inventory[9] = "null";
											}
											if(inventory[9] == "junk")
											{
												re = rando.Next(256, 913);
												Writer("You sold your " + inventory[9] + "! That'll be worth " + re + "!");
												Writer("You gained " + re + " GOLD!");
												GOLD += re;
												inventory[9] = "null";
											}
											if(inventory[9] == "null")
											{
												Writer("There's nothing there now!");
											}

											Space();
											if(From[2] == false)
											{
												Writer("What shall you sell? (0 - 9)");
											}
											else
											{
												Writer("What shall you sell? (0 - 10)");
											}
											Space();
											//Logic (help)
											Writer(inventory[0] + ", 0");
											Writer(inventory[1] + ", 1");
											Writer(inventory[2] + ", 2");
											Writer(inventory[3] + ", 3");
											Writer(inventory[4] + ", 4");
											Writer(inventory[5] + ", 5");
											Writer(inventory[6] + ", 6");
											Writer(inventory[7] + ", 7");
											Writer(inventory[8] + ", 8");
											Writer(inventory[9] + ", 9");
											if(From[2] == true)
											{
												Writer(inventory[10] + ", 10");
												Space();
												Writer("END, 11");
											}
											else
											{
												Space();
												Writer("END, 10");
											}
											Space();
											option = Reader();
											Space();
										break;

										case "10":
											if(From[2] == true)
											{
												if(inventory[0] == "potion")
												{
													Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(potions/2) + "!");
													Writer("You gained " + Math.Round(potions/2) + " GOLD!");
													GOLD += (float) Math.Round(potions_plus/2);
													inventory[0] = "null";
												}
												if(inventory[0] == "potion +")
												{
													Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
													Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
													GOLD += (float) Math.Round(potions_plus/2);
													inventory[0] = "null";
												}
												if(inventory[0] == "EXP UP")
												{
													Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
													Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
													GOLD += (float) Math.Round(EXP_UPs/2);
													inventory[0] = "null";
												}
												if(inventory[0] == "ATK UP")
												{
													Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
													Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
													GOLD += (float) Math.Round(ATK_UPs/2);
													inventory[0] = "null";
												}
												if(inventory[0] == "heart")
												{
													Writer("You sold your " + inventory[0] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
													Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
													GOLD += (float) Math.Round(HEARTS/2);
													inventory[0] = "null";
												}
												if(inventory[0] == "junk")
												{
													re = rando.Next(256, 913);
													Writer("You sold your " + inventory[0] + "! That'll be worth " + re + "!");
													Writer("You gained " + re + " GOLD!");
													GOLD += re;
													inventory[0] = "null";
												}
												if(inventory[2] == "null")
												{
													Writer("There's nothing there now!");
												}

												Space();
												if(From[2] == false)
												{
													Writer("What shall you sell? (0 - 9)");
												}
												else
												{
													Writer("What shall you sell? (0 - 10)");
												}
												Space();
												//Logic (help)
												Writer(inventory[0] + ", 0");
												Writer(inventory[1] + ", 1");
												Writer(inventory[2] + ", 2");
												Writer(inventory[3] + ", 3");
												Writer(inventory[4] + ", 4");
												Writer(inventory[5] + ", 5");
												Writer(inventory[6] + ", 6");
												Writer(inventory[7] + ", 7");
												Writer(inventory[8] + ", 8");
												Writer(inventory[9] + ", 9");
												if(From[2] == true)
												{
													Writer(inventory[10] + ", 10");
													Space();
													Writer("END, 11");
												}
												else
												{
													Space();
													Writer("END, 10");
												}
												Space();
												option = Reader();
												Space();
											}
											else
											{
												stop = true;
											}
										break;

										case "11":
											if(From[2] == true)
											{
												stop = true;
											}
											else
											{
												ErrorWrite();
											}
										break;
									}
								}
							break;
							
							default:
								ErrorWrite();
								Space();
								Writer("CabinMaster: What would you like to do?");
							break;
						}
					}
				break;

				case "2":
				case "NO":
				case "No":
				case "no":
					Space();
					Writer("CabinMaster: Have a nice day!");
					Space();
					ond = true;
				break;

				case "ATTACK":
				case "Attack":
				case "attack":
				case "3":
					Space();
					Writer("You jump kick the merchant and kill him.");
					Writer("no cabns 4 u!");
					noCabin = true;
					ond = true;
				break;

				default:
					Writer("CabinMaster: Eh?");
					Space();
					ErrorWrite();
					Writer("Will you shop?");
					Space();
					Writer("yes");
					Writer("no");
					Space();
					option = Reader();
				break;
				}
			}	
		}

		//My pride and joy
		static string monname = "Enemy";
    public static void MonsterEncounter(float hp = 10, float speed = 3, float attack = 2, string monName = "Monster",  float exp = 200F, float gold = 30, bool boss = false, bool doubleBattle = false, bool twoEnemy = false, float hpTwo = 10, float speedTwo = 10, float attackTwo = 1, string monNameTwo = "Monster 2", int teamMate = 0, string status = "Fine", string powerAttack = "Super Hit", float powerAttackHit = 10, float powerAttackHeal = 2, bool isHealing = false, bool isDefending = false, int waitTime = 1, string statusAfflict = "null", bool hasWeight = true, bool hasPattern = false, string statusTwo = "Fine",string powerAttackTwo = "Super Hit", float powerAttackHitTwo = 10, float powerAttackHealTwo = 2, bool isHealingTwo = false, bool isDefendingTwo = false, int waitTimeTwo = 0,string statusAfflictTwo = "null", bool hasWeightTwo = true, bool hasPatternTwo = false, int[] patternTwo = null, int[] weight = null, int[] pattern = null, int[] weightTwo = null)
		{
      //variables
      string[] toDo = {"Attack", "Run", "Grab", "SPECIAL", "Defend"};
      string Choose;
			bool noSpecial = false, single = true, waitTiming = false, waitTimingTwo = false;
			bool[] enemyDown = {false/*enemy two*/, false/*enemy one*/, false}, stopText = {false/*enemy two*/, false/*enemy one*/, false/*both*/};
			float[] turns = {SPE, speed, speedTwo}, turns2 = {SPE, speed, speedTwo, fMark1}, turns3 = {SPE, fMark1, speed}, turns4 = {SPE, speed};
			float[] weightAmount = new float[] {25, 50, 75, 100}, weightAmountTwo = new float[] {25, 50, 75, 100};
			float MaxHp = hp;
			int startWaitTime = waitTime, startWaitTimeTwo = waitTimeTwo, nextPattern = 0;

			if(pattern == null)
			{
				pattern = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
			}
			if(patternTwo == null)
			{
				patternTwo = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
			}
			if(weight == null)
			{
				weight = new int[] {-5, 0, -5, -5};
			}
			if(weightTwo == null)
			{
				weightTwo = new int[] {-5, 0, -5, -5};
			}
			switch(teamMate)
			{
				case 0:
					fMark_1 = Mark.HEARTS;
					fMark0 = Mark.HP;
					fMark1 = Mark.SPE;
					fMark2 = Mark.ATK;
					fMark3 = Mark.name;
					fMark4 = Mark.level;
					fMark5 = Mark.EXP;
					fMark6 = Mark.EXPNeed;
				break;

				case 1:
					fMark_1 = Breys.HEARTS;
					fMark0 = Breys.HP;
					fMark1 = Breys.SPE;
					fMark2 = Breys.ATK;
					fMark3 = Breys.name;
					fMark4 = Breys.level;
					fMark5 = Breys.EXP;
					fMark6 = Breys.EXPNeed;
				break;

				case 2:
					fMark_1 = Sapphire.HEARTS;
					fMark0 = Sapphire.HP;
					fMark1 = Sapphire.SPE;
					fMark2 = Sapphire.ATK;
					fMark3 = Sapphire.name;
					fMark4 = Sapphire.level;
					fMark5 = Sapphire.EXP;
					fMark6 = Sapphire.EXPNeed;
				break;

				case 3:
					fMark_1 = Captain.HEARTS;
					fMark0 = Captain.HP;
					fMark1 = Captain.SPE;
					fMark2 = Captain.ATK;
					fMark3 = Captain.name;
					fMark4 = Captain.level;
					fMark5 = Captain.EXP;
					fMark6 = Captain.EXPNeed;
				break;
			}

			if(twoEnemy == false)
			{
				monname = monName;
			}
			else
			{
				monname = monName + " and " + monNameTwo;
			}

			if(doubleBattle == true || twoEnemy == true)
			{
				single = false;
			}
      //monster
      Space();
      if(doubleBattle == true)
			{
				if(boss == false && twoEnemy == true)
				{
					Writer("[0;31m" + monName + " and " + monNameTwo + " is at battle with you! What shall you two do?");
				}

				else if (boss == false && twoEnemy == false)
				{
					Writer("[0;31m" + monName + " is at battle with you! What shall you two do?");
				}

				else if(boss == true && twoEnemy == false)
				{
					Color("pink");
					Writer("A great " + monName + " has honorably challenged you to a match! What shall you two do, for your lives are on the line?");
				}

				if(boss == true && twoEnemy == true)
				{
					Color("pink");
					Writer("One great " + monName + " and another great " + monNameTwo + " has honorably challenged you to a match! What shall you two do, for your lives are on the line?");
				}
			}

			else if (doubleBattle == false)
			{
				if(boss == false && twoEnemy == false)
				{
					Writer("[0;31m" + monName + " is at battle with you! What shall you do?");
				}

				if(boss == true && twoEnemy == false)
				{
					Color("pink");
					Writer("A great " + monName + " has honorably challenged you to a match! What shall you do, for your life is on the line?");
				}

				if(boss == true && twoEnemy == true)
				{
					Color("pink");
					Writer("One great " + monName + " and another great " + monNameTwo + " have honorably challenged you to a match! What shall you do, for your life is on the line?");
				}

				if(boss == false && twoEnemy == true)
				{
					Writer("[0;31m" + monName + " and " + monNameTwo + " is at battle with you! What shall you do?");
				}
			}
			//tutorial
			if(firstTime[1] == true)
			{
				Space();
				Color("bold");
				Writer("It's time to ", 2);
				Color("pink");
				Writer("fight!", 2);
				Color("bold");
				Writer(" And there are actions you can do by typing!");
				Space();
				Enter();
				Color("red");
				Writer("Wanna Attack to do damage? type 'Attack' or 2 to do some damage, or miss!");
				Enter();
				Color("bold");
				Writer("Need to stale for a teammate? type 'Defend' or 3 and you'll take less damage. perfect for double-single (two of you and one foe) and doble-double (two of you and two foes) battles!");
				Enter();
				Color("blue");
				Writer("Maybe this fight ain't up for ya? Type 'Run' or 4 to try your chances at escape! You won't always succeed, though!");
				Enter();
				Color("green");
				Writer("And if you need to make a refil, your bag is always up to the task! All you have to do is type 'Grab' (or 5)! You already have three healing potions waiting for you!");
				Enter();
				Space();
				Color("red");
				Writer("Beware, for the enemy can Attack too! And if they are faster than you, their attack will hit first, and you can die! But like you, their attacks can also miss!");
				Enter();
				Space();
				Color("cyan");
				Writer("And finally, you can do devastating attacks to monsters with a SPECIAL Attack, though it's best to wait a little to try it out.");
				Space();
				Enter();
				Color("bold");
				Writer("That's why you should always use a combination of these five options, to keep the enemy on their toes!");
				Enter();
				Color("yellow");
				Writer("Using just one will almost never work.");
				Color("null");
				Enter();
				Space();
				Writer("So now, it's time to show this " + monName + " what you're made of!");
				Color("red");
				Space(3);
				firstTime[1] = false;
			}
			//fight
			Space();
			if(doubleBattle == false)
			{
				if(twoEnemy == true)
				{
					Writer("Your HP: " + HP + ", " + monName + " HP: " + hp + ", " + monNameTwo + " HP: " + hpTwo);
				}
				else
				{
					Writer("Your HP: " + HP + ", " + monName + " HP: " + hp);
				}
			}
			else if(doubleBattle == true)
			{
				if(twoEnemy == false)
				{
					Writer("Your HP: " + HP + ", " + monName + " HP: " + hp + ", " + fMark3 + " HP: " + fMark0);
				}

				if(twoEnemy == true)
				{
					Writer("Your HP: " + HP + ", " + monName + " HP: " + hp + ", " + monNameTwo + " HP: " + hpTwo + ", " + fMark3 + " HP: " + fMark0);
				}
			}
			noSpecial = false;
			Space();
      Color("cyan");
			Writer(toDo[3]);
			Color("pink");
			Writer(toDo[0]);
			Color("bold");
			Writer(toDo[4]);
			Color("blue");
      Writer(toDo[1]);
			Color("green");
      Writer(toDo[2]);
			Color("null");
      Space();
      Choose = Reader();
      Space();
      bool fighting = true;
      while(fighting != false) 
			{		
				if(single == true)
				{
					fighting = HP > 0 && hp > 0;
				}
				else
				{
					if (doubleBattle == true)
					{
						if(HP > 0 && hp <= 0)
						{
							fighting = false;
						}
						else
						{
							fighting = true;
						}
					}
					else if (doubleBattle == true && twoEnemy == true)
					{
						if(HP > 0 && hp <= 0 && hpTwo <= 0)
						{
							fighting = false;
						}
						else
						{
							fighting = true;
						}
					}
					else if (doubleBattle == false && twoEnemy == true)
					{
						if(HP > 0 && hp <= 0 && hpTwo <= 0)
						{
							fighting = false;
						}
						else
						{
							fighting = true;
						}
					}
				}
				
				switch(Choose) 
				{
					case "1":
					case "Special":
					case "special":
					case "SPECIAL": 
						if(WILL >= 20 && noSpecial == false)
						{
							Space();
							Color("blue");
							Writer("SPECIAL Attack time!");
							if(firstTime[0] == true)
							{
								Writer("When you have enough ARTHUR'S WILL, you can preform a awesome attack once per battle!");
								Enter();
								Writer("In order to build this force, however, you need to do some ", 2);
								Color("pink");
								Writer("Attacks!");
								Color("blue");
								Enter();
								Writer("Critical hits give the most WILL, while weak hits give the least, and neutral (normal) hits give, well, a neutral amount!");
								Color("red");
								Writer("Though you should beware, for you loose WILL when a monster hits you! But you can loose less WILL when your ATK is higher!");
								Color("null");
								if(doubleBattle == true)
								{
									Enter();
									Color("red");
									Writer("But beware, for Mark doesn't attack when you're using a SPECIAL Attack! So be careful!");
									Enter();
								}
								else
								{
									Enter();
								}
								Writer("Now, time for you to use your WILL!");
								Enter();
								firstTime[0] = false;
							}

							Space();
							Color("cyan");
							Writer("You have " + WILL + " WILL left.");
							Space();
							Writer("100 WILL: UPLIFTING UPPERCUT, 1");
							Writer("90 WILL: MACHSLASH, 2");
							Writer("60 WILL: SPEED SLICE, 3");
							Writer("40 WILL: BUSTER BEAM, 4");
							Writer("220 WILL: OMNIWEB-ULTACUTTER, 5");
							Space();
							Writer("20 WILL: Dodge, 6");
							Writer("End, 7");
							Space();
							option = Reader();
							stop = false;
							while(stop == false)
							{
								switch(option)
								{
									case "1":
									case "UPLIFTING UPPERCUT":								
									case "uplifting uppercut":
									case "Uplifting Uppercut":
										if(WILL >= 120)
										{
											if(single == true || doubleBattle == true && twoEnemy == false)
											{
												Space();
												Writer("You preformed the UPLIFTING UPPERCUT! " + monName + " was slashed up, and sliced down! dealing " + Convert.ToInt32(ATK * 1.7) + " damage!");
												hp -= Convert.ToInt32(ATK * 1.7);
												WILL -= 100;
												noSpecial = true;
												stop = true;
											}
											else if(twoEnemy == true)
											{
												Writer("Select which enemy to attack. (1 - 2)");
												Space();
												Writer(monName + ", 1");
												Writer(monNameTwo + ", 2");
												Space();
												option = Reader();
												stop = false;
												while(stop == false)
												{
													switch(option)
													{
														case "1":
														case "1:":
														case "1 ":
														case "1: ":
															Space();
															Writer("You preformed the UPLIFTING UPPERCUT! " + monName + " was slashed up, and sliced down! dealing " + Convert.ToInt32(ATK * 1.7) + " damage!");
															hp -= Convert.ToInt32(ATK * 1.7);
															WILL -= 100;
															noSpecial = true;
															stop = true;
														break;

														case "2":
														case "2:":
														case "2 ":
														case "2: ":
															Space();
															Writer("You preformed the UPLIFTING UPPERCUT! " + monNameTwo + " was slashed up and sliced down! dealing " + Convert.ToInt32(ATK * 1.7) + " damage!");
															hpTwo -= Convert.ToInt32(ATK * 1.7);
															WILL -= 100;
															noSpecial = true;
															stop = true;
														break;

														default:
															ErrorWrite();
															Space();
															option = Reader();
														break;
													}
												}
											}
										}

										else
										{
											Space();
											Writer("You tried, but you didn't have enough WILL, and failed!");
											WILL = 0;
											noSpecial = true;
										}
										stop = true;
										if(hp <= 0)
										{
											continue;
										}
									break;

									case "2":								
									case "MACHSLASH":									
									case "machslash":
									case "mach slash":
									case "Mach Slash":
									case "MachSlash":
										if(WILL >= 160)
										{
											if(single == true || doubleBattle == true && twoEnemy == false)
											{
												Space();
												Writer("You preformed the MACHSLASH! " + monName + " was slashed 100 times! dealing " + 70 + " damage!");
												WILL -= 90;
												hp -= 70;
												noSpecial = true;
												stop = true;
											}
											else if(twoEnemy == true)
											{
												Writer("Select which enemy to attack. (1 - 2)");
												Space();
												Writer(monName + ", 1");
												Writer(monNameTwo + ", 2");
												Space();
												option = Reader();
												stop = false;
												while(stop == false)
												{
													switch(option)
													{
														case "1":
														case "1:":
														case "1 ":
														case "1: ":
															Space();
															Writer("You preformed the MACHSLASH! " + monName + " was slashed 100 times! dealing " + 70 + " damage!");
															WILL -= 90;
															hp -= 70;
															noSpecial = true;
															stop = true;
														break;

														case "2":
														case "2:":
														case "2 ":
														case "2: ":
															Space();
															Writer("You preformed the MACHSLASH! " + monNameTwo + " was slashed 100 times! dealing " + 70 + " damage!");
															WILL -= 90;
															hpTwo -= 70;
															noSpecial = true;
															stop = true;
														break;

														default:
															ErrorWrite();
															Space();
															option = Reader();
														break;
													}
												}
											}
										}

										else
										{
											Space();
											Writer("You tried to do the MACHSLASH, but failed!");
											WILL = 0;
											noSpecial = true;
										}
										stop = true;
										if(hp <= 0)
										{
											continue;
										}
									break;

									case "3":									
									case "SPEED SLICE":
									case "speed slice":
									case "Speed Slice":
										if(WILL >= 100)
										{
											if(single == true || doubleBattle == true && twoEnemy == false)
											{
												Space();
												Writer("You preformed the SPEED SLICE! " + monName + " was slashed through at blinding speeds, dealing " + 50 + " damage!");
												WILL -= 60;
												hp -= 50;
												noSpecial = true;
												stop = true;
											}
											else if(twoEnemy == true)
											{
												Writer("Select which enemy to attack. (1 - 2)");
												Space();
												Writer(monName + ", 1");
												Writer(monNameTwo + ", 2");
												Space();
												option = Reader();
												stop = false;
												while(stop == false)
												{
													switch(option)
													{
														case "1":
														case "1:":
														case "1 ":
														case "1: ":
															Space();
															Writer("You preformed the SPEED SLICE! " + monName + " was slashed through at blinding speeds, dealing " + 50 + " damage!");
															WILL -= 60;
															hp -= 50;
															noSpecial = true;
															stop = true;
														break;

														case "2":
														case "2:":
														case "2 ":
														case "2: ":
															Space();
															Writer("You preformed the SPEED SLICE! " + monNameTwo + " was slashed through at blinding speeds, dealing " + 50 + " damage!");
															WILL -= 60;
															hpTwo -= 50;
															noSpecial = true;
															stop = true;
														break;

														default:
															ErrorWrite();
															Space();
															option = Reader();
														break;
													}
												}
											}
										}

										else
										{
											Space();
											Writer("You tried to do the SPEED SLICE, but failed!");
											WILL = 0;
											noSpecial = true;
										}
										stop = true;
										if(hp <= 0)
										{
											continue;
										}
										stop = true;
									break;

									case "4":
									case "BUSTER BEAM":
									case "buster beam":
									case "Buster Beam":
										if(WILL >= 40)
										{
											if(single == true || doubleBattle == true && twoEnemy == false)
											{
												Space();
												Writer("You preformed the BUSTER BEAM! " + monName + " was blasted with a sword beam made of WILL, dealing " + Convert.ToInt32	(ATK * 2.5) + " damage!");
												WILL -= 40;
												hp -= Convert.ToInt32(ATK * 1.5);
												noSpecial = true;
												stop = true;
											}
											else if(twoEnemy == true)
											{
												Writer("Select which enemy to attack. (1 - 2)");
												Space();
												Writer(monName + ", 1");
												Writer(monNameTwo + ", 2");
												Space();
												option = Reader();
												stop = false;
												while(stop == false)
												{
													switch(option)
													{
														case "1":
														case "1:":
														case "1 ":
														case "1: ":
															Space();
															Writer("You preformed the BUSTER BEAM! " + monName + " was blasted with a sword beam made of WILL, dealing " + Convert.ToInt32	(ATK * 2.5) + " damage!");
															WILL -= 40;
															hp -= Convert.ToInt32(ATK * 2.5);
															noSpecial = true;
															stop = true;
														break;

														case "2":
														case "2:":
														case "2 ":
														case "2: ":
															Space();
															Writer("You preformed the BUSTER BEAM! " + monNameTwo + " was blasted with a sword beam made of WILL, dealing " + Convert.ToInt32	(ATK * 2.5) + " damage!");
															WILL -= 40;
															hpTwo -= Convert.ToInt32(ATK * 2.5);
															noSpecial = true;
															stop = true;
														break;

														default:
															ErrorWrite();
															Space();
															option = Reader();
														break;
													}
												}
											}
										}

										else
										{
											Space();
											Writer("You tried to do the BUSTER BEAM, but failed!");
											WILL = 0;
											noSpecial = true;
										}
										stop = true;
										if(hp <= 0)
										{
											continue;
										}
									break;

									case "5":
									case "omniweb-ultacutter":
									case "omniweb ultacutter":
									case "Omniweb-Ultacutter":
									case "Omniweb Ultacutter":
									case "ULTACUTTER":
									case "Ultacutter":
									case "OMNIWEB":
									case "omniweb":
									case "Omniweb":
										if(WILL >= 220)
										{
											if(single == true || doubleBattle == true && twoEnemy == false)
											{
												Space();
												Writer("You preformed the OMNIWEB-ULTACUTTER! " + monName + " was slashed too many times to count! Making a web formation dealing " + Convert.ToInt32(ATK * 3.5) + " damage!");
												WILL -= 220;
												hp -= Convert.ToInt32(ATK * 3.5);
												noSpecial = true;
												stop = true;
											}
											else if(twoEnemy == true)
											{
												Writer("Select which enemy to attack. (1 - 2)");
												Space();
												Writer(monName + ", 1");
												Writer(monNameTwo + ", 2");
												Space();
												option = Reader();
												stop = false;
												while(stop == false)
												{
													switch(option)
													{
														case "1":
														case "1:":
														case "1 ":
														case "1: ":
															Space();
															Writer("You preformed the OMNIWEB-ULTACUTTER! " + monName + " was slashed too many times to count! Making a web formation dealing " + Convert.ToInt32(ATK * 3.5) + " damage!");
															WILL -= 220;
															hp -= Convert.ToInt32(ATK * 3.5);
															noSpecial = true;
															stop = true;
														break;

														case "2":
														case "2:":
														case "2 ":
														case "2: ":
															Space();
															Writer("You preformed the OMNIWEB-ULTACUTTER! " + monNameTwo + " was slashed too many times to count! Making a web formation dealing " + Convert.ToInt32(ATK * 3.5) + " damage!");
															WILL -= 220;
															hpTwo -= Convert.ToInt32(ATK * 3.5);
															noSpecial = true;
															stop = true;
														break;

														default:
															ErrorWrite();
															Space();
															option = Reader();
														break;
													}
												}
											}
										}

										else
										{
											Space();
											Writer("You tried to do the OMNIWEB-ULTACUTTER, but failed miserabely! You took damage!");
											WILL = 0;
											HP -= 10;
											noSpecial = true;
										}
										stop = true;
										if(hp <= 0)
										{
											continue;
										}
									break;

									case "6":
									case "Dodge":
									case "dodge":
										Space();
										Writer("You dodged the incoming attack!");
										dodge = true;
										stop = true;
									break;

									case "7":
									case "End":
									case "end":
										Writer("You decided not to do a SPECIAL Attack. ");
										Writer("But by thinking of it, you don't have the time to do something else!", 2);
										stop = true;
									break;

									default:
										ErrorWrite();
										Color("cyan");
										Writer("120 WILL: UPLIFTING UPPERCUT, 1");
										Writer("160 WILL: MACHSLASH, 2");
										Writer("100 WILL: SPEED SLICE, 3");
										Writer("40 WILL: BUSTER BEAM, 4");
										Writer("220 WILL: OMNIWEB-ULTACUTTER, 5");
										Space();
										Writer("20 WILL: Dodge, 6");
										Writer("End, 7");
										Space();
										option = Reader();
									break;
								}
							}
							//monster death check
							if(single == true || doubleBattle == true && twoEnemy == false)
							{
								if(hp <= 0)
								{
									enemyDown[2] = true;
									fighting = false;
								}
							}
							if(twoEnemy == true)
							{
								if(hp <= 0)
								{
									enemyDown[1] = true;
									if(enemyDown[0] == false)
									{
										if(stopText[1] == false)
										{
											Writer(monName + " has been defeated! one down, one to go!");
											stopText[1] = true;
										}
									}
									else if(enemyDown[0] == true)
									{
										Writer("All enemies have been defeated!");
										fighting = false;
									}
								}
								if(hpTwo <= 0)
								{
									enemyDown[0] = true;
									if(enemyDown[1] == false)
									{
										if(stopText[0] == false)
										{
											Writer(monNameTwo + " has been defeated! one down, one to go!");
											stopText[0] = true;
										}
									}
									else if(enemyDown[1] == true)
									{
										Writer("All enemies have been defeated!");
										fighting = false;
									}
								}
							}
							//monster
							if(dodge == true)
							{
								Space();
								Writer("The enemy did no damage, because you dodged their attack! This gives you time to use an item!");
								Color("null");
								WILL -= 10;
								dodge = false;
								Space();
								ItemUser();
							}
							else if(dodge == false)
							{
								//monster
								Space();
								if(single == true || (doubleBattle == true && twoEnemy == false))
								{
									Color("red");
									Writer(monName + " did " + attack + " hp to you!");
									Color("null");
									HP -= attack;
									WILL -= Convert.ToInt32(attack - ATK/6);
								}
								else if(twoEnemy == true)
								{
									if(speed >= speedTwo)
									{
										Space(2);
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
										HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
										Space(2);
										Color("red");
										Writer(monNameTwo + " did " + attackTwo + " hp to you!");
										Color("null");
										HP -= attackTwo;
										WILL -= Convert.ToInt32(attackTwo - ATK/6);
									}
									else if(speedTwo > speed)
									{
										Color("red");
										Writer(monNameTwo + " did " + attackTwo + " hp to you!");
										Color("null");
										HP -= attackTwo;
										WILL -= Convert.ToInt32(attackTwo - ATK/6);
										Space(2);
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
										HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
								}
							}
							//end
							Space(2);
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							//choose
							DeathHandler();

							if(hp <= 0)
							{
								continue;
							}
							Space();
							Writer("What next? (1 - 5)");
							Space();
      				Color("cyan");
							Writer(toDo[3]);
							Color("pink");
							Writer(toDo[0]);
							Color("bold");
							Writer(toDo[4]);
							Color("blue");
      				Writer(toDo[1]);
							Color("green");
      				Writer(toDo[2]);
							Color("null");
      				Space();
      				Choose = Reader();
						}

						else if(WILL <= 20)
						{
							Color("red");
							Writer("You don't have enough WILL to do any special attacks!");
							Color("null");
							//monster death check
							if(single == true || doubleBattle == true && twoEnemy == false)
							{
								if(hp <= 0)
								{
									enemyDown[2] = true;
									fighting = false;
								}
							}
							if(twoEnemy == true)
							{
								if(hp <= 0)
								{
									enemyDown[1] = true;
									if(enemyDown[0] == false)
									{
										if(stopText[1] == false)
										{
											Writer(monName + " has been defeated! one down, one to go!");
											stopText[1] = true;
										}
									}
									else if(enemyDown[0] == true)
									{
										Writer("All enemies have been defeated!");
										fighting = false;
									}
								}
								if(hpTwo <= 0)
								{
									enemyDown[0] = true;
									if(enemyDown[1] == false)
									{
										if(stopText[0] == false)
										{
											Writer(monNameTwo + " has been defeated! one down, one to go!");
											stopText[0] = true;
										}
									}
									else if(enemyDown[1] == true)
									{
										Writer("All enemies have been defeated!");
										fighting = false;
									}
								}
							}
							//monster
							Space();
							if(firstTime[0])
							{
								if(single == true || doubleBattle == true && twoEnemy == false)
								{
									Color("red");
									Writer(monName + " did " + attack + " hp to you!");
									Color("null");
									HP -= attack;
									WILL -= Convert.ToInt32(attack - ATK/6);
								}
								if(twoEnemy == true)
								{
									if(speed >= speedTwo)
									{
										Space(2);
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
										HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
										Space(2);
										Color("red");
										Writer(monNameTwo + " did " + attackTwo + " hp to you!");
										Color("null");
										HP -= attackTwo;
										WILL -= Convert.ToInt32(attackTwo - ATK/6);
									}
									else if(speedTwo > speed)
									{
										Color("red");
										Writer(monNameTwo + " did " + attackTwo + " hp to you!");
										Color("null");
										HP -= attackTwo;
										WILL -= Convert.ToInt32(attackTwo - ATK/6);
										Space(2);
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
										HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
								}
							}
							//end
							Space(2);
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							//choose
							DeathHandler();
	
							if(hp <= 0)
							{
								enemyDown[2] = true;
								continue;
							}

							if(enemyDown[2] != true)
							{
								Space();
								Writer("What next? (1 - 5)");
								Space();
      					Color("cyan");
								Writer(toDo[3]);
								Color("pink");
								Writer(toDo[0]);
								Color("bold");
								Writer(toDo[4]);
								Color("blue");
      					Writer(toDo[1]);
								Color("green");
      					Writer(toDo[2]);
								Color("null");
      					Space();
      					Choose = Reader();
							}
						}

						else if(noSpecial == true)
						{
							Space();
							Color("red");
							Writer("You have done a SPECIAL Attack! Now you can't do another in this battle.");
							Color("null");
							Space();
							Writer("Dodge, 6");
							Space();
							Writer("End, 7");
							Space();
							option = Reader();
							if(option == "6" || option == "Dodge" || option == "dodge")
							{
								Space();
								Writer("You dodged the incoming attack!");
								dodge = true;
								stop = true;
							}

							else if(option == "End" || option == "end" || option == "7")
							{
								Writer("You decided not to do a SPECIAL Attack.");
							}
							//monster death check
							if(single == true || doubleBattle == true && twoEnemy == false)
							{
								if(hp <= 0)
								{
									enemyDown[2] = true;
									fighting = false;
								}
							}
							if(twoEnemy == true)
							{
								if(hp <= 0)
								{
									enemyDown[1] = true;
									if(enemyDown[0] == false)
									{
										if(stopText[1] == false)
										{
											Writer(monName + " has been defeated! one down, one to go!");
											stopText[1] = true;
										}
									}
									else if(enemyDown[0] == true)
									{
										Writer("All enemies have been defeated!");
										fighting = false;
									}
								}
								if(hpTwo <= 0)
								{
									enemyDown[0] = true;
									if(enemyDown[1] == false)
									{
										if(stopText[0] == false)
										{
											Writer(monNameTwo + " has been defeated! one down, one to go!");
											stopText[0] = true;
										}
									}
									else if(enemyDown[1] == true)
									{
										Writer("All enemies have been defeated!");
										fighting = false;
									}
								}
							}
							//monster
							if(dodge == true)
							{
								Space();
								Writer("The enemy did no damage, because you dodged their attack! This gives you time to use an item!");
								Color("null");
								WILL -= 10;
								dodge = false;
								Space();
								ItemUser();
							}
							else if(dodge == false)
							{
								//monster
								Space();
								if(single == true || doubleBattle == true && twoEnemy == false)
								{
									Color("red");
									Writer(monName + " did " + attack + " hp to you!");
									Color("null");
									HP -= attack;
									WILL -= Convert.ToInt32(attack - ATK/6);
								}
								if(twoEnemy == true)
								{
									if(speed >= speedTwo)
									{
										Space(2);
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
										HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
										Space(2);
										Color("red");
										Writer(monNameTwo + " did " + attackTwo + " hp to you!");
										Color("null");
										HP -= attackTwo;
										WILL -= Convert.ToInt32(attackTwo - ATK/6);
									}
									else if(speedTwo > speed)
									{
										Color("red");
										Writer(monNameTwo + " did " + attackTwo + " hp to you!");
										Color("null");
										HP -= attackTwo;
										WILL -= Convert.ToInt32(attackTwo - ATK/6);
										Space(2);
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
										HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
								}
							}
							//end
							Space(2);
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							//choose
							DeathHandler();
	
							if(hp <= 0)
							{
								continue;
							}

							Space();
							Writer("What next? (1 - 5)");
							Space();
      				Color("cyan");
							Writer(toDo[3]);
							Color("pink");
							Writer(toDo[0]);
							Color("bold");
							Writer(toDo[4]);
							Color("blue");
      				Writer(toDo[1]);
							Color("green");
      				Writer(toDo[2]);
							Color("null");
      				Space();
      				Choose = Reader();
						}
					break;
					
					case "2":
					case "attack":
					case "atack":
					case "Atack":
					case "ATACK":
					case "ATK":
					case "atk":
					case "Atk":
					case "Attaack":
					case "Atttack":
					case "Atttaaack":
					case "ATtack":
					case "Attack":
						switch(teamMate)
						{
							case 0:
								Mark.HP = fMark0; 
								Mark.SPE = fMark1; 
								Mark.ATK = fMark2; 
								Mark.name = fMark3; 
							break;

							case 1:
								Breys.HP = fMark0; 
								Breys.SPE = fMark1; 
								Breys.ATK = fMark2; 
								Breys.name = fMark3; 
							break;

							case 2:
								Sapphire.HP = fMark0;
								Sapphire.SPE = fMark1;
								Sapphire.ATK = fMark2;
								Sapphire.name = fMark3;
							break;

							case 3:
								Captain.HP = fMark0;
								Captain.SPE = fMark1;
								Captain.ATK = fMark2;
								Captain.name = fMark3;
							break;
						}
						//XXX
						if(single == true)//single-single
						{
							if(SPE == speed || speed == SPE)
							{
								speed -= 1;
								turns4[1] = speed;
							}
							if(isDefending == true)
							{
								turns4 = new float[] {speed, SPE};
							}
							else
							{
								Array.Sort(turns4);
								Array.Reverse(turns4);
							}
							//battle
							for(int i = 0; i < 2; i++)
							{
								if(enemyDown[2] == false)
								{
									if(turns4[i] == speed)
									{
										//mon1 death check
										if(hp <= 0)
										{
											enemyDown[2] = true;
										}
										else
										{
											//mon1
											//Pattern
											if(hasPattern == true)
											{
												if(waitTime <= 0 && waitTiming == true)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You somehow dodged " + monName + "'s POWER Attack!");
															waitTime = startWaitTime;
															Color("null");
														break;

														default:
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
															Color("null");
            									HP -= powerAttackHit;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(pattern[nextPattern] == 0 && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	waitTiming = false;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																	Color("null");
          												HP -= powerAttackHit;
																	waitTiming = false;
																	waitTime = startWaitTime;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																break;
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if(pattern[nextPattern] == 2 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(pattern[nextPattern] == 3 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monName + " did " + attack + " hp to you!");
															Color("null");
            									HP -= attack;
															WILL -= Convert.ToInt32(attack - ATK/6);
														break;
													}
												}
											}
											//Weight
											else if(hasWeight == true)
											{
												switch(weight[0])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[0] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[0] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[0] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[0] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[0] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;
													
													case 1:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[0] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[0] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[0] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[0] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[1])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[1] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[1] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[1] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[1] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[1] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[1] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[1] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[1] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[1] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[2])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[2] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[2] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[2] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[2] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[2] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[2] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[2] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[2] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[2] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[3])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[3] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[3] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[3] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[3] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[3] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[3] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[3] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[3] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[3] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;
												}
												re = rando.Next(1, 101);
												if(waitTime <= 0 && waitTiming == true)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You somehow dodged " + monName + "'s POWER Attack!");
															waitTime = startWaitTime;
															Color("null");
														break;

														default:
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
															Color("null");
            									HP -= powerAttackHit;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(re <= weightAmount[0] && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = rando.Next(0, 2);
															if(re == 0)
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monName + "'s POWER Attack!");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
															else
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monName + "'s POWER Attack!");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if( re > weightAmount[0] && re <= weightAmount[1] && waitTiming == false)
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monName + " did " + attack + " hp to you!");
															Color("null");
            									HP -= attack;
															WILL -= Convert.ToInt32(attack - ATK/6);
														break;
													}
												}
												else if(re > weightAmount[1] && re <= weightAmount[2] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(re > weightAmount[2] && re <= weightAmount[3] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monName + " did " + attack + " hp to you!");
															Color("null");
            									HP -= attack;
															WILL -= Convert.ToInt32(attack - ATK/6);
														break;
													}
												}
												weightAmount = new float[] {25, 50, 75, 100};
												/*
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;
															
															case 2:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to you!");
																Color("null");
            										HP -= attack;
																WILL -= Convert.ToInt32(attack - ATK/6);
															break;
														}
													break;
													case 1:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 2:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 3:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																Color("null");
            										fMark0 -= attack;
																WILL -= Convert.ToInt32(attack - ATK/8);
															break;
														}
													break;
												}
												*/
											}
										}
									}
									else if(turns4[i] == SPE)
									{
										//player death check
										DeathHandler();
										//player
										int re = rando.Next(1, 13);
										switch(re)//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
										{
											case 9:
											case 1: //weak
												Space();
												Color("yellow");
												if(isDefending == false)
												{
													Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
													Color("null");
													hp -= (int) ATK * 2/3;
													WILL += 5;
												}
												else if(isDefending == true)
												{
													Writer("You chose attack! While " + monName + " was defending, it still lost " + (int) 2/3 * (ATK * 2/3) + " hp! That was a weak hit!");
													Color("null");
													hp -= (int) 2/3 * (ATK * 2/3);
													isDefending = false;
													WILL += 2;
												}
											break;

											case 10:
											case 8:
											case 5:
											case 6:
											case 2: //neutral
												if(isDefending == false)
												{
													Space();
													Color("green");
													Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
													Color("null");
													hp -= ATK;
													WILL += 10;
												}
												else if(isDefending == true)
												{
													Space();
													Color("green");
													Writer("You chose attack! While " + monName + " was defending, it still lost " + ATK * 2/3 + " hp!");
													Color("null");
													hp -= ATK * 2/3;
													isDefending = false;
													WILL += 5;
												}
											break;

											case 7:
											case 12:
											case 3: //critical
												if(isDefending == false)
												{
													Space();
													Color("green");
													Writer("CRITICAL HIT!");
													Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
													Color("null");
													hp -= (int) ATK * 5/3;
													WILL += 20;
												}
												else if(isDefending == true)
												{
													Space();
													Color("green");
													Writer("CRITICAL HIT!");
													Writer(monName + ", while it was defending, lost " + (int) ATK + " hp!");
													Color("null");
													hp -= (int) ATK;
													isDefending = false;
													WILL += 13;
												}
											break;

											case 11:
											case 4: //miss
												Space();
												Color("red");
												Writer("You missed! " + monName + " didn't get hit!");
												Color("null");
												WILL -= 5;
											break;
										}
									}
								}
							}
            	//end
							Color();
							nextPattern++;
							if(STATUS == "Ablaze")
							{
								Space();
								Color("red");
								Writer("You took damage from being " + STATUS + "! -3 HP");
								HP -= 3;
								DeathHandler();
								Space();
							}
							if(status == "Ablaze")
							{
								Space();
								Color("green");
								Writer(monName + " took damage from being " + status + "! -4 HP!");
								hp -= 4;
								Space();
							}
							if(statusTwo == "Ablaze")
							{
								Space();
								Color("green");
								Writer(monNameTwo + " took damage from being " + statusTwo + "! -4 HP!");
								hpTwo -= 4;
							}
							Space();
							if(enemyDown[2] == false)
							{
								Space();
								Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							}
							//choosing
            	DeathHandler();

							if(hp <= 0)
							{
								enemyDown[2] = true;
								continue;
							}

							if(enemyDown[2] == false)
							{
								Space();
								Color();
								Writer("What next? (1 - 5)");
								Space();
      					Color("cyan");
								Writer(toDo[3]);
								Color("pink");
								Writer(toDo[0]);
								Color("bold");
								Writer(toDo[4]);
								Color("blue");
      					Writer(toDo[1]);
								Color("green");
      					Writer(toDo[2]);
								Color("null");
      					Space();
      					Choose = Reader();
							}
						}

						else if (doubleBattle == true && twoEnemy == false)//double-single
						{
							DeathHandler();

							if(hp <= 0)
							{
								fighting = false;
								enemyDown[2] = true;
							}
							//turn
            	Array.Sort(turns3);
							Array.Reverse(turns3);
							for(int i = 0; i < 3; i++)
							{
								if(enemyDown[2] != true)
								{
									if(turns3[i] == SPE)
									{
										//player death check
										DeathHandler();
										//player
										int re = rando.Next(1, 13);
										switch(re)//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
										{
											case 9:
											case 1: //weak
												Space();
												Color("yellow");
												if(isDefending == false)
												{
													Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
													Color("null");
													hp -= (int) ATK * 2/3;
													WILL += 5;
												}
												else if(isDefending == true)
												{
													Writer("You chose attack! While " + monName + " was defending, it still lost " + (int) 2/3 * (ATK * 2/3) + " hp! That was a weak hit!");
													Color("null");
													hp -= (int) 2/3 * (ATK * 2/3);
													isDefending = false;
													WILL += 2;
												}
											break;

											case 10:
											case 8:
											case 5:
											case 6:
											case 2: //neutral
												if(isDefending == false)
												{
													Space();
													Color("green");
													Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
													Color("null");
													hp -= ATK;
													WILL += 10;
												}
												else if(isDefending == true)
												{
													Space();
													Color("green");
													Writer("You chose attack! While " + monName + " was defending, it still lost " + (int) ATK * 2/3 + " hp!");
													Color("null");
													hp -= (int) ATK * 2/3;
													isDefending = false;
													WILL += 5;
												}
											break;

											case 7:
											case 12:
											case 3: //critical
												if(isDefending == false)
												{
													Space();
													Color("green");
													Writer("CRITICAL HIT!");
													Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
													Color("null");
													hp -= (int) ATK * 5/3;
													WILL += 20;
												}
												else if(isDefending == true)
												{
													Space();
													Color("green");
													Writer("CRITICAL HIT!");
													Writer(monName + ", while it was defending, lost " + (int) ATK + " hp!");
													Color("null");
													hp -= (int) ATK;
													isDefending = false;
													WILL += 13;
												}
											break;

											case 11:
											case 4: //miss
												Space();
												Color("red");
												Writer("You missed! " + monName + " didn't get hit!");
												Color("null");
												WILL -= 5;
											break;
										}
									}
									else if(turns3[i] == fMark1)
									{
										//mark death check/attack
										if(fMark0 <= 0)
										{
											Space();
											Writer(fMark3 + " is beat! They can't fight!");
										}
										else if (fMark0 > 0)
										{
											if(hp > 0)
											{
												re = rando.Next(1, 13);
												switch(re)
												{
													case 12:
														Space();
														Color("red");
														Writer(fMark3 + " tried to attack, but missed!");
														Color();
													break;

													default:
														if(isDefending == false)
														{
															Space();
															Color("green");
															Writer(fMark3 + " did " + fMark2 + " damage to " + monName + "!");
															Color();
															hp -= fMark2;
														}
														else
														{
															Space();
															Color("green");
															Writer(fMark3 + " did " + (int) fMark2 * 2/3 + " damage to " + monName + ", even though it was defending!");
															Color();
															hp -= (int) fMark2 * 2/3;
														}
													break;
												}
											}
											else
											{
												enemyDown[2] = true;
											}
										}
									}
									else if(turns3[i] == speed)
									{
										//mon1 death check
										if(hp <= 0)
										{
											enemyDown[2] = true;
										}
										else
										{
											//mon1
											//Pattern
											if(hasPattern == true)
											{
												if(nextPattern > 10)
												{
													nextPattern = 10;
												}
												if(waitTime <= 0 && waitTiming == true)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to you!");
																	Color("null");
            											HP -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																break;
															}
														break;

														case 1:
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/6);
																break;
															}
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(pattern[nextPattern] == 0 && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = rando.Next(0, 2);
															switch(re)
															{
																case 0:
																	re = monRand.Next(1, 21);
																	switch(re)
																	{
																		case 1:
																			Color("green");
																			Writer("You somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		default:
																			Color("purple");
																			Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to you!");
																			Color("null");
            													HP -= powerAttackHit;
																			waitTiming = false;
																			waitTime = startWaitTime;
																			WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																		break;
																	}
																break;

																case 1:
																	re = monRand.Next(1, 21);
																	switch(re)
																	{
																		case 1:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		case 2:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		case 3:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		default:
																			Color("purple");
																			Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + fMark3 + "!");
																			Color("null");
            													fMark0 -= powerAttackHit;
																			waitTiming = false;
																			waitTime = startWaitTime;
																			WILL -= Convert.ToInt32(powerAttackHit - ATK/6);
																		break;
																	}
																break;
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if(pattern[nextPattern] == 2 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(pattern[nextPattern] == 3 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to you!");
																	Color("null");
            											HP -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/6);
																break;
															}
														break;

														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/8);
																break;
															}
														break;
													}
												}
											}
											//Weight
											else if(hasWeight == true)
											{
												switch(weight[0])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[0] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[0] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[0] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[0] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[0] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;
													
													case 1:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[0] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[0] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[0] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[0] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[1])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[1] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[1] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[1] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[1] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[1] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[1] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[1] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[1] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[1] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[2])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[2] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[2] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[2] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[2] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[2] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[2] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[2] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[2] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[2] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[3])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[3] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[3] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[3] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[3] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[3] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[3] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[3] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[3] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[3] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;
												}
												re = rando.Next(1, 101);
												if(name.Replace(" ", "") == "o")
												{
													Writer(weightAmount[0] + ", " + weightAmount[1] + ", " + weightAmount[2] + ", " + weightAmount[3] + ", re: " + re);
												}
												if(waitTime <= 0 && waitTiming == true)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															re = monRand.Next(1, 21);
															switch(re)
															{		
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																	Color("null");
            											HP -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																break;
															}
														break;

														case 1:
															re = monRand.Next(1, 21);
															switch(re)
															{		
																case 1:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/6);
																break;
															}
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(re <= weightAmount[0] && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = rando.Next(0, 2);
															if(re == 0)
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monName + "'s POWER Attack!");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
															else
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow stopped " + monName + "'s POWER Heal! Like, seriously, how??");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if( re > weightAmount[0] && re <= weightAmount[1] && waitTiming == false)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to you!");
																	Color("null");
            											HP -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/6);
																break;
															}
														break;
														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/8);
																break;
															}
														break;
													}
												}
												else if(re > weightAmount[1] && re <= weightAmount[2] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(re > weightAmount[2] && re <= weightAmount[3] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to you!");
																	Color("null");
            											HP -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/6);
																break;
															}
														break;
														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/8);
																break;
															}
														break;
													}
												}
												weightAmount = new float[] {25, 50, 75, 100};
												/*
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;
															
															case 2:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to you!");
																Color("null");
            										HP -= attack;
																WILL -= Convert.ToInt32(attack - ATK/6);
															break;
														}
													break;
													case 1:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 2:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 3:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																Color("null");
            										fMark0 -= attack;
																WILL -= Convert.ToInt32(attack - ATK/8);
															break;
														}
													break;
												}
												*/
											}
										}
									}
								}
							}
            	//end
							Color();
							switch(teamMate)
							{
								case 0:
									Mark.HEARTS = fMark_1;
									Mark.HP = fMark0;
									Mark.SPE = fMark1;
									Mark.ATK = fMark2;
									Mark.name = fMark3;
									Mark.level = fMark4;
									Mark.EXP = fMark5;
									Mark.EXPNeed = fMark6;
								break;

								case 1:
									Breys.HEARTS = fMark_1;
									Breys.HP = fMark0;
									Breys.SPE = fMark1;
									Breys.ATK = fMark2;
									Breys.name = fMark3;
									Breys.level = fMark4;
									Breys.EXP = fMark5;
									Breys.EXPNeed = fMark6;
								break;

								case 2:
									Sapphire.HEARTS = fMark_1;
									Sapphire.HP = fMark0;
									Sapphire.SPE = fMark1;
									Sapphire.ATK = fMark2;
									Sapphire.name = fMark3;
									Sapphire.level = fMark4;
									Sapphire.EXP = fMark5;
									Sapphire.EXPNeed = fMark6;
								break;

								case 3:
									Captain.HEARTS = fMark_1;
									Captain.HP = fMark0;
									Captain.SPE = fMark1;
									Captain.ATK = fMark2;
									Captain.name = fMark3;
									Captain.level = fMark4;
									Captain.EXP = fMark5;
									Captain.EXPNeed = fMark6;
								break;
							}
							if(nextPattern < 10)
							{
								nextPattern++;
							}
							if(nextPattern >= 10)
							{
								nextPattern = 0;
							}
							if(STATUS == "Ablaze")
							{
								Space();
								Color("red");
								Writer("You took damage from being " + STATUS + "! -3 HP");
								HP -= 3;
								DeathHandler();
								Space();
							}
							if(status == "Ablaze")
							{
								Space();
								Color("green");
								Writer(monName + " took damage from being " + status + "! -4 HP!");
								hp -= 4;
								Space();
							}
							if(statusTwo == "Ablaze")
							{
								Space();
								Color("green");
								Writer(monNameTwo + " took damage from being " + statusTwo + "! -4 HP!");
								hpTwo -= 4;
							}
							Space(2);
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
							//choosing
            	DeathHandler();

							if(hp <= 0)
							{
								fighting = false;
								enemyDown[2] = true;
							}

							if(enemyDown[2] != true)
							{
								Space();
								Color();
								Writer("What next? (1 - 5)");
								Space();
      					Color("cyan");
								Writer(toDo[3]);
								Color("pink");
								Writer(toDo[0]);
								Color("bold");
								Writer(toDo[4]);
								Color("blue");
      					Writer(toDo[1]);
								Color("green");
      					Writer(toDo[2]);
								Color("null");
      					Space();
      					Choose = Reader();
							}
						}
						else if (doubleBattle == true && twoEnemy == true)//double-double
						{
							Array.Sort(turns2);
							Array.Reverse(turns2);
							//turn 1
							for(int i = 0; i < 4; i++)
							{
								if(enemyDown[2] == false)
								{
									if(turns2[i] == SPE)
									{
										//player death check
										DeathHandler();
										//monster death checks
										if(hp <= 0)
										{
											Space(2);
											enemyDown[1] = true;
											stopText[1] = true;
											if(enemyDown[0] == true)
											{
												Writer(monName + " has been defeated! We win!");
												enemyDown[2] = true;
											}
										}
										if(hpTwo <= 0)
										{
											Space(2);
											enemyDown[0] = true;
											stopText[0] = true;
											if(enemyDown[1] == true)
											{
												Writer(monNameTwo + " has been defeated! We win!");
												enemyDown[2] = true;
											}
										}
										//player
										if(enemyDown[2] == false)
										{
											stop = false;
											while(stop == false)
											{
												Space();
												Writer("Who do you want to fight? (1 - 2)");
												Space();
												//display of choices
												if(enemyDown[0] == true && enemyDown[1] == false)
												{
													Writer("1: " + monName);
												}
												else if(enemyDown[1] == true && enemyDown[0] == false)
												{
													Writer("2: " + monNameTwo);
												}
												else if(enemyDown[0] == false && enemyDown[1] == false)
												{
													Writer("1: " + monName);
													Writer("2: " + monNameTwo);
												}
												Space();
												option = Reader();
												//Logic
												switch(option)
												{
													case "1":
													case "1:":
													case "1: ":
														int re = rando.Next(1, 13);
														if(enemyDown[1] == true)
														{
															Writer("The enemy is already dead!");
														}
														else
														{
															switch(re)//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
															{
																case 9:
																case 1: //weak
																	Space();
																	Color("yellow");
																	if(isDefending == false)
																	{
																		Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
																		Color("null");
																		hp -= (int) ATK * 2/3;
																		WILL += 5;
																	}
																	else if(isDefending == true)
																	{
																		Writer("You chose attack! While " + monName + " was defending, it still lost " + (int) 2/3 * (ATK * 2/3) + " hp! That was a weak hit!");
																		Color("null");
																		hp -= (int) 2/3 * (ATK * 2/3);
																		isDefending = false;
																		WILL += 2;
																	}
																break;

																case 10:
																case 8:
																case 5:
																case 6:
																case 2: //neutral
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
																		Color("null");
																		hp -= ATK;
																		WILL += 10;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! While " + monName + " was defending, it still lost " + ATK * 2/3 + " hp!");
																		Color("null");
																		hp -= ATK * 2/3;
																		isDefending = false;
																		WILL += 5;
																	}
																break;

																case 7:
																case 12:
																case 3: //critical
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
																		Color("null");
																		hp -= (int) ATK * 5/3;
																		WILL += 20;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monName + ", while it was defending, lost " + (int) ATK + " hp!");
																		Color("null");
																		hp -= (int) ATK;
																		isDefending = false;
																		WILL += 13;
																	}
																break;

																case 11:
																case 4: //miss
																	Space();
																	Color("red");
																	Writer("You missed! " + monName + " didn't get hit!");
																	Color("null");
																	WILL -= 5;
																break;
															}
														}
														stop = true;
													break;

													case "2":
													case "2:":
													case "2: ":
														re = rando.Next(1, 13);
														if(enemyDown[0] == true)
														{
															Writer("The enemy is already dead!");
														}
														else
														{
															switch(re)//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
															{
																case 9:
																case 1: //weak
																	Space();
																	Color("yellow");
																	if(isDefending == false)
																	{
																		Writer("You chose attack! " + monNameTwo + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
																		Color("null");
																		hpTwo -= (int) ATK * 2/3;
																		WILL += 5;
																	}
																	else if(isDefending == true)
																	{
																		Writer("You chose attack! While " + monNameTwo + " was defending, it still lost " + (int) 2/3 * (ATK * 2/3) + " hp! That was a weak hit!");
																		Color("null");
																		hpTwo -= (int) 2/3 * (ATK * 2/3);
																		isDefending = false;
																		WILL += 2;
																	}
																break;

																case 10:
																case 8:
																case 5:
																case 6:
																case 2: //neutral
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! " + monNameTwo + " lost " + ATK + " hp!");
																		Color("null");
																		hpTwo -= ATK;
																		WILL += 10;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! While " + monNameTwo + " was defending, it still lost " + ATK * 2/3 + " hp!");
																		Color("null");
																		hpTwo -= ATK * 2/3;
																		isDefending = false;
																		WILL += 5;
																	}
																break;

																case 7:
																case 12:
																case 3: //critical
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monNameTwo + " lost " + (int) ATK * 5/3 + " hp!");
																		Color("null");
																		hpTwo -= (int) ATK * 5/3;
																		WILL += 20;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monNameTwo + ", while it was defending, lost " + (int) ATK + " hp!");
																		Color("null");
																		hpTwo -= (int) ATK;
																		isDefending = false;
																		WILL += 13;
																	}
																break;

																case 11:
																case 4: //miss
																	Space();
																	Color("red");
																	Writer("You missed! " + monNameTwo + " didn't get hit!");
																	Color("null");
																	WILL -= 5;
																break;
															}
														}
														stop = true;
													break;

													default:
														Space();
														ErrorWrite();
														Space();
														Writer("Correction: Write 1 or 2!");
														Space();
													break;
												}
											}
										}
									}
									else if(turns2[i] == fMark1)
									{
										//mark death check/attack
										if(fMark0 <= 0)
										{
											Space();
											Writer(fMark3 + " is beat! He can't fight!");
										}
										else if (fMark0 > 0)
										{
											re = rando.Next(0, 2);
											if(re == 0)
											{
												if(hp > 0)
												{
													re = rando.Next(1, 13);
													switch(re)
													{
														case 12:
															Space();
															Color("red");
															Writer(fMark3 + " tried to attack, but missed!");
															Color();
														break;

														default:
															if(isDefending == false)
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + fMark2 + " damage to " + monName + "!");
																Color();
																hp -= fMark2;
															}
															else
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + (int) fMark2 * 2/3 + " damage to " + monName + ", even though it was defending!");
																Color();
																hp -= (int) fMark2 * 2/3;
															}
														break;
													}
												}
												else if (hp <= 0 && hpTwo > 0)
												{
													re = rando.Next(1, 13);
													switch(re)
													{
														case 12:
															Space();
															Color("red");
															Writer(fMark3 + " tried to attack, but missed!");
															Color();
														break;
	
														default:
															if(isDefending == false)
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + fMark2 + " damage to " + monNameTwo + "!");
																Color();
																hpTwo -= fMark2;
															}
															else
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + (int) fMark2 * 2/3 + " damage to " + monNameTwo + ", even though it was defending!");
																Color();
																hpTwo -= (int) fMark2 * 2/3;
															}
														break;
													}
												}
											}
											else if (re == 1)
											{
												if(hpTwo > 0)
												{
													re = rando.Next(1, 13);
													switch(re)
													{
														case 12:
															Space();
															Color("red");
															Writer(fMark3 + " tried to attack, but missed!");
															Color();
														break;
	
														default:
															if(isDefending == false)
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + fMark2 + " damage to " + monNameTwo + "!");
																Color();
																hpTwo -= fMark2;
															}
															else
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + (int) fMark2 * 2/3 + " damage to " + monNameTwo + ", even though it was defending!");
																Color();
																hpTwo -= (int) fMark2 * 2/3;
															}
														break;
													}
												}
												else if(hpTwo <= 0 && hp > 0)
												{
													re = rando.Next(1, 13);
													switch(re)
													{
														case 12:
															Space();
															Color("red");
															Writer(fMark3 + " tried to attack, but missed!");
															Color();
														break;

														default:
															if(isDefending == false)
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + fMark2 + " damage to " + monName + "!");
																Color();
																hp -= fMark2;
															}
															else
															{
																Space();
																Color("green");
																Writer(fMark3 + " did " + (int) fMark2 * 2/3 + " damage to " + monName + ", even though it was defending!");
																Color();
																hp -= (int) fMark2 * 2/3;
															}
														break;
													}
												}
											}
										}
									}
									else if(turns2[i] == speed)
									{
										//mon1 death check
										if(hp <= 0)
										{
											Space(2);
											enemyDown[1] = true;
											if(enemyDown[0] == false)
											{
												if(stopText[1] == false)
												{
													Writer(monName + " has been defeated! One down, one to go!");
													stopText[1] = true;
												}

											}
											else if(enemyDown[0] == true)
											{
												Writer(monName + " has been defeated! We win!");
												fighting = false;
												enemyDown[2] = true;
											}
										}
										else
										{
											//mon1
											//Pattern
											if(hasPattern == true)
											{
												if(nextPattern > 10)
												{
													nextPattern = 10;
												}
												if(waitTime <= 0 && waitTiming == true)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to you!");
																	Color("null");
            											HP -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																break;
															}
														break;

														case 1:
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/6);
																break;
															}
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(pattern[nextPattern] == 0 && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = rando.Next(0, 2);
															switch(re)
															{
																case 0:
																	re = monRand.Next(1, 21);
																	switch(re)
																	{
																		case 1:
																			Color("green");
																			Writer("You somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		default:
																			Color("purple");
																			Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to you!");
																			Color("null");
            													HP -= powerAttackHit;
																			waitTiming = false;
																			waitTime = startWaitTime;
																			WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																		break;
																	}
																break;

																case 1:
																	re = monRand.Next(1, 21);
																	switch(re)
																	{
																		case 1:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		case 2:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		case 3:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																			waitTime = startWaitTime;
																			waitTiming = false;
																			Color("null");
																		break;

																		default:
																			Color("purple");
																			Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + fMark3 + "!");
																			Color("null");
            													fMark0 -= powerAttackHit;
																			waitTiming = false;
																			waitTime = startWaitTime;
																			WILL -= Convert.ToInt32(powerAttackHit - ATK/6);
																		break;
																	}
																break;
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if(pattern[nextPattern] == 2 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(pattern[nextPattern] == 3 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to you!");
																	Color("null");
            											HP -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/6);
																break;
															}
														break;

														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/8);
																break;
															}
														break;
													}
												}
											}
											//Weight
											else if(hasWeight == true)
											{
												switch(weight[0])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[0] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[0] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[0] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[0] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[0] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;
													
													case 1:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[0] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[0] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[0] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[0] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[1])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[1] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[1] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[1] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[1] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[1] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[1] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[1] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[1] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[1] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[2])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[2] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[2] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[2] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[2] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[2] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[2] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[2] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[2] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[2] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[3])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[3] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[3] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[3] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[3] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[3] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[3] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[3] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[3] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[3] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;
												}
												re = rando.Next(1, 101);
												Writer(weightAmount[0] + ", " + weightAmount[1] + ", " + weightAmount[2] + ", " + weightAmount[3] + ", re: " + re);
												if(waitTime <= 0 && waitTiming == true)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															re = monRand.Next(1, 21);
															switch(re)
															{		
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																	Color("null");
            											HP -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																break;
															}
														break;

														case 1:
															re = monRand.Next(1, 21);
															switch(re)
															{		
																case 1:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= powerAttackHit;
																	waitTime = startWaitTime;
																	waitTiming = false;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/6);
																break;
															}
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(re <= weightAmount[0] && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = rando.Next(0, 2);
															if(re == 0)
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monName + "'s POWER Attack!");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
															else
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow stopped " + monName + "'s POWER Heal! Like, seriously, how??");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if( re > weightAmount[0] && re <= weightAmount[1] && waitTiming == false)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to you!");
																	Color("null");
            											HP -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/6);
																break;
															}
														break;
														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/8);
																break;
															}
														break;
													}
												}
												else if(re > weightAmount[1] && re <= weightAmount[2] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(re > weightAmount[2] && re <= weightAmount[3] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to you!");
																	Color("null");
            											HP -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/6);
																break;
															}
														break;
														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monName + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attack;
																	WILL -= Convert.ToInt32(attack - ATK/8);
																break;
															}
														break;
													}
												}
												weightAmount = new float[] {25, 50, 75, 100};
												/*
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;
															
															case 2:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to you!");
																Color("null");
            										HP -= attack;
																WILL -= Convert.ToInt32(attack - ATK/6);
															break;
														}
													break;
													case 1:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 2:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 3:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																Color("null");
            										fMark0 -= attack;
																WILL -= Convert.ToInt32(attack - ATK/8);
															break;
														}
													break;
												}
												*/
											}
										}
									}
									else if(turns2[i] == speedTwo)
									{
										//mon2 death check
										if(hpTwo <= 0)
										{
											Space(2);
											enemyDown[0] = true;
											if(enemyDown[1] == false)
											{
												if(stopText[0] == false)
												{
													Writer(monNameTwo + " has been defeated! One down, one to go!");
													stopText[0] = true;
												}	
											}
											else if(enemyDown[1] == true)
											{
												Writer(monNameTwo + " has been defeated! We win!");
												fighting = false;
												enemyDown[2] = true;
											}
										}
										else
										{
											//mon2
											//Pattern
											if(hasPatternTwo == true)
											{
												if(nextPattern > 10)
												{
													nextPattern = 10;
												}
												if(waitTimeTwo <= 0 && waitTimingTwo == true)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to you!");
																	Color("null");
            											HP -= powerAttackHitTwo;
																	waitTimeTwo = startWaitTimeTwo;
																	waitTimingTwo = false;
																	WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																break;
															}
														break;

														case 1:
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= powerAttackHitTwo;
																	waitTimeTwo = startWaitTimeTwo;
																	waitTimingTwo = false;
																	WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/6);
																break;
															}
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTimeTwo--;
													Space();
													Color("blue");
													Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
													Color();
												}
												else if(patternTwo[nextPattern] == 0 && waitTimingTwo == false)
												{
													if(waitTimeTwo <= 0)
													{
														if(isHealingTwo == false)
														{
															Space();
															re = rando.Next(0, 2);
															switch(re)
															{
																case 0:
																	re = monRand.Next(1, 21);
																	switch(re)
																	{
																		case 1:
																			Color("green");
																			Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
																			waitTimeTwo = startWaitTimeTwo;
																			waitTimingTwo = false;
																			Color("null");
																		break;

																		default:
																			Color("purple");
																			Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to you!");
																			Color("null");
            													HP -= powerAttackHitTwo;
																			waitTimingTwo = false;
																			waitTimeTwo = startWaitTimeTwo;
																			WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																		break;
																	}
																break;

																case 1:
																	re = monRand.Next(1, 21);
																	switch(re)
																	{
																		case 1:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																			waitTimeTwo = startWaitTimeTwo;
																			waitTimingTwo = false;
																			Color("null");
																		break;

																		case 2:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																			waitTimeTwo = startWaitTimeTwo;
																			waitTimingTwo = false;
																			Color("null");
																		break;

																		case 3:
																			Color("green");
																			Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																			waitTimeTwo = startWaitTimeTwo;
																			waitTimingTwo = false;
																			Color("null");
																		break;

																		default:
																			Color("purple");
																			Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to " + fMark3 + "!");
																			Color("null");
            													fMark0 -= powerAttackHitTwo;
																			waitTimingTwo = false;
																			waitTimeTwo = startWaitTimeTwo;
																			WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/6);
																		break;
																	}
																break;
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monNameTwo + " used " + powerAttackTwo + "Healing an unpleasant " + powerAttackHealTwo + " HP!");
															Color("null");
															hpTwo += powerAttackHealTwo;
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHealTwo/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monNameTwo + " is preparing for a POWER Attack! " + waitTimeTwo + " turns left until it happens!");
														if(waitTimingTwo == false)
														{
															waitTimeTwo--;
														}
														waitTimingTwo = true;
														Color();
													}
												}
												else if(patternTwo[nextPattern] == 2 && waitTimingTwo == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monNameTwo + " is defending from attack!");
													isDefendingTwo = true;
												}
												else if(pattern[nextPattern] == 3 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monNameTwo + " is healing itself!");
													hpTwo += Convert.ToInt32(hpTwo/4);
												}
												else
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monNameTwo + " did " + attackTwo + " hp to you!");
																	Color("null");
            											HP -= attackTwo;
																	WILL -= Convert.ToInt32(attackTwo - ATK/6);
																break;
															}
														break;

														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monNameTwo + " did " + attackTwo + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attackTwo;
																	WILL -= Convert.ToInt32(attackTwo - ATK/8);
																break;
															}
														break;
													}
												}
											}
											//Weight
											else if(hasWeightTwo == true)
											{
												switch(weightTwo[0])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[0] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[0] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[0] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[0] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[0] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;
													
													case 1:
														weightAmountTwo[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[0] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[0] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[0] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[0] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weightTwo[1])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[1] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[1] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[1] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[1] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[1] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmountTwo[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[1] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[1] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[1] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[1] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weightTwo[2])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[2] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[2] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[2] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[2] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[2] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmountTwo[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[2] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[2] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[2] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[2] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weightTwo[3])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[3] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[3] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[3] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[3] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[3] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmountTwo[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[3] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[3] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[3] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[3] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;
												}
												re = rando.Next(1, 101);
												if(name.Replace(" ", "") == "o")
												{
													Writer(weightAmountTwo[0] + ", " + weightAmountTwo[1] + ", " + weightAmountTwo[2] + ", " + weightAmountTwo[3] + ", re: " + re);
												}
												if(waitTime <= 0 && waitTiming == true)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															re = monRand.Next(1, 21);
															switch(re)
															{		
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																	Color("null");
            											HP -= powerAttackHitTwo;
																	waitTimeTwo = startWaitTimeTwo;
																	waitTimingTwo = false;
																	WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																break;
															}
														break;

														case 1:
															re = monRand.Next(1, 21);
															switch(re)
															{		
																case 1:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= powerAttackHitTwo;
																	waitTimeTwo = startWaitTimeTwo;
																	waitTimingTwo = false;
																	WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/6);
																break;
															}
														break;
													}
												}
												else if(waitTimingTwo == true && waitTimeTwo > 0)
												{
													waitTimeTwo--;
													Space();
													Color("blue");
													Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
													Color();
												}
												else if(re <= weightAmountTwo[0] && waitTimingTwo == false)
												{
													if(waitTimeTwo <= 0)
													{
														if(isHealingTwo == false)
														{
															Space();
															re = rando.Next(0, 2);
															if(re == 0)
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
																		waitTimeTwo = startWaitTimeTwo;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																		Color("null");
            												HP -= powerAttackHitTwo;
																		waitTimingTwo = false;
																		waitTimeTwo = startWaitTimeTwo;
																		WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																	break;
																}
															}
															else
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow stopped " + monNameTwo + "'s POWER Heal! Like, seriously, how??");
																		waitTimeTwo = startWaitTimeTwo;
																		waitTimingTwo = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																		Color("null");
            												HP -= powerAttackHitTwo;
																		waitTimingTwo = false;
																		waitTimeTwo = startWaitTimeTwo;
																		WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																	break;
																}
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monNameTwo + " used " + powerAttackTwo + "Healing an unpleasant " + powerAttackHealTwo + " HP!");
															Color("null");
															hpTwo += powerAttackHealTwo;
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHealTwo/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monNameTwo + " is preparing for a POWER Attack! " + waitTimeTwo + " turns left until it happens!");
														if(waitTimingTwo == false)
														{
															waitTimeTwo--;
														}
														waitTimingTwo = true;
														Color();
													}
												}
												else if( re > weightAmountTwo[0] && re <= weightAmountTwo[1] && waitTimingTwo == false)
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monNameTwo + " did " + attackTwo + " hp to you!");
																	Color("null");
            											HP -= attackTwo;
																	WILL -= Convert.ToInt32(attackTwo - ATK/6);
																break;
															}
														break;

														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monNameTwo + " did " + attackTwo + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attackTwo;
																	WILL -= Convert.ToInt32(attackTwo - ATK/8);
																break;
															}
														break;
													}
												}
												else if(re > weightAmountTwo[1] && re <= weightAmountTwo[2] && waitTimingTwo == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monNameTwo + " is defending from attack!");
													isDefendingTwo = true;
												}
												else if(re > weightAmountTwo[2] && re <= weightAmountTwo[3] && waitTimingTwo == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monNameTwo + " is healing itself!");
													hpTwo += Convert.ToInt32(hpTwo/4);
												}
												else
												{
													re = rando.Next(0, 2);
													switch(re)
													{
														case 0:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer("You dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monNameTwo + " did " + attackTwo + " hp to you!");
																	Color("null");
            											HP -= attackTwo;
																	WILL -= Convert.ToInt32(attackTwo - ATK/6);
																break;
															}
														break;

														case 1:
															Space();
															re = monRand.Next(1, 11);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 2:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																case 3:
																	Color("green");
																	Writer(fMark3 + " dodged " + monNameTwo + "'s attack!");
																	Color("null");
																break;

																default:
																	Color("red");
																	Writer(monNameTwo + " did " + attackTwo + " hp to " + fMark3 + "!");
																	Color("null");
            											fMark0 -= attackTwo;
																	WILL -= Convert.ToInt32(attackTwo - ATK/8);
																break;
															}
														break;
													}
												}
												weightAmountTwo = new float[] {25, 50, 75, 100};
												/*
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;
															
															case 2:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to you!");
																Color("null");
            										HP -= attack;
																WILL -= Convert.ToInt32(attack - ATK/6);
															break;
														}
													break;
													case 1:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 2:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 3:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																Color("null");
            										fMark0 -= attack;
																WILL -= Convert.ToInt32(attack - ATK/8);
															break;
														}
													break;
												}
												*/
											}
										}
									}
								}
							}
							
							//end
							Color();
							switch(teamMate)
							{
								case 0:
									Mark.HEARTS = fMark_1;
									Mark.HP = fMark0;
									Mark.SPE = fMark1;
									Mark.ATK = fMark2;
									Mark.name = fMark3;
									Mark.level = fMark4;
									Mark.EXP = fMark5;
									Mark.EXPNeed = fMark6;
								break;

								case 1:
									Breys.HEARTS = fMark_1;
									Breys.HP = fMark0;
									Breys.SPE = fMark1;
									Breys.ATK = fMark2;
									Breys.name = fMark3;
									Breys.level = fMark4;
									Breys.EXP = fMark5;
									Breys.EXPNeed = fMark6;
								break;

								case 2:
									Sapphire.HEARTS = fMark_1;
									Sapphire.HP = fMark0;
									Sapphire.SPE = fMark1;
									Sapphire.ATK = fMark2;
									Sapphire.name = fMark3;
									Sapphire.level = fMark4;
									Sapphire.EXP = fMark5;
									Sapphire.EXPNeed = fMark6;
								break;

								case 3:
									Captain.HEARTS = fMark_1;
									Captain.HP = fMark0;
									Captain.SPE = fMark1;
									Captain.ATK = fMark2;
									Captain.name = fMark3;
									Captain.level = fMark4;
									Captain.EXP = fMark5;
									Captain.EXPNeed = fMark6;
								break;
							}
							Space(2);
							if(hp > 0 && hpTwo > 0)
							{
								Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, " + monNameTwo + " has " + hpTwo + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
							}
							else if(hp <= 0 && hpTwo > 0)
							{
								Writer("You have " + HP + " HP, " + monNameTwo + " has " + hpTwo + " HP, and " + fMark3+ " has " + fMark0 + " HP.");
							}
							else if(hp > 0 && hpTwo <= 0)
							{
								Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
							}
							//death
            	DeathHandler();
 
							if(hp <= 0)
							{
								Space(2);
								enemyDown[1] = true;
								if(enemyDown[1] == true)
								{
									Writer(monName + " and " + monNameTwo + " have been defeated! We win!");
									stopText[2] = true;
									enemyDown[2] = true;
								}
							}
							if(hpTwo <= 0)
							{
								Space(2);
								enemyDown[0] = true;
								if(enemyDown[1] == true)
								{
									if(stopText[2] == false)
									{
										Writer(monNameTwo + " and " + monName + " have been defeated! We win!");
										stopText[2] = true;
									}
									enemyDown[2] = true;
								}
							}

							if(enemyDown[2] != true)
							{
								//choosing
								Space();
								Color();
								Writer("What next? (1 - 5)");
								Space();
      					Color("cyan");
								Writer(toDo[3]);
								Color("pink");
								Writer(toDo[0]);
								Color("bold");
								Writer(toDo[4]);
								Color("blue");
      					Writer(toDo[1]);
								Color("green");
      					Writer(toDo[2]);
								Color("null");
      					Space();
      					Choose = Reader();
							}
						}
						else if(doubleBattle == false && twoEnemy == true)//single-double
						{
							Array.Sort(turns);
							Array.Reverse(turns);
							//battle system
							DeathHandler();
							for(int i = 0; i < 3; i++)
							{
								if(enemyDown[2] == false)
								{
									if(turns2[i] == SPE)
									{
										//player death check
										DeathHandler();
										//monster death checks
										if(hp <= 0)
										{
											Space(2);
											enemyDown[1] = true;
											stopText[1] = true;
											if(enemyDown[0] == true)
											{
												Writer(monName + " has been defeated! We win!");
												enemyDown[2] = true;
											}
										}
										if(hpTwo <= 0)
										{
											Space(2);
											enemyDown[0] = true;
											stopText[0] = true;
											if(enemyDown[1] == true)
											{
												Writer(monNameTwo + " has been defeated! We win!");
												enemyDown[2] = true;
											}
										}
										//player
										if(enemyDown[2] == false)
										{
											stop = false;
											while(stop == false)
											{
												Space();
												Writer("Who do you want to fight? (1 - 2)");
												Space();
												//display of choices
												if(enemyDown[0] == true && enemyDown[1] == false)
												{
													Writer("1: " + monName);
												}
												else if(enemyDown[1] == true && enemyDown[0] == false)
												{
													Writer("2: " + monNameTwo);
												}
												else if(enemyDown[0] == false && enemyDown[1] == false)
												{
													Writer("1: " + monName);
													Writer("2: " + monNameTwo);
												}
												Space();
												option = Reader();
												//Logic
												switch(option)
												{
													case "1":
													case "1:":
													case "1: ":
														int re = rando.Next(1, 13);
														if(enemyDown[1] == true)
														{
															Writer("The enemy is already dead!");
														}
														else
														{
															switch(re)//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
															{
																case 9:
																case 1: //weak
																	Space();
																	Color("yellow");
																	if(isDefending == false)
																	{
																		Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
																		Color("null");
																		hp -= (int) ATK * 2/3;
																		WILL += 5;
																	}
																	else if(isDefending == true)
																	{
																		Writer("You chose attack! While " + monName + " was defending, it still lost " + (int) 2/3 * (ATK * 2/3) + " hp! That was a weak hit!");
																		Color("null");
																		hp -= (int) 2/3 * (ATK * 2/3);
																		isDefending = false;
																		WILL += 2;
																	}
																break;

																case 10:
																case 8:
																case 5:
																case 6:
																case 2: //neutral
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
																		Color("null");
																		hp -= ATK;
																		WILL += 10;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! While " + monName + " was defending, it still lost " + ATK * 2/3 + " hp!");
																		Color("null");
																		hp -= ATK * 2/3;
																		isDefending = false;
																		WILL += 5;
																	}
																break;

																case 7:
																case 12:
																case 3: //critical
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
																		Color("null");
																		hp -= (int) ATK * 5/3;
																		WILL += 20;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monName + ", while it was defending, lost " + (int) ATK + " hp!");
																		Color("null");
																		hp -= (int) ATK;
																		isDefending = false;
																		WILL += 13;
																	}
																break;

																case 11:
																case 4: //miss
																	Space();
																	Color("red");
																	Writer("You missed! " + monName + " didn't get hit!");
																	Color("null");
																	WILL -= 5;
																break;
															}
														}
														stop = true;
													break;

													case "2":
													case "2:":
													case "2: ":
														re = rando.Next(1, 13);
														if(enemyDown[0] == true)
														{
															Writer("The enemy is already dead!");
														}
														else
														{
															switch(re)//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
															{
																case 9:
																case 1: //weak
																	Space();
																	Color("yellow");
																	if(isDefending == false)
																	{
																		Writer("You chose attack! " + monNameTwo + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
																		Color("null");
																		hpTwo -= (int) ATK * 2/3;
																		WILL += 5;
																	}
																	else if(isDefending == true)
																	{
																		Writer("You chose attack! While " + monNameTwo + " was defending, it still lost " + (int) 2/3 * (ATK * 2/3) + " hp! That was a weak hit!");
																		Color("null");
																		hpTwo -= (int) 2/3 * (ATK * 2/3);
																		isDefending = false;
																		WILL += 2;
																	}
																break;

																case 10:
																case 8:
																case 5:
																case 6:
																case 2: //neutral
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! " + monNameTwo + " lost " + ATK + " hp!");
																		Color("null");
																		hpTwo -= ATK;
																		WILL += 10;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("You chose attack! While " + monNameTwo + " was defending, it still lost " + ATK * 2/3 + " hp!");
																		Color("null");
																		hpTwo -= ATK * 2/3;
																		isDefending = false;
																		WILL += 5;
																	}
																break;

																case 7:
																case 12:
																case 3: //critical
																	if(isDefending == false)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monNameTwo + " lost " + (int) ATK * 5/3 + " hp!");
																		Color("null");
																		hpTwo -= (int) ATK * 5/3;
																		WILL += 20;
																	}
																	else if(isDefending == true)
																	{
																		Space();
																		Color("green");
																		Writer("CRITICAL HIT!");
																		Writer(monNameTwo + ", while it was defending, lost " + (int) ATK + " hp!");
																		Color("null");
																		hpTwo -= (int) ATK;
																		isDefending = false;
																		WILL += 13;
																	}
																break;

																case 11:
																case 4: //miss
																	Space();
																	Color("red");
																	Writer("You missed! " + monNameTwo + " didn't get hit!");
																	Color("null");
																	WILL -= 5;
																break;
															}
														}
														stop = true;
													break;

													default:
														Space();
														ErrorWrite();
														Space();
														Writer("Correction: Write 1 or 2!");
														Space();
													break;
												}
											}
										}
									}
									else if(turns2[i] == speed)
									{
										//mon1 death check
										if(hp <= 0)
										{
											Space(2);
											enemyDown[1] = true;
											if(enemyDown[0] == false)
											{
												if(stopText[1] == false)
												{
													Writer(monName + " has been defeated! One down, one to go!");
													stopText[1] = true;
												}

											}
											else if(enemyDown[0] == true)
											{
												Writer(monName + " has been defeated! We win!");
												fighting = false;
												enemyDown[2] = true;
											}
										}
										else
										{
											//mon1
											//Pattern
											if(hasPattern == true)
											{
												if(waitTime <= 0 && waitTiming == true)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You somehow dodged " + monName + "'s POWER Attack!");
															waitTime = startWaitTime;
															Color("null");
														break;

														default:
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
															Color("null");
            									HP -= powerAttackHit;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(pattern[nextPattern] == 0 && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monName + "'s POWER Attack!");
																	waitTime = startWaitTime;
																	waitTiming = false;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																	Color("null");
          												HP -= powerAttackHit;
																	waitTiming = false;
																	waitTime = startWaitTime;
																	WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																break;
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if(pattern[nextPattern] == 2 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(pattern[nextPattern] == 3 && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monName + " did " + attack + " hp to you!");
															Color("null");
            									HP -= attack;
															WILL -= Convert.ToInt32(attack - ATK/6);
														break;
													}
												}
											}
											//Weight
											else if(hasWeight == true)
											{
												switch(weight[0])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[0] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[0] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[0] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[0] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[0] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;
													
													case 1:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[0] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[0] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[0] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[0] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[1])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[1] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[1] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[1] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[1] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[1] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[1] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[1] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[1] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[1] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[2])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[2] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[2] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[2] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[2] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[2] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[2] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[2] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[2] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[2] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmount[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weight[3])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmount[3] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmount[3] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmount[3] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmount[3] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmount[3] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] += 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] += 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmount[3] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmount[3] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmount[3] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmount[3] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmount[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[0] != -5)
																	{
																		weightAmount[0] -= 5;
																	}
																break;

																case 1:
																	if(weight[1] != -5)
																	{
																		weightAmount[1] -= 5;
																	}
																break;

																case 2:
																	if(weight[2] != -5)
																	{
																		weightAmount[2] -= 5;
																	}
																break;
															}
														}
													break;
												}
												re = rando.Next(1, 101);
												if(waitTime <= 0 && waitTiming == true)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You somehow dodged " + monName + "'s POWER Attack!");
															waitTime = startWaitTime;
															Color("null");
														break;

														default:
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
															Color("null");
            									HP -= powerAttackHit;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														break;
													}
												}
												else if(waitTiming == true && waitTime > 0)
												{
													waitTime--;
													Space();
													Color("blue");
													Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
													Color();
												}
												else if(re <= weightAmount[0] && waitTiming == false)
												{
													if(waitTime <= 0)
													{
														if(isHealing == false)
														{
															Space();
															re = rando.Next(0, 2);
															if(re == 0)
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monName + "'s POWER Attack!");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
															else
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monName + "'s POWER Attack!");
																		waitTime = startWaitTime;
																		waitTiming = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																		Color("null");
            												HP -= powerAttackHit;
																		waitTiming = false;
																		waitTime = startWaitTime;
																		WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
																	break;
																}
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monName + " used " + powerAttack + "Healing an unpleasant " + powerAttackHeal + " HP!");
															Color("null");
															hp += powerAttackHeal;
															waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHeal/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monName + " is preparing for a POWER Attack! " + waitTime + " turns left until it happens!");
														if(waitTiming == false)
														{
															waitTime--;
														}
														waitTiming = true;
														Color();
													}
												}
												else if( re > weightAmount[0] && re <= weightAmount[1] && waitTiming == false)
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monName + " did " + attack + " hp to you!");
															Color("null");
            									HP -= attack;
															WILL -= Convert.ToInt32(attack - ATK/6);
														break;
													}
												}
												else if(re > weightAmount[1] && re <= weightAmount[2] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefending = true;
												}
												else if(re > weightAmount[2] && re <= weightAmount[3] && waitTiming == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is healing itself!");
													hp += Convert.ToInt32(hp/4);
												}
												else
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monName + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monName + " did " + attack + " hp to you!");
															Color("null");
            									HP -= attack;
															WILL -= Convert.ToInt32(attack - ATK/6);
														break;
													}
												}
												weightAmount = new float[] {25, 50, 75, 100};
												/*
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;
															
															case 2:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to you!");
																Color("null");
            										HP -= attack;
																WILL -= Convert.ToInt32(attack - ATK/6);
															break;
														}
													break;
													case 1:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 2:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 3:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																Color("null");
            										fMark0 -= attack;
																WILL -= Convert.ToInt32(attack - ATK/8);
															break;
														}
													break;
												}
												*/
											}
										}
									}
									else if(turns2[i] == speedTwo)
									{
										//mon2 death check
										if(hpTwo <= 0)
										{
											Space(2);
											enemyDown[0] = true;
											if(enemyDown[1] == false)
											{
												if(stopText[0] == false)
												{
													Writer(monNameTwo + " has been defeated! One down, one to go!");
													stopText[0] = true;
												}	
											}
											else if(enemyDown[1] == true)
											{
												Writer(monNameTwo + " has been defeated! We win!");
												fighting = false;
												enemyDown[2] = true;
											}
										}
										else
										{
											//mon2
											//Pattern
											if(hasPattern == true)
											{
												if(waitTimeTwo <= 0 && waitTimingTwo == true)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
															waitTime = startWaitTime;
															Color("null");
														break;

														default:
															Color("purple");
															Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
															Color("null");
            									HP -= powerAttackHitTwo;
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
														break;
													}
												}
												else if(waitTimingTwo == true && waitTimeTwo > 0)
												{
													waitTimeTwo--;
													Space();
													Color("blue");
													Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
													Color();
												}
												else if(patternTwo[nextPattern] == 0 && waitTimingTwo == false)
												{
													if(waitTimeTwo <= 0)
													{
														if(isHealingTwo == false)
														{
															Space();
															re = monRand.Next(1, 21);
															switch(re)
															{
																case 1:
																	Color("green");
																	Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
																	waitTimeTwo = startWaitTimeTwo;
																	waitTimingTwo = false;
																	Color("null");
																break;

																default:
																	Color("purple");
																	Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																	Color("null");
          												HP -= powerAttackHitTwo;
																	waitTimingTwo = false;
																	waitTimeTwo = startWaitTimeTwo;
																	WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																break;
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monNameTwo + " used " + powerAttackTwo + "Healing an unpleasant " + powerAttackHealTwo + " HP!");
															Color("null");
															hpTwo += powerAttackHealTwo;
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHealTwo/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monNameTwo + " is preparing for a POWER Attack! " + waitTimeTwo + " turns left until it happens!");
														if(waitTimingTwo == false)
														{
															waitTimeTwo--;
														}
														waitTimingTwo = true;
														Color();
													}
												}
												else if(patternTwo[nextPattern] == 2 && waitTimingTwo == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monName + " is defending from attack!");
													isDefendingTwo = true;
												}
												else if(patternTwo[nextPattern] == 3 && waitTimingTwo == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monNameTwo + " is healing itself!");
													hpTwo += Convert.ToInt32(hpTwo/4);
												}
												else
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monNameTwo + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monNameTwo + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monNameTwo + " did " + attackTwo + " hp to you!");
															Color("null");
            									HP -= attackTwo;
															WILL -= Convert.ToInt32(attackTwo - ATK/6);
														break;
													}
												}
											}
											//Weight
											else if(hasWeight == true)
											{
												switch(weightTwo[0])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[0] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weight[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weight[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weight[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[0] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[0] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[0] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[0] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;
													
													case 1:
														weightAmountTwo[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[0] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[0] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[0] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[0] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[0] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weightTwo[1])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[1] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[1] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[1] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[1] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[1] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmountTwo[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[1] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[1] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[1] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[1] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[1] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weightTwo[2])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[2] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[2] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[2] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[2] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[2] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmountTwo[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[2] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[2] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[2] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[2] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[2] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[3] != -5)
																	{
																		weightAmountTwo[3] -= 5;
																	}
																break;
															}
														}
													break;
												}
												switch(weightTwo[3])
												{
													//Take a pool of 4 integers with a ratio of 1:5, and have 0 = 25 to add up to 100. Randomly take away one from another integer when the value is increased and vise-versa when decreased. Finally, the values will be pluged into a Random.Next(0, 101) and calculate damage through that variable amounts.
													case -5:
														weightAmountTwo[3] = 0;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -4:
														weightAmountTwo[3] -= 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -3:
														weightAmountTwo[3] -= 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -2:
														weightAmountTwo[3] -= 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case -1:
														weightAmountTwo[3] -= 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] += 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] += 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] += 5;
																	}
																break;
															}
														}
													break;

													case 0:
													break;

													case 1:
														weightAmountTwo[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 2:
														weightAmountTwo[3] += 10;
														re = rando.Next(0, 3);
														for(int o = 0; o < 2; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 3:
														weightAmountTwo[3] += 15;
														re = rando.Next(0, 3);
														for(int o = 0; o < 3; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 4:
														weightAmountTwo[3] += 20;
														re = rando.Next(0, 3);
														for(int o = 0; o < 4; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													case 5:
														weightAmountTwo[3] += 25;
														re = rando.Next(0, 3);
														for(int o = 0; o < 5; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;

													default:
														weightAmountTwo[3] += 5;
														re = rando.Next(0, 3);
														for(int o = 0; o < 1; o++)
														{
															switch(re)
															{
																case 0:
																	if(weightTwo[0] != -5)
																	{
																		weightAmountTwo[0] -= 5;
																	}
																break;

																case 1:
																	if(weightTwo[1] != -5)
																	{
																		weightAmountTwo[1] -= 5;
																	}
																break;

																case 2:
																	if(weightTwo[2] != -5)
																	{
																		weightAmountTwo[2] -= 5;
																	}
																break;
															}
														}
													break;
												}
												re = rando.Next(1, 101);
												if(waitTimeTwo <= 0 && waitTimingTwo == true)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
															waitTimeTwo = startWaitTimeTwo;
															Color("null");
														break;

														default:
															Color("purple");
															Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
															Color("null");
            									HP -= powerAttackHitTwo;
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
														break;
													}
												}
												else if(waitTimingTwo == true && waitTimeTwo > 0)
												{
													waitTimeTwo--;
													Space();
													Color("blue");
													Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
													Color();
												}
												else if(re <= weightAmountTwo[0] && waitTimingTwo == false)
												{
													if(waitTimeTwo <= 0)
													{
														if(isHealingTwo == false)
														{
															Space();
															re = rando.Next(0, 2);
															if(re == 0)
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
																		waitTimeTwo = startWaitTimeTwo;
																		waitTimingTwo = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																		Color("null");
            												HP -= powerAttackHitTwo;
																		waitTimingTwo = false;
																		waitTimeTwo = startWaitTimeTwo;
																		WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																	break;
																}
															}
															else
															{
																re = monRand.Next(1, 21);
																switch(re)
																{
																	case 1:
																		Color("green");
																		Writer("You somehow dodged " + monNameTwo + "'s POWER Attack!");
																		waitTimeTwo = startWaitTimeTwo;
																		waitTimingTwo = false;
																		Color("null");
																	break;

																	default:
																		Color("purple");
																		Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																		Color("null");
            												HP -= powerAttackHitTwo;
																		waitTimingTwo = false;
																		waitTimeTwo = startWaitTimeTwo;
																		WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
																	break;
																}
															}
														}
														else
														{
															Space();
															Color("purple");
															Writer("POWER ABILITY: " + monNameTwo + " used " + powerAttackTwo + "Healing an unpleasant " + powerAttackHealTwo + " HP!");
															Color("null");
															hpTwo += powerAttackHealTwo;
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHealTwo/4);
														}
													}
													else
													{
														Space();
														Color("blue");
														Writer(monNameTwo + " is preparing for a POWER Attack! " + waitTimeTwo + " turns left until it happens!");
														if(waitTimingTwo == false)
														{
															waitTimeTwo--;
														}
														waitTimingTwo = true;
														Color();
													}
												}
												else if( re > weightAmountTwo[0] && re <= weightAmountTwo[1] && waitTimingTwo == false)
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monNameTwo + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monNameTwo + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monNameTwo + " did " + attackTwo + " hp to you!");
															Color("null");
            									HP -= attackTwo;
															WILL -= Convert.ToInt32(attackTwo - ATK/6);
														break;
													}
												}
												else if(re > weightAmountTwo[1] && re <= weightAmountTwo[2] && waitTimingTwo == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monNameTwo + " is defending from attack!");
													isDefending = true;
												}
												else if(re > weightAmountTwo[2] && re <= weightAmountTwo[3] && waitTimingTwo == false)
												{
													Space();
													Color("yellow");
													Writer("The " + monNameTwo + " is healing itself!");
													hpTwo += Convert.ToInt32(hpTwo/4);
												}
												else
												{
													Space();
													re = monRand.Next(1, 11);
													switch(re)
													{
														case 1:
															Color("green");
															Writer("You dodged " + monNameTwo + "'s attack!");
															Color("null");
														break;

														case 2:
															Color("green");
															Writer("You dodged " + monNameTwo + "'s attack!");
															Color("null");
														break;

														default:
															Color("red");
															Writer(monNameTwo + " did " + attackTwo + " hp to you!");
															Color("null");
            									HP -= attackTwo;
															WILL -= Convert.ToInt32(attackTwo - ATK/6);
														break;
													}
												}
												weightAmountTwo = new float[] {25, 50, 75, 100};
												/*
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;
															
															case 2:
																Color("green");
																Writer("You dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to you!");
																Color("null");
            										HP -= attack;
																WILL -= Convert.ToInt32(attack - ATK/6);
															break;
														}
													break;
													case 1:
														Space();
														re = monRand.Next(1, 11);
														switch(re)
														{
															case 1:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 2:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															case 3:
																Color("green");
																Writer(fMark3 + " dodged " + monName + "'s attack!");
																Color("null");
															break;

															default:
																Color("red");
																Writer(monName + " did " + attack + " hp to " + fMark3 + "!");
																Color("null");
            										fMark0 -= attack;
																WILL -= Convert.ToInt32(attack - ATK/8);
															break;
														}
													break;
												}
												*/
											}
										}
									}
								}
							}
							//end
							Color();
							switch(teamMate)
							{
								case 0:
									Mark.HEARTS = fMark_1;
									Mark.HP = fMark0;
									Mark.SPE = fMark1;
									Mark.ATK = fMark2;
									Mark.name = fMark3;
									Mark.level = fMark4;
									Mark.EXP = fMark5;
									Mark.EXPNeed = fMark6;
								break;

								case 1:
									Breys.HEARTS = fMark_1;
									Breys.HP = fMark0;
									Breys.SPE = fMark1;
									Breys.ATK = fMark2;
									Breys.name = fMark3;
									Breys.level = fMark4;
									Breys.EXP = fMark5;
									Breys.EXPNeed = fMark6;
								break;

								case 2:
									Sapphire.HEARTS = fMark_1;
									Sapphire.HP = fMark0;
									Sapphire.SPE = fMark1;
									Sapphire.ATK = fMark2;
									Sapphire.name = fMark3;
									Sapphire.level = fMark4;
									Sapphire.EXP = fMark5;
									Sapphire.EXPNeed = fMark6;
								break;

								case 3:
									Captain.HEARTS = fMark_1;
									Captain.HP = fMark0;
									Captain.SPE = fMark1;
									Captain.ATK = fMark2;
									Captain.name = fMark3;
									Captain.level = fMark4;
									Captain.EXP = fMark5;
									Captain.EXPNeed = fMark6;
								break;
							}
							//death
            	DeathHandler();
 
							if(hp <= 0)
							{
								Space(2);
								enemyDown[1] = true;
								if(enemyDown[0] == true)
								{
									Writer(monName + " and " + monNameTwo + " have been defeated! We win!");
									stopText[2] = true;
									enemyDown[2] = true;
								}
							}
							if(hpTwo <= 0)
							{
								Space(2);
								enemyDown[0] = true;
								if(enemyDown[1] == true)
								{
									if(stopText[2] == false)
									{
										Writer(monNameTwo + " and " + monName + " have been defeated! We win!");
										stopText[2] = true;
									}
									enemyDown[2] = true;
								}
							}
							//end	
							Space();
							if(hp > 0 && hpTwo > 0)
							{
								Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + monNameTwo + " has " + hpTwo + " HP.");
							}
							else if(hp <= 0 && hpTwo > 0)
							{
								Writer("You have " + HP + " HP and " + monNameTwo + " has " + hpTwo + " HP.");
							}
							else if(hp > 0 && hpTwo <= 0)
							{
								Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP.");
							}
							if(enemyDown[2] != true)
							{
								//choosing
								Space();
								Writer("What next? (1 - 5)");
								Space();
      					Color("cyan");
								Writer(toDo[3]);
								Color("pink");
								Writer(toDo[0]);
								Color("bold");
								Writer(toDo[4]);
								Color("blue");
      					Writer(toDo[1]);
								Color("green");
      					Writer(toDo[2]);
								Color("null");
      					Space();
      					Choose = Reader();
							}
						}
          break;

					case "3":
					case "defend":
					case "DFD":
					case "dfd":
					case "Dfd":
					case "Defend":
					case "DEFEND":
						if(true)//all
						{
							if(SPE >= speed)
							{
								//player death check
								DeathHandler();
								//monster death check
								if(hp <= 0)
								{
									enemyDown[2] = true;
									continue;
								}
								//defending
								Space();
								re = monRand.Next(1, 11);
								switch(re)
								{
									case 1:
										Color("green");
										Writer(monName + " missed completely!");
										Color("null");
									break;

									default:
										Color("yellow");
										Writer("You defended from " + monName + "'s attack! You took " + (int) (attack/4) * 3 + " damage!");
										Color("null");
          	  			HP -= Convert.ToInt32((attack/4) * 3);
										WILL -= Convert.ToInt32(attack - ATK/4);
									break;
								}
								if(twoEnemy == true)
								{
									switch(re)
									{
										case 1:
											Color("green");
											Writer(monNameTwo + " missed completely!");
											Color("null");
										break;

										default:
											Color("yellow");
											Writer("You defended from " + monNameTwo + "'s attack! You took " + (int) (attackTwo/4) * 3 + " damage!");
											Color("null");
          	  				HP -= Convert.ToInt32((attackTwo/4) * 3);
											WILL -= Convert.ToInt32(attackTwo - ATK/4);
										break;
									}
								}
								if(doubleBattle == true)
								{
									//mark death check/attack
									if(fMark0 <= 0)
									{
										Space();
										Writer(fMark3 + " is beat! He can't fight!");
									}
									else if (fMark0 > 0)
									{
										re = rando.Next(0, 2);
										if(re == 0)
										{
											if(hp > 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monName + "!");
												hp -= fMark2;
											}
											else if (hp <= 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monNameTwo + "!");
												hpTwo -= fMark2;
											}
										}
										else if (re == 1)
										{
											if(hpTwo > 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monNameTwo + "!");
												hpTwo -= fMark2;
											}
											else if (hpTwo <= 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monName + "!");
												hp -= fMark2;
											}
										}
									}
								}
							}
							else if(SPE < speed)
							{
								//player death check
								DeathHandler();

								//monster death check
								if(hp <= 0)
								{
									enemyDown[2] = true;
									continue;
								}
								//monster
								Space();
								re = monRand.Next(1, 11);
								switch(re)
								{
									case 1:
										Color("green");
										Writer(monName + " missed completely!");
										Color("null");
									break;

									default:
										Color("red");
										Writer("You defended from " + monName + "'s attack! You took " + (attack/4) * 3 + " damage!");
										Color("null");
          	  			HP -= Convert.ToInt32((attack/4) * 3);
										WILL -= Convert.ToInt32(attack - ATK/4);
									break;
								}
								if(twoEnemy == true)
								{
									switch(re)
									{
										case 1:
											Color("green");
											Writer(monNameTwo + " missed completely!");
											Color("null");
										break;

										default:
											Color("yellow");
											Writer("You defended from " + monNameTwo + "'s attack! You took " + (int) (attackTwo/4) * 3 + " damage!");
											Color("null");
          	  				HP -= Convert.ToInt32((attackTwo/4) * 3);
											WILL -= Convert.ToInt32(attackTwo - ATK/4);
										break;
									}
								}
								if(doubleBattle == true)
								{
									//mark death check/attack
									if(fMark0 <= 0)
									{
										Space();
										Writer(fMark3 + " is beat! He can't fight!");
									}
									else if (fMark0 > 0)
									{
										re = rando.Next(0, 2);
										if(re == 0)
										{
											if(hp > 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monName + "!");
												hp -= fMark2;
											}
											else if (hp <= 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monNameTwo + "!");
												hpTwo -= fMark2;
											}
										}
										else if (re == 1)
										{
											if(hpTwo > 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monNameTwo + "!");
												hpTwo -= fMark2;
											}
											else if (hpTwo <= 0)
											{
												Space();
												Color("green");
												Writer(fMark3 + " did " + fMark2 + " damage to " + monName + "!");
												hp -= fMark2;
											}
										}
									}
								}
							}
							switch(teamMate)
							{
								case 0:
									Mark.HEARTS = fMark_1;
									Mark.HP = fMark0;
									Mark.SPE = fMark1;
									Mark.ATK = fMark2;
									Mark.name = fMark3;
									Mark.level = fMark4;
									Mark.EXP = fMark5;
									Mark.EXPNeed = fMark6;
								break;

								case 1:
									Breys.HEARTS = fMark_1;
									Breys.HP = fMark0;
									Breys.SPE = fMark1;
									Breys.ATK = fMark2;
									Breys.name = fMark3;
									Breys.level = fMark4;
									Breys.EXP = fMark5;
									Breys.EXPNeed = fMark6;
								break;

								case 2:
									Sapphire.HEARTS = fMark_1;
									Sapphire.HP = fMark0;
									Sapphire.SPE = fMark1;
									Sapphire.ATK = fMark2;
									Sapphire.name = fMark3;
									Sapphire.level = fMark4;
									Sapphire.EXP = fMark5;
									Sapphire.EXPNeed = fMark6;
								break;

								case 3:
									Captain.HEARTS = fMark_1;
									Captain.HP = fMark0;
									Captain.SPE = fMark1;
									Captain.ATK = fMark2;
									Captain.name = fMark3;
									Captain.level = fMark4;
									Captain.EXP = fMark5;
									Captain.EXPNeed = fMark6;
								break;
							}
						}
						//end	
						Space();
						if(hp > 0 && hpTwo > 0)
						{
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + monNameTwo + " has " + hpTwo + " HP.");
						}
						else if(hp <= 0 && hp > 0)
						{
							Writer("You have " + HP + " HP and " + monNameTwo + " has " + hpTwo + ".");
						}
						else if(hp > 0 && hp <= 0)
						{
							Writer("You have " + HP + " HP and " + monName + " has " + hp + ".");
						}
						else if(hp <= 0 && hpTwo <= 0)
						{
							Writer("You have no opponents. They're all gone.");
							enemyDown[2] = true;
						}
						//choosing
          	DeathHandler();
						if(hp <= 0)
						{
							Space(2);
							enemyDown[1] = true;
							if(enemyDown[0] == false)
							{
								Writer(monName + " has been defeated! Just letting you know!");

							}
							else if(enemyDown[0] == true)
							{
								Writer(monName + " has been defeated! We win!");
								enemyDown[2] = true;
							}
						}
						if(hpTwo <= 0)
						{
							Space(2);
							enemyDown[0] = true;
							if(enemyDown[1] == false)
							{
								Writer(monNameTwo + " has been defeated! Just letting you know!"); 
							}
							else if(enemyDown[1] == true)
							{
								Writer(monNameTwo + " has been defeated! We win!");
								enemyDown[2] = true;
							}
						}
						if(enemyDown[0] == true && enemyDown[1] == true)
						{
							enemyDown[2] = true;
						}
						Space();
						Writer("What next? (1 - 5)");
						Space();
      			Color("cyan");
						Writer(toDo[3]);
						Color("pink");
						Writer(toDo[0]);
						Color("bold");
						Writer(toDo[4]);
						Color("blue");
      			Writer(toDo[1]);
						Color("green");
      			Writer(toDo[2]);
						Color("null");
      			Space();
      			Choose = Reader();
					break;

          case "4":
					case "run":
					case "RUN":
					case "Run":
						DeathHandler();
						if(single == true)
						{
							if(hp <= 0)
							{
								enemyDown[2] = true;
								continue;
							}
						}
						else if(doubleBattle == false && twoEnemy == true)
						{
							if(hp <= 0)
							{
								Space(2);
								enemyDown[1] = true;
								if(enemyDown[0] == false)
								{
									Writer(monName + " has been defeated! Just letting you know!");
									
								}
								else if(enemyDown[0] == true)
								{
									Writer(monName + " has been defeated! We win!");
									enemyDown[2] = true;
								}
							}

							if(hpTwo <= 0)
							{
								Space(2);
								enemyDown[0] = true;
								if(enemyDown[1] == false)
								{
									Writer(monNameTwo + " has been defeated! Just letting you know!"); 
								}
								else if(enemyDown[1] == true)
								{
									Writer(monNameTwo + " has been defeated! We win!");
									enemyDown[2] = true;
								}
							}
							if(enemyDown[0] == true && enemyDown[1] == true)
							{
								enemyDown[2] = true;
							}
						}

						else if(doubleBattle == true && twoEnemy == true)
						{
							if(hp <= 0)
							{
								Space(2);
								enemyDown[1] = true;
								if(enemyDown[0] == false)
								{
									Writer(monName + " has been defeated! One down, one to go!");
									
								}
								else if(enemyDown[0] == true)
								{
									Writer(monName + " has been defeated! We win!");
									continue;
								}
							}

							if(hpTwo <= 0)
							{
								Space(2);
								enemyDown[0] = true;
								if(enemyDown[1] == false)
								{
									Writer(monNameTwo + " has been defeated! One down, one to go!"); 
								}
								else if(enemyDown[1] == true)
								{
									Writer(monNameTwo + " has been defeated! We win!");
									continue;
								}
							}
						}
						else if(doubleBattle == false && twoEnemy == false)
						{
							enemyDown[2] = true;
							continue;
						}
						else if(doubleBattle == true && twoEnemy == false)
						{
							enemyDown[2] = true;
							continue;
						}
            //random # gen
            if(HP >= Convert.ToInt32(HP/3))
						{
							re = rando.Next(1, 4);
						}
						else
						{
							re = rando.Next(1, 3);
						}
						if(boss == false && SPE >= speed)
						{
            	//logic
            	Space();
							if (re == 2) 
							{
              	Writer("You ran away!");
              	return;
            	} 
							else if (re != 2) 
							{
              	Writer("You tried to run, But it failed!");
							}
						}
						else if(boss == true)
						{
							Writer("You can't run from a Boss Monster!");
						} 
					
            //monster
            Space();
						re = monRand.Next(1, 11);
						switch(re)
						{
							case 1:
								Color("green");
								Writer("You dodged " + monName + "'s attack!");
								Color("null");
							break;
								
							case 2:
								Color("green");
								Writer("You dodged " + monName + "'s attack!");
								Color("null");
							break;

							case 3:
								Color("green");
								Writer("You dodged " + monName + "'s attack!");
								Color("null");
							break;

							default:
								Color("red");
								Writer(monName + " did " + attack + " hp to you!");
								Color("null");
            		HP -= attack;
								WILL -= Convert.ToInt32(attack - ATK/6);
							break;
						}
						//end
						Space(2);
						//death checks						
						DeathHandler();
						switch(teamMate)
						{
							case 0:
								Mark.HEARTS = fMark_1;
								Mark.HP = fMark0;
								Mark.SPE = fMark1;
								Mark.ATK = fMark2;
								Mark.name = fMark3;
								Mark.level = fMark4;
								Mark.EXP = fMark5;
								Mark.EXPNeed = fMark6;
							break;

							case 1:
								Breys.HEARTS = fMark_1;
								Breys.HP = fMark0;
								Breys.SPE = fMark1;
								Breys.ATK = fMark2;
								Breys.name = fMark3;
								Breys.level = fMark4;
								Breys.EXP = fMark5;
								Breys.EXPNeed = fMark6;
							break;

							case 2:
								Sapphire.HEARTS = fMark_1;
								Sapphire.HP = fMark0;
								Sapphire.SPE = fMark1;
								Sapphire.ATK = fMark2;
								Sapphire.name = fMark3;
								Sapphire.level = fMark4;
								Sapphire.EXP = fMark5;
								Sapphire.EXPNeed = fMark6;
							break;

							case 3:
								Captain.HEARTS = fMark_1;
								Captain.HP = fMark0;
								Captain.SPE = fMark1;
								Captain.ATK = fMark2;
								Captain.name = fMark3;
								Captain.level = fMark4;
								Captain.EXP = fMark5;
								Captain.EXPNeed = fMark6;
							break;
						}
						
						//text
						if(single == true)
						{
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
						}
						else if(doubleBattle == false && twoEnemy == true)
						{
							if(hp > 0 && hpTwo > 0)
							{
								Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + monNameTwo + " has " + hpTwo + " HP.");
							}
							else if(hp <= 0 && hp > 0)
							{
								Writer("You have " + HP + " HP and " + monNameTwo + " has " + hpTwo + ".");
							}
							else if(hp > 0 && hp <= 0)
							{
								Writer("You have " + HP + " HP and " + monName + " has " + hp + ".");
							}
							else if(hp <= 0 && hpTwo <= 0)
							{
								Writer("You have no opponents. They're all gone.");
								enemyDown[2] = true;
							}
						}

						else if(doubleBattle == true && twoEnemy == true)
						{
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, " + monNameTwo + " has " + hpTwo + " HP, and " + fMark3 + "has " + fMark0 + " HP.");
						}
						else if(doubleBattle == false && twoEnemy == false)
						{
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
						}
						else if(doubleBattle == true && twoEnemy == false)
						{
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
						}
						//choose
          	Space();
						Writer("What next? (1 - 5)");
						Space();
      			Color("cyan");
						Writer(toDo[3]);
						Color("pink");
						Writer(toDo[0]);
						Color("bold");
						Writer(toDo[4]);
						Color("blue");
      			Writer(toDo[1]);
						Color("green");
      			Writer(toDo[2]);
						Color("null");
      			Space();
      			Choose = Reader();
          break;

          case "5":
					case "GRAB":
					case "grab":
					case "Grab":
            DeathHandler();
						if(single == true)
						{
							if(hp <= 0)
							{
								enemyDown[2] = true;
								continue;
							}
						}
						else if(doubleBattle == false && twoEnemy == true)
						{
							if(hp <= 0)
							{
								Space(2);
								enemyDown[1] = true;
								if(enemyDown[0] == false)
								{
									Writer(monName + " has been defeated! Just letting you know!");
									
								}
								else if(enemyDown[0] == true)
								{
									Writer(monName + " has been defeated! We win!");
									enemyDown[2] = true;
								}
							}

							if(hpTwo <= 0)
							{
								Space(2);
								enemyDown[0] = true;
								if(enemyDown[1] == false)
								{
									Writer(monNameTwo + " has been defeated! Just letting you know!"); 
								}
								else if(enemyDown[1] == true)
								{
									Writer(monNameTwo + " has been defeated! We win!");
									enemyDown[2] = true;
								}
							}
							if(enemyDown[0] == true && enemyDown[1] == true)
							{
								enemyDown[2] = true;
							}
						}

						else if(doubleBattle == true && twoEnemy == true)
						{
							if(hp <= 0)
							{
								Space(2);
								enemyDown[1] = true;
								if(enemyDown[0] == false)
								{
									Writer(monName + " has been defeated! One down, one to go!");
									
								}
								else if(enemyDown[0] == true)
								{
									Writer(monName + " has been defeated! We win!");
									continue;
								}
							}

							if(hpTwo <= 0)
							{
								Space(2);
								enemyDown[0] = true;
								if(enemyDown[1] == false)
								{
									Writer(monNameTwo + " has been defeated! One down, one to go!"); 
								}
								else if(enemyDown[1] == true)
								{
									Writer(monNameTwo + " has been defeated! We win!");
									continue;
								}
							}
						}
						else if(doubleBattle == true && twoEnemy == false)
						{
							if(hp <= 0)
							{
								enemyDown[2] = true;
							}
						}
						//tutorial
						if(firstTime[1] == true)
						{
							Color("green");
							Space();
							Writer("Time to grab something from your bag!");
							Writer("When you grab, you get something from the 10 slots in your bag.");
							Enter();
							Writer("Each slot in your bag is marked with a number from 0-9. Type the corrisponding number to use that item!");
							Writer("now you know all about grabbing!");
							Enter();
							firstTime[1] = false;
							Color("null");
						}
						//Logic
            Space();
						bool ender = false;
						//come back to this
						while(!ender)
						{
							if(From[2] == true)
							{
								Writer("Which item do you want to grab? (0 - 10)");
							}
							else
							{
								Writer("Which item do you want to grab? (0 - 9)");
							}
							Space();
							//Logic (help)
							Writer(inventory[0] + ", 0");
							Writer(inventory[1] + ", 1");
							Writer(inventory[2] + ", 2");
							Writer(inventory[3] + ", 3");
							Writer(inventory[4] + ", 4");
							Writer(inventory[5] + ", 5");
							Writer(inventory[6] + ", 6");
							Writer(inventory[7] + ", 7");
							Writer(inventory[8] + ", 8");
							Writer(inventory[9] + ", 9");
							if(From[2] == true)
							{
								Writer(inventory[10] + ", 10");
							}
							Space();
							option = Reader();
							switch(option)
							{
								case "0":
									switch(inventory[0])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[0] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[0] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[0] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[0] = "null";
											ender = true;
										break;
										
										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[0] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "1":
									switch(inventory[1])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[1] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[1] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[1] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[1] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[1] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "2":
									switch(inventory[2])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[2] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[2] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[2] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[2] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[2] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "3":
									switch(inventory[3])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[3] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[3] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[3] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[3] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[3] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "4":
									switch(inventory[4])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[4] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[4] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[4] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[4] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[4] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "5":
									switch(inventory[5])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[5] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[5] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[5] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[5] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[5] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "6":
									switch(inventory[6])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[6] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[6] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[6] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[6] = "null";
											ender = true;
										break;
										
										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[6] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "7":
									switch(inventory[7])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[7] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[7] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[7] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[7] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[7] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "8":
									switch(inventory[8])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[8] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[8] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[8] = "null";
											ender = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[8] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[8] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "9":
									switch(inventory[9])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
											inventory[9] = "null";
											ender = true;
										break;

										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											inventory[9] = "null";
											ender = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											inventory[9] = "null";
											ender = true;
										break;
										
										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												level++;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
        							}
											inventory[9] = "null";
											ender = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}
											inventory[9] = "null";
											ender = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											ender = true;
										break;

										default:
											ErrorWrite();
										break;
									}
									ender = true;
								break;

								case "10":
									if(From[2] == true)
									{
										switch(inventory[10])
										{
											case "potion":
												Space();
												Writer("You recieved 20 HP!");
												HP += 20;
												if(HP > HEARTS)
												{
													HP = HEARTS;
												}
												inventory[10] = "null";
												ender = true;
											break;

											case "heart":
												Space();
												Writer("You gained 5 HP!");
												HEARTS += 5;
												HP += 5;
												inventory[10] = "null";
												ender = true;
											break;

											case "ATK UP":
												Space();
												Writer("You buffed up! ATK increased!");
												ATK += 5;
												inventory[10] = "null";
												ender = true;
											break;

											case "EXP UP":
												Space();
												Writer("You watched a Uberdemy tutorial! EXP 	increased!");
												EXP += 1500;
												Space();
												Writer("You gained " + 1500 + " EXP!");
        								//EXP logic
												while(EXP >= EXPNeed)
												{
          								Space();
													level++;
													Writer("You leveled up to level " + level + "! 	+ 3 ATK, +1 SPE,+ 2 Max HP!");
													HEARTS = HEARTS + 2;
													HP = HEARTS + 2;
          								ATK = ATK + 3;
													SPE++;
          								EXP -= EXPNeed;
													EXPNeed += 1000;
													Space();
													Writer("STATS: Max HP: " + HEARTS + ", HP: " + HP + ", ATK: " + 	ATK + ", SPE: " + SPE);
        								}
												inventory[10] = "null";
												ender = true;
											break;

											case "potion +":
												Space();
												Writer("You recieved 60 HP!");
												HP += 60;
												if(HP > HEARTS)
												{
													HP = HEARTS + 10;
												}
												inventory[10] = "null";
												ender = true;
											break;

											case "null":
												Space();
												Writer("there is no item in this slot");
											break;
											
											default:
												ErrorWrite();
											break;
										}
										ender = true;
									}
									else
									{
										ErrorWrite();
									}
								break;

								default:
									ErrorWrite();
									if(From[2] == true)
									{
										Writer("Which item do you want to grab? (0 - 10)");
									}
									else
									{
										Writer("Which item do you want to grab? (0 - 9)");
									}
									Space();
									//Logic (help)
									Writer(inventory[0] + ", 0");
									Writer(inventory[1] + ", 1");
									Writer(inventory[2] + ", 2");
									Writer(inventory[3] + ", 3");
									Writer(inventory[4] + ", 4");
									Writer(inventory[5] + ", 5");
									Writer(inventory[6] + ", 6");
									Writer(inventory[7] + ", 7");
									Writer(inventory[8] + ", 8");
									Writer(inventory[9] + ", 9");
									if(From[2] == true)
									{
										Writer(inventory[10] + ", 10");
									}
									Space();
									option = Reader();
								break;	
							}
						}
            //monster
            Space();
            re = monRand.Next(1, 11);
						switch(re)
						{
							case 1:
								Color("green");
								Writer("You dodged " + monName + "'s attack!");
								Color("null");
							break;
								
							case 2:
								Color("green");
								Writer("You dodged " + monName + "'s attack!");
								Color("null");
							break;

							case 3:
								Color("green");
								Writer("You dodged " + monName + "'s attack!");
								Color("null");
							break;

							default:
								Color("red");
								Writer(monName + " did " + attack + " hp to you!");
								Color("null");
            		HP -= attack;
								WILL -= Convert.ToInt32(attack - ATK/6);
							break;
						}
						if(twoEnemy == true)
						{
							switch(re)
							{
								case 1:
									Color("green");
									Writer("You dodged " + monNameTwo + "'s attack!");
									Color("null");
								break;

								case 2:
									Color("green");
									Writer("You dodged " + monNameTwo + "'s attack!");
									Color("null");
								break;

								case 3:
									Color("green");
									Writer("You dodged " + monNameTwo + "'s attack!");
									Color("null");
								break;

								case 4:
									Color("green");
									Writer("You dodged " + monNameTwo + "'s attack!");
									Color("null");
								break;

								case 5:
									Color("green");
									Writer("You dodged " + monNameTwo + "'s attack!");
									Color("null");
								break;

								default:
									Color("red");
									Writer(monNameTwo + " did " + attackTwo + " hp to you!");
									Color("null");
            			HP -= attackTwo;
									WILL -= Convert.ToInt32(attackTwo - ATK/6);
								break;
							}
						}
            //end
						Space(2);
						if(single == true)
						{
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
						}
						else if(doubleBattle == false && twoEnemy == true)
						{
							if(hp > 0 && hpTwo > 0)
							{
								Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + monNameTwo + " has " + hpTwo + " HP.");
							}
							else if(hp <= 0 && hp > 0)
							{
								Writer("You have " + HP + " HP and " + monNameTwo + " has " + hpTwo + ".");
							}
							else if(hp > 0 && hp <= 0)
							{
								Writer("You have " + HP + " HP and " + monName + " has " + hp + ".");
							}
							else if(hp <= 0 && hpTwo <= 0)
							{
								Writer("You have no opponents. They're all gone.");
								enemyDown[2] = true;
							}
						}

						else if(doubleBattle == true && twoEnemy == true)
						{
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, " + monNameTwo + " has " + hpTwo + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
						}
						else if(doubleBattle == false && twoEnemy == false)
						{
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
						}
						else if(doubleBattle == true && twoEnemy == false)
						{
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + fMark3 + " has " + fMark0 + " HP.");
						}
						//choose
						DeathHandler();
						Space();
						Writer("What next? (1 - 5)");
						Space();
      			Color("cyan");
						Writer(toDo[3]);
						Color("pink");
						Writer(toDo[0]);
						Color("bold");
						Writer(toDo[4]);
						Color("blue");
      			Writer(toDo[1]);
						Color("green");
      			Writer(toDo[2]);
						Color("null");
      			Space();
      			Choose = Reader();
          break;

          default:
            ErrorWrite();
            Space();
						Writer("What next? (1 - 5)");
						Space();
      			Color("cyan");
						Writer(toDo[3]);
						Color("pink");
						Writer(toDo[0]);
						Color("bold");
						Writer(toDo[4]);
						Color("blue");
      			Writer(toDo[1]);
						Color("green");
      			Writer(toDo[2]);
						Color("null");
      			Space();
      			Choose = Reader();
          break;
        }
      }
    
			if(enemyDown[2] == true)
			{
				if (true)//XXXX
				{
					Space();
					if(single == true)
					{
						Writer("[0;36m" + monName + " was defeated! You can move on!");
					}
					else if(single != true)
					{
						if(doubleBattle == true && enemyDown[1] == true && enemyDown[0] == true)
						{
							Writer("[0;36m" + monName + " and " + monNameTwo + " were defeated! You two can move on!");
						}
						else if(doubleBattle == false && enemyDown[1] == true && enemyDown[0] == true)
						{
							Writer("[0;36m" + monName + " and " + monNameTwo + " were defeated! You can move on!");
						}
					}
					Writer("[0;0m");
					noSpecial = false;
					//GOLD system
					GOLD += gold;
					Space();
					if(gold == 1)
					{
						Writer("[0;33m You gained " + gold + " piece of GOLD!");
					}
					else
					{
						Writer("[0;33m You gained " + gold + " pieces of GOLD!");
					}
					Space();
					if(GOLD == 1)
					{
						Writer("You now have " + GOLD + " piece of GOLD!");
					}
					else
					{
						Writer("You now have " + GOLD + " pieces of GOLD!");
					}
					//Bounty System
					if(hasBounty == true)
					{
						if(MaxHp >= 0 && MaxHp <= 60)
						{
							if(bounties[0] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[0] = false;
								bountyCollected--;
							}
							else if(bounties[1] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[1] = false;
								bountyCollected--;
							}
							else if (bounties[2] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[2] = false;
								bountyCollected--;
							}
						}
						if(MaxHp >= 61 && MaxHp <= 90)
						{
							if(bounties[3] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[3] = false;
								bountyCollected--;
							}
							else if(bounties[4] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[4] = false;
								bountyCollected--;
							}
							else if (bounties[5] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[5] = false;
								bountyCollected--;
							}
						}
						if(MaxHp >= 0 && MaxHp <= 60)
						{
							if(bounties[6] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[6] = false;
								bountyCollected--;
							}
							else if(bounties[7] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[7] = false;
								bountyCollected--;
							}
							else if (bounties[8] == true)
							{
								Space();
								Writer("One of your bounties was cleared! " + bountyCollected + " more to go!");
								bounties[8] = false;
								bountyCollected--;
							}
						}
					}
					//EXP system
      	  Space();
      	  if(doubleBattle == false)
					{
						EXP += exp;
						Color("pink");
						Writer("You gained " + exp + " EXP!");
      	  	while(EXP >= EXPNeed)
						{
      	  	  HEARTS = HEARTS + 2;
							HP = HEARTS + 2;
      	  	  ATK = ATK + 3;
							SPE++;
      	  	  level++;
      	  	  EXP -= EXPNeed;
							EXPNeed += 1000;
							//text
							Space();
							Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
							//item giving
							ItemGet();
      	  	}
					}
					else
					{
						EXP += (exp/2);
						fMark5 = (exp/2);
						Color("pink");
						Writer("You and " + fMark3 + " gained " + (exp/2) + " EXP!");
      	  	while(EXP >= EXPNeed)
						{
      	  	  HEARTS = HEARTS + 2;//HEARTS
							HP = HEARTS + 2;//HP
      	  	  ATK = ATK + 3;//ATK
							SPE++;//SPE
      	  	  level++;//LEVEL
      	  	  EXP -= EXPNeed;//EXP
							EXPNeed += 1000;//EXPNeed up
							//text
							Space();
							Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
							//item giving
							ItemGet();
      	  	}
						Space();
						while(fMark5 >= fMark6)
						{
							switch(teamMate)
							{
								case 0:
									fMark6 += 1000;//EXP
									fMark_1 = fMark_1 + 2;//HEARTS
									fMark0 = fMark_1 + 2;//HP
      	  	  		fMark2 = fMark2 + 3;//ATK
									fMark1++;//SPE
      	  	  		fMark4++;//LEVEL
      	  	  		fMark5 -= fMark6;//EXPNeed up
									//text
									Space();
									Writer(fMark3 + " leveled up to level " + fMark4 + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
								break;

								case 1:
									fMark6 += 1400;//EXP
									fMark_1 = fMark_1 + 3;//HEARTS
									fMark0 = fMark_1 + 1;//HP
      	  	  		fMark2 = fMark2 + 5;//ATK
									fMark1+= 2;//SPE
      	  	  		fMark4++;//LEVEL
      	  	  		fMark5 -= fMark6;//EXPNeed up
									//text
									Space();
									Writer(fMark3 + " leveled up to level " + fMark4 + "! + 5 ATK, +2 SPE,+ 3 Max HP!");
								break;

								case 2:
									fMark6 += 1600;
									fMark_1 = fMark_1 + 5;//HEARTS
									fMark0 = fMark_1 + 3;//HP
      	  	  		fMark2 = fMark2 + 2;//ATK
									fMark1++;//SPE
      	  	  		fMark4++;//LEVEL
      	  	  		fMark5 -= fMark6;//EXPNeed up
									//text
									Space();
									Writer(fMark3 + " leveled up to level " + fMark4 + "! + 2 ATK, +1 SPE,+ 5 Max HP!");
								break;

								case 3:
									fMark6 += 3600;
									fMark_1 = fMark_1 + 10;//HEARTS
									fMark0 = fMark_1 + 12;//HP
      	  	  		fMark2 = fMark2 + 15;//ATK
									fMark1+= 12;//SPE
      	  	  		fMark4++;//LEVEL
      	  	  		fMark5 -= fMark6;//EXPNeed up
									//text
									Space();
									Writer(fMark3 + " leveled up to level " + fMark4 + "! + 15 ATK, +12 SPE,+ 10 Max HP!");
								break;
							}
      	  	}
					}
					Space();
					//STATS and EXP
					Space();
					if(doubleBattle == false)
					{
						Writer("STATS: Max HP: " + HEARTS + ", HP: " + HP + ", ATK: " + ATK + ", SPE: " + SPE);
					}
					else
					{
						Writer("YOUR STATS: Max HP: " + HEARTS + ", HP: " + HP + ", ATK: " + ATK + ", SPE: " + SPE);
						Writer(fMark3 + " STATS: Max HP: " + fMark_1 + ", HP: " + fMark0 + ", ATK: " + fMark2 + ", SPE: " + fMark1);
					}
					Space();
					Color("blue");
					if(doubleBattle == false)
					{
						Writer("Currently you are level " + level + ". You need " + EXPNeed + " EXP to level up, and you have " + EXP + " EXP.");
					}
					else
					{
						Writer("Currently you are level " + level + ". You need " + EXPNeed + " EXP to level up, and you have " + EXP + " EXP.");
						Writer("Currently " + fMark3 + " is level " + fMark4 + ". You need " + EXPNeed + " EXP to level up, and you have " + EXP + " EXP.");
					}
					//Item System
					Color("null");
					ItemGet();
					//Inventory System
      	  Space();
					Color("green");
					ItemUser();
					Color();
					//Healing teammate 2
					if(doubleBattle == true)
					{
						Writer("Would you like to have " + fMark3 + " heal for 100 GOLD? (y/n)");
						Space();
						option = Reader();
						stop = false;
						while(stop == false)
						{
							switch(option)
							{
								case "YES":
								case "Yes":
								case "y":
								case "yes":
								case "1":
									Space();
									Writer(fMark3 + " was healed to max HP!");
									Writer("You lost 100 GOLD!");
									fMark0 = Convert.ToSingle(fMark0);
									GOLD -= 100;
									Space();
									stop = true;
								break;

								case "NO":
								case "No":
								case "n":
								case "no":
								case "2":
									stop = true;
								break;

								default:
									ErrorWrite();
									Writer("Would you like to have " + fMark3 + " heal for 100 GOLD? (y/n)");
									Space();
									option = Reader();
								break;
							}
						}
						switch(teamMate)
						{
							case 0:
								Mark.HEARTS = fMark_1;
								Mark.HP = fMark0;
								Mark.SPE = fMark1;
								Mark.ATK = fMark2;
								Mark.name = fMark3;
								Mark.level = fMark4;
								Mark.EXP = fMark5;
								Mark.EXPNeed = fMark6;
							break;
							
							case 1:
								Breys.HEARTS = fMark_1;
								Breys.HP = fMark0;
								Breys.SPE = fMark1;
								Breys.ATK = fMark2;
								Breys.name = fMark3;
								Breys.level = fMark4;
								Breys.EXP = fMark5;
								Breys.EXPNeed = fMark6;
							break;

							case 2:
								Sapphire.HEARTS = fMark_1;
								Sapphire.HP = fMark0;
								Sapphire.SPE = fMark1;
								Sapphire.ATK = fMark2;
								Sapphire.name = fMark3;
								Sapphire.level = fMark4;
								Sapphire.EXP = fMark5;
								Sapphire.EXPNeed = fMark6;
							break;
							
							case 3:
								Captain.HEARTS = fMark_1;
								Captain.HP = fMark0;
								Captain.SPE = fMark1;
								Captain.ATK = fMark2;
								Captain.name = fMark3;
								Captain.level = fMark4;
								Captain.EXP = fMark5;
								Captain.EXPNeed = fMark6;
							break;
						}
					}
					//End
      	}
			}
    }
		
	 public static void ItemUser()
	 {
			Space();
			if(inventory[0] == "null" || inventory[1] == "null" || inventory[2] == "null" || inventory[3] == "null" || inventory[4] == "null" || inventory[5] == "null" || inventory[6] == "null" || inventory[7] == "null" || inventory[8] == "null" || inventory[9] == "null" || inventory[10] == "null" && From[2] == true)
			{
				inventoryFull = false;
			}
			if(inventory[0] == "null" || inventory[1] == "null" || inventory[2] == "null" || inventory[3] == "null" || inventory[4] == "null" || inventory[5] == "null" || inventory[6] == "null" || inventory[7] == "null" || inventory[8] == "null" || inventory[9] == "null" && From[2] != true)
			{
				inventoryFull = false;
			}
			if(inventory[0] != "null" && inventory[1] != "null" && inventory[2] != "null" && inventory[3] != "null" && inventory[4] != "null" && inventory[5] != "null" && inventory[6] != "null" && inventory[7] != "null" && inventory[8] != "null" && inventory[9] != "null" && inventory[10] != "null")
			{
				Writer("Your inventory is full!");
				inventoryFull = true;
			}
				Space();
				Writer("Do you want to use a item?");
				Space();
				string uption = Reader();
				Space();
				//Logic
				bool end = false;
				while(end == false)
				{
					switch(uption)
					{
						case "1":
						case "YES":
						case "Yes":
						case "yes":
							if(From[2] == true)
							{
								Writer("Which item? (0 - 10)");
							}
							else
							{
								Writer("Which item? (0 - 9)");
							}
							Space();
							//Logic (help)
							Writer(inventory[0] + ", 0");
							Writer(inventory[1] + ", 1");
							Writer(inventory[2] + ", 2");
							Writer(inventory[3] + ", 3");
							Writer(inventory[4] + ", 4");
							Writer(inventory[5] + ", 5");
							Writer(inventory[6] + ", 6");
							Writer(inventory[7] + ", 7");
							Writer(inventory[8] + ", 8");
							Writer(inventory[9] + ", 9");
							if(From[2] == true)
							{
								Writer(inventory[10] + ", 10");
								Space();
								Writer("DELETE, 11");
								Writer("END, 12");
							}
							else
							{
								Space();
								Writer("DELETE, 10");
								Writer("END, 11");
							}
							Space();
							option = Reader();
							//Logic inside logic :)
							switch(option)
							{
								case "0":
									switch(inventory[0])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[0] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[0] = "null";
											end = true;
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[0] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[0] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[0] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "1":
									switch(inventory[1])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[1] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[1] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[1] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[1] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[1] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "2":
									switch(inventory[2])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[2] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[2] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[2] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[2] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[2] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "3":
									switch(inventory[3])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[3] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[3] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[3] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[3] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[3] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "4":
									switch(inventory[4])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[4] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[4] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[4] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[4] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[4] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "5":
									switch(inventory[5])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[5] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[5] = "null";
											end = true;
										break;

										
										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[5] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[5] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[5] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "6":
									switch(inventory[6])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[6] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[6] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[6] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[6] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[6] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "7":
									switch(inventory[7])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[7] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[7] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[7] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[7] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[7] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "8":
									switch(inventory[8])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[8] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[8] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[8] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[8] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[8] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "9":
									switch(inventory[9])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}

											inventory[9] = "null";
											end = true;
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
											
											inventory[9] = "null";
											end = true;
										break;


										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[9] = "null";
											end = true;
										break;

										case "EXP UP":
											Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[9] = "null";
											end = true;
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS)
											{
												HP = HEARTS + 10;
											}

											inventory[9] = "null";
											end = true;
										break;

										case "null":
											Space();
											Writer("there is no item in this slot");
										break;

										case "junk":
											Space();
											Writer("How would you use random junk in battle? Try selling it.");
											end = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								break;

								case "10":
									if(From[2] == true)
									{
										switch(inventory[10])
										{
											case "potion":
												Space();
												Writer("You recieved 20 HP!");
												HP += 20;
												if(HP > HEARTS)
												{
													HP = HEARTS;
												}

												inventory[10] = "null";
												end = true;
											break;

											case "heart":
												Space();
												Writer("You gained 5 HP!");
												HEARTS += 5;
												HP += 5;

												inventory[10] = "null";
												end = true;
											break;


											case "ATK UP":
												Space();
												Writer("You buffed up! ATK increased!");
												ATK += 5;

												inventory[10] = "null";
												end = true;
											break;

											case "EXP UP":
												Space();
											Writer("You watched a Uberdemy tutorial! EXP increased!");
											EXP += 1500;
											Space();
											Writer("You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												Space();
												Writer("Max HP: " + HEARTS + ", ATK: " + ATK + ", SPE: " + SPE + ", HP: " + HP);
												Space();
											}
											inventory[10] = "null";
											end = true;
											break;

											case "potion +":
												Space();
												Writer("You recieved 60 HP!");
												HP += 60;
												if(HP > HEARTS)
												{
													HP = HEARTS + 10;
												}

												inventory[10] = "null";
												end = true;
											break;

											case "null":
												Space();
												Writer("there is no item in this slot");
											break;

											case "junk":
												Space();
												Writer("How would you use random junk in battle? Try selling it.");
												end = true;
											break;

											default:
												ErrorWrite();
											break;
										}
									}
									else
									{
										Writer("Which item do you want to throw?");
										Space();
										Writer(inventory[0] + ", 0");
										Writer(inventory[1] + ", 1");
										Writer(inventory[2] + ", 2");
										Writer(inventory[3] + ", 3");
										Writer(inventory[4] + ", 4");
										Writer(inventory[5] + ", 5");
										Writer(inventory[6] + ", 6");
										Writer(inventory[7] + ", 7");
										Writer(inventory[8] + ", 8");
										Writer(inventory[9] + ", 9");
										if(From[2] == true)
										{
											Writer(inventory[10] + ", 10");
											Space();
											Writer("END, 11");
										}
										else
										{
											Space();
											Writer("END, 10");
										}
										Space();
										option = Reader();
										Space();
										stop2 = false;
										//Logic
										while(stop2 == false)
										{
											switch(option)
											{
												case "0":
													Writer("Slot 0 has been deleted!");
													inventory[0] = "null";
													stop2 = true;
												break;

												case "1":
													Writer("Slot 1 has been deleted!");
													inventory[1] = "null";
													stop2 = true;
												break;

												case "2":
													Writer("Slot 2 has been deleted!");
													inventory[2] = "null";
													stop2 = true;
												break;

												case "3":
													Writer("Slot 3 has been deleted!");
													inventory[3] = "null";
													stop2 = true;
												break;

												case "4":
													Writer("Slot 4 has been deleted!");
													inventory[4] = "null";
													stop2 = true;
												break;

												case "5":
													Writer("Slot 5 has been deleted!");
													inventory[5] = "null";
													stop2 = true;
												break;

												case "6":
													Writer("Slot 6 has been deleted!");
													inventory[6] = "null";
													stop2 = true;
												break;

												case "7":
													Writer("Slot 7 has been deleted!");
													inventory[7] = "null";
													stop2 = true;
												break;

												case "8":
													Writer("Slot 8 has been deleted!");
													inventory[8] = "null";
													stop2 = true;
												break;

												case "9":
													Writer("Slot 9 has been deleted!");
													inventory[9] = "null";
													stop2 = true;
												break;

												case "10":
													if(From[2] == true)
													{
														Writer("Slot 10 has been deleted!");
														inventory[10] = "null";
														stop2 = true;
													}
													else
													{
														stop2 = true;
													}
												break;

												case "11":
													if(From[2] == true)
													{
														stop2 = true;
													}
													else
													{
														ErrorWrite();
														stop2 = true;
													}
												break;
											}
										}
									}
								break;

								case "11":
									if(From[2] == true)
									{
										Writer("Which item do you want to throw?");
										Space();
										Writer(inventory[0] + ", 0");
										Writer(inventory[1] + ", 1");
										Writer(inventory[2] + ", 2");
										Writer(inventory[3] + ", 3");
										Writer(inventory[4] + ", 4");
										Writer(inventory[5] + ", 5");
										Writer(inventory[6] + ", 6");
										Writer(inventory[7] + ", 7");
										Writer(inventory[8] + ", 8");
										Writer(inventory[9] + ", 9");
										if(From[2] == true)
										{
											Writer(inventory[10] + ", 10");
											Space();
											Writer("END, 11");
										}
										else
										{
											Space();
											Writer("END, 10");
										}
										Space();
										option = Reader();
										Space();
										stop2 = false;
										//Logic
										while(stop2 == false)
										{
											switch(option)
											{
												case "0":
													Writer("Slot 0 has been deleted!");
													inventory[0] = "null";
													stop2 = true;
												break;

												case "1":
													Writer("Slot 1 has been deleted!");
													inventory[1] = "null";
													stop2 = true;
												break;

												case "2":
													Writer("Slot 2 has been deleted!");
													inventory[2] = "null";
													stop2 = true;
												break;

												case "3":
													Writer("Slot 3 has been deleted!");
													inventory[3] = "null";
													stop2 = true;
												break;

												case "4":
													Writer("Slot 4 has been deleted!");
													inventory[4] = "null";
													stop2 = true;
												break;

												case "5":
													Writer("Slot 5 has been deleted!");
													inventory[5] = "null";
													stop2 = true;
												break;

												case "6":
													Writer("Slot 6 has been deleted!");
													inventory[6] = "null";
													stop2 = true;
												break;

												case "7":
													Writer("Slot 7 has been deleted!");
													inventory[7] = "null";
													stop2 = true;
												break;

												case "8":
													Writer("Slot 8 has been deleted!");
													inventory[8] = "null";
													stop2 = true;
												break;

												case "9":
													Writer("Slot 9 has been deleted!");
													inventory[9] = "null";
													stop2 = true;
												break;

												case "10":
													if(From[2] == true)
													{
														Writer("Slot 10 has been deleted!");
														inventory[10] = "null";
														stop2 = true;
													}
													else
													{
														stop2 = true;
													}
												break;

												case "11":
													if(From[2] == true)
													{
														stop2 = true;
													}
													else
													{
														ErrorWrite();
														stop2 = true;
													}
												break;
											}
										}
									}
									else
									{
										Space();
										Writer("Ended.");
									}
								break;

								case "12":
									if(From[2] == true)
									{
										Space();
										Writer("Ended.");
									}
									else
									{
										ErrorWrite();
									}
								break;

								default:
									ErrorWrite();
								break;
							}
						
						Space();
						Writer("Do you want to do anything else in your bag? (Max HP: " + HEARTS + ", HP: " + HP + ", ATK: " + ATK + ", SPE: " + SPE + ") (y/n)");
						Space();
						option = Reader();
						switch(option)
						{
							case "yes":
							case "YES":
							case "y":
							case "Yes":
							case "1":
								end = false;
							break;

							case "no":
							case "No":
							case "NO":
							case "2":
								end = true;
							break;

							default:
								end = true;
							break;
						}
						break;

						case "2":
						case "NO":
						case "No":
						case "no":
							end = true;
						break;

						default:
							ErrorWrite();
							Space();
							Writer("yes");
							Writer("no");
							Space();
							uption = Reader();
							Space();
						break;
					}
				}
	 }
	 
	 
	 public static void ItemGet()
	{
			if(inventory[0] == "null" || inventory[1] == "null" || inventory[2] == "null" || inventory[3] == "null" || inventory[4] == "null" || inventory[5] == "null" || inventory[6] == "null" || inventory[7] == "null" || inventory[8] == "null" || inventory[9] == "null" || inventory[10] == "null" && From[2] == true)
			{
				inventoryFull = false;
			}
			else if(inventory[0] == "null" || inventory[1] == "null" || inventory[2] == "null" || inventory[3] == "null" || inventory[4] == "null" || inventory[5] == "null" || inventory[6] == "null" || inventory[7] == "null" || inventory[8] == "null" || inventory[9] == "null" && From[2] != true)
			{
				inventoryFull = false;
			}
			else
			{
				inventoryFull = true;
			}
			if(inventoryFull == false)
			{
				//Item system
        Random rande = new Random(); 
        int roller = rande.Next(1, 5);
        //Logic
        Space();
				if (roller == 3 || roller == 4) 
				{
          roller = rande.Next(1, 15);
					switch(roller)
					{
						case 13:
						case 9:
						case 4:
						case 5:
						case 1:
							if (HEARTS < 30)
							{
								Writer("The " + monname + " dropped a potion!");
								//Swear everything is "if else switch" in C#
								if(inventory[0] == "null")
								{
									inventory[0] = "potion";
								}

								else if(inventory[1] == "null")
								{
									inventory[1] = "potion";
								}

								else if(inventory[2] == "null")
								{
									inventory[2] = "potion";
								}

								else if(inventory[3] == "null")
								{
									inventory[3] = "potion";
								}

								else if(inventory[4] == "null")
								{
									inventory[4] = "potion";
								}

								else if(inventory[5] == "null")
								{
									inventory[5] = "potion";
								}

								else if(inventory[6] == "null")
								{
									inventory[6] = "potion";
								}

								else if(inventory[7] == "null")
								{
									inventory[7] = "potion";
								}

								else if(inventory[8] == "null")
								{
									inventory[8] = "potion";
								}

								else if(inventory[9] == "null")
								{
									inventory[9] = "potion";
								}

								else if(inventory[10] == "null" && From[2] == true)
								{
									inventory[10] = "potion";
								}
							}

							if(HEARTS >= 30)
							{
								Writer("The " + monname + " dropped a potion +!");
								//another type of potion amiright?
								if(inventory[0] == "null")
								{
									inventory[0] = "potion +";
								}

								else if(inventory[1] == "null")
								{
									inventory[1] = "potion +";
								}

								else if(inventory[2] == "null")
								{
									inventory[2] = "potion +";
								}

								else if(inventory[3] == "null")
								{
									inventory[3] = "potion +";
								}

								else if(inventory[4] == "null")
								{
									inventory[4] = "potion +";
								}

								else if(inventory[5] == "null")
								{
									inventory[5] = "potion +";
								}

								else if(inventory[6] == "null")
								{
									inventory[6] = "potion +";
								}

								else if(inventory[7] == "null")
								{
									inventory[7] = "potion +";
								}

								else if(inventory[8] == "null")
								{
									inventory[8] = "potion +";
								}

								else if(inventory[9] == "null")
								{
									inventory[9] = "potion +";
								}

								else if(inventory[10] == "null" && From[2] == true)
								{
									inventory[10] = "potion +";
								}
							}
						break;

						case 8:
						case 2:
							Writer("The " + monname + " dropped a ATK UP!");
							//time for logic. Yayyy...
							if(inventory[0] == "null")
							{
								inventory[0] = "ATK UP";
							}
							
							else if(inventory[1] == "null")
							{
								inventory[1] = "ATK UP";
							}

							else if(inventory[2] == "null")
							{
								inventory[2] = "ATK UP";
							}

							else if(inventory[3] == "null")
							{
								inventory[3] = "ATK UP";
							}

							else if(inventory[4] == "null")
							{
								inventory[4] = "ATK UP";
							}

							else if(inventory[5] == "null")
							{
								inventory[5] = "ATK UP";
							}

							else if(inventory[6] == "null")
							{
								inventory[6] = "ATK UP";
							}

							else if(inventory[7] == "null")
							{
								inventory[7] = "ATK UP";
							}

							else if(inventory[8] == "null")
							{
								inventory[8] = "ATK UP";
							}

							else if(inventory[9] == "null")
							{
								inventory[9] = "ATK UP";
							}
							else if(inventory[10] == "null" && From[2] == true)
							{
								inventory[10] = "ATK UP";
							}
						break;

						case 14:
						case 11:
						case 10:
						case 3:
							Writer("The " + monname + " dropped a EXP UP!");
							//MORE MORE MOREEEEEEE!!!
							if(inventory[0] == "null")
							{
								inventory[0] = "EXP UP";
							}
							
							else if(inventory[1] == "null")
							{
								inventory[1] = "EXP UP";
							}

							else if(inventory[2] == "null")
							{
								inventory[2] = "EXP UP";
							}

							else if(inventory[3] == "null")
							{
								inventory[3] = "EXP UP";
							}

							else if(inventory[4] == "null")
							{
								inventory[4] = "EXP UP";
							}

							else if(inventory[5] == "null")
							{
								inventory[5] = "EXP UP";
							}

							else if(inventory[6] == "null")
							{
								inventory[6] = "EXP UP";
							}

							else if(inventory[7] == "null")
							{
								inventory[7] = "EXP UP";
							}

							else if(inventory[8] == "null")
							{
								inventory[8] = "EXP UP";
							}

							else if(inventory[9] == "null")
							{
								inventory[9] = "EXP UP";
							}

							else if(inventory[10] == "null" && From[2] == true)
							{
								inventory[10] = "EXP UP";
							}
						break;

						case 12:
						case 6:
						case 7:
							Writer("The " + monname + " dropped some junk!");
							//O
							if(inventory[0] == "null")
							{
								inventory[0] = "junk";
							}
							
							else if(inventory[1] == "null")
							{
								inventory[1] = "junk";
							}

							else if(inventory[2] == "null")
							{
								inventory[2] = "junk";
							}

							else if(inventory[3] == "null")
							{
								inventory[3] = "junk";
							}

							else if(inventory[4] == "null")
							{
								inventory[4] = "junk";
							}

							else if(inventory[5] == "null")
							{
								inventory[5] = "junk";
							}

							else if(inventory[6] == "null")
							{
								inventory[6] = "junk";
							}

							else if(inventory[7] == "null")
							{
								inventory[7] = "junk";
							}

							else if(inventory[8] == "null")
							{
								inventory[8] = "junk";
							}

							else if(inventory[9] == "null")
							{
								inventory[9] = "junk";
							}

							else if(inventory[10] == "null" && From[2] == true)
							{
								inventory[10] = "junk";
							}
						break;

						default:
							Space(3);
							Writer("ERROR: THERE IS A PROBLEM IN THE RANDE.NEXT GENERATION CODE (LINE: 11892)");
						break;
					}
          return;
        } 
			}	
			else
			{
				Space();
				Writer("The " + monname + " dropped something, but your inventory is full! Try clearing out some items next time!");
			}
  }

		public static void Writer(string write, int type = 1, int speed = 30)
		{
			if(type == 1)
			{
				Console.WriteLine(write, 1);
			}

			else if(type == 2)
			{
				Console.Write(write, 2);
			}

			else if(type == 3)
			{
				for(int i = 0; i < write.Length; i++)
				{
					Console.Write(Convert.ToString(write[i]), 1);
					if(write[i] == '!' || write[i] == '.' || write[i] == '?')
					{
						Thread.Sleep(speed + 220);
					}
					else if(write[i] == ';' || write[i] == ':')
					{
						Thread.Sleep(speed + 70);
					}
					else if(write[i] == ',')
					{
						Thread.Sleep(speed + 50);
					}
					else
					{
						Thread.Sleep(speed);
					}
				}
				Console.WriteLine(" ");
			}

			else if(type == 4)
			{
				for(int i = 0; i < write.Length; i++)
				{
					Console.Write(Convert.ToString(write[i]), 1);
					if(write[i] == '!' || write[i] == '.' || write[i] == '?')
					{
						Thread.Sleep(speed + 220);
					}
					else if(write[i] == ';' || write[i] == ':')
					{
						Thread.Sleep(speed + 70);
					}
					else if(write[i] == ',')
					{
						Thread.Sleep(speed + 50);
					}
					else
					{
						Thread.Sleep(speed);
					}
				}
			}
			else
			{
				type = 1;
			}
		}

		public static void ThrDot()
		{
			Thread.Sleep(900);
			Writer(".", 2);
			Thread.Sleep(400);
			Writer(".", 2);
			Thread.Sleep(400);
			Writer(".", 2);
			Thread.Sleep(900);
		}

		public static string Reader()
		{
			if(firstTime[2] == true)
			{
				Space();
				Writer("Here, type in the options to the letter or number (shown by (# - #)). Type exactly what it says.");
				Color();
				firstTime[2] = false;
			}
			return Console.ReadLine();
		}

		public static void DeathHandler()
		{
			if(HP <= 0)
			{
				if(ending[0] == false)
				{
					Space(2);
					Writer("YOU DIED!");
					End();
				}
				else
				{
					Space(2);
					Writer("YOU DIED...?");
					Enter();
					Console.Clear();
					Color("cyan");
					Writer("SilverAtom: Hello.");
					Enter();
					Writer("SilverAtom: I am SilverAtom, so basically The DRAGON'S god.");
					Enter();
					Writer("SilverAtom: It seems you can no longer carry on right now, so I'll give you an ultimatum.");
					Enter();
					Writer("SilverAtom: Accept your fate and die, or restart from the beginning of the end.");
					Enter();
					Writer("SilverAtom: You can do this " + newDeathCounter + " more time(s), so choose.");
					Space();
					Color("blue");
					Writer("DIE, 1");
					Writer("CONTINUE, 2");
					Space();
					option = Reader();
					while(true)
					{
						switch(option)
						{
							case "CONTINUE":
							case "Continue":
							case "continue":
							case "2":
								Space();
								if(newDeathCounter > 0)
								{
									Space(2);
									Color("cyan");
									Writer("See you later.");
									Thread.Sleep(400);
									HP = HEARTS + 2;
									newDeathCounter--;
									Color();
									EndGame();
									Credits();
									End();
								}
								else
								{
									Space();
									Color("cyan");
									Writer("See you later.");
									Thread.Sleep(800);
									Color("red");
									Writer("ERROR");
									End();
								}
							break;

							case "DIE":
							case "Die":
							case "die":
							case "1":
								Space(2);
								Color("cyan");
								Writer("Very Well. Do not give up!");
								Color();
								End();
							break;

							default:
								ErrorWrite();
								Space();
								Color("cyan");
								Writer("Please.");
								Space();
								Color("blue");
								Writer("DIE, 1");
								Writer("CONTINUE, 2");
								Space();
								option = Reader();
							break;
						}
					}
				}
			}
		}

	}
}