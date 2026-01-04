namespace MyBlazorApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int MembershipId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal FineAmount { get; set; }

        public Book? Book { get; set; }
        public Membership? Membership { get; set; }
    }
}