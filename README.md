# Gestão de Tarefas – Projeto VB.NET

## Descrição

Este projeto é uma **aplicação de gestão de tarefas** desenvolvida em **VB.NET com Windows Forms** e **SQL Server** como base de dados.  
Permite que múltiplos utilizadores registados possam criar, editar, eliminar e marcar tarefas como concluídas. O sistema também inclui **login e registo de utilizadores**, garantindo que cada utilizador só acede às suas próprias tarefas.

---

## Funcionalidades

- **Registo de utilizadores**
  - Nome, email e password.
  - Validação básica de dados.
  
- **Login**
  - Autenticação de utilizadores registados.
  - Dados do utilizador guardados no módulo `UserLogado` para aceder em todo o projeto.
  
- **Gestão de tarefas**
  - Criar tarefas com título, descrição e data limite.
  - Editar tarefas existentes.
  - Eliminar tarefas.
  - Marcar tarefas como concluídas.
  
- **Visualização**
  - Lista de tarefas do utilizador atual.
  - Ações rápidas através de botões ou ícones ao lado de cada tarefa (editar, concluir, eliminar).

---

## Estrutura do Projeto

- **Formulários principais**
  - `LoginForm` – Permite autenticação de utilizadores.
  - `Form1` – Permite registo de novos utilizadores.
  - `HomePage1` – Página inicial que possibilita a criação de tarefas
  
- **Módulos**
  - `UserLogado` – Guarda as informações do utilizador atual durante a sessão.

- **Base de dados**
  - Tabelas principais:
    - `Utilizadores` → Armazena os dados dos utilizadores.
    - `Tarefas` → Armazena todas as tarefas criadas, associadas a um utilizador.

---

## Tecnologias Utilizadas

- **VB.NET (Windows Forms)**  
- **SQL Server**  
- **Visual Studio**  

<span>
  <img src="https://upload.wikimedia.org/wikipedia/commons/7/78/Microsoft_Visual_Basic_for_Applications_logo.svg" width="110" height="110" />
  <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Microsoft_SQL_Server_2025_icon.svg/1200px-Microsoft_SQL_Server_2025_icon.svg.png" width="40" height="40" />
  <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Visual_Studio_Icon_2022.svg/480px-Visual_Studio_Icon_2022.svg.png" width="40" height="40" />
</span>
