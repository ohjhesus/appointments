using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceSystemFont : MonoBehaviour {

	public Font iosFont;
	public Font androidFont;
	[HideInInspector] public Font deviceFont;

	// Use this for initialization
	void Start () {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			deviceFont = iosFont;
		} else if (Application.platform == RuntimePlatform.Android) {
			deviceFont = androidFont;
		} else {
			Debug.Log("Unsupported device platform: " + Application.platform);
			deviceFont = iosFont;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
