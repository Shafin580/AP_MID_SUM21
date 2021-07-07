CREATE TABLE [Admins] (
	Id int NOT NULL IDENTITY(1,1),
	Name nvarchar(35) NOT NULL,
	Username nvarchar(35) NOT NULL UNIQUE,
	Email nvarchar(35) NOT NULL UNIQUE,
	Password nvarchar(50) NOT NULL,
  CONSTRAINT [PK_ADMINS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Customers] (
	Id int NOT NULL IDENTITY(1,1),
	Name nvarchar(35) NOT NULL,
	Username nvarchar(35) NOT NULL UNIQUE,
	Email nvarchar(35) NOT NULL UNIQUE,
	Password nvarchar(50) NOT NULL,
	PhoneNumber bigint UNIQUE,
  CONSTRAINT [PK_CUSTOMERS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Couriers] (
	Id int NOT NULL IDENTITY(1,1),
	Name nvarchar(35) NOT NULL,
	Username nvarchar(35) NOT NULL UNIQUE,
	Email nvarchar(35) NOT NULL UNIQUE,
	Password nvarchar(50) NOT NULL,
	PhoneNumber bigint NOT NULL UNIQUE,
	NID nvarchar(150) NOT NULL,
	Registered bit NOT NULL DEFAULT '0',
	Availability bit NOT NULL DEFAULT '0',
  CONSTRAINT [PK_COURIERS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Categories] (
	Id int NOT NULL IDENTITY(1,1),
	CategoryName nvarchar(20) NOT NULL UNIQUE,
  CONSTRAINT [PK_CATEGORIES] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Products] (
	Id int NOT NULL IDENTITY(1,1),
	ProductName nvarchar(50) NOT NULL,
	ProductPrice float NOT NULL,
	CategoryId int NOT NULL,
	ProductDetail nvarchar(80) NOT NULL,
	Picture nvarchar(150),
	FlavourId int NOT NULL,
  CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Details] (
	Id int NOT NULL IDENTITY(1,1),
	CourierId int,
	TransactionId int NOT NULL,
  CONSTRAINT [PK_DETAILS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Transactions] (
	Id int NOT NULL IDENTITY(1,1),
	CustomerId int NOT NULL,
	DeliveryLocation nvarchar(100) NOT NULL,
	CustomerContactNumber bigint NOT NULL,
	DeliveryDate date NOT NULL,
	ProductId int NOT NULL,
	ProductQty bit NOT NULL,
	DeliveryCharge float NOT NULL DEFAULT '0',
	AdvancePaid float NOT NULL DEFAULT '0',
	TotalPrice float NOT NULL,
	DeliveryStatus bit NOT NULL DEFAULT '0',
	TransactionNumber bigint,
  CONSTRAINT [PK_TRANSACTIONS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Logins] (
	LoginId int NOT NULL IDENTITY(1,1),
	LoginUsername nvarchar(35) NOT NULL UNIQUE,
	LoginEmail nvarchar(35) NOT NULL UNIQUE,
	LoginPassword nvarchar(50) NOT NULL,
	UserType nvarchar(20) NOT NULL,
  CONSTRAINT [PK_LOGINS] PRIMARY KEY CLUSTERED
  (
  [LoginId] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Menus] (
	Id int NOT NULL IDENTITY(1,1),
	FlavourName nvarchar(30) NOT NULL UNIQUE,
	FlavourDetail nvarchar(250) NOT NULL,
	Price float NOT NULL,
  CONSTRAINT [PK_MENUS] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO




ALTER TABLE [Products] WITH CHECK ADD CONSTRAINT [Products_fk0] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Products] CHECK CONSTRAINT [Products_fk0]
GO
ALTER TABLE [Products] WITH CHECK ADD CONSTRAINT [Products_fk1] FOREIGN KEY ([FlavourId]) REFERENCES [Menus]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Products] CHECK CONSTRAINT [Products_fk1]
GO

ALTER TABLE [Details] WITH CHECK ADD CONSTRAINT [Details_fk0] FOREIGN KEY ([CourierId]) REFERENCES [Couriers]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Details] CHECK CONSTRAINT [Details_fk0]
GO
ALTER TABLE [Details] WITH CHECK ADD CONSTRAINT [Details_fk1] FOREIGN KEY ([TransactionId]) REFERENCES [Transactions]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Details] CHECK CONSTRAINT [Details_fk1]
GO

ALTER TABLE [Transactions] WITH CHECK ADD CONSTRAINT [Transactions_fk0] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Transactions] CHECK CONSTRAINT [Transactions_fk0]
GO
ALTER TABLE [Transactions] WITH CHECK ADD CONSTRAINT [Transactions_fk1] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [Transactions] CHECK CONSTRAINT [Transactions_fk1]
GO



