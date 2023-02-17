CREATE TABLE Ticket(
	Id Int primary key identity(1,1),
	DateCreation DateTime NOT NULL,
	PriceHtva Decimal(18,2) NOT NULL,
	PriceTTC Decimal(18,2) NOT NULL,
)