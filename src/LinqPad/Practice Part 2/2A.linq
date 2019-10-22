<Query Kind="Expression">
  <Connection>
    <ID>8af4b037-de64-4731-986a-fb3e0756e755</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// A) Group employees by region and show the results in this format:
/* ----------------------------------------------
 * | REGION        | EMPLOYEES                  |
 * ----------------------------------------------
 * | Eastern       | ------------------------   |
 * |               | | Nancy Devalio        |   |
 * |               | | Fred Flintstone      |   |
 * |               | | Bill Murray          |   |
 * |               | ------------------------   |
 * |---------------|----------------------------|
 * | ...           |                            |
 * 
 */
 
from region in Regions
select new
{
	Region = region.RegionDescription,
	Employees = (from area in region.Territories
				from manager in area.EmployeeTerritories
				select manager.Employee.FirstName + " " + manager.Employee.LastName)
				.Distinct(),
	Employees2 = from area in region.Territories
				 from manager in area.EmployeeTerritories
				 group manager by manager.Employee into areaManagers
				 select areaManagers.Key.FirstName + " " + areaManagers.Key.LastName
}


