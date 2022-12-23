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
// Just for all the enemies in the game

namespace DRAGONLake
{
	public static partial class Functions
	{
		public static Monster basic = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		//Springs
		public static Monster n000 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Mossatle",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n001 = new Monster() {
			hp = 24,
			speed = 4,
			attack = 3,
			monName = "Shellaty",
			exp = 900F,
			gold = 120,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 4, 2, -5},
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n002 = new Monster() {
			hp = 1,
			speed = 17,
			attack = 18,
			monName = "Kamikazimite",
			exp = 1100F,
			gold = 0,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n003 = new Monster() {
			hp = 42,
			speed = 7,
			attack = 5,
			monName = "Zabuzabuzabuzabuza",
			exp = 1200F,
			gold = 500,
			
			boss = true,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Great-great Sla-slash",
			powerAttackHit = 13,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 2,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = new int[] {1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 0},
			
			weightTwo = null,
			
			message = " block-blocks the way-way!"
		};

		public static Monster n005 = new Monster() {
			hp = 32,
			speed = 18,
			attack = 6,
			monName = "Moronical Swordsman",
			exp = 2100F,
			gold = 490,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n006 = new Monster() {
			hp = 38,
			speed = 21,
			attack = 4,
			monName = "Dual Swordsman",
			exp = 900F,
			gold = 540,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n007 = new Monster() {
			hp = 32,
			speed = 16,
			attack = 6,
			monName = "Greatblade Swordsman",
			exp = 1250F,
			gold = 700,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n008 = new Monster() {
			hp = 45,
			speed = 20,
			attack = 8,
			monName = "Jujutsu Guysen",
			exp = 1400F,
			gold = 700,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n009 = new Monster() {
			hp = 75,
			speed = 30,
			attack = 4,
			monName = "Madahaira Uchairha",
			exp = 1600F,
			gold = 600,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n010 = new Monster() {
			hp = 75,
			speed = 40,
			attack = 6,
			monName = "Lumpy",
			exp = 2200F,
			gold = 900,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Armor Breaker",
			powerAttackHit = 12,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 3,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {2, 5, -5, -5},
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n011 = new Monster() {
			hp = 55,
			speed = 32,
			attack = 14,
			monName = "Greatblade Wielder Keyritoe",
			exp = 1900F,
			gold = 2400,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n012 = new Monster() {
			hp = 95,
			speed = 90,
			attack = 10,
			monName = "Mysterious Rowdy Swordsman",
			exp = 6300F,
			gold = 2400,
			
			boss = true,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Breakage",
			powerAttackHit = 23,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = new int[] {0, 1, 1, 1, 0, 1, 1, 1, 0, 1},
			
			weightTwo = null,
			
			message = " backflips into battle!"
		};

		public static Monster n013 = new Monster() {
			hp = 67,
			speed = 3,
			attack = 12,
			monName = "Bunnibaby",
			exp = 2400F,
			gold = 50,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n014 = new Monster() {
			hp = 92,
			speed = 80,
			attack = 8,
			monName = "Fuzzile",
			exp = 2600F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n015 = new Monster() {
			hp = 130,
			speed = 20,
			attack = 5,
			monName = "Talus Large",
			exp = 3000F,
			gold = 1200,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 4, 4, -5},
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n016 = new Monster() {
			hp = 270,
			speed = 70,
			attack = 40,
			monName = "Bunnifierce",
			exp = 6000F,
			gold = 300,
			
			boss = true,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Body Slam",
			powerAttackHit = 30,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 3,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {2, 5, 3, 4},
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n017 = new Monster() {
			hp = 150,
			speed = 35,
			attack = 12,
			monName = "Mark Conjure",
			exp = 8200F,
			gold = 4000,
			
			boss = true,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Chain Slicer",
			powerAttackHit = 40,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 2,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = new int[] {0, 0, 1, 1, 2, 2, 1, 1, 0, 2},
			
			weightTwo = null,
			
			message = " readies his weapon for a duel!"
		};

		public static Monster n018 = new Monster() {
			hp = 99,
			speed = 999,
			attack = 9,
			monName = "Macro Man",
			exp = 999F,
			gold = 99,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 70,
			speedTwo = 22,
			attackTwo = 11,
			monNameTwo = "Rockalike Medium (Pet)",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "9,000 Click Catastrophe",
			powerAttackHit = 27,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 3,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
			
			weightTwo = new int[] {-5, 5, 5, -5},
			
			message = null
		};

		public static Monster n019 = new Monster() {
			hp = 180,
			speed = 40,
			attack = 8,
			monName = "Talus Large",
			exp = 4000F,
			gold = 900,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 3, 5, -5},
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n020 = new Monster() {
			hp = 190,
			speed = 60,
			attack = 14,
			monName = "Rockalike Large",
			exp = 4000F,
			gold = 230,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Rock Barrage",
			powerAttackHit = 28,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {2, 5, -5, -5},
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n021 = new Monster() {
			hp = 70,
			speed = 30,
			attack = 16,
			monName = "Dare Demon",
			exp = 5300F,
			gold = 400,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 90,
			speedTwo = 99,
			attackTwo = 4,
			monNameTwo = "Rockalike Medium (Pet)",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Stride, Ride, Destroy",
			powerAttackHit = 24,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 0,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = new int[] {0, 1, 1, 1, 0, 1, 1, 1, 0, 1},
			
			weightTwo = new int[] {-5, 0, 5, -5},
			
			message = null
		};

		public static Monster n022 = new Monster() {hp = 250,
			speed = 15,
			attack = 12,
			monName = "Monster Whippa Bruce",
			exp = 4500F,
			gold = 2400,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 100,
			speedTwo = 60,
			attackTwo = 20,
			monNameTwo = "\"John\" the Mad Talus Large",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Whip",
			powerAttackHit = 30,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 0,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Bash",
			powerAttackHitTwo = 40,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = false,
			hasPatternTwo = true,
			
			patternTwo = new int[] {1, 1, 0, 1, 1, 0, 1, 2, 2, 1},
			
			weight = null,
			pattern = new int[] {1, 1, 0, 1, 1, 0, 1, 2, 2, 1},
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n023 = new Monster() {hp = 400,
			speed = 11,
			attack = 20,
			monName = "Magmo Talus Medium 1",
			exp = 11000F,
			gold = 900,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 400,
			speedTwo = 12,
			attackTwo = 18,
			monNameTwo = "Magmo Talus Medium 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Magma Bash",
			powerAttackHit = 35,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Rock Bash",
			powerAttackHitTwo = 25,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = false,
			hasPatternTwo = true,
			
			patternTwo = new int[] {2, 2, 1, 2, 2, 1, 2, 2, 1, 0},
			
			weight = null,
			pattern = new int[] {1, 1, 2, 1, 1, 2, 1, 1, 2, 0},
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n024 = new Monster() {hp = 220,
			speed = 30,
			attack = 16,
			monName = "Magma Carvana",
			exp = 8000F,
			gold = 9000,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 4, -5, 2},
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n025 = new Monster() {hp = 270,
			speed = 41,
			attack = 12,
			monName = "Magmalike Large",
			exp = 14000F,
			gold = 900,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 160,
			speedTwo = 55,
			attackTwo = 14,
			monNameTwo = "Volcanaraptor",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 5, 5, 2},
			pattern = null,
			
			weightTwo = new int[] {-5, 5, -5, -5},
			
			message = null
		};

		
		public static Monster n026 = new Monster() {hp = 160,
			speed = 55,
			attack = 13,
			monName = "Volcanaraptor",
			exp = 12000F,
			gold = 600,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 220,
			speedTwo = 33,
			attackTwo = 15,
			monNameTwo = "Plavadactyl",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Lava Wing",
			powerAttackHitTwo = 30,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 2,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 5, -5, 3},
			pattern = null,
			
			weightTwo = new int[] {2, 5, -5, -5},
			
			message = null
		};

		public static Monster n027 = new Monster() {hp = 170,
			speed = 45,
			attack = 14,
			monName = "Plavadactyl 1",
			exp = 9000F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 250,
			speedTwo = 24,
			attackTwo = 16,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n028 = new Monster() {hp = 210,
			speed = 30,
			attack = 12,
			monName = "Plavadactyl 1",
			exp = 9500F,
			gold = 600,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 210,
			speedTwo = 40,
			attackTwo = 10,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n029 = new Monster() {hp = 310,
			speed = 70,
			attack = 20,
			monName = "Plavadactyl",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = true,
			
			hpTwo = 110,
			speedTwo = 15,
			attackTwo = 7,
			monNameTwo = "Crown Plavadactyl",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Magmo Cross",
			powerAttackHit = 35,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 2,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Lava Bath",
			powerAttackHitTwo = 0,
			powerAttackHealTwo = 60,
			
			isHealingTwo = true,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {3, 5, -2, -5},
			pattern = null,
			
			weightTwo = new int[] {5, -2, 0, 3},
			
			message = null
		};

		public static Monster n030 = new Monster() {hp = 525,
			speed = 79,
			attack = 22,
			monName = "Pscorpatriarbordactyl",
			exp = 200F,
			gold = 30,
			
			boss = true,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Bassault",
			powerAttackHit = 29,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 0,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = new int[] {0, 1, 1, 0, 0, 1, 1, 0, 4, 4},
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n031 = new Monster() {hp = 220,
			speed = 45,
			attack = 12,
			monName = "Plavadactyl 1",
			exp = 1400F,
			gold = 300,
			
			boss = false,
			doubleBattle = true,
			twoEnemy = true,
			
			hpTwo = 240,
			speedTwo = 55,
			attackTwo = 8,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 5, -5, 3},
			pattern = null,
			
			weightTwo = new int[] {-5, 5, 2, 4},
			
			message = null
		};

		public static Monster n032 = new Monster() {hp = 240,
			speed = 60,
			attack = 14,
			monName = "Plavadactyl 1",
			exp = 12000F,
			gold = 400,
			
			boss = false,
			doubleBattle = true,
			twoEnemy = true,
			
			hpTwo = 220,
			speedTwo = 60,
			attackTwo = 14,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 5, -5, 5},
			pattern = null,
			
			weightTwo = new int[] {-5, 5, -5, 5},
			
			message = null
		};

		public static Monster n033 = new Monster() {hp = 250,
			speed = 60,
			attack = 12,
			monName = "Plavadactyl 1",
			exp = 12000F,
			gold = 400,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 305,
			speedTwo = 35,
			attackTwo = 10,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Lava Wing",
			powerAttackHit = 28,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 2,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {1, 5, -5, -5},
			pattern = null,
			
			weightTwo = new int[] {-5, 5, -5, -2},
			
			message = null
		};

		public static Monster n034 = new Monster() {hp = 220,
			speed = 45,
			attack = 14,
			monName = "Plavadactyl 1",
			exp = 8000F,
			gold = 300,
			
			boss = false,
			doubleBattle = true,
			twoEnemy = true,
			
			hpTwo = 180,
			speedTwo = 75,
			attackTwo = 10,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 5, -5, -5},
			pattern = null,
			
			weightTwo = new int[] {-5, 5, -5, -5},
			
			message = null
		};

		public static Monster n035 = new Monster() {hp = 230,
			speed = 60,
			attack = 12,
			monName = "Plavadactyl 1",
			exp = 700F,
			gold = 300,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 230,
			speedTwo = 60,
			attackTwo = 12,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Lava Wing",
			powerAttackHit = 20,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 0,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Magma Wing",
			powerAttackHitTwo = 20,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {2, 5, -5, -5},
			pattern = null,
			
			weightTwo = new int[] {2, 5, -5, -5},
			
			message = null
		};

		
		public static Monster n036 = new Monster() {hp = 250,
			speed = 60,
			attack = 12,
			monName = "Plavadactyl 1",
			exp = 500F,
			gold = 300,
			
			boss = false,
			doubleBattle = true,
			twoEnemy = true,
			
			hpTwo = 250,
			speedTwo = 60,
			attackTwo = 12,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-5, 5, -5, 2},
			pattern = null,
			
			weightTwo = new int[] {-5, 5, -5, 2},
			
			message = null
		};

		public static Monster n037 = new Monster() {hp = 120,
			speed = 10,
			attack = 10,
			monName = "Strangled Plavadactyl",
			exp = 10F,
			gold = 0,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = false,
			hasPattern = true,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = new int[] {2, 2, 2, 2, 2, 2, 2, 2, 2, 2},
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n038 = new Monster() {hp = 250,
			speed = 60,
			attack = 6,
			monName = "Plavadactyl",
			exp = 4000F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n039 = new Monster() {hp = 230,
			speed = 70,
			attack = 4,
			monName = "Plavadactyl",
			exp = 3000F,
			gold = 70,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n040 = new Monster() {hp = 200,
			speed = 70,
			attack = 15,
			monName = "Plavadactyl 1",
			exp = 1000F,
			gold = 50,
			
			boss = false,
			doubleBattle = true,
			twoEnemy = true,
			
			hpTwo = 220,
			speedTwo = 50,
			attackTwo = 15,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Lava Wing",
			powerAttackHit = 30,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Ingeothrash",
			powerAttackHitTwo = 23,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {-3, 5, -5, -5},
			pattern = null,
			
			weightTwo = new int[] {-2, 5, 3, 1},
			
			message = " look for a kill!"
		};

		
		public static Monster n041 = new Monster() {hp = 260,
			speed = 90,
			attack = 17,
			monName = "Plavadactyl 1",
			exp = 1000F,
			gold = 40,
			
			boss = false,
			doubleBattle = true,
			twoEnemy = true,
			
			hpTwo = 290,
			speedTwo = 70,
			attackTwo = 18,
			monNameTwo = "Plavadactyl 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Lava Bath",
			powerAttackHit = 10,
			powerAttackHeal = 70,
			
			isHealing = true,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Relavax",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 50,
			
			isHealingTwo = true,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {5, 5, -5, -5},
			pattern = null,
			
			weightTwo = new int[] {3, 5, 3, 3},
			
			message = " lazily enter the fight!"
		};

		public static Monster n042 = new Monster() {hp = 360,
			speed = 90,
			attack = 20,
			monName = "Final Plavadactyl",
			exp = 600F,
			gold = 25,
			
			boss = false,
			doubleBattle = true,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Lava Wing",
			powerAttackHit = 50,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = new int[] {5, 5, -5, -5},
			pattern = null,
			
			weightTwo = null,
			
			message = " trots slowly to face you two."
		};

		public static Monster n043 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n044 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n045 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n046 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n047 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n048 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n049 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n050 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n051 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n052 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n053 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n054 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n055 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n056 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n057 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n058 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n059 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n060 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n061 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n062 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n063 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n064 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n065 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n066 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n067 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n068 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		/*; ) */public static Monster n069 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n070 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n071 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n072 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n073 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n074 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n075 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n076 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n077 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n078 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n079 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n080 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n081 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n082 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n083 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n084 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n085 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n086 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n087 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n088 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n089 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n090 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n091 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n092 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n093 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n094 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n095 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n096 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n097 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n098 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n099 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n100 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		
		public static Monster n101 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n102 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n103 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n104 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n105 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};


		public static Monster n106 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};

		public static Monster n107 = new Monster() {hp = 10,
			speed = 3,
			attack = 2,
			monName = "Monster",
			exp = 200F,
			gold = 30,
			
			boss = false,
			doubleBattle = false,
			twoEnemy = false,
			
			hpTwo = 10,
			speedTwo = 10,
			attackTwo = 1,
			monNameTwo = "Monster 2",
			
			teamMate = 0,
			
			status = "Fine",
			
			powerAttack = "Super Hit",
			powerAttackHit = 10,
			powerAttackHeal = 2,
			
			isHealing = false,
			isDefending = false,
			
			waitTime = 1,
			statusAfflict = "null",
			
			hasWeight = true,
			hasPattern = false,
			
			statusTwo = "Fine",
			
			powerAttackTwo = "Super Hit",
			powerAttackHitTwo = 10,
			powerAttackHealTwo = 2,
			
			isHealingTwo = false,
			isDefendingTwo = false,
			
			waitTimeTwo = 0,
			statusAfflictTwo = "null",
			
			hasWeightTwo = true,
			hasPatternTwo = false,
			
			patternTwo = null,
			
			weight = null,
			pattern = null,
			
			weightTwo = null,
			
			message = null
		};
	}
}