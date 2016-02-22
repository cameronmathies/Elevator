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
	void OnTriggerStay(Collider col)
    {
        if(col.gameObject.tag == "Bad")
        {
            Health -= 2;
        }
    }
	// Update is called once per frame
	void Update () {
	if(HealthBar.name == "HeathBar")
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
