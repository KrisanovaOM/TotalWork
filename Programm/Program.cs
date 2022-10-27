// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetInpunArrayFromConsole()
{
  Console.WriteLine("Введите элементы массива через запятую без пробелов: ");
  string value = Console.ReadLine();
  string[] arrayStringTest = value.Split(",").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

  string[] arrayString = new string[arrayStringTest.Length];
  for (int i = 0; i < arrayString.Length; i++)
  {
    arrayString[i] = arrayStringTest[i];
  }
  return arrayString;
}

void PrintArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + (i == array.Length - 1 ? "]" : ", "));
  }
}

int GetNumberElenentsInArray(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      count++;
    }
  }
  return count;
}

string[] GetTotalArray(string[] startArray)
{
  string[] ReadyArray = new string[GetNumberElenentsInArray(startArray)];
  int countElementReadyArray = 0;
  for (int i = 0; i < startArray.Length; i++)
  {
    if (startArray[i].Length <= 3)
    {
      ReadyArray[countElementReadyArray] = startArray[i];
      countElementReadyArray++;
    }
  }
  return ReadyArray;
}

// Начало основной программы
string[] arrayString = GetInpunArrayFromConsole();
string[] totalArray = GetTotalArray(arrayString);
Console.WriteLine("Результат: ");
PrintArray(arrayString);
Console.Write(" -> ");
PrintArray(totalArray);