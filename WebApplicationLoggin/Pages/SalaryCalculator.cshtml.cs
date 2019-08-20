using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationLoggin.Pages
{
    public class SalaryCalculatorModel : PageModel
    {
        private HR.ISalaryFormula _SalaryFormula;
        public SalaryCalculatorModel(HR.ISalaryFormula SalaryFormula)
        {
            _SalaryFormula = SalaryFormula;
        }

        public float Salary { get; set; }
        public  ActionResult  OnGet()
        {
            HR.SalaryCalculator SalaryCalculator = 
                new HR.SalaryCalculator(_SalaryFormula);
            Salary = SalaryCalculator.Calculate(8 * 19, 200, 8 * 1);
            return Page();
        }
    }
}