namespace BethanysPieShop.Models
{
    public class CartItem
    {
        public string? CartId { get; set; }
        public int CartItemId = default!;
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }   
}
