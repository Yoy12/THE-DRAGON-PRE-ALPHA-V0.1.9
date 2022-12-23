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
		//endgame guys
		//also may be kaizo
		public static void EndGame()
		{
			ending[0] = true;
			Console.Clear();
			bool googagooga = false;
			while(googagooga == false)
			{
			if(From[0] == true)//springs help/1
			{

			}
			else if(From[1] == true)//hills
			{

			}
			else if(From[2] == true)//forests Mountains
			{
				while(ending[1] == false)
				{
					HP = HEARTS - 4;
					switch(area)
					{
						case 0:
							Save();
							hasStarted = true;
							CertainSerialSave();
							Writer("After a week of journeying, you are slightly tattered but otherwise fine.");
							Enter();
							Writer("In the distance, you see a silhouette of a figure, tall and strong. Massive in stature and awesome in strength, bulging muscles covering his frame.");
							Enter();
							Writer("Man the Man: Little man, why you come here?", 3);
							Enter();
							Writer(name + ": Why do you have a russian accent? Isn't this place French?", 3);
							Enter();
							Writer("Man the Man: Quiet Little man. I know who I am and yet you no NOTHING. I wil grind you into litle tiny part. You will never see your mama again, fied.", 3);
							Enter();
							MonsterEncounter(160, 25, 15, "Man the Man", 3000F, 1200, true);

							Space();
							Writer("Man the little man: Raugh! Big man, you are powerful! I never think you to be powerful, big man. In sight of you, I am tiny.", 3);
							Enter();
							Writer(name + ": Ok. So anyway, where the FRICK is THE DRAG-", 3);
							ThrDot();
							Space();
							Writer("The ground rumbles, the man falls, while you stand in a tense position, readying your sword for battle.");
							Enter();
							Writer("Helecopters, Bombers, and Fighter planes fly behind you with swordsmen on top, piecing the air with their mach 20 speeds as their eargrading sound drags behind like paper in the wind.");
							Enter();
							Writer("You look towards where they're heading.");
							Enter();
							Writer("A massive dragon the size of a quarter of the inner sector silhouettes the sky. Climbing a tower, smashing another with its massive wings, it's glowing eyes illuminating its crimson red-stained mouth with the shreaded clothing of its victims swaying in the wind. Its body red as a gleaming ruby, its belly yellow as a fine topaz-gold, its body is magestic in the very definition of the word, only uncomplimented by its cruel carnivorous nature.");
							Enter();

							Writer(name + " [in awe]: Oh my God...", 3);
							Enter();
							Writer("Man the little man: You come for DRAGON, no? Do not fear innevitable, yes? Stop quivering like a little man.", 3);
							Enter();
							Writer(name + ": Hmph.", 3);
							Enter();
							Writer("Man the little man: Well, very not nice to see you. Hope you die so I get Деньги!", 3);
							Writer(name + ": Ok...?", 3);
							Enter();
							area = 1;
							Save();
						break;

						case 1:
							Console.Clear();
							Writer("From the bay, you continue your journey, now litterily in sight of THE DRAGON.");
							Enter();
							Writer("Person: My mom's in the city center! You have to get her out!", 3);
							Space();
							Writer("Another Person: Please...don't let my husband die...", 3);
							Space();
							Writer("Yet Another Person: Don't let him destroy my workplace!! Don't you see?! My income will be ruined!! Why can't you stop it now?!!", 3);
							Enter();
							Writer("Gaurding Police Officer [stressed, attemping to calm residents]: We're doing everything we can in order to make sure the Dragon is defeated. Please remain calm and keep hope the situation can be stabilized.", 3);
							Enter();
							Writer(name + ": ...", 3);
							Writer("The yells ard cries of the people aren't silent, as the dusk breaks and the sun sets on their hopes and their dreams. You carry on.");
							Enter();
							Writer("As you walk on the pearly-sand shores, you stumble apon a swordsman on the shore. Two men handling pretty roughly ― with a gun.");
							Enter();
							Writer("Pirate: End of the line, bukkee!", 3);
							Writer("Before he can take the shot, you tank it with your massive greatblade Maldur.");
							Enter();
							Writer("Pirate: What eu' doin', bukkee? Tryn' steal our stoay' kil'? Ell' not toay'!", 3);
							Enter();
							Writer("Pirate: Let's ", 4);
							Color("yellow");
							Writer("[13]", 4);
							Color();
							Writer(" em' up, mate!", 4);
							Space(2);
							Writer("Pirate 2: Oy!", 3);
							Enter();
							MonsterEncounter(85, 25, 12, "Betsy the Cook", 3000F, 1200, true, false, true, 75, 60, 20, "Cranky the Crook");
							Space();
							area = 2;
							Save();
						break;

						case 2:
							Writer("Betsy: But...But how!", 3);
							Enter();
							Writer("Betsy: We tagg teamed him...but still...lost!", 3);
							Enter();
							Writer("Betsy: Right, Cranky?", 3);
							Enter();
							Writer("*Cranky chillin' by being dead*", 3);
							Enter();
							Writer("Betsy: NOOOO!!! CRANKYYYY!!!", 3);
							Space();
							Writer("You proceed to break his neck.");
							Enter();
							Writer("The unconcious swordsman immediately backflips up, likely from muscle memory, probably from being subject to the sudden commotion.");
							Enter();
							Writer("Swordsman: Reaugh...what happened...", 3);
							Space();
							Writer("You instinctivly ready into a battle stance, startled by his overwhelming WILL.");
							Enter();
							Writer("The swordsman takes the stance as a challenge.");
							Space();
							Writer("Swordsman: Ohhh, so if it's a battle you want...IT'S A BATTLE YOU'LL GET!!!", 3);
							MonsterEncounter(150, 75, 18, "Mysterious Rowdy Swordsman", 5600F, 4000, true);
							Space();
							area = 3;
							Save();
						break;

						case 3:
							Writer("Swordsman [tired]: huff..puff...", 3);
							Enter();
							Writer(name + ": Why are you saying huff puff-", 3);
							Thread.Sleep(800);
							Writer("Swordsman: Wow! You really are tough! I thought I could catch you by suprise by jumping up for battle, but I was wrong, I guess.", 3);
							Enter();
							Writer(name + " [cocky]: Indeed you are.", 3);
							Color("bold");
							Writer(name + " [thinking]: How were you catching me by suprise? You said that I initiated the battle!", 3);
							Color();
							Enter();
							Writer("Mark: So! my name's...I think...Mark? I'm...a swordsman...maybe? I dunno...my memory's all fuzzy, it's like I can't grasp onto any one of them. [embarrassed] H-How about you?", 3);
							Enter();
							Writer(name + ": My name's " + name + ", and I am the swordsman that will defeat the Dragon.", 3);
							Enter();
							Writer("Mark: Awesome! How about we go to dinner my treat. After all, you saved me!", 3);
							Enter();
							Writer(name + ": Hmmph.", 3);
							Enter();
							Console.Clear();
							Color("bold");
							Writer(name + " [thinking]: I said THE DRAGON Wrong, but he didn't care. All the real swordsmen know how to say it, so something must be wrong.", 3);
							Enter();
							//city suberbs
							Console.Clear();
							if(HP < HEARTS)
							{
								HP = HEARTS;
							}
							Writer("Inside the cabin, you begin to relax and see fine dinning tables and a shop in the back.");
							Enter();
							Writer("Mark: Feel free to shop, if you'd like!", 3);
							Enter();
							Writer("You decide to feel free to shop, if you'd like.");
							Enter();
							Use(550, 650, 900, 720, 1540);
							Enter();
							Writer("Mark: So...where you from?", 3);
							Enter();
							Writer(name + ": Nabletown, Massachusetts Colony. So technically I'm English.", 3);
							Enter();
							Writer("Mark: Wow! I...may have been there before...", 3);
							Space();
							Writer("Just then, the orders came from the waiter.");
							Enter();
							Writer("Waiter: Thank you for dinning at Sunflower Garden.", 3);
							Enter();
							Writer("You glance at the waiter. Something seems off about him to you. No, not that.");
							Enter();
							Writer("Something seems familiar.");
							Enter();
							Writer("Mark: Thank you!", 3);
							Enter();
							Writer("Mark: I honestly don't remember much from where I came from. It feels like I never did. But...I also feel I'm missing something, missing a part of me. Something happened on that ship that made me loose my memory.", 3);
							Enter();
							Writer(name + " [prying for information]: What ship? How'd you get there?", 3);
							Enter();
							Writer("Mark [trying to avoid memory questions]: Welll...this food is delicious! [stuffing his face] Mmmmh...Ummmph...So...Delicious!", 3);
							Enter();
							Writer(name + ": ...", 3);
							Enter();
							Writer("After dining, you and Mark meet outside.");
							Enter();
							area = 4;
							Save();
						break;

						case 4:
							Writer("Mark: So, what's the plan for defeating The Dragon?", 3);
							Enter();
							Writer(name + ": It's THE DRAGON, and why are you helping me? I have no intention of splitting the money.", 3);
							Enter();
							Writer("Mark [puzzled]: But...you...[regaining composure] anyway, I wasn't in it for the money. I just wanted something to test my skill. After all, that's what being a swordsman is all about, right?", 3);
							Writer(name + ": Sure...but you know it'll be hard, and that's why I was wondering why you'd-", 3);
							Enter();
							Writer("Mark is pummled to the adjecent building.");
							Enter();
							Writer("You pull your sword out in anticipation of attack.");
							Writer("Puncher: GAHAHAHAHAHHAHAHAHAHAHAHAAAAAAAAAA!!! SOME FRESH MEAT I SEE?! WELL, I GUESS IT'S TIME FOR SOME GOOD OL' PUMMELED CHICKEN!!", 3);
							Enter();
							Writer("Mark [wiping the blood trickling off his mouth, standing using the building]: Who is this guy?", 3);
							Enter();
							Writer("Upon closer inspection, you realize something terrible.");
							Enter();
							Writer(name + " [shocked, frightened]: Y-you...", 3);
							Writer("Peter Puncher: " + name.ToUpper() + "...", 3);
							Enter();
							Writer("Peter Puncher: HOW DARE YOU COME TO THIS REGION??!!!", 3);
							Enter();
							Writer("You drop your sword, stunned in true fear. Your breathing quickens, your heart rate slows, you feel your palms sweat and turn into a river next to your sahara of a mouth.");
							Enter();
							Writer("Mark decides to take action. He lunges at the foe, shoots his grappling hook into Peter's massive arm and lanches him into the air. With a single leaping swipe Mark does massive damage to Peter's chest.");
							Enter();
							Writer("Peter becomes livid and grabs Mark's neck. The ground becoming closer, Peter drives Mark head first into the cobbled road. Debris flies everywhere, and you stumble to the ground as smoke fills the air.");
							Enter();
							Writer("You're still shaking from fear.");
							Enter();
							Color("yellow");
							Writer(name + " [thinking, freaking out]: Why would he do this? Why would he track us down? WHY IS HE LIKE THIS??", 3);
							Color();
							Enter();
							Writer("Peter Puncher: Wanna know why I hate you so much? YOU THINK UR' SUUUUCH A VICTIM. CRYN' TO UR' MOM ABOUT YOUR DUMBA** DAD every time he so much as LOOKS AT YOU FUNNY!! I HATE YOU, Ark. I HATE YOU!!!", 3);
							Enter();
							Writer("Peter Puncher: NOW...FOR SOME OL' SPECIALTY PUMMLED CHICKEN!!!", 3);
							Space();
							Writer("He then pulls up Mark by the arm a punches him over and over. His comatose body being knocked senseless by a raging psycopath.");
							Enter();
							Writer(name + " [in fear]:...no...dammit...why...?", 3);
							Enter();
							Writer("Puncher: AHAHAHAHAHAHAHAHHAHAHA, WELL, DON'T SEEM TO LIKE IT HUH?? TOOOOO BAAAAD!!!", 3);
							Enter();
							Writer("Peter them takes a boulder the size of Mark and slams it into his face.");
							Enter();
							Writer("GAAHAHA CHAAHAH GWAHAHAHAHAHAHAHAHAHAAHHAHAAAAAAAAAAAAAAAAA!!!!!!!!", 3);
							Enter();
							Writer("The last straw.");
							Enter();
							Writer("You just met Mark a few hours ago, but for some reason, you feel an inbridled rage. I feeling inside wells up, and all you can see is red. As Peter continues to ravage what seems to be a lifeless corpse, you stand up.");
							Enter();
							Writer("With your fists clenched so hard they draw blood through your gloves, you slug Peter through Sunflower Gardens. People running for their lives, and pick up your sword and ready to fight.");
							Enter();
							Writer(name + ": DIE...", 3);
							Enter();
							Writer("LITERAL Monster Encounter!");
							Enter();
							MonsterEncounter(340, 79, 20, "Peter Puncher the Cannibal Boxer", 4000F, 4000, true);
							Space();
							area = 5;
							Save();
						break;

						case 5:
							Writer("You're in blind rage. Mark is bleeding out on the floor, but he is of least concern to youright now. You barely know him, but you're still livid with unhinged INTENT TO KILL.");
							Enter();
							Writer("You take one step, your WILL flaring and you muscles bulging.");
							Enter();
							Writer("You take another step, remember all that had tooken EVERYTHING from you in the past.");
							Enter();
							Writer("Another step. FATHER, BROTHER, HOW COULD YOU LIE TO ME?! HOW COULD YOU STAND BY MY SIDE AND YET STILL WRONG ME?! SEND ME AWAY?! ALLOW MOTHER TO DIE??!! WITH A LOOK IN YOUR EYES OF REGRET?! HOW COULD YOU????!!!!");
							Enter();
							Writer("A final step. Your sword glares, not it's normal tint of refined silver, but blood.");
							Enter();
							Color("red");
							Writer("You slash at his feet, abutating them.");
							Writer("Peter: PLEASE STOP!!! GRAAAUUUGHH! IT HURTS! IT HURTS!", 3);
							Enter();
							Writer("You cut off his hands. His red blood only reminding you of what you did to him. To father.");
							Enter();
							Writer(name + " [in his head, going ballistic]: No, HE DESERVED IT!! THAT BASTARD DID NOT DESERVE ANOTHER WAKING MOMENT!!", 3);
							Enter();
							Writer("You slash away his arms. He's bleeding out. Both of them are. But you have to prolong it. His SUFFERING.");
							Enter();
							Writer("You cut away not his feet, but his entire lower body. only his chest and head remains. his stomach, spleen, and liver are leaking out. His screams are dimming. He's dying. But you're not done with him yet.");
							Enter();
							Writer("You punch him. Again, and again, and again in what little body he has left. You crying. Everything around you is fading away. Mark, the dessimated Cabin, everything. You feel your heartbeat in your head, you're thinking back to your father who left you. You...you...YOU...");
							Enter();
							Color();
							Writer("You stop.");
							Enter();
							Writer("He's been dead for an hour now. You've been punching his dead body, you dumbarse.");
							Enter();
							Writer("That wasn't \"my\" voice though. It was Mark's.");
							Enter();
							area = 6;
							Save();
						break;

						case 6:
							Console.Clear();
							//job offer/imprisoned
							Writer("Mark is kneeling right beside you. While is more fatal wounds have been healed using potion pluses, he still steems to be battered up.");
							Enter();
							Writer("Mark: I must've been out for, huh? You ok? I saw what you did to that monster.", 3);
							Enter();
							Writer("You look at your hands. Skin dyed red and wet blood stretch all the way to your ankles, the body you'd been pummling more pulpish than Mark's face. Your knuckles are stinging, if not bleeding. It's hard to tell with all of Pete's blood. You're also exhausted.");
							Enter();
							Writer(name + " [hyperventilating]: I...sorry...I...I was...I'm...!", 3);
							Enter();
							Writer("Mark hugs you as he winces from pain.");
							Enter();
							Writer("Mark: It's ok. Whatever happens, we're a team.", 3);
							Enter();
							Writer(name + " [jokingly]: Gae.", 3);
							Enter();
							Writer("Mark slaps you out of his arms.");
							Enter();
							Writer(name + ": But why...?", 3);
							Enter();
							Writer("Mark: Because you're a friend. And true friends got each other's backs.", 3);
							Writer("Mark [jokingly]: Which means you owe me one!", 3);
							Enter();
							Writer(name + ": Grrr...", 3);
							Enter();
							Writer("You get up, blood on your arms, but not tainting the person you are at your core, a humble ", 2);
							Color("bold");
							Writer("\"hero\"", 2);
							Color();
							Space();
							Enter();
							Writer("Then the police came.");
							Enter();
							area = 7;
							Save();
						break;

						case 7:
							Console.Clear();
							Writer("You fight for yourself.");
							MonsterEncounter(90, 50, 10, "Popo Paul", 6000F, 300, true, true);
							Space();
							Writer("You slash and you swipe.");
							Enter();
							MonsterEncounter(90, 50, 10, "Popo Pete", 6000F, 300, true);
							Space();
							Writer("But they were too much.");
							Enter();
							MonsterEncounter(90, 50, 10, "Popo Percy", 6000F, 300, true);
							Space();
							Writer("And you were captured by the police.");
							Enter();
							//imprisioned
							Console.Clear();
							Writer("Mark: Rrraaughh...", 3);
							Space();
							Writer("Mark wakes up.");
							Enter();
							Writer("Mark [confused]: Guuagghh...Where...am I?", 3);
							Enter();
							Writer("Mark looks around to see his inprisionment; his cage. Although he remembered that hed had liked birds, he never wanted to be in their shoes.");
							Enter();
							Writer("Mark: Well, what a predicement, huh?", 3);
							Enter();
							Writer(name + ": It seems so...", 3);
							Enter();
							Writer("Mark turns around to see you, drowsy and whipped, sitting cross-legged on the floor with your back turned to him; only giving a backward glace back.");
							Enter();
							area = 8;
							Save();
						break;

						case 8:
							Writer("Mark: What...what did they DO you?", 3);
							Enter();
							Writer(name + ": They knocked me unconscious. Guess to hell with necessary force.", 3);
							Writer("Mark: How could they do that?", 3);
							Enter();
							Writer("Mark looks around again. Creeping as close as he can the the bars locking him in, not too close due to the chains conencted to the wall, he peers through; dripping pipes create a stressed atmosphere, and the muttering of guardsmen rings down the broken concrete walls. Mark had before heard a man making a choking sound, but it's gone now.");
							Enter();
							Writer("Macaroni Speaker: *section 35, inmate 249 kill-I mean exterminated. Available staff clean up the body.*", 3);
							Enter();
							Writer("You and Mark then heard the chattering stop and the stomping of clad boots on the floor. You also see a rat crawl by.");
							Enter();
							if(WILL > 0)
							{
								Writer("You snatch the rat using your WILL, break its neck and bring it over.");
								Enter();
								WILL -= 2;
								if(WILL < 0)
								{
									WILL = 0;
								}
							}
							else
							{
								Writer("Mark proceeds to use his proficiency with animal coorsion to bring it to him. You then grab the squirming creature and break its neck, ending its life to the horror of Mark.");
								Enter();
								Writer("Mark [annoyed]: You didn't have to do THAT, you know!!", 3);
								Writer(name + ": This rat can be useful. Besides, you don't really have a relationship with it, do you?", 3);
								Enter();
								Writer("Mark [crossing arms, looking away]: Grrr...", 3);
								Enter();
							}
							Writer("With your newly found kill's spine, you slowly cut it's femur out of it's leg, shape it into a small dagger, and slowly cut the chains on your wrists and ankles.");
							Enter();
							Color("bold");
							Writer("4 HOURS LATER...");
							Color();
							Space();
							Writer("You've made not a lot of progress in your cell, cutting away to Mark's unending banging on the walls of your cell. You notice that your cell is known as 'cell 74', and you are inmate 264 and Mark is 263. It seems they get a lot of inmates in this prison.");
							Enter();
							Color("bold");
							Writer("10 HOURS LATER...");
							Color();
							Thread.Sleep(1000);
							Space();
							Writer("You've cut through one part of the chain, and are weakening the other part. You nearly get caught for the smelling rat carcus, but luckly the gaurd that came in did not notice the femur (you have pockets) or the weakened ankle chain.");
							Enter();
							Color("bold");
							Writer("26 HOURS LATER...");
							Color();
							Thread.Sleep(1000);
							Space();
							Writer("It's the next day from when you've been admitted for 20 years in prison. You tried to cut first thing in the morning, but you had to go for roll call, breakfast, and work before you had the chance to go back to your cell 5 hours later. Your ankle chain is now weakened enough so that you could yank it out, so there's only three to go...");
							Enter();
							Color("bold");
							Writer("49 HOURS LATER");
							Thread.Sleep(1000);
							Color();
							Space();
							Writer("Day three of being locked up. You overslept in the morning, so you got beat. after, you were punished by having to skip breakfast. You worked extra long too, so it took a while before you could get back to cutting. Mark made some new friends, and he can't stop talking about this one guy who stood up for him at lunch. You told him he's a swordsman, and should not need people to stand up for him. Mark responds by telling you that although he may not remember much, he still knows that's not what a swordsman is all about.");
							Enter();
							Color("red");
							Writer("131 HOURS LATER");
							Thread.Sleep(1000);
							Color();
							Space();
							ATK -= 8;
							Writer("End of the week, and you can hear the echoes of fighter pilots crashing on the outside. You've loss muscle mass by a little bit of a margin, and your mental health has only deteriorated further. If not for Mark, you could've been completely insane by now. Rumor has it the Warden's boss is coming to specifically see the \"murderer\" of Pete the Puncher, and how a \"canadate\" managed to be off the grid for so long. Turns out, it's gonna happen tomorrow.");
							Enter();
							area = 9;
							Save();
						break;

						case 9:
							//breakout
							Console.Clear();
							Color("red");
							Writer("150 HOURS LATER...");
							Color();
							Thread.Sleep(2000);
							Enter();
							Writer("You wake up, things are different. Instead of waking up to the normal, cruel, empty atmostphere, you wake up to gunshots, bloodcurdling screams, and violence.");
							Enter();
							Writer("And someone's at your door, with Mark hostage; his hand holding both of Mark's tight.");
							Enter();
							Writer("Governor: Greetings, " + name + ". I am the Prison Governor. It is a...not so much an honor...but an experience to meet you.", 3);
							Enter();
							Writer(name + " [concerned]: What's happening out there? And what are you doing to Mark?!", 3);
							Space();
							Writer("Governor: All will be answered in time, " + name + ", but for now, I would like to have a chat with you.", 3);
							Enter();
							Writer("Mark struggles as the Governor attempts to hold him.");
							Space();
							Writer("Mark: Don't listen to him! He has alternative motives! ALTERNATIVE MOTIVES!!", 3);
							Enter();
							Writer("Governor: Quiet, you.", 3);
							Space();
							Writer("He, with one swift strike to the neck, knocks Mark out.");
							Enter();
							Writer(name + " [angered]: What do you want?!", 3);
							Space();
							Writer("Governor: Well, simple, really. I want you.", 3);
							Enter();
							Writer(name + " [sarcastic]: I'm not gay.", 3);
							Enter();
							Writer("Governor [amused, aroused??]: Oh, no. On the contraire, " + name + ". I mearely want your power, your skill to enforce. The aura you give off is strong, confident. Something the police force could use in their ranks.", 3);
							Enter();
							Writer(name + ": I'm still getting gay vibes, but whatever. I'm not a policeman. I'm a mercinary, and swordsman like no other. I don't need to get a paycheck and a uniform to be great or to be remembered. I can do that on my own.", 3);
							Thread.Sleep(800);
							Space();
							Writer(name + ": That's how I always rolled...", 3);
							Enter();
							Writer("Governor [actually aroused]: Well, I never expected a yes from you, so I'll just have to convince you over a period.", 3);
							Enter();
							Color("bold");
							Writer("Governor: By any means necessary.", 3);
							Color();
							Enter();
							Writer("The Governor proceeds to punch you in the gut. While it knocks the wind out of you, it does less than expected. You've seen Bushables his harder than this.");
							Enter();
							//goTime
							Writer("Governor: Now, I'll visit you once this...situation...is under control.", 3);
							Space();
							Writer("Mark then kicks the Governor so hard he gets smashed headfirst into the concrete ceiling.");
							Enter();
							area = 10;
							Save();
						break;

						case 10:
							Writer("Mark: " + name + ", we gotta go.", 3);
							Space();
							Writer(name + ": How...Right!", 3);
							Space();
							Writer("You blast off, breaking off your chains and getting ready for battle.");
							Enter();
							Writer("You run down the nearest hall, but encounter gaurds.");
							Space();
							Writer(name + ": Dammit, I don't have my sword!", 3);
							Space();
							Writer("Mark: You don't need a sword to be awesome! Just watch!", 3);
							Enter();
							Writer("The gaurds pull out extendable metal rods and prepare for battle themselves.");
							Enter();
							Writer("Male Gaurd: PULL OVE...I mean STAND DOWN!!", 3);
							Space();
							Writer("Shy Male Gaurd: Y-Yeah!", 3);
							Enter();
							MonsterEncounter(100, 20, 6, "Gaurd #718", 9000F, 400, true, true, true, 80, 12, 9, "(Shy) Gaurd #920");
							Space();
							Writer(name + ": I'm Not as strong as I should be...", 3);
							Space();
							Writer("Mark: But they're crappers, too, so come on! We still have to figure out where to get our stuff!", 3);
							Enter();
							Writer("You run through the clostrophobic halls, looking through room after identical room. You find a bathroom, the workrooms, and an office.");
							Enter();
							Writer("OH CRAP AN OFFICE-");
							Thread.Sleep(600);
							MonsterEncounter(70, 40, 9, "Gaurd #345", 4500F, 600, true, true, false);
							Space();
							Writer("Mark: That was a stupid idea.", 3);
							Space();
							Writer(name + ": Tell me about it...", 3);
							Enter();
							Writer("Continuing down the halls, you find the clothing room, and some gaurds with who you can assume to be the Prison Warden.");
							Enter();
							Writer("Warden: You're not escaping. The Governor has set everything as it should be, and you are merely going by memory of your short week here. Perhaps next time you'll have a better knowledge of this place. Too bad you'll be in for life after this!", 3);
							Enter();
							Writer("Mark: We ain't surrendering to your hunky-dunky sorry arse! I'll stick my finger up your butt before you ever get the pleasure of bringing us behind bars!", 3);
							Space();
							Writer(name + ": Besides, you've been using lethal force this entire time. Were you really trying to capture us, or is it something else?", 3);
							Enter();
							Writer("Warden: I've been doing everything I've been told to do by the Governor. From the defense of the building from those weird anime swordsman, to stopping you from ever exiting the building. Did you really think that you found this room by pure chance? We've set up a controlled environment inside this facility to make sure you never escape. Every time you think you have the upper hand is fabricated to make our victory over you sweeted.", 3);
							Enter();
							Writer("Warden: And when everything has been taken away from you, candidate, your only option will be to come to us.", 3);
							Space();
							Writer("THE DRAGON roars as the battle stages itself. This underground facility shakes, proving its shottiness as rubble falls from the ceiling. You ready your hands, bloodied from brawling, as the addreneline flows through your body.");
							Enter();
							Writer("And you start to remember.");
							Enter();
							area = 11;
							Save();
						break;

						case 11:
							//memories
							Console.Clear();
							Color("green");
							Writer("A young " + name + " runs towards his house. He carries a exotic bug and a pack of wine.");
							Enter();
							Writer(name + ": Mom! I'm home!", 3);
							Space();
							Writer("Mom [divided attention on computer]: Welcome home, Sammy. How was your day out?", 3);
							Enter();
							Writer(name + "'s father enters the room, his face stern and unshaven with a sleevless undershirt covered in sweat.");
							Thread.Sleep(1500);
							Space();
							Writer("Father: Beer?", 3);
							Space();
							Writer(name + " [unamused]: Here, Dad.", 3);
							Space();
							Writer(name + " then hands in the 12-pack of beer.", 3);
							Enter();
							Writer("Father [mumbling]: Should make these in 24-packs...", 3);
							Space();
							Writer("He then leaves the room, opening the pack with his bear hands, and immediantly gobbling a whole bottle.");
							Enter();
							Writer(name + ": Mom! look what I found!", 3);
							Space();
							Writer("The exited child then unclotches his hand to reveal a bettle with pale eyes.");
							Enter();
							Writer(name + ": It's so cool, isn't it Mom?", 3);
							Enter();
							Writer("Mom [stressed]: That's great honey, but I need to work on this right now. There's a due date for this project, and I have to present the city papers to the clients by Fizzlesday.", 3);
							Space();
							Writer(name + " [dissapointed]: But Mooom, it's only Tanderday! You have plenty of time!", 3);
							Enter();
							Writer("Mom: I'm sorry honey...why don't you talk to your father?", 3);
							Space();
							Writer(name + " [adamant]: But I HATE Dad! He just drinks that expired grape juice and italian apple cider all day. I tasted it once, and I spit it out because it was NASTY!!", 3);
							Enter();
							Writer("Mom [shocked]: YOU DRANK WI-...expired grape juice?! I told you not to do that!", 3);
							Space();
							Writer(name + " [looking down]: I'm sorry...", 3);
							Enter();
							area = 12;
							Save();
						break;

						case 12:
							//escape
							Console.Clear();
							Color();
							Writer("You put your hand on your temple, hit with a vivid memory.");
							Enter();
							Writer(name + ": Raughh...", 3);
							Enter();
							Writer("Mark: You ok, " + name + "?", 3);
							Enter();
							Writer(name + ": Yeah, I'm FINE!!", 3);
							Space();
							Writer("You say as to throw a mean left hook at the Warden, which he cleanly blocks and holds with his hand.");
							Enter();
							Writer("Warden: It'll take more than that to bring me down, candidate!", 3);
							Enter();
							ItemUser();
							MonsterEncounter(260, 50, 12, "Thug Penetenary Prison Warden Roger Green", 12000F, 9000, true,true, true, 80, 25, 5, "Gaurd #3 (Benny Green)");
							Space();
							area = 13;
							Save();
						break;

						case 13:
							Writer("Warden Green: Dammit...I failed you...Governor...", 3);
							Enter();
							Writer("Mark: Wooohoo!! THAT'S waht you get for trying to take us down!", 3);
							Enter();
							Writer(name + ": Hmph.", 3);
							Space();
							Writer("You then both equip your gear, increasing your attack to normal.");
							ATK += 8;
							Enter();
							Writer("Mark: So now what?", 3);
							Space();
							Writer(name + ": I dunno. Guess we leave and go to THE DRAGON.", 3);
							Enter();
							Writer("Governor: I don't think so...", 3);
							Enter();
							Writer("You both look behind you as a massive Gundam-like armor suit blasts through the comparibly tiny door, blasting you two comparibly tiny teenagers away.");
							Enter();
							Writer(name + ": Dammit, can't you just leave us alone?! Whad'd we do to you besides what we're going to now!", 3);
							Space();
							Writer("Governor: What you did is threaten my perfect crime-er penetentary streak!", 3);
							Enter();
							Color("bold");
							Writer("NOW FALL AT MY FEET!", 3);
							Color();
							Enter();
							Writer("The floor lowers to reveal a tennis court sized battlegrounds as field lights illuminate the incoming action. Tubes filled with lava slug their way around the area, as the \"Gundam\" Prepares for attack.");
							Enter();
							Writer("BOSS ENCOUNTER!!");
							ItemUser();
							MonsterEncounter(470, 90, 7, "War Robot Governor", 9000F, 4000, true, true, false);
							Space();
							area = 14;
							Save();
						break;

						case 14:
							Writer("Governor: NOOOOOOOOOOOOO!!! HOW COULD THIS BEEE???!!!", 3);
							Enter();
							Writer(name + ": Dude, it's not a big deal-", 3);
							Space();
							Writer("Governor: NOOOOOOOOOOOOOOOOOO!!!!", 3);
							Enter();
							Writer("Governor: If I can't have MY WAY...I'LL LET NO ONE HAVE THEIR WAY!!!", 3);
							Enter();
							Writer("Mark: What-", 3);
							Thread.Sleep(100);
							Console.Clear();
							Color("bold");
							Writer("BAAAAAAAAAMMMMMMMMMMMMMMMMMM");
							Enter();
							Color();
							Writer("An explosion happened. But you're not dead.");
							Enter();
							Writer("The governor is laying in a net, surrounded by scrap from his robot machine. Above him is a bright and extravigently clothed anime-looking young adult with a katana on his hip.");
							Space();
							Writer("Swordsman A: Well, that's been taken care of. Kinda wish it was less of a pushover, though.", 3);
							Enter();
							Writer("Another anime character-dressed swordsman, this time a female with duel swords and glasses, drops from the ceiling.");
							Space();
							Writer("Swordswoman S: So we finally found this guy. This took much longer than the Captain's intitial projection. Speaking of, where's is the Captain?", 3);
							Enter();
							Writer("Just then, a 6 foot 7 inch stubby looking swordsman in a black coat appears behind the women.");
							Enter();
							Writer("Swordsman Captain: I'm right here.", 3);
							Enter();
							Writer("Swordswoman S [startled]: You really should stop doing that.", 3);
							Enter();
							Writer("Mark [enthusiastic]: WOW!! COOL!!", 3);
							Space();
							Writer(name + " [angry about his win being taken away]: HEY!! WHO ARE YOU??", 3);
							Enter();
							Writer("Swordsman A: Oh? Hah! I guess we didn't introduce ourselves.", 3);
							Enter();
							Writer("They all proceed to do ridiculous poses.");
							Space();
							Color("green");
							Writer("Swordsman A: I'm the awesome possum: Breys!", 3);
							Space();
							Color("red");
							Writer("Swordswoman S: I am the elegant knight of the dark: Sapphire!", 3);
							Space();
							Color("blue");
							Writer("Swordsman Captain: I am the leader of this initiative: Captain. Our activities include dispatching high level threats: including the Dragon.", 3);
							Enter();
							Color("bold");
							Writer("Breys, Sapphire, and Captain together: And we are...Rumble Group!", 3);
							Color();
							//crew
							Enter();
							Writer(name + " [dumbfounded]: ...", 3);
							Space();
							Writer("Mark [amazed]: WOW...!", 3);
							Enter();
							Writer("Breys: Pretty good, eh? And what's your names?", 3);
							Enter();
							Writer(name + ": I don't even WANT to accosiate with you-", 3);
							Space();
							Writer("Mark: His name is " + name + ", and my name is Mark something!", 3);
							Enter();
							Writer("Breys: You don't know your own last name?", 3);
							Space();
							Writer("Mark: I kinda have amnesia I think, so I don't know anything much of before I got here.", 3);
							Enter();
							Writer("Breys: I see...", 3);
							Enter();
							Writer("Sapphire: Well, we can always try and get those memories back!", 3);
							Enter();
							Writer("Captain: We cannot.", 3);
							Space();
							Writer("Breys and Sapphire simulateusly: WHAT?!", 3);
							Enter();
							Writer("Breys [pointing to Mark]: He needs help! We can't just leave him? That's not what the Rumble Group does!", 3);
							Enter();
							Writer("Captain: The Rumble group is meant to defeat the Dragon. Nothing more or less was required.", 3);
							Enter();
							Writer("Breys: C'mon! Don't be a wet noodle!", 3);
							Enter();
							Writer(name + ": Ok, what the HELL is happening?!", 3);
							Enter();
							Writer(name + ": You guys just barge in and decide the fate my friend? Uncool!", 3);
							Enter();
							Writer(name + ": And worst of all, you guys are planning on defeating THE DRAGON, what?!", 3);
							Enter();
							Writer(name + ": And Mr. Stoic Protagonist over here isn't even pronouncing it right!!", 3);
							Enter();
							Writer(name + ": You guys can't barge into here and steal ALL the glory and just excpect me, Sam- I mean " + name + ", to like it! I'm a mercinary. This guy probably has a booty, and I want to take it!!", 3);
							Enter();
							Writer("Sapphire: That's not what we're doing at all! We're trying to help you!", 3);
							Enter();
							Writer(name + ": Well NEWSFLASH!! We! Don't! Need! Your! HELP!!", 3);
							Enter();
							Writer("Mark: " + name + ", why are you being so mean? They just stopped up from being evaporated!!", 3);
							Enter();
							Writer(name + ": Because I HATE it when people think they have the moral highground! Besides, they didn't do crap when we were caught in the explosion. It already happened by the time the \"Rumble Group\" got here.", 3);
							Enter();
							Writer("Mark: Even if they didn't do anything, they swill want to help!", 3);
							Enter();
							Writer(name + ": How sure are you of that?! How sure of you that they won't just gain our trust and immediantly turn on us when the journey's over?!", 3);
							Enter();
							Color("bold");
							Writer("Captain: ENOUGH!!", 3);
							Color();
							Enter();
							Writer("Captain: Breys and Sapphire just wanted to help you. Nothing more, nothing less.", 3);
							Space();
							Writer(name + ": Grrr...", 3);
							Enter();
							Writer("Captain: ...You know what? Let us go into the city. There, we can reconvine at a resturant. My treat. We will talk there.", 3);
							Space();
							Writer("Sapphire & Breys simulateusly: What?!", 3);
							Enter();
							Writer(name + ": WE WOULD-", 3);
							Space();
							Writer("Mark: Never NOT accept your offer!", 3);
							Enter();
							Writer("Captain: Excellent. We'll meet at the Crispy Crab. RUMBLE GROUP! ROLLOUT!!", 3);
							Enter();
							Writer("They proceed to jump through the ceiling.");
							Enter();
							Writer("Mark [concerned]: " + name + ", I feel like there's something you're not telling me. Everything ok?", 3);
							Enter();
							Writer(name + ": ...", 3);
							Enter();
							area = 15;
							Save();
						break;

						case 15:
							//getting to the city hub
							Console.Clear();
							Writer("After leaving the facility (adn collecting the booty), you head to the city hub.");
							GOLD += 2000;
							bountiesCleared += 1;
							Enter();
							Writer("Mark: " + name + ", I've been meaning to ask...", 3);//he was going to ask...
							Enter();
							Writer(name + ": Hm?", 3);
							Enter();
							Writer("Mark: N-nevermind.", 3);
							Enter();
							Writer("You finally make it to town square. Because of the military's efforts in the past few days, the area is now habitable. There are many places and establishments: shops, houses, diners, a bounty house, hotels, apartments, the like. They also had starving refugees and refugee camps.");
							Enter();
							Writer("Mark: Wow! I guess we'll be staying here for a while!", 3);
							Space();
							Writer(name + ": Eh.", 3);
							ending[1] = true;
							area = 0;
							Save();
						break;
					}
				}
				if(ending[1] == true)
				{
					//city hub
					Save();
					hasStarted = true;
					
					CertainSerialSave();
					Console.Clear();

					while(true)
					{
						Writer("Where would you like to go? (1 - 6)");
						Space();

						Color("yellow");
						Writer("Cabin, 1");
						Color("blue");
						Writer("Diner, 2");
						Color("cyan");
						Writer("Bounty House, 3");
						Color("green");
						Writer("Charity House, 4");
						Color("purple");
						Writer("Hunt Zone, 5");
						Color("bold");
						Writer("Apartment, 6");
						Space();
						Color("red");
						Writer("Go to THE DRAGON, 7");
						Color();

						Space();
						option = Reader();
						switch(option)
						{
							//Shopping
							case "1":
								Space();
								Writer("You go inside the Cabin.");
								Enter();
								Writer("Hello! Welcome to the Cabin! I'm the CabinMaster, so what do you want to do?");
								Space();
								Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD Left. Buy wisely!");
								Space();
								Color("blue");
								Writer("200G: Rest, 1");
								Color("green");
								Writer("Shop, 2");
								Space();
								Color("red");
								Writer("Leave, 3");
								Color();
								Space();
								option = Reader();
								stop = false;
								while(stop != true)
								{
									switch(option)
									{	
										case "1":
										case "rest":
										case "REST":
										case "Rest":
											Space();
											Writer("You went to rest until the next day.");
											Enter();
											HP = HEARTS + 2;
											Writer("CabinMaster: Good sleep? That'll be 200G!");
											Writer("You lost 200 GOLD!");
											GOLD -= 200;
											Enter();
											Writer("CabinMaster: Ok! Wanna do anything else?");
											Space();
											Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD Left. Buy wisely!");
											Space();
											Color("blue");
											Writer("200G: Rest, 1");
											Color("green");
											Writer("Shop, 2");
											Space();
											Color("red");
											Writer("Leave, 3");
											Color();
											Space();
											option = Reader();
										break;

										case "2":
										case "buy":
										case "shop":
										case "Buy":
										case "Shop":
										case "BUY":
										case "SHOP":
											Space();
											Writer("CabinMaster: Alright! I got a good selection right here! And I'll NEVER run out of stock!");
											Space();
											Use();
											Writer("CabinMaster: Ok! Wanna do anything else?");
											Space();
											Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD Left. Buy wisely!");
											Space();
											Color("blue");
											Writer("200G: Rest, 1");
											Color("green");
											Writer("Shop, 2");
											Space();
											Color("red");
											Writer("Leave, 3");
											Color();
											Space();
											option = Reader();
										break;

										case "3":
										case "leave":
										case "go":
										case "Leave":
										case "Go":
										case "LEAVE":
										case "GO":
											Space(2);
											Writer("CabinMaster: Ok! See you around!");
											stop = true;
										break;

										default:
											ErrorWrite();
											Space();
											Writer("CabinMaster: Ok! Wanna do anything else?");
											Space();
											Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD Left. Buy wisely!");
											Space();
											Color("blue");
											Writer("200G: Rest, 1");
											Color("green");
											Writer("Shop, 2");
											Space();
											Color("red");
											Writer("Leave, 3");
											Color();
											Space();
											option = Reader();
										break;
									}
								}
							break;

							//Diner
							case "2":
								Space();
								Writer("You go inside the fine diner with Mark.");
								Enter();
								Writer("Accountant: Hello, hello! I'm the accountant of Sunflower Gardens, and will pick out your seats.");
								Enter();
								if(GOLD < 200)
								{
									Writer("Accountant: Oh? I'm sorry, but you don't have enough GOLD to buy from our menu. Come back when you have enough funds. Thank you for considering Sunflower Gardens, though!");
								}
								else
								{
								Writer("Accountant: Ok, your seats have been set!");
								if(storyEventFM[0] == true)
								{
									Writer("As you walk through to the table area, you see the Rumble Group sitting at a table next to a wall. Breys seems impacient, Sapphire twidling her thumbs with her head in the clouds, and Captain being incredibly stoic in atmostphere. It's as if he is not thinking of anything at all. Unnerving.");
									Enter();
									Writer(name + ": Why did I agree to this...");
									Enter();
									Writer(name + " [looking at Mark angrily]: Oh wait, I didn't.");
									Enter();
									Writer("Mark: You were just acting strange. I though this would be the best way to settle this without death!");
									Space();
									Writer(name + ": And NOW you're opposed to that?!");
									Enter();
									Writer("Mark: The guards were different to me, okay?");
									Enter();
									Writer(name + ": Besides, how would you know what's normal for me and what's not? We've only been frie-allies, for a few days!");
									Enter();
									Writer("Mark: I know we're still trying to fingure our friendship out, but we got a bond, you know? Being in the locker together really put us through some crap. And that bonds us like a hot iron!");
									Enter();
									Writer(name + ": Hmph.");
									Enter();
									Writer("You and Mark sit down on the opposite side of the Rumble Group, akwardly waiting for coversation to start.");
									Enter();
									Writer("Captain: So, " + name + ", how is the city to you? I can tell you're not from here.");
									Enter();
									Writer(name + ": How the hell do you know my name's " + name + "?");
									Space();
									Writer("Captain: I know many things, " + name + ". Some things that are so obvious, yet know one knows them.");
									Enter();
									Writer(name + ": Okay...");
									Enter();
									Writer("Sapphire: Sorry, " + name + ", he's just like this sometimes! Don't pay too much attention to it.");
									Enter();
									Writer("Breys: Anyway, let's get to the point at hand. We gotta figure out what's between us.");
									Enter();
									Writer(name + ": What do you mean 'what's between us'?");
									Space();
									Writer("Breys: As in, termoil.");
									Enter();
									Writer("Sapphire: It seems that we don't have a mutual understanding of goals, and, I think that's a very big problem...");
									Enter();
									Writer("Breys: Yeah man. If we keep getting at each other's throats, we can't defeat the Dragon, or more importantly help out your buddy Mark here.");
									Enter();
									Writer(name + ": You guys are forgetting a crucial detail. When the hell did I say I could share THE DRAGON with you guys?! It is MY bounty, for ME.");
									Enter();
									Writer("Captain: We don't have to share the money. Our group already has agents around the globe doing community and miscellaneous jobs for high profit. We don't need the reward from 'THE DRAGON'.");
									Enter();
									Writer("Captain: That being said, we are not closed off to deals giving us a portion of the money.");
									Enter();
									Writer(name + ": ...But I am, so that's a no-go.");
									Enter();
									Writer("Captain: Indeed.");
									Space();
									Writer("Sapphire: I think we've made it clear by now that we only have two common goals: defeating the Dragon and helping Mark with his memories. I have a plan of action for meeting both of these goals at the same time.");
									Enter();
									Writer(name + ": Let's hear it, then.");
									Enter();
									Writer("Sapphire: I think what we do is climb a ciruclar routes through the suburbs and urban areas of the city. This way, we can build up strength and kill any monsters who made it past the city's wall.");
									Enter();
									Writer("Sapphire: Next, I plan for us to then climb in elevation on a straight path through to the Dragon starting from 50 kilometers away. This way, we can catch any swordsman off guard as they would be under the assumption that we were going around and only killing monsters. This works because the Rumble Group hasn't publicly disclosed taking action against the Dragon.");
									Enter();
									Writer("Sapphire [enthusiastic]: Finally, the Captain and " + name + " with go ahead and defeat the Dragon!");
									Enter();
									Writer("Mark: That's a pretty good plan. You though of it just now?");
									Space();
									Writer("Sapphire [humbled]: Well...yeah!");
									Enter();
									Writer(name + ": Well it seems that you have thought this through. We have a common goal and plan to approach it. But I just want to make some things clear...");
									Enter();
									Writer(name + " [holding up one finger]: 1)  It's 'THE DRAGON', not 'the Dragon'. [holding up a second finger] And 2) This is an agreed allience, NOT a friendship. Understand?");
									Enter();
									Writer("Captain [pulls out hand]: I'm glad we have an agreement.");
									Enter();
									Writer(name + ": I'm not so happy...but I think it'll benefit.");
									Space();
									Writer("You both then shake hands, noticing his grip is strong you leave, knowing an adventure awaits.");
									storyEventFM[0] = false;
								}
								else if(regular >= 10)
								{
									re = rando.Next(0, 2);
									if(re == 0)
									{
										Writer("Waiter: A regular, have we? What shall you pick for your order?");
									}
									else
									{
										Writer("Waitress: Ooo, a regular! What shall you order on this fine day?");
									}
									Enter();
									Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD left. Buy wisely! (1 - 6)");
									Space();
									Writer("	Seered Salmon, 1: A fine 400G delight which is crafted from the most perfect salmon, engineered with WILL, garlic seasoning, and salt. Even with these preparations, it still remains one of the cheapest thing on this list, and with the best value! Heals all HP plus 5.");
									Space();
									Writer("	Ratatouille, 2: A popular 250G delicacy in the summer. Cooked with the finest vegetables, it will taste like heaven! Heals all HP.");
									Space();
									Writer("	Cassoulet, 3: A comfort 700G dish which is made from the most promising of meat and beans. It's pork is made from the pastures of the costline region Pays de la Loire, and it shows in taste. Its rich meat softens even the hardest of hearts, and you won't want to go a day without it! Heals all HP + 15");
									Space();
									Writer(" Boeuf bourguignon, 4: If you're feeling normal, this 300G dish will staisfy your needs. While it includes no wine, it's onion seasoning and grade A beef will suffice for its soberness. Perfect for a nice relaxing dinner. Heals all HP + 10.");
									Space();
									Writer("	Chocolate soufflé, 5: While our menu is small, no menu is complete without a dessert! The chocolate is imported from the French colonies in africa, and their wholehearted labor is greatly appreciated. The chocolate crust with caramel creams makes a mouthwatering 150G dessert. Heals nearly all HP.");
									Space();
									Writer("Leave, 6 (you still have to pay a 50G fee)");
									Space();
									option = Reader();
									stop = false;
									while(stop == false)
									{
										switch(option)
										{
											case "1":
												Space();
												Writer("Waiter/Waiteress: You choose the Seered Salmon? Alright!");
												Enter();
												Writer("You waited an hour. The Seered Salmon looked more delicious than even pictured in the description.");
												Enter();
												Writer("Mark: Man, this Seered Salmon is delicious!");
												Space();
												Writer(name + " [stuffing his mouth]: Yeah...");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Aw yeah!");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 400;
												HP = HEARTS + 5;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "2":
												Space();
												Writer("Waiter/Waiteress: You choose the Ratatouille? Alright!");
												Enter();
												Writer("You waited an hour. The Ratatouille looked just like the picture.");
												Enter();
												Writer("Mark: Man, this Ratatouille is pretty good!");
												Space();
												Writer(name + " [eating]: Yeah.");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Yep!");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 250;
												HP = HEARTS;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "3":
												Space();
												Writer("Waiter/Waiteress: You choose the Cassoulet? Alright!");
												Enter();
												Writer("You waited an hour. The Cassoulet looked expensive, but appealing.");
												Enter();
												Writer("Mark: Man, this Cassoulet tastes good!");
												Space();
												Writer(name + " : I guess...");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Yeah.");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 700;
												HP = HEARTS + 15;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "4":
												Space();
												Writer("Waiter/Waiteress: You choose the Boeuf bourguignon? Alright!");
												Enter();
												Writer("You waited an 30 minutes. The Boeuf bourguignon looked less apealing them expected, but atleast is is edible.");
												Enter();
												Writer("Mark: This Boeuf bourguignon tastes alright.");
												Space();
												Writer(name + " : It tastes meh.");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Uh...");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 300;
												HP = HEARTS + 10;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "5":
												Space();
												Writer("Waiter/Waiteress: You choose the Chocolate soufflé? Alright!");
												Enter();
												Writer("You waited an 30 minutes. The Chocolate soufflé looked bloated but delicious.");
												Enter();
												Writer("Mark: This Chocolate soufflé nice!");
												Space();
												Writer(name + " : Pretty much.");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Yeah!");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 150;
												HP = HEARTS - (HEARTS/4);
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "6":
												Space();
												Writer("Thank you for considering dining here! Also, pay the fee.");
												Writer("You lost 50G!");
												stop = true;
											break;

											default:
												ErrorWrite();
												Space();
												Writer("Waiter/Waitress: I'm sorry, but we don't have many options right now. Why don't you choose what's not the selection?");
												Space();
												Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD left. Buy wisely! (1 - 6)");
												Space();
												Writer("	Seered Salmon, 1: A fine 400G delight which is crafted from the most perfect salmon, engineered with WILL, garlic seasoning, and salt. Even with these preparations, it still remains one of the cheapest thing on this list, and with the best value! Heals all HP plus 5.");
												Space();
												Writer("	Ratatouille, 2: A popular 250G delicacy in the summer. Cooked with the finest vegetables, it will taste like heaven! Heals all HP.");
												Space();
												Writer("	Cassoulet, 3: A comfort 700G dish which is made from the most promising of meat and beans. It's pork is made from the pastures of the costline region Pays de la Loire, and it shows in taste. Its rich meat softens even the hardest of hearts, and you won't want to go a day without it! Heals all HP + 15");
												Space();
												Writer(" Boeuf bourguignon, 4: If you're feeling normal, this 300G dish will staisfy your needs. While it includes no wine, it's onion seasoning and grade A beef will suffice for its soberness. Perfect for a nice relaxing dinner. Heals all HP + 10.");
												Space();
												Writer("	Chocolate soufflé, 5: While our menu is small, no menu is complete without a dessert! The chocolate is imported from the French colonies in africa, and their wholehearted labor is greatly appreciated. The chocolate crust with caramel creams makes a mouthwatering 150G dessert. Heals nearly all HP.");
												Space();
												Writer("Leave, 6 (you still have to pay a 50G fee)");
												Space();
												option = Reader();
											break;
										}
									}
								}
								else if(regular < 10)
								{
									re = rando.Next(0, 2);
									if(re == 0)
									{
										Writer("Waiter: A new visitor, have we? What shall you pick for your order?");
									}
									else
									{
										Writer("Waitress: Ooo, a new one! What shall you order on this fine day?");
									}
									Enter();
									Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD left. Buy wisely! (1 - 6)");
									Space();
									Writer("	Seered Salmon, 1: A fine 450G delight which is crafted from the most perfect salmon, engineered with WILL, garlic seasoning, and salt. Even with these preparations, it still remains one of the cheapest thing on this list, and with the best value! Heals all HP plus 5.");
									Space();
									Writer("	Ratatouille, 2: A popular 300G delicacy in the summer. Cooked with the finest vegetables, it will taste like heaven! Heals all HP.");
									Space();
									Writer("	Cassoulet, 3: A comfort 750G dish which is made from the most promising of meat and beans. It's pork is made from the pastures of the costline region Pays de la Loire, and it shows in taste. Its rich meat softens even the hardest of hearts, and you won't want to go a day without it! Heals all HP + 15");
									Space();
									Writer(" Boeuf bourguignon, 4: If you're feeling normal, this 350G dish will staisfy your needs. While it includes no wine, it's onion seasoning and grade A beef will suffice for its soberness. Perfect for a nice relaxing dinner. Heals all HP + 10.");
									Space();
									Writer("	Chocolate soufflé, 5: While our menu is small, no menu is complete without a dessert! The chocolate is imported from the French colonies in africa, and their wholehearted labor is greatly appreciated. The chocolate crust with caramel creams makes a mouthwatering 200G dessert. Heals nearly all HP.");
									Space();
									Writer("Leave, 6 (you still have to pay a 100G fee)");
									Space();
									option = Reader();
									stop = false;
									while(stop == false)
									{
										switch(option)
										{
											case "1":
												Space();
												Writer("Waiter/Waiteress: You choose the Seered Salmon? Alright!");
												Enter();
												Writer("You waited an hour. The Seered Salmon looked more delicious than even pictured in the description.");
												Enter();
												Writer("Mark: Man, this Seered Salmon is delicious!");
												Space();
												Writer(name + " [stuffing his mouth]: Yeah...");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Aw yeah!");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 450;
												HP = HEARTS + 5;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "2":
												Space();
												Writer("Waiter/Waiteress: You choose the Ratatouille? Alright!");
												Enter();
												Writer("You waited an hour. The Ratatouille looked just like the picture.");
												Enter();
												Writer("Mark: Man, this Ratatouille is pretty good!");
												Space();
												Writer(name + " [eating]: Yeah.");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Yep!");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 300;
												HP = HEARTS;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "3":
												Space();
												Writer("Waiter/Waiteress: You choose the Cassoulet? Alright!");
												Enter();
												Writer("You waited an hour. The Cassoulet looked expensive, but appealing.");
												Enter();
												Writer("Mark: Man, this Cassoulet tastes good!");
												Space();
												Writer(name + " : I guess...");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Yeah.");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 750;
												HP = HEARTS + 15;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "4":
												Space();
												Writer("Waiter/Waiteress: You choose the Boeuf bourguignon? Alright!");
												Enter();
												Writer("You waited an 30 minutes. The Boeuf bourguignon looked less apealing them expected, but atleast is is edible.");
												Enter();
												Writer("Mark: This Boeuf bourguignon tastes alright.");
												Space();
												Writer(name + " : It tastes meh.");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Uh...");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 350;
												HP = HEARTS + 10;
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "5":
												Space();
												Writer("Waiter/Waiteress: You choose the Chocolate soufflé? Alright!");
												Enter();
												Writer("You waited an 30 minutes. The Chocolate soufflé looked bloated but delicious.");
												Enter();
												Writer("Mark: This Chocolate soufflé nice!");
												Space();
												Writer(name + " : Pretty much.");
												Enter();
												Writer("Waiter/Waitress: You enjoy your meal?");
												Space();
												Writer(name + " & Mark simulateusly: Yeah!");
												Enter();
												Writer("How much is your tip? (use only numbers without spaces or commas)");
												Space();
												option = Reader();
												Space();
												Writer("You gave a " + Convert.ToSingle(option) + " GOLD tip to the Waiter/Waitress!");
												GOLD -= Convert.ToSingle(option);
												GOLD -= 200;
												HP = HEARTS - (HEARTS/4);
												Enter();
												if(GOLD < 0)
												{
													Writer("You're now in debt!");
													Enter();
												}
												Writer("That you for going to Sunflower Garden! Goodbye!");
												Enter();
												regular++;
												stop = true;
											break;

											case "6":
												Space();
												Writer("Thank you for considering dining here! Also, pay the fee.");
												Writer("You lost 100G!");
												GOLD -= 100;
												stop = true;
											break;

											default:
												ErrorWrite();
												Space();
												Writer("Waiter/Waitress: I'm sorry, but we don't have many options right now. Why don't you choose what's not the selection?");
												Space();
												Writer("You have " + HEARTS + " Max HP, " + HP + " HP, and " + GOLD + " GOLD left. Buy wisely! (1 - 6)");
												Space();
												Writer("	Seered Salmon, 1: A fine 450G delight which is crafted from the most perfect salmon, engineered with WILL, garlic seasoning, and salt. Even with these preparations, it still remains one of the cheapest thing on this list, and with the best value! Heals all HP plus 5.");
												Space();
												Writer("	Ratatouille, 2: A popular 300G delicacy in the summer. Cooked with the finest vegetables, it will taste like heaven! Heals all HP.");
												Space();
												Writer("	Cassoulet, 3: A comfort 750G dish which is made from the most promising of meat and beans. It's pork is made from the pastures of the costline region Pays de la Loire, and it shows in taste. Its rich meat softens even the hardest of hearts, and you won't want to go a day without it! Heals all HP + 15");
												Space();
												Writer(" Boeuf bourguignon, 4: If you're feeling normal, this 350G dish will staisfy your needs. While it includes no wine, it's onion seasoning and grade A beef will suffice for its soberness. Perfect for a nice relaxing dinner. Heals all HP + 10.");
												Space();
												Writer("	Chocolate soufflé, 5: While our menu is small, no menu is complete without a dessert! The chocolate is imported from the French colonies in africa, and their wholehearted labor is greatly appreciated. The chocolate crust with caramel creams makes a mouthwatering 200G dessert. Heals nearly all HP.");
												Space();
												Writer("Leave, 6 (you still have to pay a 100G fee)");
												Space();
												option = Reader();
											break;
										}
									}
								}
								}
							break;

							//Bounty House
							case "3":
								Space();
								Writer("You enter the Bounty House. Alone.");
								Enter();
								Writer("BountyMaster: Hi. Bounty Boad's over there.");
								Enter();
								if(firstTime[5] == true)
								{
									Color("bold");
									Writer("Time to get some bounties!");
									Enter();
									Color("yellow");
									Writer("When you compete a bounty, you get a substancial amout of GOLD, which can compensate for the change-cheap campaign.");
									Enter();
									Color("red");
									Writer("In order to complete a bounty, you need to defeat a certain amount of enemies.");
									Enter();
									Writer("Enemies are sorted into groups based on HP count: Easy (0 - 60HP), Medium (61 - 90HP), and Hard(91 - 190HP). You can even get bounties for Minibosses (191HP+)! The harder the enemy, the more the bounty'll be worth!");
									Enter();
									Writer("The higher your bounty level, the harder the enemies you can bounty for!");
									Enter();
									Writer("But you can only do one bounty at a time, so choose wisely!");
									Enter();
									Color("purple");
									Writer("You can randomly find a bounty with options of level of the monster, up to your own. When you shuffle, you get three options of a bounty. If you want to shuffle for three different ones, it cost 100G per shuffle.");
									Enter();
									Color("green");
									Writer("Once you complete enough bounties, your bounty level will increase, causing you to be able to hunt higher level monsters!");
									Enter();
									Writer("You can turn in your bounty at the Bounty Board in the city!");
									Enter();
									Color("bold");
									Writer("Now go out there and hunt some monsters and collect some bounties!");
									Enter();
									Color();
									firstTime[5] = false;
								}
								Writer("Bounty Level: " + bountyLevel + ", Bounties to Go: " + bountyCollected + ", Bounties to Next Level: " + bountyNeed + ", Bounties Done: " + bountiesCleared + ".");
								Writer("What will you do? (1 - 4)");
								Space();
								Writer("Find Bounties, 1");
								Writer("Turn in Bounties, 2");
								Writer("Drop Bounty, 3 (100G compensation fee)");
								Space();
								Writer("Leave, 4 (10G compensation fee)");
								Space();
								option = Reader();
								stop = false;
								while(stop != true)
								{
									switch(option)
									{
										case "1":
											Space();
											if(hasBounty == false)
											{
												Writer("Time to shuffle!");
												Enter();
												Writer("Which one? (1 - 4)");
												Space();
												//First Bounty Choice
												for(int r = 0; r < 3; r++)
												{
													re = rando.Next(1, 4);
													switch(re)
													{
														case 1:
															Bounty1[r] = 1;
															re = rando.Next(800, 2000);
															bountyCostings[0] = re;
														break;

														case 2:
															if(bountyLevel >= 2)
															{
																Bounty1[r] = 2;
																re = rando.Next(2000, 10000);
																bountyCostings[0] = re;
															}
															else
															{
																Bounty1[r] = 1;
																re = rando.Next(800, 2000);
																bountyCostings[0] = re;
															}
														break;

														case 3:
															if(bountyLevel >= 3)
															{
																Bounty1[r] = 3;
																re = rando.Next(10000, 120000);
																bountyCostings[0] = re;
															}
															else
															{
																if(bountyLevel >= 2)
																{
																	Bounty1[r] = 2;
																	re = rando.Next(2000, 10000);
																	bountyCostings[0] = re;
																}
																else
																{
																	Bounty1[r] = 1;
																	re = rando.Next(800, 2000);
																	bountyCostings[0] = re;
																}
															}
														break;
													}
												}
												if(Bounty1[0] == 1)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty1[0] == 2)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty1[0] == 3)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[0] + "), 1");
												Space();
												//Second Bounty Choice
												for(int r = 0; r < 3; r++)
												{
													re = rando.Next(1, 4);
													switch(re)
													{
														case 1:
															Bounty2[r] = 1;
															re = rando.Next(800, 2000);
															bountyCostings[1] = re;
														break;

														case 2:
															if(bountyLevel >= 2)
															{
																Bounty2[r] = 2;
																re = rando.Next(2000, 10000);
																bountyCostings[1] = re;
															}
															else
															{
																Bounty2[r] = 1;
																re = rando.Next(800, 2000);
																bountyCostings[1] = re;
															}
														break;

														case 3:
															if(bountyLevel >= 3)
															{
																Bounty2[r] = 3;
																re = rando.Next(10000, 120000);
																bountyCostings[1] = re;
															}
															else
															{
																if(bountyLevel >= 2)
																{
																	Bounty2[r] = 2;
																	re = rando.Next(2000, 10000);
																	bountyCostings[1] = re;
																}
																else
																{
																	Bounty2[r] = 1;
																	re = rando.Next(800, 2000);
																	bountyCostings[1] = re;
																}
															}
														break;
													}
												}
												if(Bounty2[0] == 1)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty2[0] == 2)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty2[0] == 3)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[1] + "), 2");
												Space();
												//Third Bounty Choice
												for(int r = 0; r < 3; r++)
												{
													re = rando.Next(1, 4);
													switch(re)
													{
														case 1:
															Bounty3[r] = 1;
															re = rando.Next(800, 2000);
															bountyCostings[2] = re;
														break;

														case 2:
															if(bountyLevel >= 2)
															{
																Bounty3[r] = 2;
																re = rando.Next(2000, 10000);
																bountyCostings[2] = re;
															}
															else
															{
																Bounty3[r] = 1;
																re = rando.Next(800, 2000);
																bountyCostings[2] = re;
															}
														break;

														case 3:
															if(bountyLevel >= 3)
															{
																Bounty3[r] = 3;
																re = rando.Next(10000, 120000);
																bountyCostings[2] = re;
															}
															else
															{
																if(bountyLevel >= 2)
																{
																	Bounty3[r] = 2;
																	re = rando.Next(800, 2000);
																	bountyCostings[2] = re;
																}
																else
																{
																	Bounty3[r] = 1;
																	re = rando.Next(800, 2000);
																	bountyCostings[2] = re;
																}
															}
														break;
													}
												}
												if(Bounty3[0] == 1)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty3[0] == 2)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty3[0] == 3)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[2] + "), 3");
												Space();
												//End
												Space();
												Writer("50G: Shuffle Again, 4");
												Space();
												option = Reader();
												Space();
												stop2 = false;
												while(stop2 == false)
												{
													switch(option)
													{
														case "1":
															switch(Bounty1[0])
															{
																case 1:
																	bounties[0] = true;
																break;

																case 2:
																	bounties[3] = true;
																break;

																case 3:
																	bounties[6] = true;
																break;
															}
															switch(Bounty1[1])
															{
																case 1:
																	bounties[1] = true;
																break;

																case 2:
																	bounties[4] = true;
																break;

																case 3:
																	bounties[7] = true;
																break;
															}
															switch(Bounty1[2])
															{
																case 1:
																	bounties[2] = true;
																break;

																case 2:
																	bounties[5] = true;
																break;

																case 3:
																	bounties[8] = true;
																break;
															}
															Writer("Bounty Registered!");
															stop = true;
															stop2 = true;
															bountyCollected = 3;
															bountyCost = bountyCostings[0];
															hasBounty = true;
														break;

														case "2":
															switch(Bounty2[0])
															{
																case 1:
																	bounties[0] = true;
																break;

																case 2:
																	bounties[3] = true;
																break;

																case 3:
																	bounties[6] = true;
																break;
															}
															switch(Bounty2[1])
															{
																case 1:
																	bounties[1] = true;
																break;

																case 2:
																	bounties[4] = true;
																break;

																case 3:
																	bounties[7] = true;
																break;
															}
															switch(Bounty2[2])
															{
																case 1:
																	bounties[2] = true;
																break;

																case 2:
																	bounties[5] = true;
																break;

																case 3:
																	bounties[8] = true;
																break;
															}
															Writer("Bounty Registered!");
															stop = true;
															stop2 = true;
															bountyCollected = 3;
															bountyCost = bountyCostings[1];
															hasBounty = true;
														break;

														case "3":
															switch(Bounty3[0])
															{
																case 1:
																	bounties[0] = true;
																break;

																case 2:
																	bounties[3] = true;
																break;

																case 3:
																	bounties[6] = true;
																break;
															}
															switch(Bounty3[1])
															{
																case 1:
																	bounties[1] = true;
																break;

																case 2:
																	bounties[4] = true;
																break;

																case 3:
																	bounties[7] = true;
																break;
															}
															switch(Bounty3[2])
															{
																case 1:
																	bounties[2] = true;
																break;

																case 2:
																	bounties[5] = true;
																break;

																case 3:
																	bounties[8] = true;
																break;
															}
															Writer("Bounty Registered!");
															stop = true;
															stop2 = true;
															bountyCollected = 3;
															bountyCost = bountyCostings[2];
															hasBounty = true;
														break;

														case "4":
															Space();
															Writer("BountyMaster: That'll be a 50G fee.");
															Enter();
															if(GOLD >= 50)
															{
																Writer("You lost 50 GOLD!");
																GOLD -= 50;
																Enter();
																Writer("Re-shuffle Time!");
																Enter();
																Writer("Which One? (1 - 4)");
																//Shuffling
																Shuffle();
																//End
																Space();
																Writer("50G: Shuffle Again, 4");
																Space();
																option = Reader();
															}
															else if(GOLD < 50)
															{
																Writer("BountyMaster: You're too broke to reshuffle.");
																Enter();
																stop2 = true;
															}
														break;

														default:
															ErrorWrite();
															Writer("Which one? (1 - 4)");
															Space();
															//selection
															Shuffle2();
															//Choice
															Space();
															Writer("50G: Shuffle Again, 4");
															Space();
															option = Reader();
														break;
													}
												}
											}
											else
											{
												Writer("BountyMaster: You already have a bounty. If you don't like it, then call it off or finish it!");
											}
											//Choose
											stop = false;
											Enter();
											Writer("Bounty Level: " + bountyLevel + ", Bounties to Go: " + bountyCollected + ", Bounties to Next Level: " + bountyNeed + ", Bounties Done: " + bountiesCleared + ".");
											Writer("What will you do? (1 - 4)");
											Space();
											Writer("Find Bounties, 1");
											Writer("Turn in Bounties, 2");
											Writer("Drop Bounty, 3 (100G compensation fee)");
											Space();
											Writer("Leave, 4 (10G compensation fee)");
											Space();
											option = Reader();
										break;

										case "2":
											Space();
											if(bountyCollected == 0 && hasBounty == true)
											{
												hasBounty = false;
												Writer("Bounty Cleared! You got " + bountyCost + " GOLD! Now you can find another bounty!");
												GOLD += bountyCost;
												bountiesCleared++;
												bountyNeed--;
												while(bountyNeed <= 0 && bountyLevel < 4)
												{
													Space();
													Color("purple");
													bountyLevel++;
													Writer("You leveled up your bounty level, and you're now level " + bountyLevel + "!");
													Space();
													switch(bountyLevel)
													{
														case 2:
															Color("green");
															Writer("You can now take on medium level enemies for cash!");
															bountyNeed = 10;
														break;

														case 3:
															Color("cyan");
															Writer("You can now take on hard level enemies for cash!");
															bountyNeed = 20;
														break;

														case 4:
															Color("red");
															Writer("Final Level!!");
															Color("blue");
															Writer("You can now hunt mini-bosses for cash!!");
														break;

														default:
															if(bountyLevel < 2)
															{
																Color("red");
																Writer("Wait...how the hell did you get here?! Back to level one!!");
																bountyLevel = 1;
															}
															else if(bountyLevel >= 5)
															{
																Color("red");
																Writer("FINAL. LEVEL. That's how it works!");
																Color("blue");
																Writer("You only get to take on mini-bosses for cash.");
															}
														break;
													}
													Color();
												}
												Enter();
												Writer("Bounty Level: " + bountyLevel + ", Bounties to Go: " + bountyCollected + ", Bounties to Next Level: " + bountyNeed + ", Bounties Done: " + bountiesCleared + ".");
												Writer("What will you do? (1 - 4)");
												Space();
												Writer("Find Bounties, 1");
												Writer("Turn in Bounties, 2");
												Writer("Drop Bounty, 3 (100G compensation fee)");
												Space();
												Writer("Leave, 3");
												Space();
												option = Reader();
											}
											else if(bountyCollected > 0 && hasBounty == true)
											{
												Writer("You still have to clear the bounty! " + bountyCollected + " more to go!");
												Enter();
												Writer("Bounty Level: " + bountyLevel + ", Bounties to Go: " + bountyCollected + ", Bounties to Next Level: " + bountyNeed + ", Bounties Done: " + bountiesCleared + ".");
												Writer("What will you do? (1 - 4)");
												Space();
												Writer("Find Bounties, 1");
												Writer("Turn in Bounties, 2");
												Writer("Drop Bounty, 3 (100G compensation fee)");
												Space();
												Writer("Leave, 3");
												Space();
												option = Reader();
											}
											else if(hasBounty == false)
											{
												Writer("You don't have a bounty! Go get one!");
												Enter();
												Writer("Bounty Level: " + bountyLevel + ", Bounties to Go: " + bountyCollected + ", Bounties to Next Level: " + bountyNeed + ", Bounties Done: " + bountiesCleared + ".");
												Writer("What will you do? (1 - 4)");
												Space();
												Writer("Find Bounties, 1");
												Writer("Turn in Bounties, 2");
												Writer("Drop Bounty, 3 (100G compensation fee)");
												Space();
												Writer("Leave, 3");
												Space();
												option = Reader();
											}
										break;

										case "3":
											Space();
											Writer("BountyMaster: Ok. Pay the fee or I'll not do it.");
											Enter();
											Writer("Pay fee? (y/n)");
											Space();
											option = Reader();
											bool stoop = false;
											while(stoop != true)
											{
												switch(option)
												{
													case "1":
													case "YES":
													case "Yes":
													case "yes":
														Space();
														Writer("BountyMaster: Ok. I put the recall in.");
														Enter();
														Writer("You lost 100 GOLD!");
														GOLD -= 100;
														hasBounty = false;
														bounties[0] = false;
														bounties[1] = false;
														bounties[2] = false;
														bounties[3] = false;
														bounties[4] = false;
														bounties[5] = false;
														bounties[6] = false;
														bounties[7] = false;
														bounties[8] = false;
														bounties[9] = false;
														bountyCollected = 0;
														bountyCost = 0;
														stoop = true;
														Enter();
														Writer("Bounty Level: " + bountyLevel + ", Bounties to Go: " + bountyCollected + ", Bounties to Next Level: " + bountyNeed + ", Bounties Done: " + bountiesCleared + ".");
														Writer("What will you do? (1 - 4)");
														Space();
														Writer("Find Bounties, 1");
														Writer("Turn in Bounties, 2");
														Writer("Drop Bounty, 3 (100G compensation fee)");
														Space();
														Writer("Leave, 3");
														Space();
														option = Reader();
													break;

													case "NO":
													case "No":
													case "no":
													case "2":
														Space();
														Writer("BountyMaster: Then I'll just not do it. Get out, too.");
														Enter();
														stoop = true;
														stop = true;
													break;
												
													default:
														ErrorWrite();
														Enter();
														Writer("Pay fee? (y/n)");
														Space();
														option = Reader();
													break;
												}
											}
										break;

										case "4":
											Space();
											Writer("BountyMaster: See you around, then. Also pay the fee, or else.");
											Enter();
											Writer("Pay fee? (y/n)");
											Space();
											option = Reader();
											switch(option)
											{
												case "YES":
												case "Yes":
												case "yes":
												case "1":
													Space();
													Writer("BountyMaster: Good boy...");
													Enter();
													Writer("You lost 100 GOLD!");
													GOLD -= 10;
													if(GOLD < 0)
													{
														Enter();
														Writer("You're now in debt!");
														Enter();
													}
													Enter();
													Writer("BountyMaster: See ya, if you don't die, that is...");
													Enter();
													stop = true;
												break;

												case "NO":
												case "No":
												case "no":
												case "2":
													Space();
													Writer("BountyMaaster: No was never an option.");
													Enter();
													MonsterEncounter(9999, 9999, 9999, "CabinMaster Green", 0F, 0, true);
													stop = true;
												break;

												default:
													Space();
													Writer("CabinMaster: Unintelligeble is a no to me.");
													Enter();
													MonsterEncounter(9999, 9999, 9999, "CabinMaster Green", 0F, 0, true);
													stop = true;
												break;
											}
										break;

										default:
											ErrorWrite();
											Enter();
											Writer("Bounty Level: " + bountyLevel + ", Bounties to Go: " + bountyCollected + ", Bounties to Next Level: " + bountyNeed + ", Bounties Done: " + bountiesCleared + ".");
											Writer("What will you do? (1 - 4)");
											Space();
											Writer("Find Bounties, 1");
											Writer("Turn in Bounties, 2");
											Writer("Drop Bounty, 3 (100G compensation fee)");
											Space();
											Writer("Leave, 4 (10G compensation fee)");
											Space();
											option = Reader();
										break;
									}
								}
							break;

							//Charity House
							case "4":

							break;

							//Hunt Zone
							case "5":
								Space();
								stop = false;
								bool both = false;
								int teamer = 0;
								while(stop == false)
								{
									Writer("Do you want to take teammate 2 with you into the Hunt Zone? (y/n)");
									Space();
									option = Reader();
									switch(option)
									{
										case "1":
										case "yes":
										case "Yes":
										case "YES":
											stop2 = false;
											while(stop2 == false)
											{
												Space();
												Writer("Who will you take? (1 - 5)");
												Space();
												if(playedWith[0] == true)
												{
													Writer("Mark, 1");
												}
												if(playedWith[1] == true)
												{
													Writer("Breys, 2");
												}
												if(playedWith[2] == true)
												{
													Writer("Sapphire, 3");
												}
												if(playedWith[3] == true)
												{
													Writer("Captain, 4");
												}
												Space();
												Writer("END, 5");
												Space();
												option = Reader();
												switch(option)
												{
													case "1":
														teamer = 0;
														teamMateName = Mark.name;
														both = true;
														stop = true;
													break;

													case "2":
														if(playedWith[1] == true)
														{
															teamer = 1;
															teamMateName = Breys.name;
															both = true;
															stop = true;
														}
														else
														{
															ErrorWrite();
														}
													break;

													case "3":
														if(playedWith[2] == true)
														{
															teamer = 2;
															teamMateName = Sapphire.name;
															both = true;
															stop = true;
														}
														else
														{
															ErrorWrite();
														}
													break;

													case "4":
														if(playedWith[3] == true)
														{
															teamer = 3;
															teamMateName = Captain.name;
															both = true;
															stop = true;
														}
														else
														{
															ErrorWrite();
														}
													break;

													case "5":
														stop2 = true;
														Space();
													break;

													default:
														ErrorWrite();
													break;
												}
											}
										break;

										case "2":
										case "No":
										case "no":
										case "NO":
											Space();
											both = false;
											stop = true;
										break;
									}
								}
								Enter();
								if(both == true)
								{
									Writer("You and " + teamMateName + " enter the Hunt Zone.");
									Enter();
								}
								else
								{
									Writer("You enter the Hunt Zone.");
									Enter();
								}
								if(firstTime[7] == true)
								{
									Writer("HuntingMaster: Well, well, well. Look who'e got 'ere! A fine young man ready to do some that 'ol huntin'! Here's you ticket (children are on the house), and be ready for some prime monster squashin'!");
									Enter();
									Color("bold");
									Writer("Welcome to the Hunt Zone!");
									Enter();
									Color("yellow");
									Writer("Here, you can battle farther and farther in with enemies getting stronger and yielding more experience points the farther you go in.");
									Enter();
									Color("red");
									Writer("But if your HP is under half after a battle, you loose!");
									Enter();
									Color("green");
									Writer("While the monsters themselves give only 10G, you can complete bounties for max profit!");
									Enter();
									Color("purple");
									Writer("You'll also be able to leave at anytime.");
									Enter();
									Color("cyan");
									Writer("It's free for you (other party members with pay on their own), so good luck!");
									Enter();
									Color();
									firstTime[7] = false;
								}

								Writer("HuntingMaster: OK! Let's go!");
								Enter();
								
								stop = false;
								int hunted = 0;
								while(!stop)
								{
									for(int i = 0; i < 51; i++, hunted++)
									{
										if(HP > HP/2)
										{
											if(hunted == 0 && i == 0)
											{
												Space();
												Writer("We're just starting out!");
												Enter();
											} else if(i == 0) {
												Space();
												Writer("Back to the beginning!");
												Enter();
											}
											else if(i > 0 && i < 10)
											{
												Space();
												Writer("We're getting deeper in!");
												Enter();
											}
											else if(i >= 10 && i < 31)
											{
												Space();
												Writer("Trucking along!");
												Enter();
											}
											else if(i >= 31 && i < 41)
											{
												Space();
												Writer("We're real deep!");
												Enter();
											}
											else if(i >= 41)
											{
												Space();
												Writer("Super deep in now. You don't even know where you are...");
											}
											else if(i == 50)
											{
												Space();
												Writer("Near the checkpoint now!!");
											}

											//random enemies
											re = rando.Next(0, 5);
											switch(re)
											{
												case 0:
													enemy.name = "Bushable";
												break;

												case 1:
													enemy.name = "Rockalike";
												break;

												case 2:
													enemy.name = "Talus";
												break;

												case 3:
													enemy.name = "Mini Landshark";
												break;

												case 4:
													enemy.name = "Shellatty";
												break;
											}
											MonsterEncounter(enemy.HP + (i * 2), enemy.SPE + ((int) i/2), enemy.ATK + ((int) i/3), enemy.name, i * 200, 10, false, both, teamMate: teamer);//Enemy generation (both is a variable)
										}
										else
										{
											Space();
											Writer("Woopsy! HP is too low! Time to go!");
											break;
										}
									}
									if(hunted >= 50)
									{
										Writer("Checkpoint! Wohoo!!");
										Enter();
										Writer("HuntingMaster: Hoo wee! Now, that was' fun, wasn' it? Now, do you wanna to leave? Or let the fun continue?");

										Space();
										Writer("(y/n)");
										option = Reader();
										switch(option) 
										{
											case "YES":
											case "Yes":
											case "yes":
											case "y":
											case "1":
												Writer("HuntingMaster: Alright! See ya!");
												stop = true;
												Save();
												Enter();
											break;

											case "NO":
											case "No":
											case "no":
											case "n":
											case "2":
												Writer("HuntingMaster: Well let's-a get-a going!!");
												Save();
												Enter();
											break;

											default:
												Writer("HuntingMaster: Huh? I didn't quite get that...");
												ErrorWrite();
												Enter();
											break;
										}
									}
								}
							break;
							
							//Apartments
							case "6":
								Space();
								Writer("You and Mark enter an apartment.");
								Enter();
								if(firstTime[6] == true)
								{
									Writer("Accountant: Hello! Welcome to this apartment complex! Would you like to rent an apartment?");
									Enter();
									Writer("Mark: I'll rent this time.");
									Enter();
									Writer("Mark hands over his and your ID, along with 6000G.");
									Enter();
									Writer("Ok! Here's your apartment keys. Don't loose them! One of our staff will see you to your room.");
									Enter();
									Writer(name + " and Mark: Thanks!");
									Enter();
									Writer("Employee [decrepid]: Here's your room.");
									Enter();
									Writer("Setting in, you see a marble kitchen with a microwave, oven, and sink along with 3 counters and a glass dinner table.");
									Space();
									Writer("In the halls are refine oak wood, and the carpets are expensive and clean. It has a university wallpaper which is ingrained into the stay.");
									Enter();
									Writer("Mark: Guess it's work the 6000 GOLD, huh " + name + "?");
									Enter();
									Writer(name + ": Yeah...");
									Enter();
									Color("bold");
									Writer("Welcome to your new apartment building!!");
									Enter();
									Writer("Here, you can organize yourself!");
									Enter();
									Color("green");
									Writer("If you want your inventory to be more organized, then you can go to your bag to organize it by switching around items and deleting them!");
									Enter();
									Color("yellow");
									Writer("Want to put something away? You can go to your drawer to take and put away items!");
									Enter();
									Color("red");
									Writer("Feeling tired? You can sleep to restore HP!");
									Enter();
									Color("purple");
									Writer("And finally, you can go over the tutorials in the game you've unlocked.");
									Enter();
									Color("blue");
									Writer("Have fun!");
									Enter();
									Color();
									firstTime[6] = false;
								}
								stop = false;
								while(stop != true)
								{
									Writer("What do you want to do? (1 - 5)");
									Space();
									Color("green");
									Writer("Bag, 1");
									Color("red");
									Writer("Drawer, 2");
									Color("cyan");
									Writer("Tutorials, 3");
									Color("purple");
									Writer("Sleep, 4");
									Color("blue");
									Writer("Use, 5");
									Color();
									Space();
									Writer("Leave, 6");
									Space();
									option = Reader();
									stop = false;
									switch(option)
									{
										case "1":
										case "bag":
										case "Bag":
										case "BAG":
											Space();
											Writer("Time to organize your bag!");
											Space();
											for(int i = 0; i < 11; i++)
											{
												Writer(inventory[i] + ", " + i);
											}
											Space();
											Writer("END, 11");
											Space();
											Writer("Which to switch? (0 - 11)");
											Space();
											option = Reader();
											stop2 = false;
											while(stop2 != true)
											{
												switch(option)
												{
													case "0":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 0)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														string temp;
														while(stop2 != true)
														{
															switch(option)
															{
																case "1":
																	temp = inventory[0];
																	inventory[0] = inventory[1];
																	inventory[1] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[0];
																	inventory[0] = inventory[2];
																	inventory[2] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[0];
																	inventory[0] = inventory[3];
																	inventory[3] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[0];
																	inventory[0] = inventory[4];
																	inventory[4] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[0];
																	inventory[0] = inventory[5];
																	inventory[5] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[0];
																	inventory[0] = inventory[6];
																	inventory[6] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[0];
																	inventory[0] = inventory[7];
																	inventory[7] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[0];
																	inventory[0] = inventory[8];
																	inventory[8] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[0];
																	inventory[0] = inventory[9];
																	inventory[9] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[0];
																	inventory[0] = inventory[10];
																	inventory[10] = temp;
																	Writer("0 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[0] = "null";
																	Space();
																	Writer("Switch or Delete Again? 0 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "1":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 1)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[1];
																	inventory[1] = inventory[0];
																	inventory[0] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[1];
																	inventory[1] = inventory[2];
																	inventory[2] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[1];
																	inventory[1] = inventory[3];
																	inventory[3] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[1];
																	inventory[1] = inventory[4];
																	inventory[4] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[1];
																	inventory[1] = inventory[5];
																	inventory[5] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[1];
																	inventory[1] = inventory[6];
																	inventory[6] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[1];
																	inventory[1] = inventory[7];
																	inventory[7] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[1];
																	inventory[1] = inventory[8];
																	inventory[8] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[1];
																	inventory[1] = inventory[9];
																	inventory[9] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 0)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[1];
																	inventory[1] = inventory[10];
																	inventory[10] = temp;
																	Writer("1 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 1 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[1] = "null";
																	Space();
																	Writer("Switch or Delete Again? 0 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 1)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "2":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 2)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[2];
																	inventory[2] = inventory[0];
																	inventory[0] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[2];
																	inventory[2] = inventory[1];
																	inventory[1] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[2];
																	inventory[2] = inventory[3];
																	inventory[3] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[2];
																	inventory[2] = inventory[4];
																	inventory[4] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[2];
																	inventory[2] = inventory[5];
																	inventory[5] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[2];
																	inventory[2] = inventory[6];
																	inventory[6] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[2];
																	inventory[2] = inventory[7];
																	inventory[7] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[2];
																	inventory[2] = inventory[8];
																	inventory[8] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[2];
																	inventory[2] = inventory[9];
																	inventory[9] = temp;
																	Writer("1 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[2];
																	inventory[2] = inventory[10];
																	inventory[10] = temp;
																	Writer("2 was switched for " + inventory[2] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[2] = "null";
																	Space();
																	Writer("Switch or Delete Again? 2 is " + inventory[2] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 2)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "3":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 3)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[3];
																	inventory[3] = inventory[0];
																	inventory[0] = temp;
																	Writer("3 was switched for " + inventory[0] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[0] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[3];
																	inventory[3] = inventory[1];
																	inventory[1] = temp;
																	Writer("3 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[3];
																	inventory[3] = inventory[2];
																	inventory[2] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[3];
																	inventory[3] = inventory[4];
																	inventory[4] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[3];
																	inventory[3] = inventory[5];
																	inventory[5] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[3];
																	inventory[3] = inventory[6];
																	inventory[6] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[3];
																	inventory[3] = inventory[7];
																	inventory[7] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[3];
																	inventory[3] = inventory[8];
																	inventory[8] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[3];
																	inventory[3] = inventory[9];
																	inventory[9] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[3];
																	inventory[3] = inventory[10];
																	inventory[10] = temp;
																	Writer("3 was switched for " + inventory[3] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[3] = "null";
																	Space();
																	Writer("Switch or Delete Again? 3 is " + inventory[3] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 3)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "4":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 4)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[4];
																	inventory[4] = inventory[0];
																	inventory[0] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[4];
																	inventory[4] = inventory[1];
																	inventory[1] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[4];
																	inventory[4] = inventory[2];
																	inventory[2] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[4];
																	inventory[4] = inventory[3];
																	inventory[3] = temp;
																	Writer("4 was switched for " + inventory[1] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[1] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[4];
																	inventory[4] = inventory[5];
																	inventory[5] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[4];
																	inventory[4] = inventory[6];
																	inventory[6] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[4];
																	inventory[4] = inventory[7];
																	inventory[7] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[4];
																	inventory[4] = inventory[8];
																	inventory[8] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[4];
																	inventory[4] = inventory[9];
																	inventory[9] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[4];
																	inventory[4] = inventory[10];
																	inventory[10] = temp;
																	Writer("4 was switched for " + inventory[4] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[4] = "null";
																	Space();
																	Writer("Switch or Delete Again? 4 is " + inventory[4] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 4)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "5":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 5)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[5];
																	inventory[5] = inventory[0];
																	inventory[0] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[5];
																	inventory[5] = inventory[1];
																	inventory[1] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[5];
																	inventory[5] = inventory[2];
																	inventory[2] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[5];
																	inventory[5] = inventory[3];
																	inventory[3] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[5];
																	inventory[5] = inventory[4];
																	inventory[4] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[5];
																	inventory[5] = inventory[6];
																	inventory[6] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 15is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[5];
																	inventory[5] = inventory[7];
																	inventory[7] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[5];
																	inventory[5] = inventory[8];
																	inventory[8] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[5];
																	inventory[5] = inventory[9];
																	inventory[9] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[5];
																	inventory[5] = inventory[10];
																	inventory[10] = temp;
																	Writer("5 was switched for " + inventory[5] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[5] = "null";
																	Space();
																	Writer("Switch or Delete Again? 5 is " + inventory[5] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 5)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "6":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 6)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[6];
																	inventory[6] = inventory[0];
																	inventory[0] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[6];
																	inventory[6] = inventory[1];
																	inventory[1] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[6];
																	inventory[6] = inventory[2];
																	inventory[2] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[6];
																	inventory[6] = inventory[3];
																	inventory[3] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[6];
																	inventory[6] = inventory[4];
																	inventory[4] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[6];
																	inventory[6] = inventory[5];
																	inventory[5] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[6];
																	inventory[6] = inventory[7];
																	inventory[7] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[6];
																	inventory[6] = inventory[8];
																	inventory[8] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[6];
																	inventory[6] = inventory[9];
																	inventory[9] = temp;
																	Writer("1 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[6];
																	inventory[6] = inventory[10];
																	inventory[10] = temp;
																	Writer("6 was switched for " + inventory[6] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[6] = "null";
																	Space();
																	Writer("Switch or Delete Again? 6 is " + inventory[6] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 6)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "7":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 7)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[7];
																	inventory[7] = inventory[0];
																	inventory[0] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[7];
																	inventory[7] = inventory[1];
																	inventory[1] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[7];
																	inventory[7] = inventory[2];
																	inventory[2] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[7];
																	inventory[7] = inventory[3];
																	inventory[3] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[7];
																	inventory[7] = inventory[4];
																	inventory[4] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[7];
																	inventory[7] = inventory[5];
																	inventory[5] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[7];
																	inventory[7] = inventory[6];
																	inventory[6] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[7];
																	inventory[7] = inventory[8];
																	inventory[8] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[7];
																	inventory[7] = inventory[9];
																	inventory[9] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[7];
																	inventory[7] = inventory[10];
																	inventory[10] = temp;
																	Writer("7 was switched for " + inventory[7] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[7] = "null";
																	Space();
																	Writer("Switch or Delete Again? 7 is " + inventory[7] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 7)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "8":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 8)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[8];
																	inventory[8] = inventory[0];
																	inventory[0] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[8];
																	inventory[8] = inventory[1];
																	inventory[1] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[8];
																	inventory[8] = inventory[2];
																	inventory[2] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[8];
																	inventory[8] = inventory[3];
																	inventory[3] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[8];
																	inventory[8] = inventory[4];
																	inventory[4] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[8];
																	inventory[8] = inventory[5];
																	inventory[5] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[8];
																	inventory[8] = inventory[6];
																	inventory[6] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[8];
																	inventory[8] = inventory[7];
																	inventory[7] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[8];
																	inventory[8] = inventory[9];
																	inventory[9] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[8];
																	inventory[8] = inventory[10];
																	inventory[10] = temp;
																	Writer("8 was switched for " + inventory[8] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[8] = "null";
																	Space();
																	Writer("Switch or Delete Again? 8 is " + inventory[8] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 8)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "9":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 9)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[9];
																	inventory[9] = inventory[0];
																	inventory[0] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "1":
																	temp = inventory[9];
																	inventory[9] = inventory[1];
																	inventory[1] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[9];
																	inventory[9] = inventory[2];
																	inventory[2] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[9];
																	inventory[9] = inventory[3];
																	inventory[3] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[9];
																	inventory[9] = inventory[4];
																	inventory[4] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[1];
																	inventory[1] = inventory[5];
																	inventory[5] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[9];
																	inventory[9] = inventory[6];
																	inventory[6] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[9];
																	inventory[9] = inventory[7];
																	inventory[7] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[9];
																	inventory[9] = inventory[8];
																	inventory[8] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "10":
																	temp = inventory[9];
																	inventory[9] = inventory[10];
																	inventory[10] = temp;
																	Writer("9 was switched for " + inventory[9] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[9] = "null";
																	Space();
																	Writer("Switch or Delete Again? 9 is " + inventory[9] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 9)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "10":
														Space();
														Writer("Switch with what?");
														Space();
														for(int i = 0; i < 11; i++)
														{
															if(i != 10)
															{
																Writer(inventory[i] + ", " + i);
															}
														}
														Space();
														Writer("DELETE, 11");
														Writer("END, 12");
														Space();
														option = Reader();
														while(stop2 != true)
														{
															switch(option)
															{
																case "0":
																	temp = inventory[10];
																	inventory[10] = inventory[0];
																	inventory[0] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "2":
																	temp = inventory[10];
																	inventory[10] = inventory[2];
																	inventory[2] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "3":
																	temp = inventory[10];
																	inventory[10] = inventory[3];
																	inventory[3] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "4":
																	temp = inventory[10];
																	inventory[10] = inventory[4];
																	inventory[4] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "5":
																	temp = inventory[10];
																	inventory[10] = inventory[5];
																	inventory[5] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "6":
																	temp = inventory[10];
																	inventory[10] = inventory[6];
																	inventory[6] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "7":
																	temp = inventory[10];
																	inventory[10] = inventory[7];
																	inventory[7] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "8":
																	temp = inventory[10];
																	inventory[10] = inventory[8];
																	inventory[8] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "9":
																	temp = inventory[10];
																	inventory[10] = inventory[9];
																	inventory[9] = temp;
																	Writer("10 was switched for " + inventory[10] + "!");
																	temp = "";
																	Space();
																	Writer("Switch Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "11":
																	Space();
																	Writer("Deleted!");
																	inventory[10] = "null";
																	Space();
																	Writer("Switch or Delete Again? 10 is " + inventory[10] + ".");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;

																case "12":
																	stop2 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																	Space();
																	Writer("Switch with what?");
																	Space();
																	for(int i = 0; i < 11; i++)
																	{
																		if(i != 10)
																		{
																			Writer(inventory[i] + ", " + i);
																		}
																	}
																	Space();
																	Writer("DELETE, 11");
																	Writer("END, 12");
																	Writer("Which to switch? (0 - 12)");
																	Space();
																	option = Reader();
																break;
															}
														}
													break;

													case "11":
														stop2 = true;
													break;

													default:
														ErrorWrite();
														Writer("Time to organize your bag!");
														Space();
														for(int i = 0; i < 11; i++)
														{
															Writer(inventory[i] + ", " + i);
														}
														Space();
														Writer("END, 11");
														Space();
														Writer("Which to switch? (0 - 11)");
														Space();
														option = Reader();
														stop2 = false;
													break;
												}
											}
										break;

										case "2":
										case "drawer":
										case "Drawer":
										case "DRAWER":
											stop2 = false;
											while(stop2 != true)
											{
												Space();
												Writer("Which slot will you put away?");
												Space();
												for(int i = 0; i < 11; i++)
												{
													Writer(inventory[i] + ", " + i);
												}
												Space();
												Writer("TAKE FROM STORAGE, 11");
												Writer("END, 12");
												Space();
												option = Reader();
												int yo = 0;
												//Logic
												switch(option)
												{
													case "0":
														stop3 = false;
														yo = 0;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "1":
														stop3 = false;
														yo = 1;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "2":
														stop3 = false;
														yo = 2;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "3":
														stop3 = false;
														yo = 3;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "4":
														stop3 = false;
														yo = 4;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "5":
														stop3 = false;
														yo = 5;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "6":
														stop3 = false;
														yo = 6;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "7":
														stop3 = false;
														yo = 7;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "8":
														stop3 = false;
														yo = 8;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "9":
														stop3 = false;
														yo = 9;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "10":
														stop3 = false;
														yo = 10;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to put it in? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "1":
																	r = 1;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "2":
																	r = 2;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "3":
																	r = 3;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "4":
																	r = 4;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "5":
																	r = 5;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "6":
																	r = 6;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "7":
																	r = 7;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "8":
																	r = 8;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "9":
																	r = 9;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "10":
																	r = 10;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "11":
																	r = 11;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "12":
																	r = 12;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "13":
																	r = 13;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "14":
																	r = 14;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "15":
																	r = 15;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "16":
																	r = 16;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "17":
																	r = 17;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "18":
																	r = 18;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "19":
																	r = 19;
																	storage[r] = inventory[yo];
																	inventory[yo] = "null";
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "11":
														stop3 = false;
														yo = 0;
														while(stop3 == false)
														{
															Space();
															Writer("Which slot? (0 - 20)");
															Space();
															for(int i = 0; i < 20; i++)
															{
																Writer(storage[i] + ", " + i);
															}
															Space();
															Writer("END, 20");
															Space();
															Writer("Which slot to take from? (0 - 20)");
															option = Reader();
															int r = 0;
															switch(option)
															{
																case "0":
																	r = 0;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "1":
																	r = 1;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "2":
																	r = 2;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "3":
																	r = 3;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "4":
																	r = 4;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "5":
																	r = 5;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "6":
																	r = 6;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "7":
																	r = 7;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "8":
																	r = 8;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "9":
																	r = 9;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "10":
																	r = 10;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "11":
																	r = 11;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "12":
																	r = 12;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "13":
																	r = 13;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "14":
																	r = 14;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "15":
																	r = 15;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "16":
																	r = 16;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "17":
																	r = 17;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "18":
																	r = 18;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "19":
																	r = 19;
																	if(inventoryFull == false)
																	{
																		for(int i = 0; i < 11; i++)
																		{
																			switch(inventory[i])
																			{
																				case "null":
																					inventory[i] = storage[r];
																					storage[r] = "null";
																					i = 11;
																				break;

																				default:
																				break;
																			}
																		}
																	}
																	else
																	{
																		Writer("It seems you can't take anything out because your inventory is full!");
																		Space();
																		stop3 = true;
																	}
																break;

																case "20":
																	stop3 = true;
																	Space();
																break;

																default:
																	ErrorWrite();
																break;
															}
														}
													break;

													case "12":
														stop2 = true;
														Space();
													break;

													default:
														ErrorWrite();
													break;
												}
											}
										break;

										case "3":
										case "tutorials":
										case "tutorial":
										case "Tutorial":
										case "Tutorials":
										case "TUTORIALS":
										case "TUTORIAL":
											stop2 = false;
											while(stop2 == false)
											{	
												Space();
												Color();
												Writer("Which one? (1 - 7)");
												Space();
												for(int i = 0; i < 7; i++)
												{
													//firstTime = {true/*SPECIAL*/, true/*attacking, grabbing, running*/, 	true/*options*/, true/*enter*/, true/*shopping*/, true/*bounty board*/, 	true/*apartments*/, true}
													if(firstTime[i] == false && i != 3)
													{
														switch(i)
														{
															case 0:
																Writer("1: SPECIAL TUTORIAL");
															break;
	
															case 1:
																Writer("2: BATTLE TUTORIAL");
															break;
	
															case 2:
																Writer("3: OPTIONS TUTORIAL");
															break;
	
															case 4:
																Writer("4: SHOPPING TUTORIAL");
															break;
	
															case 5:
																Writer("5: BOUNTY TUTORIAL");
															break;
	
															case 6:
																Writer("6: APARTMENT TUTORIAL");
															break;
	
															default:
															break;
														}
													}
												}
												Space();
												Writer("Leave, 7");
												Space();
												option = Reader();
												Space();
												switch(option)
												{
													case "1":
														Space();
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
														Enter();
														Color("red");
														Writer("But beware, for Mark doesn't attack when you're using a SPECIAL Attack! So be careful!");
														Enter();
														Writer("Now, time for you to use your WILL!");
														Enter();
													break;

													case "2":
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
														Writer("Need to stale for a teammate? type 'Defend' or 3 and you'll take less damage. perfect for double-single (two ofyou and one foe) and doble-double (two of you and two foes) battles!");
														Enter();
														Color("blue");
														Writer("Maybe this fight ain't up for ya? Type 'Run' or 4 to try your chances at escape! You won't always succeedthough!");
														Enter();
														Color("green");
														Writer("And if you need to make a refil, your bag is always up to the task! All you have to do is type 'Grab' (or 5)!You already have three healing potions waiting for you!");
														Enter();
														Space();
														Color("red");
														Writer("Beware, for the enemy can Attack too! And if they are faster than you, their attack will hit first, and you candie! But like you, their attacks can also miss!");
														Enter();
														Space();
														Color("cyan");
														Writer("And finally, you can do devastating attacks to monsters with a SPECIAL Attack, though it's best to wait a littleto try it out.");
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
														Writer("So now, it's time to show this monster what you're made of!");
														Color("red");
														Enter();
													break;

													case "3":
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
														Enter();
													break;

													case "4":
														Space();
														Color("yellow");
														Writer("It's time to do some ", 2);
														Color("green");
														Writer("cash money!", 2);
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
													break;

													case "5":
														Color("bold");
														Writer("Time to get some bounties!");
														Enter();
														Color("yellow");
														Writer("When you compete a bounty, you get a substancial amout of GOLD, which can compensate for the change-cheap campaign.");
														Enter();
														Color("red");
														Writer("In order to complete a bounty, you need to defeat a certain amount of enemies.");
														Enter();
														Writer("Enemies are sorted into groups based on HP count: Easy (0 - 60HP), Medium (61 - 90HP), and Hard(91 - 190HP). You can even get bounties for Minibosses (191HP+)! The harder the enemy, the more the bounty'll be worth!");
														Enter();
														Writer("The higher your bounty level, the harder the enemies you can bounty for!");
														Enter();
														Writer("But you can only do one bounty at a time, so choose wisely!");
														Enter();
														Color("purple");
														Writer("You can randomly find a bounty with options of level of the monster, up to your own. When you shuffle, you get three options of a bounty. If you want to shuffle for three different ones, it cost 100G per shuffle.");
														Enter();
														Color("green");
														Writer("Once you complete enough bounties, your bounty level will increase, causing you to be able to hunt higher level monsters!");
														Enter();
														Writer("You can turn in your bounty at the Bounty Board in the city!");
														Enter();
														Color("bold");
														Writer("Now go out there and hunt some monsters and collect some bounties!");
														Enter();
														Color();
													break;

													case "6":
														Color("bold");
														Writer("Welcome to your new apartment building!!");
														Enter();
														Writer("Here, you can organize yourself!");
														Enter();
														Color("green");
														Writer("If you want your inventory to be more organized, then you can go to your bag to organize it by switching around items and deleting them!");
														Enter();
														Color("yellow");
														Writer("Want to put something away? You can go to your drawer to take and put away items!");
														Enter();
														Color("red");
														Writer("Feeling tired? You can sleep to restore HP!");
														Enter();
														Color("purple");
														Writer("And finally, you can go over the tutorials in the game you've unlocked.");
														Enter();
														Color("blue");
														Writer("Have fun!");
														Enter();
														Color();
													break;

													case "7":
														stop2 = true;
													break;

													default:
														ErrorWrite();
													break;
												}
											}
										break;

										case "4":
										case "Sleep":
										case "sleep":
										case "SLEEP":
											Space();
											Writer("You slept. HP sent to overmax!");
											Enter();
											Writer("Mark: It's a new day!");
											Writer(name + ": Meh.");
											HP = HEARTS + 2;
											Enter();
										break;

										case "5":
										case "Use":
										case "use":
										case "USE":
											Use();
										break;

										case "6":
										case "leave":
										case "Leave":
										case "LEAVE":
											Space();
											Writer("You and Mark left the apartment.");
											Space(2);
											stop = true;
										break;

										default:
											ErrorWrite();
										break;
									}
								}
							break;

							//Story
							case "7":
							
							break;

							default:
								ErrorWrite();
								Space();
								Writer("Where would you like to go? (1 - 7)");
								Space();
								Color("yellow");
								Writer("Cabin, 1");
								Color("blue");
								Writer("Diner, 2");
								Color("cyan");
								Writer("Bounty House, 3");
								Color("green");
								Writer("Charity House, 4");
								Color("purple");
								Writer("Hunt Zone, 5");
								Color("bold");
								Writer("Apartment, 6");
								Space();
								Color("red");
								Writer("Go to THE DRAGON, 7");
								Color();
								Space();
								option = Reader();
							break;
						}					
					}
				}
			}
			else if(From[3] == true)//forests ruins
			{

			}
			else if(From[4] == true)//springs refuse/2
			{

			}
			else
			{
				Writer("Joe mama jo ma joe jo mama joe ma joe joe joe ma joe ma joe joe joe mama. JOE-");
				Enter();
				Credits();
			}
			}
		}

		public static void Credits()
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

		public static void Greetings2()
		{
			if(quickEnd == true)
			{
				Color("cyan");
				Writer("Debug Proffessor: Which one do you want?");
				Space();
				Writer("Forest Moutains, 1");
				Writer("Forest Mines, 2");
				Writer("Hills, 3");
				Writer("Springs Good Guy, 4");
				Writer("Springs Bad Guy, 5");
				Space();
				Writer("Normal Playthrough, 6");
				Writer("Endgame Stats Playthrough, 7");
				Space();
				Color();
				option = Reader();
				bool seiljgrndjgh = false;
				while(seiljgrndjgh != true)
				{
					switch(option)
					{
						case "1":
							Space();
							Writer("Do you want to go to town? (y/n)");
							Space();
							option = Reader();
							stop = false;
							while(stop == false)
							{
								switch(option)
								{
									case "1":
									case "yes":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[2] = true;
										ending[1] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									case "2":
									case "no":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[2] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									default:
										ErrorWrite();
										Enter();
										Writer("Do you want to go to town? (y/n)");
										Space();
										option = Reader();
									break;
								}
							}
						break;

						case "2":
							Space();
							Writer("Do you want to go to town? (y/n)");
							Space();
							option = Reader();
							while(stop == false)
							{
								switch(option)
								{
									case "1":
									case "yes":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[3] = true;
										ending[1] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									case "2":
									case "no":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[3] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									default:
										ErrorWrite();
										Enter();
										Writer("Do you want to go to town? (y/n)");
										Space();
										option = Reader();
									break;
								}
							}
						break;

						case "3":
							Space();
							Writer("Do you want to go to town? (y/n)");
							Space();
							option = Reader();
							while(stop == false)
							{
								switch(option)
								{
									case "1":
									case "yes":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[1] = true;
										ending[1] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									case "2":
									case "no":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[1] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									default:
										ErrorWrite();
										Enter();
										Writer("Do you want to go to town? (y/n)");
										Space();
										option = Reader();
									break;
								}
							}
						break;

						case "4":
							Space();
							Writer("Do you want to go to town? (y/n)");
							Space();
							option = Reader();
							while(stop == false)
							{
								switch(option)
								{
									case "1":
									case "yes":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[0] = true;
										ending[1] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									case "2":
									case "no":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[0] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									default:
										ErrorWrite();
										Enter();
										Writer("Do you want to go to town? (y/n)");
										Space();
										option = Reader();
									break;
								}
							}
						break;

						case "5":
							Space();
							Writer("Do you want to go to town? (y/n)");
							Space();
							option = Reader();
							while(stop == false)
							{
								switch(option)
								{
									case "1":
									case "yes":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[4] = true;
										ending[1] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									case "2":
									case "no":
										MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
										From[4] = true;
										stop = true;
										EndGame();
										Credits();
										End();
									break;

									default:
										ErrorWrite();
										Enter();
										Writer("Do you want to go to town? (y/n)");
										Space();
										option = Reader();
									break;
								}
							}
						break;

						case "6":
							Color("cyan");
							Writer("Debug Proffessor: Ok");
							Color();
							Thread.Sleep(1000);
							Console.Clear();
							stop = true;
							seiljgrndjgh = true;
						break;

						case "7":
							MonsterEncounter(0, 0, 0, "Beat Me Up.png", 88000F, 5000);
							Space();
							Console.Clear();
							stop = true;
							seiljgrndjgh = true;
						break;

						default:
							ErrorWrite();
							Color("cyan");
							Writer("Debug Proffessor: Which one do you want?");
							Space();
							Writer("Forest Moutains, 1");
							Writer("Forest Mines, 2");
							Writer("Hills, 3");
							Writer("Springs Good Guy, 4");
							Writer("Springs Bad Guy, 5");
							Space();
							Writer("Normal Playthrough, 6");
							Space();
							Color();
							option = Reader();
						break;
					}
				}
			}
		}
		public static void Greetings()
		{
			if(name.Replace(" ", "") == "")
			{
				name = "Samuel";
			}
			if(name.Replace(" ", "") == "dare")
			{
				Color("cyan");
				Writer("Activated 'DEBUG' cheat. HAPPY CHEATING!");
				Color("bold");
				name = "o";
				WILL = 300;
			}
			if(name.Replace(" ", "").ToLower() == "silveratom")
			{
				Color("cyan");
				Writer("Never stand where he once stood.");
				Thread.Sleep(400);
				End();
			}
			if(name.Replace(" ", "") == "desmos")
			{
				for(int i = 0; i < inventory.Length - 2; i++)
				{
					inventory[i] = "potion +";
				}
				quickEnd = true;
			}
			if(name.Replace(" ", "") == "FromFM")
			{
				Writer("YOOOOOOOOOOOOOOOOOOOOOOUUUUUUUUUUUUUUUUUUUUUUUUUU");
				From[2] = true;
				inventory[0] = "potion +";
				inventory[1] = "potion +";
				inventory[2] = "potion +";
				inventory[3] = "potion +";
				inventory[4] = "potion +";
				inventory[5] = "potion +";
				inventory[6] = "potion +";
				inventory[7] = "potion +";
				inventory[8] = "potion +";
				inventory[9] = "potion +";
			}
			if(name.Replace(" ", "") == "Sus" || name.Replace(" ", "") == "sus")
			{
				Color("bold");
				Writer("BUM BUM BUM BUM BUM BUM BUM. BUMBUMBUM.ඞඞඞ");
				Space();
			}
			if(name.Replace(" ", "") == "Jon")
			{
				Color("red");
				Writer("Amogus");
				Color();
			}
			if(name.Replace(" ", "") == "SonGohan")
			{
				Color("bold");
				Writer("YOU ENABLED THE 'JUNK' CHEAT. HAPPY CHEATING!");
				inventory[0] = "junk";
				inventory[1] = "junk";
				inventory[2] = "junk";
				inventory[3] = "junk";
				inventory[4] = "junk";
				inventory[5] = "junk";
				inventory[6] = "junk";
				inventory[7] = "junk";
				inventory[8] = "junk";
				inventory[9] = "junk";
			}
			if(name.Replace(" ", "").ToLower() == "silver")
			{
				Writer("ACTIVATED \"DEBUGGER'S GOLD\" CHEAT! Welcome, Master.");
				Space();
				Color("bold");
				Writer("Enter area number: ", 2);
				Space();
				option = Console.ReadLine();
				area = Convert.ToInt32(option);
				for(int i = 0; i < 5; i++)
				{
					inventory[i] = "potion +";
				}
				name = "SilverAtom";
				quickEnd = true;
			}
			if(name == "01001101 01110010 00101110 00100000 01000100 01100101 01100010 01110101 01100111 00100000 01110011 01100001 01111001 01110011 	00111010 00100000 01000100 01101111 01101110 00100111 01110100 00100000 01110101 01110011 01100101 00100000 01110100 01101000 01101001 01110011 	00100000 01100011 01101000 01100101 01100001 01110100 00100000 01110101 01101110 01101100 01100101 01110011 01110011 00100000 01111001 01101111 	01110101 00100000 01110111 01100001 01101110 01110100 00100000 01110100 01101111 00100000 01100010 01100101 00100000 01101011 01101001 01101100 	01101100 01100101 01100100 00100000 01101001 01101110 00100000 01100010 01100101 01100100 00100001")
			{
				Writer("01011001 01101111 01110101 00100000 01100101 01101110 01100001 01100010 01101100 01100101 01100100 00100000 01110100 01101000 01100101 	00100000 00100010 01000100 01000101 00101101 01000100 01000101 00101101 01000100 01000101 01000101 01000101 01000101 01000101 01000101 	01000101 01000101 01000101 01000101 01000101 01000101 01000101 01000101 01000101 01000101 00100010 00100000 00110001 00110010 00110011 	00110100 00110101 00110110 00110111 00111000 00110111 00110110 00110101 00110100 00110010 00110000 00111001 01101001 00110011 01110101 	00111000 00110010 00110100 00111000 00110111 00110100 00110101 00111000 00110000 00111001 00110101 01101001 00110010 00110011 00110100 	00110101 00110111 00110011 00110010 00110000 00110011 01100101 01110101 01101010 00111000 00110111 00110010 00110011 01111001 00111000 	00110011 00111001 00111000 00111000 00110011 00110111 00110101 00110000 00111000 00110100 00110011 00111001 00110100 00111000 00110100 	00111000 00111001 00110010 00110010 00110000 00110011 00111001 00111000 00111000 00110100 00110111 00110101 00110111 00110101 00110111 	00110111 00111000 00111001 00110011 00110010 00111001 00101101 01100101 00111101 00111101 00111101 00110010 00111000 00111001 00110010 	00111001 00111000 00110100 00100000 01000011 01001000 01000101 01000001 01010100 00101110 00100000 01001000 01000001 00101101 01001000 	01000001 00101101 01000001 01001000 00101101 01000001 01001000 01000001 01001000 01000001 01001000 01000001 01001000 01000001 01001000 	01000001 01001000 01000001 01001000 01000001 01001010 01110101 01011101 00101101 01110111 01100101 01110010 00110000 01100110 01100111 	01110100 01110011 01101001 01101010 01110000 01101110 01101000 00101100 01101101 01100110 01100100 01111000 01101110 01100111 01110101 	01111001 01101011 00101100 01101000 01101010 01110010 01110011 01110100 01100010 01100101 01100110 01110010 00101110 01101001 01110011 	01100101 01100111 01110011 01101000 01110011 01101100 01100101 01110010 01100010 01100101 01110010 01110101 01101000 01100010 01110010 	01100111 01101100 01101111 01110011 01101001 01110101 01100101 01100010 01100001 01100110 01110111 00111011 01101111 01110010 01100101 	01110100 01110011 01101000 00101110 01110010 01100100 01101010 01101011 01110101 01100110 01101001 01101100 01101111 00111011 01101000 	01101001 00111011 00100111 01101100 00101100 00100111 01110011 01111010 01110000 01101001 01101010 01100001 01100111 01110100 00101101 	01110010 01110111 01100110 01100101 01101011 01101101 00100000 00101110");
				ATK = 2147483647;
				HP = 2147483647;
				HEARTS = 2147483647;
				SPE = 2147483647;
				WILL = 9999;
				EXPNeed = 2147483647;
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
			if(name.Replace(" ", "") == "Saver")
			{
				Color("bold");
				Writer("Enter area number: ", 2);
				Space();
				option = Console.ReadLine();
				area = Convert.ToInt32(option);
				HEARTS = 100;
				HP = 102;
				ATK = 30;
				SPE = 30;
				EXPNeed = 4500;
				for(int i = 0; i < 5; i++)
				{
					inventory[i] = "potion +";
				}
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
			if(name == "Akhna Zone")
			{
				Space();
				Color("green");
				Writer("People who don't know: :D");
				Color("red");
				Writer("People who know: 💀");
				Color("null");
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
				WILL = 999;
			}
			if(name.Replace(" ", "") == "fuck" || name.Replace(" ", "") == "bitch" || name.Replace(" ", "") == "ass" || name.Replace(" ", "") == "cum" || 	name.Replace(" ", "") == "bastard")
			{
				Space(4);
				Writer("Ok, no.");
				End(0);
			}
			if(name.Replace(" ", "") == "assfart" || name.Replace(" ", "") == "myass")
			{
				Space(3);
				Writer("Save it for Pokémon...");
				End(0);
			}
			if(name.Replace(" ", "") == "mybutt")
			{
				Space(2);
				Writer("*giggling* not funny.");

				Color("black");
				Space();
				Writer("SilverAtom [whispering]: You probably talk out of your arse.");
				Color("null");
			}
			if(name.Replace(" ", "") == "Buttsex")
			{
				Color("red");
				Writer("I HATE LOSING LIKE WINNING HATES ME!!");
				End();
			}
			if(name.Replace(" ", "") == "oopaloopa")
			{
				Space();
				Writer("Krillin: For the last time Goku I'm not an oopaloopa!");
			}
			if(name.Replace(" ", "") == "ur mom")
			{
				Space(2);
				Writer("Plz no.");
			}
			if(name.Replace(" ", "") == "sup gamr")
			{
				Space();
				Writer("'Sup with you.");
			}
			if(name.Replace(" ", "") == "Ethan")
			{
				Space();
				Color("bold");
				Writer("Remember kids: Don't put your real name online!");
				Enter();
				Color("red");
				Writer("I NOW KNOW YOUR LOCATION.");
			}
		}

		public static void Shuffle()
		{
			//First Bounty Choice
												for(int r = 0; r < 3; r++)
												{
													re = rando.Next(1, 4);
													switch(re)
													{
														case 1:
															Bounty1[r] = 1;
															re = rando.Next(800, 2000);
															bountyCostings[0] = re;
														break;

														case 2:
															if(bountyLevel >= 2)
															{
																Bounty1[r] = 2;
																re = rando.Next(2000, 10000);
																bountyCostings[0] = re;
															}
															else
															{
																Bounty1[r] = 1;
																re = rando.Next(800, 2000);
																bountyCostings[0] = re;
															}
														break;

														case 3:
															if(bountyLevel >= 3)
															{
																Bounty1[r] = 3;
																re = rando.Next(10000, 120000);
																bountyCostings[0] = re;
															}
															else
															{
																if(bountyLevel >= 2)
																{
																	Bounty1[r] = 2;
																	re = rando.Next(2000, 10000);
																	bountyCostings[0] = re;
																}
																else
																{
																	Bounty1[r] = 1;
																	re = rando.Next(800, 2000);
																	bountyCostings[0] = re;
																}
															}
														break;
													}
												}
												if(Bounty1[0] == 1)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty1[0] == 2)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty1[0] == 3)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[0] + "), 1");
												Space();
												//Second Bounty Choice
												for(int r = 0; r < 3; r++)
												{
													re = rando.Next(1, 4);
													switch(re)
													{
														case 1:
															Bounty2[r] = 1;
															re = rando.Next(800, 2000);
															bountyCostings[1] = re;
														break;

														case 2:
															if(bountyLevel >= 2)
															{
																Bounty2[r] = 2;
																re = rando.Next(2000, 10000);
																bountyCostings[1] = re;
															}
															else
															{
																Bounty2[r] = 1;
																re = rando.Next(800, 2000);
																bountyCostings[1] = re;
															}
														break;

														case 3:
															if(bountyLevel >= 3)
															{
																Bounty2[r] = 3;
																re = rando.Next(10000, 120000);
																bountyCostings[1] = re;
															}
															else
															{
																if(bountyLevel >= 2)
																{
																	Bounty2[r] = 2;
																	re = rando.Next(2000, 10000);
																	bountyCostings[1] = re;
																}
																else
																{
																	Bounty2[r] = 1;
																	re = rando.Next(800, 2000);
																	bountyCostings[1] = re;
																}
															}
														break;
													}
												}
												if(Bounty2[0] == 1)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty2[0] == 2)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty2[0] == 3)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[1] + "), 2");
												Space();
												//Third Bounty Choice
												for(int r = 0; r < 3; r++)
												{
													re = rando.Next(1, 4);
													switch(re)
													{
														case 1:
															Bounty3[r] = 1;
															re = rando.Next(800, 2000);
															bountyCostings[2] = re;
														break;

														case 2:
															if(bountyLevel >= 2)
															{
																Bounty3[r] = 2;
																re = rando.Next(2000, 10000);
																bountyCostings[2] = re;
															}
															else
															{
																Bounty3[r] = 1;
																re = rando.Next(800, 2000);
																bountyCostings[2] = re;
															}
														break;

														case 3:
															if(bountyLevel >= 3)
															{
																Bounty3[r] = 3;
																re = rando.Next(10000, 120000);
																bountyCostings[2] = re;
															}
															else
															{
																if(bountyLevel >= 2)
																{
																	Bounty3[r] = 2;
																	re = rando.Next(800, 2000);
																	bountyCostings[2] = re;
																}
																else
																{
																	Bounty3[r] = 1;
																	re = rando.Next(800, 2000);
																	bountyCostings[2] = re;
																}
															}
														break;
													}
												}
												if(Bounty3[0] == 1)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty3[0] == 2)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty3[0] == 3)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[2] + "), 3");
												Space();
		}
		public static void Shuffle2()
		{
			//First Bounty Choice
												if(Bounty1[0] == 1)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty1[0] == 2)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty1[0] == 3)
												{
													if(Bounty1[1] == 2)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty1[1] == 1)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty1[1] == 3)
													{
														if(Bounty1[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty1[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty1[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[0] + "), 1");
												//Second Bounty Choice
												if(Bounty2[0] == 1)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty2[0] == 2)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty2[0] == 3)
												{
													if(Bounty2[1] == 2)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty2[1] == 1)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty2[1] == 3)
													{
														if(Bounty2[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty2[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty2[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[1] + "), 2");
												//Third Bounty Choice
												if(Bounty3[0] == 1)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 3 easy enemies");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
												}
												if(Bounty3[0] == 2)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 3 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 2 medium enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 medium enemy");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
												}
												if(Bounty3[0] == 3)
												{
													if(Bounty3[1] == 2)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 2 medium enemies, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
													}
													if(Bounty3[1] == 1)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 easy enemy, 1 medium enemy, 1 hard enemy");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 2 easy enemies, 1 hard enemy");
														}
													}
													if(Bounty3[1] == 3)
													{
														if(Bounty3[2] == 3)
														{
															Writer("KILL: 3 hard enemies");
														}
														if(Bounty3[2] == 2)
														{
															Writer("KILL: 1 medium enemy, 2 hard enemies");
														}
														if(Bounty3[2] == 1)
														{
															Writer("KILL: 1 easy enemy, 2 hard enemies");
														}
													}
												}
												Console.Write(" (Cost: " + bountyCostings[2] + "), 3");
		}
	}
}