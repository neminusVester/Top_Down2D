using System;
using UnityEngine;

[Serializable]
public class StoredValue<T>
{
	[SerializeField]
	private T value;
	public T Value
	{
		get => value;
		set
		{
			// Если значение поменялось
			// сохраняем новое значение
			// и инициируем событие OnValueChanged
			if (!this.value.Equals(value))
			{
				this.value = value;
				SaveLoadSystem.Instance.Save();
				OnValueChanged?.Invoke(value);
			}
		}
	}

	public event Action<T> OnValueChanged;

	public StoredValue()
	{
		try
		{
			value = Activator.CreateInstance<T>();
		}
		catch (MissingMethodException)
		{
			value = default(T);
		}
	}

	public StoredValue(T value)
	{
		this.value = value;
	}
}