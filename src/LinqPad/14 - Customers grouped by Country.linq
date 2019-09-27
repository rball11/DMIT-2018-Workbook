<Query Kind="Expression">
  <Connection>
    <ID>a6d005d1-8751-4e00-96d3-6b4b4c4ca9bf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Display all the company names and contact names for our customers, grouped by country
from row in Customers
//		Customer	Table<Customer>
group  row   by   row.Address.Country
//	  Customer	  [		string		]
//    \what/      \       how       /
//				   \      Key      /

	into CustomersByCountry
//  IGrouping<string, Customer>

select new
{
   Country = CustomersByCountry.Key, 
// the key is "how" we have sorted the data
   Customers = from data in CustomersByCountry
               select new
               {
			       Company = data.CompanyName,
				   Contact = data.ContactName
               }
}