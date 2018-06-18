create table Transactions(transactionID int primary key identity(1,1)
,TransactionDate date)
go
create table TransactionItem (TransactionItemID int primary key identity(1,1),
 TransctionID int foreign key references Transactions(transactionID),
 ProductID int foreign key references products(id))