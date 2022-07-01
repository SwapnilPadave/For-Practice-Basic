CREATE DATABASE FORPRACTICE

CREATE TABLE CUSTOMER
(
  CustomerID int primary key identity,
  CustomerName nvarchar (100) Not Null,
  ContactNumber nvarchar(20) Not Null,
  [Address] nvarchar(100) Not Null,
  City nvarchar(100) Not Null,
  PostalCode nvarchar(100) Not Null,
  Country nvarchar(100) Not Null
)

CREATE TABLE ORDERS
(
  OrderID int primary key identity,
  CustomerID int,
  FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID),
  EmployeeID nvarchar(100) Not Null,
  OrderDate date Not Null,
  ShipperID nvarchar(100) Not Null  
)

--Inserting Values into Customer Table

INSERT INTO CUSTOMER VALUES('Swapnil Padave','9773129135','Byculla','Mumbai','400010','India');
INSERT INTO CUSTOMER VALUES('Nilesh Pathak','8676345687','Ghatkopar','Mumbai','400123','India');
INSERT INTO CUSTOMER VALUES('Vijay Panjabi','9876543987','Virar','Navi Mumbai','400867','India');
INSERT INTO CUSTOMER VALUES('Sanket Bankar','7869546301','Parel','Mumbai','400012','India');
INSERT INTO CUSTOMER VALUES('Saurabh Shetye','9978645430','Andheri','Mumbai','400045','India')

--Inserting Values into Orders Table

INSERT INTO ORDERS VALUES(3,'V111','2022-05-25','V11126052022');
INSERT INTO ORDERS VALUES(1,'S999','2022-03-09','S99909032022');
INSERT INTO ORDERS VALUES(5,'S123','2022-01-11','S12311012022');
INSERT INTO ORDERS VALUES(2,'N099','2021-04-19','N09919042022');
INSERT INTO ORDERS VALUES(4,'S400','2022-06-21','S40021062022');

SELECT * FROM CUSTOMER
SELECT * FROM ORDERS

--INNER JOIN--
SELECT * FROM CUSTOMER
INNER JOIN ORDERS
ON CUSTOMER.CustomerID=ORDERS.OrderID

--LEFT JOIN--
SELECT CUSTOMER.CustomerName,CUSTOMER.Country ,ORDERS.OrderID,ORDERS.OrderDate
FROM CUSTOMER
LEFT JOIN ORDERS ON CUSTOMER.CustomerID = ORDERS.CustomerID
ORDER BY CUSTOMER.CustomerName;

--RIGHT JOIN--
SELECT ORDERS.OrderID, CUSTOMER.CustomerName, CUSTOMER.Country
FROM ORDERS
RIGHT JOIN CUSTOMER ON ORDERS.CustomerID = CUSTOMER.CustomerID
ORDER BY ORDERS.OrderID;

--FULL JOIN--
SELECT CUSTOMER.CustomerName, ORDERS.OrderID
FROM CUSTOMER
FULL OUTER JOIN ORDERS ON CUSTOMER.CustomerID=ORDERS.CustomerID
ORDER BY CUSTOMER.CustomerName;

--SELF JOIN--
SELECT A.CustomerName AS CustomerName1, B.CustomerName AS CustomerName2, A.City
FROM CUSTOMER A, CUSTOMER B
WHERE A.CustomerID <> B.CustomerID
AND A.City = B.City
ORDER BY A.City;

select * from CUSTOMER
Select * from ORDERS

