using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace assignment_products_categories.Models
{
  public class Category
  {
    [Key]
    public int ChefId { get; set; }
    [Required]
    public string FirstName { get; set; }

    // navigation property
    public List<Dish> Dishes { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}