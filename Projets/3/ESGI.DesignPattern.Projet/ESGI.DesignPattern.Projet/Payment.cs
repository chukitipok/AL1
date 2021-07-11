using System;

namespace ESGI.DesignPattern.Projet

{
    public class Payment
    {
        private double _amount;
        private DateTime _date;

        public Payment(double amount = 0.0, DateTime date = new())
        {
            Amount = amount;
            Date = date;
        }

        public double Amount
        {
            get { return _amount; }

            private set { _amount = value; }
        }

        public DateTime Date
        {
            get { return _date; }

            private set { _date = value; }
        }
    }
}