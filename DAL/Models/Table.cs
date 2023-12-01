using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Table
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public int Slot { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("Table")]
    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
