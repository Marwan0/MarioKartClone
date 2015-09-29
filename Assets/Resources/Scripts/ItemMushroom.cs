﻿using UnityEngine;
using System.Collections;

public class ItemMushroom : Item {

	[SerializeField]
	private float SpeedBoost = 25f;

	public override Item use(CarItemHandler car, bool useBehind)
	{
		Rigidbody body = car.Controller.GetComponent<Rigidbody> ();

		body.velocity += SpeedBoost * (body.rotation * Vector3.forward);

		car.Controller.SendMessage ("CapSpeed");
		return null;
	}
}
