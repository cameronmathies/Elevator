using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public GameObject spawnPoint;
    public Rigidbody2D projectile1;
    public AudioSource shot;
    public GameObject projectilePrefab;
    public GameObject Parent;
    public float ShotSpeed;
    public float timer;
    public float nextFire = -11.0f;
    public float timerCode = 5f;
    public GameObject m_Enemy;
    public float m_SpawnTime = 3f;
    public Transform[] m_SpawnPoints;


    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Good")
        {
            nextFire = nextFire + 4;
            Rigidbody hitPlayer;
            Debug.Log("Fire");
            //Rigidbody clone;
            //clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
            StartCoroutine("fire");
            //StartCoroutine("fire");
            //if (Time.time >= nextFire)
            //{
            //    Rigidbody clone;
            //    clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
            //    InvokeRepeating("FireBall", m_SpawnTime, m_SpawnTime);

            //    StartCoroutine("fire");
            //}
        }
    }

    void FireBall()
    {
        Rigidbody clone;
        clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
    }
    IEnumerator fire()
    {
        yield return new WaitForSeconds(3);
         Rigidbody clone;
        clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
        //StartCoroutine("fire");
    }
        // Use this for initialization
        void Start()
    {
        StartCoroutine("fire");
        nextFire = Time.time;
    }
    void Attack()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Rigidbody clone;
            clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
        
        //  clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;

    }

    }
    // Update is called once per frame
    //void Update()
    //{

    //    if (Time.time >= nextFire)
    //    {
    //        if (Input.GetButtonDown("Fire1"))
    //        {
    //            nextFire = nextFire + 1;
    //            Rigidbody hitPlayer;
    //            hitPlayer = Instantiate(projectile1, transform.position, transform.rotation) as Rigidbody;
    //            hitPlayer.velocity = transform.TransformDirection(Vector2.right * ShotSpeed);
    //            // AudioSource audio = GetComponent<AudioSource>();
    //            //  audio.Play();
    //        }
    //    }



    //    for (var i = 0; i < Input.touchCount; ++i)
    //    {
    //        if (Input.GetTouch(i).phase == TouchPhase.Began)
    //        {
    //            Debug.Log("VARVAR");
    //            Rigidbody clone;
    //            clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as Rigidbody;
    //            //clone = (Instantiate(projectilePrefab, transform.position, transform.rotation) as GameObject).transform.parent = projectilePrefab.transform;
    //            clone.velocity = transform.TransformDirection(Vector2.right * ShotSpeed);
    //            //            Physics.IgnoreCollision ( projectilePrefab.collider, transform.root.collider );


    //        }
      //  }



  //  }
}