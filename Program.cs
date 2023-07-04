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



