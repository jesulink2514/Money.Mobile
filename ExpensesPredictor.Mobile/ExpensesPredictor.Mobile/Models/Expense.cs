using System;

namespace ExpensesPredictor.Mobile.Models
{
    public class Expense:BindableBase
    {
        private string _title;
        private string _description;
        private double _amount;
        private ExpenseFrecuency _frecuency;
        public Guid Id { get; set; }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title,value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description,value); }
        }

        public double Amount
        {
            get { return _amount; }
            set { SetProperty(ref _amount,value);}
        }

        public ExpenseFrecuency Frecuency
        {
            get { return _frecuency; }
            set {SetProperty(ref _frecuency,value); }
        }
    }
}
