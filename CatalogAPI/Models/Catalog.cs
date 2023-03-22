using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CatalogAPI.Models
{

//user2 modifying the code
//add sub catalog name

    [Table("Catalog")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	//user2 make change
	//user3 make update
        [Required]
        [Column("Catalog_Id")]
        public long CatalogId { get; set; }
        [Column("Catalog_Name")]
        [Required]
	//user2 lalalala

	//user3 make update here
        [StringLength(50)]


//user3 modifying the code
//add additional constraint to catalog name

        public string? CatalogName { get; set; }

        //[JsonIgnore]       
       // public Collection<Product> ProductList { get; set; }


    }
}

//test smartgit

//user2 test smartgit again