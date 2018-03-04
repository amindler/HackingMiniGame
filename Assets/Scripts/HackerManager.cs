using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackerManager : MonoBehaviour {

	public static int ResourcePower = 0;

	public Text ResourcePowerText;

	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		ResourcePowerText.text = ResourcePower.ToString();
	}

	public static void AddResourcePower(int amount){
		ResourcePower += amount;
	}
}
