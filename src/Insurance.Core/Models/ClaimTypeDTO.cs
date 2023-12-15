namespace Insurance.Core.Models
{
    public class ClaimTypeDTO
    {
        public ClaimTypeDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
