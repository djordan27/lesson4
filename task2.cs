// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int GetNumber() {
    int result = 0;
    while(true) {
        if(int.TryParse(Console.ReadLine(), out result)){
            break;
        } else {
            Console.WriteLine("Вы ввели недопустимое значение введите число");
        }
    }
    return result;
}

void sum() {
    int number = Math.Abs(GetNumber());
    int sumNumber = 0;
    int divider = 10;
    int divider1 = 1;
    while(number / divider > 0){
        sumNumber = sumNumber + (number % divider) / divider1;
        divider = divider * 10;
        divider1 = divider1 *10;
    }
    sumNumber = sumNumber + number / divider1;
    Console.WriteLine($"{number} -> {sumNumber}");
}

sum();