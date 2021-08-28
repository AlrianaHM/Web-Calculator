using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController
    {
        List<Calculator.Models.Calculator> calculators = new List<Calculator.Models.Calculator>();
        int idx = 0;

        public void CreateCalculator(string eks, string res)
        {
            Calculator.Models.Calculator c = new Calculator.Models.Calculator { Id = idx, Expresion = eks, Result = res };
            idx++;
            calculators.Add(c);
        }

        public string GetResult(string expresion)
        {
            try
            {
                double result = Convert.ToDouble(new DataTable().Compute(expresion, null));
                CreateCalculator(expresion, result.ToString());
                return result.ToString();
            }
            catch (Exception e)
            {
                return "Syntax Error";
            }
        }
    }
}