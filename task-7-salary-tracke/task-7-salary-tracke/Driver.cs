using System;
using System.Collections.Generic;
using System.Text;

namespace task_7_salary_tracke
{
    class Class_driver : IPosition
    {
        private double zp_baz;

        public double GetSalary(double shifts)
        {
            return shifts*zp_baz * 0.85/24;
        }
        public void SetBasicSalary(double salary)
        {
            zp_baz = salary;
        }
    }
}
