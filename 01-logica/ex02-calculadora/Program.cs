// Calculadora Simples: Leia dois números e uma operação (+, -, *, /) e exiba o resultado.
Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Choose an operation (+, -, *, /): ");
string operation = Console.ReadLine() ?? "";

if(operation == "+") {
    Console.WriteLine($"Result: {firstNumber + secondNumber}");
} 