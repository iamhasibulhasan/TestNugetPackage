namespace TestNugetPackage.Application.Feature
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
    }
}
