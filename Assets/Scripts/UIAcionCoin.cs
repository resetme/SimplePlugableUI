using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "UI COin")]
public class UIAcionCoin : UIAction {
	
	public override void UIActionDO(MainUI ui, float value)
	{
		ui.coinLabel.text = value.ToString();
	}
}
