﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TMP_ItemDisplay : MonoBehaviour {

	[SerializeField]
	private Player player = null;

	private Text text = null;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player.CurrentItem == null)
			text.text = "No Item";
		else
			text.text = player.CurrentItem.ToString ();
	}
}