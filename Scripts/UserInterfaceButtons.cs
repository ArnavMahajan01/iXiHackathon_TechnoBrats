using UnityEngine;
using System.Collections;
using System.IO;

public class UserInterfaceButtons : MonoBehaviour
{
	public float sSpeed = 0.03f;
	public float rSpeed = 70.0f;
	public float tSpeed = 5.0f;
//	public GameObject Model;
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
		// transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
			GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (sSpeed, sSpeed, sSpeed);
		}

	public void ScaleUpButtonRepeat ()
	{
		ZoomUp = true;
		Debug.Log ("Up");
	}
	public void ScaleDownButtonRepeat ()
	{
		ZoomDown = true;
		Debug.Log ("Down");
	}
	
	
	public void ScaleUpButtonOff ()
	{
		ZoomUp = false;
		Debug.Log ("Off");
	}
	public void ScaleDownButtonOff ()
	{
		ZoomDown = false;
		Debug.Log ("Off");
	}

	
	public void ScaleDownButton ()
	{
		// transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
		GameObject.FindWithTag ("Model").transform.localScale += new Vector3 (-sSpeed, -sSpeed, -sSpeed);
	}

	

	public void ChangeScene (string a)
	{
		
		Application.LoadLevel (a);
	}

	public void AnyButton ()
	{
		Debug.Log ("Any");
	}
}
