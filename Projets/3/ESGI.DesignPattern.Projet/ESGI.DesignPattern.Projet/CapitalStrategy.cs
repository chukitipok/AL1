using System;
namespace ESGI.DesignPattern.Projet
{
    public abstract class CapitalStrategy
    {
        // private TimeDuration _duration;
        // private long MILLIS_PER_DAY = (long)TimeDuration.MillisPerDay;
        // private long DAYS_PER_YEAR = (long)TimeDuration.DaysPerYear;

        public abstract double Capital(Loan loan);

        // protected double RiskFactorFor(Loan loan)
        protected double RiskFactorFor()
        {
            return 0.03;
            // return RiskFactor.GetFactors().ForRating(loan.GetRiskRating());
        }

        // protected double UnusedRiskFactorFor(Loan loan)
        protected double UnusedRiskFactorFor()
        {
            return 0.01;
            // return UnusedRiskFactors.GetFactors().ForRating(loan.GetRiskRating());
        }

        public virtual double Duration(Loan loan)
        {
            return YearsTo(loan.GetExpiry(), loan);
        }

        protected double YearsTo(DateTime? endDate, Loan loan)
        { 
            var beginDate = loan.GetToday() == null ? loan.GetStart() : loan.GetToday();
            var timeDelta = (endDate?.Ticks - beginDate?.Ticks) / (long)TimeDuration.MillisPerDay;
            timeDelta /= (long)TimeDuration.DaysPerYear;
            
            return (double) timeDelta;
            
            // return (double)((endDate?.Ticks - beginDate?.Ticks) / (long)TimeDuration.MillisPerDay / (long)TimeDuration.DaysPerYear);
        }
    }
}