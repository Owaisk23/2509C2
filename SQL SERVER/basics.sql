-- create DB
create database "2509C2";

-- use DB
use "2509C2";

-- delete database
DROP DATABASE "2509C2";

-- table creation
CREATE TABLE Employee(
	id INT PRIMARY KEY IDENTITY(1,1),
	empName VARCHAR(255) NOT NULL,
	designation VARCHAR(255) NOT NULL,
	salary INT NOT NULL,
	city VARCHAR(255) NOT NULL,
	deptId INT
);
-- Single record insert
INSERT INTO Employee VALUES('Abu Bakar', 'DBA', 128000, 'Hyderabad', null);

-- Read Table records
SELECT * FROM Employee;

-- Single record insert
INSERT INTO Employee(empName, designation, salary, city, deptId) VALUES
('Imran', 'QA Developer', 80000, 'Lahore', null),
('Anwar', 'Backend Developer', 88000, 'Lahore', null),
('Rayyan', 'Product Manager', 128000, 'Islamabad', null),
('Nabeel', 'Frontend Developer', 82000, 'Karachi', null),
('Farmil', 'Senior Marketing Agent', 90000, 'Islamabad', null),
('Fasiha', 'UIUX Designer', 75000, 'Karachi', null),
('Sidrah', 'Mob App Developer', 178000, 'Multan', null);

-- DISTINCT difference
SELECT DISTINCT city FROM Employee;

-- DELETE Record
DELETE FROM Employee where id = 1;

-- Update records
Update Employee set salary = 75000 where city = 'Karachi';

Update Employee set empName='Taha', designation='Product Manager' where id=2;

-- where clause 

SELECT empName, designation from Employee where designation='Product Manager'; 

-- not

SELECT empName, designation from Employee where not designation='Product Manager'; 

-- AND

SELECT empName, designation, salary from Employee where not designation='Product Manager'
AND salary <= 88000; 


-- OR

SELECT id, empName, designation, salary from Employee where not designation='Product Manager'
OR salary <= 88000; 

SELECT id, empName, designation, salary from Employee where designation='Product Manager'
OR salary <= 88000; 

SELECT id, empName, designation, salary from Employee where not designation='Product Manager'
OR salary > 88000;

-- between

SELECT * FROM Employee where id between 2 and 6;

-- like && SEARCH QUERY %K%
SELECT * FROM Employee where city like '%Ka%';

SELECT * FROM Employee where designation like '%Mob%';

SELECT * FROM Employee where city like '%I%' AND designation like '%Senior%';

-- IN
SELECT * FROM Employee where city IN ('Islamabad');

-- Order By
SELECT * FROM Employee order by empName asc;


SELECT * FROM Employee order by salary desc;

-- Top
SELECT top 4 * FROM Employee;

SELECT top 70 percent * FROM Employee;

-- aggregate functions

SELECT COUNT(empName) as total_employees FROM Employee;

SELECT MIN(salary) as min_salary FROM Employee;

SELECT MAX(salary) as max_salary FROM Employee;

SELECT SUM(salary) as total_salary FROM Employee;

SELECT AVG(salary) as avg_salary FROM Employee;

SELECT CONCAT(empName, ' has a designation of ', designation, ' has salary of ', salary)
as EmpDetails from Employee;

-- SUB QUERIES
SELECT empName, salary FROM Employee where salary < (SELECT AVG(salary)
as avg_salary FROM Employee);

--GROUP BY

SELECT city, COUNT(id) as EmpCount FROM Employee GROUP BY city;

SELECT city, MAX(salary) as MaxSalary FROM Employee GROUP BY city;

SELECT city, MIN(salary) as MinSalary FROM Employee GROUP BY city;

SELECT city, SUM(salary) as TotalSalary FROM Employee GROUP BY city;

INSERT INTO Employee(empName, designation, salary, city, deptId) VALUES
('Bisma', 'MANAGER', 265000, 'Karachi', null),
('Iqra', 'MANAGER', 190000, 'Lahore', null),
('Humaira', 'MANAGER', 330000, 'Islamabad', null);

SELECT designation, COUNT(id) as EmpCount FROM Employee
GROUP BY designation having designation = 'MANAGER';

-- NEW TABLE OF DEPARTMENT

CREATE TABLE Department(
deptId INT PRIMARY KEY IDENTITY(1,1),
deptName VARCHAR(50) NOT NULL
);

INSERT INTO Department VALUES 
('Academics'),('SRO'), ('TECH'), ('Marketing'), ('Exam');

SELECT * FROM Department;


