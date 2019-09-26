<Query Kind="Expression">
  <Connection>
    <ID>e076134a-52b5-423d-8e02-29a44a57cdc8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

from company in Suppliers
select new
{
    Supplier = company.CompanyName,
	Contact = company.ContactName,
	Phone = company.Phone,
    Products = from item in company.Products
	select new
	{
		ProductName = item.ProductName,
		CategoryName = item.Category.CategoryName,
		UnitPrice = item.UnitPrice,
		QuantityPerUnit = item.QuantityPerUnit
	}
}