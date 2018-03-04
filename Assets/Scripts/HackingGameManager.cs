using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackingGameManager : MonoBehaviour {

	public delegate void WorldTick();
	public static event WorldTick OnTick;

	public bool HackRunning = true;

	// Use this for initialization
	void Start () {
		StartCoroutine(WorldTicking());
	}

	IEnumerator WorldTicking(){
		while(HackRunning){
			yield return new WaitForSeconds(1);
			if( OnTick != null){
				OnTick();
			}
		}
		yield return 0;
	}
}
