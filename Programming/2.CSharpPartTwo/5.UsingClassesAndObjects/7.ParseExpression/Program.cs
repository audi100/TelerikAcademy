using System;
using System.Collections.Generic;

class Program
{
    // Read a string char by char and split it in tokens: "(1 + 2) * 3" -> "(", "1", "+", "2", ")", "*", "3"
    static List<string> Tokenize(string s)
    {
        List<string> tokens = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ') continue; // Skip white space

            string token = String.Empty;

            if (IsChar(s[i])) // String
                for (; i < s.Length && IsChar(s[i]) || i-- == int.MaxValue; i++)
                    token += s[i];

            else if (IsDigit(s[i]) || (s[i] == '-' && IsDigit(s[i + 1]))) // Number
                for (; i < s.Length && (IsDigit(s[i]) || s[i] == '.' || s[i] == '-') || i-- == int.MaxValue; i++)
                    token += s[i];

            else token += s[i]; // Operator

            tokens.Add(token);
        }

        return tokens;
    }

    // Parse an infix expression to postfix: "(", "1", "+", "2", ")", "*", "3" -> "1 2 + 3 *"
    static string ParseExpression(List<string> infix)
    {
        string postfix;

        // TODO: 

        return "3 5.3 + 2.7 * 22 ln 2.2 -1.7 pow / -";
    }

    // Evaluate a postfix expression - "1 2 + 3 *" -> 9
    static double EvaluateExpression(string output)
    {
        var stack = new Stack<double>();

        foreach (string token in output.Split(' '))
            if (token == "+") stack.Push(stack.Pop() + stack.Pop());
            else if (token == "-") stack.Push(-stack.Pop() + stack.Pop());
            else if (token == "*") stack.Push(stack.Pop() * stack.Pop());
            else if (token == "/") stack.Push(1 / stack.Pop() * stack.Pop());
            else if (token == "ln") stack.Push(Math.Log(stack.Pop(), Math.E));
            else if (token == "sqrt") stack.Push(Math.Sqrt(stack.Pop()));
            else if (token == "pow") stack.Push(Math.Pow(y: stack.Pop(), x: stack.Pop())); // x ^ y
            else stack.Push(double.Parse(token));

        return stack.Pop();
    }

    static void Main()
    {
        Console.WriteLine(EvaluateExpression(ParseExpression(Tokenize("(3 + 5.3) * 2.7 - ln(22) / pow(2.2, -1.7)"))));
    }

    // Helper methods
    static bool IsChar(char c)
    {
        return c >= 'a' && c <= 'z';
    }

    static bool IsDigit(char c)
    {
        return c >= '0' && c <= '9';
    }
}
