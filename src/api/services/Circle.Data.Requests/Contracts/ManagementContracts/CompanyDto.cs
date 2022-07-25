namespace Circle.Data.Requests.ManagementContracts
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public bool IsActive { get; set; }
    }
}