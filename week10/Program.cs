using System;
delegate int NumberChanger(int x);
delegate string TextChanger(string y);
delegate void GetValue(int x);
delegate void GetWord(string y);

namespace week10
{
    class Program
    {
        static int number = 20;
        static string message = "ik ben 22 jaar oud";

        static void Main(string[] args)
        {
            //Console.WriteLine("het nummer is {0}", AddNumber(3));
            NumberChanger nc = new NumberChanger(AddNumber);
            Console.WriteLine("het nummer is {0}", nc(5));
            Console.WriteLine("het nummer is {0}", nc.Invoke(3));
            NumberChanger ncMult = new NumberChanger(Multinumber);
            Console.WriteLine("Het nummer is {0}", ncMult(2));
            NumberChanger ncDev = new NumberChanger(DevideNumber);
            Console.WriteLine("Het nummer is {0}", ncDev(2));
            NumberChanger ncSub = new NumberChanger(subtractNumber);
            Console.WriteLine("Het nummer is {0}", ncSub(3));

            TextChanger tc = new TextChanger(AddText);
            Console.WriteLine("De tekst is {0}", tc(" en ik wil een kopje koffie"));

            //instantiate the delegate
            //TextChanger word = DelegateMethod;
            //call the delegate
            //word("helloow");
            GetWord word = WordValue;
            GetValue value = NumberValue;
            value(5);
            value(ncSub(5));
            //value(nc(1));
            value(ncMult(5));
            word(message);






        }
        public static int Multinumber(int b)
        {
            number *= b;
            return number;
        }


        public static int AddNumber(int a)
        {
            number += a;
            return number;
        }

        public static int DevideNumber(int c)
        {
            number /= c;
            return number;
        }

        public static int subtractNumber(int d)
        {
            number -= d;
            return number;
        }

        public static string AddText(string f)
        {
           message += f;
           return message;
        }

        public static void NumberValue(int number)
        {
            Console.WriteLine("Het nummer is {0}", number);
        }

        public static void WordValue(string message)
        {
            Console.WriteLine("Het nummer is {0}", message);
        }


    }
}
