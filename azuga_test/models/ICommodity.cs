using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azuga_test
{
    public interface ICommodity
    {
        public string Item { get; set; }

        public string ItemCategory { get; set; }

        public double TaxRate { get; set; }

        public double  FinalPrice { get; set; }
    }



    //public enum ItemCategory
    //{
    //    Medicine = 1,
    //}
}
