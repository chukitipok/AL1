namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.GetCommitment() * loan.GetUnusedPercentage() * Duration(loan) * RiskFactorFor();
        }
    }
}