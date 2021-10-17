using System;

namespace Laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student[] students = new Student[5];
                students[0] = new Student(1, "Romanov", "Alexander", "Vladimirovich", 2002, "Minsk, st.Stroiteley, h.3", 375298888888, "FIT", 2);
                students[1] = new Student(1, "Romanov", "Alexander", "Vladimirovich", 2002, "Minsk, st.Stroiteley, h.3", 375298888888, "FIT", 2);
                students[2] = new Student(2, "Petrov", "Andrew", "Alekseevich", 2001, "Minsk, st.Stroiteley, h.3", 375298995312, "HTIT", 2);
                students[3] = new Student(3, "Moroz", "Egor", "Vitalievich", 1999, "Minsk, st.Prityckogo, h.25", 375293397862, "TOV", 9);
                students[4] = new Student(4, "Stepanova", "Julia", "Dmitrievna", 2000, "Minsk, st.Prityckogo, h.25", 375294478162, "TOV", 4);

                Console.WriteLine("Список учеников факультета ТОВ:");
                foreach (Student student in students)
                {
                    if (student.Faculty == "TOV")
                        student.Print();
                }
                Console.WriteLine("Список учеников второй группы:");
                foreach (Student student in students)
                {
                    if (student.Group == 2)
                        student.Print();
                }

                if (students[0].Equals(students[1]))
                    Console.WriteLine("Эти ученики одинаковы\n");

                Student Andrew = students[2];
                int dateOfBirth = Andrew.DateOfBirth;
                string surname = Andrew.Surname;
                string name = Andrew.Name;

                Andrew.StudentAge(dateOfBirth);

                Console.WriteLine("Изменение имени: \n");
                Andrew.ChangeName(out name, "Egor");
                Andrew.Name = name;
                Andrew.Print();

                Console.WriteLine("Изменение фамилии: \n");
                Andrew.ChangeSurname(ref surname, "Shimanchik");
                Andrew.Surname = surname;
                Andrew.Print();

                Andrew.ShowCount();


                Console.WriteLine("Список всех учеников:");
                foreach (Student student in students)
                {
                    Console.WriteLine(student.ToString());
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
