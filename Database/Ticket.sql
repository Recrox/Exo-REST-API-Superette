CREATE TABLE Ticket(
	Id Int primary key identity(1,1),
	DateCreation DateTime NOT NULL,
	PriceHtva Decimal NOT NULL,
	PriceTTC Decimal NOT NULL,
)