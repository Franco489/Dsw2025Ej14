namespace Dsw2025Ej14.Api.Domain
{
    public class Product
    {
        public string? Sku { get; set; }
        private string? Name { get; set; }
        private decimal CurrentUnitPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
