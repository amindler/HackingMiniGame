using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityManager : MonoBehaviour {

	public static int ResourcePower = 0;

	// Use this for initialization
	void Start () {

	}

	public static void AddResourcePower(int amount){
		ResourcePower += amount;
	}
}
