using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    class Program
    {
        protected static StackExample<SampleData> stack;
        static void Main(string[] args)
        {
            #region push over limit
            stack = new StackExample<SampleData>();
            var taro = new SampleData("Taro");
            var hanako = new SampleData("Hanako");
            var jiro = new SampleData("Jiro");
            var yoko = new SampleData("Yoko");
            var saburo = new SampleData("Saburo");

            //stack.Push(taro);
            //stack.Push(hanako);
            //stack.Push(jiro);
            //stack.Push(yoko);
            //stack.Push(saburo);
            #endregion

            Console.ReadLine();

            #region delete specific index
            stack = new StackExample<SampleData>();

            //stack.Push(taro);
            //stack.Push(hanako);
            //stack.Push(jiro);
            //stack.Remove(2);
            //stack.Remove(1);
            //stack.Remove(2);
            #endregion

            Console.ReadLine();

            #region get item
            stack = new StackExample<SampleData>();

            stack.Push(taro);
            stack.Push(hanako);
            var item = stack.Pop();
            Console.WriteLine(item.Name);
            item = stack.Pop();
            Console.WriteLine(item.Name);
            item = stack.Pop();
            try
            {
                Console.WriteLine(item.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("it's unsafe - {0}", ex.Message);
            }
            #endregion

            Console.ReadLine();
        }

    }
}
