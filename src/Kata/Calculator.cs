namespace Kata
{
    public class Calculator
    {
        public int Add(string x = "")
        {
            if (string.IsNullOrEmpty(x))
            {
                return 0;                
            }

            return int.Parse(x);
        }
        
    }
}