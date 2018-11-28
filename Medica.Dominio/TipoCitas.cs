﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medica.Dominio
{
    [Table("Usuarios")]
    public class TipoCitas
    {
        
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public string Imagen { get; set; }
    }
}


