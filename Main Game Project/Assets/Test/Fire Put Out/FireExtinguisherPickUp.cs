using UnityEngine;
using System.Collections;

public class FireExtinguisherPickUp : MonoBehaviour {

    public GameObject Item;

    void OnTriggerEnter(Collider other)
    {
        Item.SetActive(false);

    }
}
