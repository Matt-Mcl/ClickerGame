using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasableScript : MonoBehaviour {

	public ButtonScript buttonScript;
	public TextScript textScript;

	public float cost; //Cost of item
	public float rate; //Gain per second, per item

	public float globalItemRate = 1; //Global modifier that can be set by items

	public int amount = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// General function for ran when any upgrade/item is bought.
	// Increases the amount of that upgrade/item and removes balance.
	private void General () {
		amount++;
		buttonScript.clicked -= cost;
	}

	public void BuyItem () {
		if (buttonScript.clicked >= cost) {
			General();
			cost *= 1.1f;
			textScript.ClickText("Cost: " + cost + "\nGain: " + rate);
		}
	}
	
	public void BuyUpgrade1 () {
		if (buttonScript.clicked >= cost) {
			General();
			buttonScript.rate *= 2;
			cost *= 2;
			textScript.ClickText("Double Click Income\nCost: " + cost);
		}
	}

	public void BuyUpgrade2 () {
		if (buttonScript.clicked >= cost) {
			General();
			globalItemRate *= 1.1f;
			cost *= 2;
			textScript.ClickText("Increase Item Income by 10%\nCost: " + cost);
		}
	}

}
