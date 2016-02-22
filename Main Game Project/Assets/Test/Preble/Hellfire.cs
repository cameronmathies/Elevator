using UnityEngine;
using System.Collections;

public class Hellfire : MonoBehaviour {

    private Transform target;
    private float force = 2f;
    private bool ifTarget = false;
    private float starttime;

    public void SetTarget(Transform helTarg)
    {
        target = helTarg;
        ifTarget = true;
        starttime = Time.time + 0.5f;
        transform.parent = null;
        gameObject.AddComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (ifTarget)
        {
            if (target == null)
            {
                GetComponent<Rigidbody>().velocity = (transform.forward * 1500 * Time.deltaTime);

            }
            else
            {

                if (Time.time > starttime)
                {
                    Vector3 dir = target.position - transform.position;
                    Quaternion rot = Quaternion.LookRotation(dir);
                    transform.rotation = Quaternion.Slerp(transform.rotation, rot, force * Time.deltaTime);
                }

                GetComponent<Rigidbody>().velocity = (transform.forward * 1500 * Time.deltaTime);

            }
        }
    }
}
