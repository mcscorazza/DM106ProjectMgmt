# Trabalho DM106
Sistema desenvolvido em ASP.NET Core para gerenciar Projetos de Máquinas, permitindo o controle de tarefas, Requisitos e Componentes Mecânicos. 
Projeto desenvolvido como parte da disciplina DM106 da pós-graduação em **Cloud Computing e Desenvolvimento Mobile**.
Ele permite o cadastro de ```Projetos Mecânicos```, vincular uma ou mais ```Tarefas``` (1:N) e um ou mais ```Requisitos``` (1:N) a um ```Projeto``` e criar relações entre diversos ```Componentes Mecânicos``` com diversos ```Projetos``` (N:N).

## 🛠 Tecnologias Utilizadas

- Visual Studio 2022
- ASP.NET Core 7
- Entity Framework Core
- SQL Server
- Swagger

## Diagrama de Classes do Projeto
![Arquitetura de Classes Project Mgmt](https://github.com/mcscorazza/DM106ProjectMgmt/blob/main/assets/Diagrama%20de%20Classes.png)

## ▶️ Como Executar o Projeto

#### 1. Clone este repositório:
```bash
git clone https://github.com/mcscorazza/DM106ProjectMgmt.git
```
#### 2. Abra o arquivo DM106ProjectMgmt.sln no Visual Studio 2022.

#### 3. Execute as migrações
```bash
Upgrade-Database
```

#### 4. Execute o projeto DM106ProjectMgmt_API [▶ https] para iniciar a API.

#### 5. Acesse o Swagger em:
```
https://localhost:7221/swagger/index.html
```

#### 6. Crie um usuário no endpoint /auth/register
```json
{
  "email": "string",
  "password": "string"
}
```
#### 7. Faça o 'login' através do endpoint 
```c
/auth/login
```
* informando as credenciais cadastradas no passo anterior, habilitando a opção 'true' para 'useCookies'

#### 8. Utilize os enpoints abaixo para listar os dados dos Projetos, Tarefas, Requisitos e Componentes cadastrados
```c
/design
/design/5 //para listar os dados do Projeto com ID 5

/task
/task/8 //para listar os dados da Tarefa com ID 8

/requirement
/requirement/3 //para listar os dados do Requisito com ID 3

/component
/component/15 //para listar os dados do Componente com ID 15
```

#### 9. Execute os endpoints do tipo POST para criar novos Projetos, Tarefas, Requisitos ou Componentes
Projeto Mecanico (incluindo um ou mais componentes - opcional)
```json
[POST] /design

{
  "name": "string",
  "drawingCode": "string",
  "client": "string",
  "components": [
    {
      "partNumber": "string",
      "description": "string"
    }
  ]
}
```
Tarefa (onde _machineDesignId_ indica o ID do projeto a vincular a Tarefa criada)
```json
[POST] /task
{
  "title": "string",
  "owner": "string",
  "status": "string",
  "machineDesignId": 0
}
```
Requisito (onde _machineDesignId_ indica o ID do projeto a vincular o Requisito criado)
```json
[POST] /requirement
{
  "description": "string",
  "type": "string",
  "machineDesignId": 0
}
```
Componente
```json
[POST] /component
{
  "partNumber": "string",
  "description": "string"
}
```

#### 9. Para fazer o logout e excluir o cookie do navegador:
```
/auth/logout
```


## 🚧 Status do Projeto
✅ Finalizado para entrega acadêmica  
🔧 Possíveis melhorias futuras: autenticação, interface gráfica, etc.


## 👨‍💻 Autor

Desenvolvido por **Marcos Corazza**  
[GitHub](https://github.com/mcscorazza) • [LinkedIn](https://www.linkedin.com/in/corazza/)
