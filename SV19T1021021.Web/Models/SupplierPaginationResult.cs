﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SV19T1021021.DomainModel;

namespace SV19T1021021.Web.Models
{
    public class SupplierPaginationResult : BasePaginationResult
    {
        public List<Supplier> Data { get; set; }
    }
}