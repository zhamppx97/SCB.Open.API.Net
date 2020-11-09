using System.ComponentModel.DataAnnotations;

namespace SCB.Open.API.Net.LoanOrigination.Models
{
    public class SimulatorCalRequestBody
    {
        public Loan loan { get; set; }
    }

    public class Loan
    {
        /// <summary>
        /// Required:
        /// Product type
        /// </summary>
        [Required]
        public string productIntent { get; set; }
        /// <summary>
        /// Required:
        /// Total loan request amount
        /// </summary>
        [Required]
        public float totalRequestAmount { get; set; }
        /// <summary>
        /// Required:
        /// Loan payment frequency
        /// </summary>
        [Required]
        public string paymentFrequency { get; set; }
        /// <summary>
        /// Optional:
        /// Loan tenor
        /// </summary>
        public int loanTenor { get; set; }
        /// <summary>
        /// Optional:
        /// Loan installment amount
        /// </summary>
        public float installmentAmount { get; set; }
        /// <summary>
        /// Optional:
        /// Bi-weekly
        /// 0: No grace period
        /// 1: Have 1 grace period to extend the first repayment for 2 weeks
        /// 2: Have 2 grace period to extend the first repayment for 4 weeks
        /// Monthly
        /// 0 : No grace period
        /// 1: Have 1 grace period to extend first repayment date for 1 month
        /// Grace period is the period to delay first repayment installment
        /// </summary>
        public int gracePeriod { get; set; }
        /// <summary>
        /// Optional:
        /// Loan payment due day
        /// If loan.paymentFrequency is Monthly, send string of date 3 to 25.
        /// Else, send day of week code from 1 (Sunday) to 7 (Saturday)
        /// </summary>
        public int dueDay { get; set; }
    }
}
