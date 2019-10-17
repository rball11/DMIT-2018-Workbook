<Query Kind="Expression">
  <Connection>
    <ID>e076134a-52b5-423d-8e02-29a44a57cdc8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

from sale in Orders
//where sale.Payments.Count == 0
where sale.OrderDate.Value.Month == 5
	&& sale.OrderDate.Value.Year == 2018
select new //sale
{
	Customer = sale.Customer.CompanyName,
	ResponseTime = sale.RequiredDate.Value - sale.OrderDate.Value,
	PaymentDueOn = sale.PaymentDueDate,
	FirstPayment = sale.Payments.First().PaymentDate,
	PaymentResponseTime = sale.Payments.First().PaymentDate - sale.PaymentDueDate.Value
}