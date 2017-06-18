using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontSetter : MonoBehaviour {

	private Font font;
	private DeviceSystemFont dsf;

	// Use this for initialization
	void Start () {
		dsf = GameObject.Find("Manager").GetComponent<DeviceSystemFont>();
		StartCoroutine(SetFont());
	}
	
	IEnumerator SetFont () {
		while (dsf.deviceFont == null) yield return new WaitForSeconds(0);

		font = dsf.deviceFont;
		foreach (Text text in GetComponents<Text>()) {
			text.font = font;
		}

		foreach (Text text in GetComponentsInChildren<Text>()) {
			text.font = font;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
