﻿using SFB.Solutions.Entities;
using SFB.Solutions.Entities.M_Almacen;
using SFB.Solutions.Repository.M_Almacen;
using SFB.Solutions.Sevices.M_Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFB.Solutions.Logic.M_Almacen
{
    public class ProductoBL
    {
        private readonly IProductoServices _repository;
        public ProductoBL()
        {
            _repository = new ProductoRepository ();

        }
        public List<ProductoBE> Listar()
        {
            return _repository.Listar();
        }
        public List<MensajeBE> Guardar(ProductoBE BE)
        {
            return _repository.Guardar(BE);
        }
        public MensajeBE Anular(ProductoBE BE)
        {
            return _repository.Anular(BE);
        }

    }
}
