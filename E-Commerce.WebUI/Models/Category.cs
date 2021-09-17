﻿using System;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.WebUI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        
    }
}
