use bdJapanori;

create table tbComanda (
idComanda int primary key,
situacaoComanda varchar(15),
statusComanda varchar(20)
);
create table tbProduto (
idProduto int primary key auto_increment,
nomeProduto varchar(50),
descProduto varchar(200),
precoProduto varchar(10),
statusProduto varchar(20)
);
create table tbComandaProduto (
idComanda int references tbComanda(idComanda),
idProduto int references tbProduto(idProduto)
);
create table tbEstoque (
idItem int primary key auto_increment,
nomeItem varchar(50),
qntItem int,
tipoQntItem varchar(15),
datacarregamento varchar(20),
statusItem varchar(20)
);
create table tbProdutoEstoque (
idProduto int references tbProduto(idProduto),
idItem int references tbEstoque(idItem)
);
/*create table tbVenda (
idVenda int primary key auto_increment
dataVenda
idFunc int references tbFuncionario(idFunc),
idtipoPag int references tbPagamento(idtipoPag),
statusVenda varchar(20)
);

create table tbVendaComandaProduto (
idVenda int references tbVenda(idVenda),
idComanda int references tbComanda(idComanda),
idProduto int references tbProduto(idProduto)
);
*/
create table tbPagamento (
idtipoPag int primary key auto_increment,
tipoPag varchar(20) not null,
parcelamento varchar(20) not null,
statusPag varchar(20)
);

select * from tbComanda;
select * from tbProduto;
select * from tbComandaProduto;
select * from tbEstoque;
select * from tbProdutoEstoque;
select * from tbPagamento;
drop table tbComanda;
drop table tbProduto;
drop table tbComandaProduto;
drop table tbEstoque;
drop table tbProdutoEstoque;
drop table tbPagamento;

insert into tbComanda values(1002,"Vazia","On");
insert into tbProduto(nomeProduto,descProduto,precoProduto,statusProduto) values (
"Coca-Cola 350ml",
"Coca-Cola Latinha",
"5",
"On");
insert into tbComandaProduto values(1001,3);
insert into tbEstoque(nomeItem,qntItem,tipoQntItem,datacarregamento,statusItem) values (
"Coca-Cola Lata",
"50",
"Unidades",
"23/10/2020",
"On");
insert into tbProdutoEstoque(idProduto,idItem) values(3,4);

/* SELECT COMANDA SEM O PREÇO TOTAL */
select c.idComanda,
	c.situacaoComanda,
	cp.Itens
from tbComanda c,
	(select idProduto, count(*) Itens
	from tbComandaProduto
	group by idComanda) cp
where c.situacaoComanda = "Ativa" and
c.idComanda = cp.idComanda;

