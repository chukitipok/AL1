using System;
namespace ESGI.DesignPattern.Projet
{
    public abstract class CapitalStrategy
    {
        public abstract double Capital(Loan loan);
        
        protected double RiskFactorFor()
        {
            return 0.03;
        }

        protected double UnusedRiskFactorFor()
        {
            return 0.01;
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
            
        }
    }
}