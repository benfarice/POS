create table Categories(
	id int identity(1,1) not null primary key,
	name varchar(500) not null
)
create table products(
	id int identity(1,1) not null primary key,
	name varchar(500) not null,
	image_url varchar(500),
	barcode varchar(500)
)
alter table products
add cat_id int foreign key references Categories(id)
create table employe(
	id int identity(1,1) not null primary key,
	name varchar(500) not null,
	pass_word varchar(4),
	role_is_admin int,
	phone varchar(100),
	email varchar(100)
)
create table restaurant_table(
	id int identity(1,1) not null primary key,
	number int
)
--drop table arrive_sortis
create table arrive_sortis(
	heur int,
	minute_ int,
	jour int,
	mois int,
	time_spend_in_minutes int,
	is_in int,
	id_employe int foreign key references employe(id),
	constraint mykey primary key(jour,mois,id_employe,minute_)
)
create table customer(
	id int identity(1,1) not null primary key,
	name varchar(500) not null,
	phone varchar(100),
	email varchar(100)
)
--drop table the_order
create table the_order(
	id int identity(1,1) not null primary key,
	employe_id int foreign key references employe(id),
	customer_id int foreign key references customer(id),
	restaurant_table int foreign key references restaurant_table(id),
	has_payed int,
	how_much_customers int
)
create table Ordre_details(
	id int identity(1,1) not null primary key,
	product_id int foreign key references products(id),
	order_id int foreign key references the_order(id),
	options varchar(800),
	Quantite float not null
)