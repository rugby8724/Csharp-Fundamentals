
StartCalculator();

void StartCalculator()
{
    Console.WriteLine("Hello!");
    Console.WriteLine("Input the first number: ");

    var firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Input the second number: ");
    var secondNumber = int.Parse(Console.ReadLine());
    var mathOperation = "";
    while(mathOperation == "" || mathOperation == "bad response")
    {
        mathOperation = MathmaticalOperations();
    }
    var total = Calculate(firstNumber, secondNumber, mathOperation);
    Console.WriteLine(total);
    Console.WriteLine(" Press any key to exit program");
    Console.ReadKey();
    

}

string MathmaticalOperations()
{
    Console.WriteLine("What would operation would you like to do? ");
    Console.WriteLine("[A]dd");
    Console.WriteLine("[S]ubtract");
    Console.WriteLine("[M]ultiply");
    var mathOperation = Console.ReadLine().ToLower();
    if(mathOperation == "a" || mathOperation == "s" || mathOperation == "m")
    {
        return mathOperation;
    }
    return "bad response";

}
string Calculate(int a, int b, string oper)
{
    string op;
    int total;
    if(oper == "a")
    {
        op = " + ";
        total = a + b;
        
    }
    else if(oper == "s")
    {
        op = " - ";
        total = a - b;
    }
    else
    {
        op = " * ";
        total = a * b;
    }
    return a + op + b + " = " + total;
}