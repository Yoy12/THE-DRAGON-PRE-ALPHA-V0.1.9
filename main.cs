using System;
using System.IO;
using System.Threading;
using System.Windows.Input;
// 
// https://bluesock.org/~willkg/dev/ansi.html#ansicodes
// RED: [0;31m
// RESET: [0m

//NOTE: After DRAGON, player is at level 12 and has about 42 HP and 54 - 64 ATK, so 250 hp and 20 attack is necessary.
//NOTE: Balance, Bi-

namespace DRAGONLake
{
  class Program
  {
    //variables
    static float EXP, EXPNeed = 2000, SPE = 19, HP = 20, HEARTS = 20, ATK = 5;
		static int level = 2, GOLD = 500, WILL = 400, re = 0;
		static string[] inventory = {"potion", "potion", "potion", "null", "null", "null", "null", "null", "null", "null", "null"/*not used until aftergame*/};
		static string[] go1 = {"springs", "hills", "forests", "debug"};
		static string name;

		static string option = "Samuel";
		static bool noCabin = false, stop = false, dodge = false, debug = true;
		static bool[] firstTime = {true/*SPECIAL*/, true/*attacking, grabbing, running*/, true/*options*/, true/*enter*/, true/*shopping*/, true}, From = {true/*springs*/, true/*hills*/, true/*forests*/};

		static Object[] Mark = new Object[] {120/*hp, 0*/, 25/*speed, 1*/, 23/*attack, 2*/, "Mark Conjure"/*name, 3*/};
		
		static Random rando = new Random();

