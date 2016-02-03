using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public void Play()
    {
        Application.LoadLevel("Lobby");
    }
    public void Credits()
    {
        Application.LoadLevel("Credits");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
