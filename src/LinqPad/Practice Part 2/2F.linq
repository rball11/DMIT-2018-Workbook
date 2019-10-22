<Query Kind="Expression">
  <Connection>
    <ID>8af4b037-de64-4731-986a-fb3e0756e755</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// F) List all the Suppliers, by Country
from vendor in Suppliers
group vendor by vendor.Address.Country into nationalSuppliers
select new
{
	Country = nationalSuppliers.Key,
	Suppliers = from company in nationalSuppliers
				select company.CompanyName
}