namespace ByteCart.Admin.Domain.Entities.Products
{
    public class ProductTag
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public Guid TagId { get; set; }
        public Tag Tag { get; set; } = null!;
    }
}