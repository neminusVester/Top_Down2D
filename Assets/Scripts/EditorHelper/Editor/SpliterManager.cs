using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class SpliterManager
{
	static SpliterManager()
	{
		EditorApplication.hierarchyWindowItemOnGUI += HandleHierarchyWindowItemOnGUI;
	}

	private static void HandleHierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
	{
		var gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
		if (gameObject == null) return;

		var spliter = gameObject.GetComponent<Spliter>();
		if (spliter == null) return;

		spliter.tag = "EditorOnly";

		var styleState = new GUIStyleState() { textColor = spliter.TextColor };
		var style = new GUIStyle()
		{
			normal = styleState,
				fontStyle = FontStyle.Bold,
				alignment = spliter.TextAlignment
		};

		if (spliter.Extend)
		{
			var parentsCount = spliter.transform.GetParentsCount();

			// Числа подобранны вручную
			// Информации как получить ширину окна иерархии не нашёл :(
			var offset = parentsCount * 14;
			selectionRect.x -= offset + 27.5f;
			selectionRect.width += offset + 43;
		}

		EditorGUI.DrawRect(selectionRect, spliter.BackgroundColor);
		EditorGUI.LabelField(selectionRect, spliter.name, style);
	}
}