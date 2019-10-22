<Query Kind="Expression">
  <Connection>
    <ID>8af4b037-de64-4731-986a-fb3e0756e755</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// B) List all the companys sorted by Company Name. Include the company's company name, contact name, and other contact information in the result.
from company in Customers
select new
{
	CompanyName = company.CompanyName,
	Contact = new 
			  {
					Name = company.ContactName,
					Title = company.ContactTitle,
					Email = company.ContactEmail,
					Phone = company.Phone,
					Fax = company.Fax
			  }
}