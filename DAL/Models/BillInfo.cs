using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("BillInfo")]
public partial class BillInfo
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BillID")]
    public int BillId { get; set; }

    [Column("ProductID")]
    public int ProductId { get; set; }

    public int CountValue { get; set; }
}
