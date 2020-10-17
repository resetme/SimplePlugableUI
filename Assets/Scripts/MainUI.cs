using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
	public UnityEngine.UI.Text coinLabel;
	public UnityEngine.UI.Text lifeLabel;
	
	private void OnEnable()
	{
		SendEvent.EventUpdateUI += UPdateUI;
	}

	private void OnDisable()
	{
		SendEvent.EventUpdateUI -= UPdateUI;
	}

	void UPdateUI(UIAction action)
	{
		action.UIActionDO(this, action.value);
	}
}
