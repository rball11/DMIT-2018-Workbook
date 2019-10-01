<Query Kind="Expression">
  <Connection>
    <ID>8af4b037-de64-4731-986a-fb3e0756e755</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Practice questions - do each one in a separate LinqPad query.


//A) List all the customer company names for those with more than 5 orders.
from person in Customers
where person.Orders.Count >= 5
select person.CompanyName
//B) Get a list of all the region names
from region in Regions
select region.RegionDescription
//C) Get a list of all the territory names
from territory in Territories
select territory.TerritoryDescription
//D) List all the regions and the number of territories in each region
from region in Regions
select new
{
	region.RegionDescription,
	NOofTerritories = region.Territories.Count
}
//E) List all the region and territory names in a "flat" list
from data in Territories
select new
{
   Region = data.Region.RegionDescription,
   Territory = data.TerritoryDescription
}
//F) List all the region and territory names as an "object graph"
//   - use a nested query
from data in Regions
select new
{
   Region = data.RegionDescription,
   Territory = from territory in data.Territories select territory.TerritoryDescription
}
//G) List all the product names that contain the word "chef" in the name.
from product in Products
				 where product.ProductName.Contains("Chef")
				 select product.ProductName
//H) List all the discontinued products, specifying the product name and unit price.
from product in Products
				 where product.Discontinued.Equals(1)
				 select new
				 {
					 product.ProductName,
					 product.UnitPrice
				 }
//I) List the company names of all Suppliers in North America (Canada, USA, Mexico)
from row in Suppliers
where row.Address.Country.Contains("Canada") || row.Address.Country.Contains("USA") || row.Address.Country.Contains("Mexico")
group row by new 
{ 
	Nation = row.Address.Country
} 
into SupplierGroups

select new
{
   Key = SupplierGroups.Key,
   Suppliers = from data in SupplierGroups
               select new
               {
                   Company = data.CompanyName,
				   Country = data.Address.Country
               }
}