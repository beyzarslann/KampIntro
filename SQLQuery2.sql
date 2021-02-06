--Select
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers 

Select * from Customers where City = 'London'

--case insensitive
Select * from Products where categoryId=1 or categoryId=3 

Select * from Products where categoryId=1 and UnitPrice>=10

Select * from Products order by ProductName
Select * from Products order by CategoryID,ProductName
Select * from Products where categoryId=1 order by UnitPrice asc --ascending-artan  --descending-desc-düşen

select count(*) from Products
select count(*) from Products where CategoryID=2

select categoryId, count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10 

--DTO Data Transformation Object 
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
 
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