INSERT INTO Department VALUES 
('Placement'),('Admin');

SELECT * FROM Employee;

TRUNCATE TABLE Department;

DROP TABLE Employee;

-- table creation
CREATE TABLE Employee(
	id INT PRIMARY KEY IDENTITY(1,1),
	empName VARCHAR(255) NOT NULL,
	designation VARCHAR(255) NOT NULL,
	salary INT NOT NULL,
	city VARCHAR(255) NOT NULL,
	deptId INT,
	FOREIGN KEY (deptId) references Department(deptId)
	-- FK     own table key   ref    tablename(tablekey)
);


INSERT INTO Employee(empName, designation, salary, city, deptId) VALUES
('Ahad', 'CAH', 480000, 'Karachi', 1),
('Imran', 'Faculty Member', 80000, 'Karachi', 1),
('Anwar', 'Network Assistant', 88000, 'Karachi', 3),
('Rayyan', 'Admin Manager', 128000, 'Karachi', 7),
('Nabeel', 'SRO Head', 82000, 'Karachi', 2),
('Farmil', 'Senior Marketing Agent', 90000, 'Karachi', 4),
('Fasiha', 'Batch Coordinator', 75000, 'Karachi', 1),
('Sidrah', 'Manager Academics', 178000, 'Karachi', 1),
('Bisma', 'Examination Head', 265000, 'Karachi', 5),
('Iqra', 'DCAH', 190000, 'Karachi', 1),
('Humaira', 'SRO', 330000, 'Karachi', 2);

SELECT empName, designation, deptName, city, salary FROM Employee as emp
INNER JOIN Department as d on emp.deptId = d.deptId;

SELECT empName, designation, deptName, city, salary FROM Employee as emp
LEFT JOIN Department as d on emp.deptId = d.deptId;

SELECT empName, designation, deptName, city, salary FROM Employee as emp
RIGHT JOIN Department as d on emp.deptId = d.deptId;

SELECT empName, designation, deptName, city, salary FROM Department as d 
LEFT JOIN Employee as emp  on  d.deptId = emp.deptId;

SELECT empName, designation, deptName, city, salary FROM Department as d 
RIGHT JOIN Employee as emp  on  d.deptId = emp.deptId;

SELECT empName, designation, deptName, city, salary FROM Department as d 
FULL OUTER JOIN Employee as emp  on  d.deptId = emp.deptId;

INSERT INTO Employee(empName, designation, salary, city) VALUES
('Ahad', 'CAH', 480000, 'Karachi');

-- Views
SELECT empName, designation FROM Employee;

CREATE VIEW [empDesignationName]
AS
SELECT empName, designation FROM Employee;

SELECT * FROM empDesignationName;


CREATE VIEW [deptNames]
AS
SELECT deptName FROM Department;

SELECT * FROM deptNames;

SELECT name, create_date FROM sys.views;

DROP VIEW empDeptNames;

-- DCL: Data Control Language

SELECT * FROM sys.sql_logins;

CREATE LOGIN ACC_EMP WITH PASSWORD='555';

CREATE USER ACC_EMP FROM LOGIN ACC_EMP;
 
-- IZAJAT = GRANT
GRANT SELECT on dbo.Employee TO ACC_EMP;

GRANT INSERT, DELETE on dbo.Employee TO ACC_EMP;

-- REVOKE
REVOKE SELECT on dbo.Employee TO ACC_EMP;

DROP LOGIN ACC_EMP;

-- STORED PROCEDURES

CREATE PROCEDURE SeeEmp
AS
BEGIN
SELECT * FROM Employee
END;

SeeEmp;

CREATE PROCEDURE SeeEmp6
AS
BEGIN
SELECT * FROM Employee where id=6
END;

SeeEmp6;

CREATE PROCEDURE AddEmp @Name varchar(255), @desig varchar(255), @sal int, @city varchar(65),
@dId int 
AS
BEGIN
INSERT INTO Employee VALUES (@Name, @desig, @sal, @city, @dId)
SELECT * FROM Employee
END;

AddEmp @Name='Taha', @desig='Manager', @sal=156000, @city='Isl', @dId=6;


AddEmp @Name='Maha', @desig='Senior SQA', @sal=96000, @city='ISB', @dId=1;

-- TRIGGER 
CREATE TRIGGER AddEmp_trigger
ON Employee FOR INSERT
AS
BEGIN
print('a new employee added successfully.')
END;

--ALTER
ALTER TRIGGER AddEmp_trigger
ON Employee FOR INSERT
AS
BEGIN
SELECT * FROM inserted
END;

