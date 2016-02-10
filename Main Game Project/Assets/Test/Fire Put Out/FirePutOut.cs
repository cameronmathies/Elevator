using UnityEngine;
using System.Collections;

public class FirePutOut : MonoBehaviour
{

    public GameObject yourObject;
    public ParticleSystem Foam;

    // Use this for initialization
    void FixedUpdate()
    {
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
    void Update()
    {

        if (Input.GetKey(KeyCode.G))
        {

            Foam.Emit(10); //Emit some particle
        }

    }
}
