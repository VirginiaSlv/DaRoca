# 🥬 DaRoça - Sistema de Logística de Entrega de Alimentos

**DaRoça** é uma solução de software desenvolvida para otimizar a logística de entrega de uma empresa especializada em produtos frescos e orgânicos. O sistema foi projetado para facilitar a programação de rotas eficientes de entrega, garantindo praticidade, economia e qualidade no serviço.

---

## 📦 Visão Geral

A empresa **DaRoça** oferece um serviço de entrega de alimentos, onde os clientes podem:

- Escolher os produtos desejados
- Definir a frequência de entrega:
  - Entrega única
  - Entrega semanal
  - Entrega quinzenal
  - Entrega mensal

O foco principal do sistema é **otimizar o transporte dos alimentos**, utilizando algoritmos inteligentes para definir as **rotas mais eficientes** para os motoristas.

---

## ⚙️ Funcionalidades

O sistema é composto por dois módulos principais:

### 🖥️ Front-end (C# com Windows Forms)

- Interface gráfica intuitiva
- Gerenciamento de:
  - Pedidos
  - Motoristas
  - Centros de distribuição
  - Histórico de entregas

### 🧠 Back-end (Python - Lógica de Otimização)

- Conexão direta com o banco de dados
- Leitura e manipulação de dados de:
  - Clientes
  - Pedidos
  - Centros de distribuição
  - Motoristas
- Distribuição equitativa de pedidos entre motoristas de um mesmo centro
- Cálculo da **rota de entrega mais eficiente** para cada motorista, utilizando o **algoritmo do vizinho mais próximo**

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia     | Descrição                                                                 |
|----------------|---------------------------------------------------------------------------|
| C#             | Desenvolvimento da interface gráfica (Windows Forms)                      |
| Python         | Lógica de otimização e roteirização                                       |
| SQL Server     | Armazenamento dos dados                                                   |
| ADO.NET        | Conexão com o banco de dados no C# (via `System.Data.SqlClient`)          |
| SQLAlchemy / pyodbc | Conexão com o banco de dados no Python (dependendo da biblioteca usada) |

---

## 🧩 Algoritmo de Otimização

O sistema utiliza o **algoritmo do vizinho mais próximo (Nearest Neighbor Algorithm)** para encontrar a melhor sequência de entregas, minimizando o tempo e a distância percorrida por cada motorista.

---

## 🚀 Objetivos do Projeto

- Reduzir custos com transporte
- Garantir a entrega de produtos frescos com qualidade
- Facilitar a gestão logística de empresas do ramo alimentício
- Automatizar a distribuição e roteirização de pedidos
