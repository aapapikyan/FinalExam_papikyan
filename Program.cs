string[] array = new string[10]; //Задаем первоначальный массив
array[0] = "hello";
array[1] = "-2";
array[2] = "world";
array[3] = "alfa";
array[4] = "be";
array[5] = "net";
array[6] = "car";
array[7] = "12";
array[8] = "bravo";
array[9] = "for";
int newLength = 0; //Вводим счетчик подходящих строк
string[] tempArray = new string[10]; //Вводим промежуточный массив для сохранения подходящих строк
for (int i = 0; i < array.Length; i++) //Цикл поиска и сохранения подходящих строк и подсчет количества подходящих строк
{
    if (array[i].Length < 4)
    {
        tempArray[newLength] = array[i];
        newLength++;
    }
}
Console.WriteLine($"Количество строк в массиве, содержащих не более 3 символов, равно {newLength}:");
string[] finalArray = new string[newLength]; //Вводим итоговый массив с длинной, равной количеству подходящих строк
for (int i = 0; i < newLength; i++)// Циклом записываем в итоговый массив строки, сохраненные в промежуточном массиве
{
    finalArray[i] = tempArray[i];
    Console.Write($"{finalArray[i]}   ");
}
