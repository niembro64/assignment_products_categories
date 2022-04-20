using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace assignment_products_categories.Models
{
  public class Product
  {
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [Range(0,int.MaxValue)]
    public decimal Price { get; set; }

    // navigation property
    public List<Association> CategoryList { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}