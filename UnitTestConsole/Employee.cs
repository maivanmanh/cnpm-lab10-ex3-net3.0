using System;
namespace UnitTestConsole
{
    public abstract class Employee
    {
        public static int BASE_SALARY = 1490; // lương cơ bản: 1.49 triệu

        public int ID { set; get; }
        public String Name { set; get; }
        public double Factor { set; get; } // hệ số lương
        public bool UnionMember { set; get; } // thành viên của Công Đoàn ?


        public Employee()
        {
        }

        // Tính lương THÁNG:  phương thức này không cần test
        public virtual double GetSalary()
        {
            return Factor * BASE_SALARY;
        }
    }
}

