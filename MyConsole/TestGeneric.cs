using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Generic<T>
    {
        Stack<T> stk = new Stack<T>();
        public void push(T obj)
        {
            stk.Push(obj);
        }

        public T pop()
        {
            T obj = stk.Pop();
            return obj;
        }
    }


    class TestGeneric
    {
        static void Main(string[] args)
        {
            Generic<int> g = new Generic<int>();
            //g.push("CSharp");
        }
    }



}
