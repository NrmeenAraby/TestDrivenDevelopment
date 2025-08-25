namespace Calculator
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            if (Sum(2, 2) != 4)
            {
                throw new Exception();
            }
        }
        int Sum(int a, int b)
        {
            return a + b;
        }
    }
}