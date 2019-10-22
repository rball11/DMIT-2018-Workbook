<Query Kind="Expression">
  <Connection>
    <ID>8af4b037-de64-4731-986a-fb3e0756e755</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// E) Group all customers by city. Output the city name, aalong with the company name, contact name and title, and the phone number.
from company in Customers
group company by company.Address.City into customersByCity
select new
{
	City = customersByCity.Key,
	Customers = from buyer in customersByCity
				select new
				{
					 buyer.CompanyName,
					 buyer.ContactName,
					 buyer.ContactTitle,
					 buyer.Phone
				}
}