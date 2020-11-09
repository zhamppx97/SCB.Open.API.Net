using System;

namespace SCB.Open.API.Net.LoanOrigination.Models
{
    public class SimulatorCalResponseData
    {
        public SimulatorCalStatus status { get; set; }
        public SimulatorCalData data { get; set; }
        public object jsonString { get; set; }
    }

    public class SimulatorCalStatus
    {
        public int code { get; set; }
        public string description { get; set; }
    }

    public class SimulatorCalData
    {
        public SimulatorCalLoan loan { get; set; }
    }

    public class SimulatorCalLoan
    {
        public float totalRequestAmount { get; set; }
        public int loanTenor { get; set; }
        public float installmentAmount { get; set; }
        public string paymentFrequency { get; set; }
        public SimulatorCalInstallment installment { get; set; }
        public float interestRate { get; set; }
        public DateTime firstDueDate { get; set; }
    }

    public class SimulatorCalInstallment
    {
        public float minAmount { get; set; }
        public float maxAmount { get; set; }
    }
}
