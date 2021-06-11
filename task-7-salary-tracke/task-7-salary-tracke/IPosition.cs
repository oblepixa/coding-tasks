using System;
using System.Collections.Generic;
using System.Text;

namespace task_7_salary_tracke
{
    interface IPosition
    {

        public double GetSalary(double shifts);

        public void SetBasicSalary(double salary);

    }
}
