﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
