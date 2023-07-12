# Extentions

## Оглавление

* [Editor Extensions](#List-Extensions)
  + [GUIButton](#bool-ScriptableObject.-GUIButton)
  + [GUILayoutVertical](#Rect-ScriptableObject.-GUILayoutVertical)
  + [GUILayoutHorizontal](#Rect-ScriptableObject.-GUILayoutHorizontal)
  + [BeginScrollView](#ScriptableObject.-BeginScrollView)

* [List Extensions](#List-Extensions)
  + [GetRandom](<#T-List\<T\>. GetRandom()>)
  + [Populate](<#Array\<T\>. Populate(T-value)>)
  + [Print](<#string-List\<T\>. Print()>)
  + [Shuffle](<#List\<T\>-List\<T\>. Shuffle()>)
  + [GetRandomIndex](<#int-List\<T\>. GetRandomIndex\<T\>()>)
  + [GetRandomIndexWithout](<#int-List\<T\>. GetRandomIndexWithout\<T\>(T-exclusion)>)
* [String Extensions](#String-Extensions)
  + [Remove](<#string-Remove(string-removeString)>)
  + [UppercaseWords](<#string-UppercaseWords()>)
  + [DeclOfNum](<#string-DeclOfNum(string-title1, -string-title2, -string-title5, -string-format-=-"{0}-{1}")>)
* [Vector Extensions](#Vector-Extensions)
  + [Abs](<#Vector2-/-Vector3-Abs()>)
  + [FloorToInt](<#Vector2Int-/-Vector3Int-FloorToInt()>)
  + [CeilToInt](<#Vector2Int-/-Vector3Int-CeilToInt()>)
  + [RoundToInt](<#Vector2Int-/-Vector3Int-RoundToInt()>)
  + [WithX](<#Vector3-WithX()>)
  + [WithY](<#Vector3-WithY()>)
  + [WithZ](<#Vector3-WithZ()>)
* [Date Time Extensions](#Date-Time-Extensions)
  + [InSeconds](<#long-InSeconds()>)
  + [FormatedDateTime](<#string-FormatedDateTime()>)
* [Unity Extensions](#Unity-Extensions)
  + [RandomColor](<#Color-RandomColor()>)
  + [SetToParent](<#Transform-SetToParent()>)
  + [CreateReadableTexture](<#Texture2D-CreateReadableTexture()>)
  + [GetRectTransform](<#RectTransform-GetRectTransform()>)
  + [WithAlpha](<#Color-WithAlpha()>)
  + [RandomBool](<#bool-RandomBool()>)
  + [RandomSign](<#int-RandomSign()>)
  + [RandomRangeWithout](<#int-RandomRangeWithout()>)
  + [MyResize](<#Texture2D-MyResize()>)
  + [SetActive](<#SetActive()>)
  + [SetInactive](<#SetInactive()>)
  + [SetLeft](<#RectTransform-SetLeft()>)
  + [SetRight](<#RectTransform-SetRight()>)
  + [SetTop](<#RectTransform-SetTop()>)
  + [SetBottom](<#RectTransform-SetBottom()>)
  + [DestroyAllChild](<#Transform-DestroyAllChild()>)
  + [GetParentsCount](<#Transform-GetParentsCount()>)
  + [DrawLine](<#DrawLine()>)

## Editor Extensions

### `bool` ScriptableObject. GUIButton

* _`string`_ **`text`**: Тест кнопки
* _`Color`_ **`color`**: Цвет кнопки

Добавляет кнопку с текстом и цветом

```csharp
if (this.GUIButton("Test", Color.green))
	Debug.Log("Button pressed");
```

#

### `Rect` ScriptableObject. GUILayoutVertical

* _`Action`_ **`body`**: Тело лейаута
* _`GUIStyle`_ **`style`** (опционально): Стил
* _`params GUILayoutOption[]`_ **`options`** (опционально): GUILayout опции

```csharp
this.GUILayoutVertical(() => {
	// Anything
});
```

#

### `Rect` ScriptableObject. GUILayoutHorizontal

* _`Action`_ **`body`**: Тело лейаута
* _`GUIStyle`_ **`style`** (опционально): Стил
* _`params GUILayoutOption[]`_ **`options`** (опционально): GUILayout опции

```csharp
this.GUILayoutHorizontal(() => {
	// Anything
});
```

#

### ScriptableObject. BeginScrollView

* **`ref`** _`Vector2`_ **`scrollPosition`**: Положение скрола
* _`Action`_ **`body`**: Тело
* _`bool`_ **`alwaysShowHorizontal`** (опционально): Параметр, чтобы всегда показывать горизонтальную полосу прокрутки. Если значение `false` или пропущено, оно отображается только в том случае, если содержимое внутри представления прокрутки шире, чем само представление прокрутки
* _`bool`_ **`alwaysShowVertical`** (опционально):  Параметр, чтобы всегда показывать верликальную полосу прокрутки. Если значение `false` или пропущено, оно отображается только в том случае, если содержимое внутри представления прокрутки шире, чем само представление прокрутки
* _`GUIStyle`_ **`horizontalScrollbar`** (опционально): Дополнительный стиль графического интерфейса, используемый для горизонтальной полосы прокрутки. Если не указано, используется стиль горизонтальной полосы прокрутки из текущего графического интерфейса.
* _`GUIStyle`_ **`verticalScrollbar`** (опционально): Дополнительный стиль графического интерфейса, используемый для верликальной полосы прокрутки. Если не указано, используется стиль верликальной полосы прокрутки из текущего графического интерфейса.
* _`GUIStyle`_ **`background`** (опционально): Стиль фона
* **`params`** _`GUILayoutOption[]`_ **`options`** (опционально): GUILayout опции

```csharp
this.BeginScrollView(ref scrollPosition, () => {
	// Anything
});
```

## List Extensions

### `T` List\<T>. GetRandom()

Возвращает случайный эллемент листа

```csharp
var list = new List<int> { 4, 2, 6, 7, 2 };
var randomElement = list.GetRandom(); // 7
```

#

### Array\<T>. Populate(T value)

Заполняет массив

* _`T`_ **`value`**: Значение для заполнения массива

```csharp
var array new int[5];
array.Populate(3); // array = {3, 3, 3, 3, 3}
```

#

### `string` List\<T>. Print()

Пепреводит лист с читаемый вид

```csharp
var list = new List<int> { 4, 2, 6, 7, 2 };
Debug.log(list.Print()); // "[ 4, 2, 6, 7, 2 ]"
```

#

### `List<T>` List\<T>. Shuffle()

Перемешивает лист

```csharp
var list = new List<int> { 1, 2, 3, 4, 5 };
list.Shuffle(); // "[ 4, 2, 1, 5, 3 ]"
```

#

### `int` List\<T>. GetRandomIndex<T>()

Возвращает случайный индекс листа

```csharp
var list = new List<int> { 100, 25, 342, 9532 };
var index = list.GetRandomIndex(); // 2
```

#

### `int` List\<T>. GetRandomIndexWithout<T>(T exclusion)

Возвращает случайный индекс листа с исключинеим

* _`T`_ **`exclusion`**: Значение, которое мы не хотим чтобы возвращалось

```csharp
var list = new List<int> { 100, 25, 342, 9532 };
var index = list.GetRandomIndexWithout(2); // 3
```

#

## String Extensions

### `string` Remove(string removeString)

Улаляет из строки подстроку

* _`string`_ **`removeString`**: Подстрока, которую надо удалить

```csharp
var str = "Майнкрафт - это моя жизнь";
var newStr = str.Remove("это"); // "Майнкрафт -  моя жизнь";
```

#

### `string` UppercaseWords()

Делает первую букву в каждом слове заглавной

```csharp
var original = "майнкрафт - это моя жизнь";
var uppercased = original.UppercaseWords(); // "Майнкрафт - Это Моя Жизнь"
```

#

### `string` DeclOfNum(string title1, string title2, string title5, string format = "{0} {1}")

Возвращает число и склонённое слово

* _`string`_ **`title1`**: Склонение для 1. (ex. 1 `час`)
* _`string`_ **`title2`**: Склонение для 2. (ex. 2 `часа`)
* _`string`_ **`title5`**: Склонение для 5. (ex. 5 `часов`)
* _`string`_ **`format`** (default = `"{0} {1}"`): Формат вывода

```csharp
var i = 1;
var s = i.DeclOfNum("час", "часа", "часов"); // 1 час
```

```csharp
var i = 2;
var s = i.DeclOfNum("час", "часа", "часов"); // 2 часа
```

```csharp
var i = 5;
var s = i.DeclOfNum("час", "часа", "часов"); // 5 часов
```

#

## Vector Extensions

### `Vector2 / Vector3` Abs()

Возвращает абсолютный вектор

```csharp
var v2 = new Vector2(-2, 4);
var v2Abs = v2.Abs(); // (2, 4)
```

#

### `Vector2Int / Vector3Int` FloorToInt()

Округление вниз всех координат

```csharp
var v3 = new Vector3(0.4, 5.6, 1.3);
var v3f = v3.FloorToInt(); // (0, 5, 1)
```

#

### `Vector2Int / Vector3Int` CeilToInt()

Округление вверх всех координат

```csharp
var v3 = new Vector3(0.4, 5.6, 1.3);
var v3c = v3.CeilToInt(); // (1, 6, 2)
```

#

### `Vector2Int / Vector3Int` RoundToInt()

Округление к ближайшему целому числу всех координат

```csharp
var v3 = new Vector3(0.4, 5.6, 1.3);
var v3r = v3.RoundToInt(); // (0, 6, 1)
```

#

### `Vector3` WithX()

Возвращает вектор с новым значением **x**

* _`float`_ **`x`**: Новое значение **x**

```csharp
transform.position = transform.position.WithX(3);
```

#

### `Vector3` WithY()

Возвращает вектор с новым значением **y**

* _`float`_ **`y`**: Новое значение **y**

```csharp
transform.position = transform.position.WithY(3);
```

#

### `Vector3` WithZ()

Возвращает вектор с новым значением **z**

* _`float`_ **`z`**: Новое значение **z**

```csharp
transform.position = transform.position.WithZ(3);
```

#

## Date Time Extensions

### `long` InSeconds()

Возвращает текущее время и дату в секундах

```csharp
var dt = DateTime.Now;
var seconds = dt.InSeconds();
```

#

### `string` FormatedDateTime()

Время в формате `дней:часов:минут:секунд`

* _`string`_ **`spliter`** (default = `":"`): Разделитель между цифрами

```csharp
var dt = DateTime.Now;
var time = dt.FormatedDateTime();
```

#

## Unity Extensions

#

### `Color` RandomColor()

Возвращяет случайный цвет

```csharp
var color = Extensions.RandomColor();
```

### `Transform` SetToParent()

Выставляет parent для transform и выравнивает его по parent

```csharp
transform.SetToParent(parentTransform);
```

#

### `Texture2D` CreateReadableTexture()

Возвращяет читаемаю текстуру спрайта

```csharp
var readableTexture = image.sprite.CreateReadableTexture();
```

#

### `RectTransform` GetRectTransform()

Возвращает RectTransform компонента

```csharp
var readableTexture = image.sprite.CreateReadableTexture();
```

#

### `Color` WithAlpha()

Возвращает цвет с переданной альфой

* _`float`_ **`alpha`**: Прозрачность

```csharp
image.color = image.color.WithAlpha(0.3f);
```

#

### `bool` RandomBool()

Возвращает случайное булевое значение

* _`float`_ **`probability`** (default = `0.5f`): Вероятность выпадения true. [0, 1]

```csharp
var bit_ili_ne_bit = Extensions.RandomBool();

// true с вероятностью 99%
var playerShoodWin = Extensions.RandomBool(0.99f);
```

#

### `int` RandomSign()

Случайно возвращает 1 или -1

* _`float`_ **`probability`** (default = `0.5f`): Вероятность выпадения 1. [0, 1]

```csharp
var randomSign = Extensions.RandomSign();

// Вернёт 1 с вероятностью 1%
var positivePls = Extensions.RandomSign(0.01f);
```

#

### `int` RandomRangeWithout()

Возвращает случайный число с исключением

* _`int`_ **`min`**: Минимальное значение (включительно)
* _`int`_ **`max`**: Максимальное значение (эксклюзивно)
* _`int`_ **`exclusion`**: Исключение

```csharp
// Вернёт случейное число в диапазоне [0, 4), но не 2. (0, 1 или 3)
var i = Extensions.RandomRangeWithout(0, 4, 2);
```

#

### `Texture2D` MyResize()

Масштабирует текстуру

* _`int`_ **`newWidth`**: Новая ширина
* _`int`_ **`newHeight`**: Новая высота

```csharp
var newTex = texture.MyResize(100, 200);
```

#

### SetActive()

Активирует компонент или gameObject

```csharp
// То же самое что и image.gameObject.SetActive(true);
image.SetActive();
transform.SetActive();
text.SetActive();

// То же самое что и gameObject.SetActive(true);
gameObject.SetActive();
```

#

### SetInactive()

Деактивирует компонент или gameObject

```csharp
// То же самое что и image.gameObject.SetActive(false);
image.SetInactive();
transform.SetInactive();
text.SetInactive();

// То же самое что и gameObject.SetActive(false);
gameObject.SetInactive();
```

#

### `RectTransform` SetLeft()

Выставляет отступ слева

* _`float`_ **`left`**: Отступ

```csharp
rectTransform.SetLeft(10);
```

#

### `RectTransform` SetRight()

Выставляет отступ справа

* _`float`_ **`right`**: Отступ

```csharp
rectTransform.SetRight(10);
```

#

### `RectTransform` SetTop()

Выставляет отступ сверху

* _`float`_ **`top`**: Отступ

```csharp
rectTransform.SetTop(10);
```

#

### `RectTransform` SetBottom()

Выставляет отступ снизу

* _`float`_ **`bottom`**: Отступ

```csharp
rectTransform.SetBottom(10);
```

### `Transform` DestroyAllChild()

Удаляет все дочерние объекты

```csharp
transform.DestroyAllChild();
```

### 'Transform' GetParentsCount()

Возвращает колличество родителей

```csharp
var count = transform.GetParentsCount();
```

#

### DrawLine()

Рисует линию, начинающуюся from к to с заданной шириной

* _`Vector3`_ **`from`**: Начало
* _`Vector3`_ **`to`**: Конец
* _`float`_ **`width`**: Ширина

```csharp
private void OnDrawGizmos()
{	
	DrawLine(Vector3.zero, Vector3.one, 5);
}
```

#
