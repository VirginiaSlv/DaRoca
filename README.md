# DaRoça

#DaRoça: Sistema de Logística de Entrega de Alimentos
Este projeto, chamado "DaRoça", é uma solução de software para otimizar a logística de entrega de uma empresa de alimentos que trabalha com produtos frescos e orgânicos. A aplicação foi desenvolvida para resolver o desafio de programar as melhores rotas de entrega, garantindo a praticidade e a qualidade do serviço.

Visão Geral
A empresa "DaRoça" oferece um serviço de entrega de alimentos onde os clientes podem escolher produtos e definir a frequência de recebimento (única vez, semanalmente, quinzenalmente ou mensalmente).

O foco principal deste projeto é a otimização da entrega e do transporte dos alimentos, utilizando algoritmos de roteirização para definir as rotas mais eficientes para os motoristas.

Funcionalidades
O sistema é composto por duas partes principais:

Front-end (Windows Forms): Uma interface visual (em C#) para que os usuários possam gerenciar o histórico de pedidos, motoristas e centros de distribuição.

Back-end (Lógica de Otimização): Um módulo de programação (em Python) responsável por:

Acessar os dados de clientes, pedidos, centros de distribuição e motoristas diretamente do banco de dados.

Distribuir os pedidos de forma equitativa entre os motoristas de um mesmo centro.

Calcular a melhor rota de entrega para cada motorista, utilizando o método do vizinho mais próximo (algoritmo de otimização).

Tecnologias
Linguagem de Programação: C# e Python.

Banco de Dados: SQL Server.

Acesso a Dados: Conexão direta ao banco de dados utilizando bibliotecas como System.Data.SqlClient (para C#) e conexões SQL (para Python).

Interface: Windows Forms.

