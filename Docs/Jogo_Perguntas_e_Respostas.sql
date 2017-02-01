create database db_PerguntasERespostas

use db_PerguntasERespostas

create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)

select * from tb_Jogador

insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

create table tb_Perguntas(
    id int identity primary key,
    pergunta varchar(max),
    resposta_correta varchar(max),
    data    datetime default getdate()
    )
    
    select * from tb_Perguntas
    
    insert into tb_Perguntas(pergunta, resposta_correta)
    values('Quanto é 4 + 3?','7')
    
    select * from tb_Jogador
    
    --deleta um id especifico na tabela--
    delete from tb_Jogador where id = 1
    
    --insere um novo id na tabela--
    insert into tb_Jogador(nome) values('Ramom')
    
    --deleta dados da tabela--
    delete from tb_Jogador
    
    --limpa tabela e zera o campo identity--
    truncate table tb_Jogador
