using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharekterMoveMent : MonoBehaviour
{

    public bool inUse;
    private GameObject GameMaster;

    void OnMouseDown()
    {
        inUse = true;
         
        GameMaster.GetComponent<MouseStats>().Holding = this.gameObject;
    }
    // Use this for initialization
    void Start ()
    {
        GameMaster = GameObject.Find("GameMaster");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
