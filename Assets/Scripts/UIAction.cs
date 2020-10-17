using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIAction : ScriptableObject
{
	public float value;
	public abstract void UIActionDO(MainUI ui, float value);
}
