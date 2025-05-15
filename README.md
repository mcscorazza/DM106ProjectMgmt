# Trabalho DM106
O projeto “ProjectMgmt” é uma aplicação web desenvolvida em ASP.NET Core com o objetivo de gerenciar Projetos de Máquinas online. 
Ele permitirá o cadastro de ```Projetos```, vincular uma ou mais ```Tarefas``` a um ```Projeto``` (1:N) e criar relações entre diversos ```Componentes Mecânicos``` com diversos ```Projetos``` (N:N).

## Aluno: 
Marcos Eduardo Corazza

## Diagrama de Classes do Projeto
![Arquitetura de Classes Project Mgmt](https://github.com/mcscorazza/DM106ProjectMgmt/blob/main/DM106ProjectMgmt/docs/Diadrama%20de%20Classes.png)

## Criação manual das Tabelas 

### DesignMachine
```sql
CREATE TABLE MachineDesign (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(255) NOT NULL,
	DrawingCode NVARCHAR(30) NOT NULL,
	Client NVARCHAR(255) NOT NULL,
);
```

### JobTask
```sql
CREATE TABLE JobTask (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(255) NOT NULL,
	Owner NVARCHAR(30) NOT NULL,
	Status NVARCHAR(255) NOT NULL,
);
```