INSERT INTO Employee(empName, designation, salary, city) VALUES
('Saad', 'Frontend Deveoper', 88000, 'Karachi');

DROP TRIGGER AddEmp_trigger;

CREATE TABLE EmpLogs(
	logid int PRIMARY KEY identity(1,1),
	ActionPerformed nvarchar(255)
);

SELECT * FROM EmpLogs;

SELECT * into Test From Employee;

SELECT * FROM Test;

-- TRIGGER 
CREATE TRIGGER AddEmp_trigger
ON Employee AFTER INSERT
AS
BEGIN
DECLARE @Id int, @name varchar(65)
SELECT @Id=id, @name=empName FROM inserted
INSERT INTO EmpLogs VALUES(@name + ' having ID = '
+ CAST(@Id as varchar(6)) + ' is added at ' + 
CAST(GETDATE() as varchar(30)))
END;


SELECT * FROM Employee where emp_status=0;

ALTER TABLE Employee ADD emp_status int default(1)
NOT NULL;

CREATE TRIGGER Soft_Delete
ON Employee
INSTEAD OF DELETE
AS
BEGIN 
DECLARE @ID int
SELECT @ID=id FROM Deleted
Update Employee set emp_status=0 where id=@ID
END;

DELETE FROM Employee where id=4;





 -- Update Trigger
 CREATE Trigger Update_Employees
 On Employee
 for Update
 as
 begin
DECLARE @Id int
DECLARE @Newname varchar(60), @Oldname varchar(60)
DECLARE @Newsalary int,  @Oldsalary int
DECLARE @NewDesignation varchar(60),@OldDesignation varchar(60)
DECLARE @Newdeptid int,  @Olddeptid int
DECLARE @Newcity varchar(60), @Oldcity varchar(60)
DECLARE @AuditString varchar(255)

SELECT * into #Temptable from inserted
WHILE(exists (SELECT id from #Temptable))
begin
SELECT @Id=id, @Newname=empName, @Newsalary=salary, @NewDesignation=designation,@Newcity=city,@Newdeptid=deptId FROM #Temptable
SELECT  @Oldname=empName, @Oldsalary=salary, @OldDesignation=designation,@Oldcity=city,@Olddeptid=deptId FROM deleted where id=@Id
SET @AuditString =''
SET @AuditString ='An employee having id = '+ CAST(@Id as varchar(6))+' on '+  CAST(GETDATE() as varchar(30))+' is changed '
if(@Oldname <> @Newname)
SET @AuditString = @AuditString + ' its name from '+@Oldname +' to '+ @Newname

if(@Oldsalary <> @Newsalary)
SET @AuditString = @AuditString + ' its salary from '+CAST(@Oldsalary as varchar(10)) +' to '+CAST(@Newsalary as varchar(10))

if(@OldDesignation <> @NewDesignation)
SET @AuditString = @AuditString + ' its designation from '+@OldDesignation +' to '+ @NewDesignation

if(@Oldcity <> @Newcity)
SET @AuditString = @AuditString + ' its city from '+@Oldcity +' to '+ @Newcity

if(@Olddeptid <> @Newdeptid)
SET @AuditString = @AuditString + ' its deptid from '+CAST(@Olddeptid as varchar(10)) +' to '+CAST(@Newdeptid as varchar(10))
 Insert into Emplogs values(@AuditString)
 DELETE FROM #Temptable where id=@Id
end
 end;


 select * from Employee;
 update Employee set city='Lahore' where id > 7;
 select * from Emplogs;

 -- Transactions 
 -- ddl- data definition language (create , alter, drop)
 -- dml-data manipulation language (insert,update,delete, select)
 -- dcl-data control languages (grant/revoke)
 -- tcl- transaction control language. (ROLLBACK/ COMMIT)

 -- ACID properties.
 
-- A => Atomicity -- all the steps are fully completed or not a single step will execute.
-- C => Consistency -- all the nodes in a network should be aware of the transaction.
-- I => Isolation -- one transaction's info should not be known to another transaction.
-- D => Durability -- changes after transaction should be saved.

-- Integrity
Begin Transaction
Update Employee set empName='Khurram' where id= 1;
Commit Transaction;-- save changes

Rollback Transaction;-- wapis

BEGIN TRANSACTION
BEGIN try 
Update Employees set empName='chakwal' where id= 1/0;
print('Commited Successfully.')
COMMIT TRANSACTION
End try
BEGIN catch
print('Rolled back Successfully.')
Rollback Transaction
END catch;