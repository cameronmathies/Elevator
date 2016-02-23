using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour
{

    // Use this for initialization
    public float bulletSpeed;
    GameObject parent;

    private Vector3 theScale;

    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
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

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("It should start going down.");
            Destroy(gameObject);

        }

    }
}