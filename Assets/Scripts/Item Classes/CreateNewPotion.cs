using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;
	// Use this for initialization
	void Start () {
		CreatePotion ();
		Debug.Log (newPotion.ItemName);
		Debug.Log (newPotion.ItemID.ToString ());
		Debug.Log (newPotion.ItemDescription.ToString ());
		Debug.Log (newPotion.PotionType.ToString ());
		
	}
	
	private void CreatePotion(){
		newPotion = new BasePotion ();
		newPotion.ItemName = "Potion";
		newPotion.ItemDescription = "A potion";
		newPotion.ItemID = Random.Range (1, 101);
		ChoosePotionType ();
		
		
	}
	
	private void ChoosePotionType(){
		int randomTemp = Random.Range (0, 7);
		if (randomTemp ==1)
		{
			newPotion.PotionType = BasePotion.PotionTypes.ENDURANCE;
		}
		if (randomTemp ==2)
		{
			newPotion.PotionType = BasePotion.PotionTypes.ENERGY;
		}
		if (randomTemp ==3)
		{
			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
		}
		if (randomTemp ==4)
		{
			newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
		}
		if (randomTemp ==5)
		{
			newPotion.PotionType = BasePotion.PotionTypes.SPEED;
		}if (randomTemp ==6)
		{
			newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
		}
		if (randomTemp ==7)
		{
			newPotion.PotionType = BasePotion.PotionTypes.VITALITY;
		}
	}
	

}
