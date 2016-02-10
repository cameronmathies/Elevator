using UnityEngine;
using System.Collections;

public class RotateSample : MonoBehaviour
{	
	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("x", .5, "Time",2, "easeType", "easeoutbounce", "loopType", "loop", "delay", .4));
	}
}

