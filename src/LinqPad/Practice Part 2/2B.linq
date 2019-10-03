<Query Kind="Expression">
  <Connection>
    <ID>e076134a-52b5-423d-8e02-29a44a57cdc8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// B) List all the Customers by Company Name. Include the Customer's company name, contact name, and other contact information in the result.
from customer in Customers
select new
{
	CompanyName = customer.CompanyName,
	ContactName = customer.ContactName,
	ContactTitle = customer.ContactTitle,
	ContactEmail = customer.ContactEmail,
	Phone = customer.Phone,
	Fax = customer.Fax
}