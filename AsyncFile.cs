using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    public class AsyncFile
    {
        string path = "D:\\AsyncFile\\file.txt";
        FileStream file = null;
        public async Task<FileStream> method1()
        {
            Console.WriteLine("method1");
            //FileStream file = null;
            await Task.Run(() =>
            {
                
                file = new FileStream(path, FileMode.OpenOrCreate);
                Console.WriteLine("file open");
                
            });
            await Task.Delay(5000);
            //string msg = "File1 opened in method1";
            //Console.WriteLine("File1 in method1");
            Console.WriteLine("method1 ended");
            return file;
        }
        public async Task<string> method2()
        {
            Console.WriteLine("method2");
            StreamWriter streamWriter = new StreamWriter(file);
            streamWriter.Write("Hi Message from method2");

            streamWriter.Close();
            file.Close();
            Console.WriteLine("method2 ended");
            string msg = "Two Done!";
            return msg;
        }
        async Task<string> method3(FileStream file)
        {
            StreamWriter streamWriter = new StreamWriter(file);
            streamWriter.Write("Hi Message from method3");

            streamWriter.Close();
            file.Close();
            Console.WriteLine("File closed in method3");
            string msg = "Three Done!";
            return msg;
        }
        async Task<int> method4()
        {
            Console.WriteLine("Opened and Written");
            return 0;
        }
        public static async Task Main(string[] args)
        {
            AsyncFile obj = new AsyncFile();

            /*DirectoryInfo directoryInfo = new DirectoryInfo(obj.path);
            var file = obj.method1().Result;
            obj.method2();
            obj.method3(file);*/
            
            var task1 = obj.method1();
            var task2 = obj.method2();
            //var task3 = obj.method3();
            Task progress = Task.WhenAll(task1, task2);
            //Task progress = Task.WhenAny(task1, task2);
            //await progress;

            //var task4 = obj.method4();
            while (true)
            {
                if (progress.Status == TaskStatus.RanToCompletion)
                {
                    //obj.method4();
                    Task task4 = obj.method4();
                    break;
                }
                else
                {
                    Console.WriteLine("Not Completed");
                }
                Thread.Sleep(3000);
            }
            //Console.WriteLine(progress);

            Console.ReadLine();
        }
    }
}
