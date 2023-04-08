using System;
using System.Collections.Generic;
using System.Threading;

namespace ToDo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Categories category = new Categories();
            int writeNum, writeNum2, defaultNum = 1;
            bool isOpen = true;


            Console.WriteLine($"{new string('/',13)} ToDo List {new string('\\',13)}");

            Console.Write("> Создайте категорию: ");
            category.CreateCategory(Console.ReadLine());

            while (isOpen)
            {
                category.ShowCategories();
                Console.Write(": 1 - Добавить задачу" +
                              "\n: 2 - Удалить задачу" +
                              "\n: 3 - Переместить задачу в другую категорию" +
                              "\n: 4 - Создать категорию" +
                              "\n: 5 - Удалить категорию" +
                              "\n: 6 - Выход из приложения\n" +
                              "\nВыберите номер функции: ");

                writeNum = Int32.Parse(Console.ReadLine());
                if (writeNum == 1)
                {
                    Console.Write("\n> Добавить задачу: ");
                    category.categories[defaultNum].AddTask(Console.ReadLine());
                }
                else if (writeNum == 2)
                {
                    category.categories[defaultNum].ShowTasks();
                    Console.Write("\n> Выберите задачу: ");
                    writeNum = Int32.Parse(Console.ReadLine());
                    category.categories[defaultNum].RemoveTask(writeNum);
                }
                else if (writeNum == 3)
                {
                    Console.WriteLine("\n> Выберите номера категорий");
                    Console.Write("Из - ");
                    writeNum = Int32.Parse(Console.ReadLine());
                    Console.Write("В - ");
                    writeNum2 = Int32.Parse(Console.ReadLine());
                    category.RelocateTask(category.categories[writeNum], category.categories[writeNum2]);
                }
                else if (writeNum == 4)
                {
                    Console.Write("\n> Создайте категорию: ");
                    category.CreateCategory(Console.ReadLine());
                }
                else if (writeNum == 5)
                {
                    Console.Write("\n> Удалите категорию под номером: ");
                    writeNum = Int32.Parse(Console.ReadLine());
                    if (!(writeNum <= 0 || category.categories.Count < writeNum))
                        category.DeleteCategory(writeNum);
                }
                else if (writeNum == 6)
                    isOpen = false;
                else
                    Console.WriteLine("\nНеверное значение");


                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}