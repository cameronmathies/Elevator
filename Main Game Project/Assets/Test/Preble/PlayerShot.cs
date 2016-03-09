using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerShot : MonoBehaviour
{

    public GameObject bullet;
    public Transform SpawnPoint;
    public float ShotSpeed;
    Transform PLayer;

    public float timeBetweenShots = 1f;  // Allow 3 shots per second

    private float timestamp;

    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;
    
        if (Time.time >= timestamp && (Input.GetButtonDown("Fire1")))
        {
           // GameObject childObject =
                Instantiate(bullet, PLayer.position, PLayer.rotation); //instantiates laser to shotSpawn location
           // bullet.transform.parent = PLayer.transform;
            //Instantiate(bullet, new Vector2(if * 2F, p), Quaternion.identity);
            //GameObject childObject = Instantiate(bullet) as GameObject;
            //GameObject childObject = Instantiate(bullet, transform.position.x + (transform.forward * 2), transform.rotation);
            //GameObject go = Instantiate(Resources.Load("PlayerShot")) as GameObject;
            Rigidbody clone;
            //clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
            //clone.transform.SetParent(PLayer.transform, true);
            
            timestamp = Time.time + timeBetweenShots;
        }
    }




    //public GameObject spawnPoint;
   ///public Rigidbody2D projectile1;
    //public AudioSource shot;
    //public GameObject projectilePrefab;
    //public GameObject Parent;
    
    //public float timer;
    //public float nextFire = -1f;
    //public float timerCode = 5f;
    //public GameObject m_Enemy;
    //public float m_SpawnTime = 3f;
    //public Transform[] m_SpawnPoints;
    //// Use this for initialization
    void Start()
    {
        PLayer = GetComponent<Transform>();

        //    //nextFire = Time.time;
        //for (int y = 0; y < 5; y++)
        //{
        //    for (int x = 0; x < 5; x++)
        //    {
        //       ube.transform.position = new Vector2(x, y);
        //    }
        //}
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {

    //            StartCoroutine("fire");

    //        // StartCoroutine("fire");
    //        // AudioSource audio = GetComponent<AudioSource>();
    //        //  audio.Play();
    //    }
    //}
    ////IEnumerator fire()
    ////{
    ////   // yield return new WaitForSeconds(2);

    ////    Rigidbody clone;
    ////    clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;


    ////}



    ////void Attack()
    ////{
    ////    //timer -= Time.deltaTime;
    ////    if (timer <= 0)
    ////    {
    ////        StartCoroutine("fire");
    ////        // Rigidbody clone;
    ////        //clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;

    ////        //  clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;

    ////    }

    ////}
}