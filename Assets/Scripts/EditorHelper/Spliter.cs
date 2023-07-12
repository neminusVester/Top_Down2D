using UnityEngine;

[ExecuteAlways]
public class Spliter : MonoBehaviour
{
	[SerializeField] private Color textColor = Color.white;
	[SerializeField] private Color backgroundColor = Color.black;
	[SerializeField] private TextAnchor textAlignment = TextAnchor.MiddleCenter;
	[SerializeField] private bool extend;

	public Color TextColor => textColor;
	public Color BackgroundColor => backgroundColor;
	public TextAnchor TextAlignment => textAlignment;
	public bool Extend => extend;

	private void Update() => transform.DetachChildren();
}