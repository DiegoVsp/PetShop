CREATE DATABASE PETSHOP;

USE PETSHOP;

CREATE TABLE CLIENTE(
CODCLI INT PRIMARY KEY auto_increment NOT NULL,
NOME VARCHAR(30) NOT NULL,
CPF VARCHAR(15) NOT NULL,
CEP VARCHAR(10),
ENDERECO VARCHAR(40),
CIDADE VARCHAR(30),
NUMERO VARCHAR(10),
TELEFONE VARCHAR(15) NOT NULL,
EMAIL VARCHAR(50)
);

CREATE TABLE PET(
CODPET INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
CODCLIENTE INT NOT NULL,
NOME VARCHAR(20) NOT NULL,
ESPECIE VARCHAR(20),
RACA VARCHAR(20),
PORTE VARCHAR(20),
SEXO VARCHAR(10),
COR VARCHAR(20),
FOREIGN KEY (CODCLI) REFERENCES CLIENTE(CODCLI)
);

CREATE TABLE SERVICO(
CODSERV INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
TIPO VARCHAR(20),
PORTE VARCHAR(20),
VALOR DECIMAL(7,2)
);

CREATE TABLE FUNCIONARIO(
CODFUNC INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
NOME VARCHAR(30)NOT NULL,
CPF VARCHAR(15) NOT NULL,
CEP VARCHAR(10),
ENDERECO VARCHAR (40),
CIDADE VARCHAR(30),
NUMERO VARCHAR(10),
TELEFONE VARCHAR (15) NOT NULL,
CARTTRAB VARCHAR(15),
SALARIO DECIMAL(7,2)
);

CREATE TABLE ATENDIMENTO(
CODATEND INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
CODSERV INT NOT NULL,
CODPET INT NOT NULL,
CODFUNC INT NOT NULL,
DATAHORA DATETIME,
SITUACAO VARCHAR(20),
FOREIGN KEY (CODSERV) REFERENCES SERVICO(CODSERV),
FOREIGN KEY (CODPET) REFERENCES PET(CODPET),
FOREIGN KEY (CODFUNC) REFERENCES FUNCIONARIO(CODFUNC)
);