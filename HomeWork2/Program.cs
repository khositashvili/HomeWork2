using System.Diagnostics.CodeAnalysis;
static void task1() 
{
    int num1 = 15;
    int num2 = 5;
    int add = num1 + num2;
    int diff = num1 - num2;
    int mult = num1 * num2;
    int div = num1 / num2;
    Console.WriteLine("1. Addition result: " + add);
    Console.WriteLine("2. Subtraction result: " + diff);
    Console.WriteLine("3. Multiplication result: " + mult);
    Console.WriteLine("4. Division result: " + div);
}
        static void task2()
        {
        float flt = 1 / 7f;
        double dbl = 1 / 7d;
        decimal dcml = 1 / 7m;
        Console.WriteLine("1. Float result: " + flt); //After point max 8 digits
        Console.WriteLine("2. Double result: " + dbl); //After point max 16 digits
        Console.WriteLine("3. Decimal result: " + dcml); //After point max 28 digits
        Console.WriteLine("1. Float result after *7: " + flt* 7);
        Console.WriteLine("2. Double result after *7: " + dbl* 7);
        Console.WriteLine("3. Decimal result after *7: " + dcml* 7);

        bool comp1 = (dbl == flt);
        bool comp2 = (flt * 7 == dbl * 7);
        Console.WriteLine("Float vs Double result before: " + comp1);
        Console.WriteLine("Float vs Double result after: " + comp2);
        }

task1();
