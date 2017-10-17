using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Bank
{
    static class MathEx
    {
        /* факториал через рекурсию */
        public static int Fact( int f )
        {
            if ( f == 1)
            {
                return 1;
            }
            return MathEx.Fact(f - 1) * f;
        }
        
        /* обратное числовое значение аргумента */
        public static double Reciprocal(int e)
        {
            //если в метод передан 0 выбрасываем исключение деления на ноль
            if (e == 0) { throw new DivideByZeroException(); }
            return 1d / e;
        }
        
        /* дробная часть */
        public static double FracPart(double c)
        {
            int l = (int)c;
            return c - l;
        }
        
        /* четность */
        public static bool IsEven(int z)
        {
            
            if ((z % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /* нечетность */
        public static bool IsOdd(int d)
        {
            if((d % 2) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }
        
        /* кубический корень */
        public static double Crt(double s)
        {
            return Math.Pow(s, 1f / 3);
        }
        
        /* радианы */
        public static double DegToRad(int g)
        {                      
            return Math.PI * 2 * (g / 360f);
        }
        
        /* градусы */
        public static double RadToDeg(double rad)
        {            
            return (rad / (Math.PI * 2)) * 360;
        }


    }
}
