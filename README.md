# Padrões de Design: MVP e MVC

Este repositório contém implementações simples dos padrões de design **MVP (Model-View-Presenter)** e **MVC (Model-View-Controller)** para ilustrar suas diferenças e aplicações. 

 

## 🎯 **MVC (Model-View-Controller)**

### **Componentes e Responsabilidades**
- **Model**: Gerencia os dados da aplicação e a lógica de negócio. Não tem conhecimento sobre a interface.
- **View**: Exibe os dados para o usuário. É notificada pelo Controller ou Model sobre mudanças.
- **Controller**: Atua como intermediário entre a View e o Model. Recebe a entrada do usuário e decide quais ações executar no Model ou View.

### **Fluxo de Comunicação**
1. O usuário interage com o **Controller**.
2. O **Controller** atualiza o **Model** e notifica a **View**.
3. A **View** apresenta as mudanças do **Model**.

### **Características**
- A lógica de apresentação pode ser dividida entre o **Controller** e a **View**.
- O **Controller** pode ser mais difícil de testar, pois frequentemente é acoplado diretamente à **View**.

### **Cenários Comuns de Uso**
- Frameworks web, como **ASP.NET MVC**, **Ruby on Rails**.
- Aplicações com interação simples ou direta do usuário.

 

## 🎯 **MVP (Model-View-Presenter)**

### **Componentes e Responsabilidades**
- **Model**: Gerencia os dados e a lógica de negócio. Igual ao **Model** no MVC.
- **View**: Exibe dados para o usuário e encaminha eventos para o **Presenter**. É passiva, contendo lógica mínima.
- **Presenter**: Contém toda a lógica de apresentação. Atua como intermediário entre o **Model** e a **View**. Atualiza diretamente a **View**.

### **Fluxo de Comunicação**
1. O usuário interage com a **View**, que repassa eventos para o **Presenter**.
2. O **Presenter** manipula o **Model** e atualiza diretamente a **View**.

### **Características**
- O **Presenter** é mais fácil de testar, pois não está diretamente acoplado à **View**.
- A **View** é uma interface passiva, com lógica mínima ou nula.
- Ideal para cenários que exigem maior controle sobre a lógica de apresentação.

### **Cenários Comuns de Uso**
- Aplicações desktop ou mobile.
- Cenários onde maior testabilidade e controle da lógica de apresentação são necessários.

 

## 🛠️ **Estrutura do Repositório**

### **MVC Implementation**
- `/MVC/Model`: Contém a lógica e os dados do sistema.
- `/MVC/View`: Responsável pela interação com o usuário.
- `/MVC/Controller`: Gerencia a comunicação entre Model e View.

### **MVP Implementation**
- `/MVP/Model`: Contém a lógica e os dados do sistema.
- `/MVP/View`: Exibe os dados e atua como interface passiva.
- `/MVP/Presenter`: Contém a lógica de apresentação.

---

