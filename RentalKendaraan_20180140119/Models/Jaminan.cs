﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_20180140119.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }
        public string NamaJaminan { get; set; }

        public Peminjaman Peminjaman { get; set; }
    }
}
