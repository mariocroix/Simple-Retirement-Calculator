namespace RetirementCalculator.Models;

using System.ComponentModel.DataAnnotations;

public class RetirementInput
{
    [Range(0, 110, ErrorMessage = "Age must be between 0 and 110.")]
    public int CurrentAge { get; set; }

    [Range(0, 110, ErrorMessage = "Age must be between 0 and 110.")]
    public int RetirementAge { get; set; }

    public decimal CurrentSavings { get; set; }
    public decimal MonthlySavings { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Interest rate must be positive.")]
    public decimal AnnualInterestRate { get; set; }
}
