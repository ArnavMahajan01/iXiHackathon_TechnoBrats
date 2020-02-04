using UnityEngine;
using System.Collections;
using System.IO;

public class UserInterfaceButtons : MonoBehaviour
{
	public float sSpeed = 0.03f;
	public float rSpeed = 70.0f;
	public float tSpeed = 5.0f;

	bool ZoomUp = false;
	bool ZoomDown = false;
	
	
	void Update ()
	{
		if (ZoomUp) {
			ScaleUpButton ();
		}

		if (ZoomDown) {
			ScaleDownButton ();
		}	

	}

	public void CloseAppButton ()
	{
		Application.Quit ();
	}

	


	public void ScaleUpButton ()
	{
		
			GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (sSpeed, sSpeed, sSpeed);
		}

	public void ScaleUpButtonRepeat ()
	{
		ZoomUp = true;
		
	}
	public void ScaleDownButtonRepeat ()
	{
		ZoomDown = true;
		
	}
	
	
	public void ScaleUpButtonOff ()
	{
		ZoomUp = false;
		
	}
	public void ScaleDownButtonOff ()
	{
		ZoomDown = false;
		Debug.Log ("Off");
	}

	
	public void ScaleDownButton ()
	{
		
		GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (-sSpeed, -sSpeed, -sSpeed);
	}

	

}
