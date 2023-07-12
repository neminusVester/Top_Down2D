using UnityEngine;

// Здесь собраны extension'ы для удобной работы с векторами
public static partial class Extensions
{
	/// <summary>Возвращает абсолютный вектор</summary>
	public static Vector2 Abs(this Vector2 vector)
	{
		var absVector = new Vector2();
		absVector.x = Mathf.Abs(vector.x);
		absVector.y = Mathf.Abs(vector.y);
		return absVector;
	}

	/// <summary>Округление вниз всех координат</summary>
	public static Vector2Int FloorToInt(this Vector2 vector)
	{
		var v2i = new Vector2Int();
		v2i.x = Mathf.FloorToInt(vector.x);
		v2i.y = Mathf.FloorToInt(vector.y);
		return v2i;
	}

	/// <summary>Округление вверх всех координат</summary>
	public static Vector2Int CeilToInt(this Vector2 vector)
	{
		var v2i = new Vector2Int();
		v2i.x = Mathf.CeilToInt(vector.x);
		v2i.y = Mathf.CeilToInt(vector.y);
		return v2i;
	}

	/// <summary>Округление к ближайшему целому числу всех координат</summary>
	public static Vector2Int RoundToInt(this Vector2 vector)
	{
		var v2i = new Vector2Int();
		v2i.x = Mathf.RoundToInt(vector.x);
		v2i.y = Mathf.RoundToInt(vector.y);
		return v2i;
	}

	/// <summary>Возвращает абсолютный вектор</summary>
	public static Vector3 Abs(this Vector3 vector)
	{
		var absVector = new Vector3();
		absVector.x = Mathf.Abs(vector.x);
		absVector.y = Mathf.Abs(vector.y);
		absVector.z = Mathf.Abs(vector.z);
		return absVector;
	}

	/// <summary>Округление вниз всех координат</summary>
	public static Vector3Int FloorToInt(this Vector3 vector)
	{
		var v3i = new Vector3Int();
		v3i.x = Mathf.FloorToInt(vector.x);
		v3i.y = Mathf.FloorToInt(vector.y);
		v3i.z = Mathf.FloorToInt(vector.z);
		return v3i;
	}

	/// <summary>Округление вверх всех координат</summary>
	public static Vector3Int CeilToInt(this Vector3 vector)
	{
		var v3i = new Vector3Int();
		v3i.x = Mathf.CeilToInt(vector.x);
		v3i.y = Mathf.CeilToInt(vector.y);
		v3i.z = Mathf.CeilToInt(vector.z);
		return v3i;
	}

	/// <summary>Округление к ближайшему целому числу всех координат</summary>
	public static Vector3Int RoundToInt(this Vector3 vector)
	{
		var v3i = new Vector3Int();
		v3i.x = Mathf.RoundToInt(vector.x);
		v3i.y = Mathf.RoundToInt(vector.y);
		v3i.z = Mathf.RoundToInt(vector.z);
		return v3i;
	}

	/// <summary>Возвращает вектор с новым значением x</summary>
	/// <param name="x">Новое значение x</param>
	public static Vector3 WithX(this Vector3 vector, float x) => new Vector3(x, vector.y, vector.z);

	/// <summary>Возвращает вектор с новым значением y</summary>
	/// <param name="y">Новое значение y</param>
	public static Vector3 WithY(this Vector3 vector, float y) => new Vector3(vector.x, y, vector.z);

	/// <summary>Возвращает вектор с новым значением z</summary>
	/// <param name="z">Новое значение z</param>
	public static Vector3 WithZ(this Vector3 vector, float z) => new Vector3(vector.x, vector.y, z);
}