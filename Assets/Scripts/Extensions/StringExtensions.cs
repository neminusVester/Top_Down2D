using System;

// Здесь собраны extension'ы для удобной работы со строками
public static partial class Extensions
{
	/// <summary>Улаляет из строки подстроку</summary>
	/// <param name="removeString">Что удалить</param>
	public static string Remove(this string sourceString, string removeString)
	{
		var index = sourceString.IndexOf(removeString);
		var cleanPath = (index < 0) ?
			sourceString :
			sourceString.Remove(index, removeString.Length);

		return cleanPath;
	}

	/// <summary>Делает первую букву в каждом слове заглавной</summary>
	/// <example>
	/// <code>
	/// string original = "майнкрафт - это моя жизнь";
	/// string uppercased = original.UppercaseWords();
	/// </code>
	/// uppercased = "Майнкрафт - Это Моя Жизнь"
	/// </example>
	public static string UppercaseWords(this string value)
	{
		var array = value.ToCharArray();

		// Handle the first letter in the string
		if (array.Length >= 1)
		{
			if (char.IsLower(array[0]))
				array[0] = char.ToUpper(array[0]);
		}

		// Scan through the letters, checking for spaces
		// Uppercase the lowercase letters following spaces
		for (var i = 1; i < array.Length; i++)
		{
			if (array[i - 1] == ' ')
			{
				if (char.IsLower(array[i]))
					array[i] = char.ToUpper(array[i]);
			}
		}

		return new string(array);
	}

	/// <summary>Возвращает число и склонённое слово</summary>
	/// <example>
	/// <code>
	/// int i = 5;
	/// string s = i.DeclOfNum("час", "часа", "часов");
	/// </code>
	/// </example>
	public static string DeclOfNum(this int number, string title1, string title2, string title5, string format = "{0} {1}")
	{
		// 			Indexes for 0, 1, 2, 3, 4, 5
		var cases = new int[] { 2, 0, 1, 1, 1, 2 };
		var titles = new string[] { title1, title2, title5 };
		var title = titles[(number % 100 > 4 && number % 100 < 20) ? 2 : cases[(number % 10 < 5) ? number % 10 : 5]];
		return String.Format(format, number, title);
	}
}