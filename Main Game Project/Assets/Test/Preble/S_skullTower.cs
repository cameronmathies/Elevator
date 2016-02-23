using UnityEngine;
using System.Collections;

public class S_skullTower : MonoBehaviour {


    public Transform target;
    public float turretSpeed;
    public float fireRate;
    public float fireBallHeight;
    public GameObject fireBall;
    public float range;
    float distance;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Rotate turret to look at player.
        Vector2 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        rotation.x = 0;
        rotation.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * turretSpeed);

        //Fire at player when in range.
        distance = Vector2.Distance(transform.position, target.position);

        if (distance < range)
        {
            launchFireBall();
        }
    }

    void launchFireBall()
    {
        Vector2 position = new Vector2(transform.position.x, transform.position.y + fireBallHeight);
        Instantiate(fireBall, position, transform.rotation);
    }
}
