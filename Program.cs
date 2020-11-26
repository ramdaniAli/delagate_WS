using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS4_Delegation
{
    class Program
    {
        public class Q1
        {
            public delegate int Somme(int n1 , int n2 );

            public static  int Methode(int n1 , int n2)
            {
                return n1 + n2;
            }

            public static void Show (int n1 , int n2)
            {
                Somme d = Methode;
                Console.WriteLine(d(n1,n2));
            }
        }

        public class Q2
        {
            public delegate int Square(int num);

            public static void Show (int num)
            {
                //lambda 
                Square method = x => x * x;
                Console.WriteLine(method(num));
            }
        }

        public class Q3
        {

            public static void Show ()
            {
                var anonymous = new { Num = 5, Msg = "WS4" };
                Console.WriteLine($"num : {anonymous.Num} , msg : {anonymous.Msg}");
            }
        }

        //Q4 
        public delegate void deleg();
        public class A
        {
            public void ma ()
            {
                Console.WriteLine("ma");
            }
        }

        public class B
        {
            public void mb ()
            {
                Console.WriteLine("mb");
            }
        }

        public class Q4
        {
            A a = new A();
            B b = new B();

            public delegate void Void();
            
        }
        static void Main(string[] args)
        {
            //question 1 is 
            int number = 5;
            Q1.Show(number , number);
            Q2.Show(number);
            Q3.Show();
            Console.ReadKey();


        }
    }
}
