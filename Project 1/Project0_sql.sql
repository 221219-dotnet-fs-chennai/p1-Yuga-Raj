CREATE SCHEMA project;


-- skills table start

CREATE TABLE project.skills(
    [skill_id] INT NOT NULL IDENTITY(1,1),
    skill_name VARCHAR(256)  NOT NULL,
    skill_experience INT NOT NULL,
    PRIMARY KEY([skill_id]),
    us_id INT NOT NULL,

    CONSTRAINT FK_usid_skill FOREIGN KEY(us_id)
    REFERENCES project.[user](user_id)

);
    -- CONSTRAINT FK_EmpDetails_Emp FOREIGN KEY(EmployeeID)
    -- REFERENCES FORQC.Employee([Id])

-- view skills table
select * FROM project.skills;


-- insert into skills
INSERT INTO project.skills(skill_name,skill_experience,us_id)
VALUES('full stack developer',10,2);

-- truncate skills
TRUNCATE TABLE project.skills;

--Drop table
DROP TABLE project.skills;

-- skills table end


-- Education table Start

-- Education table creation
CREATE TABLE project.edu(
    edu_id INT NOT NULL IDENTITY(1,1),
    institution_name VARCHAR(256) NOT NULL,
    course_name VARCHAR(256) NOT NULL,
    [start_date] DATE NOT NULL,
    [end_date] DATE NOT NULL,
    cgpa VARCHAR(10) NOT NULL,
    PRIMARY KEY(edu_id),
    us_id INT NOT NULL,
    CONSTRAINT FK_usid_edu FOREIGN KEY(us_id)
    REFERENCES project.[user](user_id)
);

-- View edu table
SELECT * FROM project.edu;

-- insert values to edu table
INSERT INTO project.edu(institution_name,course_name,[start_date],[end_date],cgpa,us_id)
VALUES('msajce','Electronics and comm engineering','2018-08-04','2022-06-04','8.1',2);

--truncate for edu
truncate TABLE project.edu;

--drop edu table
drop TABLE project.edu;
-- education table end


-- company table start

-- create table
CREATE TABLE project.comp(
    comp_id INT NOT NULL IDENTITY(1,1),
    comp_name VARCHAR(256) NOT NULL,
    about VARCHAR(100) NOT NULL,
    [start_date] DATE NOT null,
    [end_date] DATE NOT NULL,
    PRIMARY KEY(comp_id),
    us_id INT NOT NULL,

    CONSTRAINT FK_usid_Comp FOREIGN KEY(us_id)
    REFERENCES project.[user](user_id)
);

-- view comp table
SELECT * FROM project.comp;

-- insert into table

INSERT INTO project.comp(about,comp_name,[start_date],[end_date],[us_id])
VALUES('Reputed Company,Career Development','Revature','2022-12-19','2023-02-01','2');

-- truncate comp table
TRUNCATE TABLE project.comp;
-- drop comp table
drop TABLE project.comp;

-- end of comp table


-- start of user table
-- create user table
CREATE TABLE project.[user](
    user_id INT NOT NULL IDENTITY(1,1),
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    email_id VARCHAR(100) NOT NULL,
    [password] VARCHAR(20) NOT NULL,
    phone_no int NOT NULL,
    PRIMARY KEY(user_id)
);


drop TABLE project.[user];

SELECT * FROM project.[user];



-- All Select statements 
SELECT * From project.[user];
SELECT * From project.[skills];
SELECT * From project.[edu];
SELECT * From project.[comp];

-- insertion of values

INSERT into project.[user](first_name,last_name,email_id,[password],phone_no)
VALUES('Yuga','Raj','yugaraj31@gmail.com','987654321','861051669');

INSERT into project.[user](first_name,last_name,email_id,[password],phone_no)
VALUES('Yuvraj','Singh','yuvrajsingh12@gmail.com','987654321','861051669');

INSERT into project.[user](first_name,last_name,email_id,[password],phone_no)
VALUES('Randy','Orton','randyorton@gmail.com','987654321','861051669');

INSERT into project.skills(skill_name,skill_experience,us_id)
VALUES('Trainer',10,2);

ALTER TABLE project.[user] ALTER COLUMN phone_no bigint;

-- Login Check
SELECT * FROM project.[user]
WHERE email_id = 'yugaraj31@gmail.com' and password = '987654321';


--Add Skill Check
INSERT into project.skills(skill_name,skill_experience,us_id)
VALUES('Java',10,3);


-- Skill of particular user
select k.skill_id,k.skill_name,k.skill_experience from project.Skills as k
WHERE k.us_id = 2;

-- Skill Update Statement
-- UPDATE table_name
-- SET column1 = value1, column2 = value2, ...
-- WHERE condition;

UPDATE project.skills
SET skill_name = 'helloworld', skill_experience = 21
WHERE skill_id = 12;


-- delete a skill

SELECT * FROM project.skills;
DELETE FROM project.skills 
WHERE skill_id = 12

