using System;
namespace ESGI.DesignPattern.Projet
{
    public abstract class CapitalStrategy
    {
        private const double RiskFactorFor = 0.03;
        private const double UnusedRiskFactorFor = 0.01;
        private long MILLIS_PER_DAY = 86400000;
        private long DAYS_PER_YEAR = 365;

        public abstract double Capital(Loan loan);

        protected double GetRiskFactorFor()
        {
            return RiskFactorFor;
        }

        protected double GetUnusedRiskFactorFor()
        {
            return UnusedRiskFactorFor;
        }

        public virtual double Duration(Loan loan)
        {
            return YearsTo(loan.GetExpiry(), loan);
        }

        protected double YearsTo(DateTime? endDate, Loan loan)
        {
            if (endDate == null)
            {
                throw new InvalidOperationException("EndDate is null for future operations calculus.");
            }
            
            var beginDate = loan.GetToday() == null ? loan.GetStart() : loan.GetToday();
            return (double)((endDate?.Ticks - beginDate?.Ticks) / MILLIS_PER_DAY / DAYS_PER_YEAR);
        }
    }
}