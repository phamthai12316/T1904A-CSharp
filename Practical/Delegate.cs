namespace t1904a.Practical
{
    public delegate void DemoDelegate(string s);

    public class Delegate
    {
        
        public event DemoDelegate PrimeNumberFinder;
        public event DemoDelegate OnPrimeNumber;
        
        static void Main(string[] args)
        {
            Phone p = new Phone();
        }

    }
}