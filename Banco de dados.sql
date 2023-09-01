create table Cliente(

idCliente int identity,

nomeCliente varchar(35)not null,

senha char(6) not null,

cpf char(11) not null,

rg char(9) not null,

dataNascimento char(8) not null,

email varchar(50) not null,

logindecliente char(11) not null,

sexo varchar(50)not null,

cidade varchar(50) not null,

estado varchar(50) not null,

constraint pk_Cliente primary key (idCliente),

constraint uk_cpf unique (cpf),

constraint uk_loginCliente unique (logindecliente)

)

 

 

create table Conta(

idConta int identity,

idCliente int not null,

saldo decimal not null,

tipoConta varchar(20) not null,

statusConta varchar(10) not null,

senhaConta char(6) not null

constraint pk_Conta primary key (idConta)

constraint fk_Conta_Cliente foreign key (idCliente) references Cliente(idCliente)

constraint ck_Conta_StatusConta check(statusConta in('aberto','fechado'))

)

 

 

 

create table Movimentação(

idMovimentacao int identity,

idTipoOperacao int not null,

valor decimal not null,

dataHora datetime not null

)

 

 

 

create table TipoOperacao(

idTipoOperacao int identity,

nomeOperacao varchar(12) not null

constraint pk_TipoOperacao primary key (idTipoOperacao)

)

 

 

 

create table MovimentaçãoAgendada(

idMovimentacaoAgendada int identity,

idConta int not null,

idTipoOperacao int not null,

valor decimal not null,

dataAgenda datetime not null,

statusAgendamento varchar(20)not null,

constraint pk_MovimentacaoAgendada primary key(idMovimentacaoAgendada),

constraint fk_MovimentacaoAgendada_Conta foreign key(idConta) references Conta (idConta),

constraint fk_MovimentacaoAgendada_TipoOperacao foreign key(idTipoOperacao) references TipoOperacao(idTipoOperacao)

)

use jucabancoartur(

create procedure ps_buscaContasPorIdCliente
@idCliente int 
as
select * from conta
where idCliente = @idCliente
exec ps_buscaContasPorIdCliente 1

create procedure psValidaLogin_48
@cpf chat (11),
@senha chat (6),
as
select * from cliente, 
where cpf=@cpf and senha=@senha
exec psValidaLogin_48 '11122233334','123456',


create procedure psValidaLogin_48
@cpf char(11),
@senha char(6),
as
select * from cliente,
where cpf=@cpf and senha=@senha,


create procedure psValidaLogin_48

select * from cliente

insert into Conta
values ('1,','31/12/2006','21/04/2023','110000','Poupança','aberto')


create procedure pi_Correntista
@nomecorrentista varchar(50),
@dataNascimento datetime,
@logradouro varchar(50),
@numero varchar(5),
@complemento varchar(10),
@cidade varchar(60),
@estado char(2),
@cpf char(11),
@senha char(6),
@celular char(11)
as
insert into Cliente
values (@nomecorrentista,@dataNascimento,@logradouro,
@numero,@complemento,@cidade,@estado,@cpf,@senha,@celular)



