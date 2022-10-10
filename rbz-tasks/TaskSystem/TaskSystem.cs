using System;
using System.Collections;
using System.Collections.Generic;

namespace TaskSystem
{
    public interface ITask
    {
        void Process();

        string GetName();
    }

    public class TaskProcessor
    {
        private readonly List<ITask> _tasks = new List<ITask>();
        
        public void Process()
        {
            foreach (var task in _tasks)
            {
                var name = task.GetName();
                Console.WriteLine($"Running Task[{name}]\n\n\n");
                task.Process();
                Console.WriteLine($"Stopping Task[{name}]\n\n\n");
            }
        }

        public void AddTask(ITask task)
        {
            _tasks.Add(task);
        }
    }
}