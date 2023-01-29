// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
string GetNumber()
{
    string result = Console.ReadLine();
    return result;
}
//1.создание массива
//2.проверка 1ого элемента 1 индекса массива, на переопределение Int
//3.передача успешных элементов в 2ой массив
string []finalArray(string number){
    string [] firstArray = number.Split(',', ' ');
    string [] lastArray = new string [number.Length];
    string word;
    int numberTry;
    int countSuccess = 0;
    int countLastArray = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        word = firstArray[i];
        for (int j = 0; j < word.Length; j++)
        {
            bool success = int.TryParse(word.Substring(j, 1), out numberTry);
            if (success) {
                lastArray[countLastArray] = lastArray[countLastArray] + word.Substring(j, 1);
                countSuccess++;
            }
        }
        
        if(countSuccess > 0) {
            countLastArray++;
            countSuccess = 0;
        }
    }
     return lastArray;
}

int[] arrayOfNumber(string[] array)
{
    int[] arrayOfNumber = new int[array.Length];
    int countArray = 0;
    int countArrayOfNumber = 0;
    while (countArray < array.Length)
    {
        if (int.TryParse(array[countArray], out arrayOfNumber[countArrayOfNumber]))
        {
            countArrayOfNumber++;
        }
        countArray++;
    }
    Array.Resize(ref arrayOfNumber, countArrayOfNumber);
    return arrayOfNumber;
}
string number = GetNumber();
string[] array = finalArray(number);
int[] arrayNumber = arrayOfNumber(array);
Console.Write("[");
for (int i = 0; i < arrayNumber.Length - 1; i++)
{
    Console.Write($"{arrayNumber[i]},");
}
Console.Write($"{arrayNumber[arrayNumber.Length - 1]}]");

