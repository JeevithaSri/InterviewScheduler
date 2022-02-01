create table Roles(
ID int identity(1,1) primary key ,
Rolename varchar(30) not null,
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 

)

select * from Roles


create table Users(
ID int identity(1,1) primary key ,
RoleId int not null CONSTRAINT RFK FOREIGN KEY (RoleId) 
REFERENCES Roles(ID),
Username varchar(30) not null,
Password varchar(30) not null,
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)





select * from Users


create table UserDetails(
ID int identity(1,1) primary key ,
UserID int not null CONSTRAINT UDFK FOREIGN KEY (UserID) 
REFERENCES Users (ID),
Name varchar(30) not null,
DOB date not null,
Email varchar(30) not null,
Address varchar(50) not null,
Mobileno varchar(12) not null,
Skills varchar(50) not null
)

alter table Users 
drop column Rolename
select * from UserDetails


create table Job(
ID int identity(1,1) primary key ,
JobRole varchar(20) not null,
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)

alter table Job
add Available int

select * from Job


create table InterviewLevel(
ID int identity(1,1) primary key ,
Level varchar(30) not null,
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)

alter table InterviewLevel
add Description varchar(50)

select * from InterviewLevel



create table Candidate(
ID int identity(1,1) primary key ,
Name varchar(30) not null,
DOB date not null,
Address varchar(50) not null,
Mobileno varchar(12) not null,
Qualification varchar(15) not null,
Email varchar(30) not null,
LevelID int not null CONSTRAINT CLFK FOREIGN KEY (LevelID) 
REFERENCES InterviewLevel (ID),
JobID int not null CONSTRAINT CJFK FOREIGN KEY (JobID) 
REFERENCES Job (ID),
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)

select * from Candidate

alter table Candidate
add Resume varbinary(max) 


create table Panel(
ID int identity(1,1) primary key ,
Name varchar(30) not null,

Email varchar(30) not null,
Mobileno varchar(12) not null,
LevelID int not null CONSTRAINT PLFK FOREIGN KEY (LevelID) 
REFERENCES InterviewLevel (ID),
JobID int not null CONSTRAINT PJFK FOREIGN KEY (JobID) 
REFERENCES Job (ID),
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)


alter table Panel
drop constraint PJFK

alter table Panel
drop constraint PLFK

alter table Panel
drop column JobId

alter table Panel
drop column LevelId

alter table Panel
add JobRole varchar(20)

alter table Panel
add Level varchar(10)



select * from Panel


create table PanelAvailability(
ID int identity(1,1) primary key ,
Panel_id int not null CONSTRAINT PFK FOREIGN KEY (Panel_id) 
REFERENCES Panel (ID), 
Name varchar(30) not null,
AvailableDate date not null,
AvailableTimeFrom time not null,
AvailableTimeTo time not null,
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)

select * from PanelAvailability


create table CandidateAvailability(
ID int identity(1,1) primary key ,
CandidateID int not null CONSTRAINT CFK FOREIGN KEY (CandidateID) 
REFERENCES Candidate(ID), 
Name varchar(30) not null,
AvailableDate date not null,
AvailableTimeFrom time not null,
AvailableTimeTo time not null,
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)

select * from CandidateAvailability


create table Schedule(
ID int identity(1,1) primary key ,
Candidate_id int not null CONSTRAINT CFK1 FOREIGN KEY (Candidate_id) 
REFERENCES Candidate(ID), 
Panel_id int not null CONSTRAINT PFK1 FOREIGN KEY (Panel_id) 
REFERENCES Panel (ID), 
LevelID int not null CONSTRAINT SLFK FOREIGN KEY (LevelID) 
REFERENCES InterviewLevel (ID),
Date date not null,
TimeFrom time not null,
TimeTo time not null,
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)

select * from Schedule


create table InterviewStatus(
ID int identity(1,1) primary key ,
ScheduleID int not null CONSTRAINT SFK FOREIGN KEY (ScheduleID) 
REFERENCES Schedule(ID), 
Status varchar(15),
created_at DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
modified_at DATETIME2 
)

select * from InterviewStatus
