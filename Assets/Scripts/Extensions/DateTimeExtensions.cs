using System;

// Здесь собраны extension'ы для удобной работы с датой и временем
public static partial class Extensions
{
	/// <summary>Возвращает текущее время и дату в секундах</summary>
	public static long InSeconds(this DateTime dateTime)
	{
		return dateTime.Ticks / TimeSpan.TicksPerSecond;
	}

	/// <summary>Время в формате 'дней:часов:минут:секунд'</summary>
	/// <param name="spliter">Разделитель между цифрами</param>
	public static string FormatedDateTime(this TimeSpan span, string spliter = ":")
	{
		if (span.Days > 0)
		{
			return span.Days + spliter + span.Hours + spliter + span.Minutes.ToString("00") + spliter + span.Seconds.ToString("00");
		}
		else
		{
			if (span.Hours > 0)
				return span.Hours + spliter + span.Minutes.ToString("00") + spliter + span.Seconds.ToString("00");
			else
				return span.Minutes + spliter + span.Seconds.ToString("00");
		}
	}
}