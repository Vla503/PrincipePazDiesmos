﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Dto.Paginacion
{
    public class PaginadoVm
    {
        public string UrlPaginaAnterior { get; set; }

        public List<BotonPaginacionVm> Botones { get; set; }

        public string UrlPaginaSiguiente { get; set; }

        public int PaginaActiva { get; set; }

        public string ClasePersonalizada { get; set; }
    }
}
