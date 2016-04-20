using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {


        static void Main(string[] args)
        {
            #region
            /* //(1) Exersize 1.a 
            int i =  0;
             while (i < 10) {
                 if (i % 2 == 0)
                     Console.Write(1 + " ");
                 else
                     Console.Write(-1 + " ");
                 ++i;
             }
             Console.WriteLine();

             //(1) Exersize 1.b
             for (int i = 0; i < 10; i++) {
                 if (i % 2 == 0)
                     Console.Write(-1 + " ");
                 else
                     Console.Write(1 + " ");
             }

            // (1) Exersize 1.c
            for (int i = 0; i < 10; i++) {
                 Console.Write((i % 2 == 0) ? (1 + " ") : -1 + " ");
             }
             
             int k = 0;
             while(k<10){
                Console.Write(1-2 * (k % 2) == " ");
                ++k;
              }
             
             
             
             */

            /* //(2) print to the console numbers in the reverse order 
            for (int i = 10; i >= 0; i--) {
                 Console.Write(i + " ");
             }
             //(2.1) print to the console numbers in the reverse order
             int num = 12345;
            int tmp = num;
            while (tmp > 0)
            {
                Console.Write(tmp % 10 + " ");
                tmp /= 10;
            }*/

            /* //(3) Print the sum of numbers
            int sum = 0;
            for (int i = 0; i < 10; i++) {
                sum += i;
              }
            Console.Write("The sum of numbers at 1 to 10: " + sum );*/



           /* //(5, 6) NOD-Greatest common diviser; NOK - Least common multiple
            int a = 195;
            int b = 52;
            int nok = 0;
            int nod = 0;
            for (int i = 1; i <= a * b; i++) {
                if ( a%i == 0 && b % i == 0) {
                    nok = i;
                }
                
            }
            nod = a * b / nok;
            Console.Write("NOK: "+nok + " ");
            Console.WriteLine("NOD: " + nod + " ");*/

            /*
            //(7) Check the number is a simple or not
            bool prostoe = true;
            int num = 20;
            
            for (int i = 2; i <= num; i++) {
                
                if (num % i == 0)
                    prostoe = false;
                break;
                            
            }
            if (prostoe == true)
            {
                Console.Write("Prostoe");
            }
            else
                Console.Write("Ne prostoe");*/

            /* // (8) 
            int n = 15;
             int binNum = 0;
             int digits  = 0;
             int tmp = n;
             int sum1 = 0;

             while (tmp > 0) {
                 binNum = tmp % 2;
                 tmp /= 2;
                 digits++;
                 Console.Write(binNum);
                 //Console.WriteLine();
                 if (binNum == 1)
                 {
                     sum1 += binNum;

                 }
             }
             Console.WriteLine("\n The sum of units: " + sum1);
             */

            /* // (9) 
            float num = 2.5f;
            int grade = 3;
            float res = 1;
            for (int i = 0; i < grade; i++) {
                
                if (grade == 0)
                    res = 1;
                else
                    res *= num;
                                
            }
            Console.Write("The number with grade: " + res );*/

            /* // (10) Vse deliteli natural'nogo chisla
            float num = 21;
               for (int i = 1; i < num; i++) {
                if (num % i == 0)
                    
                Console.Write("Dividers" + i);
            }*/
            #endregion

            //------------------------------------------------------------------------------------------------>>

          /*  //lecture2
           //int num = 12345;
            int[,] matrix = new int [2,3];

            for (int j = 0; j < matrix.GetLength(1); j++)
                    for (int i = 0; i < matrix.GetLength(0); i++)
                            matrix[i, j] = j * matrix.GetLength(0) + i;
                
            
            foreach (int x in matrix)
            
            
            {
                Console.Write(x + "");
            }*/

            /*int[,] arr = new int[,]{{1,2},{3,4},{5,6}};
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i % 2 == 1)
                    {
                        for (j = arr.GetLength(1) - 1; j >= 0; j--)
                        Console.Write(arr[i,j] + " ");
                        break;
                    }
                    else {
                        
                            Console.Write(arr[i,j] + " ");

                    }      
                    }
                Console.WriteLine();
            }*/
            int[,] arr = new int[,]{{1,2,3},{4,5,6},{7,8,9}};


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write(arr[i, j] + " ");
                    
                    }
                break;

               // Console.WriteLine();
                }

                Console.WriteLine();
            }
                
            

                #region
                /* int len = 0;
            int tmp = num;
            while (tmp > 0) {
                len++;
                tmp /= 10;
            }
            
            int[] digits = new int[5];
            tmp = num;
            for (int i = len-1; i >= 0; i--) {
                digits[i] = tmp % 10;
                tmp /= 10;

            }
            foreach (int i in digits) 
                Console.Write(i + " " );
            Console.WriteLine("");
            for (int i = len - 1; i >= 0; i--) 
                Console.Write(digits[i]+" ");
            Console.WriteLine("");
           string digits = num.ToString();
           for (int i = 0; i < digits.Length; i++) {
               Console.Write(digits[i] + " ");
           }
           Console.WriteLine();
           for (int i = digits.Length-1; i >=0; i--)
           {
               Console.Write(digits[i] + " ");
           }
           Console.WriteLine();*/
                #endregion

            

                    Console.ReadKey();
        }

       
    }
}
