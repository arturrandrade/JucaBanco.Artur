     
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
statusConta varchar(10) not null
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

use jucabancoartur

create procedure psValidaLogin_48
@cpf char (11),
@senha char(6)
as
select * from Cliente
where cpf=@cpf and senha=@senha

exec psValidaLogin_48 '1112222234','123456'
select * from conta
where idCliente=1
create procedure ps_buscaContasPorIdCorrentista_48 
@idCliente int
as
select * from conta
where idCliente=@idCliente
 
exec ps_buscaContasPorIdCorrentista_48 1