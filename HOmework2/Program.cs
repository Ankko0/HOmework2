using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOmework2
{
    class Program
    {
        private static Student Addstudent()
        {
            Student student = new Student();

            Console.WriteLine("Введите имя");
            student.FIO = Console.ReadLine();
            Console.WriteLine("Введите ID группы");
            student.GROUP_ID = int.Parse( Console.ReadLine());

            return student;
        }


        static void Main(string[] args)
        {
            studentsDB db = new studentsDB();

            while (true)
            {
                foreach (Group group in db.Groups.ToList())
                {
                    Console.WriteLine("Название группы: {0} Кол-во студентов: {1} Номер группы: {2}", group.Name.Name1, group.Students.Count, group.ID);
                    //Console.ReadLine();
                    foreach (Student student in db.Students.Where(x => x.GROUP_ID == group.ID))
                    {   

                        Console.WriteLine(student.FIO);
                    }

                 
                }

                Console.WriteLine("Какое действие нужно совершить ?");
                Console.WriteLine("1 - добавить студента");
                Console.WriteLine("2 – удалить студента");
                Console.WriteLine("3 – выйти");
                int N = int.Parse(Console.ReadLine());
                switch (N)
                {
                    case 1:
                        try
                        {
                            db.Students.Add(Addstudent());
                            db.SaveChanges();
                        }
                        catch (Exception) { };
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Введите ID");
                            int ID = int.Parse(Console.ReadLine());
                            Student student = db.Students.Find(ID);
                            if (student != null)
                                db.Students.Remove(student);
                            db.SaveChanges();
                        }
                        catch (Exception) { };
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Ошибка");
                        break;

                }
            }

        }
    }
}
