﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace iti_DB_forms.Models;

[PrimaryKey("St_Id", "Crs_Id")]
[Index("Crs_Id", Name = "IX_Student_Courses_Crs_Id")]
public partial class Student_Course
{
    [Key]
    public int Crs_Id { get; set; }

    [Key]
    public int St_Id { get; set; }

    public int? Grade { get; set; }

    [ForeignKey("Crs_Id")]
    [InverseProperty("Student_Courses")]
    public virtual Course Crs { get; set; }

    [ForeignKey("St_Id")]
    [InverseProperty("Student_Courses")]
    public virtual Student St { get; set; }
}