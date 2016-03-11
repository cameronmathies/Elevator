﻿using UnityEngine;
using System.Collections;

public class BulletDelete : MonoBehaviour
{
    public GameObject PlayerFireBall;
    public GameObject PrebleFireBall;

    void Start()
    {
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bad")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Good")
        {

            Destroy(PrebleFireBall);

        }
    }
}
