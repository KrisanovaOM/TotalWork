// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GetInpunArrayFromConsole()
{
  Console.WriteLine("Введите элементы массива через запятую без пробелов: ");
  string value = Console.ReadLine();
  string[] arrayStringTest = value.Split(",").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

  return arrayStringTest;
}

void PrintArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + (i == array.Length - 1 ? "]" : ", "));
  }
}

int GetNumberElenentsInArray(string[] array, int limitLenth)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= limitLenth)
    {
      count++;
    }
  }
  return count;
}

string[] GetTotalArray(string[] startArray, int limitLenth)
{
  string[] readyArray = new string[GetNumberElenentsInArray(startArray, limitLenth)];
  int countElementReadyArray = 0;
  for (int i = 0; i < startArray.Length; i++)
  {
    if (startArray[i].Length <= limitLenth)
    {
      readyArray[countElementReadyArray] = startArray[i];
      countElementReadyArray++;
    }
  }
  return readyArray;
}

// Начало основной программы
int limitLength = 4; // Количество символов элемента массива
string[] arrayString = GetInpunArrayFromConsole();
string[] totalArray = GetTotalArray(arrayString, limitLength);
Console.WriteLine("Результат: ");
PrintArray(arrayString);
Console.Write(" -> ");
PrintArray(totalArray);