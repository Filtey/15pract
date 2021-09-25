using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khakimov_15prakt1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 задание
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Stack Stck = new Stack();

            for (int i = 1; i <= n; i++)
            {
                Stck.Push(i);
            }

            Console.WriteLine("Размерность стека " + Stck.Count);
            Console.WriteLine("Верхний элемент стека= " + Stck.Peek());
            Console.WriteLine("Размерность стека " + Stck.Count);

            Console.Write("Содержимое стека= ");
            while (Stck.Count != 0)
            {
                Console.Write("{0} ", Stck.Pop());
            }
            Console.WriteLine();
            Console.WriteLine("Новая размерность стека " + Stck.Count);
            Console.ReadKey();




            //2 задание
            StreamReader sr1 = new StreamReader("f2.txt");
            string stroka = sr1.ReadToEnd();
            sr1.Close();
            bool proverka = true;
            Stack skobka = new Stack();        
            

            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == '(') skobka.Push(i);
                else if (stroka[i] == ')')
                {

                    if (skobka.Count == 0)
                    {
                        proverka = false;
                        Console.WriteLine("В позиции " + i + "лишняя скобка");
                    }
                    else
                    {
                        skobka.Pop();
                    }
                }
            } 
            

            if (skobka.Count == 0)
            {
                if (proverka) Console.WriteLine("скобки сбалансированы!");
            }
            else
            {
                Console.Write("Возможно лишняя скобка в позиции ");
                while (skobka.Count != 0)
                {
                    Console.Write("{0} ", (int)skobka.Pop());
                }
                Console.WriteLine();

            }
        }

    }
}
