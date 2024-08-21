using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSameNumbersButLess.ToLessNimbersConverter
{
    public class ToLessNumbersCoverter
    {
        public static int NumbersConverter(int number)
        {
            int[] num = number.ToString().Select(x => x - '0').ToArray();
            
            if (num.Length <= 1)
            {
                return -1;
            }

            int lastIndex = 1;
            int secondLastIndex = 2;

            for (int i = 0; i < num.Length; i++, lastIndex++, secondLastIndex++)
            {
                int lastDigit = num[num.Length - lastIndex];
                int secondLastDigit = num[num.Length - secondLastIndex];

                if (lastDigit < secondLastDigit)
                {
                    num[num.Length - lastIndex] = (char)secondLastDigit;
                    num[num.Length - secondLastIndex] = (char)lastDigit;

                    if (Convert.ToInt32(num[0]) == 0)
                    {
                        return -1;
                    }

                    return Convert.ToInt32(new string(num.ToList().Select(x => Convert.ToChar(x + '0')).ToArray()));
                }

                if (num.Length <= secondLastIndex)
                {
                    return -1;
                }

                secondLastDigit = Convert.ToInt32(num[num.Length - (secondLastIndex + 1)]);

                if (lastDigit < secondLastDigit)
                {
                    num[num.Length - lastIndex] = secondLastDigit;
                    num[num.Length - (secondLastIndex + 1)] = lastDigit;

                    if (Convert.ToInt32(num[0]) == 0)
                    {
                        return -1;
                    }

                    return Convert.ToInt32(new string(num.ToList().Select(x => Convert.ToChar(x + '0')).ToArray()));
                }
            }

            return -1;
        }
    }
}
