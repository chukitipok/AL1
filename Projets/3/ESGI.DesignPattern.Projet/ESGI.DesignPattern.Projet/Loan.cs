using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class Loan
    {
        double _commitment;
        private DateTime? _expiry;
        private DateTime? _maturity;
        private double _outstanding;
        IList<Payment> _payments;
        private DateTime? _today;
        private DateTime _start;
        private double _riskRating;
        private double _unusedPercentage;
        private CapitalStrategy _capitalStrategy;

        private Loan(double commitment,
                    DateTime start,
                    DateTime? expiry,
                    DateTime? maturity,
                    int riskRating,
                    CapitalStrategy capitalStrategy)
        {
            _expiry = expiry;
            _commitment = commitment;
            _today = new DateTime?();
            _start = start;
            _maturity = maturity;
            _riskRating = riskRating;
            _unusedPercentage = 1.0;
            _capitalStrategy = capitalStrategy;
            _payments = new List<Payment>();
        }

        public static Loan NewTermLoan(double commitment, DateTime start, DateTime maturity, int riskRating)
        {
            return new(commitment, start, null,
                            maturity, riskRating, new CapitalStrategyTermLoan());
        }

        public static Loan NewRevolver(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            return new(commitment, start, expiry,
                            null, riskRating, new CapitalStrategyRevolver());
        }

        public static Loan NewAdvisedLine(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            if (riskRating > 3) return null;
            Loan advisedLine = new Loan(commitment, start, expiry,
                                        null, riskRating, new CapitalStrategyAdvisedLine());
            advisedLine.SetUnusedPercentage(0.1);
            return advisedLine;
        }

        public DateTime? GetExpiry()
        {
            return _expiry;
        }

        public double GetCommitment()
        {
            return _commitment;
        }

        public DateTime? GetMaturity()
        {
            return _maturity;
        }

        public double GetRiskRating()
        {
            return _riskRating;
        }

        public void Payment(double amount, DateTime paymentDate)
        {
            _payments.Add(new Payment(amount, paymentDate));
        }

        public double Capital()
        {
            return _capitalStrategy.Capital(this);
        }

        public DateTime? GetToday()
        {
            return _today;
        }

        public DateTime? GetStart()
        {
            return _start;
        }

        public IList<Payment> Payments()
        {
            return _payments;
        }

        public double GetUnusedPercentage()
        {
            return _unusedPercentage;
        }

        public void SetUnusedPercentage(double unusedPercentage)
        {
            _unusedPercentage = unusedPercentage;
        }

        public double UnusedRiskAmount()
        {
            return (_commitment - _outstanding);
        }

        public double OutstandingRiskAmount()
        {
            return _outstanding;
        }
    }
}