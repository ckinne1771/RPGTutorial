﻿using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes{
		HEAD,
		CHEST,
		SHOULDERS,
		LEGS,
		FEET,
		ARMS,
		NECK,
		EARRING,
		RING,

}
	private EquipmentTypes equipmentType;
	private int spellEffectID;

	public EquipmentTypes EquipmentType {
		get{ return equipmentType;}
		set{ equipmentType = value;}
	}

	public int SpellEffectID {
		get{ return spellEffectID;}
		set{ spellEffectID = value;}
	}


}