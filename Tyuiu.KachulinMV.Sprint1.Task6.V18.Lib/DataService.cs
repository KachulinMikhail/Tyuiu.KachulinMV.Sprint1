using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KachulinMV.Sprint1.Task6.V18.Lib
{
    public class DataService: ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            if (value.Length > 1 && value[0] == '0')
            {
                return false;
            }

            if (value == "0")
            {
                return false;
            }

            return true;
        }
    }
}