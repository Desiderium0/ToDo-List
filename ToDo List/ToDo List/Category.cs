using System;
using System.Collections.Generic;

namespace ToDo_List
{
    class Category : Task
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public void ShowTasks()
        {
            Console.WriteLine($"> Выводим задачи");
            if (tasks.Count != 0)
                for (int i = 0; i < tasks.Count; i++)
                    Console.WriteLine($"{tasks[i]} - {i + 1}");
            else
                Console.WriteLine("Задач нет!\n");
        }
    }
}
