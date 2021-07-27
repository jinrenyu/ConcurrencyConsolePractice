using System.Threading;
using System.Threading.Tasks;
using System;

namespace ConcurrencyConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1.new方式实例化一个Task，需要通过Start方法启动
            // Task task = new Task(() =>
            // {
            //     Thread.Sleep(100);
            //     Console.WriteLine($"hello, task1的线程ID为{Thread.CurrentThread.ManagedThreadId}");
            // });
            // task.Start();

            //2.Task.Factory.StartNew(Action action)创建和启动一个Task
            // Task task2 = Task.Factory.StartNew(() =>
            //   {
            //       Thread.Sleep(100);
            //       Console.WriteLine($"hello, task2的线程ID为{ Thread.CurrentThread.ManagedThreadId}");
            //   });

            //3.Task.Run(Action action)将任务放在线程池队列，返回并启动一个Task
            // Task task3 = Task.Run(() =>
            //   {
            //       //Thread.Sleep(100);
            //       Console.WriteLine($"hello, task3的线程ID为{ Thread.CurrentThread.ManagedThreadId}");
            //   });
            Task.FromResult("121");
            Console.WriteLine($"执行主线程！{ Thread.CurrentThread.ManagedThreadId}");
            Console.ReadKey();
        }
    }
}
