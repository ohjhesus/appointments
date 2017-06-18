using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class SQLOps : MonoBehaviour {

	public string phpHandlerURL = "http://localhost:8888/appointments/handler.php?";

	// Use this for initialization
	void Start () {
		//QueryDatabase(0, 0);
	}
	
	public string[] QueryDatabase (int queryid, int custid) {
		string url = phpHandlerURL + "query_id=" + queryid + "&cust_id=" + custid;
		WebClient wc = new WebClient();
		string responseBytes = wc.DownloadString(url);
		//Debug.Log(responseBytes);

		string[] responseArray = responseBytes.Split('|');

		return responseArray;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
