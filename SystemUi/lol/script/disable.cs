using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disable : MonoBehaviour {

    public GameObject tutor_1;
    public GameObject tutor_2;
    public Button button1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnDisable()
    {
        tutor_1.SetActive(false);
        tutor_2.SetActive(false);
        button1.gameObject.SetActive(false);
    }
}
