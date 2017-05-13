using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Patpedhi.Utilities
{
    public class ValidationLogic
    {
        //Check numbers upto two decimal places
        public static bool IsPrice(char c, string str)
        {

            Regex rx = new Regex(@"^((\d*)|[.]|[\b])$");
            if (rx.IsMatch(c.ToString()) == false)
                return false;
            else
            {
                if (Convert.ToInt16(c) == 8)
                    return true;
                else if (c == '.' && (str.IndexOf(".") > -1))
                    return false;
                else if ((str.IndexOf(".") != -1) && ((str.Length - (str.IndexOf(".") + 1)) >= 2))
                    return false;
                else
                    return true;
            }
        }
        public static bool IsInteger(char c)
        {
            Regex rx = new Regex(@"^((\d*))$");
            if (rx.IsMatch(c.ToString()) == false)
                return false;
            else
                return true;
        }
        public static bool IsNumericWithDecimal(string Value)
        {
            bool RetVal = true;
            if (Value.Trim() == "") return false; //if blank string passed.
            char[] Sep = ".".ToCharArray();
            string[] sarr = Value.Split(Sep, Value.Length);
            if (sarr.Length == 0) return (IsNumeric(Value));
            if (sarr.Length > 2)
            {
                return false;  //check only one decimal point
            }
            else
            {
                switch (sarr.Length)
                {
                    case 1: if (IsNumeric(sarr[0].Trim())) RetVal = true; else RetVal = false; break; //check for no: without decimal places
                    case 2: if (sarr[1].Length <= 2)
                            if (IsNumeric(sarr[1].Trim())) RetVal = true; else RetVal = false;//check for 2 digits after decimal points
                        else
                            RetVal = false;
                        break;
                }
            }
            return RetVal;
        }
        public static bool IsNumeric(string Name)
        {
            char namech;
            int nameascii;
            bool RetVal = true;
            if (Name.Trim() == "") return false;
            char[] NameCharArray = Name.ToCharArray();
            for (int i = 0; i < NameCharArray.Length; i++)
            {
                namech = NameCharArray[i];
                nameascii = Convert.ToInt16(namech);

                //check For Numerics
                if (((nameascii > 47 && nameascii < 58) || (nameascii == 8)) == false)
                {
                    RetVal = false;
                    break;
                }
            }
            return RetVal;
        }
    }
}
