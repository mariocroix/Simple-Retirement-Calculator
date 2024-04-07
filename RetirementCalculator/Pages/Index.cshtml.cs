using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetirementCalculator.Models;
using RetirementCalculator.Services;

namespace RetirementCalculator.Pages;

public class IndexModel : PageModel
{
    private readonly IRetirementCalculator _retirementCalculator;

    [BindProperty]
    public RetirementInput Input { get; set; }

    public RetirementResult Result { get; set; }

    public IndexModel(IRetirementCalculator retirementCalculator)
    {
        _retirementCalculator = retirementCalculator;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        // Custom validation: CurrentAge must not be greater than RetirementAge
        if (Input.CurrentAge > Input.RetirementAge)
        {
            ModelState.AddModelError("Input.RetirementAge", "Retirement age must be greater than current age.");
        }

        if (!ModelState.IsValid)
        {
            return Page();
        }

        Result = _retirementCalculator.CalculateRetirementInfo(Input);
        return Page();
    }
}

