CREATE TABLE [dbo].[Usuario] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (255) CONSTRAINT [DF_Usuario_Nome] DEFAULT ('') NOT NULL,
    [CPF]            CHAR (11)     CONSTRAINT [DF_Usuario_CPF] DEFAULT ('') NOT NULL,
    [EMail]          VARCHAR (255) CONSTRAINT [DF_Usuario_EMail] DEFAULT ('') NOT NULL,
    [Telefone]       VARCHAR (20)  CONSTRAINT [DF_Usuario_Telefone] DEFAULT ('') NOT NULL,
    [Sexo]           CHAR (1)      CONSTRAINT [DF_Usuario_Sexo] DEFAULT ('O') NOT NULL,
    [DataNascimento] DATETIME      CONSTRAINT [DF_Usuario_DataNascimento] DEFAULT (((1753)/(1))/(1)) NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Usuario_Nome]
    ON [dbo].[Usuario]([Nome] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UX_Usuario_CPF]
    ON [dbo].[Usuario]([CPF] ASC);

