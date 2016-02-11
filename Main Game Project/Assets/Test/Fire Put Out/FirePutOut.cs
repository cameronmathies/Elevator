using UnityEngine;
using System.Collections;

public class FirePutOut : MonoBehaviour
{

    public GameObject yourObject;
    public ParticleSystem Foam;
    bool holdingDown;
    // Use this for initialization
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.G))
        {
            yourObject.tag = "Foamless";
            holdingDown = true;

        }

        //if (holdingDown == false)
        //{
        //    yourObject.tag = "Foamless";

        //}

        if (Input.GetKey(KeyCode.H))
        {
            yourObject.tag = "Foamless";

        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.G))
        {
            yourObject.tag = "Foam";

            Foam.Emit(10); //Emit some particle
        }

    }
}
