CREATE TABLE [ArticleTicket] (
    [Id] int IDENTITY(1,1),
    [ArticleId] int NOT NULL,
    [TicketId] int NOT NULL,
    [Quantity] int NOT NULL,

    --CONSTRAINT [PK_ArticleTicket] PRIMARY KEY ([ArticleId], [TicketId]),
    CONSTRAINT [PK_ArticleTicket] PRIMARY KEY ([Id]) ,
    CONSTRAINT [FK_ArticleTicket_Article_ArticleId] FOREIGN KEY ([ArticleId]) REFERENCES [Article] ([Id]),
    CONSTRAINT [FK_ArticleTicket_Ticket_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Ticket] ([Id])
);