using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "UI Life")]
public class UIAcionLife : UIAction {
	
	public override void UIActionDO(MainUI ui, float value)
	{
		ui.lifeLabel.text = value.ToString();
	}
}