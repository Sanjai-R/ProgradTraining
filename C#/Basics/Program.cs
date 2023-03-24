using Basics;

class Basic
{
    static void main(string[] args)
    {
        var p1 = new Basic();
        p1.CalculateSqr(5);
    }
    public void printSqr(int n)
    {
        Console.Write(CalculateSqr(n));
    }
    public int CalculateSqr(int num)
    {
        return num * num;
    }
}