﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiMedica.Models
{
    [Table("TipoCitas")]
    public class TipoCitas
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        [MaxLength(200)]
        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        [MaxLength(80)]
        [Required]
        public string Imagen { get; set; }
    }
}