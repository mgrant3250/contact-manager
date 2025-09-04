namespace ContactManager.Models
{
    public class Category
    {
        public Category() => Contacts = new HashSet<Contact>();
        public int CategoryId { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Contact> Contacts { get; set; }
    }
}
