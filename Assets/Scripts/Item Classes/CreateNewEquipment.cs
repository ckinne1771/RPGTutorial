using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;
	private string[] itemNames = new string[4]{"Common", "Uncommon","Rare", "Legendary"};

	// Use this for initialization
	void Start () {
		CreateEquipment ();
		Debug.Log (newEquipment.ItemName);
		Debug.Log (newEquipment.ItemID.ToString());
		Debug.Log (newEquipment.ItemDescription.ToString());
		Debug.Log (newEquipment.EquipmentType.ToString());
		Debug.Log (newEquipment.Stamina.ToString());
		Debug.Log (newEquipment.Endurance.ToString());
		Debug.Log (newEquipment.Intellect.ToString());
		Debug.Log (newEquipment.Strength.ToString());
	}

	private void CreateEquipment()
	{
		newEquipment = new BaseEquipment ();
		newEquipment.ItemName = itemNames [Random.Range (0, 3)] + "Item";
		newEquipment.ItemDescription = "A peice of equipment.";
		newEquipment.ItemID = Random.Range (1, 101);
		ChooseItemType ();
		newEquipment.Stamina = Random.Range (1, 11);
		newEquipment.Endurance = Random.Range (1, 11);
		newEquipment.Intellect = Random.Range (1, 11);
		newEquipment.Strength = Random.Range (1, 11);
	}


	private void ChooseItemType()
{
		int randomTemp = Random.Range (1, 9);
		if (randomTemp == 1) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
		}
		if (randomTemp == 2) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ARMS;
		}
		if (randomTemp == 3) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
		}
		if (randomTemp == 4) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRING;
		}
		if (randomTemp == 5) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
		}
		if (randomTemp == 6) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
		}
		if (randomTemp == 7) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
		}
		if (randomTemp == 8) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
		}
		if (randomTemp == 9) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
		}

	}

}