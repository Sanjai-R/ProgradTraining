namespace PhotoBookApplication
{
    internal class Program
    {
        public static Action<dynamic> print = txt => Console.WriteLine(txt);
        static void Main(string[] args)
        {
            while (true)
            {
                givePrompt();
                var opt = Console.ReadLine();
                switch (opt)
                {
                    case "a":
                        PhotoBook defaultPhotoBook = new PhotoBook();
                        print($"Number of pages in default photo book: {defaultPhotoBook.GetNumberOfPages()}");
                        break;
                    case "b":
                        print("Enter No.of Pages to add:");
                        int count = Convert.ToInt32(Console.ReadLine());
                        PhotoBook custom = new PhotoBook(count);
                        print($"Number of pages in Custom photo book: {custom.GetNumberOfPages()}");
                        break;
                    case "c":
                        AddPhotoBook large = new AddPhotoBook();
                        print($"Number of pages in large photo book: {large.GetNumberOfPages()}");
                        break;
                    case "d":
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
        public static void givePrompt()
        {
            print(@"Enter any option
                a) Default PhotoBook
                b) Custom PhotoBook
                c) Large PhotoBook
                d) Exit");
        }
    }
}