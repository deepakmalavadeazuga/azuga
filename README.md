tbl_commodities

	{

		"item": "Perfume",

		"itemCategory": "Imported",

		"quantity": 1,

		"price": 4000

	},

	{

		"item": "Black Swan",

		"itemCategory": "Book",

		"quantity": 1,

		"price": 300

	}



====================================


tbl_taxrates

[
{

		"itemCategory": "Clothes",
                "taxRate":5,
                "additionalTax" : {
                 "threshold": 1000,
                 "tax":7
                }

]


select c.item,c.itemCategory,t.taxRate


