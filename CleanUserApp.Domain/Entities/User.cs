namespace CleanUserApp.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }   // PK
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}