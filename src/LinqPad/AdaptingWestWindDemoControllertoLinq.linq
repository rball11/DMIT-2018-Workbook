<Query Kind="Expression">
  <Connection>
    <ID>e076134a-52b5-423d-8e02-29a44a57cdc8</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

from cat in Categories //removed context. for Linq
select new // ProductCategory
{
 CategoryName = cat.CategoryName,
 Description = cat.Description,
 Picture = cat.Picture.ToImage(), //remove .ToImage() for VS
 MimeType = cat.PictureMimeType,
 Products = from item in cat.Products
            select new // ProductSummary
            {
                Name = item.ProductName,
                Price = item.UnitPrice,
                Quantity = item.QuantityPerUnit
            }
}