    static void Main(string[] args) 
		{
			//Starting
			if(debug == true)
			{

			}
			if(debug == false)
			{
				Console.Clear();
			}
			Space(3);
			//All of the game
      Writer("THE DRAGON (V0.1.4 PRE-ALPHA)");
      Writer("START");
      Space();
      Writer("Please enter your Player Name: ", 2);
      name = Console.ReadLine();
      if(name.Replace(" ", "") == "")
			{
				name = "Samuel";
			}
			if(name.Replace(" ", "") == "oogabooga")
			{
				Space();
				Color("red");
				Writer("ENTERED 'BUFF' CHEAT. Happy cheating!");
				Color("bold");
				HEARTS = 100;
				HP = 100;
				SPE = 100;
				ATK = 100;
			}
			if(name.Replace(" ", "") == "Yessurr")
			{
				Space();
				Color("red");
				Writer("ENTERED 'RICH' CHEAT. Happy cheating!");
				Color("bold");
				inventory[0] = "potion +";
				inventory[1] = "potion +";
				inventory[2] = "potion +";
				inventory[3] = "potion +";
				inventory[4] = "potion +";
				inventory[5] = "ATK UP";
				inventory[6] = "ATK UP";
				inventory[7] = "ATK UP";
				inventory[8] = "ATK UP";
				inventory[9] = "ATK UP";
			}
			if(name.Replace(" ", "") == "Nehemaih")
			{
				Space();
				Color("red");
				Writer("ENTERED 'STRONG' CHEAT. Happy cheating!");
				Color("bold");
				ATK = 20;
				HP = 40;
				HEARTS = 40;
				SPE = 20;
			}
			Space();
			Writer("Do you want tutorials?");
			Space();
			Writer("yes");
			Writer("no");
			Space();
			option = Console.ReadLine();
			while(stop == false)
			{
				switch(option)
				{
					case "2":
					case "NO":
					case "No":
					case "no":
						firstTime[0] = false;
						firstTime[1] = false;
						firstTime[2] = false;
						firstTime[3] = false;
						firstTime[4] = false;
						firstTime[5] = false;

						stop = true;
					break;

					case "1":
					case "YES":
					case "Yes":
					case "yes":
						stop = true;
					break;

					default:
						Space();
						ErrorWrite();
						Space();
						Writer("yes");
						Writer("no");
						Space();
						option = Console.ReadLine();
					break;
				}
			}
			stop = false;
			//starting
			Space(3);
      Writer("Hello " + name + "! There is a DRAGON, and it needs to be slain! Where shall you go to give it its deserved fate?"); //options to go first
      Space();
			Color("cyan");
      Writer(go1[0] + ", 1");
			Color("yellow");
      Writer(go1[1] + ", 2");
			Color("green");
      Writer(go1[2] + ", 3");
			Color("null");
      Space();

      //game's first half
      option = Reader();
      while(name != "fuck")
			{
			if (option == go1[0] || option == "Spring" || option == "1" || option == "spring")//spring
			{
        Space();
				Writer("The spring? Well, terrible choice!");
				Space();
				Color("bold");
				Writer("This option is ", 2);
				Color("red");
				Writer("hard mode. ", 2);
				Color("bold");
				Writer("Do you REALLY want to do this option?");
				Space();
				Writer("yes");
				Writer("no");
				Space();
				option = Reader();
				while(stop != true)
				{
					if(option == "yes" || option == "Yes" || option == "YES" || option == "1")
					{
						stop = true;
						Color("null");
					}

					else if(option == "no" || option == "No" || option == "NO" || option == "2")
					{
						End();
					}

					else
					{
						Space();
						ErrorWrite();
						Writer("yes");
						Writer("no");
						Space();
						option = Reader();
					}
				}
				HEARTS -= 2;
				HP -= 2;
				SPE -= 2;
				ATK -= 2;
        Space();
				//swamp springs
				Writer("You go through the desolate springs, which look more like a swamp.");
				Enter();
				Writer("Then, of course, MONSTER ENCOUNTER.");
				Enter();
        MonsterEncounter(17, 3, 4, "Mossatle", 1500F, 90, false);
				Space();
				Writer("The springs, infested, are crawling with monsters.");
				Space();
				MonsterEncounter(20, 4, 3, "Shellatty", 700F, 70, false);
				Space();
				Writer("Each more deadly than the last.");
				Space();
				MonsterEncounter(1, 18, 20, "Kamakasemite", 1100F, 0, false);
				Space();
				Writer(name + ": Why am I even here...");
				Space();
				Writer("Zabuzabuzabuzabuza: Hey you! Time to die!");
				Space();
				Enter();
				Space();
				Writer(name + ": no.");
				Space();
				MonsterEncounter(30, 7, 5, "Zabuzabuzabuzabuza", 1200F, 190, true);
				Space();
				//Duelsville
				Enter();
				Console.Clear();
				Space(3);
				Writer("You finally get out of the swamp-like springs, and travel into a town full of swordsman.");
				Thread.Sleep(700);
				Writer("The town crumbled at your wake, you make your way through.");
				Space();
				MonsterEncounter((int) HEARTS/2, (int) SPE/2, (int) ATK/3, "Goronical Swordsman", (int) EXPNeed/3, (int) GOLD/3, true);
				Space();
				Writer("After the duel, you trot through the broken town, with other swordsman having duels of their own — deadly duels.");
				Space();
				Writer("Swordsman: Hey! You're not going to the DRAGON, right?!");					
				Space();
				Enter();
				Writer(name + ": Yeah. Why?");
				Space();
				ThrDot();
				Space();
				Writer("Swordsman: D I E .", 2);
				Enter();
				MonsterEncounter((int) HEARTS/2, (int) SPE/2, (int) ATK/3, "Duel Swordsman", (int) EXPNeed/3, (int) GOLD/3, true);
				stop = true;		

				Space();
				Writer("After the swordsman, you keep through the area, when you come across a traveling CabinMaster.");
				Enter();
				Writer("CabinMaster: Sup! Want to buy something? I'm having a sale!");
				Space();
				ThrDot();
				Writer("CabinMaster: Look, man. I'm running on low here. barely have enough to eat! I'll give you half off if you buy from me. Heck, I'll throw in an extra for each purchase. Please man, help a guy out here.");
				Enter();
				ThrDot();
				Space();
				Writer("Just then, a swordsman came in for a fight!");
				Enter();
				MonsterEncounter((int) HEARTS/2, (int) SPE/3, (int) ATK, "Guy the Swordsman", (int) EXPNeed/3, (int) GOLD/3, true);
				Space();
				Writer("CabinMaster: Phew! Thanks man! Here's some GOLD for your troubles.");
				Space();
				Writer("You got 20 GOLD!");
				GOLD += 20;
				Enter();
				Writer(name + ": This isn't jack squat! Cheapscape!");
				Space();
				Writer("CabinMaster: I told you, I'm running on empty. Now, are you going to shop or what?", 2);
				Color("red");
				Writer("If I were you, I would buy my bag full! The enemies outside the town are strong and fierce!", 2);
				Color("null");
				//Logic
				Space();
				Use(492, 897, 2145, 1324, 234);
				//rest
				Space();
				Writer("After you encountered the cheapscape, you continue on your path through duel town, destroying too many foes after too many foes.");
				MonsterEncounter((int) HEARTS/2, (int) SPE/3, (int) ATK/4, "Jujutsu Guysen", (int) EXPNeed/3, (int) GOLD/2, true);
				Space();
				MonsterEncounter(HEARTS * 2, (int) SPE, (int) ATK/2, "Madara Uchairha", (int) EXPNeed/3, (int) GOLD/2, true);
				Space();
				MonsterEncounter((int) HEARTS, (int) SPE, (int) ATK/2, "Takeyuki", (int) EXPNeed/3, (int) GOLD/5, true);
				Space();
				MonsterEncounter((int) HEARTS/2, (int) SPE/2, (int) ATK/2, "Taneukami", (int) EXPNeed/3, (int) GOLD/3, true);
				Space();
				Writer("After the encounters with the offly familiar swordsman, you are almost out of Duel Town, when you see a guy.");
				Enter();
				Writer("With a quick slash, the person puts you into a swordlock.");
				Space();
				Writer("Bam ", 2);
				Thread.Sleep(1000);
				Writer("Kablam ", 2);
				Thread.Sleep(1000);
				Writer(" BOOM!", 2);
				Thread.Sleep(1000);
				Space();
				Writer("Swordsman: YEAH. WOO-HOO! THIS is what I like in a swordsman!");
				Enter();
				Writer(name + ": ...");
				Enter();
				Writer("Swordsman: Now! It's time to pick up the ", 2);
				Color("bold");
				Writer("HEAT!", 2);
				Enter();
				Writer("Swordsman: But first, I want a fair match! Heal up!");
				Space();
				Writer("You where healed to Max HP!");
				HP = HEARTS;
				Enter();
				Writer("Swordsman: Now, time to get this party started! It's time for a DEATH DUEL!!!");
				Enter();
				MonsterEncounter(75, 18, 12, "Mysterious Rowdy Swordsman", 4500, 3000, true);
				Writer(name + ": *huff* *puff*");
				Thread.Sleep(1700);
				Space();
				Writer("Swordsman: *Huff* *Puff*");
				Enter();
				Writer("Swordsman: I've never been beaten before...Wow! You really are amazing with thay big sword of yours! I have always been looking for a challenge since I became a swordsman, but I have never been able to find one.");
				Enter();
				Writer("Swordsman: No matter where I looked; other swordsman, colleuges from my academy, my sensei, or even monsters couldn't handle my blade. But you...you showed be something that Rhonido Sensei always told me...");
				Enter();
				Writer("Swordsman: That everyone has a superior in their skill. And that it is important that we listen and respect them!");
				Enter();
				ThrDot();
				Writer("Swordsman: I'm not going to do that to you though!", 2);
				Space();
				ThrDot();
				Writer(name + ": bruh.");
				Enter();
				Writer("Mark: Anyway, my name's Mark, and I'll see you again!");
				Enter();
				Writer("After your jolly but painful meeting, you finally leave the duel-torn village. In its wake, you crumble on the path to the DRAGON, killing many, many, many things that are unlcuky enough to be in traveling way.");
				Enter();
				MonsterEncounter(90, 21, 14, "Bunillaby", 234, 700, false);
				Space();
				MonsterEncounter(85, 19, 12, "Fuzilite", 786, 903, false);
				Space();
				Writer("You keep treking on, the monsters stronger than ever. You push and push, knowing at any moment, a monster could spell your doom.");
				Enter();
				Writer("But you can't let that happen, for you have a goal in mind.");
				Enter();
				MonsterEncounter(84, 8, 7, "Talus", 4534, 880, false);
				Space();
				//Cabin
				if(noCabin == false)
				{
					Writer("You find a cabin on the path, and in need of some well deserved rest, you go in.");
					Enter();
					Writer("CabinMaster: Welcome! You are the 1,000,000th customer! Congradulations! I shall give you 1% off everything as a reward for coming to this amazing cabin which has had 999,999 customers before you! Enjoy your generous sale that comes from luck!");
					Enter();
					Writer(name + ": 1% off? Greedy critz!");
					Enter();
					Writer("CabinMaster: Buisiness is a hard thing, you know. Now, what will you do here?");
					Enter();
					stop = false;
					while(stop != true)
					{
						Color("yellow");
						Writer("You have " + GOLD + " GOLD and ", 2);
						Color("red");
						Writer(HP + " HP left. ", 2);
						Color("yellow");
						Writer("Buy wisely! (1 - 3)", 2);
						Color("green");
						Space();
						Writer("1: Shop");
						Color("bold");
						Writer("2: Rest, G247");
						Color("null");
						Space();
						Writer("3: Leave");
						Space();
						option = Reader();
						//It's time for your favorite thing: Logic!!! Yayyy...*sob* *sob*
						switch(option)
						{
							case "2":
							case "REST":
							case "rest":
							case "Rest":
								Space();
								Writer("You had a nice good rest on a crappy bed. HP fully restored!");
								HP = HEARTS;
								GOLD -= 247;
								Space();
								Writer("CabinMaster: Good afternoon! You had a nice, long sleep sleep didn't you? Our beds are top quality, you know!");
								Enter();
								Writer(name + ": ...");
								Enter();

								Color("yellow");
								Writer("You have " + GOLD + " GOLD and ", 2);
								Color("red");
								Writer(HP + " HP left. ", 2);
								Color("yellow");
								Writer("Buy wisely!", 2);
								Color("green");
								Space();
								Writer("1: Shop");
								Color("bold");
								Writer("2: Rest, G247");
								Color("null");
								Space();
								Writer("Leave");
								Space();
								option = Reader();
							break;

							case "1":
							case "SHOP":
							case "shop":
							case "Shop":
								Space();
								Use(198, 594, 990, 396, 1485);

								Space();
								Color("yellow");
								Writer("You have " + GOLD + " GOLD and ", 2);
								Color("red");
								Writer(HP + " HP left. ", 2);
								Color("yellow");
								Writer("Buy wisely!", 2);
								Color("green");
								Space();
								Writer("1: Shop");
								Color("bold");
								Writer("2: Rest, G247");
								Color("null");
								Space();
								Writer("Leave");
								Space();
								option = Reader();
							break;

							case "3":
							case "LEAVE":
							case "leave":
							case "Leave":
								Space();
								Writer("CabinMaster: Ok. I hope you had your fill here. See ya!");
								stop = true;
							break;

							default:
								Writer("CabinMaster: Speak in english, kiddo.");
								ErrorWrite();

								Color("yellow");
								Writer("You have " + GOLD + " GOLD and ", 2);
								Color("red");
								Writer(HP + " HP left. ", 2);
								Color("yellow");
								Writer("Buy wisely!", 2);
								Color("green");
								Space();
								Writer("1: Shop");
								Color("bold");
								Writer("2: Rest, G247");
								Color("null");
								Space();
								Writer("3: Leave");
								Space();
								option = Reader();
							break;
						}
					}
				}

				else if(noCabin == true)
				{
					Writer("You see a Cabin, but it says: ", 2);
					Color("red");
					Writer("YOU ARE NOT WELCOME, " + name + ".");
					Space();
					Writer("No cabins 4 u!");
				}
				//Mark encounter/Savanna
				Enter();
				Console.Clear();
				Space(2);
				Writer("After the  town, you go into a dry savanna, lush with fauna and deserted with flora. Going through, you learn to appreciate the wildlife of the savanna, and its natural cycle in life.");
				Enter();
				Color("bold");
				Writer("KABLAM!!!");
				Enter();
				Writer("CLING, CHABLING, BAM, BOOM, CLANK!!!");
				Enter();
				Writer("Mark: Now THIS is battling! Yeah! WHOO! Alright!");
				Writer("You keep yourself on your toes as the ground is obliterated by the slashing of mighty swords.");
				Color("null");
				Enter();
				Writer("Struggling to keep up, you manage to push him back.");
				Enter();
				Writer("Mark: 1, 2, 3, 4; I declare a Duel War!", 2);
				Thread.Sleep(2000);
				Color("bold");
				Writer("Mark: 5, 6, 7, 8; Time to put the score straight!", 2);
				Color("null");
				Space();
				MonsterEncounter(140, 23, 18, "[1;34mMonotonous Mark[1;31m", 9000F, 4000, true);
				Space();
				Writer("Mark: *Huff* puff* *Huff* *puff*...You're...*huff* *puff*...good at this...*huff* *puff*");
				Enter();
				Writer("Mark: I thought...catching you by suprise...would be your downfall...but even when I'm smart I...I don't even win!");
				Writer("Mark: You truly are amazing...By the way...what's your name?");
				Enter();
				Writer(name + ": My name ", 2);
				Thread.Sleep(1200);
				Writer("is " + name + ".", 2);
				Enter();
				Writer("Mark: " + name + ", huh? Nice name. Well, see ya!");
				Writer("After that, he jumps away.");
				Enter();
				//rest
				Writer("After the yet again brief encounter, you go through this new and beutiful area; encounters with more swordsman on the path to the DRAGON more common, as this is the quickest route. Which makes is even more ", 2);
				Color("red");
				Writer("dangorous.", 2);
				Color("null");
				Enter();
				MonsterEncounter(60, 10, 10, "Macro Man", 400F, 900, true);
				Space();
				MonsterEncounter(90, 12, 8, "Friezan'", 900F, 1540, true);
				Space();
				Writer("The savanna is vast, and you encounter many animals. It is a very nice place to camp as well. And you find yourself putting out your campfire just to see the beuty of the stars.");
				Enter();
				Writer("You trek and trek, its grass yellowish but soft, and-");
				Enter();
				Color("bold");
				Writer("T H U M P!!!");
				Enter();
				MonsterEncounter(101, 8, 8, "Rockalike", 1100F, 290, true);
				Space();
				Writer("G a U gH!! W hY dOe DiSs HaPpEn O mE ?/? I fE eL iKe CrA p 1 WhY/? WH YYY Y?!?1/");
				Enter();
				Writer("i H A TE wHeN tHIs hApP enS..> M aN...");
				Enter();
				Writer(name + ": It TALKS?!");
				Enter();
				Writer("Rockalike: WeL lL Ye ACH!1 ByE, CriTZ!");
				Enter();
				Writer("After cursing at you, it rolles away while you stay confused on how a monster talked.");
				Enter();
				MonsterEncounter(30, 24, 12, "Dare Demon", 2000F, 470, false);
				//town arc
				Enter();
				Console.Clear();
				Space();
				Writer("Continuing, you come across a deserted village, though this one is unlike duel town.");
				Enter();
				Writer("Walking in, you see a terrible scene; sick people, injured folk, and a little boy trying to take care of them all, along with is siblings. You walk to see the damage, when you see a familiar face; ", 2);
				Color("blue");
				Writer("Mark!", 2);
				Color("null");
				Enter();
				Writer(name + ": What are you doing here Mark?! I thought you where only into battling?");
				Enter();
				Writer("Mark: I am, but when justice calls, I am its right hand man!");
				Enter();
				Writer(name + ": What is THAT supposed to mean?");
				Enter();
				Writer("Mark: It MEANS that I like to help the poor, " + name + "! You should be helping too!");
				Enter();
				Writer("What will you say?");
				Space();
				Color("red");
				Writer("option 1: " + name + ": I know...I was seeing these people in need. I really sould help!");
				Color("green");
				Writer("option 2: " + name + ": I'm a mercinary, not a medic! You can save these people on your own. I want to stay out of this.");
				Color("null");
				Space();
				option = Reader();
				//logic
				stop = false;
				while(stop == false)
				{
					switch(option)
					{
						case "1":
						case "1:":
						case "option 1":
						case "option 1:":
						case "I know...I was seeing these people in need. I really sould help!":
							Space();
							Writer("Mark: Now THAT'S the mark of a true swordsman! It's good to help people in need!");
							Enter();
							Writer(name + "[embarrassed]: Whatever...");
							stop = true;
						break;

						case "2":
						case "2:":
						case "option 2":
						case "option 2:":
						case "I'm a mercinary, not a medic! You can save these people on your own. I want to stay out of this.":
							Space();
							Writer("Mark: What a critz! Mark, I didn't know you were this heartless!");
							Enter();
							Writer(name + ": For a mercinary, to have a heart is a bad thing, you know.");
							Enter();
							Writer("Mark: At least ", 2);
							Color("bold");
							Writer("try!", 2);
							Color("null");
							Space();
							Writer(name + ": How about ", 2);
							Color("bold");
							Writer("no?", 2);
							Color("null");
							stop = true;
						break;

						default:
							Space();
							ErrorWrite();
							Writer("What will you say?");
							Space();
							Color("red");
							Writer("option 1: " + name + ": I know...I was seeing these people in need. I really sould help!");
							Color("green");
							Writer("option 2: " + name + ": I'm a mercinary, not a medic! You can save these people on your own. I want to stay out of this.");
							Color("null");
							Space();
							option = Reader();
						break;
					}
				}
				//rest
				Space();
				Writer("Mark: Anyway, right now are priority is getting the guys who caused this. Right now I heard they're heading for ", 2);
				Color("red");
				Writer("THE DRAGON.", 2);
				Color("null");
				Enter();
				Writer(name + ": So, how are they getting there?");
				Enter();
				Writer("Mark: They're getting there by ship. We can take a boat and take them out! And once we do that, we can take the stuff they stole!");
				Enter();
				Writer(name + ": Seems simple enough. So how do you think we'll get to them, now that we are quite the way away from the shore?");
				Enter();
				Writer("Mark: Simple. We'll ", 2);
				Color("red");
				Writer("fire ", 2);
				Color("null");
				Writer("our way there!", 2);
				Enter();
				Writer(name + ": What do you mean?");
				Enter();
				Writer("Mark: Simple! We take a foward cannon. When we go, we will be at the shore where they'll be! Chances are that they have yet to leave, so we can catch up to them!");
				Enter();
				Writer(name + ": Seems legit.");
				Space();
				Writer("Mark: Great! Just remember to get ready first! We may be there for a while");
				Enter();
				Writer("Townspeople: We thank you greatly for what you two are doing for us. Here is some GOLD for your troubles.");
				Enter();
				Writer("You gained 500 GOLD!");
				GOLD += 500;
				Enter();
				Writer(name + ": You mean 'little' GOLD don't you.");
				Enter();
				Writer("Mark: Shut up!");
				Enter();
				Color("yellow");
				Writer("You have " + GOLD + " GOLD and ", 2);
				Color("pink");
				Writer(HP + " HP left. ", 2);
				Color("bold");
				Writer("Be wise!", 2);
				Color("null");
				ItemUser();
				Enter();
				//ship
				Console.Clear();
				Space();
				Writer("You both get into separate cannons, each prepared — hopefully — for the hardships ahead.");
				Enter();
				Writer("Mark: I hope you're ready for this!");
				Space();
				Color("bold");
				Writer(name + ": P e r h a p s.");
				Enter();
				ThrDot();
				Thread.Sleep(1200);
				Writer("BAM!");
				Color("null");
				Space();
				Writer("With a blast, you are off, off away.");
				Enter();
				Writer("PLUNK!");
				Enter();
				Writer("Mark [hurt]: Man! Perhaps I shouldn't have made us travel by cannon, that hurt like fu-");
				Space();
				Writer(name + ": Keep the game T rated, please.");
				Enter();
				Writer("Mark: Frick...");
				Enter();
				Writer("You see a pirate in the distance. What do you do?");
				stop = false;
				while(stop == false)
				{
					Space();
					Color("green");
					Writer("option 1: " + name + "[thinking]: Frick these guys, I'm not going to point it out.");
					Color("red");
					Writer("option 2: " + name + "[thinking]: For once, I want to be helpful. I'll tell Mark about that guy.");
					Color("null");
					Space();
					option = Reader();
					Space();
					switch(option)
					{
						case "Option 1:":
						case "option 1:":
						case "Option 1: ":
						case "option 1: ":
						case "Option One:":
						case "option one:":
						case "Option One: ":
						case "option one: ":
						case "1":
						case "One:":
						case "one:":
						case "One: ":
						case "one: ":
						case "1: ":
						case "1:":
							Writer(name + ": ...");
							Space();
							Writer("After a little bit, the pirates leave the shore.");
							Space();
							Writer("Mark: Hey, dammit! They're getting away!");
							Enter();
							Writer(name + "[playing innocent]: Huh.");
							Enter();
							Writer("Mark: Darn, we're going to have to travel by sea!");
							Enter();
							Writer(name + ": Why not boat?");
							Enter();
							Writer("Mark: Because I don't know how to use a boat.");
							Enter();
							Writer("Mark: So now, let's strap down, put on our swimming suits, and let's get swimming!");
							Enter();
							//ocean
							Console.Clear();
						break;

						case "Option 2:":
						case "option 2:":
						case "Option 2: ":
						case "option 2: ":
						case "Option Two:":
						case "option two:":
						case "Option Two: ":
						case "option two: ":
						case "2":
						case "Two:":
						case "two:":
						case "Two: ":
						case "two: ":
						case "2: ":
						case "2:":
							Writer(name + ": Look! Over there! A pirate!");
							Enter();
							Writer("Great! Let's annialate him!");
							MonsterEncounter(100, 30, 19, "Ol' Pirate Joe (Sweeper)", 600F, 600, false);
						break;
					}
				}
      }

			if(option == go1[3] || option == "69")//DEBUG
			{
				MonsterEncounter(monName: "Debug Bug", exp: 2000F, gold: 3000,attack: 4 ,hp: 20, speed: 2, doubleBattle: true);
				MonsterEncounter(monName: "Debug Bug", exp: 3000F, gold: 3000, doubleBattle: true);
				Writer("END");
				Enter();
				End(0);
			}

	    else if (option == go1[2] || option == "Forest" || option == "Forests" || option == "forest" || option ==  "3")//forests
			{
        Space();
				//forests
				Writer("forest? Classic choice! You go and immediately run into a MONSTER ENCOUNTER");
        Space();
        MonsterEncounter(5, 3, 2, "Bushable", 500F, 100);
        Space(2);
        //rest of the option
        Writer("You defeated (or maybe ran from) the monster, but your jouney still goes on.");
				Space();
        Writer("You go through the dangorous forests, destroying all in your path.");
				Enter();
				MonsterEncounter(10, 4, 5, "Stealing Steve", 1500F, 1200);
				Space();
				//Crossroads
				Enter();
				Console.Clear();
				Writer("You come to a crossroads or a Mine and Mountain. What shall you do?");
        Writer("What shall you do?");
        Space();
        Writer("Go to Mine");
        Writer("Go to Mountain");
        //Logic
        Space();
        option = Reader();
        while(true)//while loop to keep going through options if wrong input
				{
				switch(option) 
				{
      	  case "1":
					case "Go to Mine":
					case "go to mine":
					case "mine":
					case "Mine":
      	    Space();
      	    Writer("You go through the dark mines, where you meet a guy");
      	    Space();
      	    Writer("GUY: Hi! You're in the mines, huh. Not to be captin ovious, but you really shouldn't	be here. it's dangorous.");
      	    Enter();
      	    Writer("What do you say? (1 for option1, 2 for option 2)");
      	    Space();
      	    Writer("option 1: " + name + ": I don't care. I gotta mission to do,so scram");
      	    Space();
						Writer("option 2: " + name + ": *sniff* o k.");
						Space();
      	    option = Reader();
      	    switch(option) {
      	      case "1":
							case "I don't care. I gotta mission to do,so scram":
							case "option 1":
      	        Writer("I warned you.");
								Space();
      	        MonsterEncounter(23, 5, 9, "MegaMadGuy", 200F, 300, false);
								Space();
								Writer("You keep going through the mines,");
								Enter();
								MonsterEncounter(25, 4, 6, "Rockalike", 1500F, 130, false);
								Space();
								Writer("Going through the tipper-tap of picks, you stumble into a caption.");
								Space();
								Writer("Captin [on phone]: Mmmhm. Huhhuh. WHAT?! I'm going to destory him in the name of the law when I find him! What are to details? What? A large sword and his name is '" + name + "'? I'll definitely find and kill him!");
								Enter();
								Writer(name + ": Uhhh, hello?");
								Thread.Sleep(1000);
								Space();
								Writer("Captin: Who are you?");
								Space();
								Thread.Sleep(3000);
								Writer(name + ": I'm " + name + ".");
								ThrDot();
								Thread.Sleep(2200);
								Space();
								Writer("Captin: >:(", 2);
								Space(2);
								MonsterEncounter(40, 6, 7, "Caption Joe", 5000F, 2000, true);
								//Forest: Weeping Ruins
								Enter();
								Console.Clear();
								Space(2);
								Writer("You head out of the mines on the other end to find a hedgeworth of ruins. Big and small; long and short. You walk through, being guilded by your map to the ultimate goal.");
								Enter();
								MonsterEncounter(27, 5, 5, "Artifact Stealer", 2000F, 700, false);
								Space();
								Writer("You see a potion lying on the ground.");
								Space();
								Writer("You got a potion!");
								if(HEARTS >= 30)
								{
									Space();
									Writer("You got a potion +!");
									//logic
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
								}

								else
								{
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
								}
								Enter();
								MonsterEncounter(25, 4, 6, "Talus", 1700F, 90, false);
								Space();
								Writer("You face the ruins, thinking of what might've lived there, and you remember to keep on path");
								Enter();
								MonsterEncounter(30, 8, 8, "Falbed Gaurd", 3000F, 900, true);
								Space();
								//Cabin
								if(!noCabin)
								{
									Writer("You are going when you come across a store in the ruins. In need of supplies, you go inside.");
									Space();
									Writer("CabinMaster: Hello! I like studying past civilizations, but I need money! So I founded this store here. You buy supplies, I get to study. Win win!");
									
									Enter();
									Writer("What do you want to do?");
									Space();
									Writer("1: Shop");
									Writer("2: Rest, G300");
									Space();
									Writer("3: Leave");
									Space();
									option = Reader();
									bool cockend = false;
									while(!cockend)
									{
										switch(option)
										{
											case "1":
											case "1:":
											case "SHOP":
											case "shop":
											case "Shop":
												Space();
												Writer("Great! Here's the options. I don't have much, but I hope you are satisfied!");
												Space();
												Color("yellow");
												Writer("You have " + GOLD + " GOLD left. Purchase wisely!");
												Color("null");
												Space();
												Writer("potion, G400");
												Writer("potion +, G800");
												Writer("ATK UP, G1200");
												Space();
												Writer("Leave");
												Space();
												option = Reader();
												bool napend = false;
												while(!napend)
												{
													switch(option)
													{
														case "potion":
															if(GOLD >= 400)
															{
																Space();
																Writer("You bought a potion!");

																GOLD -= 200;
																Space();
																Writer("Do you want to use it?");
																Space();
																Writer("yes");
																Writer("no");
																Space();
																option = Reader();
																if(option == "yes") 
																{
																	Space();
																	Writer("You gained 20 HP!");
																	HP += 20;
																	napend = true;
																	cockend = true;
																}

																else
																{
																	GOLD -= 200;
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

																	Space();
																	Writer("Do you want to stop shopping?");
																	Space();
																	option = Reader();
																	switch(option)
																	{
																		case "1":
																		case "YES":
																		case "Yes":
																		case "yes":
																			napend = true;
																		break;

																		case "2":
																		case "NO":
																		case "No":
																		case "no":

																		break;

																		default:
																			ErrorWrite();
																		break;
																	}
																}
															}

															else if(GOLD < 400)
															{
																Space();
																Writer("CabinMaster: Sorry, " + name + ", But I'm too poor to be generous!");
															}
														break;

														case "potion +":
															if(GOLD >= 800)
															{
																Space();
																Writer("You bought a potion +!");
																GOLD -= 600;
																Space();
																Writer("Do you want to use it?");
																Space();
																Writer("yes");
																Writer("no");
																Space();
																option = Reader();
																if(option == "yes") 
																{
																	Space();
																	Writer("You gained 60 HP!");
																	HP += 60;
																	napend = true;
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
																}
																Space();
																Writer("Do you want to stop shopping?");
																Space();
																option = Reader();
																switch(option)
																{
																	case "1":
																	case "YES":
																	case "Yes":
																	case "yes":
																		napend = true;
																	break;

																	case "2":
																	case "NO":
																	case "No":
																	case "no":

																	break;

																	default:
																		ErrorWrite();
																	break;
																}
															}

															else if(GOLD < 800)
															{
																Space();
																Writer("CabinMaster: Sorry, " + name + ", but I'm too poor to be generous!");
															}
														break;

														case "ATK UP":
															if(GOLD >= 1200)
															{
																Space();
																Writer("You bought a ATK UP!");
																GOLD -= 1000;
																Space();
																Writer("Do you want to use it?");
																Space();
																Writer("yes");
																Writer("no");
																Space();
																option = Reader();
																if(option == "yes") 
																{
																	Space();
																	Writer("You gained 5 ATK!");
																	ATK += 5;
																	napend = true;
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
																}

																Space();
																Writer("Do you want to stop shopping?");
																Space();
																option = Reader();
																switch(option)
																{
																	case "1":
																	case "YES":
																	case "Yes":
																	case "yes":
																		napend = true;
																	break;

																	case "2":
																	case "NO":
																	case "No":
																	case "no":

																	break;

																	default:
																		ErrorWrite();
																	break;
																}
															}

															else if(GOLD < 1200)
															{
																Space();
																Writer("CabinMaster: Sorry, " + name + ", but I'm too poor to be generous!");
															}
														break;

														case "Leave":
															Space();
															Writer("CabinMaster: Ok. see ya!");
															cockend = true;
															napend = true;
														break;

														default:
															Space();
															ErrorWrite();
															Space();
															Writer("What would you like to buy?");
															Space();
															Writer("potion, G400");
															Writer("potion +, G800");
															Writer("ATK UP, G1200");
															Space();
															Writer("Leave");
															Space();
															option = Reader();
														break;
													}
												}
											break;

											case "2":
											case "2:":
											case "REST":
											case "rest":
											case "Rest":
												Space();
												Writer("Welp, rest up! I have a guest room over there!");
												Space();
												Writer("You rested for the next day. HP full!");
												HP = HEARTS;
												Thread.Sleep(1200);
												Console.Clear();
											break;

											case "3":
											case "3:":
											case "LEAVE":
											case "leave":
											case "Leave":
												Space();
												Writer("CabinMaster: Ok. see ya!");
												cockend = true;
											break;

											default:
												ErrorWrite();
												Space();
												Writer("CabinMaster: I'll ask this again. What do you want to do here?");
												Space();
												option = Reader();
											break;
										}
									}
								}

								else
								{
									Writer("You see a cabin, but it's empty. no cabns 4 u!");
								}
								//rest
								Enter();
								Writer("Continuing on your jouney through the Ruined civilization, you encounter many foes.");
								Space();
								MonsterEncounter(32, 8, 9, "Fabled Gaurd", 4000F, 950, false);
								Space();
								MonsterEncounter(31, 7, 8, "Fabled Gaurd", 2500F, 850, false);
								Space();
								Writer("Continuing on, you get to a docks, but then, someone rams you into the ocean!");
								Space();
								MonsterEncounter(42, 11, (int) ATK/3, "Stealing Mermaid-Man Thing", 4500F, 2300, true);
								Space();
								//Ocean
								Enter();
								Console.Clear();
								Writer("After killing your foe, you are in the ocean. A deep, dark ocean.");
								Space();
								Writer("Now, you were originally planning to go on a ship to THE DRAGON. But now, you will most likely have to swim instead.");
								Enter();
								Writer(name + ": Oh crap. Now I have to swim hundreds of miles! This is just damning great!");
								Space();
								MonsterEncounter(35, 14, 7, "Mosshuat", 2000F, 0, false);
								Space();
								MonsterEncounter(30, 12, 9, "BIONICLE BOI", 660F, 0, false);
								Space();
								MonsterEncounter(1, 1, 999, "UNDER DEM SEA", 2324F, 334, false);
								Space();
								MonsterEncounter(39, 15, 20, "X X X X X X X", 3424F, 883, false);
								Space();
								Writer(name + ": Da frick are these fish names?!");
								Enter();
								MonsterEncounter(25, 16, 7, "The Fitness Gram", 2900F, 10, true);
								Space();
								MonsterEncounter(35, 15, 8, "Pacer Test is", 2900F, 10, true);
								Space();
								MonsterEncounter(45, 14, 10, "A Multistage Aerobatic Compacity", 2900F, 10, true);
								Space();
								MonsterEncounter(55, 13, 13, "That Gets Progressivly Harder", 2900F, 10, true);
								Space();
								MonsterEncounter(65, 12, 17, "As You Go.", 2900F, 10, true);
								Space();
								Thread.Sleep(2000);
								Writer(name + ": (ಠ_ಠ)");
								Space();
								Thread.Sleep(3000);
								Writer("SilverAtom: (•̀.̫•́✧)");
								Space();
								ItemUser();
								MonsterEncounter(69, 0, 21, "Deal with it.", 69F, 69, true);
								Space();
								//Ocean Cave
								Thread.Sleep(3000);
								Console.Clear();
								Writer(name + ": I think the sea water is getting to me...");
								Writer("You say as you swim right into a large skull shaped cave. From there, things felt a little more fresh. Even the water became freshwater, somehow. You felt relaxed, and you let yourself relax. And-");
								Space(5);
								HP -= 10;
								MonsterEncounter(50, 8, 10, "Gaurdian Eel", 4000F, 70, true);
								Space();
								Writer("The eel dropped to the floor as you swam even more, wondering why you aren't drowning by now.");
								Space();
								Writer("Then, out of nowhere, a DRAGON came!");
								ItemUser();
								Space(3);
								MonsterEncounter(215, 20, 12, "Ocean DRAGON", 20000F, 700, true);
								Space(2);
								Writer("After the death of the fiendish foe, you are finally, after many hours of swimming, at the shore of the city. Now, there is only one thing left to do. Find...");
								Space(5);
								Thread.Sleep(3000);
								Writer("THE DRAGON");
								Thread.Sleep(2000);
								EndGame();
								Credits();
								End();
      	      break;

      	      case "*sniff* o k.": 
							case "2":
							case "option 2:":
      	        Writer("GUY: Good. Well, nice meeting	you. Bye!");
      	        Space(2);
								Writer("What shall you do?");
      					Space();
      					Writer("Go back to Mine");
      					Writer("Go to Mountain");
      					//Logic
      					Space();
      					option = Reader();
      	      break;
      	    }
      	  break;

      	  case "2":
					case "Go to Mountain":
					case "go to mountain":
					case "mountain":
					case "Mountain":
						Space();
						Writer("You go up the steap Mountain, where you meet a man in the distance, but when the man gets closer, he gets hairier, then bigger,then it is clear you have not met a man.");
						Space(2);
						MonsterEncounter(25, 2, 3, "Obscurasnow Medium",4000F, 150);
						//rest
						Space(2);
						Writer("After you defeated the Obscurasnow, you keep on the path; it getting snowier as you go. You can berely see where you are going, and your food is nearly freezing in your hands.");
						Space();
						//Cabin
						if(noCabin == false)
						{
							//Cabin
							Writer("Things aren't looking up for you. The higher you go, the worse it gets. Then, you see a cabin. A nice, humble cabin amist the stormy Mountain.");
							Enter();
							Writer("CabinMaster: Helloo! Stormy Mountain, Huh? Yeah, I built this cabin so people could rest up on their jouney to the heart.");
							Space(2);
							Writer("CabinMaster: So anyway, do you want to rest up for 400 gold? Livng up here isn't easy, you know.");
							Space();
							//Logic
							Writer("Pay up? You have " + GOLD + " gold and " + HP + " HP left.");
							Space();
							Writer("yes");
							Writer("no");
							Space();
							option = Reader();
							switch(option)
							{
								case "YES":
								case "Yes":
								case "yes":
									GOLD -= 400;
									HP = HEARTS;
									Space();
									Writer("CabinMaster: Thank you for your service. But there is more too! I have a plethera of supplies, and can I interest you with them?");
									Space();
									Writer("yes");
									Writer("no");
									Space();
									Space();
									//near shop
																
								break;
								
								case "No":
								case "NO":
								case "no":
								Space();
								Writer("CabinMaster: No? Well you'll regret it! See you around, if ever!");
								break;

								case "Attack":
									Space();
									Writer("You killed the CabinMaster, you murderer.");
									Space(2);
									Writer("No mor cabns 4 u!");
									noCabin = true;
								break;
								
								default:
								Writer("CabinMaster: What? It's a yes	or no question. So what'll it be?");
								Space();
								Writer("yes");
								Writer("no");
								Space();
								option = Reader();
								break;
							}
						}
						else
						{
							Writer("You see a cabin, but it is empty, so you move on to a shop next to it.");
						}
						//rest
						Enter();
						Writer("In the drift, you continue to the top. For, reasons. Anyway, you see humanoids again. But this time, they're smaller, and TWO of them!");
						Space(2);
						MonsterEncounter(15, 3, 2, "Obscureasnow Mini",3000F, 70);
						Space(2);
						Writer("You defeated one, but the other comes charging at you!");
						Enter();
						MonsterEncounter(15, 3, 2, "Obscureasnow Mini",3000F, 70);
						Space(2);
						Writer("Those little ones were no match for you!");
						Enter();
						Space();
						Writer("You head to the top, hoping to be able to find whatever you are looking for. But you hear footsteps. LOUD footsteps. Of a beast, no, a monster. A huge Obscuronsnow appears, threatening you with it's booming chest bumps. DO you, " + name + " know what that means? MONSTER ENCOUNTER.");
						ItemUser();
						Space(4);
						//Boss
						MonsterEncounter(60, 8, 10, "Obscuronsnow Large", 10000F, 300, true);
						//Heart Caverns
						Writer("After crossing paths with the beast, you have defeated it, and therefore you can move on to the heart.");
						Space();
						MonsterEncounter(30, 6, 7, "Heart Gaurdian", 1000F, 20, false);
						Space();
						MonsterEncounter(30, 6, 7, "Heart Gaurdian", 1000F, 20, false);
						Space();
						MonsterEncounter(30, 6, 7, "Heart Gaurdian", 1000F, 20, false);
						Space();
						MonsterEncounter(32, 6, 7, "Heart Gaurdian", 1000F, 20, false);
						Space();
						Writer(name + ": There's a lot of these 'Heart Gaurdian' things huh?");
						Enter();
						MonsterEncounter(36, 6, 7, "Heart Gaurdian", 1000F, 20, false);
						Space();
						MonsterEncounter(42, 6, 7, "Heart Gaurdian", 1000F, 20, false);
						Space();
						MonsterEncounter(50, 6, 7, "Heart Gaurdian", 1000F, 20, false);
						Space();
						Writer("You stop for a well needed break from the onslaught of Gaurdians on your tail, to sharpen your sword and stuff. Sitting on the ground, there is a beating presence. Then, and jewl-like arm sits on your shoulder.");
						Space(3);
						MonsterEncounter(67, 1, 12, "Jewled Man", 3500F, GOLD, true);//Mini-Boss
						Space();
						Writer(name + ": What was that?! Is that ", 2);
						Color("bold");
						Writer("a...man!", 2);
						Color("bold");
						Enter();
						Writer(name + ": What the hell...");
						Writer("You say as the monster appears to be a man.");
						Enter();
						Writer("The realization frightens you, as you head downroad. The gaurdians you see become more agressive, so there is no time to put away your sword.");
						Enter();
						MonsterEncounter(62, 8, 11, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(69, 8, 11, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(70, 8, 11, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(70, 8, 11, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(70, 8, 11, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(70, 8, 11, "Heart Gaurdian", 3000F, 20, false);
						Space();
						Writer(name + ": *Huff* *puff*");
						Enter();
						MonsterEncounter(90, 11, 15, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(90, 11, 15, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(100, 11, 9, "Heart Gaurdian", 3000F, 20, false);
						Space(2);
						Writer(name + ": So...*puff*...many....*huff*");
						Enter();
						MonsterEncounter(120, 14, 17, "Heart Gaurdian", 3000F, 20, false);
						Space();
						MonsterEncounter(128, 14, 17, "Heart Gaurdian", 3000F, 20, false);
						Space();
						Writer("After 11 ENCOUNTERS, you finally get to the main door. better use an item!");
						Space();
						ItemUser();
						Space(3);
						Writer("You open the awesomely big doors, to reveal a heart. And a gaurdian. A HUGE GAURDIAN. One that is bigger than the heart itself.");
						Space();
						Writer("BOSS ENCOUNTER!");
						Thread.Sleep(2000);
						MonsterEncounter(150, 9, 13, "Mega Heart Gaurdian", 100F, 20, true);
						Space();
						Thread.Sleep(1000);
						Writer("BAAAAAAAM!");
						Space();
						Writer("The gaurdian was a host, and there was something inside! In reality the beast was a DRAGON!");
						Enter();
						ItemUser();
						Space();
						Writer("Ice DRAGON: RWWWWWAAAAAAAARRRRR!!!");
						Space(5);
						MonsterEncounter(220, 15, 17, "Ice DRAGON", 20000F, 2000, true);
						Space(4);
						Writer("Glistening, the heart as more awesome than anyone had known. You reach for it, and it gives you a message.");
						Space(5);
						Thread.Sleep(2000);
						Color("blue");
						Writer("THERE WILL BE A REMAKE.");
						inventory[10] = "null";
						Thread.Sleep(1000);
						Space(3);
						Writer("Ingraning whatever that means in your mind, you make your way out of the Mountains, the city in the horizon. All for one purpose: ");
						Thread.Sleep(3000);
						Space(5);
						Writer("To destroy the DRAGON.");
						Thread.Sleep(2000);
						From[2] = true;
						EndGame();
						Credits();
						End();
      	  break;
      	  
					default:
      	    ErrorWrite();
						Space();
						Writer("Where to? Mine or Mountain?");
						Space();
						option = Reader();
      	  break;
      	}
      	}
			}


      else if (option == go1[1] || option == "Hills" || option == "Hill" || option == "hill" || option == "2") //hills
			{
        Writer("The hills? Basic choice! You head towards the hills, but MONSTER ENCOUNTER!");
        MonsterEncounter(5, 1, 4, "Rockalike");
        Space();
				Writer("After you defeated the Rokalike, you head through the steap hills, until you get to a bar.");
				Space();
				Writer("Hungry for som o' dat 'good stuff', You head in willingly.");
				Space(2);
				Writer(name + ": Gimmie a drink, bartender.");
				Writer("You ask as you come in and sit on a stool.");
				Space();
				Writer("You see a hot girl next to you. From there you greet her.");
				Space();
				Writer("Girl: Hello. You look like a strong boy. Why don't you take a task for me honey, and I'll give ya 500.");
				Space();
				Writer("Girl: What do you say?");
				Space();
				Writer("yes");
				Writer("no");
				Space();
				option = Reader();
				bool eeend = false;
				while(!eeend)//Angelina task
				{
					switch(option)
					{
						case "yes":
							Space();
							Writer("Angelina: Awesome! My name's Angelina, so report to me when finished with your task. Alright?");
							Space(2);
							Writer("TASK: KILL 3 BUSHABLES");
							eeend = true;
						break;

						case "no":
							Space();
							Writer("Girl: Oh? Well that's too bad. Anyway, see you around!");
							eeend = true;
						break;

						default:
							Writer("Girl: What? Speak in English, Honey.");
							Space();
							ErrorWrite();
							Space();
							option = Reader();
						break;
					}
				}
				Space();
				Writer("Bartender: Here's a drink.");
				Space();
				Writer("Will you drink the Sake?");
				Space();
				Writer("yes");
				Writer("no");
				Space();
				option = Reader();
				switch(option)
				{
					case "yes":
						Writer("UNDERAGE DRINKING IS BAD!!! You lost HP!");
						Writer("You wasted 70 gold!");
						GOLD -= 70;
						HP -= 5;
						ATK += 5;
					break;

					case "no":
						Writer("You did the right thing!");
						Space();
						Writer("Bartender: Guess you just want some milk. Sorry, you look like you're an adult, but you're actually 16.");
						Space();
						Writer("Take the milk?");
						Space();
						Writer("yes");
						Writer("no");
						Space();
						option = Reader();
						bool eeeend = false;
						while(!eeeend)
						{
							switch(option)
							{
								case "yes":
									Space();
									Writer("Drink MILK for Calcium!");
									Writer("You lost 40 gold! You gained 5 ATK!");
									GOLD -= 40;
									ATK += 5;
									eeeend = true;
								break;

								case "no":
									Space();
									Writer("Bartender: Why'd you even say for me to give you a drink if you didn't want to drink anythin'?");
									eeeend = true;
								break;

								default:
									Writer("Bartender: Yes or no question.");
									Space();
									Writer("Take the milk?");
									Space();
									Writer("yes");
									Writer("no");
									Space();
									option = Reader();
								break;
							}
						}
					break;
				}

				Space();
				Writer("After relaxing at the bar, you stumble over a Rockalike. It gets mad and MONSTER ENCOUNTER!");
				MonsterEncounter(25, 4, 3, "Rockalike Small", 3000F, 150);
				Space(3);
				Writer("Rockalike: GRAAAAAAAUUUUUUGGGGHHHHHHH!!!! AAAAUUGGHH ThAt HuRtS! wHy DiD yOu HuRt Me?!?!");
				Space();
				Writer(name + ": Oh? You animals talk?, 1");
				Writer(name + ": Because you attacked me first!, 2");
				Space();
				option = Reader();
				Space();
				switch(option)
				{
					case "1":
						Writer("Y E S  wE cAn TaLk! WeE ErE rElAeD tO oU mUrDeReRs,, AfTeR aLl.. T H A T '' S  W H Y  wE cAn LeArN yOuR IrReGeLaR lEgUeG..");
					break;
					
					case "2":
						Writer("W R O N G ! YoU StUmBlEd OvEr M E  fIrSt!");
					break;

					default:
						Writer("It looks as it it doesn't even understand you.");
					break;
				}

				Space();
				Writer("GuH,,  i fEe T E RR I B L E  !1 ImMa lEaVe1");
				Space();
				Writer("The Rockalike rolled away.");
				Space();
				Writer("After the encounter, ");
				MonsterEncounter(20, 4, 4, "Talus Small", 700F, 90);
				Space();
				Writer("You keep on.");
				MonsterEncounter(22, 3, 6, "Talus Medium", 850F, 110);
				Space();
				Writer("Destorying thing after thing;");
				MonsterEncounter(13, 6, 7, "Viper Planter", 900F, 60);
				Space();
				Writer("Monster after monster.");
				MonsterEncounter(26, 3, 6, "Talus Large", 3100F, 300);
				Space();
				Writer("Keeping at it.");
				MonsterEncounter(20, 5, 5, "Talus", 1500F, 400);
				Space();
				Writer("Until you find");
				Writer("potion found");
				inventory[9] = "potion";
				MonsterEncounter(24, 1, 10, "Slow Stomper", 1600F, 50);
				Space();
				Writer("Until you find");
				Space();
				Thread.Sleep(2000);
				Space(4);
				Writer("THE DRAGON");
				Thread.Sleep(3000);

								
				if(inventory[8] == "null")
				{
					Writer("You found a potion from the ground.");
					inventory[8] = "potion";
				}
				if(inventory[7] == "null")
				{
					Space();
					Writer("You found another potion from the ground. Odd");
					inventory[7] = "potion";
				}
				Space(2);
				Writer("You feel a omninious feeling in the air.");
				//Maximo Boss
				Space();
				Writer("STOMP");
				Thread.Sleep(100);
				Space();
				Writer("STOMP");
				Thread.Sleep(100);
				Space();
				Writer("STOMP");
				Thread.Sleep(100);
				Space();
				Writer("STOMP");
				Thread.Sleep(100);

				Space();
				Writer("M", 2);
				Thread.Sleep(700);
				Writer("A", 2);
				Thread.Sleep(700);
				Writer("X", 2);
				Thread.Sleep(700);
				Writer("I", 2);
				Thread.Sleep(700);
				Writer("M", 2);
				Thread.Sleep(700);
				Writer("O");
				Thread.Sleep(700);
				Writer("BOSS ENCOUNTER");

				Thread.Sleep(300);
				Writer("STATUS", 2);
				Writer(".", 2);
				Thread.Sleep(700);
				Writer(".", 2);
				Thread.Sleep(700);
				Writer(".", 2);
				Thread.Sleep(900);
				Writer("EDIJUFVBEHKSAYVSIOLUHFYBOYU", 2);
				Thread.Sleep(1000);
				Writer("-DEATH", 2);
				Space(3);
				Thread.Sleep(1000);
				ItemUser();
				//MAXIMO ENCOUNTER
				MonsterEncounter(100, 9, 12, "MAXIMO", 4500F, 3000, true);
				//rest
				Writer("With the MAXIMO gone, you see a path downroad. Embarking on that path goes through a canyon known as DRAGON CLIMB CANYON.");
				Space();
				MonsterEncounter(33, 9, 12, "Boinker", 1000F, 80, false);
				Space();
				Writer("You keep heading down the path, rocky areas stumbling you up, causing you to take damage. -2 HP.");
				HP -= 2;
				MonsterEncounter(1, 10, 20, "Fecies-a-fier", 5000F, 250, false);
				Space();
				Writer("Through everything, you feel something on your back. A chill that is piercing.");
				Space();
				MonsterEncounter(42, 8, 8, "Talus", 2000F, 70, false);
				Space();

				Writer("You keep going, 'laying to rest' the mosters you come by.");
				Thread.Sleep(150);
				Space(3);
				Writer("But the feeling won't go away.");
				Thread.Sleep(1000);
				Enter();
				Writer("A LandShark soars at you from out of nowhere, and gets a free hit! -9 damage! Mini-Boss Encounter!");
				HP -= 9;
				Space();
				MonsterEncounter(120, 11, 10, "LandShark", 2700F, 120, true);//LandShark Miniboss
				Space();
				Writer("That chilly feeling still resides in your soul, the presence of a looming threat keeps you at your sword handle. Some monsters aproach you, but they are slashed to bits before a battle starts.");
				Enter();
				Writer("You keep walking, listening, brewing a plan for which you will partake when the monster approaches. Your palms are sweating bineith your gloves, legs tightening to anticipate a threat. The presence feels like a never-ending gaze that watches your every movement; stalking you, examining you, feeling you.");
				Enter();
				Writer("M", 2);
				Thread.Sleep(300);
				Writer("a", 2);
				Thread.Sleep(300);
				Writer("k", 2);
				Thread.Sleep(300);
				Writer("i", 2);
				Thread.Sleep(300);
				Writer("n", 2);
				Thread.Sleep(300);
				Writer("g", 2);
				Thread.Sleep(300);
				Writer(" ", 2);
				Thread.Sleep(300);
				Writer("s", 2);
				Thread.Sleep(300);
				Writer("u", 2);
				Thread.Sleep(300);
				Writer("r", 2);
				Thread.Sleep(300);
				Writer("e", 2);
				Thread.Sleep(300);
				Writer(" ", 2);
				Thread.Sleep(300);
				Writer("y", 2);
				Thread.Sleep(300);
				Writer("o", 2);
				Thread.Sleep(300);
				Writer("u", 2);
				Thread.Sleep(300);
				Writer(" ", 2);
				Thread.Sleep(300);
				Writer("a", 2);
				Thread.Sleep(300);
				Writer("r", 2);
				Thread.Sleep(300);
				Writer("e", 2);
				Thread.Sleep(300);
				Writer(" ", 2);
				Thread.Sleep(300);
				Writer("a", 2);
				Thread.Sleep(300);
				Writer(" ", 2);
				Thread.Sleep(300);
				Writer("g", 2);
				Thread.Sleep(300);
				Writer("o", 2);
				Thread.Sleep(300);
				Writer("o", 2);
				Thread.Sleep(300);
				Writer("d", 2);
				Thread.Sleep(300);
				Writer(" ", 2);
				Thread.Sleep(300);
				Writer("m", 2);
				Thread.Sleep(300);
				Writer("e", 2);
				Thread.Sleep(300);
				Writer("a", 2);
				Thread.Sleep(300);
				Writer("l", 2);
				Thread.Sleep(300);
				Writer(".", 2);
				Thread.Sleep(900);
				Space();

				MonsterEncounter(65, 9, 11, "Young Dragon", 3000F, 300, false);
				Space();
				Thread.Sleep(300);
				Writer(".", 2);
				Thread.Sleep(300);
				Writer(".", 2);
				Thread.Sleep(300);
				Writer(".", 2);
				Thread.Sleep(900);
				
				Writer(name + ": What was that?");
				Space();
				Writer(name + ": This tingling feeling...It's unatural.");
				Thread.Sleep(700);
				Space();
				Writer(name + ": It lingers still, wanting me, waiting for me.");
				Space(2);
				Writer("It is then that you realize that you were walking down the path, right into a cave.");
				Space();
				Writer("The monster growls as you come to it, to make sure to slay it to finally rid yourself of this aweful, terrible, horrifying feeling.");
				Space();
				Thread.Sleep(300);
				Writer(".", 2);
				Thread.Sleep(150);
				Writer(".", 2);
				Thread.Sleep(150);
				Writer(".", 2);
				Thread.Sleep(900);
				Space();
				Writer("Step, ", 2);
				Thread.Sleep(300);
				Writer("Step, ");
				Thread.Sleep(300);
				Writer("Step; ", 2);
				Writer("With your sword drawn, you walk into the unkown, waiting to meet your foe.");
				Thread.Sleep(1000);
				ItemUser();
				Space(4);
				MonsterEncounter(190, 15, 15, "Thunder DRAGON", 50000F, 5000, true);//Thunder DRAGON fight
				Space(3);
				Writer("After the death of the dragon, you make your way out of the cave.");
				Space();
				Writer("The light blinding, you make your way out of the valley, and and you find yourself at the doorsetep of the city. Read to fight...");
				Space(5);
				Thread.Sleep(3000);
				Writer("THE DRAGON");
				From[1] = true;
				EndGame();
				Credits();
				End();
      } 
			
			else 
			{
        Space();
        ErrorWrite();
        Writer("Hello " + name + "! There is a dragon, and it needs to be slain!  Where shall you go to give it its deserved fate?"); //options to go first
        Space();
				Color("cyan");
        Writer(go1[0] + ", 1");
				Color("yellow");
        Writer(go1[1] + ", 2");
				Color("green");
        Writer(go1[2] + ", 3");
				Color("null");
        Space();
        option = Reader();
      }
    	}

		
	}
      

    //functions  
    

    static void Space(int spaces = 1) 
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

    static void ErrorWrite() 
		{
      Color("red");
			Writer("Remember to write exactly as it appears in terminal. Otherwise it won't work!");
      Color("null");
			Space();
    }

		static void End(int ExitCode = 0)	
		{
			System.Environment.Exit(ExitCode);  
		}

		static void Enter()
		{
			Space();
			if(firstTime[3] == true)
			{
				Writer("Press enter to continue. You also continue when you see '>'.");
				firstTime[3] = false;
			}
			else if(firstTime[3] != true)
			{
				Writer(">", 2);
			}
			if (Console.ReadKey().Key != ConsoleKey.Enter) 
			{ 

				Thread.Sleep(7000);
      } 
			Space();
		}

		static void Color(string color = "null")
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
			}
		}

		public static void Use(int potions = 200, int potions_plus = 600, int ATK_UPs = 1000, int EXP_UPs = 400, int HEARTS = 1500)
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
						Enter();
						Color("bold");
						Writer("When shopping, you should always assume that you're gonna need a lot of stuff. After all, monsters isn't always nice!");
						Enter();
						Writer("There are also many types of Items; I'll tell you about all of them!");
						Enter();
						Color("blue");
						Writer("potion: These useful tools heal 20HP when you have 20 - 39 HP, these can suffice. You can check HP in the beginning and endd of each battle!");
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
						Writer("No that you know about all the items in the shop, you can shop intelligently! just remember to Leave when you're done! See ya!");
						Enter();
						firstTime[4] = false;
					}
					Writer("CabinMaster: Great! potions, EXP UPs, hearts! It's yours, my friend! As long as you have enough GOLD!");
					while(!ond)
					{
						kend = false;
						Space();
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
						Space();
						option = Reader();
						switch(option)
						{
							case "1":
							case "1:":
							case "Potion":
							case "potion":
								if(GOLD >= potions)
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
									if(option == "yes") 
									{
										Space();
										Writer("You gained 20 HP!");
										HP += 20;
									}
									else
									{
										GOLD -= 200;
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
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "yes":
												ond = true;
											break;

											case "no":
											break;

											default:
												ErrorWrite();
											break;
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
											case "yes":
												ond = true;
												kend = true;
											break;

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

								else if(GOLD < potions)
								{
									Space();
									Writer("CabinMaster: Sorry, " + name + ", but I can't give credit!");
								}
								
							break;

							case "2":
							case "2:":
							case "Potion +":
							case "potion plus":
							case "Potion Plus":
							case "potion +":
								if(GOLD >= potions_plus)
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
									if(option == "yes") 
									{
										Space();
										Writer("You gained 60 HP!");
										HP += 60;
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
									}
									
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "yes":
												ond = true;
												kend = true;
											break;

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
								if(GOLD >= EXP_UPs)
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
									if(option == "yes") 
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
									}
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "yes":
												ond = true;
												kend = true;
											break;

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
							break;

							case "4":
							case "4:":
							case "atk up":
							case "Atk Up":
							case "ATK UP":
								if(GOLD >= ATK_UPs)
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
									if(option == "yes") 
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
									}
									while(kend == false)
									{
										Space();
										Writer("Do you want to stop shopping?");
										Space();
										option = Reader();
										switch(option)
										{
											case "yes":
												ond = true;
												kend = true;
											break;

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
							break;

							case "5":
							case "5:":
							case "Heart":
							case "heart":
								if(GOLD >= HEARTS)
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
									if(option == "yes") 
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
											case "yes":
												ond = true;
												kend = true;
											break;

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
							break;

							case "6":
							case "6:":
							case "LEAVE":
							case "leave":
							case "Leave":
								Space();
								Writer("CabinMaster: Ok! See ya!");
								ond = true;
							break;
							
							default:
								ErrorWrite();
								Space();
								Writer("CabinMaster: What would you like to do?");
								Space();
								Writer("1: Shop");
								Writer("2: Rest, G300");
								Space();
								Writer("3: Leave");
								Space();
								option = Reader();
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
		
		static string monName = "Enemy";
    static void MonsterEncounter(float hp = 10,  float speed = 3, float attack = 2, string monName = "Monster",  float exp = 200F, int gold = 30, bool boss = false, bool doubleBattle = false, bool twoEnemy = false,float hpTwo = 10,float speedTwo = 4,float attackTwo = 1,string monNameTwo = "Monster 2") 
		{
      //variables
      string[] toDo = {"Attack", "Run", "Grab", "SPECIAL"};
      string Choose;
			bool noSpecial = false;
      //monster
      Space();
      if(doubleBattle == true)
			{
				if(boss == false && twoEnemy == true)
				{
					Writer("[0;31m" + monName + " and " + monNameTwo + " is at battle with you! What shall you do?");
				}

				else if (boss == false && twoEnemy == false)
				{
					Writer("[0;31m" + monName + " is at battle with you! What shall you do?");
				}

				else if(boss == true && twoEnemy == false)
				{
					Color("pink");
					Writer("A great " + monName + " has honorably challenged you to a match! What shall you do, for your life is on the line?");
				}

				if(boss == true && twoEnemy == true)
				{
					Color("pink");
					Writer("A great " + monName + " and " + monNameTwo + " has honorably challenged you to a match! What shall you do, for your life is on the line?");
				}
			}

			else if (doubleBattle == false)
			{
				if(boss == false)
				{
					Writer("[0;31m" + monName + " and is at battle with you! What shall you do?");
				}

				if(boss == true)
				{
					Color("pink");
					Writer("A great " + monName + " has honorably challenged you to a match! What shall you do, for your life is on the line?");
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
				Writer("Wanna Attack to do damage? type 'Attack' to do some damage, or miss!");
				Enter();
				Color("blue");
				Writer("Maybe this fight ain't up for ya? Type 'Run' to try your chances at escape! You won't always succeed, though!");
				Enter();
				Color("green");
				Writer("And if you need to make a refil, your bag is always up to the task! All you have to do is type 'Grab'!");
				Enter();
				Space();
				Color("red");
				Writer("Beware, for the enemy can Attack too! And if they are faster than you, their attack will hit first, and you can die!");
				Space();
				Enter();
				Color("bold");
				Writer("That's why you should always use a combination of these three options, to keep the enemy on their toes!");
				Enter();
				Color("yellow");
				Writer("Using just one will never work.");
				Color("null");
				Enter();
				Space();
				Writer("So now, it's time to show this " + monName + " what you're made of!");
				Space(3);
				firstTime[1] = false;
			}
			//fight
			Writer("Your HP: " + HP + ", " + monName + " HP: " + hp);
			noSpecial = false;
			Color("null");
      Space();
      Color("cyan");
			Writer(toDo[3]);
			Color("pink");
			Writer(toDo[0]);
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
        fighting = HP > 0 && hp > 0;
        
				
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
								Space();
								Writer("In order to build this force, however, you need to do some ", 2);
								Color("pink");
								Writer("Atttacks!");
								Color("blue");
								Space();
								Writer("Critical hits give the most WILL, while weak hits give the least, and neutral (normal) hits give, well, a neutral amount!");
								Color("red");
								Writer("Though you should beware, for you loose WILL when a monster hits you! But you can loose less WILL when your ATK is higher!");
								Color("null");
								Space();
								Writer("Now, time for you to use your WILL!");
								firstTime[0] = false;
							}

							Space();
							Color("cyan");
							Writer("You have " + WILL + " WILL left.");
							Space();
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
											Space();
											Writer("You preformed the UPLIFTING UPPERCUT! " + monName + " was slashed up, and sliced down! dealing " + Convert.ToInt32(ATK * 1.7) + " damage!");
											hp -= Convert.ToInt32(ATK * 1.7);
											WILL -= 120;
											noSpecial = true;
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
											Space();
											Writer("You preformed the MACHSLASH! " + monName + " was slashed 100 times! dealing " + 70 + " damage!");
											WILL -= 120;
											hp -= 70;
											noSpecial = true;
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
											Space();
											Writer("You preformed the SPEED SLICE! " + monName + " was slashed through at blinding speeds, dealing " + 50 + " damage!");
											WILL -= 100;
											hp -= 50;
											noSpecial = true;
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
											Space();
											Writer("You preformed the BUSTER BEAM! " + monName + " was blasted with a sword beam made of WILL, dealing " + Convert.ToInt32(ATK * 2.5) + " damage!");
											WILL -= 40;
											hp -= Convert.ToInt32(ATK * 2.5);
											noSpecial = true;
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
											Space();
											Writer("You preformed the OMNIWEB-ULTACUTTER! " + monName + " was slashed too many times to count! Making a web formation dealing " + Convert.ToInt32(ATK * 2.5) + " damage!");
											WILL -= 220;
											hp -= Convert.ToInt32(ATK * 2.5);
											noSpecial = true;
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
										if(SPE <= 22)
										{
											Writer("But my thinking of it, you don't have the time to do something else!", 2);
										}
										else if(SPE > 22)
										{
											Space();
											Writer("What next?");
											Space();
											Color("cyan");
											Writer(toDo[3]);
											Color("pink");
											Writer(toDo[0]);
											Color("blue");
      								Writer(toDo[1]);
											Color("green");
      								Writer(toDo[2]);
											Color("null");
      								Space();
      								Choose = Reader();
											while(stop == false)
											{
													if(Choose == "Attack" || Choose == "attack")
													{
														if(HP <= 0)
														{
															Space(3);
															Writer("YOU DIED!");
															End(0);
														}

														if(hp <= 0)
														{
															continue;
														}
														//turn
														//player death check
														if(HP <= 0)
														{
														Space(3);
														Writer("YOU DIED!");
														End(0);
														}
														//player
            								Random r = new Random();
														int re = r.Next(1, 13);
														switch(re)//miss: 2(17%), weak: 2(17%), nutral: 5(42%), critical: 3(25%)
														{
															case 1: //weak
																Space();
																Color("yellow");
																Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
																Color("null");
																hp -= (int) ATK * 2/3;
																WILL += 5;
															break;
															case 2: //nutral
																Space();
																Color("green");
																Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
																Color("null");
																hp -= ATK;
																WILL += 10;
															break;
															case 3: //critical
																Space();
																Color("green");
																Writer("CRITICAL HIT!");
																Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
																Color("null");
																hp -= (int) ATK * 5/3;
																WILL += 20;
															break;
															case 4: //miss
																Space();
																Color("red");
																Writer("You missed! " + monName + " didn't get hit!");
																Color("null");
																WILL -= 10;
															break;
															case 5: //nutral
																Space();
																Color("green");
																Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
																Color("null");
																hp -= ATK;
																WILL += 10;
															break;
															case 6: //nutral
																Space();
																Color("green");
																Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
																Color("null");
																hp -= ATK;
																WILL += 10;
															break;
															case 7: //critical hit
																Space();
																Color("green");
																Writer("CRITICAL HIT!");
																Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
																Color("null");
																hp -= (int) ATK * 5/3;
																WILL += 20;
															break;
															case 8: //nutral
																Space();
																Color("green");
																Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
																Color("null");
																hp -= ATK;
																WILL += 10;
															break;
															case 9: //weak
																Space();
																Color("yellow");
																Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
																Color("null");
																hp -= (int) ATK * 2/3;
																WILL += 5;
															break;
															case 10: //nutral
																Space();
																Color("green");
																Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
																Color("null");
																hp -= ATK;
																WILL += 10;
															break;
															case 11: //miss
																Space();
																Color("red");
																Writer("You missed! " + monName + " didn't get hit!");
																Color("null");
															break;
															case 12: //critical hit
																Space();
																Color("green");
																Writer("CRITICAL HIT!");
																Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
																Color("null");
																hp -= (int) ATK * 5/3;
																WILL += 20;
															break;
														}
														//monster death check
														if(hp <= 0)
														{
														continue;
														}
															
														Space(2);
														Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
														//choosing
            								if(HP <= 0)
														{
															Space(3);
															Writer("YOU DIED!");
															End(0);
														}

														if(hp <= 0)
														{
															continue;
														}
														stop = true;
													}

													else if(Choose == "Run" || Choose == "run")
													{
														if(HP <= 0)
														{
															Space(3);
															Writer("YOU DIED!");
															End(0);
														}

														if(hp <= 0)
														{
															continue;
														}
            								//random # gen
            								Random rand = new Random(); 
            								int roller = rand.Next(1, 4);
														if(!boss && SPE >= speed)
														{
            									//logic
            									Space();
															if (roller == 3) 
															{
            								  	Writer("You ran away!");
            								  	return;
            									} else if (roller != 3) 
															{
            								  	Writer("You tried to run, But it failed!");
															}
														}
														else if(boss == true)
														{
															Writer("You can't run from a Boss Monster!");
														} 
														else
														{
															Writer("You were too slow to run from the " + monName + "!");
														}
														//end
														Space(2);
														Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
														//choose
														if(HP <= 0)
														{
															Space(3);
															Writer("YOU DIED!");
															End(0);
														}

														if(hp <= 0)
														{
															continue;
														}
														stop = true;
													}

													if(Choose == "Grab" || Choose == "grab")
													{
														ItemUser();
														stop = true;
													}	
											}
										}
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
							if(hp <= 0)
							{
							continue;
							}
							if(!dodge)
							{
								//monster
								Space();
								Color("red");
								Writer(monName + " did " + attack + " hp to you!");
								Color("null");
								HP -= attack;
								WILL -= Convert.ToInt32(attack - ATK/6);
							}

							else if(dodge == true)
							{
								Space();
								Writer("The " + monName + " did no damage, because you dodged the attack! This gives you time to use an item!");
								Color("null");
								WILL -= 10;
								dodge = false;
								Space();
								ItemUser();
							}
							//end
							Space(2);
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							//choose
							if(HP <= 0)
							{
								Space(3);
								Writer("YOU DIED!");
								End(0);
							}

							if(hp <= 0)
							{
								continue;
							}
							Space();
							Writer("What next?");
							Space();
      				Color("cyan");
							Writer(toDo[3]);
							Color("pink");
							Writer(toDo[0]);
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
							if(hp <= 0)
							{
								continue;
							}
							//monster
							Space();
							Color("red");
							Writer(monName + " did " + attack + " hp to you!");
							Color("null");
							HP -= attack;
							WILL -= Convert.ToInt32(attack - ATK/6);
							//end
							Space(2);
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							//choose
							if(HP <= 0)
							{
								Space(3);
								Writer("YOU DIED!");
								End(0);
							}
	
							if(hp <= 0)
							{
								continue;
							}

							Space();
							Writer("What next?");
							Space();
      				Color("cyan");
							Writer(toDo[3]);
							Color("pink");
							Writer(toDo[0]);
							Color("blue");
      				Writer(toDo[1]);
							Color("green");
      				Writer(toDo[2]);
							Color("null");
      				Space();
      				Choose = Reader();
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
							if(hp <= 0)
							{
								continue;
							}
							//monster
							if(dodge == true)
							{
								Space();
								Writer("The " + monName + " did no damage, because you dodged the attack! This gives you time to use an item!");
								Color("null");
								WILL -= 10;
								dodge = false;
								Space();
								ItemUser();
							}
							else if(dodge == false)
							{
								Space();
								Color("red");
								Writer(monName + " did " + attack + " hp to you!");
								Color("null");
								HP -= attack;
								WILL -= Convert.ToInt32(attack - ATK/6);
							}
							//end
							Space(2);
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							//choose
							if(HP <= 0)
							{
								Space(3);
								Writer("YOU DIED!");
								End(0);
							}
	
							if(hp <= 0)
							{
								continue;
							}

							Space();
							Writer("What next?");
							Space();
      				Color("cyan");
							Writer(toDo[3]);
							Color("pink");
							Writer(toDo[0]);
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
					case "ATK":
					case "atk":
					case "Atk":
					case "Attaack":
					case "Atttack":
					case "Atttaaack":
					case "ATtack":
					case "Attack":
            if(doubleBattle == false && twoEnemy == false)
						{
							if(HP <= 0)
							{
								Space(3);
								Writer("YOU DIED!");
								End(0);
							}

							if(hp <= 0)
							{
								continue;
							}
							//turn
            	if(SPE >= speed)//player first
							{
								//player death check
								if(HP <= 0)
								{
								Space(3);
								Writer("YOU DIED!");
								End(0);
								}
								//player
            		Random r = new Random();
								int re = r.Next(1, 13);
								switch(re)//miss: 2(17%), weak: 2(17%), nutral: 5(42%), critical: 3(25%)
								{
									case 1: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 2: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 3: //critical
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 4: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
										WILL -= 10;
									break;

									case 5: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 6: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 7: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 8: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 9: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 10: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 11: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
									break;

									case 12: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;
								}
								//monster death check
								if(hp <= 0)
								{
								continue;
								}
								//monster
								Space();
								Color("red");
								Writer(monName + " did " + attack + " hp to you!");
								Color("null");
            		HP -= attack;
								WILL -= Convert.ToInt32(attack - ATK/6);
							}
							if(SPE < speed)//monster first
							{
								//monster death check
								if(hp <= 0)
								{
								continue;
								}
								//monster
								Space();
								Color("red");
								Writer(monName + " did " + attack + " hp to you!");
								Color("null");
								HP -= attack;
								WILL -= Convert.ToInt32(attack - ATK/6);
								//player death check
								if(HP <= 0)
								{
								Space(3);
								Writer("YOU DIED!");
								End(0);
								}
								re = rando.Next(1, 13);
								//player
								switch(re)//miss: 2(17%), weak: 2(17%), nutral: 5(42%), critical: 3(25%)
								{
									case 1: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 2: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 3: //critical
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 4: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
										WILL -= 10;
									break;

									case 5: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 6: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 7: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 8: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 9: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + Convert.ToInt32(ATK * 2/3) + " hp! That was a weak hit!");
										Color("null");
										hp -= Convert.ToInt32(ATK * 2/3);
										WILL += 5;
									break;

									case 10: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 11: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
									break;

									case 12: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + Convert.ToInt32(ATK * 5/3) + " hp!");
										Color("null");
										hp -= Convert.ToInt32(ATK * 5/3);
										WILL += 20;
									break;
								}
							}
            	//end
							Space(2);
							Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
							//choosing
            	if(HP <= 0)
							{
								Space(3);
								Writer("YOU DIED!");
								End(0);
							}

							if(hp <= 0)
							{
								continue;
							}

							Space();
							Writer("What next?");
							Space();
      				Color("cyan");
							Writer(toDo[3]);
							Color("pink");
							Writer(toDo[0]);
							Color("blue");
      				Writer(toDo[1]);
							Color("green");
      				Writer(toDo[2]);
							Color("null");
      				Space();
      				Choose = Reader();
						}

						else if (doubleBattle == true && twoEnemy == false)
						{
							if(HP <= 0)
							{
								Space(3);
								Writer("YOU DIED!");
								End(0);
							}

							if(hp <= 0)
							{
								continue;
							}
							//turn
            	if(SPE >= speed && SPE >= (float)Mark[1])//player first
							{
								//player death check
								if(HP <= 0)
								{
									Space(3);
									Writer("YOU DIED!");
									End(0);
								}
								//player
            		Random r = new Random();
								int re = r.Next(1, 13);
								switch(re)//miss: 2(17%), weak: 2(17%), nutral: 5(42%), critical: 3(25%)
								{
									case 1: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 2: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 3: //critical
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 4: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
										WILL -= 10;
									break;

									case 5: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 6: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 7: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 8: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 9: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 10: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 11: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
									break;

									case 12: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;
								}
								if((float)Mark[1] > speed)
								{
									//mark death check/attack
									if((float)Mark[0] <= 0)
									{
										Space();
										Writer("Mark is beat! He can't fight!");
									}
									else if ((float)Mark[0] > 0)
									{
										Space();
										Color("green");
										Writer((string)Mark[3] + " did " + (float)Mark[2] + " damage!");
										hp -= (float)Mark[2];
									}
									//monster death check
									if(hp <= 0)
									{
										continue;
									}
									//monster
									re = rando.Next(0, 2);
									if(re == 0)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
            				HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}

									else if (re == 1)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to " + (string)Mark[3] + "!");
										Color("null");
            				(float)Mark[0] -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
								}
								else if((float)Mark[1] <= speed)
								{
									//monster death check
									if(hp <= 0)
									{
										continue;
									}
									//monster
									re = rando.Next(0, 2);
									if(re == 0)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
            				HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}

									else if (re == 1)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to " + (string)Mark[3] + "!");
										Color("null");
            				(float)Mark[0] -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
									//Mark death check/attack
									if((float)Mark[0] <= 0)
									{
										Space();
										Writer("Mark is beat! He can't fight!");
									}
									else if ((float)Mark[0] > 0)
									{
										Space();
										Color("green");
										Writer((string)Mark[3] + " did " + (float)Mark[2] + " damage!");
										hp -= (float)Mark[2];
									}
								}
							}
							if(SPE >= speed && SPE < (float)Mark[1])//mark first
							{
								//Mark death check/attack
								if((float)Mark[0] <= 0)
								{
									Space();
									Writer("Mark is beat! He can't fight!");
								}
								else if ((float)Mark[0] > 0)
								{
									Space();
									Color("green");
									Writer((string)Mark[3] + " did " + (float)Mark[2] + " damage!");
									hp -= (float)Mark[2];
								}
								//player death check
								if(HP <= 0)
								{
								Space(3);
								Writer("YOU DIED!");
								End(0);
								}
								//player
            		Random r = new Random();
								int re = r.Next(1, 13);
								switch(re)//miss: 2(17%), weak: 2(17%), nutral: 5(42%), critical: 3(25%)
								{
									case 1: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 2: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 3: //critical
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 4: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
										WILL -= 10;
									break;

									case 5: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 6: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 7: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 8: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 9: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 10: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 11: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
									break;

									case 12: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;
								}
								//monster death check
								if(hp <= 0)
								{
									continue;
								}
								//monster
								re = rando.Next(0, 2);
								if(re == 0)
								{
									Space();
									Color("red");
									Writer(monName + " did " + attack + " hp to you!");
									Color("null");
            			HP -= attack;
									WILL -= Convert.ToInt32(attack - ATK/6);
								}
								else if (re == 1)
								{
									Space();
									Color("red");
									Writer(monName + " did " + attack + " hp to " + (string)Mark[3] + "!");
									Color("null");
            			(float)Mark[0] -= attack;
									WILL -= Convert.ToInt32(attack - ATK/6);
								}
							}
							if(SPE < speed && SPE >= (float)Mark[1])//monster first, mark last
							{
								//monster death check
									if(hp <= 0)
									{
										continue;
									}
									//monster
									re = rando.Next(0, 2);
									if(re == 0)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
            				HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}

									else if (re == 1)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to " + Mark[3] + "!");
										Color("null");
            				(float)Mark[0] -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
								//player death check
								if(HP <= 0)
								{
								Space(3);
								Writer("YOU DIED!");
								End(0);
								}
								re = rando.Next(1, 13);
								//player
								switch(re)//miss: 2(17%), weak: 2(17%), nutral: 5(42%), critical: 3(25%)
								{
									case 1: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 2: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 3: //critical
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 4: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
										WILL -= 10;
									break;

									case 5: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 6: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 7: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 8: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 9: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + Convert.ToInt32(ATK * 2/3) + " hp! That was a weak hit!");
										Color("null");
										hp -= Convert.ToInt32(ATK * 2/3);
										WILL += 5;
									break;

									case 10: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 11: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
									break;

									case 12: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + Convert.ToInt32(ATK * 5/3) + " hp!");
										Color("null");
										hp -= Convert.ToInt32(ATK * 5/3);
										WILL += 20;
									break;
								}
								//Mark death check/attack
								if((float)Mark[0] <= 0)
								{
									Space();
									Writer("Mark is beat! He can't fight!");
								}
								else if ((float)Mark[0] > 0)
								{
									Space();
									Color("green");
									Writer(Mark[3] + " did " + Mark[2] + " damage!");
									hp -= Mark[2];
								}
							}
							if(SPE < speed && SPE < (float)Mark[1])//player last
							{
								if((float)Mark[1] > speed)
								{
									//mark death check/attack
									if((float)Mark[0] <= 0)
									{
										Space();
										Writer("Mark is beat! He can't fight!");
									}
									else if ((float)Mark[0] > 0)
									{
										Space();
										Color("green");
										Writer((string)Mark[3] + " did " + (float)Mark[2] + " damage!");
										hp -= Mark[2];
									}
									//monster death check
									if(hp <= 0)
									{
										continue;
									}
									//monster
									re = rando.Next(0, 2);
									if(re == 0)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
            				HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}

									else if (re == 1)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to " + Mark[3] + "!");
										Color("null");
            				Mark[0] -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
								}

								else if(Mark[1] <= speed)
								{
									//monster death check
									if(hp <= 0)
									{
										continue;
									}
									//monster
									re = rando.Next(0, 2);
									if(re == 0)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to you!");
										Color("null");
            				HP -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}

									else if (re == 1)
									{
										Space();
										Color("red");
										Writer(monName + " did " + attack + " hp to " + (string)Mark[3] + "!");
										Color("null");
            				(float)Mark[0] -= attack;
										WILL -= Convert.ToInt32(attack - ATK/6);
									}
									//Mark death check/attack
									if((float)Mark[0] <= 0)
									{
										Space();
										Writer("Mark is beat! He can't fight!");
									}
									else if (Mark[0] > 0)
									{
										Space();
										Color("green");
										Writer((string)Mark[3] + " did " + Mark[2] + " damage!");
										hp -= (float)Mark[2];
									}
								}

								//player death check
								if(HP <= 0)
								{
									Space(3);
									Writer("YOU DIED!");
									End(0);
								}
								//player
            		Random r = new Random();
								int re = r.Next(1, 13);
								switch(re)//miss: 2(17%), weak: 2(17%), nutral: 5(42%), critical: 3(25%)
								{
									case 1: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 2: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 3: //critical
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 4: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
										WILL -= 10;
									break;

									case 5: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 6: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 7: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;

									case 8: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 9: //weak
										Space();
										Color("yellow");
										Writer("You chose attack! " + monName + " lost " + (int) ATK * 2/3 + " hp! That was a weak hit!");
										Color("null");
										hp -= (int) ATK * 2/3;
										WILL += 5;
									break;

									case 10: //nutral
										Space();
										Color("green");
										Writer("You chose attack! " + monName + " lost " + ATK + " hp!");
										Color("null");
										hp -= ATK;
										WILL += 10;
									break;

									case 11: //miss
										Space();
										Color("red");
										Writer("You missed! " + monName + " didn't get hit!");
										Color("null");
									break;

									case 12: //critical hit
										Space();
										Color("green");
										Writer("CRITICAL HIT!");
										Writer(monName + " lost " + (int) ATK * 5/3 + " hp!");
										Color("null");
										hp -= (int) ATK * 5/3;
										WILL += 20;
									break;
								}
							}
            	//end
							Space(2);
							Writer("You have " + HP + " HP, " + monName + " has " + hp + " HP, and " + Mark[3] + " has " + Mark[0] + " HP.");
							//choosing
            	if(HP <= 0)
							{
								Space(3);
								Writer("YOU DIED!");
								End(0);
							}

