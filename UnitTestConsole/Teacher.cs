using System;
namespace UnitTestConsole
{
    public class Teacher: Employee
    {
        public static double TEACHING_ALLOWANCE_FACTOR = 1.25; // hệ số phụ cấp giảng dạy
        public static double SENIORITY_FACTOR = 1000; // mỗi năm thâm niên được tăng lương 1 triệu


        public int Seniority { set; get; } // số năm công tác

        public Teacher()
        {
        }

        /* Viết 4 test cases cho phương thức này
         * 
         * Lương giảng viên được tính theo công thức sau
         * Lương thực lãnh = lương cơ bản theo hệ số nhà nước (1) + lương thâm niên (2)
         *   + Lương (1) được tính như sau: hệ số lương * 1.49 triệu
         *      - do là giảng viên nên được hưởng 25% phụ cấp giảng dạy của lương cơ bản
         *      - nếu có tham gia công đoàn thì đóng công đoàn: 1% lương cơ bản, ai không tham gia công đoàn thì không phải đóng
         *      
         *   + Lương (2): được tính theo công thức: thâm niên * 1 triệu
         */
        public override double GetSalary()
        {
            double baseSalary = base.GetSalary();
            baseSalary = baseSalary * (UnionMember ? 0.99 : 1);

            double salary = TEACHING_ALLOWANCE_FACTOR * baseSalary + SENIORITY_FACTOR * Seniority;
            return salary;
        }


    }
}

