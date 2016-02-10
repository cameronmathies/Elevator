using UnityEngine;
using System.Collections;

public class FirePutOut : MonoBehaviour {

    public GameObject yourObject;


    // Use this for initialization
    void FixedUpdate() {
        if (Input.GetKey(KeyCode.G))
        {
            yourObject.tag = "Foam";

        }
        if (Input.GetKey(KeyCode.H))
        {
            yourObject.tag = "Foamless";

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
