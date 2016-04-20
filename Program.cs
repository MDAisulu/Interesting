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
         //-------------------------------HomeWork 1-------------------------------------------->
          //(1) Exersize 1.a 
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
             
            
      //(2) print to the console numbers in the reverse order 
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
                    }

      //(3) Print the sum of numbers
                    int sum = 0;
                    for (int i = 0; i < 10; i++) {
                        sum += i;
                      }
                    Console.Write("The sum of numbers at 1 to 10: " + sum );



     //(5, 6) NOD-Greatest common diviser; NOK - Least common multiple
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
                    Console.WriteLine("NOD: " + nod + " ");

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
                        Console.Write("Ne prostoe");

    // Exercise (8) 
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
                          if (binNum == 1)
                         {
                             sum1 += binNum;

                         }
                     }
                     Console.WriteLine("\n The sum of units: " + sum1);
             

           // Exercise (9) 
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

                    // (10) Vse deliteli natural'nogo chisla
                    float num = 21;
                       for (int i = 1; i < num; i++) {
                        if (num % i == 0)
                    
                        Console.Write("Dividers" + i);
                    }
            

   //---------------------------------------HomeWork 2--------------------------------------------------------->>
                                       
            // Exercise (1)
                             int[] arr = new int[] {1,2,3,4,5}; 
                            for (int i = 0; i < arr.Length; i++) { 

                            Console.Write((arr[i] % 2 == 0) ? "-1 " : "1 "); 
                            }
             //Exercise (7) Max and min matrix in per loop
                             int[] arr = new int[] {1,2,13,0,5 }; 
                            int max = arr[0]; 
                            int min = arr[0]; 
                            for (int i = 0; i < arr.Length; i++) { 

                            if (arr[i] > max) 
                            { 
                            max = arr[i]; 
                            } 
                            if (arr[i] < min) { 
                            min = arr[i]; 
                            } 
                            }

                            Console.Write(max +" " + min); 

        //Exercise (8) if sum_matrix odd a[i,j] *2 or *3
                             int[] arr1 = new int[] {2,3,4,5,6,8}; 
                            int sum = 0; 
                            for (int i = 0; i < arr1.Length; i++) 
                            { 
                            sum += arr1[i]; 
                            } 
                            for (int i = 0; i < arr1.Length; i++) { 

                            Console.WriteLine((sum%2==0)?(arr1[i] *=3):(arr1[i] *=2 )); 
                            }
            //Exercise (12) Обойти матрицу по спирали
                            int[,] arr_11 = new int[,] { {1,2, 3},{4,5,6},{7,8,9 } }; 
                            int k = 1; 
                            int m = arr_11.GetLength(0); 
                            int n = arr_11.GetLength(1); 
                            int col1 = 0; 
                            int col2 = m-1; 
                            int row1 = 0; 
                            int row2 = n-1; 
                            while (k <= m*n) { 
                            for (int i = col1; i <= col2; i++) { 
                            arr_11[row1, i] = k++; 
                            } 
                            for (int j = row1+1; j <= row2; j++) 
                            { 
                            arr_11[j, col2] = k++; 
                            } 
                            for (int i = col2-1; i >= col1; i--) 
                            { 
                            arr_11[row2, i] = k++; 
                            } 
                            for (int j = row2-1; j >= row1+1; j--) 
                            { 
                            arr_11[j, col1] = k++; 
                            } 
                            col1++; 
                            col2--; 
                            row1++; 
                            row2--; 
                            } 
                            for (int i = 0; i < arr_11.GetLength(0); i++) { 
                            for (int j = 0; j < arr_11.GetLength(1); j++) { 
                            Console.Write(arr_11[i,j] + "\t"); 
                            } 
                            Console.WriteLine(); 
                            }


          // Exercise (11) Zigzag for columns and rows
            int[,] arr = new int[,]{{1,2,3},{4,5,6},{7,8,9}};


            for (int i = 0; i < arr.GetLength(0); j++)
            {
                for (int j = 0; j < arr.GetLength(1); i++)
                {
                    if(i%2==0){
                        for(j=arr.GetLength(1); j>=0; j++)
                           Console.Write(arr[i, j] + " ");
                    }else
                {
                Console.Write(arr[i,j] + " ");
                }
                }
                Console.WriteLine();
             }
           
        
           
            // Exercise (10) Обойти матрицу по столбцам
          int[,] arr = new int[,]{{1,2,3},{4,5,6},{7,8,9}};

          for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                
             }
            Console.WriteLine();
        }
                
            
                    Console.ReadKey();
        }

       
    }

