using System;
namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyTermLoan : CapitalStrategy
    {
        private const double Epsilon = 0.001;

        public override double Capital(Loan loan)
        {
            return loan.GetCommitment() * Duration(loan) * RiskFactorFor();
            // return loan.GetCommitment() * Duration(loan) * RiskFactorFor(loan);
        }

        public override double Duration(Loan loan)
        {
            var duration = 0.0;
            var weightedAverage = 0.0;
            var sumOfPayments = 0.0;
            
            foreach (var payment in loan.Payments())
            {
                sumOfPayments += payment.Amount;
                weightedAverage += YearsTo(payment.Date, loan) * payment.Amount;
            }
            
            if (Math.Abs(loan.GetCommitment()) > Epsilon)
            {
                duration = weightedAverage / sumOfPayments;
            }
            
            return duration;
        }
    }
}