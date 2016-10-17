using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOriginalProject.Figure
{
    public class Circle
    {
        public decimal Radio{ get; set; }
        
        public decimal Area
        {
            get { return (Radio * Radio) * 3.14159;
        }
                             
        public Circle(decimal radius)
        {
            Radio = radius;
        }
    }
}
