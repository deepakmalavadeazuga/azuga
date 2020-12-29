using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azuga_test.models
{

    public class Food : Commodity
    {
        public override double TaxRate1
        {
            get
            {
                return 5;
            }
        }
    }
    public class Commodity : ICommodity
    {
        public string ItemCategory { get; set; }
        public string Item { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

        public virtual double TaxRate1
        { get; set; }
        public  double TaxRate
        {
            get
            {
                {
                    //Get this from DB, we cannot hard code here
                    if (ItemCategory == "Food" || ItemCategory == "Medicine")
                    {
                        return 5;
                    }
                    else if (ItemCategory == "Imported")
                    {
                        return 18;
                    }
                    else if (ItemCategory == "Clothes")
                    {
                        if(price>1000)
                        {
                            return 12;
                        }
                        return 10;
                    }
                    else if (ItemCategory == "Music")
                    {
                        return 3;
                    }
                    return 0;
                }
            }

            set { }
        }
        

        public double FinalPrice 
        {
            get;

            set;
        }


    }


    
    public class BOM
    {
        public BOM()
        {
            BOMCommodities = new List<ICommodity>();
        }
       public DateTime DateTime { get; set; }

       public List<ICommodity> BOMCommodities { get; set; }

       public double TotalAmount { get; set; }
    }
}
