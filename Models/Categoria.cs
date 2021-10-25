﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lojaSapato.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}