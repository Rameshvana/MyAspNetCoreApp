using System.ComponentModel;

namespace TestClass
{
    public class Class1
    {
        public string ReverseSumNumber(int num)
        {
            int Sum = 0;
            foreach (char ch in num.ToString())
            {
                Sum += int.Parse(ch.ToString());
            }
            Console.WriteLine(Sum);

            string ReverseSum = "";
            foreach (var item in Sum.ToString())
            {

                ReverseSum = item + ReverseSum;
            }
            return ReverseSum;
        }
    
        public String findEventOddNumber(int num)
        {
            string result;
            if (num % 2 == 0)
            {
                result = "Given number is Even Num";
            }
            else
            {
                result = "Given number is Odd Num";
            }
           return result;
        }

        public int FindHCF(int a, int b)
        {
           
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b; 
                }
                else
                {
                    b = b - a;
                }
            }
            return a; 
        }
        
        public string FindEvenOddNumArray(int[] arr)
        {
            int[] numbersArry = arr;

            string EvenNumbers = "", OddNumbers = "";

            foreach (int number in numbersArry)
            {
                if (number % 2 == 0)
                {
                    EvenNumbers += " " + number;
                }
                else
                {
                    OddNumbers += " " + number;
                }

            }


            return ($"Even numbers are:{EvenNumbers} \n Odd numbers are: {OddNumbers}");

            
        }

        public string FindFibanoiceSeris(int x)
        {
            

            int fibNum = x;

            int firstNum = 0;
            int secondNum = 1;

            string fibanoiceNum = "";

            for (int i = 0; i < fibNum; i++)

            {
                int result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;

                fibanoiceNum += " " + result.ToString();
            }

            return $"Fibanoice numbers are:{fibanoiceNum}" ;
        }
       
        public string FindLargeNumber(int[] arr)
        {
            
            int maxValue = arr[0];

            for (int i = 1; i < arr.Length; i++)

            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            return $"The maxValue is: {maxValue}.";
        }

        public string FindPrimeNumber(int x)
        {

            int numInput = x;

            int count = 0;
            string result = "";

            for (int i = 1; i <= numInput; i++)
            {

                if (numInput % i == 0)
                {
                    count++;
                }
            }


            if (count == 2)
            { 
                result = "Prime"; 
            }
            else {
                result = "not Prime"; 
            }


            return result;

        }
        
        public string ReverseNumber(string input)
        {
          

            string myString = input;

            string revsString = "";

            foreach (var item in myString)
            {

              revsString = item + revsString;

            }

            return $"Reversed number is {revsString}.";
        }

        public string ReverseNumberArray(int[] arr)
        {
            int[] myArry = { 9, 3, 1, 6, 8, 2, 7, 4, 5 };

            var reverseNumber = String.Join("", arr.Reverse());
            return $"the reversed array is: {reverseNumber}.";
        }

        public string SimpleCalculator(int x, int y,string operation)
        {

           

            int result = 0;
            switch (operation)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                case "%":
                    result = x % y;
                    break;
                default:
                    Console.WriteLine("not valid operation");
                    break;
            }

          return $"result is: {result}.";
        }

        public string SumOfNumbers(int a, int b)
        {
           
            int sumOfnumbers = a + b;
            int differenceOnumbers = a - b;

            return ($"Sum of two numbers is {sumOfnumbers} \nDifference of two numbers is {differenceOnumbers}.");
        }

        public string ReverseWord(string word)
        {
            string[] s = Array.ConvertAll(word.Split(' '), Convert.ToString);

            string result = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i] + " ";
            }

            return $"Reversed word is:  {result}";
        }

        public string LettersDigitsCount(string mystring)
        {
            int lettersCount = 0;
            int numberCount = 0;
            int specialCharCount = 0;


            foreach (var item in mystring)
            {
                if (char.IsLetter(item))
                {
                    lettersCount++;
                }
                else if (char.IsDigit(item))
                {
                    numberCount++;
                }
                else
                {
                    specialCharCount++;
                }

            }
            return ($"Letters Count is: {lettersCount} \nNumber Count is {numberCount} \nSpecial char count is {specialCharCount}");
        }

        public string WordCount(string word)
        {
            string[] s = Array.ConvertAll(word.Split(' '), Convert.ToString);

            string result = "";

            foreach (var item in s)
            {
                Console.WriteLine($"{item} - {item.Length}");
            }

            return $"Reversed word is:  {result}";
        }
    
       
        public string ReverseString(string mystring)
        {
            string ReverseString = "";

            for (int i = mystring.Length-1; i>= 0; i--)
            {
                ReverseString += mystring[i];
            }
            return ReverseString;
        }

        public string FindLengthArray(int[] arr)
        {
            int arryLength = 0;

            foreach (var item in arr)
            {
                arryLength++;
            }
            return $"the given Array length is: {arryLength}.";
        }

        public void ConvertToCharArray(string inputString)
        {
            char[] charArr = inputString.ToCharArray();

            foreach (var item in charArr)
            {
                Console.WriteLine(item);
            }
        }

        public void SortingArray(string[] cityNamesh)
        {
            Array.Sort(cityNamesh);

            Console.Write("Sorted array is: ");

            foreach (var item in cityNamesh)
            {
                Console.Write($"{item} ");
            }
        }

        public string ExtremArray(int[] arr)
        {
            Array.Sort(arr);
            int minValue = arr[0];
            int maxValue = arr[arr.Length - 1];

            int sum = minValue + maxValue;
            return $"Addition extreme Array sum is {sum}.";
        }

        public string SumOfEvenOddPostion(int[] arr)
        {
            int EvenSum = 0, OddSum = 0;

            for (var i=0;i < arr.Length; i++)
            {
                if( i % 2 == 0)
                {
                    EvenSum += arr[i];
                }
                else
                {
                    OddSum += arr[i];
                }
            }
            return $"Event postion sum is: {EvenSum} \nOdd postion sum is: {OddSum}";

            
        }

        public string SplitArray(int[] arr,int postion)
        {
            string firstPart = "", secondPart = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (postion > i)
                {
                    firstPart += arr[i] + " ";
                }
                else
                {
                    secondPart += arr[i] + " ";
                }
            }
            return $"First Part of Arrat is :{firstPart}\nSecond part of Array is: {secondPart}";
        }

        public string MergeArray()
        {
            string[] cityArr1 = { "Hyderabad", "Bangaluru", "Chennai", "Khammam" };

            string[] cityuArr2 = { "Vijayavada", "Tirupathi", "Warngal" };

            var finalArray = cityArr1.Concat(cityuArr2).ToArray();
         
           return "Concatenated Array is : " + string.Join(", ", finalArray);


        }

        public string SumOfArryPairs(int[] arr)
        {
            //int[] arr = [5, 12, 7, 3, 9];

            string pairsResult = "";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine($"{arr[i]} {arr[i + 1]}");
                int sumOfpair = arr[i] + arr[i + 1];
                pairsResult += sumOfpair.ToString() + " ";
            }
            return $"the Sum Array pairs result is: {pairsResult}";
        }

        public List<int> DiagonalMatricx(int[,] arr)
        {
          

            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
           };

            List<int> diagonal = new List<int>();


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(arr[i, i]);
                diagonal.Add(arr[i, i]);
            }

            return diagonal;

           //($"diogonal elements is: {String.Join(" ", diagonal)}");



        }
        public int[,] AddMatrix(int[,] arr1, int[,] arr2)
        {
            



        
            int rows = arr1.GetLength(0);
            int columns = arr1.GetLength(1);


            int[,] newMatrix = new int[rows, columns];


            string newMatrixstr = "";
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    //Console.WriteLine($"{arr1[i, j]},{arr2[i, j]} = {arr1[i, j] + arr2[i, j]}");
                    int value = arr1[i, j] + arr2[i, j];
                    newMatrix[i, j] = value;
                    newMatrixstr += value + " ";


                }
            }
                    ;
            

            return newMatrix;
        }

        public int FindMaxArray(int[] arr)
        {
            int[] numbersArry = [4, 60, 19, 22, 30, 9, 89, 52, 70, 15];

            int maxValueArray = arr.Max();

            return maxValueArray;

            
        }

        public int FindMaxMatrix(int[,] arr1)
        {
            
            int maxValuein_matrix = 0;

            int row = arr1.GetLength(0);
            int col = arr1.GetLength(1);

            //Console.WriteLine($"rows-{row} col-{col}");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (maxValuein_matrix < arr1[i, j])
                    {
                        maxValuein_matrix = arr1[i, j];
                    }
                }
            }

            return maxValuein_matrix;

        }

        public List<int> SecondDiagonalMatrix(int[,] arr)
        {


            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
           };
            int col = arr.GetLength(1);
            //Console.WriteLine(col);
            List<int> diagonal = new List<int>();


            for (int i = 0; i < arr.GetLength(0); i++)
            {
               
                int value = matrix[i, col - 1 - i]; 
                diagonal.Add(value); 
                
            }

            return diagonal;

            //($"diogonal elements is: {String.Join(" ", diagonal)}");



        }

        public bool AreMatricesEqual(int[,] matrix_a, int[,] matrix_b)
        {
            // Get dimensions of matrices
            int rows = matrix_a.GetLength(0);
            int cols = matrix_a.GetLength(1);

            // Check if dimensions are equal
            bool checkRows = matrix_a.GetLength(0) == matrix_b.GetLength(0);
            bool checkCols = matrix_a.GetLength(1) == matrix_b.GetLength(1);

            // If dimensions don't match, matrices can't be equal
            if (!checkRows || !checkCols)
            {
                return false;
            }

            // Check if each element in the matrices is equal
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix_a[i, j] != matrix_b[i, j])
                    {
                        return false;  
                    }
                }
            }

            // If no differences found, matrices are equal
            return true;
        }

        public bool IsIdentityMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows != cols)
            {
                return false;
            }else
            {
                return true;
            }





                
        }

        public bool IsLeftTriangularMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

          
            if (rows != cols)
            {
                return false;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = i + 1; j < cols; j++)  
                {
                    if (matrix[i, j] != 0)
                    {
                        return false; 
                    }
                }
            }
            
            return true;
        }

        

    }





}
