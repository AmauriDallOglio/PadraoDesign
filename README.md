# Arquiteturas de Software

Este repositório aborda três abordagens arquiteturais populares em desenvolvimento de software: **Clean Architecture**, **MVC (Model-View-Controller)** e **MVP (Model-View-Presenter)**. 

---

## 1. **Clean Architecture**

### Definição:
Clean Architecture é uma abordagem arquitetural que organiza o sistema em camadas concêntricas, com dependências direcionadas para o núcleo (regras de negócio). O objetivo é criar uma aplicação modular, testável e independente de frameworks, banco de dados ou interface do usuário.

### Características:
- **Camadas principais**:
  - **Entities (ou Core)**: Regras de negócio mais puras e independentes.
  - **Use Cases (ou Application)**: Regras específicas da aplicação.
  - **Interface Adapters**: Adaptadores para interagir com frameworks ou sistemas externos.
  - **Frameworks & Drivers**: A camada mais externa, que lida com a infraestrutura.

### Dependências:
- A direção das dependências sempre aponta para o núcleo (Entities).
- As camadas externas nunca conhecem as internas.

### Objetivo:
- Separar regras de negócio do restante do sistema.
- Facilitar mudanças sem afetar todo o sistema.

### Pontos fortes:
- Alta **testabilidade** devido à separação de responsabilidades.
- **Independência de frameworks** e detalhes de implementação.
- Facilita a **substituição de tecnologias** (ex.: banco de dados, UI).

### Pontos fracos:
- **Complexidade inicial** maior.
- Exige mais **disciplina** e esforço para implementar.

### Casos de uso:
- Sistemas **complexos** e grandes que precisam de longa manutenção.
- Quando há uma necessidade de **forte desacoplamento**.

---

## 2. **MVC (Model-View-Controller)**

### Definição:
MVC é um padrão de design que separa a aplicação em três componentes principais para organizar a interação entre a lógica de negócio, interface de usuário e entrada do usuário.

### Componentes:
- **Model**:
  - Gerencia os dados e a lógica de negócio.
  - Comunica-se com o banco de dados ou serviços de backend.
  
- **View**:
  - Apresenta os dados do Model ao usuário.
  - Responsável pela interface gráfica.
  
- **Controller**:
  - Atua como intermediário entre a View e o Model.
  - Recebe entradas do usuário, decide como processá-las e atualiza o Model e a View.

### Pontos fortes:
- **Simplicidade** e facilidade de implementação.
- Estrutura bem **conhecida** e amplamente adotada.

### Pontos fracos:
- À medida que a aplicação cresce, o **Controller** pode ficar sobrecarregado.
- Pode haver **dependências mais rígidas** entre componentes.

### Casos de uso:
- Aplicações **web simples** ou de médio porte.
- Frameworks como **ASP.NET MVC**, **Ruby on Rails**, ou **Laravel**.

---

## 3. **MVP (Model-View-Presenter)**

### Definição:
MVP é uma evolução do MVC, onde a lógica de apresentação é completamente retirada da View e colocada no Presenter. A View é uma interface passiva e só responde às instruções do Presenter.

### Componentes:
- **Model**:
  - Igual ao MVC. Gerencia os dados e a lógica de negócio.
  
- **View**:
  - Responsável por exibir dados e encaminhar eventos para o Presenter.
  - Não contém lógica.
  
- **Presenter**:
  - Contém toda a lógica de apresentação.
  - Atua como intermediário entre a View e o Model.
  - Atualiza a View diretamente.

### Pontos fortes:
- O **Presenter** é mais **testável** do que o Controller do MVC, pois não depende da View diretamente.
- A **View** é mais simples e desacoplada da lógica.

### Pontos fracos:
- Pode resultar em muita **comunicação entre View e Presenter**, especialmente em interfaces complexas.
- Um número maior de **classes** e código boilerplate.

### Casos de uso:
- Aplicações com **interfaces mais ricas** (ex.: desktop ou mobile).
- Onde é necessário maior controle sobre a **lógica de apresentação**.


