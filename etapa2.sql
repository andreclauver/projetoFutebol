create database etapa2;
use etapa2;

create table ator(
id integer unsigned auto_increment not null,
nome varchar(80) not null,
email varchar(100) not null,
data_ultima_alteracao date not null,
primary key(id)
)engine=innodb;

insert into ator(id,nome,email,data_ultima_alteracao)
values (null,'Rafael','rafael@gmail.com','2021/1/1');

DELIMITER $$

create procedure prc_verid(in id int)
begin
  select * from ator where id=id;
  end
  $$
  CALL prc verid(1);
  
  DELIMITER $$
  
  create procedure prc_listar_id(in nome varchar(50), in id int)
  begin
  select * from ator where nome_ator=nome and id=id;
  end
  $$
  call prc_listar_id('Jorge',1);