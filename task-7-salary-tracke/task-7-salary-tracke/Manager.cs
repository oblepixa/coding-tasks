using System;
using System.Collections.Generic;
using System.Text;

namespace task_7_salary_tracke
{
    class Class_manager : IPosition
    {
        private double zp_baz;
        private double prib;


        public void SetBasicSalary(double salary)
        {
            zp_baz = salary;
        }
        public void P(double prib_mes)
        {
            prib = prib_mes;
        }
        public double GetSalary(double shifts)
        {
            return shifts*(zp_baz * zp_baz * 0.25 * Math.Pow(10, -4) + prib * 0.5 * Math.Pow(10, -2)/24);
        }
    }
}
