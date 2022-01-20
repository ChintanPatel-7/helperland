--Create Heplperland Command

Create database HelperLand

-- Table 1 : User

Create table [User]
(
	UserId		int				PRIMARY KEY NOT NULL IDENTITY(1,1),
	FirstName	varchar(50)		NOT NULL,
	LastName	varchar(50),
	Email		varchar(250)	NOT NULL UNIQUE,
	MobileNo	varchar(15),
	Password	varchar(20)		NOT NULL,
	AvtarImage	varchar(250),
	Gender		varchar(10),
	DateOfBirth	Date,
	IsActive	bit				NOT NULL DEFAULT 1,
	IsPetAtHome	bit,
	Natinality	varchar(25),
	DateOfRegistration	DateTime NOT NULL,
	Distance	decimal(5,2)	DEFAULT 25
);

-- Table 2 : UserRole

Create table [UserRole]
(
	UserId		int				FOREIGN KEY REFERENCES [User](UserID) NOT NULL,
	RoleName	varchar(25)		NOT NULL
);

-- Table 3 : Address

Create table [Address]
(
	AddressId	int				PRIMARY KEY NOT NULL IDENTITY(1,1),
	StreetName	varchar(100)	NOT NULL,
	HouseNumber	varchar(25)		NOT NULL,
	PostalCode	varchar(10)		NOT NULL,
	City		varchar(50)		NOT NULL,
	PhoneNumber	varchar(15)		NOT NULL
);

-- Table 4 : UserAddress

Create table [UserAddress]
(
	UserID		int				FOREIGN KEY REFERENCES [User](UserID) NOT NULL,
	AddressID	int				FOREIGN KEY REFERENCES [Address](AddressId) NOT NULL
);

-- Table 5 : Service

Create table [Service]
(
	ServiceID	int				PRIMARY KEY NOT NULL IDENTITY(1,1),
	Date		Date			NOT NULL,
	IsPet		bit				NOT NULL DEFAULT 0,
	AddressId	int				NOT NULL FOREIGN KEY REFERENCES [Address](AddressId),
	TotalAount	Decimal(10,2)	NOT NULL,
	Distance	Decimal(5,2),
	ServiceActionId	int			NOT NULL FOREIGN KEY REFERENCES [ServiceAction](ServiceActionId),
	ServiceProviderId	int		NOT NULL FOREIGN KEY REFERENCES [User](UserID),
	CustomerId	int				NOT NULL FOREIGN KEY REFERENCES [User](UserID)
);

-- Table 6 : ExtraServices

Create table [ExtraServices]
(
	ExtraServicesId		int			PRIMARY KEY NOT NULL IDENTITY(1,1),
	ServiceID			int			NOT NULL FOREIGN KEY REFERENCES [Service](ServiceID),
	ExtraServicesName	varchar(30) NOT NULL
);

-- Table 7 : ServiceAction

Create table [ServiceAction]
(
	ServiceActionId		int		PRIMARY KEY NOT NULL IDENTITY(1,1),
	ServiceActionName	Varchar(30) NOT NULL
);

-- Table 8 : ResheduleServices

Create table [ResheduleServices]
(
	ResheduleServicesId	int			PRIMARY KEY NOT NULL IDENTITY(1,1),
	ServiceId			int			NOT NULL FOREIGN KEY REFERENCES [Service](ServiceID),
	Text				varchar(500)
);

-- Table 9 : ServiceFeedBack

Create table [ServiceFeedback]
(
	ServiceFeedbackId	int				PRIMARY KEY NOT NULL IDENTITY(1,1),
	OnTimeArrival		Decimal(3,1)	NOT NULL,
	Friendly			Decimal(3,1)	NOT NULL,
	QualityOfService	Decimal(3,1)	NOT NULL,
	TotalRating			Decimal(3,1)	NOT NULL,
	Text				varchar(500),
	ServiceId			int				NOT NULL FOREIGN KEY REFERENCES [Service](ServiceID)
);

-- Table 10 : ContactUsDetail

Create table [ContactUsDetail]
(
	Id			int				PRIMARY KEY NOT NULL IDENTITY(1,1),
	FirstName	varchar(50)		NOT NULL,
	LastName	varchar(50),
	Mobile		varchar(15),
	Email		varchar(250)	NOT NULL UNIQUE,
	Subject		varchar(50)		NOT NULL,
	Message		varchar(500)	NOT NULL
);