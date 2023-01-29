// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
//1- ый Вариант
// void cycle()
// {
//     int a = 0;
//     int a1 = 0;
//     int b = 2;
//     int i = 0;//1 итерация цикла проверяет введеное значение на возможность преопределения в int, пока не получится.
//     for (; i < b; i++)
//     {
//         if (a == 0 && b == 2)
//         {
//             if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b)){
//                 a1 = a;
//             } else {
//                 Console.WriteLine("Ошибка ввода! Введите 2 натуральных числа");
//                 a = 0;
//                 b = 2;
//                 i = i - 1;
//             }
//         } else {
//             a = a * a1;
//         }

//     }
//     Console.WriteLine(a);
// }

// cycle();

//2-ой вариант

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

int degree(int a, int b){

    int a1 = a;

    for (int i = 1; i < b; i++){
        a = a * a1;
    }
    return a;
}

int a = GetNumber();
int b = GetNumber();

Console.WriteLine($"{a}, {b} -> {degree(a, b)}");