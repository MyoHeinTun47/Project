namespace Project.Domain
{
    public class Category : BaseDomainModel
    {
        public string? CategoryName { get; set; }
        public CategoryType CategoryType {  get; set; }

        public int AppUserId { get; set; }
    }
    public enum CategoryType
    {
        Income,
        Expense
    }
}
