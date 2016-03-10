//using UnityEngine;
//using System.Collections;

//public class EnemyFollow : MonoBehaviour
//{
//    [SerializeField]
//    ParticleSystem m_Explosion;
//    SpriteRenderer m_Sprite;
//    public SpriteRenderer m_EnemyShield;
//    GameObject m_Player;
//    float m_Distance;
//    PolygonCollider2D m_Coll;
//    CircleCollider2D m_Trigger;
//    float m_RotationSpeed = 4;
//    bool m_EnemyDead = false;
//    Transform m_TransformPlayer;
//    public float m_Speed = 2f;
//    //initializing memeber variables

//    void Awake()
//    {
//        m_Explosion = GetComponent<ParticleSystem>();
//        m_Sprite = GetComponent<SpriteRenderer>();
//        m_Coll = GetComponent<PolygonCollider2D>();
//        m_Trigger = GetComponent<CircleCollider2D>();
//        m_Player = GameObject.FindGameObjectWithTag("Player");
//        m_TransformPlayer = m_Player.transform;
       
//    }

//    void FixedUpdate()
//    {
//        //if (PlayerDie.PlayerDead() || m_EnemyDead)
//            return; //enemy does nothing if player is dead
//        else
//        {
//            Vector3 direction = m_TransformPlayer.position - transform.position;
//            direction.z = 0.0f;
//            if (direction != Vector3.zero)
//            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.FromToRotation(Vector3.down, direction), m_RotationSpeed * Time.deltaTime);
//            transform.position += (m_TransformPlayer.position - transform.position).normalized * m_Speed * Time.deltaTime;
//            //enemy determines player position, orients itself toward player and subtracts distance between the two. 
//        }
    
//    }


//    void OnTriggerEnter2D(Collider2D coll)
//    {
//        if (coll.gameObject.tag == "Player")
//        {
//            m_EnemyDead = true;
//            StartCoroutine(Countdown()); //kills enemy, starts enemy death IEnumerator
//        }
            
//        else if (coll.gameObject.tag == "Laser")
//        {
//            m_EnemyDead = true;
//            StartCoroutine(Countdown()); //same as before
//        }


//    }

//    IEnumerator Countdown()
//    {
//    int timer = 2;
//        while (timer > 0)
//        {
//            timer--;
//            m_Explosion.enableEmission = true; //enable particle effects
//            m_EnemyShield.enabled = false; //disable enemyShield sprite renderer
//            m_Sprite.enabled = false; //disable enemy sprite renderer
//            m_Coll.enabled = false; //disables enemy colliders
//            m_Trigger.enabled = false; //disables enemy trigger
//            yield return new WaitForSeconds(1);
//        }
//        m_Explosion.enableEmission = false;
//        Destroy(gameObject);
//    }


