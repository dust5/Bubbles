using UnityEngine;
using System.Collections;

public class Button_ChangeBg : MonoBehaviour {


	public Transform target;
	// Use this for initialization
	int Bgposition = 0;
	bool Startchange = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Startchange) {
			SpringPosition sp = target.GetComponent<SpringPosition> ();
			if(sp.target.x != Bgposition)
			{
				sp.target.Set (Bgposition, 0, 0);
				sp.enabled = true;
			}
			else
			{
				Startchange = false;
			}

		}
	}

	void ChangeBackgroundInfo()
	{
		Bgposition = 640;
		Startchange = true;
	}
	void ChangeBackgroundCreate()
	{
		Bgposition = 0;
		Startchange = true;
	}
	void ChangeBackgroundReceive()
	{
		Bgposition = -640;
		Startchange = true;
	}
}
