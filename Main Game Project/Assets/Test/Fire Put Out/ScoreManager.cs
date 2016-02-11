using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public float score = 0;        // The player's score.
           float points = 1;
    public Text scoretext;

    void Start()
    {
       // scoretext.text = "score " + score;
    }
    //Text text;                      // Reference to the Text component.

    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bullets")
        {
            score += points;
        }
    }
    void Awake()
    {
        // Set up the reference.
      //  text = GetComponent<Text>();

        // Reset the score.
       // score = 0;
    }


    void Update()
    {
        scoretext.text = score + "";
        // Set the displayed text to be the word "Score" followed by the score value.
        print (score);
    }
}
