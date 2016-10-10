using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo_2
{
    class App
    {

        private static String welcome = "Welcome to the Stack App";
        private static String bye = "Thanks for using the Stack App!";


       // private static Stack<T> stack;


        static void Main(string[] args)
        {
            //int input;
            
            Console.WriteLine(welcome + "\n");

            do
            {
                DisplayMenu();
                int input;
                int.TryParse(Console.ReadLine(), out input);

                if (input != 1 && input != 2 && input != 3 && input !=4 )
                {
                    Console.WriteLine("Exiting now!\n");
                    break;
                }

                switch (input)
                {
                    case 1:
                        IntegerStack();
                        break;
                    case 2:
                        FloatStack();
                        break;
                    case 3:
                        StringStack();
                        break;
                    case 4:
                       ObjectStack();
                        break;
                }

            } while (true);

            Console.WriteLine(bye + "\n");
            Console.ReadLine();
        }

        //METHODS
        private static void ObjectStack()
        {
            Stack<Object> stack = new Stack<Object>();
            int cnt = 1;
            Console.WriteLine("enter the items");
            Console.WriteLine("if you want to exit press: 666\n");

            do
            {
                Console.WriteLine("{0}. item: ", cnt);
                string name = Console.ReadLine();
                int intNumber;
                float floatNumber;
                if (name!=" " && !int.TryParse(name, out intNumber) && !float.TryParse(name, out floatNumber) )
                {
                    Object item = new Object(name);
                    stack.Push(item);
                    cnt++;
                }
                else break;

            } while (true);

            try
            {
                Console.WriteLine("\nlast read item: {0}", stack.Peek().ToString());
                Console.WriteLine("entered items:");

                //print the stack data
                for (int i = 1; i < cnt; i++)
                    Console.Write("{0}  ", stack.Pop());
                Console.WriteLine();

            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Error: no number allowed");
            }
        }


        public static void FloatStack()
        {
            Stack<float> stack = new Stack<float>();
            int cnt = 1;
            Console.WriteLine("enter the items");
            Console.WriteLine("if you want to exit press any other key \n");

            do
            {
                Console.WriteLine("{0}. item: ", cnt);
                float item;
                if (float.TryParse(Console.ReadLine(), out item))
                {
                    stack.Push(item);
                    cnt++;
                }
                else break;

            } while (true);

            try
            {
                Console.WriteLine("last read item: {0}", stack.Peek());
                Console.WriteLine("entered items:");

                //print the stack data
                for (int i = 1; i < cnt; i++)
                    Console.Write("{0}  ", stack.Pop());

            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Error: stack is empty!");
            }
        }

        public static void StringStack()
        {
            Stack<String> stack = new Stack<String>();
            int cnt = 1;
            Console.WriteLine("enter the items");
            Console.WriteLine("if you want to exit press: 666\n");

            do
            {
                Console.WriteLine("{0}. item: ", cnt);
                String item = Console.ReadLine();

                if (item != "666")
                {
                    stack.Push(item);
                    cnt++;
                }
                else break;
                
            } while (true);

            try
            {
                Console.WriteLine("last read item: {0}", stack.Peek());
                Console.WriteLine("entered items:");

                //print the stack data
                for (int i = 1; i < cnt; i++)
                    Console.Write("{0}  ", stack.Pop());

            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Error: stack is empty!");
            }
        }
        public static void IntegerStack()
        {
            Stack<int> stack = new Stack<int>();
            int cnt = 1;
            Console.WriteLine("enter the items");
            Console.WriteLine("if you want to exit press any other key \n");

            do
            {
                Console.WriteLine("{0}. item: ", cnt);
                int item;
                if (int.TryParse(Console.ReadLine(), out item))
                {
                    stack.Push(item);
                    cnt++;
                }
                else break;

            } while (true);

            try
            {
                Console.WriteLine("last read item: {0}", stack.Peek());
                Console.WriteLine("entered items:");

                //print the stack data
                for (int i = 1; i < cnt; i++)
                    Console.Write("{0}  ", stack.Pop());

            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Error: stack is empty!");
            }

        }

        
        public static Boolean EnterAgain()
        {
            Console.WriteLine("Once again? (y/n) \n");
            String again = Console.ReadLine();
           // Console.ReadKey().KeyChar == 'y'

            if (again == "y")
                return true;
            else return false;
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\nselect the kind of element you want to work with:\n");
            Console.WriteLine("\t1- Integer\n");
            Console.WriteLine("\t2- Float\n");
            Console.WriteLine("\t3- String\n");
            Console.WriteLine("\t4- Object\n");
            Console.WriteLine("\nPress any other key to exit\n");
        }

    }
}
