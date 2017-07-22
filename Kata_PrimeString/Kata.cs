namespace Kata_PrimeString
{
    public class Kata
    {
        public bool PrimeString(string s)
        {
            if (s.Length == 1)
            {
                return true;
            }

            var primeString = s.Substring(0, 1);
            if (s.Replace(primeString, "") == "")
            {
                return true;
            }

            return false;
        }
    }
}