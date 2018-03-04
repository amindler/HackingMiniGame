using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerationUnit : MonoBehaviour {

	public int currentResourceTick = 1;
	public int maxResourceTick = 4;

	public int ResourceUnitsGenerated = 1;

	public bool SecurityRGU = false;

	// Use this for initialization
	void Start () {
		HackingGameManager.OnTick += ResourceGeneration;
	}
	
	void ResourceGeneration(){
		if(currentResourceTick < maxResourceTick){
			currentResourceTick ++;
		} else {
			currentResourceTick = 1;
			GenerateResource();
		}
	}

	private void GenerateResource(){
		if(SecurityRGU == false){
			HackerManager.AddResourcePower(ResourceUnitsGenerated);
		} else {
			SecurityManager.AddResourcePower(ResourceUnitsGenerated);
		}
	}
}
