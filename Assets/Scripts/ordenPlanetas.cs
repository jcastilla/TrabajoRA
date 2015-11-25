using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ordenPlanetas : MonoBehaviour {

	public GameObject sol;
	public GameObject tierra;
	public GameObject jupiter;
	public GameObject neptuno;
	Text text;
	float posSol;
	float posTierra;
	float posJupiter;
	float posNeptuno;
	bool cambioColor = false;

	void Awake()
	{
		text = GetComponent <Text> ();
		text.color = Color.red;

		//puntos = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		posSol = sol.GetComponent<Transform> ().position.x;
		posTierra = tierra.GetComponent<Transform> ().position.x;
		posJupiter = jupiter.GetComponent<Transform> ().position.x;
		posNeptuno = neptuno.GetComponent<Transform> ().position.x;

		if (posSol > posTierra && posTierra > posJupiter && posJupiter > posNeptuno)
			text.color = Color.green;
	}
}
