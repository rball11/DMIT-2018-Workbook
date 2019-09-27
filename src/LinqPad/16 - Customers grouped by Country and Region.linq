<Query Kind="Expression">
  <Connection>
    <ID>a6d005d1-8751-4e00-96d3-6b4b4c4ca9bf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the customers grouped by country and region.
from row in Customers
group row by new 
{ 
	Nation = row.Address.Country, 
	row.Address.Region 
} 
into CustomerGroups

select new
{
   Key = CustomerGroups.Key,
   Country = CustomerGroups.Key.Country,
   Region = CustomerGroups.Key.Region,
   Customers = from data in CustomerGroups
               select new
               {
                   Company = data.CompanyName,
                   City = data.Address.City
               }
}