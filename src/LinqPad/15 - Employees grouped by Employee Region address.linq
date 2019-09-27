<Query Kind="Expression">
  <Connection>
    <ID>a6d005d1-8751-4e00-96d3-6b4b4c4ca9bf</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Display the Employees, grouped by the region in which the employee lives. Show the employee's first name, last name, and job title as separate properties within each group.
//TODO: Write the data types

from person in Employees
//   Employee	Table<Employees>
group person by person.Address.Region into EmployeeGroups
//	  Employee	Region					   
select new
{
    Region = EmployeeGroups.Key,
	Employee = from staff in EmployeeGroups
	           select new
               {
			       FirstName = staff.FirstName,
				   LastName = staff.LastName,
				   JobTitle = staff.JobTitle
               }
}