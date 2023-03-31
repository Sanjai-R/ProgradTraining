namespace Unit_Testing
{
    public class CGPACalculatorClass
    {
        public static string grade = "";

        enum gradeEnum
        {
            O, A, B, C, D
        }

        public static void Main()
        {
            int subjectsCount = 3;
            List<float> marks = new List<float>() { 90.0f, 80.0f, 60.0f };
            CalculateCGPA(subjectsCount, marks);
        }

        public static string CalculateCGPA(int subjectsCount, List<float> marks)
        {
            float total = marks.Sum();
            float avg = total / subjectsCount;
            Console.WriteLine("Average: " + avg);
            float cgpa = avg / 10.0f;
            AssignGrade(cgpa);
            return grade;
        }

        public static void AssignGrade(float cgpa)
        {
            Console.WriteLine("CGPA: " + cgpa);
            if (cgpa > 9f)
            {
                grade = gradeEnum.O.ToString();
            }
            else if (cgpa > 8f)
            {
                grade = gradeEnum.A.ToString();
            }
            else if (cgpa > 7f)
            {
                grade = gradeEnum.B.ToString();
            }
            else
            {
                grade = gradeEnum.C.ToString();
            }

            Console.WriteLine("Grade: " + grade);
        }
    }
}