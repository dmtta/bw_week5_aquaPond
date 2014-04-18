using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FishGod : MonoBehaviour {

	public FishScript fishPrint;
	List<FishScript> fishList = new List<FishScript>(); 

	// Use this for initialization
	void Start () {
		int counter = 0;
		while (counter < 100) {
			FishScript newFish = Instantiate(fishPrint, Random.insideUnitSphere * 10f, Random.rotation) as FishScript;
			fishList.Add(newFish);
			counter++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
