Create Table Supplier(
	Id Int Identity(1,1),
	SupplierCode varchar(250) NOT NULL,
	Name varchar(250) NOT NULL,
	Country varchar(250) NOT NULL,
	EcoScore Int  NOT NULL,

	CONSTRAINT [PK_ArticleSupplier] PRIMARY KEY (Id)
	
);



    --CONSTRAINT [PK_ArticleTicket] PRIMARY KEY ([Id]) ,
    --CONSTRAINT [FK_ArticleTicket_Article_ArticleId] FOREIGN KEY ([ArticleId]) REFERENCES [Article] ([Id]),
    --CONSTRAINT [FK_ArticleTicket_Ticket_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Ticket] ([Id])