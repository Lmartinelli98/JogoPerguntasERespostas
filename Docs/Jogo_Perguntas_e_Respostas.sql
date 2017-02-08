create database db_PerguntasERespostas

use db_PerguntasERespostas

create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)



insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

create table tb_Perguntas(
    id int identity primary key,
    pergunta varchar(max),
    resposta_correta varchar(max),
    id_Jogador int,
    data    datetime default getdate()
    )
    
    insert into tb_Perguntas(pergunta, resposta_correta)
    values('Quanto é 4 + 3?','7')
    
    --retorna o ultimo identity inserido
    
    select @@IDENTITY
    
    select @@SERVERNAME
    
    
    --deleta um id especifico na tabela--
    delete from tb_Jogador where id = 1
    
    --insere um novo id na tabela--
    insert into tb_Jogador(nome) values('Ramom')
    
    --deleta dados da tabela--
    delete from tb_Jogador
    
    --limpa tabela e zera o campo identity--
    truncate table tb_Jogador
    
        select * from tb_Jogador where id_jogador = 2
        
        select * from tb_Perguntas
        
        alter table tb_perguntas add  id_Jogador int
    
       select * from tb_Jogador join tb_Perguntas on tb_Jogador.id = tb_Perguntas.id_Jogador
