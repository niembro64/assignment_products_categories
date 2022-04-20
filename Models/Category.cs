using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace assignment_products_categories.Models
{
  public class Category
  {
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; }

    // navigation property
    public List<Association> ProductList { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}