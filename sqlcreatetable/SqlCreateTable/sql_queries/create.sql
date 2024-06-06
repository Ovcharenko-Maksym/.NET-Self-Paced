CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Position VARCHAR(100) NOT NULL
);

CREATE TABLE Project (
    ProjectID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL UNIQUE,
    CreationDate DATE NOT NULL,
    Status TEXT NOT NULL,
    ClosureDate DATE
);

CREATE TABLE Task (
    TaskID INT PRIMARY KEY,
    ProjectID INT,
    Description TEXT NOT NULL,
    Deadline DATE NOT NULL,
    Status TEXT NOT NULL,
    DateSetStatus DATE NOT NULL,
    EmployeeID INT,
    FOREIGN KEY (ProjectID) REFERENCES Project(ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE Employee_Project (
    EmployeeProjectID INT PRIMARY KEY,
    EmployeeID INT,
    ProjectID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (ProjectID) REFERENCES Project(ProjectID)
);

CREATE TABLE Task_Employee (
    TaskEmployeeID INT PRIMARY KEY,
    TaskID INT,
    EmployeeID INT,
    FOREIGN KEY (TaskID) REFERENCES Task(TaskID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE Task_Status (
    TaskStatusID INT PRIMARY KEY,
    Status TEXT NOT NULL UNIQUE
);

CREATE TABLE Project_Status (
    ProjectStatusID INT PRIMARY KEY,
    Status TEXT NOT NULL UNIQUE
);