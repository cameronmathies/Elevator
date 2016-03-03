using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed;
    public float speed = 10f;
	public float RotateSpeed;
    public float jump;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * jump * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}