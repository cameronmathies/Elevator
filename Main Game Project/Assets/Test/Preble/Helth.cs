using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Helth : MonoBehaviour {
    public Slider HealthBar;
    public int Health;
    public Text HealthT;

    // Use this for initialization
    void Start () {
        Health = 100;
	}
	void OnTriggerStay2D(Collider2D other)
    {
        if (other.isTrigger)
        {
            Debug.Log("This Collider2D can be triggered");
        }
        Debug.Log("It's entered.");
        if (other.gameObject.tag == "Bad")
        {
            Debug.Log("It should start going down.");
            Health -= 1;
        }
    }
	// Update is called once per frame
	void Update () {
        if (HealthBar.name == "HeathBar")
        {
            HealthBar.value = Health;
        }
        HealthT.text = Health + "%";

        if(Health < 0)
        {
            Application.LoadLevel("Main Menuss");
        }
    }
}
