using System;
using System.Collections.Generic;

namespace ToDo_List
{
    class Categories : Category
    {
        public Dictionary<int, Category> categories = new Dictionary<int, Category>();
        public int Index { get; private set; }

        public Categories(string name = "") : base(name) { }
        
        public void CreateCategory(string name)
        {
            categories.Add(categories.Count + 1, new Category(name));
            Index = categories.Count + 1;
        }

        public void DeleteCategory(int key) =>
            categories.Remove(key);          
            
        public void ShowCategories()
        {
            int e = 1;
            Console.WriteLine($"\n{new string('-', 13)} Категории { new string('-', 13)}");
            if (categories.Count != 0)
            {
                foreach (var category in categories)
                {
                    Console.WriteLine($"\n{category.Value.Name} - [{category.Key}]");
                    for (int i = 0; i < categories[e].tasks.Count; i++)
                        Console.WriteLine($"- {categories[e].tasks[i]}");
                    e++;
                }  
            }
            else
                Console.Write("\nНет категорий!\n");

            Console.WriteLine($"\n{new string('-', 37)}");
        }

        public void RelocateTask(Category categOut, Category categIn)
        {
            Console.WriteLine($"Доступные задачи в каталоге {categOut.Name}" );
            foreach (var task in categOut.tasks)
                Console.WriteLine($"- {task}");

            Console.Write("Выберите номер задачи: ");
            int write = Int32.Parse(Console.ReadLine());
            categIn.tasks.Add(categOut.tasks[write - 1]);
            categOut.tasks.RemoveAt(write - 1);
        }
    }
}
