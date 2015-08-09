using UnityEngine;
using System.Collections;

public class piyoMove : Token {

	public const int Angle1 = 0;
	public const int Angle2 = 25;
	public const int Angle3 = 90;
	public const int Angle4 = 155;
	public const int Angle5 = 180;
	public const int Angle6 = 215;
	public const int Angle7 = 270;
	public const int Angle8 = 325;
	
	void Start () {
        float dir = Angle1;
		int rand = Random.Range(1, 9);
		if (rand == 1) {
	        dir = Angle1;
		} else if (rand == 2) {
	        dir = Angle2;
		} else if (rand == 3) {
	        dir = Angle3;
		} else if (rand == 4) {
	        dir = Angle4;
		} else if (rand == 5) {
	        dir = Angle5;
		} else if (rand == 6) {
	        dir = Angle6;
		} else if (rand == 7) {
	        dir = Angle7;
		} else if (rand == 8) {
	        dir = Angle8;
		}
        float spd = 5;
        SetVelocity(dir, spd);
	}
	
}
