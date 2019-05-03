using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3._1_BudianuViorela
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to calculate factorial using recursion in C# + iterative + time difference.
            int factor = 1, numar = 20;
            int i = 1;
            while (i <= numar)
            {
                factor *= i;
                i++;
            }
            //Console.WriteLine(Factorial(numar)); //Compilation time: 0,2 sec, absolute running time: 0,13 sec, cpu time: 0,11 sec, average memory usage: 15 Mb, average nr of threads: 3, absolute service time: 0,36 sec
            Console.WriteLine(factor);  //Compilation time: 0,16 sec, absolute running time: 0,09 sec, cpu time: 0,09 sec, average memory usage: 14 Mb, average nr of threads: 3, absolute service time: 0,3 sec
                                        //Algorithm to find if Array contains duplicates? 
            Console.WriteLine("Dati dimensiunea si elemenntele vectorului:");
            int dime = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[dime];
            for (int index = 0; index < dime; index++)
            {
                array1[index] = Convert.ToInt32(Console.ReadLine());
            }


            if (CheckDuplicates(dime, array1))
            {
                Console.WriteLine("Avem duplicate");
            }
            else
            {
                Console.WriteLine("Vectorul are elemente unice");
            }

            //How to find sum of digits of a number using Recursion? 
            Console.WriteLine("Numarul");
            int numarul = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sumaCifrelor(numarul));

            //Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number? 
            MajorityAppears();
            //Write a Program which checks if two Strings are Anagram or not? 

            string cuvant1 = "aaaaaa", cuvant2 = "Labina";
            if (Anagram(cuvant1, cuvant2))
            {
                Console.Write("Anagram");

            }
            else
            {
                Console.Write("Nu e Anagram");
            }

            //Write a function to print the nth number in Fibonacci series?
            int nr = 9;
            Console.Write(Fib(nr));
            //Write a function to count a total number of set bits in a 32 - bit Integer ?
            // vedem mai intai numarul in baza 2
            // numaram cati de 1 avem 
            long n = 65;
            Console.WriteLine(SetBits(n));
            // Write a function to remove duplicate characters from String?
            Console.WriteLine(removedupes("Alabalaportocala"));

            //C# program to check if a number is Armstrong number or not?
            n = ArmstrongNumber();

            // Algorithm to check if a number is Prime or not? 
            NumarPrim();

            //Algorithm to check if a number is a Palindrome ? V
            Console.Write("numar Palindrom:");
            int numarp = Convert.ToInt32(Console.ReadLine());

            int reverse = Reverse(numarp);
            if (numarp == Reverse(numarp))
            {
                Console.Write("Palindrome");
            }
            else
            {
                Console.Write("Nu e numar palindrom");
            }

            //How to rotate an array by a given pivot?
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int pivot = 2;
            //parcurgem de la al doilea element pana la pivot, si punem primul element intr-o variabila auxiliara
            for (int a = 1; a <= pivot; a++)
            {
                int aux = array[0];
                // mutam elementele de la final spre inceput
                for (int k = 1; k < array.Length; k++)
                {
                    array[k - 1] = array[k];

                }
                array[array.Length - 1] = aux;
            }
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j]);
            }

            // Sorting an Array using Selection Sort

            int[] array11 = new int[5] { 11, 21, 13, 4, 25 };
            int min = array11[0];
            SelectionSort(array11);


            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + ",");
            }
            //Sorting an Array using Bubble Sort
            int[] array2 = new int[5] { 11, 21, 13, 4, 25 };
            BubbleSort(array2);
            //--------------------------------------------------------------------------

            //How to find the nth element from the end, in a singly linked, in a single pass?
            Console.Write("Al catelea element de la final doriti sa il aflati?");
            int nth = Convert.ToInt32(Console.ReadLine());

            LinkedList<int> linked = new LinkedList<int>();


            LinkedListNode<int> nod1 = linked.AddLast(1);
            LinkedListNode<int> nod2 = linked.AddLast(2);
            LinkedListNode<int> nod3 = linked.AddLast(3);
            LinkedListNode<int> nod4 = linked.AddLast(4);
            LinkedListNode<int> nod5 = linked.AddLast(5);
            LinkedListNode<int> nod6 = linked.AddLast(6);
            LinkedListNode<int> nod7 = linked.AddLast(6);
            LinkedListNode<int> nod8 = linked.AddLast(77);
            LinkedListNode<int> nod9 = linked.AddLast(77);

            //pointers 
            LinkedListNode<int> p1 = linked.First;
            LinkedListNode<int> p2 = linked.First;
            Console.Write(p1.Value);

            // loop pana la valoarea introdusa -1
            for (int j = 0; j < nth - 1; j++)
            {
                // mutam p2 pana la nth-1 (daca nu e null)

                if (p2 == null)
                {
                    break;
                }

                p2 = p2.Next;
            }

            // in acest moment p2 este la nodul (nth-1)in fata lui p1. Le mutam pe amandoua pana p2 devine null - ajunge la ultimul nod

            while (p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            Console.WriteLine(Convert.ToString(p1.Value));
            Console.ReadLine();

            //Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion?
           //- Initializam 3 pointeri prev -NULL, curent - head si next -NULL.
            // -Iteram linked list.In loop:


//pointers 
            LinkedListNode<int> next = null;
            LinkedListNode<int> prev = null;
            LinkedListNode<int> current = linked.First;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;

            }
            linked.First = prev;

            foreach (var a in linked)
            {
                Console.Write(a);
            }

            //How to remove duplicates from a sorted linked list?
            LinkedListNode<int> head = linked.First;
            LinkedListNode<int> next = head.Next;
            while (next != null)
            {

                if (head == next)
                {
                    linked.Remove(head);
                }
                next = next.Next;
            }
            foreach (var a in linked)
            {
                Console.WriteLine(a);

            }

            //How to detect a cycle in a singly linked list?
            //How to merge two sorted linked list, write a program in your favorite programming language e.g. Java, C#
            LinkedList<int> linked1 = new LinkedList<int>();
            LinkedList<int> linked2 = new LinkedList<int>();
            LinkedList<int> linked3 = new LinkedList<int>();

            LinkedListNode<int> nod11 = linked1.AddLast(1);
            LinkedListNode<int> nod12 = linked1.AddLast(2);
            LinkedListNode<int> nod13 = linked1.AddLast(3);
            LinkedListNode<int> nod14 = linked1.AddLast(4);
            LinkedListNode<int> nod15 = linked1.AddLast(5);
            LinkedListNode<int> nod16 = linked1.AddLast(6);
            LinkedListNode<int> nod17 = linked1.AddLast(6);
            LinkedListNode<int> nod18 = linked1.AddLast(77);
            LinkedListNode<int> nod19 = linked1.AddLast(77);

            LinkedListNode<int> nod21 = linked2.AddLast(1);
            LinkedListNode<int> nod22 = linked2.AddLast(12);
            LinkedListNode<int> nod23 = linked2.AddLast(13);
            LinkedListNode<int> nod24 = linked2.AddLast(24);
            LinkedListNode<int> nod25 = linked2.AddLast(51);
            LinkedListNode<int> nod26 = linked2.AddLast(63);
            LinkedListNode<int> nod27 = linked2.AddLast(65);
            LinkedListNode<int> nod28 = linked2.AddLast(77);
            LinkedListNode<int> nod29 = linked2.AddLast(773);


            LinkedListNode<int> current1 = linked1.First;
            LinkedListNode<int> current2 = linked2.First;

            for (int ii = 0; ii < linked1.Count - 1; ii++)
            {
                for (int j = 0; j < linked2.Count - 1; j++)
                {
                    if (current1.Value < current2.Value)
                    {
                        linked3.AddLast(current1.Value);
                        current1 = current1.Next;

                    }
                    else
                    {
                        if (current1.Value == current2.Value)
                        {
                            linked3.AddLast(current1.Value);
                            current1 = current1.Next;
                            current2 = current2.Next;
                        }
                        else
                        {
                            linked3.AddLast(current2.Value);
                            current2 = current2.Next;
                        }

                    }
                }
            }
            foreach (var a in linked3)
            {
                Console.WriteLine(a);
            }

        }




        private static int Factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        private static bool CheckDuplicates(int n, int[] array)
        {
            bool duplicat = false;
            for (int index1 = 0; index1 < n - 1; index1++)
            {
                for (int index2 = index1 + 1; index2 < n; index2++)
                {
                    if (array[index1] == array[index2])
                    {
                        duplicat = true;
                        break;
                    }
                }
                break;
            }
            return duplicat;
        }
        private static int sumaCifrelor(int n)
        {
            int suma = 0;

            if (n < 10) //caz elementar
            {
                return n;
            }
            else
            {
                suma += n % 10 + sumaCifrelor(n / 10);

            }
            return suma;
        }
        private static void MajorityAppears()
        {
            Console.WriteLine("Dati dimensiunea si elementele vectorului:");
            int dimen = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[dimen];
            for (int index = 0; index < dimen; index++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }
            int element = array[0], pozitia = 0, max = 1;
            for (int k = 0; k < array.Length - 1; k++)
            {
                int count = 1;//pentru ca fiecare element se afla macar o data;

                for (int l = k + 1; l < array.Length; l++)
                {
                    if (array[k] == array[l])
                    {
                        count++; // numar de cate ori apare;
                    }

                }
                if (count > max)
                {
                    pozitia = k;
                    element = array[k];
                    max = count;
                }
            }
            Console.WriteLine($"Elementul care apare cel mai des:{element},prima aparitie:{pozitia},nr aparitii:{max}");
        }
        private static bool Anagram(string v, string x)
        {
            if (v.Length != x.Length)
                return false;
            else
            {
                v = v.ToLower();
                x = x.ToLower();
                int count = 0;
                char[] v1 = v.ToCharArray();
                char[] x1 = x.ToCharArray();
                Array.Sort(x1);
                Array.Sort(v1);
                for (int i = 0; i < v1.Length; i++)
                {
                    if (x1[i] == v1[i])
                    {
                        count++;
                    }

                }

                if (count == v.Length)
                    return true;
                else
                    return false;
            }
        }
        private static int Fib(int n)
        {
            int a = 0, b = 1, c = 0;

            // primul numar din Fibonacci 
            if (n == 0) return a;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
        public static int SetBits(long numar)
        {
            string biti = "";
            int x, count = 0;
            while (numar != 0)
            {
                x = (int)numar % 2;
                biti += x;
                numar = numar / 2;

            }
            int i = 0;
            while (i < biti.Length)
            {
                if (biti[i] == '1')
                    count++;
                i++;
            }
            return count;
        }
        //-----------varianta 2 la set bits----
        public static int SetBits(int numar)
        {
            string biti = Bits(numar);
            int count = 0;

            int i = 0;
            while (i < biti.Length)
            {
                if (biti[i] == '1')
                    count++;
                i++;
            }
            return count;
        }
        public static string Bits(int numar)
        {
            string biti = "";
            if (numar == 1)
            {
                return "1";
            }
            else
            {
                biti += Convert.ToString(numar % 2) + Bits(numar / 2);
            }
            return biti;
        }

        public static string removedupes(string s)
        {
            string newString = string.Empty;
            List<char> found = new List<char>();
            foreach (char c in s)
            {
                if (found.Contains(c))
                    continue;

                newString += c.ToString();
                found.Add(c);
            }
            return newString;
        }

        private static long ArmstrongNumber()
        {

            int n, r, sum = 0, temp;
            Console.Write("numar= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
            return n;
        }

        // NumarPrim - cand se imparte doar la el insusi si la 1
        private static void NumarPrim()
        {
            Console.WriteLine("Dati numarul");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1 || n == 2)
            {
                Console.WriteLine("Numarul introdus este prim");
            }

            else
            {
                bool gasit = false;

                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Numarul nu este prim");
                        gasit = true;
                        break;
                    }


                }
                if (gasit == false)
                {
                    Console.WriteLine("Numar prim");
                }
            }
        }
        private static int Reverse(int numar)
        {

            int n = 0;
            while (numar != 0)
            {
                n = n * 10 + numar % 10;
                numar = numar / 10;
            }
            return n;
        }
        //parcurgem vectorul si vedem daca elementul curent este mai mic decat min. daca da, interclasam
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }
        private static void BubbleSort(int[] array)
        {

            bool ok = true;

            do
            {
                ok = true;
                for (int f = 0; f < array.Length - 1; f++)
                {
                    if (array[f] > array[f + 1])
                    {
                        int aux = array[f];
                        array[f] = array[f + 1];
                        array[f + 1] = aux;
                        ok = false;
                    }
                }
            } while (ok == false);
            for (int f = 0; f < array.Length; f++)
            {
                Console.Write(array[f] + " ");
            }
        }





    }


}
