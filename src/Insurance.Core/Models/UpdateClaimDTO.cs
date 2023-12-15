namespace Insurance.Core.Models
{
    public class UpdateClaimDTO
    {
        public UpdateClaimDTO(
           DateTime claimDate,
           DateTime lossDate,
           string assuredName,
           decimal incurredLoss,
           bool closed
        )
        {
            ClaimDate = claimDate;
            LossDate = lossDate;
            AssuredName = assuredName;
            IncurredLoss = incurredLoss;
            Closed = closed;
        }

        public DateTime ClaimDate { get; set; }

        public DateTime LossDate { get; set; }

        public string AssuredName { get; set; }

        public decimal IncurredLoss { get; set; }

        public bool Closed { get; set; }
    }
}
