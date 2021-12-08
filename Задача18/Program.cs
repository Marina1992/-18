using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Задача18
{
    class Program
    {
        static void Main(string[] args)


        {
            /* Дана строка, содержащая скобки трёх видов(круглые, квадратные и фигурные) и любые другие символы. 
             * Проверить, корректно ли в ней расставлены скобки. Например, 
             * в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.  
             * Указание: задача решается однократным проходом по символам заданной строки слева направо;
             для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека
            (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.
             */

            Console.WriteLine("Введите строку с разными типами скобок ");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str) ? "Колличество скобок совпаадет" : "Колличество скобок не совпадает");
                 
                           
            Console.ReadLine();
        }

        static bool Check(string str)
        {
            Stack<char> st = new Stack<char>();
            var sk = new Dictionary<char, char>
            {
                {')','('},
                {'}','{'},
                {']','['},
            };
            foreach (var n in str)
            {
                if (n == '{' || n == '(' || n == '[')
                    st.Push(n);//добавляет элемент в стек на первое место
                if (n == '}' || n == ')' || n == ']')
                {
                    if (st.Count == 0 || st.Pop() != sk[n])
                        return false;

                }
            }
            if (st.Count != 0)
                return false;
            return true;

            Console.ReadKey();
            }
        }

    }

    

      