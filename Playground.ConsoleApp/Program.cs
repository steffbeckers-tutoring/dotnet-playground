// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Recursion

// Fibonacci
uint Fibonacci(uint number)
{
    if (number <= 1)
    {
        return number;
    }

    return Fibonacci(number - 1) + Fibonacci(number - 2);
}

Console.WriteLine(Fibonacci(10));

// Fibonacci with memoization

uint[] fibonacciMemory;

uint FibonacciWithMemoization(uint number)
{
    if (number <= 1)
    {
        return number;
    }

    if (fibonacciMemory[number] > 0)
    {
        return fibonacciMemory[number];
    }

    fibonacciMemory[number] = FibonacciWithMemoization(number - 1) + FibonacciWithMemoization(number - 2);

    return fibonacciMemory[number];
}

uint fibonacciNumber = 50;
fibonacciMemory = new uint[fibonacciNumber + 1];
Console.WriteLine(FibonacciWithMemoization(fibonacciNumber));

// Sum of natural numbers

uint SumOfNaturalNumbers(uint count)
{
    if (count == 0)
    {
        return 0;
    }

    return count + SumOfNaturalNumbers(count - 1);
}

Console.WriteLine(SumOfNaturalNumbers(42));

// Count digits of a number

uint CountDigits(uint number)
{
    if (number < 10)
    {
        return 1;
    }

    return 1 + CountDigits(number / 10);
}

Console.WriteLine(CountDigits(123));

// Reverse a string

string Reverse(string text)
{
    if (string.IsNullOrEmpty(text) || text.Length == 1)
    {
        return text;
    }

    return text[text.Length - 1] + Reverse(text.Substring(0, text.Length - 1));
}

Console.WriteLine(Reverse("steff"));

// Tower of Hanoi

void TowerOfHanoi(int n, char fromRod, char toRod, char auxRod)
{
    // Base case: only one disk → move it directly
    if (n == 1)
    {
        Console.WriteLine($"Move disk 1 from {fromRod} to {toRod}");
        return;
    }

    // Step 1: move top n-1 disks from source to auxiliary
    TowerOfHanoi(n - 1, fromRod, auxRod, toRod);

    // Step 2: move the nth (largest) disk from source to target
    Console.WriteLine($"Move disk {n} from {fromRod} to {toRod}");

    // Step 3: move the n-1 disks from auxiliary to target
    TowerOfHanoi(n - 1, auxRod, toRod, fromRod);
}

TowerOfHanoi(3, 'A', 'C', 'B');
