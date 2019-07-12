using System;

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            bool areInTrouble = false;

            if (aSmile == bSmile)
            {
                areInTrouble = true;
            }

            return areInTrouble;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            bool weCanSleepIn = false;

            if (isWeekday == false || isVacation == true)
            {
                weCanSleepIn = true;
            }

            return weCanSleepIn;
        }

        public int SumDouble(int a, int b)
        {
            int mySum = 0;

            if (a == b)
            {
                mySum = a * 4;
            }
            else
            {
                mySum = a + b;
            }
            return mySum;
        }

        public int Diff21(int n)
        {
            int myValue = 0;

            if (n > 21)
            {
                myValue = Math.Abs(21 - n) * 2;
            }
            else
            {
                myValue = Math.Abs(21 - n);
            }

            return myValue;
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            // We are in trouble if the parrot is talking and the hour is before 7 or after 20.
            bool weAreInTrouble = false;

            if (hour < 7 && isTalking == true || hour > 20 && isTalking == true)
            {
                weAreInTrouble = true;
            }

            return weAreInTrouble;
        }

        public bool Makes10(int a, int b)
        {
            bool doesMake10 = false;
            if (a == 10 || b == 10 || a + b == 10)
            {
                doesMake10 = true;
            }
            return doesMake10;
        }

        public bool NearHundred(int n)
        {
            bool isCloseTo100 = false;
            if (n > 89 && n < 111 || n > 189 && n < 211)
            {
                isCloseTo100 = true;
            }
            return isCloseTo100;
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            bool isNegative = false;
            if (a < 0 && b > 0 && negative == false ||
                a > 0 && b < 0 && negative == false ||
                a < 0 && b < 0 && negative == true)
            {
                isNegative = true;
            }
            return isNegative;
        }

        public string NotString(string s)
        {
            string myString = "";
            if (s.StartsWith("not "))
            {
                myString = s;
            }
            else
            {
                myString = "not " + s;
            }
            return myString;
        }

        public string MissingChar(string str, int n)
        {
            string myString = str.Remove(n, 1);
            return myString;
        }

        public string FrontBack(string str)
        {
            string myString = "";
            // string is one long
            if (str.Length == 1)
            {
                myString = str;
            }
            // string is two long
            if (str.Length == 2)
            {
                myString = str[1].ToString() + str[0].ToString();
            }
            // if string is three or longer
            if (str.Length >= 3)
            {
                myString = str[str.Length - 1].ToString() +
                      str.Substring(1, str.Length - 2) +
                      str[0].ToString();
            }
            return myString;
        }

        public string Front3(string str)
        {
            string myString = "";

            if (str.Length <= 3)
            {
                myString = str + str + str;
            }
            if (str.Length >= 4)
            {
                myString = str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
            }

            return myString;
        }

        public string BackAround(string str)
        {
            string myString = "";

            if (str.Length < 1)
            {
                myString = str;
            }
            else
            {
                myString = str[str.Length - 1].ToString() + str + str[str.Length - 1].ToString();
            }

            return myString;
        }

        public bool Multiple3or5(int number)
        {
            throw new NotImplementedException();
        }

        public bool StartHi(string str)
        {
            throw new NotImplementedException();
        }

        public bool IcyHot(int temp1, int temp2)
        {
            throw new NotImplementedException();
        }

        public bool Between10and20(int a, int b)
        {
            throw new NotImplementedException();
        }

        public bool HasTeen(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public bool SoAlone(int a, int b)
        {
            throw new NotImplementedException();
        }

        public string RemoveDel(string str)
        {
            throw new NotImplementedException();
        }

        public bool IxStart(string str)
        {
            throw new NotImplementedException();
        }

        public string StartOz(string str)
        {
            throw new NotImplementedException();
        }

        public int Max(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public int Closer(int a, int b)
        {
            throw new NotImplementedException();
        }

        public bool GotE(string str)
        {
            throw new NotImplementedException();
        }

        public string EndUp(string str)
        {
            throw new NotImplementedException();
        }

        public string EveryNth(string str, int n)
        {
            throw new NotImplementedException();
        }
    }
}
