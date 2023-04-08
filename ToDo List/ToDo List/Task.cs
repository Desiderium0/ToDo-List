using System;
using System.Collections.Generic;

namespace ToDo_List
{
    class Task
    {
        public List<string> tasks = new List<string>();

        public void AddTask(string task) =>
            tasks.Add(task);

        public void RemoveTask(int index) =>
            tasks.RemoveAt(index - 1);
    }
}
