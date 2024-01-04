using System;

namespace TEMA_STRINGS_TO_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberToString = Console.ReadLine();
            string result = string.Empty;

            if (numberToString.Length > 1)
            {
                if(numberToString.Length == 2)
                {
                    //Zeci
                    result = GenerateTenths(numberToString, result);
                }
                if(numberToString.Length == 3)
                {
                    //Sute
                    result = GenerateHundreds(numberToString, result);

                }
                if(numberToString.Length == 4)
                {
                    //Mii
                    result = GenerateThousands(numberToString, result);
                }
            }
            else
            {
                result = GetSingleDigit(Convert.ToString(numberToString[0]));
            }


            Console.WriteLine(result);
        }

        private static string GenerateThousands(string numberToString, string result)
        {
            result += GetSingleDigit(Convert.ToString(numberToString[0]));
            result += " thousand";
            string lastThreeDigits = numberToString.Substring(1, 3);
            string lastTwoDigitsFromThousand = numberToString.Substring(2, 2);
            if (numberToString[1] != '0' && numberToString[2] == '0' && numberToString[3] == '0')
            {
                result = ( GenerateHundreds(lastThreeDigits, result));
            }
            if (numberToString[1] != '0' && numberToString[2] != '0' && numberToString[3] == '0')
            {
                result = ( GenerateHundreds(lastThreeDigits, result));
            }
            if (numberToString[1] != '0' && numberToString[2] != '0' && numberToString[3] != '0')
            {
                result = ( GenerateHundreds(lastThreeDigits, result));
            }
            if(numberToString[1] == '0' && numberToString[2] == '0' && numberToString[3] != '0')
            {
                result += (" " + GetSingleDigit(numberToString[3].ToString()));
            }
            if(numberToString[1] == '0' && numberToString[2] != '0' && numberToString[3] != '0')
            {
                result += (" " + GenerateTenths(lastTwoDigitsFromThousand, result));
            }
            if (numberToString[1] == '0' && numberToString[2] != '0' && numberToString[3] == '0')
            {
                result += (" " + GetTens(lastTwoDigitsFromThousand));
            }

            return result;
        }

        private static string GenerateHundreds(string numberToString, string result)
        {
            result += " " +  GetSingleDigit(Convert.ToString(numberToString[0]));
            result += " hundred";
            string lastTwoDigits = numberToString.Substring(1, 2);
            if (numberToString[1] != '0' && numberToString[2] != '0')
            {
                result += (" " + GenerateTenths(lastTwoDigits, result));
            }
            if (numberToString[1] != '0' && numberToString[2] == '0')
            {
                result += (" " + GetTens(lastTwoDigits));
            }
            if (numberToString[1] == '0' && numberToString[2] != '0')
            {
                result += (" " + GetSingleDigit(numberToString[2].ToString()));
            }

            return result;
        }

        private static string GenerateTenths(string numberToString, string result)
        {
            if ((Convert.ToInt32(numberToString) >= 10 && Convert.ToInt32(numberToString) < 20))
            {
                result = GetDigitsFrom10To19(numberToString);
            }
            if (Convert.ToInt32(numberToString) > 19 && Convert.ToInt32(numberToString) < 100)
            {
                string firstDigit = Convert.ToString(numberToString[0]);
                string decimalResult = Convert.ToString(firstDigit += "0");
                result = GetTens(Convert.ToString(decimalResult));
                char secondDigit = numberToString[1];
                if (secondDigit != '0')
                {
                    result += (" " + GetSingleDigit(Convert.ToString(numberToString[1])));
                }
            }

            return result;
        }

        public static string GetTens(string a)
        {
            switch (a)
            {
                case "20":
                    return "twenty";
                case "30":
                    return "thirty";
                case "40":
                    return"forty";
                case "50":
                    return "fifty";
                case "60":
                    return "sixty";
                case "70":
                    return "seventy";
                case "80":
                    return "eighty";
                case "90":
                    return "ninety";
                default:
                    return "zero";
            }
        }
        public static string GetSingleDigit(string a)
        {
            switch (a)
            {
                case "1":
                    return "one";
                case "2":
                    return "two";
                case "3":
                    return "three";
                case "4":
                    return "four";
                case "5":
                    return "five";
                case "6":
                    return "six";
                case "7":
                    return"seven";
                case "8":
                    return "eight";
                case "9":
                    return "nine";
                default:
                    return "zero";
            }
        }
        public static string GetDigitsFrom10To19(string a)
        {
            switch (a)
            {
                case "10":
                    return "ten";
                case "11":
                    return "eleven";
                case "12":
                    return "twelve";
                case "13":
                    return "thirteen";
                    case"14":
                    return "fourteen";
                case "15":
                    return "fiftteen";
                case "16":
                    return "sixteen";
                case "17":
                    return "seventeen";
                case "18":
                    return "eighteen";
                case "19":
                    return "nineteen";
                default:
                    return "zero";

            }
        }
    }
}
