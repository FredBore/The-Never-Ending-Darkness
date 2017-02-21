using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CamEvents : MonoBehaviour {
	public Camera[] Cameras;
	void Start ()
	{

		Cameras [0].enabled = true;
		Cameras [1].enabled = false;
	}
	void AnimStart ()
	{
		
	    Cameras [0].enabled = true;
		Cameras [1].enabled = false;
	}
	public void ChangeCam () 
	{
		Cameras[0].enabled = false;
		Cameras [1].enabled = true;
	}

}
