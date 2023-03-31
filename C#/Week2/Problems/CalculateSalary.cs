namespace Problems
{
    public class CalculateSalary
    {
        public static Action<dynamic> print = text => Console.WriteLine(text);
        public static void start()
        {
            double[] workDay = { 16, 18, 0, 1.8 };
            print(OverTime(workDay));
        }
        public static string OverTime(double[] arr)
        {
            
            double start = arr[0];
            double end = arr[1];
            double hourlyRate = arr[2];
            double overtimeMultiplier = arr[3];
            double regularHours = 0;
            double overtimeHours = 0;
            
            switch (true)
            {
              
                case bool x when (start >= 9 && end <= 17):
                    regularHours = end - start;
                    overtimeHours = 0;
                    break;
                case bool x when (start < 9 && end > 17):
                    regularHours = 17 - start;
                    overtimeHours = end - 17;
                    break;
                case bool x when (start < 9 && end <= 17):
                    regularHours = end - 9;
                    overtimeHours = 0;
                    break;
                case bool x when (start >= 9 && end > 17):
                    regularHours = 17 - start;
                    overtimeHours = end - 17;
                    break;
                default:
                    return "$0.00";
            }

            double pay = CalculatePay(regularHours,hourlyRate,overtimeHours,overtimeMultiplier);
            return $"$ {pay}";
        }

        public static double CalculatePay(double regularHours, double hourlyRate, double overtimeHours, double overtimeMultiplier)
        {
            return regularHours * hourlyRate + overtimeHours * hourlyRate * overtimeMultiplier;

        }
    }
}