using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class Calculator
    {
        public int Id { get; set; }
        public string Expresion { get; set; }
        public string Result { get; set; }
    }
}