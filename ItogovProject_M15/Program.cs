// <copyright file="Program.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ItogovProject_M15
{
    /// <summary>
    /// Класс Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод Main
        /// </summary>
        public static void Main()
        {
          var classes = new[]
          {
               new Classroom
               {
                   Students =
                   {
                       "Evgeniy", "Sergey", "Andrew"
                   },
               },
               new Classroom
               {
                   Students =
                   {
                       "Anna", "Viktor", "Vladimir"
                   },
               },
               new Classroom
               {
                   Students =
                   {
                   "Bulat", "Alex", "Galina"
               },
            }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadKey();
        }

        /// <summary>
        /// Метод получения списка всех студентов
        /// </summary>
        /// <param name="classes">Ввод классных комнат</param>
        /// <returns> результат сформированный список студентов </returns>
      public static string[] GetAllStudents(Classroom[] classes)
        {
            var rezult = (from room in classes
                          from item in room.Students
                          select item.ToString()).ToArray();

            return rezult;
        }

        /// <summary>
        /// Класс Classroom
        /// </summary>
        public class Classroom
        {
            /// <summary>
            /// Поле для хранения списка студентов
            /// </summary>
            public List<string> Students = new List<string>();
        }
    }
}
