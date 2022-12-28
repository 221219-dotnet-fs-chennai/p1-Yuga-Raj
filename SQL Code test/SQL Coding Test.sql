CREATE SCHEMA Yuga;

create table Yuga.Department (
    [Id] INT NOT NUll,
    [Name] VARCHAR(60) NOT NULL,
    [Location] VARCHAR(60) NOT NULL,
    PRIMARY KEY ([Id])
);

--INSERT into Yuga.Department([Id],[FirstName],[LastName],[SSN],[Deptid]) 
--VALUES()

create table Yuga.Employee(
    [Id] INT NOT NULL IDENTITY(1,1),
    [FirstName] VARCHAR(60) NOT NULL,
    [LastName] VARCHAR(60) NOT NULL,
    [SSN] bigint NOT NULL,
    [DeptId] int,

    CONSTRAINT FK_Emp,Dept FOREIGN KEY (DeptId)
    REFERENCES Yuga.Department([Id]),

    PRIMARY KEY ([Id])
);

create table Yuga.EmpDetails(
    [Id] INT NOT NULL IDENTITY(1,1)
    [EmployeeId] INT,
    [Salary] int NOT NULL,
    [Address] VARCHAR(60) NOT NULL,
    [City] VARCHAR(60) NOT NULL,
    [State] VARCHAR(60) NOT NULL,
    [Country] VARCHAR(60) NOT NULl,

    PRIMARY KEY([Id]),

    CONSTRAINT FK_EmpDetails_Emp FOREIGN KEY (EmployeeId)
    REFERENCES Yuga.Employee([Id])
);

--Adding 3 records in each table
--Department table
 Insert into Yuga.Department([Id],[Name],[Location])
 VALUES('1','SOFT TEAM','CHENNAI'),('2','FINANCE','KERALA'),('3','MARKETING','BANGALORE');

 SELECT * FROM Yuga.Department;

 --Employee Table
 Insert into Yuga.Employee([FirstName],[LastName],[SSn],[DeptId])
 VALUES ('Yuga','raj',12345,1),('Najum','md',34567,2),('Tina','Smith',45678,3),('Randy','orton',56789,4);

 SELECT * FROM Yuga.Employee;

--Employee Details table
Insert into Yuga.EmployeeDetails([EmployeeId],[Salary],[Address],[City],[State],[Country])
VALUES (1,'1000','Mg road','Chennai','Tamilnadu','India'),
(2,'2000','Mg road', 'tenkasi','Tamilnadu','India'),
(3,'3000','Mg road', 'Ennore','Tamilnadu','India'),
(4,'4000','Mg road', 'Malapuram','Kerala','India');

-- selects
SELECT * FROM Yuga.Departments;
SELECT * FROM Yuga.Employee;
SELECT * FROM Yuga.EmployeeDetails;

--List Employee in marketing 
SELECT * FROM anbu.Employee as e1
INNER JOIN anbu.EmployeeDetails as e2
on e2.EmployeeId = e1.Id
WHERE e1.deptid = 3;

--total salary of marketing
SELECT sum(e2.Salary) totalsalary FROM Yuga.Employee as e1
INNER JOIN Yuga.EmployeeDetails as e2
on e2.EmployeeId = e1.Id
WHERE e1.DeptId = 3;

--total employee by Department
SELECT e1.DeptId, count(e1.FirstName) as 'no of employees' from Yuga.Employee as e1
GROUP by DeptId;

--increase salary of Tina to 90000
SELECT * FROM Yuga.EmployeeDetails;
UPDATE Yuga.EmployeeDetails;
SET Salary = 90000
WHERE EmployeeId = 3;

--normal
UPDATE Yuga.EmployeeDetails
SET Salary = 3000
WHERE EmployeeId = 3;