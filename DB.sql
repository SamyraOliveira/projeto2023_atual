EXECUTE xp_create_subdir 'C:\DBEstamparia' 
GO 
 
CREATE DATABASE Estamparia
ON PRIMARY ( 
NAME = 'Arquivo_Principal', 
FILENAME = 'C:\DBEstamparia\Arquivo_Principal.mdf', SIZE = 5 MB, 
FILEGROWTH = 10% 
), 
FILEGROUP FG1 ( 
NAME = 'Arquivo_Dados', 
FILENAME = 'C:\DBEstamparia\Arquivo_Dados.ndf', 
SIZE = 3 MB, 
FILEGROWTH = 10% 
) 
LOG ON ( 
NAME = 'Arquivo_Log', 
FILENAME = 'C:\DBEstamparia\Arquivo_Log.ldf', 
SIZE = 1 MB, 
FILEGROWTH = 10% 
) 
GO 
 
EXECUTE xp_dirtree 'C:\DBEstamparia', 10, 1 
GO 
 
USE Estamparia 
GO 
 
CREATE TABLE Colaboradores ( 
codigo_Colaborador INT PRIMARY KEY NOT NULL,
CPF_Colaborador VARCHAR(11) NOT NULL, 
cargo_Colaborador VARCHAR (256) NOT NULL,
telefone_Colaborador VARCHAR (256) NOT NULL, 
email_Colaborador VARCHAR (256) NOT NULL, 
estado_Colaborador VARCHAR (256) NOT NULL, 
cidade_Colaborador VARCHAR (256) NOT NULL, 
endereco_Colaborador VARCHAR (256) NOT NULL, 
bairro_Colaborador VARCHAR (256) NOT NULL, 
CEP_Colaborador VARCHAR (8) NOT NULL, 
nome_Colaborador VARCHAR (256) NOT NULL, 
dataNasc_Colaborador DATE NOT NULL, 
user_Colaborador VARCHAR (50) NOT NULL, 
password_Colaborador VARCHAR (1000) NOT NULL, 
status_Colaborador INT NOT NULL 
) 
GO 
 
SELECT * FROM Colaboradores go 
 
CREATE TABLE Fornecedores (
codigo_Fornecedor INT PRIMARY KEY NOT NULL, 
nomeAbreviado_Fornecedor VARCHAR (256) NOT NULL, 
CNPJ_Fornecedor VARCHAR (14) NOT NULL, 
CEP_Fornecedor VARCHAR (8) NOT NULL, 
endereco_Fornecedor VARCHAR (256) NOT NULL, 
cidade_Fornecedor VARCHAR (256) NOT NULL, 
estado_Fornecedor VARCHAR (256) NOT NULL, 
telefone_Fornecedor VARCHAR (11) NOT NULL, 
representante_Fornecedor VARCHAR (256) NOT NULL, 
email_Fornecedor VARCHAR (256) NOT NULL, 
status_Fornecedor INT NOT NULL 
) 
GO 
 
SELECT * FROM Fornecedores go 
 
CREATE TABLE Materiais( codigo_Material INT PRIMARY KEY NOT NULL,
codigo_Fornecedor INT FOREIGN KEY  
REFERENCES Fornecedores (codigo_Fornecedor) NOT NULL, 
nome_Material VARCHAR (256) NOT NULL,
quantidade_Material INT NOT NULL, 
preco_Material DECIMAL(10,8) NOT NULL, 
status_Material INT NOT NULL 
) 
GO 
 
SELECT * FROM Materiais go 
 
CREATE TABLE Clientes ( 
codigo_Cliente INT PRIMARY KEY NOT NULL,
nome_Cliente VARCHAR (256) NOT NULL,
CPFCNPJ_Cliente VARCHAR (14) NOT NULL, 
telefone_Cliente VARCHAR (11) NOT NULL,
email_Cliente VARCHAR (256) NOT NULL,
dataNasc_Cliente DATE NOT NULL,
estado_Cliente VARCHAR (256) NOT NULL,
cidade_Cliente VARCHAR (256) NOT NULL,
endereco_Cliente VARCHAR (256) NOT NULL,
CEP_Cliente VARCHAR (8) NOT NULL,
status_Cliente INT NOT NULL 
) go 
 
SELECT * FROM Clientes go 
 
CREATE TABLE Pedidos ( codigo_Pedido INT PRIMARY KEY NOT NULL, 
codigo_Cliente INT FOREIGN KEY  
REFERENCES Clientes (codigo_Cliente) NOT NULL,
codigo_Colaborador INT FOREIGN KEY 
REFERENCES Colaboradores (codigo_Colaborador) NOT NULL, 
codigo_Material INT FOREIGN KEY 
REFERENCES Materiais (codigo_Material) NOT NULL, 
tipoGola_Pedido VARCHAR (256) NOT NULL, 
corCamiseta_Pedido VARCHAR (256) NOT NULL, 
tamP_quant_Pedido INT , 
tamM_quant_Pedido INT , 
tamG_quant_Pedido INT, 
totalCamisetas_Pedido INT NOT NULL, 
estampa_Pedido IMAGE NOT NULL, 
nome_Material VARCHAR (256) NOT NULL, 
data_Pedido DATE, 
valorUnit_Pedido DECIMAL (10,8) NOT NULL, 
valorTotal_Pedido DECIMAL (10,8) NOT NULL, 
valorEntrada_Pedido DECIMAL (10,8) NOT NULL, 
nome_Cliente VARCHAR (256) NOT NULL/*, 
status_Pedido INT NOT NULL*/ 
) 
go 	 
 
SELECT * FROM Pedidos go 
