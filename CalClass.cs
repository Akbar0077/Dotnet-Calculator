using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calproj
{
    public class CalClass
    {
        string oper = "";
        string firstNumberstr = "";
        string secondNumberstr = "";
        public CalClass()
        {

        }
        public int Addnumber(int firstNumberstr, int secondNumberstr)
        {
            int a = firstNumberstr;
            int b = secondNumberstr;
            int result = a + b;
            return result;

        }
        public int Subnumber(int firstNumberstr, int secondNumberstr)
        {
            int a = firstNumberstr;
            int b = secondNumberstr;
            int result = a - b;
            return result;

        }
        public int Mulnumber(int firstNumberstr, int secondNumberstr)
        {
            int a = firstNumberstr;
            int b = secondNumberstr;
            int result = a * b;
            return result;

        }
        public int Divnumber(int firstNumberstr, int secondNumberstr)
        {
            int a = firstNumberstr;
            int b = secondNumberstr;
            int result = a / b;
            return result;

        }
        public int Test(params int[]values)
        {
            int total = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            return total;

        }
}   }
