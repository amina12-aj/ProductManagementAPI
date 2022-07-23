using System.ComponentModel.DataAnnotations;

namespace ProductManagementAPI.model
{
    public static class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string productName { get; set; }
        public string price { get; set; }
        public string productType{ get; set; }
        public DateTime date { get; set; }
    }

    
}
 
