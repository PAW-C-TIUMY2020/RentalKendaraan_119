using System;
using System.Collections.Generic;

namespace RentalKendaraan_20180140119.Models
{
    public partial class KondisiKendaraan
    {
        public int IdKondisi { get; set; }
        public string NamaKondisi { get; set; }

        public Pengembalian IdKondisiNavigation { get; set; }
    }
}
