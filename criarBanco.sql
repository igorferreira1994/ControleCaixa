CREATE DATABASE ControleCaixa;
GO
USE ControleCaixa;
GO
CREATE TABLE ControleCaixa.dbo.Pedido
    (
      ID INT IDENTITY(1,1) PRIMARY KEY,
      DataPedido DATETIME ,
      Descricao VARCHAR(255),
	   Valor DECIMAL(10,2) ,
      Lancamento VARCHAR(10),	  
    );

		
