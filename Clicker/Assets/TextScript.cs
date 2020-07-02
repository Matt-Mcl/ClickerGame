using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

	public Text message;

	// Use this for initialization
	void Start () {
		
	}
	
	void Awake () {
		message = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ClickText (string total) {
		message.text = total;
	}
}
