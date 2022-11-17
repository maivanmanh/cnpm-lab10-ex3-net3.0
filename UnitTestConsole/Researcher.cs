using System;
namespace UnitTestConsole
{
    public class Researcher: Employee
    {
        public static int PAPER_RANK_1_SALARY = 10000; // tương đương 100 triệu
        public static int PAPER_RANK_2_SALARY = 70000;
        public static int PAPER_RANK_3_SALARY = 50000;

        public int NumOfPaper { set; get; } // số lượng bài báo khoa học / năm
        public int PaperRank { set; get; } // hạng từ 1-3, giả sử mọi bài báo đều đồng hạng

        public Researcher()
        {
        }

        /** tính lương THEO THÁNG, viết 4 testcase cho phương thức này
         * 
         * Lương của nghiên cứu viên được tính theo công thức sau
         * Lương thực lãnh = lương cơ bản (1) + phụ cấp nghiên cứu (2)
         *      (1) được tính giống giảng viên
         *      (2) được tính bằng: số lượng bài báo khoa học trong năm * giá tiền của hạng bài báo 
         *      (giả sử tất cả các bài báo đều đồng hạng)
         */
        public override double GetSalary()
        {
            double baseSalary = base.GetSalary();
            int salaryPerPaper = PAPER_RANK_1_SALARY;

            if (PaperRank == 2)
            {
                salaryPerPaper = PAPER_RANK_2_SALARY;
            }
            if (PaperRank == 2)
            {
                salaryPerPaper = PAPER_RANK_3_SALARY;
            }
            double salary = baseSalary + NumOfPaper * salaryPerPaper;

            return salary * 0.99;
        }
    }
}

