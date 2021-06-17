using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    GameObject MainCam;
    
    private void Awake()
    {
        MainCam = GameObject.Find("Main Camera");
    }
    private void OnMouseDown()
    {
        MainCam.GetComponent<Game>().check(gameObject.name);
    }
}
