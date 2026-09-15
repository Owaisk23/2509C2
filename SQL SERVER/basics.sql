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
INSERT INTO Employee VALUES('Hanzala', 'Software Developer', 78000, 'Karachi', null);

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