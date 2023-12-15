namespace Insurance.Core.Models
{
    public class CompanyDTO
    {
        public CompanyDTO(
            int id,
            string name,
            string address1,
            string address2,
            string address3,
            string postcode,
            string country,
            bool active,
            DateTime insuranceEndDate,
            bool activeInsurance = true
            )
        {
            Id = id;
            Name = name;
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
            Postcode = postcode;
            Country = country;
            Active = active;
            InsuranceEndDate = insuranceEndDate;
            HasActiveInsurance = activeInsurance;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string Postcode { get; set; }

        public string Country { get; set; }

        public bool Active { get; set; }

        public DateTime InsuranceEndDate { get; set; }

        private bool _activeInsurance;

        public bool HasActiveInsurance {
            get => _activeInsurance;
            set 
            {
                _activeInsurance =
                    InsuranceEndDate.Ticks > DateTime.Now.Ticks; 
            } 
        }
    }
}
