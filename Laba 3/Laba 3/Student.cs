using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_3
{
    public partial class Student
    {
        const long maxFormatNum = 375299999999;
        const long minFormatNum = 375290000000;

        private readonly int id;
        private string surname;
        private string name;
        private string patronymic;
        private int dateOfBirth;
        private string adress;
        private long telnumber;
        private string faculty;
        private static int course;
        private int group;

        private static int change;

        public int Id
        {
            get => id;
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public int DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public long Telnumber
        {
            get { return telnumber; }
            set
            { 
                if(value < minFormatNum || value > maxFormatNum)
                {
                    value = telnumber;
                }
                else
                {
                    throw new Exception("Incorrect number!");
                }
            }
        }

        public string Faculty
        {
            get => faculty;
            set { faculty = value; }
        }
        
        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public static int Change
        {
            get => change;
        }

        ////////////////////////////////////////////
        static Student()
        {
            course = 2;
            change = 0;
            Console.WriteLine("Static Constructor\n");
        }

        public Student()
        {
            faculty = "FIT";
            change++;
        }

        private Student(string surname_parm)
        {
            this.surname = surname_parm;
            change++;
        }

        public Student(int id, string surname, string name, int dateOfBirth, string adress, long telnumber, string faculty = "unknown", int group = 0)
        {
            if (group <= 10 && group >= 1)
            {
                this.id = id;
                this.surname = surname;
                this.name = name;
                this.dateOfBirth = dateOfBirth;
                this.adress = adress;
                this.telnumber = telnumber;
                this.faculty = faculty;
                this.group = group;
                Student.change++;
            }
            else throw new Exception("Такой группы нет!");
        }
        public Student(int id, string surname, string name, string patronymic, int dateOfBirth, string adress, long telnumber, string faculty, int group)
        {
            if (group <= 10 && group >= 1)
            {
                this.id = id;
                this.surname = surname;
                this.name = name;
                this.patronymic = patronymic;
                this.dateOfBirth = dateOfBirth;
                this.adress = adress;
                this.telnumber = telnumber;
                this.faculty = faculty;
                this.group = group;
                Student.change++;
            }
            else throw new Exception("Такой группы нет!");
        }

        ////////////////////////////////////////////////

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public void StudentAge(int dateOfBirth)
        {
            int student_age = 2021 - dateOfBirth;
            Console.WriteLine($"Возраст ученика: {student_age}\n");
        }

        public void ShowCount()
        {
            Console.WriteLine($"Текущее количество учеников: {change}\n");
        }
        public void ChangeName(out string newName, string prevname)
        {
            newName = prevname;
        }

        public void ChangeSurname(ref string newSurname, string surname)
        {
            newSurname = surname;
        }
    }
}
