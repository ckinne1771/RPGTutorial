using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public BaseMageClass()
	{
		CharacterClassName = "Mage";
		CharacterClassDescription = "Adept in the arcane ways, can weild a wide variety of spells";
		Stamina = 12;
		Endurance = 14;
		Strength = 10;
		Intellect = 16;
	}

}
