using System;
using System.Collections;
using System.Collections.Generic;

namespace TaskSystem
{
    public interface ITaskProcessor
    {
        void Process();

        string GetName();
    }

    public class TaskProcessor
    {
        private readonly List<ITaskProcessor> _tasks = new List<ITaskProcessor>();
        
        public void Process()
        {
            foreach (var task in _tasks)
            {
                var name = task.GetName();
                Console.WriteLine($"Running Task[{name}]\n\n\n");
                task.Process();
                Console.WriteLine($"\n\n\nStopping Task[{name}]");
            }
        }

        public void AddTask(ITaskProcessor task)
        {
            _tasks.Add(task);
        }
    }
}