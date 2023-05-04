﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalLab.Models
{
    public class positions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string positionId { get; set; }
        public string positionName { get; set; }
        public float baseSalary { get; set; }
        public float salaryIncreaseRate { get; set; }

    }
}