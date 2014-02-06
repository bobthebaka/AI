using UnityEngine;
using System.Collections;

public class RotationA : MonoBehaviour 
{
	public GameObject NumberOne;
	public GameObject NumberTwo;
	public GameObject NumberFour;
	public GameObject NumberFive;

	Vector2 OnePos;
	Vector2 TwoPos;
	Vector2 FourPos;
	Vector2 FivePos;


	// Use this for initialization
	void Start ()
	{
		OnePos = NumberOne.transform.position;
		TwoPos = NumberTwo.transform.position;
		FourPos = NumberFour.transform.position;
		FivePos = NumberFive.transform.position;
			
	}
	
	// Update is called once per frame
	void Update ()
	{

	
	}

	void OnMouseDown()
	{
		NumberOne.transform.position = TwoPos;
		NumberTwo.transform.position = FivePos;
		NumberFour.transform.position = OnePos;
		NumberFive.transform.position  = FourPos;

		OnePos = NumberOne.transform.position;
		TwoPos = NumberTwo.transform.position;
		FourPos = NumberFour.transform.position;
		FivePos = NumberFive.transform.position;

	}

}
