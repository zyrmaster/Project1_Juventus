using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public double Price { get; set; }

    [Column("CategoryID")]
    public int CategoryId { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ProductType { get; set; } = null!;

    [ForeignKey("CategoryId")]
    [InverseProperty("Products")]
    public virtual ProductCategory Category { get; set; } = null!;
}
public class ProductWithQuantity
{
    public Product OriginalProduct { get; set; }
    public int Quantity { get; set; }
}
