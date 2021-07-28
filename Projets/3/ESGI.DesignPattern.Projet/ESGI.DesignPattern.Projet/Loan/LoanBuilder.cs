using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class LoanBuilder
    {
        double _commitment;
        private DateTime? _expiry;
        private DateTime? _maturity;
        private DateTime _start;
        private double _riskRating;
        private CapitalStrategy _capitalStrategy;
        
        /*
        private double _unusedPercentage;
        private double _outstanding;
        IList<Payment> _payments;
        private DateTime? _today;
        */
        
        public LoanBuilder WithCommitment(double commitment)
        {
            _commitment = commitment;
            return this;
        }

        public LoanBuilder WithExpiry(DateTime? expiry)
        {
            _expiry = expiry;
            return this;
        }

        public LoanBuilder WithMaturity(DateTime? maturity)
        {
            _maturity = maturity;

            return this;
        }
        //
        // public LoanBuilder WithOutstanding(double outstanding)
        // {
        //     _outstanding = outstanding;
        //
        //     return this;
        // }
        //
        // public LoanBuilder WithPayments(IList<Payment> payments)
        // {
        //     _payments = payments;
        //
        //     return this;
        // }
        //
        // public LoanBuilder WithToday(DateTime? today)
        // {
        //     _today = today;
        //
        //     return this;
        // }
        // public LoanBuilder WithUnusedPercentage(double unusedPercentage)
        // {
        //     _unusedPercentage = unusedPercentage;
        //     return this;
        // }
        public LoanBuilder WithStart(DateTime start)
        {
            _start = start;
            return this;
        }
        
        public LoanBuilder WithRiskRating(double riskRating)
        {
            _riskRating = riskRating;
            return this;
        }
        
        
        
        public LoanBuilder WithCapitalStrategy(CapitalStrategy capitalStrategy)
        {
            _capitalStrategy = capitalStrategy;
            return this;
        }
        
        
        public Loan Build()
        {
            return new Loan(_commitment, _start, _expiry, _maturity, _riskRating, _capitalStrategy);
        }
    }
}