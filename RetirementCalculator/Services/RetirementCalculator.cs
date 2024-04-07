using RetirementCalculator.Models;

namespace RetirementCalculator.Services;

public class RetirementCalculator : IRetirementCalculator
{
    public RetirementResult CalculateRetirementInfo(RetirementInput input)
    {
        var yearsToSave = input.RetirementAge - input.CurrentAge;
        var totalSavings = input.CurrentSavings;

        for (int i = 0; i < yearsToSave * 12; i++)
        {
            totalSavings += input.MonthlySavings;
            var monthlyInterest = totalSavings * (input.AnnualInterestRate / 100 / 12);
            totalSavings += monthlyInterest;
        }

        return new RetirementResult { TotalSavingsAtRetirement = totalSavings };
    }
}
