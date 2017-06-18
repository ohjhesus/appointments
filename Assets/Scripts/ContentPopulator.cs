using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentPopulator : MonoBehaviour {

	public GameObject manager;
	public GameObject panelTemplate;

	public int customer_id = 0;

	// Use this for initialization
	void Start () {
		string[] apptsArray = manager.GetComponent<SQLOps>().QueryDatabase(0, customer_id);

		foreach (string appt in apptsArray) {
			if (appt != "") {
				string[] splitAppt = appt.Split('~');

				string[] splitDateTime = splitAppt[0].Split(' ');
				string[] splitDate = splitDateTime[0].Split('-');
				string formattedDateTime = splitDate[2] + "/" + splitDate[1] + "/" + splitDate[0] + " " + splitDateTime[1].Substring(0, splitDateTime[1].Length - 3);

				CreatePanel(formattedDateTime, splitAppt[1], splitAppt[2], new string[] { "contact info", "array" });
			}
		}
	}
	
	public void CreatePanel (string date, string serviceName, string address, string[] contactInfo) {
		GameObject panel = Instantiate(panelTemplate);
		panel.transform.SetParent(transform);
		panel.transform.localScale = Vector3.one;
		panel.transform.FindChild("Date").GetComponent<Text>().text = date;
		panel.transform.FindChild("ServiceName").GetComponent<Text>().text = serviceName;
		panel.transform.FindChild("Address").GetComponent<Text>().text = address;

		panel.name = "appointment_" + serviceName + "_" + date;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
