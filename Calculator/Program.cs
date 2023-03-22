Console.WriteLine("Enter the operation (+/-):");
char userOperator = char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());



switch (userOperator)
{
    case '+':
        addition(firstNum, secondNum); 
        break;
    case '-':
        Subtraction(firstNum, secondNum); 
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}



static void addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}