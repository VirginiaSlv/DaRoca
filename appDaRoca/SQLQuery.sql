CREATE SCHEMA DaRoca;

CREATE TABLE [DaRoca].[Usuarios](
	[idUsuario] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [DaRoca].[CentroDeDistribuicao](
	[idCentro] [nvarchar](50) NOT NULL,
	[nome] [nvarchar](50) NOT NULL,
	[cidade] [nvarchar](50) NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
	[latitude] [float] NOT NULL,
	[longitude] [float] NOT NULL,
 CONSTRAINT [PK_CentroDeDistribuicao] PRIMARY KEY CLUSTERED 
(
	[idCentro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]




CREATE TABLE [DaRoca].[Clientes](
	[idCliente] [nvarchar](50) NOT NULL,
	[nome] [nvarchar](50) NOT NULL,
	[cidade] [nvarchar](50) NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
	[latitude] [int] NOT NULL,
	[longitude] [int] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]






CREATE TABLE [DaRoca].[CompartilharCentro](
	[idCentroCompartilhar] [nvarchar](50) NOT NULL,
	[idCentroRecebem] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [DaRoca].[CompartilharCentro]  WITH CHECK ADD  CONSTRAINT [FK_idCentroCompartilhar] FOREIGN KEY([idCentroCompartilhar])
REFERENCES [DaRoca].[CentroDeDistribuicao] ([idCentro])
GO

ALTER TABLE [DaRoca].[CompartilharCentro] CHECK CONSTRAINT [FK_idCentroCompartilhar]
GO

ALTER TABLE [DaRoca].[CompartilharCentro]  WITH CHECK ADD  CONSTRAINT [FK_idCentroRecebem] FOREIGN KEY([idCentroRecebem])
REFERENCES [DaRoca].[CentroDeDistribuicao] ([idCentro])
GO

ALTER TABLE [DaRoca].[CompartilharCentro] CHECK CONSTRAINT [FK_idCentroRecebem]



DROP TABLE DaRoca.Pedidos;



CREATE TABLE [DaRoca].[Motoristas](
	[idMotoristas] [nvarchar](50) NOT NULL,
	[idCentro] [nvarchar](50) NOT NULL,
	[nome] [nvarchar](50) NOT NULL,
	[horaInicio] [time](7) NOT NULL,
	[horaFim] [time](7) NOT NULL,
	[inicioIntervalo] [time](7) NOT NULL,
	[fimIntervalo] [time](7) NOT NULL,
	[velocidade] [tinyint] NOT NULL,
 CONSTRAINT [PK_Motoristas] PRIMARY KEY CLUSTERED 
(
	[idMotoristas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [DaRoca].[Motoristas]  WITH CHECK ADD  CONSTRAINT [fk_motorista_centro] FOREIGN KEY([idCentro])
REFERENCES [DaRoca].[CentroDeDistribuicao] ([idCentro])


ALTER TABLE [DaRoca].[Motoristas] CHECK CONSTRAINT [fk_motorista_centro]





CREATE TABLE [DaRoca].[Pedidos](
	[idPedidos] [nvarchar](50) NOT NULL,
	[idCentro] [nvarchar](50) NOT NULL,
	[idCliente] [nvarchar](50) NOT NULL,
	[horaFeito] [date] NOT NULL,
	[dataEstimada] [datetime2](7) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[idPedidos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [DaRoca].[Pedidos]  WITH CHECK ADD  CONSTRAINT [fk_Pedidos_Centro] FOREIGN KEY([idCentro])
REFERENCES [DaRoca].[CentroDeDistribuicao] ([idCentro])
GO

ALTER TABLE [DaRoca].[Pedidos] CHECK CONSTRAINT [fk_Pedidos_Centro]
GO

ALTER TABLE [DaRoca].[Pedidos]  WITH CHECK ADD  CONSTRAINT [fk_Pedidos_Cliente] FOREIGN KEY([idCliente])
REFERENCES [DaRoca].[Clientes] ([idCliente])
GO

ALTER TABLE [DaRoca].[Pedidos] CHECK CONSTRAINT [fk_Pedidos_Cliente]



INSERT INTO DaRoca.Usuarios (idUsuario, senha)
VALUES ('usuario', '12345');