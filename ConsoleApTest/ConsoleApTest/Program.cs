using TestClass;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Net.Security;
using System.Text.RegularExpressions;

namespace ConsoleApTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var pr = new Program();

            var classAp = new Class1();

            //pr.ReverseSumNumber();
            //pr.findEventOddNumber();
            //pr.FindHCF();
            //pr.FindEvenOddNumArray();
            //pr.FindFibanoiceSeris();
            //pr.FindLargeNumber();
            //pr.FindPrimeNumber();
            //pr.ReverseNumber();
            //pr.ReverseNumberArray();
            //pr.SimpleCalculator
            //pr.SumOfNumbers();
            //pr.ReverseWord();
            //pr.LettersDigitsCount();
            //pr.WordCount();
            //pr.ReverseString();
            //pr.FindLengthArray();
            //pr.ConvertToCharArray();
            //pr.SortingArray();
            //pr.ExtremArray();
            //pr.SumOfEvenOddPostion();
            //pr.SplitArray();
            //pr.MergeArray();
            //pr.SumOfArryPairs();
            //pr.FrequencyCharArray();
            //pr.SimpleAtm();
            //pr.DiagonalMatricx();
            //pr.AddMatrix();
            //pr.FindMaxArray();
            //pr.DiagonalMatrixUser();
            //pr.FindMaxMatrix();
            //pr.SecondDiagonalMatrix();
            //pr.SumDiagonalMatrix();
            //r.CountDublicateArray();
            //.AreMatricesEqual();
            //pr.LeftTrianglePattern();
            //pr.IsIdentityMatrix();
            //pr.IsLeftTriangularMatrix();
            //pr.ReverseLeftTrianglePatern();
            //pr.UniqueElementsArry();
            //pr.FindLengthString();
            //pr.CompareStrings();
            //pr.CopyString();
            //pr.VowelsCount();
            //pr.FindSubString();
            //pr.FirstCharUpperString();
            //pr.ReversetheWords();
            //pr.SolidRightAngle();
            //pr.EquilateralTriangle();
            // pr.ReverseRightAngleTriangle();
            pr.HollowRightAngleTriangle();

        }

        private void ReverseSumNumber()
        {
            var classAp = new Class1();


            Console.Write("Enter a number: ");
            int Input = int.Parse(Console.ReadLine());
            Console.WriteLine($"the sum of Reversed number is {classAp.ReverseSumNumber(Input)}");

        }

        private void findEventOddNumber()
        {
            var classAp = new Class1();

            Console.Write("Eneter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(classAp.findEventOddNumber(num));
        }

        private void FindHCF()
        {
            Console.Write("Enter the first number:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number:");
            int b = int.Parse(Console.ReadLine());

            var clasAp = new Class1();

            Console.WriteLine("The hcf of {0} and {1} is: {2}", a, b, clasAp.FindHCF(a, b));
        }

        private void FindEvenOddNumArray()
        {
            int[] numbersArry = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var classAp = new Class1();
            Console.WriteLine(classAp.FindEvenOddNumArray(numbersArry));
        }

        private void FindFibanoiceSeris()
        {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            var claApp = new Class1();
            Console.WriteLine(claApp.FindFibanoiceSeris(x));
        }

        private void FindLargeNumber()
        {
            Console.Write("Enter three numbers with space separtor here: ");
            string numbers = Console.ReadLine();

            var myString = numbers.Split(" ");

            int[] numArry = Array.ConvertAll(myString, int.Parse);

            var clasApp = new Class1();
            Console.WriteLine(clasApp.FindLargeNumber(numArry));
        }

        private void FindPrimeNumber()
        {
            Console.Write("Enter a number: ");
            int numInput = int.Parse(Console.ReadLine());

            var clasAp = new Class1();
            Console.WriteLine(clasAp.FindPrimeNumber(numInput));
        }

        private void ReverseNumber()
        {
            Console.Write("Enter a number here: ");
            string myString = Console.ReadLine();

            var clasAp = new Class1();
            Console.WriteLine(clasAp.ReverseNumber(myString));
        }

        private void ReverseNumberArray()
        {
            var clasApp = new Class1();

            int[] myArry = { 9, 3, 1, 6, 8, 2, 7, 4, 5 };

            Console.WriteLine(clasApp.ReverseNumberArray(myArry));
        }

        private void SimpleCalculator()
        {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Choose operation here (+ - * % /): ");
            string operation = Console.ReadLine();

            var clasAp = new Class1();
            Console.WriteLine(clasAp.SimpleCalculator(x, y, operation));
        }

        private void SumOfNumbers()
        {
            Console.Write("Enter a first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number: ");
            int b = int.Parse(Console.ReadLine());

            var clasAp = new Class1();
            Console.WriteLine(clasAp.SumOfNumbers(a, b));

        }

        private void ReverseWord()
        {
            Console.Write("Enter a string here: ");
            string mystring = Console.ReadLine();    //"Hi my name Ramesh";
            var clsap = new Class1();

            Console.WriteLine(clsap.ReverseWord(mystring));
        }

        private void LettersDigitsCount()
        {
            Console.Write("Enter a string here: ");

            string str = Console.ReadLine();

            string mystring = "Hello World! 123";
            //"Hi my name Ramesh";

            var clasApp = new Class1();
            Console.WriteLine(clasApp.LettersDigitsCount(mystring));
        }

        private void WordCount()
        {
            Console.Write("Enter a word here: ");
            string myString = Console.ReadLine();

            var clasApp = new Class1();
            clasApp.WordCount(myString);
        }

        private void ReverseString()
        {
            Console.Write("Enter a String: ");
            string InputString = Console.ReadLine();

            var classApp = new Class1();

            Console.WriteLine(classApp.ReverseString(InputString));
        }

        private void FindLengthArray()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12 };
            string[] arr2 = { "Tayota", "Scoda", "Tata", "Bmw", "Hunday", "Mahindra" };

            var claApp = new Class1();
            Console.WriteLine(claApp.FindLengthArray(arr1));

        }

        private void ConvertToCharArray()
        {
            Console.Write("Enter a string here: ");
            string inputString = Console.ReadLine();

            var classAp = new Class1();
            classAp.ConvertToCharArray(inputString);

        }

        private void SortingArray()
        {
            string[] cityNamesh = { "Hyderabad", "Khammam", "Bangaluru", "Wrngal", "Tirupathi", "TamilNadu" };

            var clasAp = new Class1();
            clasAp.SortingArray(cityNamesh);
        }

        private void ExtremArray()
        {
            int[] numArray = [2, 5, 1, 8, 3];
            var clasAp = new Class1();

            Console.WriteLine(clasAp.ExtremArray(numArray));
        }

        private void SumOfEvenOddPostion()
        {
            int[] numbers = { 32, 4, 8, 10, 21, 30, 4, 2, 9 };

            var classApp = new Class1();
            Console.WriteLine(classApp.SumOfEvenOddPostion(numbers));


        }

        private void SplitArray()
        {
            int[] a = { 10, 20, 30, 40, 50, 60, 70, 80 };

            Console.Write("Chhose part to split the array: ");
            int postion = int.Parse(Console.ReadLine());

            var clssApp = new Class1();
            Console.WriteLine(clssApp.SplitArray(a, postion));
            // 2

        }

        private void MergeArray()
        {
            var classApp = new Class1();
            Console.WriteLine(classApp.MergeArray());
        }

        private void SumOfArryPairs()
        {
            int[] arr = [5, 12, 7, 3, 9];

            var classApp = new Class1();
            Console.WriteLine(classApp.SumOfArryPairs(arr));
        }

        private void FrequencyCharArray()
        {
            int[] arr1 = { 1, 2, 4, 2, 3, 1 };
            int[] setArray = new int[arr1.Length];


        }

        private void SimpleAtm()
        {



            int attemps = 1;

            int Bankbalance = 5500;
            while (attemps <= 3)
            {
                Console.Write("Wellcome to IcciC bank Atm\nEenter Atm card pin: ");
                int atmPin = int.Parse(Console.ReadLine());


                if (atmPin == 5505)
                {
                    attemps = 4;
                    //Console.WriteLine("Atp pin correct");
                    Console.Write("chose the options \nDeposit(d) and Withdraw(w) and bank Balance(b): ");
                    string paymentMode = Console.ReadLine();


                    if (paymentMode == "b")
                    {
                        Console.WriteLine($"Your bank balance is {Bankbalance}");
                    }
                    else if (paymentMode == "d")
                    {
                        Console.Write("Enter deposite ammount here: ");
                        int depositeAmount = int.Parse(Console.ReadLine());
                        Bankbalance += depositeAmount;
                        Console.WriteLine($"You are current bank balance is {Bankbalance} Thank you.");
                    }
                    else if (paymentMode == "w")
                    {
                        Console.Write("Enter withdraw amount here: ");
                        int withdraAmount = int.Parse(Console.ReadLine());

                        Bankbalance -= withdraAmount;
                        Console.WriteLine($"Successfully Withdraw amount \nYou are current bank balance is {Bankbalance} Thank you.");

                    }
                    else if (paymentMode == "pc")
                    {
                        Console.Write("Enter a new Pin: ");
                        int newAtmpin = int.Parse(Console.ReadLine());
                        atmPin = newAtmpin;
                        Console.WriteLine($"Succesfully change the your atm pin {atmPin}");
                        attemps = 3;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Try again..");
                    attemps++;

                }
            }
        }

        private void DiagonalMatricx()
        {
            var clsApp = new Class1();
            int[,] arr1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 3, 4, 5 } };

            Console.WriteLine($"diogonal elements is: {String.Join(" ", clsApp.DiagonalMatricx(arr1))}");


        }

        private void AddMatrix()
        {

            int[,] arr1 =
            {
                {1,2,3,4 },
                {3,4 ,5, 4},

            };
            int[,] arr2 =
   {
                {1,2,3,4 },
                {3,4,5,4 },

            };

            var classApp = new Class1();
            Console.WriteLine(classApp.AddMatrix(arr1, arr2));
        }

        private void FindMaxArray()
        {
            int[] numbersArry = [4, 60, 19, 22, 30, 9, 89, 52, 70, 15];

            var classAp = new Class1();
            Console.WriteLine(classAp.FindMaxArray(numbersArry));

        }

        private void DiagonalMatrixUser()
        {
            Console.Write("Enter row size of matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter colums size of matrix: ");
            int col = int.Parse(Console.ReadLine());

            int[,] Inputmatrix = new int[rows, col];


            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter {col} elements of {i + 1} row with space : ");
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < col; j++)
                {
                    Inputmatrix[i, j] = int.Parse(input[j]);
                }
            }

            var clsApp = new Class1();
            int[,] arr1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 3, 4, 5 } };

            //clsApp.DiagonalMatricx(arr1);
            Console.WriteLine($"diogonal elements is: {String.Join(" ", clsApp.DiagonalMatricx(Inputmatrix))}");





        }

        private void FindMaxMatrix()
        {
            int[,] arr1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 3, 40, 5 } };

            var clApp = new Class1();
            Console.WriteLine($"the maxValue in matrix is {clApp.FindMaxMatrix(arr1)}");
        }

        private void SecondDiagonalMatrix()
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
            var clsApp = new Class1();
            clsApp.SecondDiagonalMatrix(matrix);
            Console.WriteLine($"Second diogonal elements is: {String.Join(" ", clsApp.SecondDiagonalMatrix(matrix))}");

        }

        private void SumDiagonalMatrix()
        {
            var clsApp = new Class1();
            int[,] arr1 = { { 10, 2, 3 }, { 3, 40, 5 }, { 3, 4, 50 } };

            Console.WriteLine($"Sum of diogonal elements is: {clsApp.DiagonalMatricx(arr1).Sum()}");
        }

        private void CountDublicateArray()
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 1, 5 };

            int[] emtyArray = new int[5];
            List<int> num = new List<int>();

            int dublicate_values_count = 0;

            foreach (var item in arr)
            {
                if (!num.Contains(item))
                {
                    num.Add(item);
                }
            }

            foreach (var i in num)
            {
                int count = 0;
                foreach (var item in arr)
                {
                    if (i == item)
                    {
                        count++;
                    }
                }

                if (count >= 2)
                {
                    //Console.WriteLine($"the value {i} repeted {count} times");
                    dublicate_values_count++;
                }
            }
            Console.WriteLine(dublicate_values_count);
        }

        private void AreMatricesEqual()
        {
            int[,] matrix_a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrix_b = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            var clApp = new Class1();
            bool isEqual = clApp.AreMatricesEqual(matrix_a, matrix_b);
            Console.WriteLine(isEqual);
        }

        private void LeftTrianglePattern()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private void IsIdentityMatrix()
        {
            int[,] matrix = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            var clApp = new Class1();

            Console.WriteLine($"the given matrix identity is {clApp.IsIdentityMatrix(matrix)}.");
        }

        private void IsLeftTriangularMatrix()
        {
            int[,] matrix = { { 1, 0, 0 },
                          { 2, 3, 0 },
                          { 4, 5, 6 } };

            var clApp = new Class1();

            Console.WriteLine($"is left leftTriangle : {clApp.IsLeftTriangularMatrix(matrix)}");  // Output: True
        }

        private void ReverseLeftTrianglePatern()
        {
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        private void UniqueElementsArry()
        {
            int[] numArry = [1, 4, 2, 5, 3, 1, 4];
            Console.WriteLine(numArry.GetType());
            HashSet<int> uniqueEle = new HashSet<int>(numArry);
            Console.Write(String.Join(" ", uniqueEle));
        }

        private void FindLengthString()
        {
            Console.Write("Enter a word String: ");
            string myString = Console.ReadLine();
            string name = "Hello World";
            int char_count = 0;
            foreach (var item in myString)
            {
                char_count++;
            }
            Console.WriteLine(char_count);

        }

        private void CompareStrings()
        {
            var cl = new CompareStrings_class();
            Console.Write("Enter string one: ");
            string string1 = Console.ReadLine();

            Console.Write("Enter string two: ");
            string string2 = Console.ReadLine();

            Console.WriteLine($"Given two Strings are Equal : {cl.ComapteStrings(string1, string2)}");

        }

        private void CopyString()
        {
            var cl = new CopyString_class();
            string mystr = "Hello World";
            string result = cl.CopyString(mystr);

            Console.WriteLine($"Copy string is: {result}");
        }

        private void VowelsCount()
        {
            var cl = new VowelsCount_class();

            string str = "Hello";
            Console.WriteLine($"Vowel and Consonates count is {cl.VowelsCount(str)}.");
        }

        private void FindSubString()
        {
            string mainString = "Im a Fullstack developer";
            int start = 2;
            int end = 5;
            var cl = new SubString_class();

            cl.FindSubString(mainString, start, end);
        }

        private void FirstCharUpperString()
        {
            var cl = new FirstCharUpperString_class();
            string mainString = "hello world";
            Console.WriteLine(cl.FirstCharUpperString(mainString));
        }

        private void ReversetheWords()
        {
            var cl = new ReversetheWords_class();

            string myString = "My name is Ramesh";

            Console.WriteLine($"Reversed words is:  {cl.Reversethewords(myString)}");
        }

        private void SolidRightAngle()
        {
            Console.Write("Enter the height of the triangle: ");

            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private void EquilateralTriangle()
        {
            int height = 5;

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private void ReverseRightAngleTriangle()
        {
            int height = 5;

            for (int row = 1; row <= height; row++)
            {
                for (int space = 1; space <= height - row; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 1; star <= row; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        private void HollowRightAngleTriangle()
        {
            int height = 5;

            for (int row = 1; row <= height; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col == 1 || col == row || row == height)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private void IsValidEmail()
        {
            Console.Write("Enter an email address: ");
            string email = Console.ReadLine();

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            bool value = regex.IsMatch(email);



            if (value)
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }


        }

    }
}
