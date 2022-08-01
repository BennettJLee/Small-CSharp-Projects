using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class PowerBallLine : LottoLine
    {
        public int PowerBallNumber = 0;
        int[] numbersArray = new int[7];
        public PowerBallLine(string[] csvArray) : base (csvArray)
        {
            for (int i = 0; i < 7; i++)
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
            for (int i = 0; i < numbersArray.Length; i++)
            {
                index += numbersArray[i].ToString().PadRight(5);
            }
            return index;
        }
    }
}
