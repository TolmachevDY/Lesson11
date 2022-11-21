using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Line
    {
        double k;
        double b;         
        
        public Line(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0 && b == 0)
                return "Решений бесконечно много"; 
            if (k == 0)
                return "Ошибка. Деление на ноль";            
            if (k == 0 && b != 0)
                return "Решений нет";
            else
            {
                double r = -b / k;
                return Convert.ToString(r);
            }
        }
    }
}
