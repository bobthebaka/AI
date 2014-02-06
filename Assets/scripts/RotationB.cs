using UnityEngine;
using System.Collections;

public class RotationB : MonoBehaviour 
{
	public GameObject NumberTwo;
	public GameObject NumberThree;
	public GameObject NumberFive;
	public GameObject NumberSix;
	
	Vector2 TwoPos;
	Vector2 ThreePos;
	Vector2 FivePos;
	Vector2 SixPos;
	
	
	// Use this for initialization
	void Start ()
	{
		TwoPos = NumberTwo.transform.position;
		ThreePos = NumberThree.transform.position;
		FivePos = NumberFive.transform.position;
		SixPos = NumberSix.transform.position;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}
	
	void OnMouseDown()
	{
		NumberTwo.transform.position = ThreePos;
		NumberThree.transform.position = SixPos;
		NumberFive.transform.position = TwoPos;
		NumberSix.transform.position  = FivePos;
		
		TwoPos = NumberTwo.transform.position;
		ThreePos = NumberThree.transform.position;
		FivePos = NumberFive.transform.position;
		SixPos = NumberSix.transform.position;
		
	}
	
}