namespace PhotoBookApplication
{
    public class PhotoBook
    {
        public int NumberOfPages { get; set; }
        public PhotoBook(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }
        public PhotoBook()
        {
            NumberOfPages = 16;
        }

        public virtual int GetNumberOfPages()
        {
            return NumberOfPages;
        }

    }
    public class AddPhotoBook : PhotoBook
    {
        public AddPhotoBook() : base(64)
        {
        }
        public override int GetNumberOfPages()
        {
            return base.GetNumberOfPages();
        }
    }
}