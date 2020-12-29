using azuga_test.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azuga_test
{
    public interface IBOMService
    {
        BOM GetBOM(List<Commodity> commodities);
    }

    public class BOMService : IBOMService
    {
        BOM _bom = new BOM();
        double finalPrice = 0;
        public BOM GetBOM(List<Commodity> commodities)
        {

            _bom.DateTime = DateTime.Now;
            
            //For every commodity add the item 
            for(var i=0;i<commodities.Count;i++)
            {
                commodities[i].FinalPrice = AddTax(commodities[i].price, commodities[i].TaxRate);
                finalPrice += commodities[i].FinalPrice;
                _bom.BOMCommodities.Add(commodities[i]);
            }

            //supposed to be done in DB

            AddAdditionalTax();
            SortItemsByName();
            _bom.TotalAmount = finalPrice;
            return _bom;
        }

        public double GetTaxRate(Commodity typeofCommodity)
        {
            double taxRate = 0;
            if(typeofCommodity is Food)
            {
                taxRate=((Food)typeofCommodity).TaxRate;
            }
            return taxRate;
        }

        public void SortItemsByName()
        {
            _bom.BOMCommodities=_bom.BOMCommodities.OrderBy(p=>p.Item).ToList();
        }

        public void AddAdditionalTax()
        {
            if (finalPrice > 2000)
            {
                finalPrice = AddTax(finalPrice, 5);
            }
        }

        public double AddTax(double price, double TaxRate)
        {
            return price + ((price * TaxRate) / 100);
        }
    }
}
