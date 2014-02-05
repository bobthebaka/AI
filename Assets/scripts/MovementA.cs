using UnityEngine;
using System.Collections;

public class MovementA : MonoBehaviour
{

	public GameObject oneone;
	public GameObject onetwo;
	public GameObject twoone;
	public GameObject twotwo;

	Vector2 oneonePos;
	Vector2 onetwoPos;
	Vector2 twoonePos;
	Vector2 twotwoPos;

	void Start ()
	{
		// if the objects are not assigned in the Inspector...
		if (!oneone && !onetwo && !twoone && !twotwo)
		{ 
			//find them
			oneone = GameObject.Find("1-1"); 
			onetwo = GameObject.Find("1-2");
			twoone = GameObject.Find("2-1");
			twotwo = GameObject.Find("2-2");
		}

		oneonePos = oneone.transform.position;
		onetwoPos = onetwo.transform.position;
		twoonePos = twoone.transform.position;
		twotwoPos = twotwo.transform.position;
	}

	// Update is called once per frame
	void Update ()
	{
	}
	
	void OnMouseDown()
	{
		//swaps positions
		oneone.transform.position = onetwoPos;
		onetwo.transform.position = twotwoPos;
		twotwo.transform.position = twoonePos;
		twoone.transform.position  = oneonePos;

		//updates positions
		oneonePos = oneone.transform.position;
		onetwoPos = onetwo.transform.position;
		twoonePos = twoone.transform.position;
		twotwoPos = twotwo.transform.position;


	}

}
