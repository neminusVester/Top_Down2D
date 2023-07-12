using System;
using UnityEditor;
using UnityEngine;

// Здесь собраны разные extension'ы для удобной работы с UnityEditor
public static partial class Extensions
{
	public static bool GUIButton(this ScriptableObject so, string text, Color color)
	{
		var originalColor = GUI.backgroundColor;
		GUI.backgroundColor = color;
		var pressed = GUILayout.Button(text);
		GUI.backgroundColor = originalColor;
		return pressed;
	}

	public static Rect GUILayoutVertical(this ScriptableObject so, Action body, params GUILayoutOption[] options)
	{
		var rect = EditorGUILayout.BeginVertical(options);
		body?.Invoke();
		EditorGUILayout.EndVertical();
		return rect;
	}

	public static Rect GUILayoutVertical(this ScriptableObject so, Action body, GUIStyle style, params GUILayoutOption[] options)
	{
		var rect = EditorGUILayout.BeginVertical(style, options);
		body?.Invoke();
		EditorGUILayout.EndVertical();
		return rect;
	}

	public static Rect GUILayoutHorizontal(this ScriptableObject so, Action body, params GUILayoutOption[] options)
	{
		var rect = EditorGUILayout.BeginHorizontal(options);
		body?.Invoke();
		EditorGUILayout.EndHorizontal();
		return rect;
	}

	public static Rect GUILayoutHorizontal(this ScriptableObject so, Action body, GUIStyle style, params GUILayoutOption[] options)
	{
		var rect = EditorGUILayout.BeginHorizontal(style, options);
		body?.Invoke();
		EditorGUILayout.EndHorizontal();
		return rect;
	}

	public static void BeginScrollView(this ScriptableObject so, ref Vector2 scrollPosition, Action body, params GUILayoutOption[] options)
	{
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, options);
		body?.Invoke();
		EditorGUILayout.EndScrollView();
	}

	public static void BeginScrollView(this ScriptableObject so, ref Vector2 scrollPosition, Action body, GUIStyle style, params GUILayoutOption[] options)
	{
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, style, options);
		body?.Invoke();
		EditorGUILayout.EndScrollView();
	}

	public static void BeginScrollView(this ScriptableObject so, ref Vector2 scrollPosition, Action body, string text, GUIStyle style, params GUILayoutOption[] options)
	{
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, text, style, options);
		body?.Invoke();
		EditorGUILayout.EndScrollView();
	}

	public static void BeginScrollView(this ScriptableObject so, ref Vector2 scrollPosition, Action body, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)

	{
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
		body?.Invoke();
		EditorGUILayout.EndScrollView();
	}

	public static void BeginScrollView(this ScriptableObject so, ref Vector2 scrollPosition, Action body, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
	{
		scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
		body?.Invoke();
		EditorGUILayout.EndScrollView();
	}
}