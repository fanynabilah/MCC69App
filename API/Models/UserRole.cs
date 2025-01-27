﻿using API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class UserRole : IEntity
    {
        [Key]
        public int Id { get; set; }

        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }

        public virtual Role Role { get; set; }
        [ForeignKey("Role")]
        public int Role_Id { get; set; }
    }
}
