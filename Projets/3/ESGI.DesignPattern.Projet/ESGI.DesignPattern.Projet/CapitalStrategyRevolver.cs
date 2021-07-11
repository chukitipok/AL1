namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyRevolver : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return (loan.OutstandingRiskAmount() * Duration(loan) * GetRiskFactorFor())
                        + (loan.UnusedRiskAmount() * Duration(loan) * GetUnusedRiskFactorFor());
        }
    }
}