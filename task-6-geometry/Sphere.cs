using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    class Sphere : ISphere
    {
        //свойство класса, куда будет сохраняться радиус
        //его не видно извне, работает только внутри класса
        private double _radius;

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double Volume()
        {
            return (4 *_radius  * _radius * _radius * Math.PI)/3 ;
        }
    }
}
