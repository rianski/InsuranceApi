namespace Insurance.Core.Models
{
    public class ClaimDTO
    {
        public ClaimDTO(
            string ucr,
            int companyId,
            DateTime claimDate,
            DateTime lossDate,
            string assuredName,
            decimal incurredLoss,
            bool closed,
            int daysSinceClaim = 0
        )
        {
            UCR = ucr;
            CompanyId = companyId;
            ClaimDate = claimDate;
            LossDate = lossDate;
            AssuredName = assuredName;
            IncurredLoss = incurredLoss;
            Closed = closed;
            DaysSinceClaim = daysSinceClaim;
        }

        public string UCR { get; set; }

        public int CompanyId { get; set; }

        public DateTime ClaimDate { get; set; }

        public DateTime LossDate { get; set; }

        public string AssuredName { get; set; }

        public decimal IncurredLoss { get; set; }

        public bool Closed { get; set; }

        private int _claimAge;

        public int DaysSinceClaim
        {
            get => _claimAge;
            set
            {
                if (ClaimDate.Ticks < DateTime.Now.Ticks)
                {
                    _claimAge = (DateTime.Now - ClaimDate).Days;
                }
                else
                {
                    _claimAge = value;
                }
            }
        }
    }
}
