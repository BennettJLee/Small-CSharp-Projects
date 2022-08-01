using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class LottoLine
    {
        int[] numbersArray = new int[6];
        /// <summary>
        /// adds csv file to Array
        /// </summary>
        /// <param name="csvArray"></param>
        public LottoLine(string[] csvArray)
        {
            for (int i = 0; i < 6; i++)
            {
                numbersArray[i] = int.Parse(csvArray[i]);
            }
        }
        /// <summary>
        /// adds arrays to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string index = "";
            for(int i = 0; i < numbersArray.Length; i++)
            {
                index += numbersArray[i].ToString().PadRight(5);
            }
            return index;
        }
        /// <summary>
        /// Checks if any lotto numbers are correct
        /// </summary>
        /// <param name="winNumsArray"></param>
        /// <returns></returns>
        public virtual int CheckNumbers(int[] winNumsArray)
        {
            int count = 0;
            for(int i = 0; i < numbersArray.Length; i++)
            {
                for(int j = 0;j < winNumsArray.Length; j++)
                {
                    if(numbersArray[i] == winNumsArray[j])
                    {
                       count++;
                    }
                }
            }
            return count;
        }
    }
}
