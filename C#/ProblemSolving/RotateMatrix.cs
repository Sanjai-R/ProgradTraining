namespace ProblemSolving
{
    internal class RotateMatrix
    {
        static Action<dynamic> print = (s) => Console.WriteLine(s);

        
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4] {
                { 1, 2, 3 ,4},
                { 5, 6, 7, 8},
                { 9, 10, 11, 12},
                { 13, 14, 15, 16}
            };
            int[,] rotated = new int[4, 4];
            int N = 4;

            print("Original Matrix");
            printArr(N, a);

            for (int i = 0; i < N / 2; i++)
            {
                for (int j = i; j < N - i - 1; j++)
                {
                    int temp = a[i, j];
                    a[i, j] = a[N - 1 - j, i];
                    a[N - 1 - j, i] = a[N - 1 - i, N - 1 - j];
                    a[N - 1 - i, N - 1 - j] = a[j, N - 1 - i];
                    a[j, N - 1 - i] = temp;
                    
                }
                
            }

            print("Rotated Matrix");
            printArr(N, a);
            
        }

        public static void printArr(int N, int[, ] a)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}