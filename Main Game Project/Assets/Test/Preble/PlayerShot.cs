using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject PLayer;
    public float timeBetweenShots = 1f;  // Allow 3 shots per second

    private float timestamp;

    void Update()
    {
        if (Time.time >= timestamp && (Input.GetButtonDown("Fire1")))
        {
            Rigidbody clone;
            clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
            clone.transform.SetParent(PLayer.transform, true);

            timestamp = Time.time + timeBetweenShots;
        }
    }




    //public GameObject spawnPoint;
   public Rigidbody2D projectile1;
    //public AudioSource shot;
    public GameObject projectilePrefab;
    //public GameObject Parent;
    public float ShotSpeed;
    //public float timer;
    //public float nextFire = -1f;
    //public float timerCode = 5f;
    //public GameObject m_Enemy;
    //public float m_SpawnTime = 3f;
    //public Transform[] m_SpawnPoints;
    //// Use this for initialization
    //void Start()
    //{
    //    //nextFire = Time.time;

    //}

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