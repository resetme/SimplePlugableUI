using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEvent : MonoBehaviour
{

	[SerializeField]
	public UIAction eventToSend;

	public static event Action<UIAction> EventUpdateUI = delegate {};


	private void OnTriggerEnter(Collider other)
	{
		eventToSend.value += 10;
		EventUpdateUI.Invoke(eventToSend);
	}
}