							if(hp <= 0)
							{
								continue;
							}

							Space();
							Writer("What next?");
							Space();
      				Color("cyan");
							Writer(toDo[3]);
							Color("pink");
							Writer(toDo[0]);
							Color("blue");
      				Writer(toDo[1]);
							Color("green");
      				Writer(toDo[2]);
							Color("null");
      				Space();
      				Choose = Reader();
						}
          break;

          case "3":
					case "run":
					case "Run":
						if(HP <= 0)
						{
							Space(3);
							Writer("YOU DIED!");
							End(0);
						}
						
						if(hp <= 0)
						{
							continue;
						}
            //random # gen
            Random randa = new Random(); 
            int rollea = randa.Next(1, 4);
						if(!boss && SPE >= speed)
						{
            	//logic
            	Space();
							if (rollea == 3) 
							{
              	Writer("You ran away!");
              	return;
            	} else if (rollea != 3) 
							{
              	Writer("You tried to run, But it failed!");
							}
						}
						else if(boss == true)
						{
							Writer("You can't run from a Boss Monster!");
						} 
						else
						{
							Writer("You were too slow to run from the " + monName + "!");
						}
					
            //monster
            Space();
						Color("red");
						Writer(monName + " did " + attack + " hp to you!");
						Color("null");
						HP -= attack;
						//end
						Space(2);
						Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
						//choose
						if(HP <= 0)
						{
							Space(3);
							Writer("YOU DIED!");
							End(0);
						}
						
