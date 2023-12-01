using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Employee
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string EmployeeName { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Potision { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Salary { get; set; } = null!;

    [Column("AccountID")]
    public int? AccountId { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("Employees")]
    public virtual Account? Account { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
