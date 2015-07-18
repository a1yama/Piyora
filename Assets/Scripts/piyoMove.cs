using UnityEngine;
using System.Collections;

public class piyoMove : Token {

	void Start () {
        float dir = Random.Range(0, 359);
        float spd = 5;
        SetVelocity(dir, spd);
	}
	
}
