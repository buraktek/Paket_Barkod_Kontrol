using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Paket_Barkod_Kontrol
{
    public class Package
    {
        public int ID { get; set; }
        public string Meter_ID { get; set; }

        public int Meter_Count_In_Box { get; set; }

        public string Package_Code { get; set; }

        public string Product_Code { get; set; }

        public DateTime Packing_Date { get; set; }
        public string Transferred_Public { get; set; }
    }
}
