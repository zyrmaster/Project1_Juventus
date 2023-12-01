using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Bill
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateIn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOut { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    public double PriceTotal { get; set; }

    [Column("TableID")]
    public int TableId { get; set; }

    [Column("CustomerID")]
    public int CustomerId { get; set; }

    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Bills")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("EmployeeId")]
    [InverseProperty("Bills")]
    public virtual Employee Employee { get; set; } = null!;

    [ForeignKey("TableId")]
    [InverseProperty("Bills")]
    public virtual Table Table { get; set; } = null!;
}
