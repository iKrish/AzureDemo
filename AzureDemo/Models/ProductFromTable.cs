using Microsoft.WindowsAzure.Storage.Table;
using System.ComponentModel.DataAnnotations;

namespace AzureDemo.Models
{
    public class ProductsFromTable : TableEntity
    {

        public ProductsFromTable(string name, string category)
        {
            PartitionKey = category;
            RowKey = name;
        }

        public ProductsFromTable() { }

        [Key]
        public string id { get; set; }
        public string ProductModel { get; set; }
        public string Description { get; set; }
    }

    
}