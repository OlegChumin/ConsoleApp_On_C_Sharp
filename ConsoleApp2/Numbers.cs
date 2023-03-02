namespace ConsoleApp2;

public class Numbers
{
    static void Main(string[] args)
    {
        // NumbersScopes();
        // VariableScope();
    }


    static void ArithmeticOperations()
    {
        var x1 = 10u; // - тип переменной ->
        x1 = 20;
        // x1 = -100;
    }


    static void VariableScope()
    {
        int a = 1; //int
        {
            int b = 2;
            {
                int c = 3;
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.WriteLine($"c = {c}");
            }
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            // Console.WriteLine($"c = {c}");
        }
        Console.WriteLine($"a = {a}");
        // Console.WriteLine($"b = {b}");
        // Console.WriteLine($"c = {c}");
    }
    
    static void NumbersScopes()
    {
        int intNumberMin = Int32.MinValue;
        Int32 intNumberMax = Int32.MaxValue;
        Console.WriteLine("Int32.MinValue = " + intNumberMin);
        Console.WriteLine("Int32.MaxValue = " + intNumberMax);

        // string charNumberMin = char.MinValue.ToString();
        // string charNumberMax = Char.MaxValue.ToString();
        // Console.WriteLine("char.MinValue = " + charNumberMin);
        // Console.WriteLine("Char.MaxValue = " + charNumberMax);

        char someChar = '@';
        Console.WriteLine("char - alaise == System.Char = " + someChar);
        Console.WriteLine($"char - alaise == System.Char = {someChar}");
    }
}