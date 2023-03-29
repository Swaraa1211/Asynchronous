using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class AsyncLamba
    {
        async Task<int> a()
        {
            int number = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Executing a");
                    number++;
                }
            });
            Console.WriteLine("In a");
            //await Task.Delay(1000);
            Console.WriteLine("End a");
            return number;
        }
        async Task b()
        {
            Console.WriteLine("In b");
            await Task.Delay(1000);
            Console.WriteLine("End b");
        }
        async Task c(int number)
        {
            Console.WriteLine($"Number from  a: {number}");
            Console.WriteLine("In c");
            await Task.Delay(1000);
            Console.WriteLine("End c");
        }
        static async Task Main(string[] args)
        {
            AsyncLamba obj = new AsyncLamba();
            var Task1 = obj.a();
            var Task2 = obj.b();
            int number = await Task1;
            var Task3 = obj.c(number);

            Console.ReadLine();

        }
    }
}
