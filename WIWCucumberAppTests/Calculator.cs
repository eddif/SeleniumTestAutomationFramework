using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIWCucumberAppTests
{
    public class Calculator
    {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }
        private int result { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
