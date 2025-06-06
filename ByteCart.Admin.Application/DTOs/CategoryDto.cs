namespace ByteCart.Admin.Application.DTOs
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid? ParentCategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public int ProductCount { get; set; }
        public IEnumerable<CategoryDto> SubCategories { get; set; } = new List<CategoryDto>();
        public IEnumerable<Guid> Products { get; set; } = new List<Guid>();
        
    }
}