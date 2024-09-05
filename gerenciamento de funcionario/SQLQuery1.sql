Create table emplyees
(
	id int primary key identity(1,1),
	id_funcionario varchar(max) null,
	full_name varchar(max) null,
	genero varchar(max) null,
	numero_contato varchar(max) null,
	posisao varchar(max) null,
	image varchar(max) null,
	salario int null,
	insert_date date null,
	update_date date null,
	delete_date date null,

) 

select * from emplyees

alter table emplyees
add status varchar(max) null