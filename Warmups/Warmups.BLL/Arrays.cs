using System;
using System.Linq;


namespace Warmups.BLL
{
    public class Arrays
    {

        public bool FirstLast6(int[] numbers)
        {
            bool firstLastis6 = false;
            if (numbers[0]== 6 || numbers[numbers.Length-1] == 6)
            {
                firstLastis6 = true;
            }
            return firstLastis6;
        }

        public bool SameFirstLast(int[] numbers)
        {
            bool bothAreSame = false;
            if (numbers[0] == numbers[numbers.Length-1])
            {
                bothAreSame = true;
            }
            return bothAreSame;
        }

        public int[] MakePi(int n)
        {
            int[] myPi = new int[n];
            string pi = Math.PI.ToString().Replace(".", "");

            for (int i = 0; i < n; i++)
            {
                 myPi[i] = (int)Char.GetNumericValue(pi[i]); 
            }
            return myPi;
        }
        
        public bool CommonEnd(int[] a, int[] b)
        {
            bool hasCommonEnd = false;
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                hasCommonEnd = true;
            }
            return hasCommonEnd;
        }
        
        public int Sum(int[] numbers)
        {
            int yourSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                yourSum += numbers[i];
            }
            return yourSum;
        }
        
        public int[] RotateLeft(int[] numbers)
        {
            int[] leftArray = new int[numbers.Length];

            leftArray[numbers.Length - 1] = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                leftArray[i] = numbers[i + 1];
            }
            
            return leftArray;
        }
        
        public int[] Reverse(int[] numbers)
        {
            int[] reversed = new int[numbers.Length];
            int p = numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[i] = numbers[p - 1];
                p--;
            }
            return reversed;
        }
        
        public int[] HigherWins(int[] numbers)
        {
            int[] highArray = new int[numbers.Length];
            if (numbers[numbers.Length - 1] < numbers[0])
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    highArray[i] = numbers[0];
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    highArray[i] = numbers[numbers.Length - 1];
                }
            }

            return highArray;
        }
        
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] yourMiddle = new int[2];
            yourMiddle[0] = a[1];
            yourMiddle[1] = b[1];
            return yourMiddle;
        }
        
        public bool HasEven(int[] numbers)
        {
            bool containsEven = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    containsEven = true;
                }
            }        

            return containsEven;
        }
        
        public int[] KeepLast(int[] numbers)
        {
            int[] doubleArray = new int[numbers.Length * 2];
            doubleArray[doubleArray.Length - 1] = numbers[numbers.Length - 1];
            return doubleArray;
        }
        
        public bool Double23(int[] numbers)
        {
            bool hasDoubles = false;
            int numberOfThrees = 0;
            int numberOfTwos = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    numberOfTwos++;
                }
                if (numbers[i] == 3)
                {
                    numberOfThrees++;
                }
            }

            if (numberOfTwos == 2 || numberOfThrees == 2)
            {
                hasDoubles = true;
            }
            return hasDoubles;
        }
        
        public int[] Fix23(int[] numbers)
        {
            if (numbers[0] == 2 && numbers[1] == 3)
            {
                numbers[1] = 0;
            }
            if (numbers[1] == 2 && numbers[2] == 3)
            {
                numbers[2] = 0;
            }

            return numbers;
        }
        
        public bool Unlucky1(int[] numbers)
        {
            bool isUnlucky = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 3)
                {
                    isUnlucky = true;
                }
            }

            return isUnlucky;

        }
        
        public int[] Make2(int[] a, int[] b)
        {
            int[] myTwo = new int[2];

            if (a.Length == 0)
            {
                myTwo[0] = b[0];
                myTwo[1] = b[1];
            }
            if (a.Length == 1)
            {
                myTwo[0] = a[0];
                myTwo[1] = b[0];
            }
            if (a.Length == 2)
            {
                myTwo[0] = a[0];
                myTwo[1] = a[1];
            }
            return myTwo;
        }

    }
}
