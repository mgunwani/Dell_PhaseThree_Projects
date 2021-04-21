
-- Create New Database

	CREATE DATABASE DellDB

-- USE Database

	USE DellDB

-- Create New Table Named 'Department' under DellDB

	CREATE TABLE Department
	(DeptId INT PRIMARY KEY,
	DeptName VARCHAR(200) NOT NULL,
	DeptLocation VARCHAR(200), 
	DeptAddedDate DATETIME DEFAULT GETDATE())

-- Insert Departments into Department Table:

	INSERT INTO Department VALUES(101, 'Sales', 'Delhi', '2020-01-01');
	INSERT INTO Department VALUES(102, 'Marketing', 'Chennai', '2020-01-01');
	INSERT INTO Department VALUES(103, 'Testing', 'Delhi', '2020-01-01');
	INSERT INTO Department VALUES(104, 'Development', NULL, '2020-01-01');
	INSERT INTO Department VALUES(105, 'Administration', 'Chennai', DEFAULT);
	INSERT INTO Department(DeptId, DeptName, DeptLocation) VALUES(106, 'Advertisment', 'Delhi');
	INSERT INTO Department(DeptName, DeptId) VALUES('Training', 107);

-- Create New Table Named 'Employee' under DellDB

	CREATE TABLE Employee
	(EmpID INT PRIMARY KEY,
	EmpName VARCHAR(200) NOT NULL,
	EmpSalary FLOAT CHECK (EmpSalary > 5000),
	EmpEmail VARCHAR(200) UNIQUE,
	EmpCountry VARCHAR(200) DEFAULT 'India',
	HireDate DateTime DEFAULT GETDATE(),
	EmployeeAddedDate DateTime DEFAULT GETDATE(),
	DeptId INT FOREIGN KEY REFERENCES Department(DeptId))

-- Insert Employees into Employee Table:

	INSERT INTO Employee VALUES(5001, 'King', 20000, 'king@gmail.com', 'USA', '2020-12-01', '2020-12-01', 101)
	INSERT INTO Employee VALUES(5002, 'Kochhar', 40000, 'kochhar@gmail.com', DEFAULT, DEFAULT, '2020-12-01', 102)
	INSERT INTO Employee VALUES(5003, 'Shreya', 25000, 'shreya@gmail.com', 'USA', '2020-12-01', '2020-12-01', 101)
	INSERT INTO Employee VALUES(5004, 'Shruti', 15000, 'shruti@gmail.com', DEFAULT, DEFAULT, DEFAULT, 102)
	INSERT INTO Employee VALUES(5005, 'John', 35000, 'john@gmail.com', 'USA', '2020-12-01', '2020-12-01', 101)
	INSERT INTO Employee VALUES(5006, 'Sarah', 13000, 'sarah@gmail.com', 'USA', '2020-12-01', '2020-12-01', 101)
	INSERT INTO Employee VALUES(5007, 'James', 45000, 'james@gmail.com', DEFAULT, DEFAULT, DEFAULT, NULL)
	INSERT INTO Employee VALUES(5008, 'Roger', 35000, 'roger@gmail.com', DEFAULT, DEFAULT, DEFAULT, 103)
	INSERT INTO Employee VALUES(5009, 'Lee', 65000, 'lee@gmail.com', 'India', '2019-12-01', '2019-12-01', 103)
	INSERT INTO Employee VALUES(5010, 'Nick', 25000, 'nick@gmail.com', 'India', '2019-12-01', '2019-12-01', 102)

-- Retrieve Departments and Employees:

	SELECT * FROM Department;
	SELECT * FROM Employee;

-- Projection on Employee Table: (Retrieve Specific Columns)

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee;

-- Selection on Employee Table: (Retirive Records based on Condition)

	SELECT * 
	FROM Employee
	WHERE EmpSalary > 40000
	
-- Projection and Selection on Employee Table

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary > 40000

-- Arithmetic Operators: (+, -, *, /)

	SELECT EmpID, EmpName, EmpSalary, EmpSalary * 12 as Annual_Salary
	FROM Employee
	WHERE EmpSalary > 40000

	SELECT EmpID, EmpName, EmpSalary, EmpSalary * 12 "Annual Salary"
	FROM Employee
	WHERE EmpSalary > 40000

-- Comparison Operators: (>, >=, <, <=, =, !=)

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName != 'Kochhar'

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary > 20000

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary >= 20000 AND EmpSalary <= 40000

-- Misc Operators (BETWEEN, IN, LIKE, IS NULL)

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary BETWEEN 20000 AND 40000

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpSalary NOT BETWEEN 20000 AND 40000

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName = 'Kochhar' OR EmpName = 'King' OR EmpName = 'Lee'

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName IN ('Kochhar', 'King', 'Lee', 'Bhawna')

	SELECT EmpID, EmpName, EmpSalary
	FROM Employee
	WHERE EmpName NOT IN ('Kochhar', 'King', 'Lee', 'Bhawna')

	SELECT EmpID, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE DeptId IS NULL

	SELECT EmpID, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE DeptId IS NOT NULL

	SELECT EmpID, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE EmpName LIKE 'K%'

	SELECT EmpID, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE EmpName LIKE '%e'

	SELECT EmpID, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE EmpName LIKE 'K%r'

	SELECT EmpID, EmpName, EmpSalary, DeptId
	FROM Employee
	WHERE EmpName LIKE '__r%'

	/* Values are Case-Sensitive. Dates are Format Sensitive. */

-- Joining Two Tables:

-- Retrieve Employee Names and thier Department Names

	SELECT Employee.EmpName, Department.DeptName
	FROM Employee JOIN Department
	ON Employee.DeptId = Department.DeptId

	SELECT Employee.EmpName, Employee.EmpSalary, Department.DeptName, Department.DeptLocation
	FROM Employee JOIN Department
	ON Employee.DeptId = Department.DeptId

	SELECT e.EmpName, e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e JOIN Department d
	ON e.DeptId = d.DeptId

	SELECT e.EmpName, e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e LEFT OUTER JOIN Department d
	ON e.DeptId = d.DeptId

	SELECT e.EmpName, e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e RIGHT OUTER JOIN Department d
	ON e.DeptId = d.DeptId

	SELECT e.EmpName, e.EmpSalary, d.DeptName, d.DeptLocation
	FROM Employee e FULL OUTER JOIN Department d
	ON e.DeptId = d.DeptId

	SELECT * FROM Department;
	SELECT * FROM Employee;

-- Update All Records in Department Table:

	UPDATE Department
	SET DeptAddedDate = '2021-01-01'

-- Update Specific Records in Department Table:

	UPDATE Department
	SET DeptLocation = 'Hydrabad'
	WHERE DeptId IN(104, 107)

-- Delete All Records:

	DELETE FROM Department;

-- Delect Specific Records:
	
	DELETE FROM Department
	WHERE DeptId = 101;

-- Truncate the Table (Deletes all recrods except the table structure)

	TRUNCATE TABLE Department

-- DROP Table (Delete the records and structure from database)

	DROP TABLE Employee;

	DROP TABLE Department;

	
	