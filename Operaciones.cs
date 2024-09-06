using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solAppSS
{
    internal class Operaciones
    {
        public bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int suma(int a, int b)
        {
            return a + b;
        }
        public int resta(int a, int b)
        {
            return a - b;
        }
        public int multiplicar(int a, int b)
        {
            return a * b;
        }
        public int dividir(int a, int b)
        {
            return a / b;
        }
    }
}
