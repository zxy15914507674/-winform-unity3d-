using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using fvc.exp;
public class DataBaseTestLink : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(SqlHelper.DataBaseLinkTest());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
