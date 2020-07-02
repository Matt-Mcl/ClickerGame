using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public TextScript counterScript;
	public TextScript gainsScript;
	public ButtonScript buttonScript;

	public PurchasableScript Item1Script;
	public PurchasableScript Item2Script;
	public PurchasableScript Item3Script;
	public PurchasableScript Item4Script;
	public PurchasableScript Item5Script;

	public PurchasableScript Upgrade2Script;

	private float gains = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Items", 0.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
		// 1: Add other items here for gains with respective multipliers.
		gains = (Item1Script.amount * Item1Script.rate) 
		+ (Item2Script.amount * Item2Script.rate)
		+ (Item3Script.amount * Item3Script.rate) 
		+ (Item4Script.amount * Item4Script.rate) 
		+ (Item5Script.amount * Item5Script.rate);  

		gains *= Upgrade2Script.globalItemRate;

		counterScript.ClickText("" + buttonScript.clicked);
		gainsScript.ClickText("Gaining " + gains + "/s from items");
	}

	// Updates every second
	private void Items () {
		buttonScript.clicked += gains;
	}
}
