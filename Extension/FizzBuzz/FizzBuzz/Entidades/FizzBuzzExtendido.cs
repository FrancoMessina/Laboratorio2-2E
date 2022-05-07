using System;
using System.Text;
namespace Entidades
{
    public static class FizzBuzzExtendido
    {
        public static string FizzBuzz(this Int32 num)
        {
            StringBuilder sb = new StringBuilder();
            if(num % 3 == 0)
                sb.Append("Fizz");
            if (num % 5 == 0)
                sb.Append("Buzz");
            if (sb.Length == 0)
                sb.Append(num);
            return sb.ToString();
        }
    }
}
