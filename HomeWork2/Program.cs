using System.Xml.Linq;

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
    float flt = 1/7f;
    double dbl = 1/7d;
    decimal dcml = 1/7m;
    Console.WriteLine("1. Float result: " + flt); //After point max 8 digits
    Console.WriteLine("2. Double result: " + dbl); //After point max 16 digits
    Console.WriteLine("3. Decimal result: " + dcml); //After point max 28 digits
    Console.WriteLine("1. Float result after *7: " + flt * 7);
    Console.WriteLine("2. Double result after *7: " + dbl * 7);
    Console.WriteLine("3. Decimal result after *7: " + dcml * 7);
    bool comp1 = (dbl == flt);
    bool comp2 = (flt * 7 == dbl * 7);
    Console.WriteLine("Float vs Double result before: " + comp1);
    Console.WriteLine("Float vs Double result after: " + comp2);
}
static void task3()
{
    //Implicit Casting
    Console.WriteLine("------Implicit Casting------");
    // int to float
    int myInt1 = 100;
    float myFloat1 = myInt1;
    Console.WriteLine($"Int ({myInt1}) to Float: {myFloat1}");

    // float to double
    float myFloat2 = 99.24F;
    double myDouble1 = myFloat2;
    Console.WriteLine($"Float ({myFloat2}) to Double: {myDouble1}");

    // int to double
    int myInt2 = 24;
    double myDouble2 = myInt2;
    Console.WriteLine($"Int ({myInt2}) to Double: {myDouble2}");

    //Explicit Casting
    Console.WriteLine("------Explicit Casting------");

    // double to int
    double myDouble3 = 99.99;
    int myInt3 = (int)myDouble3;
    Console.WriteLine($"double ({myDouble3}) to int: {myInt3}");

    // float to int
    float myFloat3 = 45.67F;
    int myInt4 = (int)myFloat3;
    Console.WriteLine($"float ({myFloat3}) to int: {myInt4}");

    // double to float
    double myDouble4 = 12345.6789;
    float myFloat4 = (float)myDouble4;
    Console.WriteLine($"double ({myDouble4}) to float: {myFloat4}");

    // decimal to double
    decimal myDecimal = 987654.321M;
    double myDouble5 = (double)myDecimal;
    Console.WriteLine($"decimal ({myDecimal}) to double: {myDouble5}");

}
static void task4()
{
    // Before
    int x = 5;
    int y = 10;
    Console.WriteLine($"Before: X = {x}, Y = {y}");

    SwapMethod (ref x, ref y);

    // After
    Console.WriteLine($"After: X = {x}, Y = {y}");

    static void SwapMethod(ref int x, ref int y)
    {
        int swap = x;
        x = y;
        y = swap;
    }
}
static void task5()
{
    
    double weight;
    double height;
        
    // User input
    Console.Write("Enter your weight in kilograms (e.g., 71.3): "); //Weight input
    weight = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter your height in meters (e.g., 1.74): "); //Height input
    height = Convert.ToDouble(Console.ReadLine());

    // Calculate BMI
    double bmi = CalculateBMI(weight, height);

    // Display BMI and Recommendations
    Console.WriteLine($"\nYour BMI is: {bmi:F2}");
    Recommendations(bmi);

    // BMI calculation method
    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    // Recommendations method
    static void Recommendations(double bmi)
    {
        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight. It's important to eat a nutritious diet and consult with a healthcare provider.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("You have a normal weight. Maintain a balanced diet and regular exercise to stay healthy.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are overweight. Consider a healthy eating plan and regular physical activity.");
        }
        else if (bmi >= 30)
        {
            Console.WriteLine("You are in the obese category. It's advisable to seek medical guidance and work on a weight-loss plan.");
        }
        else
        {
            Console.WriteLine("Incorrect inputs.");
        }
    }
}


//task1();
//task2();
//task3();
//task4();
task5();
