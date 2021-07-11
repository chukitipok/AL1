using System;

namespace ESGI.DesignPattern.Projet

{
    public class Payment
    {
        public Payment(double amount = 0.0, DateTime date = new())
        {
            Amount = amount;
            Date = date;
        }

        public double Amount { get; }

        public DateTime Date { get; }
    }
}