// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write ("Input first number: ");
int firstNumber = Int32.Parse(Console.ReadLine());
Console.Write ("Input second number:");
int secondNumber = Int32.Parse(Console.ReadLine());
if (firstNumber==secondNumber){
    Console.Write ("You entered the same numbers");
} else if (firstNumber>secondNumber){
    Console.Write ($"{firstNumber}>{secondNumber}");
}else {Console.Write($"{secondNumber}>{firstNumber}");
}


//Задача 4: Напишите программу, которая принимает на вход три
//числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int max = 0;
Console.Write("Input first number: ");
int firstNumber = Int32.Parse(Console.ReadLine());
Console.Write ("Input second number: ");
int secondNumber =Int32.Parse(Console.ReadLine());
Console.Write ("Input third number: ");
int thirdNumber = Int32.Parse(Console.ReadLine());
if (firstNumber==secondNumber && secondNumber==thirdNumber){
    Console.Write ("You entered the same numbers");
} else {
    max = firstNumber;
}
if (max<secondNumber){
    max=secondNumber;
}
if (max<thirdNumber){
    max=thirdNumber;
}
Console.WriteLine ($"Max number = {max}");

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Write ("Input number: ");
int number = Int32.Parse(Console.ReadLine());
if (number % 2 == 0){
    Console.Write ($"Yes, {number} is even number");
} else 
{Console.Write ($"No, {number} is odd number");}

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8



