using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matrix Range is the Matrix to Build the Pyramid
            int iMatrixRange = 15;
            int[,] arr = new int[,] { { 215, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 192, 124, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 117, 269, 442, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 218, 836, 347, 235, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 320, 805, 522, 417, 345, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 229, 601, 728, 835, 133, 124, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 248, 202, 277, 433, 207, 263, 257, 0, 0, 0, 0, 0, 0, 0, 0 }, { 359, 464, 504, 528, 516, 716, 871, 182, 0, 0, 0, 0, 0, 0, 0 }, { 461, 441, 426, 656, 863, 560, 380, 171, 923, 0, 0, 0, 0, 0, 0 }, { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449, 0, 0, 0, 0, 0 }, { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444, 0, 0, 0, 0 }, { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197, 0, 0, 0 }, { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928, 0, 0 }, { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121, 0 }, { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 } };
         
            Console.WriteLine("INPUT Pyramid:"); 
            Console.WriteLine();

            //Print the Pyramid without Zeros  
            for (int i = 0; i < iMatrixRange; i++)
            {
                for (int j = 0; j < iMatrixRange; j++)
                {
                    if (arr[i, j] != 0)
                        Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine(); //new line at each row  
            }
            Console.WriteLine(" ");

            string strOddorEvenNext = string.Empty;
            int iCount = 0;
            int iIndex = 0;
            int iMaxValue = 0;
            int maxSum = 0;
            string strPath = string.Empty;

            strPath = strPath + arr[0, 0].ToString() + " > ";

            // Print Just the Path
            for (int i = 0; i < (iMatrixRange - 1); i++)
            {
                if (arr[iCount, iIndex] % 2 == 0)
                    strOddorEvenNext = "ODD";
                else
                    strOddorEvenNext = "EVEN";
                iMaxValue = ValidateEvenorOdd(arr[iCount + 1, iIndex], arr[iCount + 1, iIndex + 1], strOddorEvenNext);
                if (iMaxValue == 0)
                    break;
                strPath = strPath + iMaxValue.ToString() + " > ";

                if (iMaxValue != arr[iCount + 1, iIndex])
                {

                    iIndex++;
                }
                iCount++;
            }
            if (iMaxValue == 0)
                Console.WriteLine("Error in the Pyramid");
            strPath = strPath.Remove(strPath.Length - 2);
            Console.WriteLine("Maximum Path:" + strPath);
            Console.WriteLine(" "); //new line at each row   

            //Maximumsum of the values
            string[] values = strPath.Split('>');
            for (int i = 0; i < values.Length; i++)
            {
                maxSum += int.Parse(values[i]);
            }
            Console.Write("Sum of the path is : " + maxSum);

            Console.Read();
        }


        // Checks Even or Odd and returns the Maximum Value
        public static int ValidateEvenorOdd(int Value1, int Value2, string strHighEvenorOdd)
        {
            if (strHighEvenorOdd == "EVEN")
            {
                if (Value1 % 2 == 0 && Value2 % 2 == 0)
                    return Value1 >= Value2 ? Value1 : Value2;
                else if (Value1 % 2 == 0)
                    return Value1;
                else if (Value2 % 2 == 0)
                    return Value2;
                else
                    return 0;
            }
            else
            {
                if (Value1 % 2 != 0 && Value2 % 2 != 0)
                    return Value1 >= Value2 ? Value1 : Value2;
                else if (Value1 % 2 != 0)
                    return Value1;
                else if (Value2 % 2 != 0)
                    return Value2;
                else
                    return 0;
            }
        }
        }
    }

