<Query Kind="Expression">
  <Connection>
    <ID>e076134a-52b5-423d-8e02-29a44a57cdc8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// C) List all the employees and sort the result in ascending order by last name, then first name. Show the employee's first and last name separately, along with the number of customer orders they have worked on.
from emp in Employees
orderby emp.LastName ascending, emp.FirstName ascending
select new
{
	FirstName = emp.FirstName,
	LastName = emp.LastName,
	Orders = emp.SalesRepOrders.Count
}
