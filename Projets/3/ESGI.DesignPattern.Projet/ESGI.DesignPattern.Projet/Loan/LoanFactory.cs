using System;

namespace ESGI.DesignPattern.Projet
{
    public class LoanFactory
    {
        public static ILoan Create(LoanType type, double commitment, DateTime start, DateTime end, int riskRating)
        {

            return type switch
            {
                LoanType.Term => CreateTermLoan(commitment, start, end, riskRating),
                LoanType.Revolver => CreateRevolver(commitment, start, end, riskRating),
                LoanType.AdvisedLine => CreateAdvisedLine(commitment, start, end, riskRating),
                _ => null
            };
        }

        private static ILoan CreateTermLoan(double commitment, DateTime start, DateTime maturity, int riskRating)
        {
            var newLoan = new LoanBuilder();
            var strategy = new CapitalStrategyTermLoan();

            return newLoan
                .WithCommitment(commitment)
                .WithStart(start)
                .WithMaturity(maturity)
                .WithRiskRating(riskRating)
                .WithCapitalStrategy(strategy)
                .Build();
        }

        private static ILoan CreateRevolver(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            var newLoan = new LoanBuilder();
            var strategy = new CapitalStrategyRevolver();

            return newLoan
                .WithCommitment(commitment)
                .WithStart(start).WithExpiry(expiry)
                .WithRiskRating(riskRating)
                .WithCapitalStrategy(strategy)
                .Build();
        }
        
        private static ILoan CreateAdvisedLine(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            var newLoan = new LoanBuilder();
            var strategy = new CapitalStrategyAdvisedLine();
            
            var loan = newLoan
                .WithCommitment(commitment)
                .WithStart(start)
                .WithExpiry(expiry)
                .WithRiskRating(riskRating)
                .WithCapitalStrategy(strategy)
                .Build();
            loan.SetUnusedPercentage(0.1);
            
            return loan;
        }
    }
    
}