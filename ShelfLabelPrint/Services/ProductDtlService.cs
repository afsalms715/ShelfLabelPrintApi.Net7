namespace ShelfLabelPrint.Services
{
    public class ProductDtlService
    {
        public string connectionString { get; set; }
        public ProductDtlService(string connectionString) { 
            this.connectionString = connectionString;
        }
        public string GetConnectioinString()
        {
            return connectionString;
        }
    }
}
