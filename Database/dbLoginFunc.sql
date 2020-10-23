create database bdJapanori;
use bdJapanori;

create table tbFuncionario (
idFunc int primary key auto_increment,
nomeFunc varchar(50),
datanascFunc varchar(20),
emailFunc varchar(50),
cpfFunc varchar(15),
rgFunc varchar(15),
cepFunc varchar(10),
dataadmissaoFunc varchar(20),
datademissaoFunc varchar(20),
cargoFunc varchar(50),
permFunc int,
statusFunc varchar(25)
);
drop table tbFuncionario;
select * from tbFuncionario;

insert into tbFuncionario(nomeFunc,datanascFunc,emailFunc,cpfFunc,rgFunc,cepFunc,
dataadmissaoFunc,datademissaoFunc,cargoFunc,permFunc,statusFunc) values (
"Administrador",
"05/10/2000",
"admin@gmail.com",
"cpfAdmin",
"rgAdmin",
"cepAdmin",
"20/08/2020",
"",
"CEO",
2,
"On"
);

create table tbLogin (
idLogin int primary key auto_increment,
idFunc int references tbFuncionario(idFunc),
Usuario varchar(50),
Senha varchar(12),
statusLogin varchar(25)
);

drop table tbLogin;
select * from tbLogin;

insert into tbLogin(idFunc,Usuario,Senha,statusLogin) values (
2,
"admin@gmail.com",
"admin123",
"On"
);
