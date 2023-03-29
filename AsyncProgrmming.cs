namespace Asynchronous
{
    internal class AsyncProgrmming
    {
        //threading - for concurrent execution
        static async Task Main(string[] args) //task is similar to PROMISES in JS
        {
            Task<int> resultantNumber = returnNum();
            FirstMethod();
            await resultantNumber;
            
            
            Console.WriteLine($"Return num = {resultantNumber.Result}");
            SecondMethod();
            
            Console.ReadLine();
        }
        public static async void FirstMethod()
        {
            Console.WriteLine("First Method");
            await Task.Delay(5000); //await works for a return func
            //Thread.Sleep(5000); //delay , thread is a void func
            Console.WriteLine("Method1 Ended");
        }
        public static void SecondMethod()
        {
            Console.WriteLine("Second Method");
            Console.WriteLine("Method2 Ended");
        }
        public static async Task<int> returnNum()
        {
            Thread.Sleep(5000);
            return 10;
        }
    }
}