using System.Collections.Generic;
using System.Linq;

using Random = UnityEngine.Random;

// Здесь собраны extension'ы для удобной работы с листами
public static partial class Extensions
{
	/// <summary>Возвращает случайный эллемент листа</summary>
	public static T GetRandom<T>(this List<T> list)
	{
		if (list.Count == 0)
			return default(T);

		return list[Random.Range(0, list.Count)];
	}

	/// <summary>Заполняет массив</summary>
	/// <param name="value">Значение для заполнения массива</param>
	/// <example>
	/// <code>
	/// var array = new int[10];
	/// array.Populate(5);
	/// </code>
	/// </example>
	public static void Populate<T>(this T[] arr, T value)
	{
		for (var i = 0; i < arr.Length; i++)
			arr[i] = value;
	}

	/// <summary>Пепреводит лист с читаемый вид</summary>
	public static string Print<T>(this IList<T> list)
	{
		var res = "[ " + string.Join(", ", list.Select(s => $"{s}")) + " ]";
		return res;
	}

	/// <summary>Перемешивает лист</summary>
	public static void Shuffle<T>(this IList<T> list)
	{
		System.Random rng = new System.Random();

		var n = list.Count;
		while (n > 1)
		{
			n--;
			var k = rng.Next(n + 1);
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}
	}

	/// <summary>Возвращает случайный индекс листа</summary>
	public static int GetRandomIndex<T>(this List<T> list)
	{
		if (list.Count == 0)
			return -1;

		return Random.Range(0, list.Count);
	}

	/// <summary>Возвращает случайный индекс листа с исключинеим</summary>
	/// <param name="exclusion">Значение, которое мы не хотим чтобы возвращалось</param>
	public static int GetRandomIndexWithout<T>(this List<T> list, int exclusion = -1)
	{
		if (list.Count == 0)
			return -1;

		return RandomRangeWithout(0, list.Count, exclusion);
	}
}