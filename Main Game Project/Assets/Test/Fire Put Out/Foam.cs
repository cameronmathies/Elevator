using UnityEngine;
using System.Collections;

public class Foam : MonoBehaviour {

    void OnTriggerStay(Collider target)
    {
        if (target.tag == "Foam")
        {
            Destroy(this.gameObject);
        }
    }
}
