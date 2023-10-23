using System.ComponentModel.DataAnnotations;
namespace EmpMvc.Models;
public class Product
{
[Display(Name = "Product Id")]
[Key]
[Required(ErrorMessage = "Id is compulsory")]
    public int Id{get; set;}
    [Required(ErrorMessage = "Name cannot be Blank")]
    public string Name{get; set;}
    [Range(100,900,ErrorMessage = "Price should be between 100 and 900")]
    public int Price{get; set;}
    public int Stock{get; set;}
}