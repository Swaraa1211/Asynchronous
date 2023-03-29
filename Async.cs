using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class newClass
    {
        public async Task<string> Func1()
        {
            Console.WriteLine("Func 1 started");
            await Task.Delay(4000);
            Console.WriteLine("Func 1 ended");
            return "";
        }
        public async Task<string> Func2()
        {
            Console.WriteLine("Func 2 started");
            await Task.Delay(7000);
            Console.WriteLine("Func 2 ended");
            return "";
        }
        public async Task<string> Func3()
        {
            Console.WriteLine("Func 3 started");
            Task.Delay(4000);
            Console.WriteLine("Func 3 ended");
            return "";
        }
        
    }
    internal class Async
    {
        public static void Main(string[] args)
        {
            newClass obj = new newClass();
            var a = obj.Func1();
            var b = obj.Func2();
            Task.WaitAll(a, b);
            Console.ReadLine();

            /*var calculation = new System.Diagnostics.Stopwatch();
            calculation.Start();
            Method1();
            //Task<string> returnMsg = Method1();
            //Console.WriteLine(returnMsg);
            Method2();
            //dummyMethod();

            var ans = dummyMethod();
            Console.WriteLine(ans.Result);
            //int ans = Convert.ToInt32(dummyMethod());
            //Console.WriteLine(ans);

            calculation.Stop();
            Console.WriteLine("Elapsed Time: "+calculation.ElapsedMilliseconds); 
            Console.ReadLine();


        */
        }


            /*public static async Task<string> Method1()
            {

                Console.WriteLine("Method1  Defined");
                Console.WriteLine("Message in Method1");
                string msgReceived = await Method2();
                Console.WriteLine(msgReceived);
                //Console.WriteLine(await Method2());

                Console.WriteLine("Method1 Ended");
                return "Over";
            }
            public static async Task<string> Method2()
            {
                Console.WriteLine("Method2 Defined");
                await Task.Delay(5000);
                string msg = "Message in Method2";
                Console.WriteLine("Method2 Ended");
                return msg;
            }
            public static async Task<int> dummyMethod()
            {
                Console.WriteLine("Dummy Method!!!!!!!!!!");
                return 3;
            }*/
        
    }
    
}
