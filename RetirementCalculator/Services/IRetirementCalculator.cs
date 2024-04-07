using RetirementCalculator.Models;

namespace RetirementCalculator.Services;

public interface IRetirementCalculator
{
    RetirementResult CalculateRetirementInfo(RetirementInput input);
}
