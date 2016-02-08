using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed;
    public float speed = 10f;
	public float RotateSpeed;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        
	}
}