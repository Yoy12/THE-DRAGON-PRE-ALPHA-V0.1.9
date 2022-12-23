using System;
using System.IO;
using System.Threading;
using System.Windows.Input;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
// 
// https://bluesock.org/~willkg/dev/ansi.html#ansicodes
// RED: [0;31m
// RESET: [0m

// NOTE: After DRAGON, player is at level 12 and has about 42 HP and 54 - 64 ATK, so 250 hp and 8 attack is necessary. Give them unique quirks (status effects, moves, etc.) to keep them interesting.

// NOTE: Easy Enemy: 1 - 60HP, Medium Enemy: 61 - 90HP, Hard Enemy: 91 - 190HP, MiniBoss - 191+ HP.
// NOTE: In EndGame, Easy Enemy: 1 - 120HP, Medium Enemy: 121 - 300HP, Hard Enemy: 301 - 450HP, MiniBoss - 451+ HP.

// All copyright© of SilverAtom. All rights reserved.

namespace DRAGONLake
{
	public static partial class Functions
  	{
		static void Main(string[] args) 
		{
			if(debug == true) {
			
				// new System.Media.SoundPlayer(Path.GetDirectoryName (Assembly.GetExecutingAssembly().Location) + @"\Royager.mp3").Play();
			}
			if(debug == false)
			{
				Console.Clear();
			}
			Space(6);
			if(new FileInfo("SaveData.dat").Length == 0 && new FileInfo("SaveData2.dat").Length != 0)
			{
				CertainSerialSave();
				CertainSerial();
			}
			if(new FileInfo("SaveData2.dat").Length == 0)
			{
				CertainSerialSave();
				CertainSerial();
			}
			else
			{
				CertainSerial();
			}
			//ALL of the game
			Color("purple");
			Writer("THE DRAGON (V0.1.9 " + SetColor("cyan") + "PRE-ALPHA " + SetColor("red") + "UNSTABLE" + SetColor("purple") + ")");
			Writer("START");
			Space(2);

			while(true)
			{
				CertainSerial();
				if(hasStarted == true)
				{
					Writer("SELECT YOUR ADVENTURE (1 - 2).");
					Space();
					Writer("CONTINUE, 1");
					Writer("NEW GAME, 2");
				}
				else
				{
					Writer("SELECT OPTION BY TYPING 1.");
					Space();
					Writer("NEW GAME, 1");
				}
				Space();
				string Chose = Console.ReadLine();
				Color();
				while(true)	
				{
					if(((Chose == "1" && hasStarted == true) || (Chose == "2" && goAnyway == true)) && name.Replace(" ", "") != "fuck")
					{
						Space();
						while(name.Replace(" ", "") != "fuck")
						{
							Read();
							if(ending[0] == false)
							{
								switch(Choose)
								{
									//if (option == go1[0] || option == "Spring" || option == "1" || option == "spring" || option == "spring, 1")//spring
									case "springs":
									case "Springs":
									case "Spring":
									case "1":
									case "spring":
									case "springs, 1":
									case "spring, 1":
										if(newgame)
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
											stop = false;
											while(stop != true)
											{
												switch(option)
												{
													case "yes":
													case "Yes":
													case "YES":
													case "1":
														stop = true;
														Color();
													break;

													case "no":
													case "No": 
													case "NO":
													case "2":
														End();
													break;

													default:
														Space();
														ErrorWrite();
														Color("bold");
														Writer("yes");
														Writer("no");
														Space();
														option = Reader();
													break;
												}
											}
											HEARTS -= 2;
											HP -= 2;
											SPE -= 2;
											ATK -= 2;
											Space();
											if(name.Replace(" ", "") != "Saver")
											{
												area = 1;
											}
											newgame = false;
											hasStarted = true;
											CertainSerial();
											Save();
										}
										switch(area)
										{
											case 0:
											case 1:
												//swamp springs
												Writer("Adventuring from your obligatory starting position, you enter the once beutiful Mount Chaudflamm Springs.");
												Enter();
												Writer("100's of years ago, they were the worshipping place of the French people, and gave then the confidence and 'power' needed to defeat the British.");
												Enter();
												Writer("Now this place looks more like a swamp.");
												Enter();
												Writer("And now, of course, MONSTER ENCOUNTER.");
												Enter();
												MonsterEncounter(17, 3, 4, "Mossatle", 1500F, 140, false, useClass: true, monster: n000);
												Space();
												Writer("The springs, infested after centuries of neglect, are crawling with monsters.");
												Enter();
												MonsterEncounter(24, 4, 3, "Shellatty", 700F, 120, false, weight: new int[] {-5, 4, 2, -5}, useClass: true, monster: n001);
												Space();
												Writer("Each more deadly than the last.");
												Enter();
												MonsterEncounter(1, 17, 18, "Kamakasemite", 1100F, 0, false, useClass: true, monster: n002);
												Space();
												Writer(name + ": Why am I even here...", 3);
												Enter();
												Writer("Zabuzabuzabuzabuza: Hey you! Time to die!", 3);
												Enter();
												Writer(name + ": no.", 3);
												Enter();
												MonsterEncounter(30, 7, 5, "Zabuzabuzabuzabuza", 1200F, 500, true, hasPattern: true, hasWeight: false, pattern: new int[] {1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 0}, powerAttackHit: 10, waitTime: 2, useClass: true, monster: n003);
												Space();
												area = 2;
												Save();
											break;

											case 2:
												//Duelsville
												Enter();
												Save();
												Console.Clear();
												Space(3);
												Writer("You finally get out of the swamp-like springs, and travel into a town full of swordsman.");
												Enter();
												Writer("The town is dessamated, swords litter the battlefield of a village. Bystanders seem to have been turned into shishcababs, their chest sticking up from the spears that trust trough them.");
												Enter();
												Writer("And a swordsman sees you.");
												Enter();
												MonsterEncounter(32, (int) 18, (int) 6, "Goronical Swordsman", (int) EXPNeed/3, 490, true, useClass: true, monster: n005);
												Space();
												Writer("After the duel, you trot through the broken town, with other swordsman having duels of their own — deadly duels.");
												Enter();
												Writer("Swordsman: Hey! You're not going to the DRAGON, right?!");					
												Enter();
												Writer(name + ": Yeah. Why?", 3);
												Enter();
												Color("bold");
												Writer("Swordsman: D I E .", 3);
												Color();
												Enter();
												MonsterEncounter(38, (int) 21, 4, "Duel Swordsman", (int) EXPNeed/3, 540, true, useClass: true, monster: n006);
												stop = true;		

												Space();
												Writer("After the swordsman, you keep through the area, when you come across a traveling CabinMaster.");
												Enter();
												Writer("CabinMaster: Sup! Want to buy something? I'm having a sale!", 3);
												Space();
												Writer(name + ": No.", 3);
												Enter();
												Writer("CabinMaster: Look, man. I'm running on low here. barely have enough to eat! I'll give you half off if you buy from me. Heck, I'll throw in an extra for each purchase. Please man, help a guy out here.", 3);
												Enter();
												Writer(name + ": No-", 3);
												Thread.Sleep(400);
												Space();
												Writer("Just then, a swordsman came in for a fight!");
												Enter();
												MonsterEncounter(32, 16, 6, "Guy the Swordsman", (int) EXPNeed/3, 700, true, useClass: true, monster: n007);
												Space();
												Writer("CabinMaster: Phew! Thanks man! Here's some GOLD for your troubles.", 3);
												Space();
												Writer("You got 20 GOLD!");
												GOLD += 20;
												Enter();
												Writer(name + ": This isn't jack squat! Cheapscape!", 3);
												Space();
												Writer("CabinMaster: I told you, I'm running on empty. Now, are you going to shop or what?", 4);
												Color("red");
												Writer(" If I were you, I would buy my bag full! The enemies outside the town are strong and fierce! And there isn't a shop for some while!", 4);
												Color("null");
												Space();
												//Logic
												Space();
												Use(492, 897, 2145, 1324, 234);
												//rest
												Space();
												Writer("After you encountered the cheapscape, you continue on your path through duel town, destroying too many foes after too many foes.");
												MonsterEncounter((int) HEARTS/2, (int) SPE/3, (int) ATK/4, "Jujutsu Guysen", (int) EXPNeed/3, (int) GOLD/2, true, useClass: true, monster: n008);
												Space();
												MonsterEncounter(HEARTS * 2, (int) SPE, (int) ATK/2, "Madara Uchairha", (int) EXPNeed/3, (int) GOLD/2, true, useClass: true, monster: n009);
												Space();
												MonsterEncounter((int) HEARTS, (int) SPE, (int) ATK/2, "Lumpy", (int) EXPNeed/3, (int) GOLD/5, true, useClass: true, monster: n010);
												Space();
												MonsterEncounter((int) HEARTS/2, (int) SPE/2, (int) ATK/2, "Keyrito", (int) EXPNeed/3, (int) GOLD/3, true, useClass: true, monster: n011);
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
												Writer("Swordsman: YEAH. WOO-HOO! THIS is what I like in a swordsman!", 3);
												Enter();
												Writer(name + ": ...", 3);
												Enter();
												Writer("Swordsman: Now! It's time to pick up the " + SetColor("bold") + "HEAT!!", 3);
												Enter();
												Color();
												Writer("Swordsman: But first, I want a fair match! Heal up!", 3);
												Space();
												Writer("You where healed to Max HP!");
												HP = HEARTS;
												Enter();
												Color("bold");
												Writer("Swordsman: Now, time to get this party started! It's time for a DEATH DUEL!!!", 3);
												Enter();
												MonsterEncounter(75, 18, 12, "Mysterious Rowdy Swordsman", 4500, 3000, true, useClass: true, monster: n012);
												Writer(name + ": *huff* *puff*", 3);
												Thread.Sleep(600);
												Space();
												Writer("Swordsman: *Huff* *Puff*", 3);
												Enter();
												Writer("Swordsman: I've never been beaten before...Wow! You really are amazing with thay big sword of yours! I have always been looking for a challenge since I became a swordsman, but I have never been able to find one.", 3);
												Enter();
												Writer("Swordsman: No matter where I looked; other swordsman, colleuges from my academy, my sensei, or even monsters couldn't handle my blade. But you...you showed be something that Rhonido Sensei always told me...", 3);
												Enter();
												Writer("Swordsman: That everyone has a superior in their skill. And that it is important that we listen and respect them!", 3);
												Enter();
												ThrDot();
												Writer("Swordsman: I'm not going to do that to you though!", 4);
												Space();
												ThrDot();
												Writer(name + ": bruh.", 3);
												Enter();
												Writer("Mark: Anyway, my name's Mark, and I'll see you again!", 3);
												Enter();
												area = 3;
												Save();
											break;

											case 3:
												Save();
												Console.Clear();
												Writer("After your jolly but painful meeting, you finally leave the duel-torn village. In its wake, you crumble on the path to the DRAGON, killing many, many, many things that are unlcuky enough to be in traveling way.");
												Enter();
												MonsterEncounter(90, 21, 8, "Bunillaby", 234, 700, false, useClass: true, monster: n013);
												Space();
												MonsterEncounter(85, 19, 9, "Fuzilite", 786, 903, false, useClass: true, monster: n014);
												Space();
												Writer("You keep treking on, the monsters stronger than ever. You push and push, knowing at any moment, a monster could spell your doom.");
												Enter();
												Writer("But you can't let that happen, for you have a goal in mind.");
												Enter();
												MonsterEncounter(84, 8, 7, "Talus Large", 4534, 880, false, useClass: true, monster: n015);
												Space();
												Writer("On the makeshift road to the next stop, you are stopped by a massive bunny-monster. It doesn't seem happy about you killing its child.");
												Space();
												MonsterEncounter(300, 40, 20, "Bunnifierce", 9000F, 200, true, useClass: true, monster: n016);
												//Cabin
												if(noCabin == false)
												{
													Writer("You find a cabin on the path, and in need of some well deserved rest, you go in.");
													Enter();
													Writer("CabinMaster: Welcome! You are the 1,000,000th customer! Congradulations! I shall give you 1% off everything as a reward for coming to this amazing cabin which has had 999,999 customers before you! Enjoy your generous sale that comes from luck!", 3);
													Enter();
													Writer(name + ": 1% off? Greedy critz!", 3);
													Enter();
													Writer("CabinMaster: Buisiness is a hard thing, you know. Now, what will you do here?", 3);
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
																Writer("CabinMaster: Good afternoon! You had a nice, long sleep didn't you? Our beds are top quality, you know!", 3);
																Enter();
																Writer(name + ": ...", 3);
																Enter();
															break;

															case "1":
															case "SHOP":
															case "shop":
															case "Shop":
																Space();
																Use(198, 594, 990, 396, 1485);
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
															break;
														}
													}
												}

												else if(noCabin == true)
												{
													Writer("You had seen a Cabin, but it says: ", 2);
													Color("red");
													Writer("YOU ARE NOT WELCOME, " + name + ".");
													Space();
													Writer("No cabins 4 u!");
												}
												Enter();
												area = 4;
												Save();
											break;

											case 4:
												//Mark encounter/Savanna
												Save();
												Console.Clear();
												Space(2);
												Writer("After the town, You are forced to trek around halfway up Mount Chaudflamm due to the tretcherous geography making rest impossible to travel through the magmic surfaces and onslaught of powerful enemies.");
												Enter();
												Writer("Entering the heights of the volcano, you stumble apon a familiar face ― unbeknownst to you.");
												Enter();
												Color("bold");
												Writer("KABLAM!!!");
												Enter();
												Writer("CLING, CHABLING, BAM, BOOM, CLANK!!!");
												Color("null");
												Enter();
												Writer("Mark: Now THIS is battling! Yeah! WHOO! Alright!", 3);
												Writer("You keep yourself on your toes as the precipice is obliterated by the slashing of mighty swords.");
												Color("null");
												Enter();
												Writer("Struggling to keep up, you manage to push him back.");
												Enter();
												Writer("Mark: 1, 2, 3, 4; I declare a Duel War!", 4);
												Thread.Sleep(600);
												Color("bold");
												Writer(" Mark: 5, 6, 7, 8; Time to put the score straight!", 4);
												Color();
												Space();
												MonsterEncounter(140, 23, 18, SetColor("green") + "Mark Conjure" + SetColor("pre2"), 9000F, 4000, true, weight: new int[] {2, 3, 1, -3}, powerAttackHit: 30, powerAttack: "Chain Slicer", useClass: true, monster: n017);
												Space();
												Writer("Mark: *Huff* puff* *Huff* *puff*...You're...*huff* *puff*...good at this...*huff* *puff*", 3);
												Enter();
												Writer("Mark: I thought...catching you by suprise...would be your downfall...but even when I'm smart I...I don't even win!", 3);
												Writer("Mark: You truly are amazing...By the way...what's your name?", 3);
												Enter();
												Writer(name + ": My name ", 4);
												Thread.Sleep(1200);
												Writer("is " + name + ".", 4);
												Space();
												Enter();
												Writer("Mark: " + name + ", huh? Nice name. Well, see ya!");
												Writer("After that, he jumps away, soon far into the mountain peak.", 3);
												Enter();
												//rest
												Writer("After the yet again brief encounter, you go through this heated and tempestuous region; encounters with irate and foul-mouthed swordsman on the path to the DRAGON more common, as this is the quickest route besides the firey pits below. Which makes is even more ", 2);
												Color("red");
												Writer("dangorous.", 2);
												Color("null");
												Space();
												Enter();
												MonsterEncounter(90, 20, 9, "Macro Man", 2200F, 1300, false, false, true, 110, 25, 5, "Pet Rockalike Large", weight: new int[] {3, 5, 2, -5}, powerAttack: "900 Clicker Catastrophe", powerAttackHit: 12,waitTime: 0, hasPatternTwo: true, patternTwo: new int[] {1, 1, 1, 2, 1, 1, 1, 2, 1, 2});
												Space();
												Writer("As you go up the steap and charred surfaces of the active volcano, you notice the running magma escaping the massive volcano. You sweat bullets as it seems the higher you go, the hotter it gets.");
												Enter();
												MonsterEncounter(112, 15, 7, "Talus Large", 1200F, 440, hasPattern: true, pattern: new int[] {1, 2, 1, 2, 1, 2, 1, 2, 1, 2});
												Space();
												Writer("You head up, wishing you had deodorant, and-");
												Enter();
												Color("bold");
												Writer("T H U M P!!!");
												Enter();
												MonsterEncounter(120, 8, 8, "Rockalike", 1100F, 290, true, hasPattern: true, pattern: new int[] {2, 2, 1, 1, 2, 2, 1, 1, 2, 0});
												Space();
												Writer("Rockalike: G a U gH!! W hY dOe DiSs HaPpEn O mE ?/? I fE eL iKe CrA p 1 WhY/? WH YYY Y?!?1/", 3);
												Enter();
												Writer("Rockalike: i H A TE wHeN tHIs hApP enS..> M aN...", 3);
												Enter();
												Writer(name + ": It TALKS?!", 3);
												Enter();
												Writer("Rockalike: WeL lL Ye A!1 ByE, B id c!", 3);
												Enter();
												Writer("After cursing at you, it rolles away as you stay confounded on how a monster talked.");
												Enter();
												MonsterEncounter(78, 24, 12, "Dare Demon", 2000F, 470, false, weight: new int[] {5, 5, -5, -5}, powerAttack: "Stride, Ride, and Destroy", powerAttackHit: 18, waitTime: 3);
												Space();
												Writer("You keep trecking to the top, making sure nothing obstructing your path stays for long; all with a healthy amount of teenage angst.");
												Enter();
												MonsterEncounter(100, 28, 6, "Monster Whipper Brock", 1400F, 2700, true, false, true, 122, 14, 9, "Mad Mon \"John\" the Talus Massive", hasPatternTwo: true, patternTwo: new int[] {1, 1, 1, 2, 1, 1, 1, 2, 1, 2});
												Space();
												area = 16;
												Save();
											break;

											case 16:
												//Plavadactyl Barrage arc
												Writer("As you slowly make it up the heated volcano, it seems everything around you get shrouded in mist. As you hike your way to the top, it's as if the heat's going to melt you.");
												Enter();
												Writer("Each step up the bellowing heats made your feet dance with pain, and sometimes you almost fell into the abyss of fear and danger below");
												Enter();
												MonsterEncounter(useClass: true, monster: n023);
												Space();
												Writer("New and more powerful enemies are tougher and stroger due to the heat shaping them to be rugged and harsh.");
												Enter();
												Writer("You have to be stronger than them in order to survive.");
												MonsterEncounter(useClass: true, monster: n024);
												Space();
												Writer("As you climb the mountains, less and less people are present, and more hostile enviornments come to light.");
												Enter();
												Writer("The heat of the magma dehydrates you, but you have no choice but to push on.");
												Enter();
												Writer("Halfway up to the peaks of the periless volcano, more monsters come to you for a meal.");
												Enter();
												MonsterEncounter(useClass: true, monster: n025);
												Space();
												Enter();
												MonsterEncounter(useClass: true, monster: n026);
												Space();
												Writer("Pushing on, Plavadactyls savvy you for a treat. Outrunning them is useless, for their large, boiling wings allow them to outspeed a bus.");
												Enter();
												Writer("You try to swatt them away, but only more come.");
												Enter();
												MonsterEncounter(useClass: true, monster: n027);
												Space();
												Writer("Fighting the Plavadactyls attracted more, even more lava pumped into their ravid hot veins.");
												Enter();
												Writer("You can't escape.");
												Enter();
												MonsterEncounter(useClass: true, monster: n028);
												Space();
												Writer("The Plavadactyls surround you, their body temperature making you dizzy, they try and score hits on you.");
												Enter();
												Writer("You dodge.");
												Enter();
												Writer("You dodge.");
												Enter();
												Writer("You get hit, your red blood mixing with the basalt, limestone, and sand beneath you.");
												Enter();
												Writer("You get hit again, falling to the ground from the force of a Plavadactyls quick, sharp talons.");
												Enter();
												Writer("A third tries to get a hit, but you catch its boiling foot, and throw the young Plavadactyl to the ground.");
												Enter();
												Writer("Screething as if chastizing your insulence, you pick up your greatblade to teach the lava monsters a lesson, as the Pteradactyl likewise is accompanied by one large and bulky of its kind.");
												Enter();
												MonsterEncounter(useClass: true, monster: n029);
												Space();
												Writer("The Plavadactyls are furious now, causing an uproar as you finish the pair. Soon, your hair starts to uplift.");
												Enter();
												Writer("What felt like a small breeze soon became like a hurricane behind you, and as you turned your back to face the wind, something large, something monsterous, stared at you back.");
												Enter();
												Writer("A massive, Pscorpatriarbordactyl glares at you with killing intent.");
												Enter();
												Writer("It opens its mouth and a high-pitched scream assaults your ears as the smell of rotting meat assaults your nose.");
												Enter();
												Writer("The other Plavadactyls are making stomping and shreeking in anticipation, making the ground below tremble with all its might.");
												Enter();
												Writer("With one large scream, the Pscorpatriarbordactyl silences them all.");
												Enter();
												Writer(name + ": Let's do this.");
												Enter();

												//Pscorpatriarbordactyl Boss
												MonsterEncounter(useClass: true, monster: n030);
												Space();
												Enter();
												area = 17;
												Save();
											break;

											case 17:
												Console.Clear();
												Writer("Your sword falls to the ground as your arms grow limp from exhaustion. Panting heavily, you sting as the lactic acid poisons your veins and your sweat breaches your wounds.");
												Enter();
												Writer("You barely muster the ability to stand.");
												Enter();
												Writer("The Plavadactyls screaming is shock and anger as they stare in disbelief at the rotting corpse of their leader in front of them.");
												Enter();
												Writer("You attempt to lift your sword to defend yourself, but you can't muster the strength.");
												Enter();
												Writer("As the Plavadactyls leap into the air, their hot spit grazes your skin and leaves burns on your already charred, aching body.");
												Enter();
												Writer("You try to move away, but your legs are stuck in place.");
												Enter();
												Writer("You try to muster up the strength to move at all, but you just can't.");
												Enter();
												Writer("You may die here.");
												Enter();
												Writer("Out of nowhere, a swordsman leaps from a place above the fight, and slashes at one of the beasts.");
												Enter();
												Writer("As the Plavadactyl cries in agony from its wound from a suprise strike, the swordsman is revealed.");
												Enter();
												Writer(name + ": Mark?!", 3);
												Enter();
												Writer("Mark: Heya, buddy, how's it going? Well, I guess I already know the answer to THAT question.", 3);
												Enter();
												Writer(name + " [between pants]: What're YOU doing here? Can't you see I'm busy?", 3);
												Enter();
												Writer("Mark: Busy dying? Can't let that happen!", 3);
												Space();
												Writer("Mark slashes a Plavadactyl attempting to get to you.");
												Enter();
												Writer("Mark: After all, who am I going to duel when I'm bored?", 3);
												Enter();
												Writer(name + ": I think it would be great if you spent your time annoying other people.", 3);
												Enter();
												Writer("Mark: Awww, don't be such a party pooper! Aren't you a swordsman?", 3);
												Enter();
												Writer(name + "I don't think swordsmen are contractually obligated to humor annoying people.", 3);
												Space();
												Writer("Regaining your footing, you slash a Plavadactyl. It gets furious and attacks, as do the others.");
												Enter();
												MonsterEncounter(useClass: true, monster: n031);
												Space();
												Writer(name + ": Why did you help me? We could've split and conquered.", 3);
												Enter();
												Writer("Mark: Because I'm your friend!", 3);
												Enter();
												ThrDot();
												Writer(name + ": not a very good excuse.", 4);
												Space();
												Enter();
												MonsterEncounter(useClass: true, monster: n032);
												Space();
												Writer("Together you fight the endless monsters. As their carcases pile up, so does your combined exhaustion.");
												Enter();
												Writer("Mark allowed you to do active rest, but now both of you are becoming tired.");
												Enter();
												MonsterEncounter(useClass: true, monster: n033);
												Space();
												Writer("Your swords became unsteady as you both had to focus on one enemy, while fending off others who wanted to fight.");
												Enter();
												Writer("Time was running out.");
												Enter();
												MonsterEncounter(useClass: true, monster: n034);
												Space();
												Writer(name + ": We can't keep going like this.", 3);
												Enter();
												Writer("Mark: True that.", 3);
												Enter();
												MonsterEncounter(useClass: true, monster: n035);
												Space();
												Writer("Mark [panting]: I'm...hah...exhausted...!", 3);
												Enter();
												Writer(name + " [panting]: We...can't...keep going like this!", 3);
												Enter();
												MonsterEncounter(useClass: true, monster: n036);
												Space();
												Writer(name + ": I'm fed up!");
												Space();
												Writer("You leap into the air and start choking a Plavadactyl. The monster struggles.");
												Enter();
												MonsterEncounter(useClass: true, monster: n037);
												Space();
												Writer("You tame the beast and fly away.");
												Enter();
												Writer("The other Plavadactyls are fast behind.");
												Enter();
												MonsterEncounter(useClass: true, monster: n038);
												Space();
												Enter();
												area = 18;
												Save();
											break;

											case 18:
												Console.Clear();
												Writer("You have to micromanage both controlling your Plavadactyl and fighting off others at the same time, bone-tired all the while.");
												Enter();
												MonsterEncounter(useClass: true, monster: n039);
												Space();
												Writer("The other Plavadactyls are exhausting now, their large, heavy wings slowing them down.");
												Space();
												Writer("But yours hits the ground first.");
												Enter();
												Writer(name + ": Gah!", 3);
												Space();
												Writer("Your sharp shout of pain fills the air while both you and your persuers collide with the dark, igneous soil filled with sharp, rugged stones.");
												Enter();
												Writer("You sit on the ground, clenching your dislocated shoulder.");
												Enter();
												Writer("Someone, also on a Plavadactyl, shouts in the distance.");
												Space();
												Writer("Mark: " + name + "! Wait for me!", 3);
												Enter();
												Writer(name + ": I'd rather not.", 3);
												Enter();
												Writer("A Plavadactyl sizes you up for a after-run snack, but gets pierced by Marks greatsword, which is swiftly withdrawn back to him by chain.");
												Enter();
												Writer("Mark: Looks like you coud use a hand!", 3);
												Enter();
												Writer(name + ": That thing nearly had me!");
												Enter();
												Writer("Mark: Well those 'things' are also about to pounce. What do we do? I don't think we can fight them all off...", 3);
												Enter();
												Writer(name + ": We have to fight. We have no other option.", 3);
												Enter();
												area = 19;
												Save();
											break;

											case 19:
												Console.Clear();
												Writer("Mark musters what strength he has left to slice a clean mark on a Plavadactyl.");
												Enter();
												Writer("Mark: *pant*...*pant*...then " + SetColor("bold") + "let's get to it!", 3);
												Space();
												Enter();
												MonsterEncounter(useClass: true, monster: n040);
												Space();
												MonsterEncounter(useClass: true, monster: n040);
												Space();
												MonsterEncounter(useClass: true, monster: n040);
												Space();
												Writer("Beads of sweat mixed with dark, hopeless blood drop from Mark's bruised, battered face.");
												Space();
												Writer("Mark: *pant*...*pant*...", 3);
												Enter();
												MonsterEncounter(useClass: true, monster: n041);
												Space();
												MonsterEncounter(useClass: true, monster: n041);
												Space();
												MonsterEncounter(useClass: true, monster: n041);
												Space();
												Writer("Despite your messed up shoulder, you still continue to fight for your survival. The the side of your body holding your greatblade is getting numb.");
												Space();
												Writer("You're trying to fight through the immense pain.");
												Enter();
												Writer(name + ": Hah...gah...", 3);
												Enter();
												MonsterEncounter(useClass: true, monster: n042);
												Space();
												Writer("Both of you holding onto your greatswords, you look around for more enemies to surmount.");
												Enter();
												Writer("But there is nothing left to fight. The surroundings are completely clear, and the Plavadactyls are running away.");
												Enter();
												Writer("Mark: " + name + " we...we-", 3);
												Space();
												Writer("You both fall face first to the ground, unable to muster any more stength to stand.");
												Enter();
												area = 20;
												Save();
											break;

											case 20:
												Console.Clear();
												Writer("You wake up.");
												Enter();
												Writer("Immediately, your entire body aches egregiously, and you moan in pain.");
												Enter();
												Writer("You stand up, your body shaking, and breathe in the air.");
												Space();
												Writer("How long have you been asleep? Hours? Days? Weeks? There's no recollection.");
												Enter();
												Writer("Your look to your right and see Mark sleeping peacfully. You look away to scan your surroundings.");
												Enter();
												Writer("The scene of midday is then interrupted by the sound of bugs and Magmalikes eating away at the flesh of the dead Plavadactyls.");
												Enter();
												Writer("In order to leave before they notice your presence, you pack and embark on your journey again...");
												Enter();
												Writer("...once again alone.");
												Enter();
												area = 5;
												Save();
											break;

											case 5:
												//town arc
												Enter();
												Save();
												Console.Clear();
												Space();
												Writer("A few weeks later, you come across a deserted village, though this one is unlike duel town.");
												Enter();
												Writer("Walking in, you see a terrible scene: sick people, injured folk, and a little boy trying to take care of them all, along with his siblings. You walk to see the damage, when you see a familiar face carrying around people on his shoulders: ", 2);
												Color("blue");
												Writer("Mark!", 2);
												Color("null");
												Enter();
												Writer(name + ": What are you doing here Mark?! I thought you where only into battling?", 3);
												Enter();
												Writer("Mark: I am, but when justice calls, I am its right hand man!", 3);
												Enter();
												Writer(name + ": What is THAT supposed to mean?", 3);
												Enter();
												Writer("Mark: It MEANS that I like to help the poor, " + name + "! You should be helping this kid too too!", 3);
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
															Writer("Mark: Now THAT'S the mark of a true swordsman! It's good to help people in need!", 3);
															Enter();
															Writer(name + "[embarrassed]: Whatever...", 3);
															stop = true;
														break;

														case "2":
														case "2:":
														case "option 2":
														case "option 2:":
														case "I'm a mercinary, not a medic! You can save these people on your own. I want to stay out of this.":
															Space();
															Writer("Mark: What a critz! Mark, I didn't know you were this heartless!", 3);
															Enter();
															Writer(name + ": For a mercinary, to have a heart is a bad thing, you know.", 3);
															Enter();
															Writer("Mark: At least ", 4);
															Color("bold");
															Writer("try!", 4);
															Color("null");
															Space();
															Writer(name + ": How about ", 4);
															Color("bold");
															Writer("no?", 4);
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
												Writer("Mark: Anyway, right now are priority is getting the guys who caused this. Right now I heard they're heading for ", 4);
												Color("red");
												Writer("THE DRAGON.", 4, 100);
												Color("null");
												Enter();
												Writer(name + ": So, how are they getting there?", 3);
												Enter();
												Writer("Mark: They're getting there by ship. We can take a boat and take them out! And once we do that, we can take the stuff they stole!", 3);
												Enter();
												Writer(name + ": Seems simple enough. So how do you think we'll get to them, now that we are quite the way away from the shore?", 3);
												Enter();
												Writer("Mark: Simple. We'll ", 4);
												Color("red");
												Writer("fire ", 4);
												Color("null");
												Writer("our way there!", 4);
												Enter();
												Writer(name + ": What do you mean?", 3);
												Enter();
												Writer("Mark: Simple! We take a foward cannon. When we go, we will be at the shore where they'll be! Chances are that they have yet to leave, so we can catch up to them!", 3);
												Enter();
												Writer(name + ": Seems legit.", 3);
												Space();
												Writer("Mark: Great! Just remember to get ready first! We may be there for a while.", 3);
												Enter();
												Writer("Boy & his siblings: We thank you greatly for helping us stranger teen. Here is some GOLD. I wanted to use this on candy, but I think this is a better use.", 3);
												Enter();
												Writer("You gained 500 GOLD!");
												GOLD += 500;
												Enter();
												Writer(name + ": You mean 'a little' GOLD, didn't you?", 3);
												Enter();
												Writer("Mark: Shut up!", 3);
												Enter();
												Writer("Boy: I mean, it was for candy.", 3);
												Color("yellow");
												Writer("You have " + GOLD + " GOLD and ", 2);
												Color("pink");
												Writer(HP + " HP left. ", 2);
												Color("bold");
												Writer("Be wise!", 2);
												Color("null");
												ItemUser();
												Enter();
												area = 6;
												Save();
											break;

											case 6:
												//ship
												Save();
												Console.Clear();
												Space();
												Writer("You both get into separate cannons, each prepared — hopefully — for the hardships ahead.");
												Enter();
												Writer("Mark: I hope you're ready for this!", 3);
												Space();
												Color("bold");
												Writer(name + ": P e r h a p s.", 3);
												Enter();
												ThrDot();
												Thread.Sleep(1200);
												Writer("BAM!");
												Color("null");
												Space();
												Writer("With a blast, you are off, off and away.");
												Enter();
												Writer("PLUNK!");
												Enter();
												Writer("Mark [hurt]: Man! Maybe I shouldn't have made us travel by cannon, that hurt like fu-", 3);
												Space();
												Writer(name + ": Keep the game T rated, please.", 3);
												Enter();
												Writer("Mark: Frick...", 3);
												Enter();
												Writer("You see a pirate in the distance. What do you do?");
												stop = false;
												while(stop == false)
												{
													Space();
													Color("green");
													Writer("option 1: " + name + " [thinking]: Frick these guys, I'm not going to point it out.");
													Color("red");
													Writer("option 2: " + name + " [thinking]: For once, I want to be helpful. I'll tell Mark about that guy.");
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
															area = 7;
															Save();
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
															area = 10;
															Save();
														break;
													}
												}
											break;

											case 7:
												Writer(name + ": ...");
												Space();
												Writer("After a little bit, the pirates leave the shore.");
												Space();
												Writer("Mark: Hey, dammit! They're getting away!", 3);
												Enter();
												Writer(name + " [playing innocent]: Huh.", 3);
												Enter();
												Writer("Mark: Darn, we're going to have to travel by sea!", 3);
												Enter();
												Writer(name + ": Why not boat?", 3);
												Enter();
												Writer("Mark: Because I don't know how to use a boat.", 3);
												Enter();
												Writer("Mark: So now, let's strap down, put on our swimming suits, and let's get swimming!", 3);
												Enter();
												area = 8;
												Save();
											break;

											case 8:
												//ocean
												Console.Clear();
												Writer("After flying into the ocean, You start swimming from the docks. The sheer beauty of the seafloor is magnitudes above what you imagined. Thousands of fish sail the seas, while coral reefs give yellows, reds, and purples of almost divine colors.");
												Enter();
												Writer("Mark: Place sure is beutiful, huh?", 3);
												Enter();
												Writer(name + ": Pffft. Yeah, I guess...", 3);
												Enter();
												MonsterEncounter(90, 30, 8, "BJ Fish", 2000F, 0, false, true);
												Space();
												MonsterEncounter(95, 25, 12, "Giva Fish", 1500F, 200, false, true);
												Space();
												MonsterEncounter(100, 20, 10, "Baby S. Dodododododo", 2200F, 350, false, true);
												Space();
												Writer("After some battles with crazy fish, you swim right into a warm, happy cave filled with many gems desired by thousands; all sparkling gently as if God himself gave them to you.");
												Enter();
												Writer("Both of you stand on the floor of the cave, ready to add some gems to your collection, when-");
												MonsterEncounter(140, 12, 15, "Gaurdian Eel", 4000F, 400, true, true);
												Space();
												Writer("The encounter left you both chilled, lifeless, speechless, paralyzed for unkown reasons. You gather the courage to look up, seeing a DRAGON, sparkling in gems of all sizes, elegently sparkling to decieve their sharp, blade-like fashioning. The DRAGON screams as you ready your arms, hardening for the battle to come.");
												Enter();
												area = 9;
												Save();
											break;

											case 9:
												ItemUser();
												MonsterEncounter(400, 30, 14, "Jewled Sea DRAGON", 6000F, 5200, true, true);
												Space();
												Writer("As the monster drops to the sea floor, you start to feel fuzzy. Upon tasting the water, you realize the cave had poisonous water the entire time. You and Mark try to come out, but it's too later, and you pass out at enterance of the cave");
												Enter();
												area = 0;
												From[4] = true;
												Save();
												EndGame();
												Credits();
												End();
											break;

											case 10:
												Writer(name + ": Look! Over there! A pirate!", 3);
												Enter();
												Writer("Mark: Great! Let's annialate him!", 3);
												MonsterEncounter(100, 30, 19, "Ol' Pirate Joe (Sweeper)", 600F, 600, false, true, false);
												Space();
												Writer("Mark: Great! Thanks for warning so we could pound him in!", 3);
												Enter();
												Writer(name + ": No problem. But you wouldn't think pirates would travel by land and get the oppertunity to loot a village.", 3);
												Enter();
												Writer("Mark: Hey look! Their ship! Let's pound them up!", 3);
												Enter();
												Writer(name + ": Alright...", 3);
												Enter();
												area = 11;
												Save();
											break;

											case 11:
												//b o o t y  ship
												Console.Clear();
												Writer("Under the deck of the pirate ship, you and Mark are stragegizing out of sight.");
												Enter();
												Writer("Someone snarly: WHAT?! Ol' Joe was KNOCKED OUT?! Granted, he does only sweep the decks but STILL!! Anyone who messes with MY CREW is an enemy of mine! Sweep the WHOLE SHIP and kill em'!", 3);
												Enter();
												Writer(name + ", Mark [in unison]: ", 4);
												Color("bold");
												Writer("Crap.", 4);
												Color("null");
												Enter();
												Writer(name + ": Someone's coming down the stairs!", 3);
												Space();
												Writer("Pirate: Ohh looky here man! [licks lips disgustingly] We got another victim! [licks lips disgustingly]", 3);
												Enter();
												Writer("Scarier Pirate: OOOOOOO [licks lips disgustingly] hehehehehHE!!! [licks lips disgustingly] You go FIRST [licks lips disgustingly] I'll be THERE for you [licks lips disgustingly]", 3);
												Enter();
												Writer("Pirate: [licks lips disgustingly]", 3);
												Enter();

												MonsterEncounter(105, 30, 19, "A Very Disgusting Pirate", 700F, 900, false, true, false);
												ThrDot();
												Enter();
												Writer("Scarier Pirate: NOOOOOOOOOOOO!!! BILLLYYYYYYY!!!", 3);
												Enter();
												Writer("Scarier Pirate [furious]: I'M GOING TO ", 4);
												Color("yellow");
												Writer("[this game is T rated]", 4, 60);
												Color("null");
												Writer(" KILL YOU!!!!!", 4);
												Enter();
												MonsterEncounter(125, 32, 21, "A Very, Very Disgusting and Mad Pirate", 1000F, 1100, true, true, false);
												Space();
												Writer("Mark: Nice " + name + "! Now, let's keep stra-", 3);
												ThrDot();

												MonsterEncounter(60, 21, 15, "Ol' Pirate Burner (Blacksmith)", 5000F, 1500, true, true, true, 60, 19, 17, "Ol' Pirate Fols(Gunsman)", 4);
												Space();
												Writer(name + ": This is getting out of hand...", 3);
												Enter();
												Writer("Mark: That's not something you have to tell me twice.", 3);
												Enter();
												Writer("Mark: Anyway, like I was saying, let's keep stra-", 3);
												Enter();

												MonsterEncounter(50, 22, 19, "Ol' Pirate Sam (Swordsman)", 9000F, 2000, true, true, true, 38, 25, 10, "Ol' Pirate Babidy (Wayward)");
												Space();
												Writer("Mark: WHY DO PEOPLE KEEP INTERUPPTING ME WHEN I SAY-", 3);
												Enter();
												MonsterEncounter(20, 10, 2, "fricking fish", 500F, 0, false, false, false);
												Space();
												Writer(name + ": |:(", 3, 120);
												Enter();

												Writer("Mark: We REALLY should just keep strat-", 3);
												Enter();
												Color("bold");
												Writer("SLAP");
												teamMateHP -= 5;
												Color("null");
												Enter();
												Writer("Mark: HOW DO THESE FISH KEEP GETTING IN HERE?! AND ", 4);
												Color("bold");
												Writer("Mark [infuriated]: WHY DO THEY KEEP SLAPPING ME?!?!", 3);
												Color("null");
												Enter();
												area = 12;
												Save();
											break;

											case 12:
												//strats (speedrunning music plays)
												Console.Clear();
												Writer("Mark: Ok, here's the plan.", 3);
												Enter();
												Color("bold");
												Writer("1. ", 2);
												Color("null");
												Writer("Create a distraction", 2);
												Enter();
												Color("bold");
												Writer("2. ", 2);
												Color("null");
												Writer("Take the stolen items of the village", 2);
												Enter();
												Color("bold");
												Writer("3. ", 2);
												Color("null");
												Writer("Sink the ship", 2);
												//rest
												Enter();
												Writer(name + ": Why sink the ship?", 3);
												Enter();
												Writer("Mark: Because these guys are no-goods, and they'll probably steal some more stuff anyway!", 3);
												Enter();
												Writer(name + ": No-good? You're such a baby. Not everyone has plot armor like us. Sometimes we need necessary evils to get by.", 3);
												Enter();
												Writer("Mark: That's not true! Even if times are rough, sticking to good morals are what separates a man from a boy!", 3);
												Enter();
												Writer(name + ": Whatever you say, o' wise one.", 3);
												Enter();
												Writer("Mark: Hey! Could you stop acting like the basic emo edgy archetype for one minute?! If you really felt that way, you wouldn't ahve warned me about the pirate!", 3);
												Enter();
												Writer(name + " [embarrassed]: Yeah? Well I can easily retract that kindness if you like.", 3);
												Enter();
												Writer("Mark [frustrated]: You...!", 3);
												Enter();
												area = 13;
												Save();
											break;

											case 13:
												//gotime
												Console.Clear();
												Writer("Step 1: Create a Distraction.");
												Enter();
												Writer("You climb above and and start waving your arms.");
												Enter();
												Writer(name + " [unmotivated]: Oogabooga. Shooga Toota.", 3);
												Enter();
												Writer("Captain: Get him!", 3);
												MonsterEncounter(140, 20, 10, "Ol' Pirate Brawney (Boxer)", 3600F, 529);
												Space();
												Writer("Pirate: Hey, that guy's calling us oomba loompas! Let's jump em'!", 3);
												Enter();
												Writer(name + ": What?", 3);
												Enter();
												MonsterEncounter(90, 20, 8, "Ol' Pirate Mick Mate (Cartographer)", 4000F, 456, true, false, true, 90, 18, 7, "Ol' Pirate Apprentace Jimmy (Rookie Janitor)");
												Space();
												Writer(name + ": Mark, why am I have to battling two people at once?!", 3);
												Enter();
												Writer("Mark: Because you think your cool!", 3);
												Enter();
												Writer(name + ": Damnit...", 3);
												MonsterEncounter(30, 22, 10, "Ol' Pirate Best Jeanist (Pro Hero)", 4800F, 1500, true, false, true, 18, 25, 3, "Ol' Pirate Small Might (Protagonist)");
												Space();
												Writer(name + ": Uhh...", 3);
												Enter();
												Writer("Mark: Focus! We're going to do stage 2!", 3);
												Enter();
												Writer("MarK: Here's a potion plus to heal yourself with!", 3);
												Enter();
												Writer(name + ": Could've been useful before, but I won't question it.", 3);
												Enter();
												Writer("You gained 60 HP!");
												HP += 60;
												if(HP > HEARTS)
												{
													HP = HEARTS + 10;
												}
												Enter();
												Color("blue");
												Writer("2. Take the stolen items.");
												Color();
												Enter();
												Writer("Mark: Now that most of the crew is knocked out or obliterated, we can get the goodies!", 3);
												Enter();
												Writer(name + ": Goodies? Anyway, we have to be careful! A storm is racking the ship!", 3);
												Enter();
												area = 14;
												Save();
											break;

											case 14:
												Space();
												Writer("Someone Snarly: NO ONE EVER GETTN' ME' BOOTY!", 3);
												Enter();
												Writer("Mark: Why are you doing this?! Stealing people's stuff?!");
												Writer(name + " [sarcastic remark]: Because originality is stupid and we need to be 'goodie goodies'...", 3);
												Enter();
												Writer("Someone Snarly: If they can't fight off me' good-for-nothing goons, they don't deserve the tresure they hold!", 3);
												Writer(name + " [to Mark]: He got a point...", 3);
												Enter();
												Writer("Mark: But stealing is wrong! And some people decide not to dedicade their life to one of strength and power, but one of cooperation and peace! The former life is the life we as swordsman are here to live! And we can't make people live life they don't want to live any more than we can to ourselves.", 3);
												Enter();
												Writer(name +  " [silently reflecting:...");
												Space();
												Writer("Captain Snarly: Well, enough talk! I, Captain Snarly, will single-handedly beat both of y'all!", 3);
												Enter();
												Writer(name + " and Mark simulateusly: Bring it!", 3);
												Enter();
												ItemUser();
												MonsterEncounter(140, 40, 16, "Captain Snarly (Captain)", 10000F, 3000, true, true, false);
												Space();
												area = 15;
												Save();
											break;

											case 15:
												Writer("Captain Snarly: But how...?", 3);
												Enter();
												Writer(name + ": For a lot of my life, I thought that strength made people stronger. My father is a drunkard...and I killed him after what he did to my family. That only led me to be an outcast of my family, and I trained and trained, hoping to find a meaning to my life.", 3);
												Enter();
												Writer(name + ": And I soon found myself having a mindset of the powerful over the weak...", 3, 60);
												Enter();
												Writer("But now, I feel that not everyone has to be physically strong to be powerul, but instead, they have to be strong in ways that even I may not know. And now, I think that I should try to see the world in a different way.", 3);
												Enter();
												ThrDot();
												Writer("Captain: But what does that have to do with me?", 3);
												Enter();
												Writer(name + ": Number 3.");
												Enter();
												Writer("Captain: What?");
												Color("purple");
												Writer(name + " [shouting]: SINK THE SHIIIIP!!!", 3);
												Color("bold");
												Enter();
												Writer("You slam your sword into the hull, allowing the stormy waters to rise continuously. Thunder slams the ship, causing raging fire that capsize that ship. You and Mark are slammed under, knocked out by the ship and never seen again.");
												Enter();
												Color("yellow");
												Writer("On that particular spot, at least.");
												area = 0;
												From[0] = true;
												Save();
												Thread.Sleep(2000);
												EndGame();
												Credits();
												End();
											break;
										}
									break;

									//DEBUG
									case "69":
									case "420":
									case "F I V E  N I G H T S  A T  F R E D D Y Y Y ' S .  I S  T H I S  W H E R E  Y O U  W A N T  T O  B E ????  I  J U S T D O N ' T  G E E E E T  I T T T .  W H Y  D O  Y O U  W A N T  T O  S T A Y ???":
										Use();
										MonsterEncounter(1,0,0, "Sad man", 0, 0, true, false, false, 1, 0, 0, "Sad human");
										MonsterEncounter(monName: "Debug Bug", exp: 2000F, gold: 3000,attack: 0 ,hp: 1, speed: 900, doubleBattle: false, twoEnemy: true, monNameTwo: "Debug Insect", hpTwo: 10, attackTwo: 0, hasWeight: false, hasPattern: true, pattern: new int[] {1, 1, 1, 0, 1, 3, 1, 2, 1, 1}, waitTime: 2, boss: true);
										MonsterEncounter(monName: "Debug Bug", exp: 2000F, gold: 3000,attack: 1 ,hp: 70, speed: 900, doubleBattle: true, twoEnemy: true, monNameTwo: "Debug Insect", hpTwo: 40, attackTwo: 7);
										Writer("END");
										Enter();
										End(0);
									break;

									//forests
									case "forests":
									case "Forest":
									case "Forests":
									case "forest":
									case "3":
									case "forests, 3":
										switch(area)
										{
											case 0:
											case 1:
												Space();
												//forests
												Writer("forest? Classic choice! You go and immediately run into a MONSTER ENCOUNTER");
												Space();
												MonsterEncounter(19, 3, 3, "Bushable", 500F, 100);
												Space(2);
												//rest of the option
												Writer("You defeated (or maybe ran from) the monster, but your jouney still goes on.");
												Space();
												Writer("You go through the dangorous forests, destroying all in your path.");
												Enter();
												MonsterEncounter(30, 4, 2, "Stealing Steve", 1500F, 1200);
												Space();
												Enter();
												area = 2;
												Save();
											break;

											case 2:
												//Crossroads
												Console.Clear();
												stop = false;
												while(stop == false)
												{
													Writer("Journeying out of the forests, you come to a crossroads near a Mine and a Mountain. What shall you do?");
													Writer("What shall you do?");
													Space();
													Writer("Go to Mine");
													Writer("Go to Mountain");
													//Logic
													Space();
													option = Reader();
													switch(option)
													{
														case "1":
														case "Go to Mine":
														case "go to mine":
														case "mine":
														case "Mine":
															area = 3;
															stop = true;
															Save();
														break;

														case "2":
														case "Go to Mountain":
														case "go to mountain":
														case "mountain":
														case "Mountain":
															area = 8;
															stop = true;
															Save();
														break;

														default:
															ErrorWrite();
														break;
													}
												}
											break;

											case 3:
												Space();
												Writer("You go through the dark mines, where you meet a shady miner who comes up to you like a guy asking for directions on the highway.");
												Space();
												Writer("GUY: Hi! You're in the mines, huh? Not to be captain obvious, but you really shouldn't	be here. it's dangorous.", 3);
												Enter();
												Writer("What do you say? (1 for option 1, 2 for option 2)");
												Space();
												Writer("option 1: " + name + ": I don't care. I gotta mission to do, so scram.");
												Space();
												Writer("option 2: " + name + ": *sniff* o k. [leaves like a virgin simp]");
												Space();
												option = Reader();
												bool go = false;
												switch(option) 
												{
													case "1":
													case "I don't care. I gotta mission to do, so scram.":
													case "option 1":
														area = 4;
														Save();
													break;

													case "*sniff* o k.": 
													case "2":
													case "option 2:":
														Writer("GUY: Good. Well, nice meeting	you. Bye!", 3);
														Space(2);
														go = true;
													break;

													default:
														ErrorWrite();
														Enter();
														Writer(name + ": " + option + "!", 3);
														Enter();
														Writer("GUY [confused]: What?", 3);
														Space();
														Writer("After Embarassment from being unintelligeble, you just leave.");
														Enter();
														go = true;
													break;
												}
												if(go == true)
												{
													goto case 2;
												}
											break;

											case 4:
												Writer("I warned you.", 3);
												Enter();
												MonsterEncounter(23, 5, 9, "MegaMadGUY", 200F, 300, false);
												Space();
												Writer("That was odd, but you keep moving on through the mines,");
												Enter();
												MonsterEncounter(25, 4, 6, "Rockalike", 1500F, 130, false);
												Space();
												Writer("Going through the tipper-tap of picks and avoiding sentient rocks, you nearly stumble into the Captain.");
												Space();
												Writer("Captin [on phone]: Mmmhm. Huhhuh. WHAT?! I'm going to destory him in the name of the law when I find him! What are to details? What? A large sword and his name is '" + name + "'? I'll definitely find and kill him!", 3);
												Enter();
												Writer(name + ": Uhhh, hello?", 3);
												Enter();
												Writer("Captin: Who are you? And what gives you the right to go on this private property?!", 3);
												Enter();
												Writer(name + ": No need for alarm. I'm just you friendly neigborhood " + name + ".", 3);
												Enter();
												ThrDot();
												Space();
												Writer("Captin: >:(", 4);
												Space();
												Enter();
												MonsterEncounter(40, 6, 7, "Caption Joe", 5000F, 2000, true);
												Enter();
												area = 5;
												Save();
											break;

											case 5:
												//Forest: Weeping Ruins
												Console.Clear();
												Space(2);
												Writer("You head out of the mines on the other end to find a hedgeworth of ruins. Big and small; long and short. You walk through, being guilded by your map to the ultimate goal.");
												Enter();
												MonsterEncounter(27, 5, 5, "Artifact Stealer", 2000F, 700, false);
												Space();
												Writer("When break the guy's neck with a 100 lbs sword, he drops a potion from his lifeless body as he hits the cold, Weeping Ruins floor.");
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
													Writer("CabinMaster: Hello! I like studying past civilizations, but I need money! So I founded this store here. You buy supplies, I get to study. Win win!", 3);

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
																Use(550, 1400, 1600, 2400);
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
																Writer("CabinMaster: Ok. see ya!", 3);
																cockend = true;
															break;

															default:
																ErrorWrite();
																Space();
																Writer("CabinMaster: I'll ask this again. What do you want to do here?", 3);
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
												Writer("Like...Falbed Gaurds. But continuing on, you get to a docks, but then, someone rams you into the ocean!");
												Space();
												MonsterEncounter(42, 11, (int) ATK/3, "Stealing Mermaid-Man Thing", 4500F, 2300, true);
												Space();
												//Ocean
												Enter();
												Console.Clear();
												area = 6;
												Save();
											break;

											case 6:
												Writer("After killing your foe, you are 100s of feet into the ocean. A deep, dark ocean. But because plot, you can breathe underwater, so it is really just a mild inconvenience.");
												Space();
												Writer("Now, you were originally planning to go on a ship to THE DRAGON. But now, you will most likely have to swim instead.");
												Enter();
												Writer(name + ": Oh crap. Now I have to swim hundreds of miles! This is just fricking great!", 3);
												Enter();
												MonsterEncounter(35, 14, 7, "Mosshuat", 2000F, 0, false);
												Space();
												MonsterEncounter(30, 12, 9, "BIONICLE BOI", 660F, 0, false);
												Space();
												MonsterEncounter(1, 1, 999, "UNDER DEM SEA", 2324F, 334, false);
												Space();
												MonsterEncounter(39, 15, 20, "X X X X X X X", 3424F, 883, false);
												Space();
												Writer(name + ": Da frick are these fish names?!", 3);
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
												Writer(name + ": (ಠ_ಠ)", 3);
												Space();
												Thread.Sleep(3000);
												Writer("SilverAtom [ghostly figure]: (•̀.̫•́✧). *dissapears*", 3);
												Space();
												ItemUser();
												MonsterEncounter(69, 0, 21, "Deal with it.", 69F, 69, true);
												Enter();
												area = 7;
												Save();
											break;

											case 7:
												//Ocean Cave
												Thread.Sleep(3000);
												Console.Clear();
												Writer(name + ": I think the sea water is getting to me...", 3);
												Writer("You say as you swim right into a large skull shaped cave. From there, things felt a little more fresh. Even the water became freshwater, somehow. You felt relaxed, and you let yourself relax. And-");
												Space(5);
												HP -= 10;
												MonsterEncounter(50, 8, 10, "Gaurdian Eel", 4000F, 70, true);
												Space();
												Writer("The eel dropped to the floor as you swam even more, wondering why you aren't crushed by pressure by now.");
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
												area = 0;
												From[3] = true;
												Save();
												EndGame();
												Credits();
												End();
											break;

											case 8:
												Space();
												Writer("Going up Termana Mountain, you immediantly feel the cold terrain.");
												Writer("snow fills your view as you trek feet in the air, your sword as a pickaxe, to a path in the drift.");
												Enter();
												Writer("Climbing, you grab onto each rock, your fingers blue as ice, your gasps painted with white at every breath.");
												Enter();
												Writer("Near the halfway point of the Mountain, you can feel to winds getting heavier, and the peaks of animal and human skeletons become visible to the eye. Fosted and cold, the blizzard buries them in infinite snow once again.");
												Enter();
												Writer("You climb heigher, oxygen is getting hard to find in the snowy adrift. Your eyes get watery as snow from the mountain fills your boots and wets you. Your determination is the only thing keeping you alive, and it's dwindling.");
												Enter();
												Writer("Your vision seems to be getting blurry, because in the distance you see someone alive. Someone...friendly?");
												Enter();
												Writer("Stepping closer, each pace making you weak to the bone as your muscles tire, you see more of them. A musclular frame and a hairy body. Probably what you would expect from a hiker.");
												Enter();
												Writer("Something isn't right.");
												Enter();
												Writer("It comes towards you, their silhouette becoming hairy and monsterous. Canine teeth glisten in the white peak as the sun shines eye-to-eye with the beast.");
												Enter();
												Writer("Addreneline start pumping through your veins. Your lungs frost with your muscles warming and your heavy breathing. Your heart speeds, your Maldur blade is pulled from your back.");
												Enter();
												Writer("As you go into a stance, you remember only one thing on the foot of the peak.");
												Enter();
												Writer("To FIGHT.");
												Enter();
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
													Writer("CabinMaster: Helloo! Stormy Mountain, Huh? Yeah, I built this cabin so people could rest up on their unfruitful journeys to the heart.", 3);
													Enter();
													Writer("CabinMaster: So anyway, do you want to rest up for 400 gold? Livng up here isn't easy, you know.", 3);
													Space();
													//Logic
													Writer("Pay up? You have " + GOLD + " gold and " + HEARTS + " Max HP, and " + HP + " HP left.");
													Space();
													Writer("yes");
													Writer("no");
													Space();
													option = Reader();
													bool stooper = false;
													while(stooper != true)
													{
														switch(option)
														{
															case "YES":
															case "Yes":
															case "yes":
															case "1":
																GOLD -= 400;
																HP = HEARTS;
																Space();
																Writer("CabinMaster: Thank you for your service. But there is more too! I have a plethera of supplies, and can I interest you with 	them?", 3);
																Space();
																Use();	
																stooper = true;			
															break;

															case "No":
															case "NO":
															case "no":
															case "2":
																Space();
																Writer("CabinMaster: No? Well you'll regret it! But there is more too! I have a plethera of supplies, and can I interest you with them?", 3);
																Space();
																Use();	
																stooper = true;
															break;

															case "Attack":
																Space();
																Writer("You killed the CabinMaster, you murderer.");
																Space(2);
																Writer("No mor cabns 4 u!");
																noCabin = true;
																stooper = true;
															break;

															default:
																Writer("CabinMaster: What? It's a yes	or no question. So what'll it be?", 3);
																Space();
																Writer("yes");
																Writer("no");
																Space();
																option = Reader();
															break;
														}
													}
												}
												else
												{
													Writer("You see a cabin, but it's empty. No cabns 4 u!");
												}
												//rest
												Enter();
												Writer("In the drift, you continue to the top to easily venture down. Anyway, you see humanoids again. But this time, they're smaller, and TWO of them!");
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
												Writer("You head to the top, hoping to be able to find the peak. But you hear footsteps. LOUD footsteps. Of a beast, no, a monster. A huge Obscuronsnow appears, threatening you with it's booming chest bumps. DO you, " + name + " know what that means? MONSTER ENCOUNTER.");
												ItemUser();
												Space(4);
												//Boss
												MonsterEncounter(60, 8, 10, "Obscuronsnow Large", 10000F, 300, true);
												Enter();
												area = 9;
												Save();
											break;

											case 9:
												Console.Clear();
												//Heart Caverns
												Writer("After crossing paths with the beast, you have defeated it. But the winds howl faster, the storm rages even more intensly. Fearing melting into a pile of ice in the everlasting snow, you have no choice but to go on through an abandoned mine stationed in a natural cave near the peak of the Mountain.");
												Enter();
												Writer("After entering, you sea a sea of crystal worth thousand glacing the ceiling, humans wearing antartic cloths and bearing pick-swords dotted around, rotting to the fies drawn to their imobilized corpses. The room is filled with greys, blues and purples as the cracking of ice fills your ears and the smell of rotting flesh distresses your nose.");
												Enter();
												Writer("But then you hear a crack.");
												Enter();
												Writer("Then a bump.");
												Enter();
												Writer("Then, out of the corner of your eye, you see a robot-like creature fly towards you, guns in hand, powered by the ice and snow itself, sensing what's greater. It is revealed that the cold was not what killed the people who where so unfortunate to grace this cave, but in reality, it was the Heart Gaurdians.");
												Enter();
												MonsterEncounter(30, 6, 7, "Heart Gaurdian", 1000F, 20, false);
												Space();
												MonsterEncounter(30, 6, 7, "Heart Gaurdian", 1000F, 20, false);
												Space();
												MonsterEncounter(30, 6, 7, "Heart Gaurdian", 1000F, 20, false);
												Space();
												MonsterEncounter(32, 6, 7, "Heart Gaurdian", 1000F, 20, false);
												Space();
												Writer(name + ": There's a lot of these 'Heart Gaurdian' things huh?", 3);
												Enter();
												MonsterEncounter(36, 6, 7, "Heart Gaurdian", 1000F, 20, false);
												Space();
												MonsterEncounter(42, 6, 7, "Heart Gaurdian", 1000F, 20, false);
												Space();
												MonsterEncounter(50, 6, 7, "Heart Gaurdian", 1000F, 20, false);
												Space();
												Writer("You stop for a well needed break from the onslaught of Gaurdians on your tail, to sharpen your sword and take a bite out of your sandwitch. Sitting on the ground, there is a beating presence. Then, and jewl-like arm sits on your shoulder.");
												Enter();
												Save();
												MonsterEncounter(67, 1, 12, "Jewled Man", 3500F, GOLD, true);//Mini-Boss
												Space();
												Writer(name + ": What was that?! Is that ", 4);
												Color("bold");
												Writer("a...man!", 4);
												Color("bold");
												Enter();
												Writer(name + ": What the hell...", 3);
												Enter();
												Writer("You say as the monster appears to be a man encased in crystals. his eyes stay in shock even after death, and every internal organ you know is punctured by gems. When you sit back down, you realize that the gems around you start to call to you, cling to you, promising everlasting warmth in the never ending snow. You slash them to pieces with your massive sword, creating a large sound you're sure the gaurdians heard.");
												Enter();
												Writer("You ready your blade, pack your stuff, and harden to face the truth inside the Heart of Termana Mountain.");
												Enter();
												area = 10;
												Save();
											break;

											case 10:
												MonsterEncounter(62, 8, 11, "Desperate Heart Gaurdian", 3000F, 20, false);
												Space();
												MonsterEncounter(69, 8, 11, "Desperate Heart Gaurdian", 3000F, 20, false);
												Space();
												MonsterEncounter(70, 8, 11, "Desperate Heart Gaurdian", 3000F, 20, false);
												Space();
												MonsterEncounter(70, 8, 11, "Desperate Heart Gaurdian", 3000F, 20, false);
												Space();
												MonsterEncounter(70, 8, 11, "Desperate Heart Gaurdian", 3000F, 20, false);
												Space();
												MonsterEncounter(70, 8, 11, "Desperate Heart Gaurdian", 3000F, 20, false);
												Space();
												Writer(name + ": *Huff* *puff*", 3);
												Enter();
												MonsterEncounter(90, 11, 12, "Demented Heart Gaurdian", 3000F, 20, false);
												Space();
												MonsterEncounter(90, 11, 11, "Demented Heart Gaurdian", 3000F, 20, false);
												Space();
												MonsterEncounter(100, 11, 9, "Demented Heart Gaurdian", 3000F, 20, false);
												Space(2);
												Writer(name + ": So...*puff*...many....*huff*", 3);
												Enter();
												MonsterEncounter(120, 14, 14, "Enraged Heart Gaurdian", 5000F, 100, true);
												Space();
												MonsterEncounter(128, 14, 15, "Enraged Heart Gaurdian", 6000F, 200, true);
												Space();
												Writer("After the onslought of enemies, you finally get to a large door barracaded with anything a miner would bring to a cave. Picks, excavation equipment, and all the like. From the outside, you can feel the place around it warmer, and the anger screams of the crystals in your mind, ordering you to come to them. You slash away the barracades, and ready yourself for what is to come. Better use an item!");
												Space();
												ItemUser();
												Space(3);
												area = 11;
												Save();
											break;

											case 11:
												Console.Clear();
												Writer("You open the awesomely big doors, to reveal a heart the size of a monster truck, its crystal like appearence gleaming with the melted crystals around it. But a closer inspection reveals the presence of a gaurdian. A HUGE GAURDIAN. One that is bigger than the heart itself.");
												Enter();
												Writer("BOSS ENCOUNTER!");
												Enter();
												MonsterEncounter(150, 9, 13, "Mega Heart Warden", 7000F, 400, true);
												Space();
												Thread.Sleep(1000);
												Writer("BAAAAAAAM!");
												Enter();
												Writer("As the gaurdian shreads to pieces, a lizard is revealed in its heart. A darivitive, an omen, a monster that many fear, seek, and know by one chilling name.");
												Enter();
												Color("cyan");
												Writer("A DRAGON.");
												Color();
												Enter();
												area = 12;
												Save();
											break;

											case 12:
												Console.Clear();
												ItemUser();
												Space();
												Color("cyan");
												Writer("Ice DRAGON: RWWWWWAAAAAAAARRRRR!!!");
												Color();
												Enter();
												MonsterEncounter(220, 15, 17, "Ice DRAGON", 20000F, 4000, true);
												Space(4);
												Writer("Glistening, the heart gives a sensation as if beaming a smile onto your spirit, and causes you and your brooding arse to smile back. In curiosity, you reach for it. As you touch its exterior, you feel and imense power blend with your soul, giving you more power in expansion. And after, it gives you a message.");
												Enter();
												Color("blue");
												Writer("THERE WILL BE A REMAKE.", 3);
												inventory[10] = "null";
												Enter();
												Color("null");
												Writer("Contemplating whatever that means in your mind, you make your way out of the Mountains, the city in the horizon. All for one purpose: ");
												Thread.Sleep(3000);
												Space(5);
												Writer("To destroy the DRAGON.");
												Thread.Sleep(2000);
												area = 0;
												From[2] = true;
												Save();
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
									break;


									//hills
									case "hills":
									case "Hills":
									case "Hill":
									case "hill":
									case "2":
									case "hills, 2":
										switch(area)
										{
											case 0:
											case 1:
												Console.Clear();
												Writer("The hills? Basic choice! You head towards the hills, but MONSTER ENCOUNTER!");
												Enter();
												MonsterEncounter(19, 19, 3, "Rockalike", 1400F, 200);
												Space();
												Writer("After defeating the creature, you go through the hills.");
												Enter();
												Writer("The area is large and vast; the hills of grass and rock contrasting with the mountains inn the horizon of the blue sky.");
												Enter();
												MonsterEncounter(21, 14, 4, "Talus Small", 600F, 140);
												Space();
												Writer("The monsters you encounter tend to keep themselves in the background. Camaflauged with a rock-like exoskeleton, the insectful Rockalike and the bipedal Talus look like ordinary rocks to the untrained eye.");
												Enter();
												Writer("But you've seen enemies like these before, so it's easy to see which ones to attack.");
												Enter();
												MonsterEncounter(32, 20, 5, "Rockalike", 950F, 220);
												Space();
												Writer("But despite their appearence, its obvious how they play into nature. their rolling around untilts groudn so trees can grow, and their crunchy but nutritious insides make a healthy snack to you and other animals.");
												Enter();
												Writer("Such as carnivorous plants.");
												Enter();
												MonsterEncounter(26, 20, 7, "Viper Planter", 1200F, 700);
												Space();
												Writer("After traveling some 50 miles, you head to a bar to restock and relax for the afternoon journey.");
												Enter();
												Writer("Walking in, you sit at the bar table; completely disregarding drinking laws.");
												Space();
												Writer("Seems the Bartender doesn't really care, however.");
												Enter();
												Writer(name + ": Gimmie a drink, bartender.", 3);
												Enter();
												Writer("Around, you see drunkards fighting and bottles littered on the ground. Familiar. The Sake the Bartender in preparing nearly makes you throw up; you've hated the stench for as long as you can remember.");	
												Enter();
												Writer("Bartender: Here's a drink.", 3);
												Enter();
												Writer(name + ": Please...something else. That damn Sake makes me sick.", 3);
												Enter();
												Writer("Bartender: Hope you are aren't suggesting my Sake is bad, are you?", 3);
												Enter();
												Writer("You stare coldly into the bartender's eyes. Something is familiar about him.");
												Space();
												Writer(name + ": No, I'm not.", 3);
												Enter();
												Writer("Bartender: Ok, then. How about you buy somethn' instead? We are also a cabin.", 3);
												Enter();
												Use(300, 900, 1200, 950, 450);
												Enter();
												area = 2;
												Save();
											break;

											case 2:
												Console.Clear();
												//rest
												Writer("After relaxing at the bar, you walk throughout the hills to the general direction of the THE DRAGON, feet hurting from the rocks and dirt. The sun rises high, the Mountains in the distance. 5 planes pass overhead, people falling from the sides. THE DRAGON is visible in the distance, its roars as violent as its actions.");
												Enter();
												Writer("Exiting the hills and at the foot of Termana Mountain 500 miles away, you walk through fields of green you never thought possible. The atmostphere is beutiful; you see the ocean in the background and the flora and fauna of the forests far away.");
												Enter();
												Writer(name + ": If only I had grown up here...so peaceful...", 3);
												Enter();
												Writer(name + ": Certainly not like back-", 3);
												Space();
												Writer("You refuse to speak another word, realizing you were about to dare the word 'home'.");
												Enter();
												Writer("Walking faster now, you stumble over a Rockalike. It gets mad and MONSTER ENCOUNTER!");
												Enter();
												MonsterEncounter(39, 4, 3, "Rockalike Large", 3000F, 150);
												Space(3);
												Writer("Rockalike: GRAAAAAAAUUUUUUGGGGHHHHHHH!!!! AAAAUUGGHH ThAt HuRtS! wHy DiD yOu HuRt Me?!?!", 3);
												Space();
												Writer(name + ": Oh? You animals talk?, 1");
												Writer(name + ": Because you attacked me first!, 2");
												Space();
												option = Reader();
												Space();
												switch(option)
												{
													case "1":
														Writer("Y E S  wE cAn TaLk! WeE ErE rElAeD tO oU mUrDeReRs,, AfTeR aLl.. T H A T '' S  W H Y  wE cAn LeArN yOuR IrReGeLaR lEgUeG..", 3);
													break;

													case "2":
														Writer("W R O N G ! YoU StUmBlEd OvEr M E  fIrSt!", 3);
													break;

													default:
														Writer("It looks as if it doesn't even understand you.", 3);
													break;
												}

												Enter();
												Writer("GuH,,  i fEe T E RR I B L E  !1 ImMa lEaVe1", 3);
												Enter();
												Writer("The Rockalike rolled away.");
												Enter();
												Writer("After the encounter, you notice as you walk that hills start to wade and the rocky boulders of limestone turns into massive hills in the sky. You've reached the Alps.");
												Enter();
												Writer("Jumping from rock to rock meters into the air, you start to see monsters in the distance. You ready you blade and flare your WILL, using your power for the ultimate offence.");
												Enter();
												MonsterEncounter(32, 4, 4, "Talus Small", 700F, 90);
												Space();
												Writer("The moving rock was weak, sure, but it was only a baby. More rocks start to move as even the high altitude plants start to grow alive, looking for a snack.");
												Enter();
												Writer("Weaving and dodging on the slippery rocks, you're scathed by a flying rock on the left side of your face, drawing attention to the burn mark on your left chin.");
												Enter();
												Writer("Attempting to keep bad memories at bay, you wildly charge into battle.");
												Enter();
												MonsterEncounter(35, 3, 6, "Talus Medium", 1100F, 110);
												Space();
												Writer("You destroy the Talus as the Vipers attemp to spit acid at your general direction; their pinpoint accuracy suprising you due to their lack of eyes.");
												Enter();
												Writer(name + ": Bet they sense with heat vision...I got it!", 3);
												Enter();
												Writer("Pulling your massive blade in front of your body, you cover your body heat. The Viper's accuracy seems to diminish greatly, but they then resort to spray attacks. Time to face one head on!");
												Enter();
												MonsterEncounter(26, 6, 7, "Viper Planter", 1000F, 60);
												Space();
												Writer("You kill one, but another sprays at your back, burning away at your edgy lether jacket.");
												Enter();
												Writer("Angered at the deterioration of your fasion sense, attack.");
												Enter();
												MonsterEncounter(29, 10, 8, "Viper Planter", 900F, 60);
												Space();
												Writer("It's dead. Both of them are.");
												Enter();
												area = 3;
												Save();
											break;

											case 3:
												Writer("The sun is setting, and you need to go 50 miles before you can rest.");
												Enter();
												Writer("You keep jumping through the Mountains, keeping a steady momentum all the way.");
												Enter();
												Writer("but in the distance, you see a large figure on a flat area standing 19 feet tall.");
												Enter();
												Writer("Standing on an adjecent Mountain, you stand of the outlook of a canyon far below. It becomes clear that whoever was unlucky enough to lose the battle would fumble to their death.");
												Enter();
												Writer("Realizing that sorrounding rocks are actually Taluses and Rockalike observing the battle, you jump on the platform of lime and draw your sword for battle.");
												Enter();
												MonsterEncounter(54, 15, 7, "Talus Large", 3400F, 350, true);
												Space();
												area = 4;
												Save();
											break;

											case 4:
												Writer("After the death of their leader, the Rockalike and Talus of different sizes and shape start to attack you.");
												Enter();
												MonsterEncounter(39, 5, 5, "Talus Medium", 1500F, 2000, false, false, true, 32, 6, 5, "Rockalike");
												Space();
												Writer("Attempting to avoid the onslaught of rock-based creatures, you start sliding down the Plateau and into the canyon below.");
												Enter();
												Writer("A Rockalike and a stomping beast start sliding and rolling next to you, attempting to steamroll you over.");
												Enter();
												Writer("Warding them off with your sword initially, you start to seriously attack.");
												Enter();
												MonsterEncounter(42, 1, 8, "Slow Stomper", 3200F, 50, false, false, true, 12, 35, 4, "Talus Medium");
												Space();
												area = 5;
												Save();
											break;

											case 5:
												Writer("Now halfway down the moutain, you proceed to stride with fast steps while ocassionally jumping to avoid Taluses and now Taradactyls.");
												Enter();
												Writer("The Taradactyl scratches you in the air, causing you to tumble and eventually gain your footing to fight in place.");
												Enter();
												MonsterEncounter(49, 20, 8, "Taradactyl", 2400F, 240, false, false, true, 15, 10, 7, "Rockalike Small");
												Space();
												Writer("Finally reaching the bottom, you can finally relax & catch your breath from what just happened.");
												Enter();
												Writer("But you feel a omninious feeling in the air.");
												Enter();
												//Maximo Boss
												Console.Clear();
												Space();
												Writer("STOMP");
												Thread.Sleep(1200);
												Space();
												Writer("STOMP");
												Thread.Sleep(1200);
												Space();
												Writer("STOMP");
												Thread.Sleep(1200);
												Space();
												Writer("STOMP");
												Thread.Sleep(1000);

												Space();
												Writer("M", 2);
												Thread.Sleep(400);
												Writer("A", 2);
												Thread.Sleep(400);
												Writer("X", 2);
												Thread.Sleep(400);
												Writer("I", 2);
												Thread.Sleep(400);
												Writer("M", 2);
												Thread.Sleep(400);
												Writer("O");
												Thread.Sleep(400);
												Writer("BOSS ENCOUNTER");

												Thread.Sleep(700);
												Writer("STATUS", 2);
												Writer(".", 2);
												Thread.Sleep(700);
												Writer(".", 2);
												Thread.Sleep(700);
												Writer(".", 2);
												Thread.Sleep(900);
												Writer("5354415455533A2046494E450A4142494C4954593A204445544552494F52415445440A434F4E444954494F4E3A205355422D4F5054494D414C0A4F424A4543543A2048554D414E202831364D2920414745202831352841444F4C455343454E542929204142494C495459202841525448555227532057494C4C290A4348414E4345204F4620535543434553533A2033352E3636363637250A57414E5420544F20444F3A204E45474154495645", 2);
												Thread.Sleep(1000);
												Writer("-DEATH", 2);
												Space(3);
												Thread.Sleep(3000);
												ItemUser();
												//MAXIMO ENCOUNTER
												Enter();
												MonsterEncounter(80, 9, 12, "MAXIMO", 7000F, 3000, true);
												Space();
												area = 6;
												Save();
											break;

											case 6:
												//rest
												Writer("With the MAXIMO gone, you see a fortified elevator downroad. By putting your hand on a terminal, the elevator decends the path goes diagonally into the canyon known as DRAGON CLIMB CANYON.");
												Enter();
												Console.Clear();
												Writer("coming out of the steal doors of the elevator, the area immediantly gives an eerie, creepy atmostphere. Scratch marks litter the walls, but they're too steap to climb out of even with climbing gear.");
												Enter();
												MonsterEncounter(43, 9, 12, "Boinker", 3000F, 80, false);
												Space();
												Writer("Stumbling along the path of water that trickles down, you see the holes of dens that monsters and animals could've called home.");
												Enter();
												Writer("But they're empty.");
												Enter();
												MonsterEncounter(1, 10, 20, "Fecies-a-fier", 5000F, 250, false);
												Space();
												Writer("The Fecies-a-fier crowd the upper walls, eating on squirrels and ant colonies that stumble down below or outside their homes.");
												Enter();
												Writer("Deeper in, it gets colder, as you presume it's because the sun is setting, it goes to a chilling 60°F. The light fades as the canyon gets steaper, making you have to walk sideways to get through some gaps.");
												Enter();
												Writer("Through everything, you feel something on your back. A chill that is piercing. You think it's just scratches from the rocks, but it feels like something deeper.");
												Enter();
												MonsterEncounter(45, 8, 8, "Talus Medium-Large", 2000F, 70, false);
												Space();
												area = 7;
												Save();
											break;

											case 7:
												Writer("The sound of rock ran throughout the walls, attracting desperate monsters to fall into the canyon for a meal.");
												Enter();
												Writer("Some feed on the Talus's rocky corpse, others come for red, warm, delicious human meat.");
												Enter();
												MonsterEncounter(50, 27, 5, "Rockalike Large 1", 5000F, 90, false, false, true, 500, 20, 7, "Rockalike Large 2");
												Space();
												Writer("In the rough, you see a cabin owned by a robot.");
												Enter();
												Use(220, 660, 1500, 360, 2000);
												Enter();
												Writer("After shopping, you keep going, 'laying to rest' the mosters you come by.");
												Enter();
												Writer("But the feeling won't go away.");
												Enter();
												Writer("Eventually, the canyon opens up again to a spring pool. You touch it, and it's revealed to be freezing cold, on contrary to what you imagined it would be.");
												Enter();
												Writer("It's here that you look up, revealing an endless hall of chambers locked by dusted security doors. Walking around, you see Fecies-a-fiers, Taluses, Baushables, tens of hundereds of monsters with descriptions and coded names to boot.");
												Enter();
												Writer("You would be circumspectful if not for them being, well...");
												Enter();
												Writer("Not alive.");
												Enter();
												area = 8;
												Save();
											break;

											case 8:
												Console.Clear();
												Writer("Near the end of the hallway, you see an open cage, believing the encapsled moster to be gone, you pay no notice.");
												Enter();
												Writer("You were wrong.");
												Enter();
												Writer("A LandShark soars at you from out of nowhere, and gets a free hit! -9 damage!");
												HP -= 9;
												//player death check
												DeathHandler();
												Enter();
												Writer("The monster is littered with scratches and needle injection marks. The LandShark looks old, and since the species lives to 345, its suffering must have been extended through natural means.");
												Enter();
												Writer("On its head, you see a code name that reads 'FG5432-MURDERER'. The monster looks at you with a glare that reads the feeling of anger and  old, lasting pain; completely livid through clear association of you being a human.");
												Enter();
												Color("bold");
												Writer("Mini-Boss Encounter!");
												Color();
												//Miniboss
												Enter();
												MonsterEncounter(120, 13, 10, "LandShark FG5432-MURDERER", 5000F, 120, true);//LandShark Miniboss
												Space();
												Writer("As the LandShark takes its final breath, and its body becomes still, its face becoming that of relief of its never-ending pain. Amusing how sworn enemies in monsters and humans can connect into such a primal way. The way of old pain one might think would never go away.");
												Enter();
												Writer("But there's a light at the end of the tunnel; ironic considering you're entering into a cave.");
												Enter();
												area = 9;
												Save();
											break;

											case 9:
												Writer("Once again, that chilly feeling starts to reside in your soul, the presence of a looming threat keeps you at your sword handle. Some monsters aproach you, but they are slashed to bits before any semblence battle starts.");
												Enter();
												Writer("You keep walking, listening, brewing a plan for which you will partake when the monster approaches. Your palms are sweating bineith your gloves, legs tightening to anticipate a threat. The presence feels like a never-ending gaze that watches your every movement; stalking you, examining you, feeling you.");
												Enter();
												Writer("M", 2);
												Thread.Sleep(100);
												Writer("a", 2);
												Thread.Sleep(100);
												Writer("k", 2);
												Thread.Sleep(100);
												Writer("i", 2);
												Thread.Sleep(100);
												Writer("n", 2);
												Thread.Sleep(100);
												Writer("g", 2);
												Thread.Sleep(100);
												Writer(" ", 2);
												Thread.Sleep(100);
												Writer("s", 2);
												Thread.Sleep(100);
												Writer("u", 2);
												Thread.Sleep(100);
												Writer("r", 2);
												Thread.Sleep(100);
												Writer("e", 2);
												Thread.Sleep(100);
												Writer(" ", 2);
												Thread.Sleep(100);
												Writer("y", 2);
												Thread.Sleep(100);
												Writer("o", 2);
												Thread.Sleep(100);
												Writer("u", 2);
												Thread.Sleep(100);
												Writer(" ", 2);
												Thread.Sleep(100);
												Writer("a", 2);
												Thread.Sleep(100);
												Writer("r", 2);
												Thread.Sleep(100);
												Writer("e", 2);
												Thread.Sleep(100);
												Writer(" ", 2);
												Thread.Sleep(100);
												Writer("a", 2);
												Thread.Sleep(100);
												Writer(" ", 2);
												Thread.Sleep(100);
												Writer("g", 2);
												Thread.Sleep(100);
												Writer("o", 2);
												Thread.Sleep(100);
												Writer("o", 2);
												Thread.Sleep(100);
												Writer("d", 2);
												Thread.Sleep(100);
												Writer(" ", 2);
												Thread.Sleep(100);
												Writer("m", 2);
												Thread.Sleep(100);
												Writer("e", 2);
												Thread.Sleep(100);
												Writer("a", 2);
												Thread.Sleep(100);
												Writer("l", 2);
												Thread.Sleep(100);
												Writer(".", 2);
												Thread.Sleep(900);
												Space();

												MonsterEncounter(140, 9, 11, "Young Dragon", 3000F, 300, false);//Young Dragon Miniboss
												Space();
												Thread.Sleep(300);
												Writer(".", 2);
												Thread.Sleep(300);
												Writer(".", 2);
												Thread.Sleep(300);
												Writer(".", 2);
												Thread.Sleep(900);

												Writer(name + ": What was that?", 3);
												Enter();
												area = 10;
												Save();
											break;

											case 10:
												Writer(name + ": This tingling feeling...It's unatural.", 3);
												Enter();
												Writer(name + ": It lingers still, wanting me, waiting for me.", 3);
												Enter();
												Writer("It is then that you realize that you were walking down the path, right into a cave.");
												Enter();
												Writer("The presence you've been feeling starts to hurt, an sharp pain that locks your muscles and tightens you up. An electryfying feeling that diffuses about your body.");
												Enter();
												Writer("You look above yourself");
												Enter();
												Writer("A majestic monster growls to your very presence, dripping spit from its mouth. It's bright yellow scales stand out to the cold atmostphere, electric energy and WILL coursing throughout its body. It's not so scary to you as it's eye opening how awesome DRAGONS are. Nonetheless, you  make your way to slay it and finally rid yourself of this aweful, terrible, horrifying feeling.");
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
												Writer("With your sword drawn, you walk into the unkown, waiting to meet your foe.", 2);
												Space();
												Enter();
												ItemUser();
												Console.Clear();
												MonsterEncounter(190, 10, 15, "Thunder DRAGON", 50000F, 5000, true);//Thunder DRAGON fight
												Space(3);
												Writer("After the death of the dragon, you make your way out of the cave.");
												Enter();
												Writer("The light blinding, you make your way out of the valley, and and you find yourself at the doorsetep of the city. Read to fight...");
												Enter();
												Writer("THE DRAGON");
												area = 0;
												From[1] = true;
												Save();
												EndGame();
												Credits();
												End();
											break;
										}
									break;
				
									default:
										Space();
										ErrorWrite();
										Space();
										Writer("Hello, " + name + "! There is a DRAGON, and it needs to be slain!  Where shall you go to give it their deserved fate?"); //options to go first
										Space();
										Color("cyan");
										Writer(go1[0] + ", 1");
										Color("yellow");
										Writer(go1[1] + ", 2");
										Color("green");
										Writer(go1[2] + ", 3");
										Color("null");
										Space();
										Choose = Reader();
									break;
								}
							}
							else
							{
								EndGame();
								Credits();
								End();
							}
						}
					}
					else if(Chose == "2" && hasStarted == true)//selects new game, wiping save
					{
						Space();
						Console.Clear();
						stop = false;

						while(stop == false)
						{
							Writer("Please enter your Username: ", 2);
							name = Console.ReadLine();
							Space();
							Greetings();
							stop = true;
						}

						stop2 = false;

						while(stop2 == false)
						{
							Writer("Do you want tutorials? (type yes or no)");
							Space();
							option = Console.ReadLine();
							switch(option)
							{
								case "1":
								case "y":
								case "yes":
								case "Yes":
								case "YES":
									stop2 = true;
								break;

								case "2":
								case "n":
								case "no":
								case "No":
								case "NO":
									for(int i = 0; i < firstTime.Length; i++)
									{
										firstTime[i] = false;
									}
									stop2 = true;
								break;

								default:
									ErrorWrite();
								break;
							}
						}
						Space();
						Greetings2();
						Writer("Hello, " + name + "! There is a DRAGON, and it needs to be slain! Where shall you go to give it their deserved fate?"); //options to go first

						Space();

						Color("cyan");
						Writer(go1[0] + ", 1");
						Color("yellow");
						Writer(go1[1] + ", 2");
						Color("green");
						Writer(go1[2] + ", 3");
						Color("null");

						Space();
						Choose = Console.ReadLine();
						hasStarted = true;
						goAnyway = true;

						Save();
						CertainSerialSave();
					}
					else if(Chose == "1" && hasStarted == false)//chooses new game for the first time
					{
						Space();
						Console.Clear();
						if(hasStarted == false)
						{
							stop = false;

							while(stop == false)
							{
								Writer("Please enter your Username: ", 2);
								name = Console.ReadLine();
								Space();
								Greetings();
								stop = true;
							}

							stop2 = false;

							while(stop2 == false)
							{
								Writer("Do you want tutorials? (type yes or no)");
								Space();
								option = Console.ReadLine();
								switch(option)
								{
									case "1":
									case "y":
									case "yes":
									case "Yes":
									case "YES":
										stop2 = true;
									break;

									case "2":
									case "n":
									case "no":
									case "No":
									case "NO":
										for(int i = 0; i < firstTime.Length; i++)
										{
											firstTime[i] = false;
										}
										stop2 = true;
									break;

									default:
										ErrorWrite();
									break;
								}
							}
						}

						Space();
						Greetings2();
						Writer("Hello, " + name + "! There is a DRAGON, and it needs to be slain! Where shall you go to give it their deserved fate?"); //options to 	go first
						Space();

						Color("cyan");
						Writer(go1[0] + ", 1");
						Color("yellow");
						Writer(go1[1] + ", 2");
						Color("green");
						Writer(go1[2] + ", 3");
						Color("null");

						Space();
						Choose = Reader();
						hasStarted = true;

						Save();
						CertainSerialSave();
					}
					else
					{
						ErrorWrite();
						if(hasStarted == true)
						{
							Writer("CONTINUE, 1");
							Writer("NEW GAME, 2");
						}
						else
						{
							Writer("NEW GAME, 1");
						}

						Space();
						Chose = Reader();
					}
				}
			}
		}
	}
}

