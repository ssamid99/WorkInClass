using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp.List
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3];
            //numbers[0] = 12;
            //numbers[1] = 22;
            //numbers[3] = 33;
            //Array.Resize(ref numbers, numbers.Length + 1);

            ////non gerenics
            //ArrayList numbers = new ArrayList();
            //numbers.Add(1);
            //numbers.Add(5);
            //numbers.Add(true);
            //numbers.Add("string");
            //numbers.Add(new DateTime(2022, 10, 11));
            //numbers.Add(DateTime.Now);
            //numbers.Add(DateTime.UtcNow);

            //numbers.Remove(5);          //elemeti silir
            //numbers.RemoveAt(1);        //index e gore silir
            //numbers.RemoveRange(2,1);   //hansi index den bashlasin nece eded silsin. Substring methodu kimi
            //numbers.Insert(2, "YES");
            //numbers.Reverse();
            //Console.WriteLine(numbers.IndexOf(5));

            //Console.WriteLine($"count: {numbers.Count}");
            //numbers.Add("test");
            //numbers.Add("Test1");
            //numbers.Add("test1111");
            //numbers.Add("test111");
            //numbers.Sort(new MyComparer());

            Hashtable numbers = new Hashtable();
            //numbers.Add("bir", 11);
            //numbers.Add("iki", 32);
            //numbers.Add(0, 334);
            //numbers.Add(true, "dogudur");
            //numbers.Add(false, "yanlishdir");
            //numbers.Add(11, "test");
            //numbers.Add(12, "test");
            //if (numbers.Contains(11111))
            //{
            //    Console.WriteLine("tapildi");
            //}
            //else
            //{
            //    Console.WriteLine("tapilmadi");
            //}

            //Console.WriteLine(numbers["iki"]);
            //Console.WriteLine(numbers[0]);
            //Stack stack = new Stack();
            //stack.Push(23); //Pop goturennen sra silir
            //stack.Push(25);
            //stack.Push(12);
            //stack.Peek(); //Peek goturennen sora silmir
            //while (stack.Count > 0)
            //{
            //    object v = stack.Pop();
            //    Console.WriteLine(v);
            //}
            //foreach (DictionaryEntry item in numbers)
            //{
            //    Console.WriteLine($"Key: '{item.Key} -> Value: {item.Value}'");
            //}

            //Queue queue = new Queue();
            //queue.Enqueue(23); //DAXIL EDIRIK
            //queue.Enqueue(25);
            //queue.Enqueue(12);

            //while (queue.Count > 0)
            //{
            //    object v = queue.Dequeue(); //CIXARIRIQ
            //    Console.WriteLine(v);
            //}

            //SortedList list = new SortedList(new MyComparer()); //siraliyib saxliyir
            //list.Add(1, "bir");
            //list.Add(19, "doqquz");
            //list.Add("111", "onbir");
            //list.Add(1112, "iki");
            //foreach(DictionaryEntry item in list)
            //{
            //    Console.WriteLine($"{item.Key},  {item.Value}");
            //}



            // Generics

            //Stack<int> gStack = new Stack<int>();
            //gStack.Push(2);
            //gStack.Push(true);
            //gStack.Push("test");

            //Queue<int> qq= new Queue<int>();
            //qq.Enqueue(2);
            //qq.Enqueue(3);
            //qq.Enqueue(9);

            //SortedList<string, int> sl = new SortedList<string, int>();
            //sl.Add("bir", 1);
            ////sl.Add(11, "onbir"); //sherte gore ishdyr 1nci string yazmishiqsa ilk olaraq string gelmelidi

            List<string> list = new List<string>();
            //list.Add("demo");
            //list.Add("demo1");
            //list.Add("demo3");
            //Console.WriteLine("------------");
            //Console.WriteLine(list[1]);
            //Console.WriteLine("------------");

            ////list.Clear();
            ////list.RemoveAt(0);
            //// list.RemoveAll(x => x == "demo"); //lambda expression

            //list.Insert(1, "SALAM");
            ////list.Insert(1, true); //Type yaza bilmirik

            //if (list.Contains("SALAM"))
            //{
            //    Console.WriteLine("beli");
            //}

            //foreach(string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("bir", 1);
            dict.Add("iki", 2);
           // Console.WriteLine(dict["iki"]);

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
