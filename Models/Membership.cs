namespace MyBlazorApp.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string MemberType { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateJoined { get; set; }
    }
}