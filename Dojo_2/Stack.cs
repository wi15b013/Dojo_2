//using Dojo_2.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo_2.Container
{
    class Stack<T>
    {
        class Element<T>
        {
           internal Element<T> next { get; set; }

           internal T data { get; set; }
        }

        private Element<T> first;


        public void Push(T data)
        {
            if(first == null)
            {
                first = new Element<T>() {data=data, next=null };
            }
            else
            {
                Element<T> nuevo = new Element<T>() { data = data, next = first };
                first = nuevo;
            }
        }

        public T Pop()
        {
            if (first == null)
            {
                throw new NullReferenceException("Stack is empty!");
            }
            else
            {
                T value = first.data;
                first = first.next;
                return value;
            } 
        }

        public T Peek()
        {
            if (first != null)
            {
                return first.data;
            }
            else
            {
                //return default(T);
                throw new NullReferenceException("Stack is empty!");
            }
           
        }


    }
}
