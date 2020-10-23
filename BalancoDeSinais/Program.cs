using System;

namespace BalancoDeSinais
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "";
            char s = ' ';
            CStack stack = new CStack();

            Console.WriteLine("Insira alguns caracteres:");
            expression = Console.ReadLine();

            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.EmptyStack())
                        Console.WriteLine("Excesso de simbolos de fechar");
                    else
                        s = stack.Pop();
                    if (s == '(' && c != ')')
                        Console.WriteLine("Se esperava )");
                    if (s == '{' && c != '}')
                        Console.WriteLine("Se esperava }" );
                    if (s == '[' && c != ']')
                        Console.WriteLine("Se esperava ]");
                }
            }

            if (!stack.EmptyStack())
                Console.WriteLine("Excesso de simbolos de abertura");

            Console.ReadKey();
        }
    }
}
