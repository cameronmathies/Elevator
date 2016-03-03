using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour {
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
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            nextFire = nextFire + 1;
            Rigidbody hitPlayer;
            hitPlayer = Instantiate(projectile1, transform.position, transform.rotation) as Rigidbody;
            hitPlayer.velocity = transform.TransformDirection(Vector2.left * ShotSpeed);
            // AudioSource audio = GetComponent<AudioSource>();
            //  audio.Play();
        }
    }
}
