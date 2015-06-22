using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

public BaseWarriorClass(){
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A strong melee character. Great physical attack and defence.";
		Stamina = 15;
		Endurance = 12;
		Strength = 14;
		Intellect = 10;
	}
}
