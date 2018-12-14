using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTest.Backend.Operations;
using CodeTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeTest.Pages
{
    [IgnoreAntiforgeryToken]
    public class CalculatorModel : PageModel
    {
        private readonly ICalculatorService calc;

        [BindProperty]
        public int Left {get; set;}

        [BindProperty]
        public int Right {get; set;}

        public CalculatorModel(ICalculatorService calculator)
        {
            calc = calculator;
        }

        [BindProperty]
        public int CalculationResult { get; set; }

        public void OnGet() {
            Left = CalculationResult;
        }

        public IActionResult OnPost(string operation, int left, int right) {
            Left = left;
            Right = right;
            CalculationResult = Calculate(operation);
            Right = 0;
            return Page();
        }

        private int Calculate(string operation)
        {
            if (!ModelState.IsValid) return 0;

            switch (operation)
            {
                case "add":
                    return calc.Calculate(
                        new AddOperation(Left, Right)
                    );
                case "subtract":
                    return calc.Calculate(
                        new SubtractOperation(Left, Right)
                    );
                case "multiply":
                    return calc.Calculate(
                        new MultiplyOperation(Left, Right)
                    );
                default:
                    return int.MinValue;
            }
        }

    }
}
