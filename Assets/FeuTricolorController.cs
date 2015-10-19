using UnityEngine;
using System.Collections;

public class FeuTricolorController : MonoBehaviour {


    //GameObject gameObject; 
    private Rigidbody rb; 
    

    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>(); 
        GameObject FeuVert = transform.Find("SphereVerte").gameObject;
        GameObject FeuOrange = transform.Find("SphereOrange").gameObject;
        GameObject FeuRouge = transform.Find("SphereRouge").gameObject;

        FeuVert.SetActive(true);
        FeuOrange.SetActive(false);
        FeuRouge.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
