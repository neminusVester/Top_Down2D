# Save Load System

#### Как пользоваться
**Save Load System** это система хранения данных.

Чтобы добавить новый данные для сохрания нужно либо добавить эти данные в класс **`SaveLoadData`** в виде **`StoredValue<T>`** или класса с данными.

**Все переменныe должны быть объявленны как `StoredValue<T>`**

Все данные сохраняются в PlayerPrefs и не сбрасываются между сеансами.

Данный сохраняются при каждом изменении переменной.

Также у каждой переменной есть событие **`OnValueChanged<T>`**, которой срабатывает при изменении переменной.

Класс SaveLoadSystem висит в сцене. Его не нужно нигде объявлять и инициализировать.

### StoredValue<T>

- *`StoredValue<T>`* **`StoredValue()`**: Дефолтныый конструктор
- *`StoredValue<T>`* **`StoredValue(T value)`**: Конструктор со значением
- *`T`* **`Value`**: Значение
- *`Action<T>`* **`OnValueChanged`**: Событие при изменении переменной

#### Примеры

```csharp
// Создаём новый класс с данными
[Serializable]
public class MyData
{
	// Объявляем переменную типа int
	public StoredValue<int> SomeInt;

	public MyData()
	{
		// Иницилизируем её значением 3
		SomeInt = new StoredValue<int>(3);
	}
}
```

```csharp
public class SaveLoadData
{
	// Объявляем наш класс в SaveLoadData
	public MyData MyData;

	public SaveLoadData()
	{
		// Иницилизируем наш класс
		MyData = new MyData();
	}
}
```

Использование

```csharp
// Получаем значение
var myInt = SLS.Data.MyData.SomeInt.Value;
```

```csharp
// Записываем значение
SLS.Data.MyData.SomeInt.Value = 10;
```

```csharp
// Подписываемся на событие при изменении переменной
SLS.Data.MyData.SomeInt.OnValueChanged += OnIntValueChanged;

private void OnIntValueChanged(int newValue)
{
	Debug.Log("New value: " + newValue);
}
```