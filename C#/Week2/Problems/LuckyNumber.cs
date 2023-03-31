namespace Problems
{
    public class LuckyNumberPredictor : NumberPredictor
    {
        public static void GetData()
        {
            print("Enter your DOB: ");
            int dob = Convert.ToInt32(Console.ReadLine());
            PredictLuckyNumber(dob);
        }
        public static void start()
        {
            GetData();
        }
        public override void IdentifyUnluckyNumber(int date)
        {

        }
    }
    public abstract class NumberPredictor
    {
        private List<int> fibonacciSeries = new();
        public static Action<dynamic> print = text => Console.WriteLine(text);
        public static int PredictLuckyNumber(int num)
        {
            int first = 0, second = 1;

            int third = first + second;
            while (third <= num)
            {

                first = second;
                second = third;
                third = first + second;
            }

            int ans = (Math.Abs(third - num) >=
                      Math.Abs(second - num)) ?
                               second : third;
            print(ans);
            return ans;
        }
        abstract public void IdentifyUnluckyNumber(int date);
    }

}