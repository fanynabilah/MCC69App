﻿using API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class User : IEntity
    {
        [Key]
        [ForeignKey("Employee")]
        public int Id { get; set; }
        public virtual Employee Employee { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
