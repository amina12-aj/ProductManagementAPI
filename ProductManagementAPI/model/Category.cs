using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public string? Price { get; set; }
        public string? ProductType { get; set; }
        [Required]
        public DateTime? Date { get; set; }

        //creating a list that holds all the items
        List<Products> ProductList = new List<Products>
        { new ProductList { Id = 1, ProductName = "Eggs", Price = 123456, ProductType = "Consumer", DateTime = },
            new ProductList { Id = 2, ProductName = "Rice", Price = 1000, ProductType = "Consumer", DateTime = },
            new ProductList { Id = 3, ProductName = "Stove", Price = 600, ProductType = "Electronics", DateTime = },
            new ProductList { Id = 4, ProductName = "Blender", Price = 12000, ProductType = "Electronics", DateTime = },
            new ProductList { Id = 5, ProductName = "Beans", Price = 500, ProductType = "Consumer", DateTime = },
            new ProductList { Id = 6, ProductName = "CornFlakes", Price = 1200, ProductType = "Consumer", DateTime = } 
        };


            
}
 
