using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPSample.Model
{
    public class Model1
    {
        //data
        public int operand1 { get; set; }
        public int operand2 { get; set;}
        public int result { get; set; } 

        //business logic 
        public void add()
        {
            result = operand1 + operand2;
        }
    }
}
