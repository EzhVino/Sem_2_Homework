
// Программа принимает на вход 2 числа, проверяет, является ли одно квадратом другого

// void CheckDiv(int a, int b){
//     if(a == b*b || b == a*a){
//         Console.WriteLine("Одно число является квадратом другого");
//     }else{
//         Console.WriteLine("Ни одно число не является квадратом другого");
//     }
// }
// Console.WriteLine("Введите два числа последовательно: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// CheckDiv(num1, num2);

// ИЛИ

// void CheckDiv(int a, int b){
//     if(a == b*b){
//         Console.WriteLine(a + " является квадратом " + b);
//     }else if(b == a*a){
//         Console.WriteLine(b + " является квадратом " + a);
//     }else{
//         Console.WriteLine("Ни одно число не является квадратом другого");
//     }
// }
// Console.WriteLine("Введите два числа последовательно: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// CheckDiv(num1, num2);

// Программа принимает на вход трехзначное число, показывает вторую цифру числа

// int SecondDigit(int number){
//    int result = (number % 100) / 10;
//    return result;  
//     }
// 
// Console.WriteLine("Введите трехзначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>100 && num<1000){
// Console.WriteLine("Вторая цифра " + SecondDigit(num));
// }else{
// Console.WriteLine("Вы ввели не трехзначное число");
// }

//Программа выводит третью цифру числа или сообщает, что третьей нет

// Console.WriteLine("Введите трехзначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int ThirdDigit(int number){
//    int result = number % 10;
//    return result;  
//     }

//Программа принимает на вход цифру дня недели, проверяет, выходной ли

void Weekend(int dayNumber){
    if(dayNumber == 6 || dayNumber == 7){
        Console.WriteLine("Ура, выходной!");
    }else{
        Console.WriteLine("Не выходной :(");
    }
}

Console.WriteLine("Введите порядковый номер дня недели:");
int num = Convert.ToInt32(Console.ReadLine());
if(num>1 && num<8){
Weekend(num);
}else{
Console.WriteLine("Нет такого дня недели");
}

