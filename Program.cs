using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task_exec
{
    public class taskexec: System.Threading.Tasks.TaskScheduler
    {
        protected override IEnumerable<Task> GetScheduledTasks()
        {
            throw new NotImplementedException();
        }

        protected override void QueueTask(Task task)
        {
            throw new NotImplementedException();
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            throw new NotImplementedException();
            
        }

        public void DoTasks()
        {
            string INIfolderPath;
           

            INIfolderPath = System.IO.Directory.GetCurrentDirectory();
            INIfolderPath = INIfolderPath + "\\data.ini";

            string[] lines = System.IO.File.ReadAllLines(INIfolderPath);

            // Display the file contents by using a foreach loop.
            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
                var t = Task.Run(() => {
                    Console.WriteLine("Task thread ID: {0}",
                Thread.CurrentThread.ManagedThreadId);
                });
                t.Wait();
            }
            Console.ReadKey();

        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        var t = new task_exec.taskexec();
        t.DoTasks();
        }

    }

