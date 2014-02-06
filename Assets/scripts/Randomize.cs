using UnityEngine;
using System.Collections;

public class Randomize : MonoBehaviour {

	public GameObject NumberOne;
	public GameObject NumberTwo;
	public GameObject NumberThree;
	public GameObject NumberFour;
	public GameObject NumberFive;
	public GameObject NumberSix;
	public GameObject NumberSeven;
	public GameObject NumberEight;
	public GameObject NumberNine;

	public Material mat_Number1;
	public Material mat_Number2;
	public Material mat_Number3;
	public Material mat_Number4;
	public Material mat_Number5;
	public Material mat_Number6;
	public Material mat_Number7;
	public Material mat_Number8;
	public Material mat_Number9;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		NumberOne.renderer.material = mat_Number1;
		NumberTwo.renderer.material = mat_Number2;
		NumberThree.renderer.material = mat_Number3;
		NumberFour.renderer.material = mat_Number4;
		NumberFive.renderer.material = mat_Number5;
		NumberSix.renderer.material = mat_Number6;
		NumberSeven.renderer.material = mat_Number7;
		NumberEight.renderer.material = mat_Number8;
		NumberNine.renderer.material = mat_Number9;

	}


}
