using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laba_3
{
    public partial class Student
    {
        public override string ToString()
        {
            return
                $"id: {this.id}\n" +
                $"Имя: {this.name}\n" +
                $"Фамилия: {this.surname}\n" +
                $"Отчество: {this.patronymic}\n" +
                $"Дата рождения: {this.dateOfBirth }\n" +
                $"Адрес: {this.adress}\n" +
                $"Номер телефона: {this.telnumber }\n" +
                $"Факультет: {this.faculty}\n" +
                $"Курс: {course}\n" +
                $"Группа: {this.group}\n" +
                $"_________________________________________________________";

        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new NullReferenceException();

            Student student = obj as Student;
            if (student == null)
                return false;
            return student.id == this.id;
        }

        public override int GetHashCode()
        {
            return (int)(this.group * course);
        }

    }
}