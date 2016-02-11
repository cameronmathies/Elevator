using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public float score = 0;        // The player's score.
    float points = 1;
    public Text scoretext;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Foam")
        {
           
           
            }
    }
    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        print("Score" + score);

        if (Input.GetKeyDown(KeyCode.G))
        {
            score -= points;
            score -= points;
            score -= points;
            score -= points;
            score -= points;
            score -= points;
        }
    }
}
