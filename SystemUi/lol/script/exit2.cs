using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit2 : MonoBehaviour {
    public GameObject tutor_1;
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Exit() {
        tutor_1.SetActive(false);
    }
}
