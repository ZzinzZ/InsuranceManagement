create database Insurance

use Insurance

CREATE TABLE Role (
    RoleId VARCHAR(20) PRIMARY KEY,
    RoleName VARCHAR(255)
);

CREATE TABLE TypeInsurance (
    InsuranceTypeId VARCHAR(20) PRIMARY KEY,
    NameType VARCHAR(255),
	CoverageAmount DECIMAL(10, 2),
    Deductible DECIMAL(10, 2),
    PremiumRate DECIMAL(5, 2),
    PolicyLimit DECIMAL(10, 2)
);



CREATE TABLE Employee (
    UserId VARCHAR(20) PRIMARY KEY,
    Email VARCHAR(255) NOT NULL UNIQUE,
	EmployName NVARCHAR(50),
    Password VARBINARY(MAX) NOT NULL,
    RoleId VARCHAR(20) NOT NULL,
    InsuranceTypeId VARCHAR(20),
    FOREIGN KEY (RoleId) REFERENCES Role(RoleId),
    FOREIGN KEY (InsuranceTypeId) REFERENCES TypeInsurance(InsuranceTypeId)
);


CREATE TABLE Customer (
    CustomerId VARCHAR(20) PRIMARY KEY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Password VARBINARY(MAX) NOT NULL,
    Name VARCHAR(255) NOT NULL,
    Gender VARCHAR(10),
    BirthDay DATE,
    WorkPlace VARCHAR(255),
    PerAddress VARCHAR(255),
    TempAddress VARCHAR(255),
    MedicalHistory VARCHAR(255),
	hashInfomation VARBINARY(MAX),
	PublicKey VARBINARY(MAX)
);


CREATE TABLE Contract (
    ContractId VARCHAR(20) PRIMARY KEY,
    CreatorId VARCHAR(20) NOT NULL,
    CustomerId VARCHAR(20) NOT NULL,
    InsuranceTypeId VARCHAR(20) NOT NULL,
	TermLength INT,
    StartDay DATE,
    EndDay DATE,
    TotalPrice DECIMAL(10, 2),
	PaymentType NVARCHAR(50),
    Status VARCHAR(50),
	Signature VARBINARY(MAX),
    FOREIGN KEY (CreatorId) REFERENCES Employee(UserId),
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    FOREIGN KEY (InsuranceTypeId) REFERENCES TypeInsurance(InsuranceTypeId)
);

CREATE TABLE InsurancePaid (
    ContractId VARCHAR(20) NOT NULL,
    LastPaymentDate DATE,
    NextPaymentDueDate DATE,
    TotalPaid DECIMAL(10, 2),
    NumberOfPayments INT,
    FOREIGN KEY (ContractId) REFERENCES Contract(ContractId)
);



CREATE TABLE Invoice (
    InvoiceId VARCHAR(20) PRIMARY KEY,
    CreateDay DATE,
    AccountantId VARCHAR(20),
    ContractId VARCHAR(20),
    Total DECIMAL(10, 2),
    FOREIGN KEY (AccountantId) REFERENCES Employee(UserId),
    FOREIGN KEY (ContractId) REFERENCES Contract(ContractId)
);

CREATE TABLE ActionMonitor (
    ActionId VARCHAR(20) PRIMARY KEY,
    SupervisorId VARCHAR(20),
    Actor VARCHAR(20),
    Time DATETIME,
    ActionDesc TEXT,
    FOREIGN KEY (SupervisorId) REFERENCES Employee(UserId),
	FOREIGN KEY (Actor) REFERENCES Employee(UserId)
);


select * from Role