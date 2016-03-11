using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour
{

    // Use this for initialization
    public float bulletSpeed;
    GameObject parent;
    public float nextFire = -11.0f;
    public float timer;
    private Vector3 theScale;
    public GameObject Bullet;

    void Start()
    {
        nextFire = Time.time;

        GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
       // Debug.Log("Is this doing the shouting?");
    }

    // Update is called once per frame
    void Update()
    {

        //  if(transform.localScale.x < 0) bulletSpeed = -100;
        //  if(transform.localScale.x > 0) bulletSpeed = 100;
    }
    public void SetEnemy(GameObject obj)
    {
        parent = obj;
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {

            }
            Debug.Log("It should start going down.");
           // Destroy(Bullet);

        }
    }
}

   