CREATE TABLE Article(
	Id Int primary key identity(1,1),
	Name_Article Varchar(250) NOT NULL,
	Brand Varchar(250) NOT NULL,
	Price Decimal(16,2) NOT NULL,
	Quantity int NOT NULL,

	CategoryId Int NOT NULL,
	SupplierId Int NOT NULL,

	FOREIGN KEY (CategoryId) REFERENCES CategoryArticle(Id),
	FOREIGN KEY (SupplierId) REFERENCES Supplier(Id)
)





