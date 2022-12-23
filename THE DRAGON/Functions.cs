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
	public static partial class Functions
	{
		//variables, classes, objects, and structures
		public class Fighter
		{
			public string name = "", STATUS = "Fine";
			public float HEARTS = 0, HP = 0, ATK = 0, SPE = 0, EXP = 0, EXPNeed = 0, level = 1;
		}
		
		public class Monster
		{
			public float hp = 10;
			public float speed = 3;
			public float attack = 2;
			public string monName = "Monster";
			public float exp = 200F;
			public float gold = 30;
			
			public bool boss = false;
			public bool doubleBattle = false;
			public bool twoEnemy = false;
			
			public float hpTwo = 10;
			public float speedTwo = 10;
			public float attackTwo = 1;
			public string monNameTwo = "Monster 2";
			
			public int teamMate = 0;
			
			public string status = "Fine";
			
			public string powerAttack = "Super Hit";
			public float powerAttackHit = 10;
			public float powerAttackHeal = 2;
			
			public bool isHealing = false;
			public bool isDefending = false;
			
			public int waitTime = 1;
			public string statusAfflict = "null";
			
			public bool hasWeight = true;
			public bool hasPattern = false;
			
			public string statusTwo = "Fine";
			
			public string powerAttackTwo = "Super Hit";
			public float powerAttackHitTwo = 10;
			public float powerAttackHealTwo = 2;
			
			public bool isHealingTwo = false;
			public bool isDefendingTwo = false;
			
			public int waitTimeTwo = 0;
			public string statusAfflictTwo = "null";
			
			public bool hasWeightTwo = true;
			public bool hasPatternTwo = false;
			
			public int[] patternTwo = null;
			
			public int[] weight = null;
			public int[] pattern = null;
			
			public int[] weightTwo = null;
			
			public string message = null;
		}

		public static string option = "N/A", name = "Samuel", team = name, Choose = "", STATUS = "Fine", prevColor = "", prevColor2 = "";
		public static float EXP = 0, EXPNeed = 2000, SPE = 18, HP = 20, HEARTS = 20, ATK = 5, GOLD = 500, bountyNeed = 5/*how many bounties to next level*/, bountyCollected = 0, bountiesCleared = 0, bountyCost = 0;

		public static int level = 1, WILL = 0, re = 0, newDeathCounter = 30, regular, bountyLevel = 1/*1 = easyOnly, 2 = medium & easy, 3 hard, medium, & easy, 4 = miniBosses and all others*/, area = 1;
		public static bool noCabin = false, stop = false, dodge = false, debug = true, stop2 = false, inventoryFull = false, stupidBool = true, quickEnd = false, hasBounty = false, stop3 = false, newgame = true, hasStarted = false, goAnyway = false;
		
		//static Object[] Mark = new Object[] {45/*hp, 0*/, 25/*speed, 1*/, 23/*attack, 2*/, "Mark Conjure"/*name, 3*/};

		public static string[] inventory = {"potion", "potion", "potion", "null", "null", "null", "null", "null", "null", "null", "null"/*not used until endgame*/}, go1 = {"springs", "hills", "forests", "debug"}, storage = {"null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null", "null"};
		public static float[] bountyCostings = {0, 0, 0};//How much the bounties cost

		public static int[] Bounty1 = {0/*1 = easy, 2 = medium, 3 = hard*/, 0, 0, 0/* if one, also miniboss*/},Bounty2 = {0/*1 = easy, 2 = medium, 3 = hard*/, 0, 0, 0/* if one, also miniboss*/}, Bounty3 = {0/*1 = easy, 2 = medium, 3 = hard*/, 0, 0, 0/* if one, also miniboss*/};
		public static bool[] firstTime = {true/*SPECIAL*/, true/*attacking, grabbing, running*/, true/*options*/, true/*enter*/, true/*shopping*/, true/*bounty board*/, true/*apartments*/, true/*hunt zone*/}, From = {false/*springs 2*/, false/*hills*/, false/*forest Mountains*/, false/*forest hills*/, false/*springs 1*/}, ending = {false/*first*/, false/*second, final*/}, bounties = {false/*easyEnemy*/, false/*easyEnemy*/, false/*easyEnemy*/, false/*medium enemy*/, false/*medium enemy*/, false/*medium enemy*/, false/*hard enemy*/, false/*hard enemy*/, false/*hard enemy*/, false/*miniboss enemy*/} /*the current bounty*/, storyEventFM = {true/*Dinner*/, true, true, true, true, true}, playedWith = {true, false, false, false};
		
		public static Fighter Mark = new Fighter() {HEARTS = 50, HP = 50, ATK = 23, SPE = 25, name = "Mark Conjure", EXP = 0, EXPNeed = 2000}, Breys = new Fighter() {HEARTS = 80, HP = 80, ATK = 40, SPE = 90, name = "Breys Swolder", EXP = 0, EXPNeed = 10000}, Sapphire = new Fighter() {HEARTS = 100, HP = 100, ATK = 45, SPE = 70, name = "Sapphire Jewls", EXP = 0, EXPNeed = 9000}, Captain = new Fighter() {HEARTS = 250, HP = 250, ATK = 50, SPE = 50, name = "Captain"};
		public static Fighter enemy = new Fighter() {HP = 40, ATK = 15, SPE = 35};
		
		public static Random rando = new Random();
		public static Random monRand = new Random();

		//Teammate variables
		public static float fMark_1 = Mark.HEARTS;//fMark_1
		public static float teamMateHP = Mark.HP;//fMark0
		public static float teamMateSPE = Mark.SPE;//fMark1
		public static float teamMateATK = Mark.ATK;//fMark2
		public static string teamMateName = Mark.name;//fMark3
		public static float teamMateLevel = Mark.level;//fMark4
		public static float teamMateEXP = Mark.EXP;//fMark5
		public static float teamMateEXPNeed = Mark.EXPNeed;//fMark6
		public static int teamMater;

		//Binary Saving
		public static Stream stream;
		public static BinaryFormatter bf = new BinaryFormatter();

		//functions
		public static void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			//throw new NotImplementedException();

			info.AddValue("HP", HP);
			info.AddValue("HEARTS", HEARTS);
			info.AddValue("ATK", ATK);
			info.AddValue("SPE", SPE);
			info.AddValue("EXP", EXP);
			info.AddValue("EXPNeed", EXPNeed);
			info.AddValue("level", level);
			info.AddValue("name", name);
			info.AddValue("STATUS", STATUS);
			info.AddValue("GOLD", GOLD);
			
			info.AddValue("bountyNeed", bountyNeed);
			info.AddValue("bountyCollected", bountyCollected);
			info.AddValue("bountiesCleared", bountiesCleared);
			info.AddValue("bountyCost", bountyCost);
			info.AddValue("bountyLevel", bountyLevel);
			info.AddValue("hasBounty", hasBounty);

			info.AddValue("noCabin", noCabin);
			info.AddValue("newDeathCounter", newDeathCounter);
			
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
			for(int i = 0; i < From.Length; i++)
			{
				info.AddValue("From " + i, From[i]);
			}

			for(int i = 0; i < bounties.Length; i++)
			{
				info.AddValue("bounties " + i, bounties[i]);
			}
			for(int i = 0; i < bountyCostings.Length; i++)
			{
				info.AddValue("bountyCostings " + i, bountyCostings[i]);
			}
			for(int i = 0; i < storyEventFM.Length; i++)
			{
				info.AddValue("storyEventFM " + i, storyEventFM[i]);
			}

			for(int i = 0; i < playedWith.Length; i++)
			{
				info.AddValue("playedWith " + i, playedWith[i]);
			}
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
			HEARTS = (float)info.GetValue("HEARTS", typeof(float));
			STATUS = (string)info.GetValue("STATUS", typeof(string));
			GOLD = (float)info.GetValue("GOLD", typeof(float));
			
			bountyNeed = (float)info.GetValue("bountyNeed", typeof(float));
			bountyCollected = (float)info.GetValue("bountyCollected", typeof(float));
			bountiesCleared = (float)info.GetValue("bountiesCleared", typeof(float));
			bountyCost = (float)info.GetValue("bountyCost", typeof(float));
			bountyLevel = (int)info.GetValue("bountyLevel", typeof(int));
			hasBounty = (bool)info.GetValue("hasBounty", typeof(bool));
			
			noCabin = (bool)info.GetValue("noCabin", typeof(bool));
			newDeathCounter = (int)info.GetValue("", typeof(int));
			
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
			for(int i = 0; i < From.Length; i++)
			{
				From[i] = (bool)info.GetValue("From " + i, typeof(bool));
			}

			for(int i = 0; i < bounties.Length; i++)
			{
				bounties[i] = (bool)info.GetValue("bounties " + i, typeof(bool));
			}
			for(int i = 0; i < bountyCostings.Length; i++)
			{
				bountyCostings[i] = (float)info.GetValue("bountyCostings " + i, typeof(float));
			}
			for(int i = 0; i < storyEventFM.Length; i++)
			{
				storyEventFM[i] = (bool)info.GetValue("storyEventFM " + i, typeof(bool));
			}

			for(int i = 0; i < playedWith.Length; i++)
			{
				playedWith[i] = (bool)info.GetValue("playedWith " + i, typeof(bool));
			}
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

			bf.Serialize(stream, HEARTS);
			bf.Serialize(stream, STATUS);
			bf.Serialize(stream, GOLD);
			
			bf.Serialize(stream, bountyNeed);
			bf.Serialize(stream, bountyCollected);
			bf.Serialize(stream, bountiesCleared);
			bf.Serialize(stream, bountyCost);
			bf.Serialize(stream, bountyLevel);
			bf.Serialize(stream, hasBounty);
			
			bf.Serialize(stream, noCabin);
			bf.Serialize(stream, newDeathCounter);
			
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
			for(int i = 0; i < From.Length; i++)
			{
				bf.Serialize(stream, From[i]);
			}

			for(int i = 0; i < bounties.Length; i++)
			{
				bf.Serialize(stream, bounties[i]);
			}
			for(int i = 0; i < bountyCostings.Length; i++)
			{
				bf.Serialize(stream, bountyCostings[i]);
			}
			for(int i = 0; i < storyEventFM.Length; i++)
			{
				bf.Serialize(stream, storyEventFM[i]);
			}

			for(int i = 0; i < playedWith.Length; i++)
			{
				bf.Serialize(stream, playedWith[i]);
			}
			
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

			HEARTS = (float)bf.Deserialize(stream);
			STATUS = (string)bf.Deserialize(stream);
			GOLD = (float)bf.Deserialize(stream);

			bountyNeed = (float)bf.Deserialize(stream);
			bountyCollected = (float)bf.Deserialize(stream);
			bountiesCleared = (float)bf.Deserialize(stream);
			bountyCost = (float)bf.Deserialize(stream);
			bountyLevel = (int)bf.Deserialize(stream);
			hasBounty = (bool)bf.Deserialize(stream);

			noCabin = (bool)bf.Deserialize(stream);
			newDeathCounter = (int)bf.Deserialize(stream);
			
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
			for(int i = 0; i < From.Length; i++)
			{
				From[i] = (bool)bf.Deserialize(stream);
			}

			for(int i = 0; i < bounties.Length; i++)
			{
				bounties[i] = (bool)bf.Deserialize(stream);
			}
			for(int i = 0; i < bountyCostings.Length; i++)
			{
				bountyCostings[i] = (float)bf.Deserialize(stream);
			}
			for(int i = 0; i < storyEventFM.Length; i++)
			{
				storyEventFM[i] = (bool)bf.Deserialize(stream);
			}

			for(int i = 0; i < playedWith.Length; i++)
			{
				playedWith[i] = (bool)bf.Deserialize(stream);
			}
			
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
      		if(spaces <= 0) spaces = 1;
			for(int i = 0; i < spaces; i++)
			{
				Console.WriteLine();
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

		public static void Color(string color = "null", bool setTheColor = true)
		{
			switch(color)
			{
				case "null":
					Writer("[0m", 2);
					if(setTheColor)	prevColor2 = "[0m";
				break;

				case "bold":
					Writer("[0;1m", 2);
					if(setTheColor)	prevColor2 = "[0;1m";
				break;

				case "red":
					Writer("[1;31m", 2);
					if(setTheColor)	prevColor2 = "[1;31m";
				break;

				case "yellow":
					Writer("[1;33m", 2);
					if(setTheColor)	prevColor2 = "[1;33m";
				break;

				case "blue":
					Writer("[1;34m", 2);
					if(setTheColor)	prevColor2 = "[1;34m";
				break;

				case "green":
					Writer("[1;32m", 2);
					if(setTheColor)	prevColor2 = "[1;32m";
				break;

				case "cyan":
					Writer("[1;36m", 2);
					if(setTheColor)	prevColor2 = "[1;36m";
				break;

				case "pink":
					Writer("[1;31m", 2);
					if(setTheColor)	prevColor2 = "[1;31m";
				break;

				case "purple":
					Writer("[1;35m", 2);
					if(setTheColor)	prevColor2 = "[1;35m";
				break;

				case "gray":
				case "grey":
					Writer("[0;37m", 2);
					if(setTheColor)	prevColor2 = "[0;37m";
				break;

				case "previous":
				case "pre":
				case "prev":
					Writer(prevColor, 2);
				break;

				case "black":
					Writer("[0;30m", 2);
					if(setTheColor)	prevColor2 = "[0;30m";
				break;
			}

			/*
				case "null":
						if(setTheColor)	prevColor = "[0m";
						return "[0m";

					case "bold":
						if(setTheColor)	prevColor = "[0;1m";
						return "[0;1m";

					case "red":
						if(setTheColor)	prevColor = "[1;31m";
						return "[1;31m";

					case "yellow":
						if(setTheColor)	prevColor = "[1;33m";
						return "[1;33m";

					case "blue":
						if(setTheColor)	prevColor = "[1;34m";
						return "[1;34m";

					case "green":
						if(setTheColor)	prevColor = "[1;32m";
						return "[1;32m";

					case "cyan":
						if(setTheColor)	prevColor = "[1;36m";
						return "[1;36m";

					case "pink":
						if(setTheColor)	prevColor = "[1;31m";
						return "[1;31m";

					case "purple":
						if(setTheColor)	prevColor = "[1;35m";
						return "[1;35m";

					case "gray":
					case "grey":
						if(setTheColor)	prevColor = "[0;37m";
						return "[0;37m";

					case "previous":
					case "pre":
					case "prev":
						return prevColor;

					case "black":
						if(setTheColor)	prevColor = "[0;30m";
						return "[0;30m";

					default:
						if(setTheColor)	prevColor = "[0m";
						return "[0m";
				}
			*/
		}

		public static string SetColor(string color = "null", bool setTheColor = false)
		{
			if(setTheColor)	prevColor = color;
			
			switch(color)
			{
				case "null":
					if(setTheColor)	prevColor = "[0m";
					return "[0m";

				case "bold":
					if(setTheColor)	prevColor = "[0;1m";
					return "[0;1m";

				case "red":
					if(setTheColor)	prevColor = "[1;31m";
					return "[1;31m";

				case "yellow":
					if(setTheColor)	prevColor = "[1;33m";
					return "[1;33m";

				case "blue":
					if(setTheColor)	prevColor = "[1;34m";
					return "[1;34m";

				case "green":
					if(setTheColor)	prevColor = "[1;32m";
					return "[1;32m";

				case "cyan":
					if(setTheColor)	prevColor = "[1;36m";
					return "[1;36m";

				case "pink":
					if(setTheColor)	prevColor = "[1;31m";
					return "[1;31m";

				case "purple":
					if(setTheColor)	prevColor = "[1;35m";
					return "[1;35m";

				case "gray":
				case "grey":
					if(setTheColor)	prevColor = "[0;37m";
					return "[0;37m";

				case "previous2":
				case "pre2":
				case "prev2":
					return prevColor2;

				case "black":
					if(setTheColor)	prevColor = "[0;30m";
					return "[0;30m";

				default:
					if(setTheColor)	prevColor = "[0m";
					return "[0m";
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
						if((Array.FindIndex(inventory, 0, 11, x => x == "null") != -1 && !From[2]) || (Array.FindIndex(inventory, 0, 12, x => x == "null") != -1 && From[2]))
						{
							inventoryFull = false;
						}
						else
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
												inventory[i] = "potion";
												break;
											}
											if(i == 10 && !From[2])
											{
												break;
											}
										}
									}
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping? (1 - 2)");
										Space();
										Writer("yes");
										Writer("no");
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
										Writer("Do you want to stop shopping? (1 - 2)");
										Space();
										Writer("yes");
										Writer("no");
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
										Writer("Do you want to stop shopping? (1 - 2)");
										Space();
										Writer("yes");
										Writer("no");
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
										Writer("You gained 3 ATK!");
										ATK += 3;
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
										Writer("Do you want to stop shopping? (1 - 2)");
										Space();
										Writer("yes");
										Writer("no");
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
										Writer("Do you want to stop shopping? (1 - 2)");
										Space();
										Writer("yes");
										Writer("no");
										Space();
										option = Reader();
										switch(option)
										{
											case "1":
											case "yes":
												Space();
												Writer("CabinMaster: Ok! See ya!");
												Enter();
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
								stop = false;
								while(!stop)
								{
									Space();
									if(From[2] == false)
										Writer("What shall you sell? (0 - 9)");
									else
										Writer("What shall you sell? (0 - 10)");
									
									Space();

									//Logic (help)
									//future me: gotchu bro
									for(int i = 0; i < 10; i++) Writer(inventory[i] + ", " + i);
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
									
									for(int i = 0; (i < 11 && !From[2]) || (i < 12 && From[2]); i++)
									{
										if(option == "10" || option == "11")
										{
											switch(option)
											{
												case "10":
													if(!From[2])
														stop = true;
												break;

												case "11":
													if(From[2])
														stop = true;
													else
														ErrorWrite();
												break;
											}
										}
										else if(option == "" + i + "")
										{
											switch(inventory[i])
											{
												case "potion":
													Writer("You sold your " + inventory[i] + "! That'll be worth " + Math.Round(potions/2) + "!");
													Writer("You gained " + Math.Round(potions/2) + " GOLD!");
													GOLD += (float) Math.Round(potions_plus/2);
													inventory[i] = "null";
												break;

												case "potion +":
													Writer("You sold your " + inventory[i] + "! That'll be worth " + Math.Round(potions_plus/2) + "!");
													Writer("You gained " + Math.Round(potions_plus/2) + " GOLD!");
													GOLD += (float) Math.Round(potions_plus/2);
													inventory[i] = "null";
												break;
												
												case "EXP UP":
													Writer("You sold your " + inventory[i] + "! That'll be worth " + Math.Round(EXP_UPs/2) + "!");
													Writer("You gained " + Math.Round(EXP_UPs/2) + " GOLD!");
													GOLD += (float) Math.Round(EXP_UPs/2);
													inventory[i] = "null";
												break;
												
												case "ATK UP":
													Writer("You sold your " + inventory[i] + "! That'll be worth " + Math.Round(ATK_UPs/2) + "!");
													Writer("You gained " + Math.Round(ATK_UPs/2) + " GOLD!");
													GOLD += (float) Math.Round(ATK_UPs/2);
													inventory[i] = "null";
												break;
												
												case "heart":
													Writer("You sold your " + inventory[i] + "! That'll be worth " + Math.Round(HEARTS/2) + "!");
													Writer("You gained " + Math.Round(HEARTS/2) + " GOLD!");
													GOLD += (float) Math.Round(HEARTS/2);
													inventory[i] = "null";
												break;
												
												case "junk":
													re = rando.Next(256, 913);
													Writer("You sold your " + inventory[i] + "! That'll be worth " + re + "!");
													Writer("You gained " + re + " GOLD!");
													GOLD += re;
													inventory[i] = "null";
												break;
												
												case "null":
													Writer("There's nothing there!");
												break;
											}
										}
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

		//go to here: Turn every single monster into a Monster class object.
		//go here 2 (2nd priority after above): troubleshoot Double-Double battles, fix Mark Conjure text (deal with Color() and SetColor())
		
		/*float hp = 10, float speed = 3, float attack = 2, string monName = "Monster",  float exp = 200F, float gold = 30, bool boss = false, bool doubleBattle = false, bool twoEnemy = false, float hpTwo = 10, float speedTwo = 10, float attackTwo = 1, string monNameTwo = "Monster 2", int teamMate = 0, string status = "Fine", string powerAttack = "Super Hit", float powerAttackHit = 10, float powerAttackHeal = 2, bool isHealing = false, bool isDefending = false, int waitTime = 1, string statusAfflict = "null", bool hasWeight = true, bool hasPattern = false, string statusTwo = "Fine", string powerAttackTwo = "Super Hit", float powerAttackHitTwo = 10, float powerAttackHealTwo = 2, bool isHealingTwo = false, bool isDefendingTwo = false, int waitTimeTwo = 0,string statusAfflictTwo = "null", bool hasWeightTwo = true, bool hasPatternTwo = false, int[] patternTwo = null, int[] weight = null, int[] pattern = null, int[] weightTwo = null, string message = null, */

		//My pride and joy
		static string monname = "Enemy";
    	public static void MonsterEncounter(float hp = 10, float speed = 3, float attack = 2, string monName = "Monster",  float exp = 200F, float gold = 30, bool boss = false, bool doubleBattle = false, bool twoEnemy = false, float hpTwo = 10, float speedTwo = 10, float attackTwo = 1, string monNameTwo = "Monster 2", int teamMate = 0, string status = "Fine", string powerAttack = "Super Hit", float powerAttackHit = 10, float powerAttackHeal = 2, bool isHealing = false, bool isDefending = false, int waitTime = 1, string statusAfflict = "null", bool hasWeight = true, bool hasPattern = false, string statusTwo = "Fine", string powerAttackTwo = "Super Hit", float powerAttackHitTwo = 10, float powerAttackHealTwo = 2, bool isHealingTwo = false, bool isDefendingTwo = false, int waitTimeTwo = 0,string statusAfflictTwo = "null", bool hasWeightTwo = true, bool hasPatternTwo = false, int[] patternTwo = null, int[] weight = null, int[] pattern = null, int[] weightTwo = null, string message = null, Monster monster = null, bool useClass = false, bool canRun = true)
		{
      		//setting Monster
			if(useClass && monster == null)
			{
				monster = basic;
			}
			
			//variables
      		string[] toDo = {"Attack", "Run", "Grab", "SPECIAL", "Defend"};
      		string Choose = "";
			bool noSpecial = false, single = true, waitTiming = false, waitTimingTwo = false, SPECIALING = false/*if performing a SPECIAL Attack*/, GRABBING = false/*if grabbing*/, DEFENDING = false/*checks if player is defending*/, yok = false/*checks if you entered the right action*/;
			bool[] enemyDown = {false/*enemy two*/, false/*enemy one*/, false}, stopText = {false/*enemy two*/, false/*enemy one*/, false/*both*/};
			float[] weightAmount = new float[] {25, 50, 75, 100}, weightAmountTwo = new float[] {25, 50, 75, 100};
			float MaxHp = hp;
			int startWaitTime = waitTime, startWaitTimeTwo = waitTimeTwo, nextPattern = 0, nextPatternTwo = 0, currentVenom = 2, currentVenomMon = 2, currentVenomMonTwo = 2, re2 = 0;
			int actualSPE = (int) SPE;//the speed that makes sure SPE stays the same at the end of the fight
			teamMater = teamMate;

			if(useClass)
			{
				hp = monster.hp;
				speed = monster.speed;
				attack = monster.attack;
				monName = monster.monName;
				exp = monster.exp;
				gold = monster.gold;
				
				boss = monster.boss;
				doubleBattle = monster.doubleBattle;
				twoEnemy = monster.twoEnemy;
				
				hpTwo = monster.hpTwo;
				speedTwo = monster.speedTwo;
				attackTwo = monster.attackTwo;
				monNameTwo = monster.monNameTwo;
				
				teamMate = monster.teamMate;
				
				status = monster.status;
				
				powerAttack = monster.powerAttack;
				powerAttackHit = monster.powerAttackHit;
				powerAttackHeal = monster.powerAttackHeal;
				
				isHealing = monster.isHealing;
				isDefending = monster.isDefending;
				
				waitTime = monster.waitTime;
				statusAfflict = monster.statusAfflict;
				
				hasWeight = monster.hasWeight;
				hasPattern = monster.hasPattern;
				
				statusTwo = monster.statusTwo;
				
				powerAttackTwo = monster.powerAttackTwo;
				powerAttackHitTwo = monster.powerAttackHitTwo;
				powerAttackHealTwo = monster.powerAttackHealTwo;
				
				isHealingTwo = monster.isHealingTwo;
				isDefendingTwo = monster.isDefendingTwo;
				
				waitTimeTwo = monster.waitTimeTwo;
				statusAfflictTwo = monster.statusAfflictTwo;
				
				hasWeightTwo = monster.hasWeightTwo;
				hasPatternTwo = monster.hasPatternTwo;
				
				patternTwo = monster.patternTwo;
				
				weight = monster.weight;
				pattern = monster.pattern;
				
				weightTwo = monster.weightTwo;
				
				message = monster.message;
			}

			float[] turnOrder = {SPE, speed};

			if(turnOrder[0] == turnOrder[1])
			{
				Writer("does this");
				turnOrder[1]--;
				speed--;
			}

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
			
			//setting the teammate variables
			TeamMater();

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
					if(message == null) Writer(SetColor("red") + monName + " and " + monNameTwo + " is at battle with you! What shall you two do?");
					else
					{
						Writer(SetColor("red") + monName + " and " + monNameTwo + message);
					}
				}

				else if (boss == false && twoEnemy == false)
				{
					if(message == null) Writer(SetColor("red") + monName + " is at battle with you! What shall you two do?");
					else
					{
						Writer(SetColor("red") + monName + message);
					}
				}

				else if(boss == true && twoEnemy == false)
				{
					Color("pink");
					if(message == null) Writer(SetColor("purple") + monName + SetColor("red") + " blocks the way! What shall you two do, for your lives is on the line?");
					else
					{
						Writer(SetColor("purple") + monName + SetColor("red") + message);
					}
				}

				if(boss == true && twoEnemy == true)
				{
					if(message == null) Writer(SetColor("purple") + monName + SetColor("red") + " and " + SetColor("purple") + monNameTwo + SetColor("red") + " blocks the way! It's rippin' time!");
					else
					{
						Writer(SetColor("purple") + monName + SetColor("red") + " and " + SetColor("purple") + monNameTwo + SetColor("red") + message);
					}
				}
			}

			else if (doubleBattle == false)
			{
				if(boss == false && twoEnemy == false)
				{
					if(message == null) Writer(SetColor("red") + monName + " is at battle with you! What shall you do?");
					else
					{
						Writer(SetColor("red") + monName + message);
					}
				}

				if(boss == true && twoEnemy == false)
				{
					Color("pink");
					if(message == null) Writer(SetColor("purple") + monName + SetColor("red") + " blocks the way! What shall you do, for your life is on the line?");
					else
					{
						Writer(SetColor("purple") + monName + SetColor("red") + message);
					}
				}

				if(boss == true && twoEnemy == true)
				{
					Color("pink");
					if(message == null) Writer(SetColor("purple") + monName + SetColor("red") + " and " + SetColor("purple") + monNameTwo + SetColor("red") + " Block the way!");
					else
					{
						Writer(SetColor("purple") + monName + SetColor("red") + " and " + SetColor("purple") + monNameTwo + SetColor("red") + message);
					}
				}

				if(boss == false && twoEnemy == true)
				{
					if(message == null) Writer(SetColor("red") + monName + " and " + monNameTwo + " are at battle with you! What shall you do?");
					else
					{
						Writer(SetColor("red") + monName + " and " + monNameTwo + message);
					}
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
					Writer("Your HP: " + HP + ", " + monName + " HP: " + hp + ", " + teamMateName + " HP: " + teamMateHP);
				}

				if(twoEnemy == true)
				{
					Writer("Your HP: " + HP + ", " + monName + " HP: " + hp + ", " + monNameTwo + " HP: " + hpTwo + ", " + teamMateName + " HP: " + teamMateHP);
				}
			}

			noSpecial = false;
			Space();

			//turn order of battle
			if(doubleBattle)
			{
				Array.Resize(ref turnOrder, turnOrder.Length + 1);
				turnOrder[turnOrder.GetUpperBound(0)] = teamMateSPE;
			} if(twoEnemy)
			{
				Array.Resize(ref turnOrder, turnOrder.Length + 1);
				turnOrder[turnOrder.GetUpperBound(0)] = speedTwo;
			}

			if(Array.FindIndex(turnOrder, x => x == speedTwo) != -1 && turnOrder[Array.FindIndex(turnOrder, x => x == speed)] == turnOrder[Array.FindIndex(turnOrder, x => x == speedTwo)])//if speed is equal to speedTwo
			{	
				turnOrder[Array.FindIndex(turnOrder, x => x == speedTwo)]--;
				speedTwo--;
			}
			if(Array.FindIndex(turnOrder, x => x == teamMateSPE) != -1 && turnOrder[Array.FindIndex(turnOrder, x => x == SPE)] == turnOrder[Array.FindIndex(turnOrder, x => x == teamMateSPE)])//if SPE is equal to teamMateSPE
			{	
				turnOrder[Array.FindIndex(turnOrder, x => x == teamMateSPE)]--;
				teamMateSPE--;
			}

      		yok = false;//checks for if you entered something wrong.
			while(!yok)
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

				Color("green");
				Writer(toDo[2]);
				
				Color("blue");
				Writer(toDo[1]);

				Color("null");
				
				Space();
				Choose = Reader();

				switch(Choose)
				{
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
						yok = true;
					break;

					case "1":
					case "Special":
					case "special":
					case "SPECIAL":
						yok = true;
					break;

					case "3":
					case "defend":
					case "DFD":
					case "dfd":
					case "Dfd":
					case "Defend":
					case "DEFEND":
						yok = true;
					break;


					case "4":
					case "GRAB":
					case "Grab":
					case "grab":
						yok = true;
					break;

					case "5":
					case "run":
					case "RUN":
					case "Run":
						yok = true;
					break;

					default:
						ErrorWrite();
					break;
				}
			}
      		bool fighting = true;
			
      		while(fighting) 
			{		
				if(single || (doubleBattle && twoEnemy))
				{
					fighting = hp > 0;
					if(HP <= 0)
						DeathHandler();
				}
				else if(twoEnemy)
				{
					fighting = hp > 0 || hpTwo > 0;
					if(HP <= 0)
						DeathHandler();
				}

				//checking if priority is needed
				switch(Choose) 
				{
					case "1":
					case "Special":
					case "special":
					case "SPECIAL":
						SPECIALING = true;
						DEFENDING = false;
					break;

					case "4":
					case "GRAB":
					case "Grab":
					case "grab":
						GRABBING = true;
						DEFENDING = false;
					break;
				}
				
				
				Array.Sort(turnOrder);
				Array.Reverse(turnOrder);
				
				if(SPECIALING || GRABBING)
				{
					if(Array.FindIndex(turnOrder, x => x == SPE) != -1) ShiftElement(turnOrder, Array.FindIndex(turnOrder, x => x == SPE), 0);
				}

				for(int t = 0; t < turnOrder.Length; t++) 
				{
					if(turnOrder[t] == SPE || turnOrder[t] == turnOrder.Max() + 1)
					{
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
													if(!twoEnemy)
													{
														SPECIALING = true;
														Space();
														Writer("You preformed the UPLIFTING UPPERCUT! " + monName + " was slashed up, and sliced down! dealing " + Convert.ToInt32(ATK * 1.7) + " damage!");
														hp -= Convert.ToInt32(ATK * 1.7);
														WILL -= 100;
														noSpecial = true;
														stop = true;
													}
													else
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
																	SPECIALING = true;
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
																	SPECIALING = true;
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
											break;

											case "2":								
											case "MACHSLASH":									
											case "machslash":
											case "mach slash":
											case "Mach Slash":
											case "MachSlash":
												if(WILL >= 160)
												{
													if(!twoEnemy)
													{
														SPECIALING = true;
														Space();
														Writer("You preformed the MACHSLASH! " + monName + " was slashed 100 times! dealing " + 70 + " damage!");
														WILL -= 90;
														hp -= 70;
														noSpecial = true;
														stop = true;
													}
													else
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
																	SPECIALING = true;
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
																	SPECIALING = true;
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
											break;

											case "3":								
											case "SPEED SLICE":
											case "speed slice":
											case "Speed Slice":
												if(WILL >= 100)
												{
													if(!twoEnemy)
													{
														SPECIALING = true;
														Space();
														Writer("You preformed the SPEED SLICE! " + monName + " was slashed through at blinding speeds, dealing " + 50 + " damage!");
														WILL -= 60;
														hp -= 50;
														noSpecial = true;
														stop = true;
													}
													else
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
																	SPECIALING = true;
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
																	SPECIALING = true;
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
											break;

											case "4":
											case "BUSTER BEAM":
											case "buster beam":
											case "Buster Beam":
												if(WILL >= 40)
												{
													if(!twoEnemy)
													{
														SPECIALING = true;
														Space();
														Writer("You preformed the BUSTER BEAM! " + monName + " was blasted with a sword beam made of WILL, dealing " + Convert.ToInt32	(ATK * 2.5) + " damage!");
														WILL -= 40;
														hp -= Convert.ToInt32(ATK * 1.5);
														noSpecial = true;
														stop = true;
													}
													else
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
																	SPECIALING = true;
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
																	SPECIALING = true;
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
													if(!twoEnemy)
													{
														SPECIALING = true;
														Space();
														Writer("You preformed the OMNIWEB-ULTACUTTER! " + monName + " was slashed too many times to count! Making a web formation dealing " + Convert.ToInt32(ATK * 3.5) + " damage!");
														WILL -= 220;
														hp -= Convert.ToInt32(ATK * 3.5);
														noSpecial = true;
														stop = true;
													}
													else
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
																	SPECIALING = true;
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
																	SPECIALING = true;
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
													Writer("You tried to do the OMNIWEB-ULTACUTTER, but failed miserabely! You took " + Convert.ToInt32(HP/3) + " HP!");
													WILL = 0;
													HP -= Convert.ToInt32(HP/3);
													noSpecial = true;
												}
												stop = true;
											break;

											case "6":
											case "Dodge":
											case "dodge":
												SPECIALING = true;
												Space();
												Writer("You will dodge the next move of a monster!");
												dodge = true;
												stop = true;
											break;

											case "7":
											case "End":
											case "end":
												SPECIALING = true;
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
												Color();
												Space();
												option = Reader();
											break;
										}
									}
								}

								else if(WILL <= 20)
								{
									Color("red");
									Writer("You don't have enough WILL to do any special attacks!");
									Color();
								}

								else if(noSpecial == true)
								{
									Space();
									Color("red");
									Writer("You have done a SPECIAL Attack! Now you can't do another in this battle.");
									Color("cyan");
									Space();
									Writer("Dodge, 6");
									Writer("End, 7");
									Space();
									Color();
									option = Reader();
									stop = false;
									while(!stop)
									{
										if(option == "6" || option == "Dodge" || option == "dodge")
										{
											Space();
											Writer("You will dodge the next move of a monster!");
											dodge = true;
											stop = true;
										}
										else if(option == "End" || option == "end" || option == "7")
										{
											Writer("You decided not to do a SPECIAL Attack. But by thinking of it, you didn't have time to do something else.");
										}
										else
										{
											ErrorWrite();
											Space();
											Color("red");
											Writer("You have done a SPECIAL Attack! Now you can't do another in this battle.");
											Color("cyan");
											Space();
											Writer("Dodge, 6");
											Writer("End, 7");
											Space();
											Color();
											option = Reader();
										}
									}
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
							default:
								DEFENDING = false;
								if(!twoEnemy)
								{
									//player death check
									DeathHandler();
									//player
									int re = rando.Next(1, 13);

									//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
									switch(re) 
									{
										case 9:
										case 1: //weak
											Space();
											Color("yellow");
											if(!isDefending)
											{
												Writer("You attacked! " + monName + " lost " + (int) ATK * 2/3 + " HP! That was a weak hit!");
												Color();
												hp -= (int) ATK * 2/3;
												WILL += 5;
											}
											else if(isDefending)
											{
												Writer("You attacked! While " + monName + " was defending, it still lost " + (int) ATK * 1/3 + " HP! That was a measly hit!");
												Color();
												hp -= (int) ATK * 1/3;
												isDefending = false;
												WILL += 2;
											}
										break;

										case 10:
										case 8:
										case 5:
										case 6:
										case 2: //neutral
											if(!isDefending)
											{
												Space();
												Color("green");
												Writer("You attacked! " + monName + " lost " + ATK + " HP!");
												Color();
												hp -= ATK;
												WILL += 10;
											}
											else if(isDefending)
											{
												Space();
												Color("green");
												Writer("You attacked! While " + monName + " was defending, it still lost " + Convert.ToInt32(ATK * 7/9) + " HP!");
												Color();
												hp -= Convert.ToInt32(ATK * 7/9);
												isDefending = false;
												WILL += 5;
											}
										break;

										case 7:
										case 12:
										case 3: //critical
											if(!isDefending)
											{
												Space();
												Color("green");
												Writer("CRITICAL HIT!");
												Writer(monName + " lost " + (int) ATK * 5/3 + " HP!");
												Color("null");
												hp -= (int) ATK * 5/3;
												WILL += 20;
											}
											else if(isDefending)
											{
												Space();
												Color("green");
												Writer("CRITICAL HIT!");
												Writer(monName + ", while it was defending, lost " + ATK + " HP!");
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
								else
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
									stop = false;
									while(!stop)
									{
										Space();
										Writer("Who do you want to fight? (1 - 2)");
										Space();
										//display of choices
										if(enemyDown[0] && !enemyDown[1])
										{
											Writer("1: " + monName);
										}
										else if(!enemyDown[0] && enemyDown[1])
										{
											Writer("2: " + monNameTwo);
										}
										else if(!enemyDown[0] && !enemyDown[1])
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
												if(enemyDown[1])
												{
													Writer(monName + " is already defeated!");
												}
												else
												{
													//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
													switch(re) 
													{
														case 9:
														case 1: //weak
															Space();
															Color("yellow");
															if(!isDefending)
															{
																Writer("You attacked! " + monName + " lost " + (int) ATK * 2/3 + " HP! That was a weak hit!");
																Color();
																hp -= (int) ATK * 2/3;
																WILL += 5;
															}
															else if(isDefending)
															{
																Writer("You attacked! While " + monName + " was defending, it still lost " + (int) ATK * 1/3 + " HP! That was a measly hit!");
																Color();
																hp -= (int) ATK * 1/3;
																isDefending = false;
																WILL += 2;
															}
														break;

														case 10:
														case 8:
														case 5:
														case 6:
														case 2: //neutral
															if(!isDefending)
															{
																Space();
																Color("green");
																Writer("You attacked! " + monName + " lost " + ATK + " HP!");
																Color();
																hp -= ATK;
																WILL += 10;
															}
															else if(isDefending)
															{
																Space();
																Color("green");
																Writer("You attacked! While " + monName + " was defending, it still lost " + Convert.ToInt32(ATK * 7/9) + " HP!");
																Color();
																hp -= Convert.ToInt32(ATK * 7/9);
																isDefending = false;
																WILL += 5;
															}
														break;

														case 7:
														case 12:
														case 3: //critical
															if(!isDefending)
															{
																Space();
																Color("green");
																Writer("CRITICAL HIT!");
																Writer(monName + " lost " + (int) ATK * 5/3 + " HP!");
																Color("null");
																hp -= (int) ATK * 5/3;
																WILL += 20;
															}
															else if(isDefending)
															{
																Space();
																Color("green");
																Writer("CRITICAL HIT!");
																Writer(monName + ", while it was defending, lost " + ATK + " HP!");
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
													Writer(monNameTwo + " is already defeated!");
												}
												else
												{
													//miss: 2(17%), weak: 2(17%), neutral: 5(42%), critical: 4(25%)
													switch(re) 
													{
													
														case 9:
														case 1: //weak
															Space();
															Color("yellow");
															if(!isDefendingTwo)
															{
																Writer("You attacked! " + monNameTwo + " lost " + (int) ATK * 2/3 + " HP! That was a weak hit!");
																Color();
																hpTwo -= (int) ATK * 2/3;
																WILL += 5;
															}
															else if(isDefendingTwo)
															{
																Writer("You attacked! While " + monNameTwo + " was defending, it still lost " + (int) ATK * 1/3 + " HP! That was a measly hit!");
																Color();
																hpTwo -= (int) ATK * 1/3;
																isDefendingTwo = false;
																WILL += 2;
															}
														break;

														case 10:
														case 8:
														case 5:
														case 6:
														case 2: //neutral
															if(!isDefendingTwo)
															{
																Space();
																Color("green");
																Writer("You attacked! " + monNameTwo + " lost " + ATK + " HP!");
																Color();
																hpTwo -= ATK;
																WILL += 10;
															}
															else if(isDefendingTwo)
															{
																Space();
																Color("green");
																Writer("You attacked! While " + monNameTwo + " was defending, it still lost " + Convert.ToInt32(ATK * 7/9) + " HP!");
																Color();
																hpTwo -= Convert.ToInt32(ATK * 7/9);
																isDefendingTwo = false;
																WILL += 5;
															}
														break;

														case 7:
														case 12:
														case 3: //critical
															if(!isDefendingTwo)
															{
																Space();
																Color("green");
																Writer("CRITICAL HIT!");
																Writer(monNameTwo + " lost " + (int) ATK * 5/3 + " HP!");
																Color("null");
																hpTwo -= (int) ATK * 5/3;
																WILL += 20;
															}
															else if(isDefendingTwo)
															{
																Space();
																Color("green");
																Writer("CRITICAL HIT!");
																Writer(monNameTwo + ", while it was defending, lost " + ATK + " HP!");
																Color("null");
																hpTwo -= (int) ATK;
																isDefendingTwo = false;
																WILL += 13;
															}
														break;

														case 11:
														case 4: //miss
															Space();
															Color("red");
															Writer("You missed! " + monNameTwo + " didn't get hit!");
															Color("null");
															WILL -= 3;
														break;
													}
												}
												stop = true;
											break;

											default:
												Space();
												Color("red");
												Writer("Write only 1 or 2, otherwise it won't work right!");
												Space();
											break;
										}
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
								DEFENDING = true;
								Color("green");
								Writer("You will block the next attacks!");
								Color();
								Space();
							break;

							case "4":
							case "GRAB":
							case "Grab":
							case "grab":
								DeathHandler();
						
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
								bool enter = false;
								//come back to this
								while(!enter)
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
									for(int i = 0; i < 10; i++) Writer(inventory[i] + ", " + i);
									
									if(From[2] == true)
									{
										Writer(inventory[10] + ", 10");
									}

									Space();
									int amounta = 0;//amount of inventory slots
									if(From[2]) amounta = 10;
									else amounta = 9;

									option = Reader();
									for(int i = 0; i <= amounta; i++)
									{
										if(option == "" + i + "")
										{
											switch(inventory[i])
											{
												case "potion":
													Space();
													Writer("You recieved 20 HP!");
													HP += 20;
													if(HP > HEARTS)
													{
														HP = HEARTS;
													}
													inventory[i] = "null";
													i = amounta + 1;
													enter = true;
												break;

												case "heart":
													Space();
													Writer("You gained 5 HP!");
													HEARTS += 5;
													HP += 5;
													inventory[i] = "null";
													i = amounta + 1;
													enter = true;
												break;

												case "ATK UP":
													Space();
													Writer("You buffed up! ATK increased!");
													ATK += 3;
													inventory[i] = "null";
													i = amounta + 1;
													enter = true;
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

													inventory[i] = "null";
													i = amounta + 1;
													enter = true;
												break;
												
												case "potion +":
													Space();
													Writer("You recieved 60 HP!");
													HP += 60;
													if(HP > HEARTS)
													{
														HP = HEARTS + 10;
													}
													inventory[i] = "null";
													i = amounta + 1;
													enter = true;
												break;

												case "null":
													Space();
													Writer("there is no item in this slot");
												break;

												case "junk":
													Space();
													Writer("How would you use random junk in battle? Try selling it.");
													i = amounta + 1;
													enter = true;
												break;

												default:
													ErrorWrite();
													i = amounta + 1;
												break;
											}
										}
									}
								}
							break;

							case "5":
							case "run":
							case "RUN":
							case "Run":
								DeathHandler();
								if(single && hp <= 0)
									enemyDown[2] = true;
								
								//random # gen
								if(HP >= Convert.ToInt32(HP/3))
									re = rando.Next(1, 6);
								else
									re = rando.Next(1, 3);
								
								if(!boss && canRun && SPE >= speed)
								{
									//logic
									Space();
									if (re == 2) 
									{
										if(single) Writer("You ran away!");
										else if(doubleBattle) Writer("You and " + teamMateName + " ran away!");
										t = turnOrder.Length;
									} 
									else
									{
										Writer("You tried to run, But failed!");
									}
								}
								else if(boss == true)
								{
									Writer("You can't run from a Boss Monster!");
								}  else if(!canRun) 
								{
									if(single) Writer("The monster won't let you escape!");
									if(!twoEnemy && doubleBattle) Writer("The monster won't let you or " + teamMateName + " escape!");
									if(twoEnemy && !doubleBattle) Writer("The monsters won't let you escape!");
									if(twoEnemy && doubleBattle) Writer("The monsters won't let you or " + teamMateName + " escape!");
								}
								GRABBING = false;
							break;
						}
					} 
					else if(turnOrder[t] == teamMateSPE) 
					{
						//mark death check/attack
						if(teamMateHP <= 0)
						{
							Space();
							Writer(teamMateName + " is beat! He can't fight!");
							turnOrder = turnOrder.RemoveAt(t);
						}
						else if (teamMateHP > 0)
						{
							if(twoEnemy) re = rando.Next(0, 2);
							else re = 0;

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
											Writer(teamMateName + " tried to attack " + monName + ", but missed!");
											Color();
										break;

										default:
											if(!isDefending)
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + teamMateATK + " damage to " + monName + "!");
												Color();
												hp -= teamMateATK;
											}
											else
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + (int) teamMateATK * 2/3 + " damage to " + monName + ", even though it was defending!");
												Color();
												hp -= (int) teamMateATK * 2/3;
											}
										break;
									}
								}
								else if (hp <= 0 && hpTwo > 0 && twoEnemy)
								{
									re = rando.Next(1, 13);
									switch(re)
									{
										case 12:
											Space();
											Color("red");
											Writer(teamMateName + " tried to attack " + monNameTwo + ", but missed!");
											Color();
										break;

										default:
											if(!isDefendingTwo)
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + teamMateATK + " damage to " + monNameTwo + "!");
												Color();
												hpTwo -= teamMateATK;
											}
											else
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + (int) teamMateATK * 2/3 + " damage to " + monNameTwo + ", even though it was defending!");
												Color();
												hpTwo -= (int) teamMateATK * 2/3;
											}
										break;
									}
								}
							}
							else if (re == 1 && twoEnemy)
							{
								if(hpTwo > 0)
								{
									re = rando.Next(1, 13);
									switch(re)
									{
										case 12:
											Space();
											Color("red");
											Writer(teamMateName + " tried to attack " + monNameTwo + ", but missed!");
											Color();
										break;

										default:
											if(!isDefendingTwo)
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + teamMateATK + " damage to " + monNameTwo + "!");
												Color();
												hpTwo -= teamMateATK;
											}
											else
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + (int) teamMateATK * 2/3 + " damage to " + monNameTwo + ", even though it was defending!");
												Color();
												hpTwo -= (int) teamMateATK * 2/3;
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
											Writer(teamMateName + " tried to attack " + monName + ", but missed!");
											Color();
										break;

										default:
											if(isDefending == false)
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + teamMateATK + " damage to " + monName + "!");
												Color();
												hp -= teamMateATK;
											}
											else
											{
												Space();
												Color("green");
												Writer(teamMateName + " did " + (int) teamMateATK * 2/3 + " damage to " + monName + ", even though it was defending!");
												Color();
												hp -= (int) teamMateATK * 2/3;
											}
										break;
									}
								}
							}
						}
					} 
					else if(turnOrder[t] == speed) 
					{
						//mon1 death check
						if(hp <= 0)
						{
							if(!twoEnemy) enemyDown[1] = true;
							else enemyDown[2] = true;
							turnOrder = turnOrder.RemoveAt(t);
						}
						else
						{
							//mon1
							//Pattern
							if(hasPattern)
							{
								if(pattern[nextPattern] == 0 && (!waitTiming || waitTime <= 0))
								{
									if(!isHealing && pattern[nextPattern] == 0 && waitTime <= 0)
									{
										if(!dodge)
										{	
											if(!doubleBattle)
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
														if(!DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
															Color("null");
															HP -= powerAttackHit;
															if(waitTiming) waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														}
														if(DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHit * 0.4) + " HP!");
															Color("null");
															HP -= Convert.ToInt32(powerAttackHit * 0.4);
															if(waitTiming) waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														}
													break;
												}
											}
											else
											{
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
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																Color("null");
																HP -= powerAttackHit;
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHit * 0.4) + " HP!");
																Color("null");
																HP -= Convert.ToInt32(powerAttackHit * 0.4);
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
														break;
													}
												}
												else if(re == 1 && doubleBattle && teamMateHP > 0)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer(teamMateName + " skillfully dodged " + monName + "'s POWER Attack!");
															waitTime = startWaitTime;
															waitTiming = false;
															Color("null");
														break;

														default:
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= powerAttackHit;
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= Convert.ToInt32(powerAttackHit * 0.4);
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
														break;
													}
												}
											}
										}
										else
										{
											Space();
											Writer("The enemy did no damage, because you somehow dodged their POWER Attack! You no longer can do a special attack due to the excertion.");
											Color();
											WILL -= 10;
											dodge = false;
											noSpecial = true;
											waitTiming = false;
											waitTime = startWaitTime;
											Space();
										}
									} 
									else if(isHealing && pattern[nextPattern] == 0 && waitTime <= 0)
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
									else if(waitTime > 0)
									{
										waitTime--;
										waitTiming = true;
										Space();
										Color("blue");
										if(!isHealing) Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
										if(isHealing) Writer(monName + "'s POWER Ability is preparing! " + waitTime + " turns left until it happens!");
										Color();
									}
								} 
								else if(pattern[nextPattern] == 0 && waitTiming && waitTime > 0)
								{
									waitTime--;
									waitTiming = true;
									Space();
									Color("blue");
									if(!isHealing) Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
									if(isHealing) Writer(monName + "'s POWER Ability is preparing! " + waitTime + " turns left until it happens!");
									Color();
								} 
								else if(pattern[nextPattern] == 2 && !waitTiming)
								{
									Space();
									Color("yellow");
									Writer(monName + " is defending from attack!");
									isDefending = true;
								} 
								else if(pattern[nextPattern] == 3 && !waitTiming)
								{
									Space();
									Color("yellow");
									Writer(monName + " is healing itself!");
									hp += Convert.ToInt32(hp/3);
								} 
								else
								{
									if(!dodge)
									{	
										re = rando.Next(0, 2);
										if(re == 0 || (re == 1 && !doubleBattle))
										{
											Space();
											re = monRand.Next(1, 11);
											re2 = rando.Next(1, 6);
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
													if(!DEFENDING)
													{
														Color("red");
														Writer(monName + " did " + attack + " hp to you!");
														Color("null");
														HP -= attack;
														WILL -= Convert.ToInt32(attack - ATK/6);
														if(re2 >= 1 && re2 <= 2 && statusAfflict != "null")
														{
															Space();
															Color("purple");
															if(statusAfflict == "Ablaze") Writer("You were set " + statusAfflict + "!");
															else Writer("You were " + statusAfflict + "!");
															STATUS = statusAfflict;
															Space();
														}
													}
													if(DEFENDING)
													{
														Color("orange");
														Writer(monName + " attacked, but you blocked it! The attack only did " + Convert.ToInt32(attack * (1/3)) + " hp to you!");
														Color("null");
														HP -= Convert.ToInt32(attack * (1/3));
														WILL -= Convert.ToInt32(attack - ATK/6);
														if(re2 == 1 && statusAfflict != "null")
														{
															Space();
															Color("purple");
															if(statusAfflict == "Ablaze") Writer("You were set " + statusAfflict + "!");
															else Writer("You were " + statusAfflict + "!");
															STATUS = statusAfflict;
															Space();
														}
													}
												break;
											}
										}
										else if(re == 1 && doubleBattle)
										{
											Space();
											re = monRand.Next(1, 11);
											switch(re)
											{
												case 1:
													Color("green");
													Writer(teamMateName + " dodged " + monName + "'s attack!");
													Color("null");
												break;

												case 2:
													Color("green");
													Writer(teamMateName + " dodged " + monName + "'s attack!");
													Color("null");
												break;

												case 3:
													Color("green");
													Writer(teamMateName + " dodged " + monName + "'s attack!");
													Color("null");
												break;

												default:
													Color("red");
													Writer(monName + " did " + attack + " hp to " + teamMateName + "!");
													Color("null");
													teamMateHP -= attack;
													WILL -= Convert.ToInt32(attack - ATK/6);
												break;
											}
										}
									}
									else
									{
										Space();
										Writer("The enemy did no damage, because you dodged their attack! This gives you time to use an item!");
										Color("null");
										WILL -= 10;
										dodge = false;
										Space();
										ItemUser();
									}
								}
							}
							//Weight
							else if(hasWeight)
							{
								for(int i = 0; i < weight.Length; i++) weightAmount[i] = weight[i];

								/*
									weight table*:
										-5 = 0% chance
										-4 = 5% chance
										-3 = 10% chance
										-2 = 15% chance
										-1 = 20% chance
										0 = 25% chance
										1 = 30% chance
										2 = 35% chance
										3 = 40% chance
										4 = 45% chance
										5 = 50% chance
									
									*these chances are "seeds" that give priority to certain moves. Therefore, these are not entirely correct.
								*/
								for(int i = 0; i < weightAmount.Length; i++) 
								{
									switch(Convert.ToInt32(weightAmount[i]))
									{
										case -5:
											weightAmount[i] = 0;
										break;

										case -4:
											weightAmount[i] = 5;
										break;

										case -3:
											weightAmount[i] = 10;
										break;

										case -2:
											weightAmount[i] = 15;
										break;

										case -1:
											weightAmount[i] = 20;
										break;

										case 0:
											weightAmount[i] = 25;
										break;

										case 1:
											weightAmount[i] = 30;
										break;

										case 2:
											weightAmount[i] = 35;
										break;

										case 3:
											weightAmount[i] = 40;
										break;

										case 4:
											weightAmount[i] = 45;
										break;

										case 5:
											weightAmount[i] = 50;
										break;
									}
								}

								//uses exclusive if statement writiing to make sure that the highest values are the most likely
								int doTwice = 0;
								while(doTwice < 2)
								{
									for(int i = 0; i < weightAmount.Length; i++)
									{
										if(i != 0)
										{
											if(weightAmount[i] == weightAmount[i - 1])
											{
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														weightAmount[i]--;
													break;

													case 1:
														weightAmount[i - 1]--;
													break;
												}
											}
										}
									}
									doTwice++;
								}

								Array.Sort(turnOrder);
								Array.Reverse(turnOrder);
								
								
								if(!waitTiming) re = rando.Next(Convert.ToInt32(weightAmount[0]), Convert.ToInt32(weightAmount.Sum() + 1));
								if(waitTime <= 0 && !waitTiming && re <= weightAmount[0] && (!waitTiming || waitTime <= 0))
								{
									if(!isHealing && re <= weightAmount[0] && waitTime <= 0)
									{
										if(!dodge)
										{	
											if(!doubleBattle)
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
														if(!DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
															Color("null");
															HP -= powerAttackHit;
															if(waitTiming) waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														}
														if(DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHit * 0.4) + " HP!");
															Color("null");
															HP -= Convert.ToInt32(powerAttackHit * 0.4);
															if(waitTiming) waitTime = startWaitTime;
															waitTiming = false;
															WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
														}
													break;
												}
											}
											else
											{
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
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP!");
																Color("null");
																HP -= powerAttackHit;
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHit * 0.4) + " HP!");
																Color("null");
																HP -= Convert.ToInt32(powerAttackHit * 0.4);
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
														break;
													}
												}
												else if(re == 1 && doubleBattle && teamMateHP > 0)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer(teamMateName + " skillfully dodged " + monName + "'s POWER Attack!");
															waitTime = startWaitTime;
															waitTiming = false;
															Color("null");
														break;

														default:
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= powerAttackHit;
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monName + " used " + powerAttack + "! Dealing a devastating " + powerAttackHit + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= Convert.ToInt32(powerAttackHit * 0.4);
																if(waitTiming) waitTime = startWaitTime;
																waitTiming = false;
																WILL -= Convert.ToInt32(powerAttackHit - ATK/3);
															}
														break;
													}
												}
											}
										}
										else
										{
											Space();
											Writer("The enemy did no damage, because you somehow dodged their POWER Attack! You no longer can do a special attack due to the excertion.");
											Color();
											WILL -= 10;
											dodge = false;
											noSpecial = true;
											waitTiming = false;
											waitTime = startWaitTime;
											Space();
										}
									} 
									else if(isHealing && re <= weightAmount[0] && waitTime <= 0)
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
									else if(waitTime > 0)
									{
										waitTime--;
										waitTiming = true;
										Space();
										Color("blue");
										if(!isHealing) Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
										if(isHealing) Writer(monName + "'s POWER Ability is preparing! " + waitTime + " turns left until it happens!");
										Color();
									}
								}
								else if(waitTiming && waitTime > 0)
								{
									waitTime--;
									waitTiming = true;
									Space();
									Color("blue");
									if(!isHealing) Writer(monName + "'s POWER Attack is preparing! " + waitTime + " turns left until it happens!");
									if(isHealing) Writer(monName + "'s POWER Ability is preparing! " + waitTime + " turns left until it happens!");
									Color();
								}
								else if(re < weightAmount[0] + weightAmount[1] && !waitTiming)
								{
									if(!dodge)
									{	
										re = rando.Next(0, 2);
										if(re == 0 || (re == 1 && !doubleBattle))
										{
											Space();
											re = monRand.Next(1, 11);
											re2 = rando.Next(1, 6);
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
													if(!DEFENDING)
													{
														Color("red");
														Writer(monName + " did " + attack + " hp to you!");
														Color("null");
														HP -= attack;
														WILL -= Convert.ToInt32(attack - ATK/6);
														if(re2 >= 1 && re2 <= 2 && statusAfflict != "null")
														{
															Space();
															Color("purple");
															if(statusAfflict == "Ablaze") Writer("You were set " + statusAfflict + "!");
															else Writer("You were " + statusAfflict + "!");
															STATUS = statusAfflict;
															Space();
														}
													}
													if(DEFENDING)
													{
														Color("orange");
														Writer(monName + " attacked, but you blocked it! The attack only did " + Convert.ToInt32(attack * (1/3)) + " hp to you!");
														Color("null");
														HP -= Convert.ToInt32(attack * (1/3));
														WILL -= Convert.ToInt32(attack - ATK/6);
														if(re2 == 1 && statusAfflict != "null")
														{
															Space();
															Color("purple");
															if(statusAfflict == "Ablaze") Writer("You were set " + statusAfflict + "!");
															else Writer("You were " + statusAfflict + "!");
															STATUS = statusAfflict;
															Space();
														}
													}
												break;
											}
										}
										else if(re == 1 && doubleBattle)
										{
											Space();
											re = monRand.Next(1, 11);
											switch(re)
											{
												case 1:
													Color("green");
													Writer(teamMateName + " dodged " + monName + "'s attack!");
													Color("null");
												break;

												case 2:
													Color("green");
													Writer(teamMateName + " dodged " + monName + "'s attack!");
													Color("null");
												break;

												case 3:
													Color("green");
													Writer(teamMateName + " dodged " + monName + "'s attack!");
													Color("null");
												break;

												default:
													Color("red");
													Writer(monName + " did " + attack + " hp to " + teamMateName + "!");
													Color("null");
													teamMateHP -= attack;
													WILL -= Convert.ToInt32(attack - ATK/6);
												break;
											}
										}
									}
									else
									{
										Space();
										Writer("The enemy did no damage, because you dodged their attack! This gives you time to use an item!");
										Color("null");
										WILL -= 10;
										dodge = false;
										Space();
										ItemUser();
									}
								}
								else if(re < weightAmount[0] + weightAmount[1] + weightAmount[2] && !waitTiming)
								{
									Space();
									Color("yellow");
									Writer(monName + " is defending from attack!");
									isDefending = true;
								}
								else if(re < weightAmount.Sum() && !waitTiming)
								{
									Space();
									Color("yellow");
									Writer(monName + " is healing itself!");
									hp += Convert.ToInt32(hp/3);
								}
								else
								{
									Space();
									re = monRand.Next(1, 11);
									re2 = rando.Next(1, 11);
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
											if(!DEFENDING)
											{
												Color("red");
												Writer(monName + " did " + attack + " hp to you!");
												Color("null");
												HP -= attack;
												WILL -= Convert.ToInt32(attack - ATK/6);
												if(re2 >= 1 && re2 <= 2 && statusAfflict != "null")
												{
													Space();
													Color("purple");
													if(statusAfflict == "Ablaze") Writer("You were set " + statusAfflict + "!");
													else Writer("You were " + statusAfflict + "!");
													STATUS = statusAfflict;
													Space();
												}
											}
											if(DEFENDING)
											{
												Color("orange");
												Writer(monName + " attacked, but you blocked it! The attack only did " + Convert.ToInt32(attack * (1/3)) + " hp to you!");
												Color("null");
												HP -= Convert.ToInt32(attack * (1/3));
												WILL -= Convert.ToInt32(attack - ATK/6);
												if(re2 == 1 && statusAfflict != "null")
												{
													Space();
													Color("purple");
													if(statusAfflict == "Ablaze") Writer("You were set " + statusAfflict + "!");
													else Writer("You were " + statusAfflict + "!");
													STATUS = statusAfflict;
													Space();
												}
											}
										break;
									}
								}
							}
						}
					} 
					else if(turnOrder[t] == speedTwo)
					{
						//mon1 death check
						if(hpTwo <= 0)
						{
							if(!twoEnemy) enemyDown[1] = true;
							else enemyDown[2] = true;
							turnOrder = turnOrder.RemoveAt(t);
						}
						else
						{
							//mon1
							//Pattern
							if(hasPattern)
							{
								if(patternTwo[nextPatternTwo] == 0 && (!waitTimingTwo || waitTimeTwo <= 0))
								{
									if(!isHealingTwo && patternTwo[nextPatternTwo] == 0 && waitTimeTwo <= 0)
									{
										if(!dodge)
										{	
											if(!doubleBattle)
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
														if(!DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
															Color("null");
															HP -= powerAttackHitTwo;
															if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
														}
														if(DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHitTwo * 0.4) + " HP!");
															Color("null");
															HP -= Convert.ToInt32(powerAttackHitTwo * 0.4);
															if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
														}
													break;
												}
											}
											else
											{
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
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																Color("null");
																HP -= powerAttackHitTwo;
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHitTwo * 0.4) + " HP!");
																Color("null");
																HP -= Convert.ToInt32(powerAttackHitTwo * 0.4);
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
														break;
													}
												}
												else if(re == 1 && doubleBattle && teamMateHP > 0)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer(teamMateName + " skillfully dodged " + monNameTwo + "'s POWER Attack!");
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															Color("null");
														break;

														default:
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= powerAttackHitTwo;
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= Convert.ToInt32(powerAttackHitTwo * 0.4);
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
														break;
													}
												}
											}
										}
										else
										{
											Space();
											Writer("The enemy did no damage, because you somehow dodged their POWER Attack! You no longer can do a special attack due to the excertion.");
											Color();
											WILL -= 10;
											dodge = false;
											noSpecial = true;
											waitTimingTwo = false;
											waitTimeTwo = startWaitTimeTwo;
											Space();
										}
									} 
									else if(isHealingTwo && patternTwo[nextPatternTwo] == 0 && waitTimeTwo <= 0)
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
									else if(waitTimeTwo > 0)
									{
										waitTimeTwo--;
										waitTimingTwo = true;
										Space();
										Color("blue");
										if(!isHealingTwo) Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
										if(isHealingTwo) Writer(monNameTwo + "'s POWER Ability is preparing! " + waitTimeTwo + " turns left until it happens!");
										Color();
									}
								} 
								else if(patternTwo[nextPatternTwo] == 0 && waitTimingTwo && waitTimeTwo > 0)
								{
									waitTimeTwo--;
									waitTimingTwo = true;
									Space();
									Color("blue");
									if(!isHealingTwo) Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
									if(isHealingTwo) Writer(monNameTwo + "'s POWER Ability is preparing! " + waitTimeTwo + " turns left until it happens!");
									Color();
								} 
								else if(patternTwo[nextPatternTwo] == 2 && !waitTimingTwo)
								{
									Space();
									Color("yellow");
									Writer(monNameTwo + " is defending from attack!");
									isDefendingTwo = true;
								} 
								else if(patternTwo[nextPatternTwo] == 3 && !waitTimingTwo)
								{
									Space();
									Color("yellow");
									Writer(monNameTwo + " is healing itself!");
									hpTwo += Convert.ToInt32(hpTwo/3);
								} 
								else
								{
									if(!dodge)
									{	
										re = rando.Next(0, 2);
										if(re == 0 || (re == 1 && !doubleBattle))
										{
											Space();
											re = monRand.Next(1, 11);
											re2 = rando.Next(1, 6);
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
													if(!DEFENDING)
													{
														Color("red");
														Writer(monNameTwo + " did " + attackTwo + " HP to you!");
														Color("null");
														HP -= attackTwo;
														WILL -= Convert.ToInt32(attackTwo - ATK/6);
														if(re2 >= 1 && re2 <= 2 && statusAfflictTwo != "null")
														{
															Space();
															Color("purple");
															if(statusAfflictTwo == "Ablaze") Writer("You were set " + statusAfflictTwo + "!");
															else Writer("You were " + statusAfflictTwo + "!");
															STATUS = statusAfflictTwo;
															Space();
														}
													}
													if(DEFENDING)
													{
														Color("orange");
														Writer(monNameTwo + " attacked, but you blocked it! The attack only did " + Convert.ToInt32(attackTwo * (1/3)) + " HP to you!");
														Color("null");
														HP -= Convert.ToInt32(attackTwo * (1/3));
														WILL -= Convert.ToInt32(attackTwo - ATK/6);
														if(re2 == 1 && statusAfflictTwo != "null")
														{
															Space();
															Color("purple");
															if(statusAfflictTwo == "Ablaze") Writer("You were set " + statusAfflictTwo + "!");
															else Writer("You were " + statusAfflictTwo + "!");
															STATUS = statusAfflictTwo;
															Space();
														}
													}
												break;
											}
										}
										else if(re == 1 && doubleBattle)
										{
											Space();
											re = monRand.Next(1, 11);
											switch(re)
											{
												case 1:
													Color("green");
													Writer(teamMateName + " dodged " + monNameTwo + "'s attack!");
													Color("null");
												break;

												case 2:
													Color("green");
													Writer(teamMateName + " dodged " + monNameTwo + "'s attack!");
													Color("null");
												break;

												case 3:
													Color("green");
													Writer(teamMateName + " dodged " + monNameTwo + "'s attack!");
													Color("null");
												break;

												default:
													Color("red");
													Writer(monNameTwo + " did " + attackTwo + " HP to " + teamMateName + "!");
													Color("null");
													teamMateHP -= attackTwo;
													WILL -= Convert.ToInt32(attackTwo - ATK/6);
												break;
											}
										}
									}
									else
									{
										Space();
										Writer("The enemy did no damage, because you dodged their attack! This gives you time to use an item!");
										Color("null");
										WILL -= 10;
										dodge = false;
										Space();
										ItemUser();
									}
								}
							}
							//Weight
							else if(hasWeight)
							{
								for(int i = 0; i < weightTwo.Length; i++) weightAmountTwo[i] = weightTwo[i];

								/*
									weightTwo table*:
										-5 = 0% chance
										-4 = 5% chance
										-3 = 10% chance
										-2 = 15% chance
										-1 = 20% chance
										0 = 25% chance
										1 = 30% chance
										2 = 35% chance
										3 = 40% chance
										4 = 45% chance
										5 = 50% chance
									
									*these chances are "seeds" that give priority to certain moves. Therefore, these are not entirely correct.
								*/
								for(int i = 0; i < weightAmountTwo.Length; i++) 
								{
									switch(Convert.ToInt32(weightAmountTwo[i]))
									{
										case -5:
											weightAmountTwo[i] = 0;
										break;

										case -4:
											weightAmountTwo[i] = 5;
										break;

										case -3:
											weightAmountTwo[i] = 10;
										break;

										case -2:
											weightAmountTwo[i] = 15;
										break;

										case -1:
											weightAmountTwo[i] = 20;
										break;

										case 0:
											weightAmountTwo[i] = 25;
										break;

										case 1:
											weightAmountTwo[i] = 30;
										break;

										case 2:
											weightAmountTwo[i] = 35;
										break;

										case 3:
											weightAmountTwo[i] = 40;
										break;

										case 4:
											weightAmountTwo[i] = 45;
										break;

										case 5:
											weightAmountTwo[i] = 50;
										break;
									}
								}

								//uses exclusive if statement writiing to make sure that the highest values are the most likely
								int doTwice = 0;
								while(doTwice < 2)
								{
									for(int i = 0; i < weightAmountTwo.Length; i++)
									{
										if(i != 0)
										{
											if(weightAmountTwo[i] == weightAmountTwo[i - 1])
											{
												re = rando.Next(0, 2);
												switch(re)
												{
													case 0:
														weightAmountTwo[i]--;
													break;

													case 1:
														weightAmountTwo[i - 1]--;
													break;
												}
											}
										}
									}
									doTwice++;
								}

								Array.Sort(turnOrder);
								Array.Reverse(turnOrder);
								
								
								if(!waitTimingTwo) re = rando.Next(Convert.ToInt32(weightAmountTwo[0]), Convert.ToInt32(weightAmountTwo.Sum() + 1));
								if(waitTimeTwo <= 0 && !waitTimingTwo && re <= weightAmountTwo[0] && (!waitTimingTwo || waitTimeTwo <= 0))
								{
									if(!isHealingTwo && re <= weightAmountTwo[0] && waitTimeTwo <= 0)
									{
										if(!dodge)
										{	
											if(!doubleBattle)
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
														if(!DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
															Color("null");
															HP -= powerAttackHitTwo;
															if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
														}
														if(DEFENDING)
														{
															Color("purple");
															Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHitTwo * 0.4) + " HP!");
															Color("null");
															HP -= Convert.ToInt32(powerAttackHitTwo * 0.4);
															if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
														}
													break;
												}
											}
											else
											{
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
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP!");
																Color("null");
																HP -= powerAttackHitTwo;
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! You defended against the attack but it still dealt a devastating " + Convert.ToInt32(powerAttackHitTwo * 0.4) + " HP!");
																Color("null");
																HP -= Convert.ToInt32(powerAttackHitTwo * 0.4);
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
														break;
													}
												}
												else if(re == 1 && doubleBattle && teamMateHP > 0)
												{
													re = monRand.Next(1, 21);
													switch(re)
													{
														case 1:
															Color("green");
															Writer(teamMateName + " skillfully dodged " + monNameTwo + "'s POWER Attack!");
															waitTimeTwo = startWaitTimeTwo;
															waitTimingTwo = false;
															Color("null");
														break;

														default:
															if(!DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= powerAttackHitTwo;
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
															if(DEFENDING)
															{
																Color("purple");
																Writer("POWER ATTACK!! " + monNameTwo + " used " + powerAttackTwo + "! Dealing a devastating " + powerAttackHitTwo + " HP to " + teamMateName + "!");
																Color("null");
																teamMateHP -= Convert.ToInt32(powerAttackHitTwo * 0.4);
																if(waitTimingTwo) waitTimeTwo = startWaitTimeTwo;
																waitTimingTwo = false;
																WILL -= Convert.ToInt32(powerAttackHitTwo - ATK/3);
															}
														break;
													}
												}
											}
										}
										else
										{
											Space();
											Writer("The enemy did no damage, because you somehow dodged their POWER Attack! You no longer can do a special attack due to the excertion.");
											Color();
											WILL -= 10;
											dodge = false;
											noSpecial = true;
											waitTimingTwo = false;
											waitTimeTwo = startWaitTimeTwo;
											Space();
										}
									} 
									else if(isHealingTwo && re <= weightAmountTwo[0] && waitTimeTwo <= 0)
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
									else if(waitTimeTwo > 0)
									{
										waitTimeTwo--;
										waitTimingTwo = true;
										Space();
										Color("blue");
										if(!isHealingTwo) Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
										if(isHealingTwo) Writer(monNameTwo + "'s POWER Ability is preparing! " + waitTimeTwo + " turns left until it happens!");
										Color();
									}
								}
								else if(waitTimingTwo && waitTimeTwo > 0)
								{
									waitTimeTwo--;
									waitTimingTwo = true;
									Space();
									Color("blue");
									if(!isHealingTwo) Writer(monNameTwo + "'s POWER Attack is preparing! " + waitTimeTwo + " turns left until it happens!");
									if(isHealingTwo) Writer(monNameTwo + "'s POWER Ability is preparing! " + waitTimeTwo + " turns left until it happens!");
									Color();
								}
								else if(re < weightAmountTwo[0] + weightAmountTwo[1] && !waitTimingTwo)
								{
									if(!dodge)
									{	
										re = rando.Next(0, 2);
										if(re == 0 || (re == 1 && !doubleBattle))
										{
											Space();
											re = monRand.Next(1, 11);
											re2 = rando.Next(1, 6);
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
													if(!DEFENDING)
													{
														Color("red");
														Writer(monNameTwo + " did " + attackTwo + " HP to you!");
														Color("null");
														HP -= attackTwo;
														WILL -= Convert.ToInt32(attackTwo - ATK/6);
														if(re2 >= 1 && re2 <= 2 && statusAfflictTwo != "null")
														{
															Space();
															Color("purple");
															if(statusAfflictTwo == "Ablaze") Writer("You were set " + statusAfflictTwo + "!");
															else Writer("You were " + statusAfflictTwo + "!");
															STATUS = statusAfflictTwo;
															Space();
														}
													}
													if(DEFENDING)
													{
														Color("orange");
														Writer(monNameTwo + " attacked, but you blocked it! The attack only did " + Convert.ToInt32(attackTwo * (1/3)) + " HP to you!");
														Color("null");
														HP -= Convert.ToInt32(attackTwo * (1/3));
														WILL -= Convert.ToInt32(attackTwo - ATK/6);
														if(re2 == 1 && statusAfflictTwo != "null")
														{
															Space();
															Color("purple");
															if(statusAfflictTwo == "Ablaze") Writer("You were set " + statusAfflictTwo + "!");
															else Writer("You were " + statusAfflictTwo + "!");
															STATUS = statusAfflictTwo;
															Space();
														}
													}
												break;
											}
										}
										else if(re == 1 && doubleBattle)
										{
											Space();
											re = monRand.Next(1, 11);
											switch(re)
											{
												case 1:
													Color("green");
													Writer(teamMateName + " dodged " + monNameTwo + "'s attack!");
													Color("null");
												break;

												case 2:
													Color("green");
													Writer(teamMateName + " dodged " + monNameTwo + "'s attack!");
													Color("null");
												break;

												case 3:
													Color("green");
													Writer(teamMateName + " dodged " + monNameTwo + "'s attack!");
													Color("null");
												break;

												default:
													Color("red");
													Writer(monNameTwo + " did " + attackTwo + " HP to " + teamMateName + "!");
													Color("null");
													teamMateHP -= attackTwo;
													WILL -= Convert.ToInt32(attackTwo - ATK/6);
												break;
											}
										}
									}
									else
									{
										Space();
										Writer("The enemy did no damage, because you dodged their attack! This gives you time to use an item!");
										Color("null");
										WILL -= 10;
										dodge = false;
										Space();
										ItemUser();
									}
								}
								else if(re < weightAmountTwo[0] + weightAmountTwo[1] + weightAmountTwo[2] && !waitTimingTwo)
								{
									Space();
									Color("yellow");
									Writer(monNameTwo + " is defending from attack!");
									isDefendingTwo = true;
								}
								else if(re < weightAmountTwo.Sum() && !waitTimingTwo)
								{
									Space();
									Color("yellow");
									Writer(monNameTwo + " is healing itself!");
									hpTwo += Convert.ToInt32(hpTwo/3);
								}
								else
								{
									Space();
									re = monRand.Next(1, 11);
									re2 = rando.Next(1, 11);
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
											if(!DEFENDING)
											{
												Color("red");
												Writer(monNameTwo + " did " + attackTwo + " HP to you!");
												Color("null");
												HP -= attackTwo;
												WILL -= Convert.ToInt32(attackTwo - ATK/6);
												if(re2 >= 1 && re2 <= 2 && statusAfflictTwo != "null")
												{
													Space();
													Color("purple");
													if(statusAfflictTwo == "Ablaze") Writer("You were set " + statusAfflictTwo + "!");
													else Writer("You were " + statusAfflictTwo + "!");
													STATUS = statusAfflictTwo;
													Space();
												}
											}
											if(DEFENDING)
											{
												Color("orange");
												Writer(monNameTwo + " attacked, but you blocked it! The attack only did " + Convert.ToInt32(attackTwo * (1/3)) + " HP to you!");
												Color("null");
												HP -= Convert.ToInt32(attackTwo * (1/3));
												WILL -= Convert.ToInt32(attackTwo - ATK/6);
												if(re2 == 1 && statusAfflictTwo != "null")
												{
													Space();
													Color("purple");
													if(statusAfflictTwo == "Ablaze") Writer("You were set " + statusAfflictTwo + "!");
													else Writer("You were " + statusAfflictTwo + "!");
													STATUS = statusAfflictTwo;
													Space();
												}
											}
										break;
									}
								}
							}
						}
					}
				}
				
				//END
				Color();
				if(Array.FindIndex(turnOrder, x => x == turnOrder.Max() + 1) != -1)turnOrder[Array.FindIndex(turnOrder, x => x == turnOrder.Max() + 1)] = SPE;
				SPECIALING = false;
				GRABBING = false;
				dodge = false;

				//setting the teammate variables
				if(doubleBattle) TeamMater();

				//monster patterns
				if(hp > 0 && !waitTiming && hasPattern)
				{
					if(nextPattern < 10) nextPattern++;
					if(nextPattern >= 10) nextPattern = 0;
				}
				if(twoEnemy)
				{
					if(hpTwo > 0 && !waitTimingTwo && hasPatternTwo)
					{
						if(nextPatternTwo < 10) nextPatternTwo++;
						if(nextPatternTwo >= 10) nextPatternTwo = 0;
					}
				}

				//death
				switch(STATUS) 
				{
					case "Ablaze":
						Space();
						Color("red");
						Writer("You took damage from being " + STATUS + "! -3 HP!");
						HP -= 3;
						DeathHandler();
						Space();
					break;

					case "Venomed":
						Space();
						Color("purple");
						Writer("You took damage from being afflicted with " + STATUS + "! -" + currentVenom + " HP!");
						HP -= currentVenom;
						currentVenom += 2;
						DeathHandler();
						Space();
					break;
				} switch(status) 
				{
					case "Ablaze":
						Space();
						Color("green");
						Writer(monName + " took damage from being " + status + "! -4 HP!");
						hp -= 4;
						Space();
					break;

					case "Venomed":
						Space();
						Color("purple");
						Writer(monName + " took damage from being afficled with " + status + "! -" + currentVenomMon + " HP!");
						hp -= currentVenomMon;
						currentVenomMon += 2;
						DeathHandler();
						Space();
					break;
				} 
				if(twoEnemy)
				{
					switch(statusTwo)
					{
						case "Ablaze":
							Space();
							Color("green");
							Writer(monNameTwo + " took damage from being " + statusTwo + "! -4 HP!");
							hpTwo -= 4;
						break;

						case "Venomed":
							Space();
							Color("purple");
							Writer(monNameTwo + " took damage from being afficled with " + statusTwo + "! -" + currentVenomMonTwo + " HP!");
							hp -= currentVenomMonTwo;
							currentVenomMonTwo += 2;
							DeathHandler();
							Space();
						break;
					}
				}

				Space();
				
				DeathHandler();

				if(twoEnemy)
				{
					if(hp <= 0)
					{
						Space(2);
						enemyDown[1] = true;
						if(enemyDown[0] == true && !stopText[2])
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
							if(stopText[2] == false && !stopText[2])
							{
								Writer(monNameTwo + " and " + monName + " have been defeated! We win!");
								stopText[2] = true;
								enemyDown[2] = true;
							}
						}
					}
				}

				//fighting check (again)
				if(single || (doubleBattle && !twoEnemy))
				{
					fighting = hp > 0;
					if(HP <= 0) 
						DeathHandler();
				}
				else if(twoEnemy)
				{
					fighting = hp > 0 || hpTwo > 0;
					if(HP <= 0) 
						DeathHandler();
				}

				if(fighting)
				{
					//message
					if(single) Writer("You have " + HP + " HP, and " + monName + " has " + hp + " HP.");
					if(!doubleBattle && twoEnemy) Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + monNameTwo + " has " + hpTwo + " HP.");
					if(doubleBattle && !twoEnemy) Writer("You have " + HP + " HP, " + teamMateName + " has " + teamMateHP + " HP, and " + monName + " has " + hp + " HP.");
					if(doubleBattle && twoEnemy) Writer("You have " + HP + " HP, " + teamMateName + " has " + teamMateHP + " HP, and " + monName + " has " + hp + " HP, and " + monNameTwo + " has " + hpTwo + " HP.");
					
					yok = false;//checks for if you entered something wrong.
					while(!yok)
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

						Color("green");
						Writer(toDo[2]);
						
						Color("blue");
						Writer(toDo[1]);

						Color("null");
						Space();
						Choose = Reader();

						switch(Choose)
						{
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
								yok = true;
							break;

							case "1":
							case "Special":
							case "special":
							case "SPECIAL":
								yok = true;
							break;

							case "3":
							case "defend":
							case "DFD":
							case "dfd":
							case "Dfd":
							case "Defend":
							case "DEFEND":
								yok = true;
							break;


							case "4":
							case "GRAB":
							case "Grab":
							case "grab":
								yok = true;
							break;

							case "5":
							case "run":
							case "RUN":
							case "Run":
								yok = true;
							break;

							default:
								ErrorWrite();
							break;
						}
					}
				}
      		}
    
			if(enemyDown[2] == true || !fighting)
			{
				if (true)//XXXX
				{
					Space();
					SPE = actualSPE;
					if(single == true)
					{
						if(!boss)
						{
							Writer("[0;36m" + monName + " was defeated! You can move on!");
						}
						else
						{
							Writer("[1;35m" + monName + " has been felled!");
						}
					}
					else if(single != true)
					{
						if(doubleBattle == true && enemyDown[1] == true && enemyDown[0] == true)
						{
							if(!boss)
							{
								Writer("[0;36m" + monName + " and " + monNameTwo + " were defeated! You two can move on!");
							}
							else
							{
								Writer("[1;35m" + monName + " and " + monNameTwo + " were felled!");
							}
						}
						else if(doubleBattle == false && enemyDown[1] == true && enemyDown[0] == true)
						{
							if(!boss)
							{
								Writer("[0;36m" + monName + " and " + monNameTwo + " were defeated! You can move on!");
							}
							else
							{
								Writer("[1;35m" + monName + " and " + monNameTwo + " were felled!");
							}
						}
					}
					Writer("[0;0m");
					noSpecial = false;
					//GOLD system
					GOLD += gold;
					Space();
					if(gold > 1)
					{
						Writer("[1;33m" + "You gained " + gold + " pieces of GOLD!");
					}
					else if(gold == 1)
					{
						Writer("[1;33m" + "You gained " + gold + " piece of GOLD!");
					}
					else if(gold == 0)
					{
						Writer("[1;33m" + "You gained " + "[1;31m" + "no pieces of GOLD! That must suck!" + "[1;33m");
					}
					else
					{
						Writer("[1;31m" + "How the-?!");
						End();
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
							re = rando.Next(0, 2);
							if(re == 0) 
							{
								HEARTS = HEARTS + 2;
								HP = HEARTS + 2;
							}
							else 
							{
								HEARTS = HEARTS + 3;
								HP = HEARTS + 3;
							}

      	  	 				ATK += 3;
							SPE += 2;
      	  	  				level++;
      	  	  				EXP -= EXPNeed;
							EXPNeed += 1200;
							//text
							Space();
							if(re == 0) Writer("You leveled up to level " + level + "! + 3 ATK, +2 SPE, +2 Max HP!");
							else Writer("You leveled up to level " + level + "! + 3 ATK, +2 SPE, +3 Max HP!");
							//item giving
							ItemGet();
      	  				}
					}
					else
					{
						EXP += (exp/2);
						teamMateEXP = (exp/2);
						Color("pink");
						Writer("You and " + teamMateName + " gained " + (exp/2) + " EXP!");
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
						while(teamMateEXP >= teamMateEXPNeed)
						{
							switch(teamMate)
							{
								case 0:
									teamMateEXPNeed += 1000;//EXP
									fMark_1 = fMark_1 + 2;//HEARTS
									teamMateHP = fMark_1 + 2;//HP
      	  	  						teamMateATK = teamMateATK + 3;//ATK
									teamMateSPE++;//SPE
      	  	  						teamMateLevel++;//LEVEL
      	  	  						teamMateEXP -= teamMateEXPNeed;//EXPNeed up
									//text
									Space();
									Writer(teamMateName + " leveled up to level " + teamMateLevel + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
								break;

								case 1:
									teamMateEXPNeed += 1400;//EXP
									fMark_1 = fMark_1 + 3;//HEARTS
									teamMateHP = fMark_1 + 1;//HP
      	  	  						teamMateATK = teamMateATK + 5;//ATK
									teamMateSPE+= 2;//SPE
      	  	  						teamMateLevel++;//LEVEL
      	  	  						teamMateEXP -= teamMateEXPNeed;//EXPNeed up
									//text
									Space();
									Writer(teamMateName + " leveled up to level " + teamMateLevel + "! + 5 ATK, +2 SPE,+ 3 Max HP!");
								break;

								case 2:
									teamMateEXPNeed += 1600;
									fMark_1 = fMark_1 + 5;//HEARTS
									teamMateHP = fMark_1 + 3;//HP
      	  	  						teamMateATK = teamMateATK + 2;//ATK
									teamMateSPE++;//SPE
      	  	  						teamMateLevel++;//LEVEL
      	  	  						teamMateEXP -= teamMateEXPNeed;//EXPNeed up
									//text
									Space();
									Writer(teamMateName + " leveled up to level " + teamMateLevel + "! + 2 ATK, +1 SPE,+ 5 Max HP!");
								break;

								case 3:
									teamMateEXPNeed += 3600;
									fMark_1 = fMark_1 + 10;//HEARTS
									teamMateHP = fMark_1 + 12;//HP
									teamMateATK = teamMateATK + 15;//ATK
									teamMateSPE+= 12;//SPE
      	  	  						teamMateLevel++;//LEVEL
      	  	  						teamMateEXP -= teamMateEXPNeed;//EXPNeed up
									//text
									Space();
									Writer(teamMateName + " leveled up to level " + teamMateLevel + "! + 15 ATK, +12 SPE,+ 10 Max HP!");
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
						Writer(teamMateName + " STATS: Max HP: " + fMark_1 + ", HP: " + teamMateHP + ", ATK: " + teamMateATK + ", SPE: " + teamMateSPE);
					}
					Space();
					Color("blue");
					if(doubleBattle == false)
					{
						Writer("Currently, you are level " + level + ". You need " + EXPNeed + " EXP to level up, and you have " + EXP + " EXP.");
					}
					else
					{
						Writer("Currently, you are level " + level + ". You need " + EXPNeed + " EXP to level up, and you have " + EXP + " EXP.");
						Writer("Currently, " + teamMateName + " is level " + teamMateLevel + ". they need " + EXPNeed + " EXP to level up, and they have " + EXP + " EXP.");
					}
					//Item System
					Color();
					ItemGet();
					//Inventory System
      	  			Space();
					Color("green");
					ItemUser();
					Color();
					//Healing teammate 2
					if(doubleBattle == true)
					{
						Writer("Would you like to have " + teamMateName + " heal for 100 GOLD? (y/n)");
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
									Writer(teamMateName + " was healed to max HP!");
									Writer("You lost 100 GOLD!");
									teamMateHP = Convert.ToSingle(teamMateHP);
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
									Writer("Would you like to have " + teamMateName + " heal for 100 GOLD? (y/n)");
									Space();
									option = Reader();
								break;
							}
						}
						TeamMater();
					}
					//End of MonsterEncounter
      			}
			}
			
    	}

		public static void TeamMater()
		{
			switch(teamMater)
			{
				case 0:
					Mark.HEARTS = fMark_1;
					Mark.HP = teamMateHP;
					Mark.SPE = teamMateSPE;
					Mark.ATK = teamMateATK;
					Mark.name = teamMateName;
					Mark.level = teamMateLevel;
					Mark.EXP = teamMateEXP;
					Mark.EXPNeed = teamMateEXPNeed;
				break;
							
				case 1:
					Breys.HEARTS = fMark_1;
					Breys.HP = teamMateHP;
					Breys.SPE = teamMateSPE;
					Breys.ATK = teamMateATK;
					Breys.name = teamMateName;
					Breys.level = teamMateLevel;
					Breys.EXP = teamMateEXP;
					Breys.EXPNeed = teamMateEXPNeed;
				break;

				case 2:
					Sapphire.HEARTS = fMark_1;
					Sapphire.HP = teamMateHP;
					Sapphire.SPE = teamMateSPE;
					Sapphire.ATK = teamMateATK;
					Sapphire.name = teamMateName;
					Sapphire.level = teamMateLevel;
					Sapphire.EXP = teamMateEXP;
					Sapphire.EXPNeed = teamMateEXPNeed;
				break;
							
				case 3:
					Captain.HEARTS = fMark_1;
					Captain.HP = teamMateHP;
					Captain.SPE = teamMateSPE;
					Captain.ATK = teamMateATK;
					Captain.name = teamMateName;
					Captain.level = teamMateLevel;
					Captain.EXP = teamMateEXP;
					Captain.EXPNeed = teamMateEXPNeed;
				break;
			}
		}

	 	public static void ItemUser()
		{
			Space();
			int countOfEmpty = 0;
			foreach(string x in inventory)
			{
				if(x == "null")
				{
					countOfEmpty++;
				}
			}
		 
		 	if(countOfEmpty == 0)
			{
				inventoryFull = true;
				Writer("Your inventory is full!");
			}
		 	else if (countOfEmpty == inventory.Length - 1 && !From[2])
			{
				inventoryFull = false;
			}
		 	else if(countOfEmpty == inventory.Length && From[2])
			{
				inventoryFull = false;
			}
		 	else
			{
				inventoryFull = false;
			}
		 
				Space();
				Writer("Do you want to use an item?");
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
							for(int i = 0; i < 10; i++)
							{
								Writer(inventory[i] + ", " + i);
							}
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
							//Crappy Logic :')
							for(int i = 0; i < 12; i++)
							{
								if(option == "" + i + "" && i < 10)
								{
									switch(inventory[i])
									{
										case "potion":
											Space();
											Writer("You recieved 20 HP!");
											HP += 20;
											if(HP > HEARTS)
											{
												HP = HEARTS;
											}
		
											inventory[i] = "null";
											end = true;
										break;
												
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;
		
											inventory[i] = "null";
											end = true;
										break;
		
											case "ATK UP":
													Space();
													Writer("You buffed up! ATK increased!");
													ATK += 3;
													
													inventory[i] = "null";
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
													inventory[i] = "null";
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
		
													inventory[i] = "null";
													end = true;
											break;
		
											case "null":
													Space();
													Writer("there is no item in this slot");
													end = true;
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
								else if(option == "" + i + "" && i >= 10)
								{
									
										if(option == "" + i + "" && (i == 10 && From[2]))
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
													ATK += 3;
	
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
										else if(option == "" + i + "" && (i == 10 && !From[2]))
										{
											Writer("Which item do you want to throw?");
												Space();
												for(int z = 0; z < 10; z++)
												{
													Writer(inventory[z] + ", " + z);
												}
												Space();
												Writer("END, 10");
											
												Space();
												option = Reader();
												Space();
												stop2 = false;
												//Logic
												while(!stop2)
												{
													for(int n = 0; n < 10; n++)
													{
														if(option == "" + n + "" && n < 10)
														{
															Writer("Slot " + n + " has been deleted!");
															inventory[n] = "null";
															stop2 = true;
														}
														else
														{
															stop2 = true;
														}
													}
												}
										}
								
										else if(option == "" + i + "" && (i == 11 && From[2]))
										{
												Writer("Which item do you want to throw?");
												Space();
												for(int y = 0; y < 11; y++)
												{
													Writer(inventory[y] + ", " + y);
												}
												Space();
												Writer("END, 11");
											
												Space();
												option = Reader();
												Space();
												stop2 = false;
												//Logic
												while(!stop2)
												{
													for(int n = 0; n < 11; n++)
													{
														if(option == "" + n + "" && n < 11)
														{
															Writer("Slot " + n + " has been deleted!");
															inventory[n] = "null";
															stop2 = true;
														}
														else
														{
															stop2 = true;
														}
													}
												}
										}
										else
										{
											stop = true;
										}
								}
							}

							Space();
							Writer("Do you want to do anything else in your bag? (Max HP: " + HEARTS + ", HP: " + HP + ", ATK: " + ATK + ", SPE: " + SPE + ") (y/n)");
							Space();
							option = Reader();
							Space();
							
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

		public static void Writer(string write, int type = 1, int speed = 25)
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
					Writer("SilverAtom: I am SilverAtom, so basically THE DRAGON'S god.");
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
								Writer("Very well. Do not give up!");
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

		//StackOverFlow variables
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			T[] dest = new T[source.Length - 1];
			if (index > 0) {
				Array.Copy(source, 0, dest, 0, index);
			}
	
			if (index < source.Length - 1) {
				Array.Copy(source, index + 1, dest, index, source.Length - index - 1);
			}
	
			return dest;
		}

		public static void ShiftElement<T>(this T[] array, int oldIndex, int newIndex)
		{
			// TODO: Argument validation
			if (oldIndex == newIndex)
			{
				return; // No-op
			}
			T tmp = array[oldIndex];
			if (newIndex < oldIndex) 
			{
				// Need to move part of the array "up" to make room
				Array.Copy(array, newIndex, array, newIndex + 1, oldIndex - newIndex);
			}
			else
			{
				// Need to move part of the array "down" to fill the gap
				Array.Copy(array, oldIndex + 1, array, oldIndex, newIndex - oldIndex);
			}
			array[newIndex] = tmp;
		}

		public static void ClearCurrentConsoleLine()
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(0, Console.CursorTop);
			Console.Write(new string(' ', Console.WindowWidth)); 
			Console.SetCursorPosition(0, currentLineCursor);
		}
	}
}
