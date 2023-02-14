CREATE TABLE Article(
	Id Int primary key identity(1,1),
	Name_Article Varchar(250) NOT NULL,
	Brand Varchar(250) NOT NULL,
	Price Decimal NOT NULL,
	Quantity int NOT NULL,
	--CategoryId Int NOT NULL,
	--FOREIGN KEY (CategoryId) REFERENCES CategoryArticle(Id)
)

--ALTER TABLE Article
--Add COLUMN CategoryId Int NOT NULL,
--Add COLUMN FOREIGN KEY (CategoryId) REFERENCES CategoryArticle(Id)





