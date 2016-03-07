using UnityEngine;
using System.Collections;

public class BulletDelete : MonoBehaviour
{
    public GameObject PlayerFireBall;
    public GameObject PrebleFireBall;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bad")
        {

            Destroy(PlayerFireBall);
        }

        if (other.gameObject.tag == "Good")
        {

            Destroy(PrebleFireBall);

        }
    }
}