						if(hp <= 0)
						{
							continue;
						}

            Space();
						Writer("What next?");
						Space();
      			Color("cyan");
						Writer(toDo[3]);
						Color("pink");
						Writer(toDo[0]);
						Color("blue");
      			Writer(toDo[1]);
						Color("green");
      			Writer(toDo[2]);
						Color("null");
      			Space();
      			Choose = Reader();
          break;

          case "4":
					case "grab":
					case "Grab":
            if(HP <= 0)
						{
							Space(3);
							Writer("YOU DIED!");
							End(0);
						}
						if(hp <= 0)
						{
							continue;
						}
						//tutorial
						if(firstTime[1] == true)
						{
							Color("green");
							Space();
							Writer("Time to grab something from your bag!");
							Writer("When you grab, you get something from the 10 slots in your bag.");
							Enter();
							Writer("Each slot in your bag is marked with a number from 0-9. Type the corrisponding number to use that Item!");
							Writer("now you know all about grabbing!");
							Enter();
							firstTime[1] = false;
							Color("null");
						}

						//Logic
            Space();
						bool ender = false;
						while(!ender)
						{
							Writer("What do you want to grab? (0-9)");
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
							Space();
							option = Reader();
							Space();
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
												HP = HEARTS + 10;
											}

											inventory[0] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[0] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[0] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[0] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[1] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[1] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[1] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[1] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[2] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[2] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[2] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[2] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[2] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[3] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[3] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[3] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[3] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[3] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[4] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[4] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[4] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[4] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[4] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[5] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[5] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[5] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[5] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[5] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[6] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[6] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[6] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[6] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[6] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[7] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[7] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[7] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[7] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[7] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[8] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[8] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[8] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[8] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[8] = "null";
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
												HP = HEARTS + 10;
											}

											inventory[9] = "null";
										break;
										
										case "heart":
											Space();
											Writer("You gained 5 HP!");
											HEARTS += 5;
											HP += 5;

											inventory[9] = "null";
										break;

										case "ATK UP":
											Space();
											Writer("You buffed up! ATK increased!");
											ATK += 5;
											
											inventory[9] = "null";
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}

											inventory[9] = "null";
										break;

										case "potion +":
											Space();
											Writer("You recieved 60 HP!");
											HP += 60;
											if(HP > HEARTS + 10)
											{
												HP = HEARTS;
											}

											inventory[9] = "null";
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
								break;

								default:
									ErrorWrite();
								break;
							}
						}
            //monster
            Space();
            Color("red");
						Writer(monName + " did " + attack + " hp to you!");
						Color("null");
						HP -= attack;
            //end
						Space(2);
						Writer("You have " + HP + " HP and " + monName + " has " + hp + " HP");
						//choose
						if(HP <= 0)
						{
							Space(3);
							Writer("YOU DIED!");
							End(0);
						}
						if(hp <= 0)
						{
							continue;
						}
						Space();
						Writer("What next?");
						Space();
      			Color("cyan");
						Writer(toDo[3]);
						Color("pink");
						Writer(toDo[0]);
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
            Writer("What next?");
            Space();
						Color("cyan");
						Writer(toDo[3]);
            Color("pink");
						Writer(toDo[0]);
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
      if (hp <= 0) 
			{
				Space();
				Writer("[0;36m" + monName + " was defeated! You can move on!");
				Writer("[0;0m");
				noSpecial = false;
				//GOLD system
				GOLD += gold;
				Space();
				Writer("[0;33m You gained " + gold + " gold!");
				Space();
				Writer("You now have " + GOLD + " gold!");
				//EXP system
        Space();
        EXP += exp;
				Color("pink");
				Writer("You gained " + exp + " EXP!");
        while(EXP >= EXPNeed)
				{
          Space();
					Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
					
					HEARTS = HEARTS + 2;
					HP = HEARTS + 2;
          ATK = ATK + 3;
					SPE++;
          level++;
          EXP -= EXPNeed;
					EXPNeed += 1000;

					ItemGet();
        }
				//STATS and EXP
				Space();
				Writer("STATS: Max HP: " + HEARTS + ", HP: " + HP + ", ATK: " + ATK + ", SPE: " + SPE);
				Space();
				Color("blue");
				Writer("You need " + EXPNeed + " EXP to level up. You have " + EXP + " EXP.");
				//Inventory System
        Space();
				Color("green");
				Writer("Do you want to use a item?");
				Space();
				string sption = Reader();
				Space();
				//Logic
				bool end = false;
				while(end == false)
				{
					switch(sption)
					{
						case "1":
						case "YES":
						case "Yes":
						case "yes":
							Writer("Which item? (0 - 10)");
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
											Writer("You ecieved 20 HP!");
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
											Writer("[0;35m You gained " + 1500 + " EXP!");
        							//EXP logic
											while(EXP >= EXPNeed)
											{
          							Space();
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;
												Writer("[1;32m");
												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
        							}
											Writer("[0;0m");
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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

										default:
											ErrorWrite();
										break;
									}
								break;
							}
						
						end = true;
						break;

						case "2":
						case "NO":
						case "No":
						case "no":
							end = true;
						break;

						default:
							ErrorWrite();
							Color("green");
							Space();
							Writer("yes");
							Writer("no");
							Space();
							sption = Reader();
							Space();
						break;
					}
				}
				//Item System
				Color("null");
				ItemGet();
				//End
      }
    }
		
	 static void ItemUser()
		{
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
							Writer("Which item? (0 - 10)");
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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
												Writer("You leveled up to level " + level + "! + 3 ATK, +1 SPE,+ 2 Max HP!");
												
												HEARTS = HEARTS + 2;
												HP = HEARTS + 2;
          							ATK = ATK + 3;
												SPE++;
          							level++;
          							EXP -= EXPNeed;
												EXPNeed += 1000;

												Space();
												Writer("STATS: HP: " + HEARTS + ", ATK: " + ATK);
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

										default:
											ErrorWrite();
										break;
									}
								break;
							}
						
						end = true;
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
	 
	 
	 static void ItemGet()
		{
			//Item system
        Random rande = new Random(); 
        int roller = rande.Next(1, 5);
        //Logic
        Space();
				if (roller == 3 || roller == 4) 
				{
          roller = rande.Next(1, 7);
					switch(roller)
					{
						case 1:
							if (HEARTS < 30)
							{
								Writer("The " + monName + " dropped a potion!");
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
							}

							if(HEARTS >= 30)
							{
								Writer("The " + monName + " dropped a potion +!");
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
							}
						break;

						case 2:
							Writer("The " + monName + " dropped a ATK UP!");
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
						break;

						case 3:
							Writer("The " + monName + " dropped a EXP UP!");
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
						break;

						case 4:
							if(HEARTS >= 30)
							{
								Writer("The " + monName + " dropped a potion +!");
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
							}
						break;

						case 5:
							if(HEARTS < 30)
							{
								Writer("The " + monName + " dropped a potion!");
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
							}
							
							if(HEARTS >= 30)
							{
								Writer("The " + monName +  " dropped a potion +!");
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
							}
						break;

						case 6:
						break;

						default:
							Space(3);
							Writer("ERROR: THERE IS A PROBLEM IN THE RANDE.NEXT GENERATION CODE (LINE: 1743)");
						break;
					}
          return;
        } 
    }
		
		static void Writer(string write, int type = 1)
		{
			if(type == 1)
			{
				Console.WriteLine(write);
			}

			else if(type == 2)
			{
				Console.Write(write, 2);
			}

			else
			{
				type = 1;
			}
		}

		static void ThrDot()
		{
			Thread.Sleep(900);
			Writer(".", 2);
			Thread.Sleep(400);
			Writer(".", 2);
			Thread.Sleep(400);
			Writer(".", 2);
			Thread.Sleep(900);
		}

		static string Reader()
		{
			if(firstTime[2] == true)
			{
				Space();
				Writer("It's time for you to do some options!");
				Enter();
				Writer("When doing options, it is integral for you to type it exactly as it appears, otherwise it may not work!");
				Enter();
				Writer("The options may be typing what is says, or it may be typing numbers. What option it is, it will tell you!");
				Enter();
				Color("bold");
				Writer("Now go out there, and choose your life away!");
				Writer("(You might want to press enter to see the options again!)");
				Color("null");
				firstTime[2] = false;
			}
			return Console.ReadLine();
		}

		static void EndGame()
		{

		}

		static void Credits()
		{
			string[] producers = {"SilverAtom", "DaRubyMiner360"};
			Space(5);
			Console.Clear();
			Color("bold");
			Writer("CREDITS");
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Color("blue");
			Writer("Producer: " + producers[0]);
			Color("null");
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Color("red");
			Writer("Coding Assistance: " + producers[1]);
			Color("null");
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(150);
			Space();
			Thread.Sleep(3000);
			Space();
			Color("pink");
			Writer("THE END");
		}
	}
}
