# Desenvolvimento de Aplicações .NET

## ASP.NET MVC

### O que é Entity Framework

- Entity Framework é um ORM(Mapeador Relacional de Objeto) que permite que os desenvolvedores de .NET trabalherm com um banco de dados usando objetos .NET. Elimina a necessidade da maioria do código de acesso a dados que os devs geralmente precisam gravar.
- Linhas de utilização:
  - Database First
  - Model First
  - Code First
- Data Annotations
  - O Data Annotations é um recurso que permite que você adicione atributos e métodos em nossas classes para alterar convenções padrão e personalizar alguns comportamentos
  - Principais Atributos:
    - Required: Significa campo obrigatório
    - RegularExpression: Valida o campo por expressão regular
    - Display: Nome a ser mostrado em todas as interfaces de usuário
    - StringLength: Determina a quantidade máxima de caracteres que poderá ser informada
    - MinLength: Determina a quantidade mínima de caracteres que poderá ser informada
    - DisplayFormat: Formato a ser exibido nas interface de usuário
    - Range: Define a faixa de dados aceita pela propriedade
  - Migrations
    - O Migrations é um recurso que oferece uma maneira de atualizar de forma incremental o esquema de banco de dados para manter em sincronia com o modelo de classe do seu projeto preservando os dados existentes no banco de dados.
    - Com o Migrations tamém é possível realizar o downgrade caso você deseje voltar o seu banco de dados para a versão anterior em que se encontrava além de manter um histórico de alterações

### Padrão MVC

- O MVC é um padrão de arquitetura que divide a aplicação em três camadas: a visão(view), o modelo(model) e o controlador(controller).
- É um padrão muito utilizado devido a sua arquitetura que possibilita separar o projeto em camadas onde cada uma delas executa o que lhe é definido e nada mais.
- O MVC traz como benefício o isolamento das regras de negócios da interface do usuário, o que permite que exista várias interfaces de usuários que podem ser modificadas sem afetar a regra do negócio
- Model
  - É a camada responsável pela leitura e escrita de dados, e também de suas validações
- View
  - É a camada de interação com o usuário. Ela apenas faz a exibição dos dados, sendo ela por meio de um HTML ou XML
- Controller
  - É a camada responsável por receber todas as requisições e por controlar qual model usar e qual view será mostrado ao usuário

### Routes

- No modelo ASP.NET MVC as requisições do navegador são enviadads para uma Ação da Controller, tirando a necessidade de cada URL possuir um arquivo físico
- Quando uma aplicação ASP.NET MVC é criada já é configurado um padrão de rota default:
  - **url: "{controller}/{action}/{id}",**
  - **defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional**
- Esse padrão já atende a maioria das necessidades, porém é possível criar padrões personalizados
- Custom Routes
  - **url: "student/{id}/{name}/{standardId}",**
  - **defaults: new {controller = "Student", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, standardId = UrlParameter.Optional**
- Exemplo de uma URL utilizando a rota default:
  - `http://localhost:1234/home/index/100`
  - `http://localhost:1234/home/index/`

### Action Result

- O Action Result é o resultado de uma Ação processada por uma controller, o action result possui diversos tipos

### Http Verbs

- Os Http Verbs são métodos do protocolo HTTP que informam ao servidor qual ação ele deve executar.
  - Get: Buscar recursos, Cache
  - Post: Criar um novo recurso
  - Put/Path: Atualizar um recurso existente
  - Delete: Remover um recurso

### Razor

- O Razor é uma View Engine utilizada no ASP.NET MVC. O seu principal objetivo é simplificar o desenvolvimento de aplicações ASP.NET pois ele deixa o código mais simples, fácil e legível
- Benefícios
  - Menor curva de aprendizagem, por ser baseado em C#
  - Por possuir uma sintaxe limpa ele requer que o desenvolvedor digite menos para chegar a um resultado
  - O Visual Studio possui IntelliSense para páginas Razor, o que nos dá uma maior produtividade

### Middlewares

- Middlewares são componentes(classes) que é executado em todas as solicitações na aplicação ASP.NET
- Normalmente existem vários middlewares na aplicação e nós definimos a ordem em que são executados
- Cada middleware adiciona ou modifica a solicitação HTTP e pode passar o controle para o próximo middleware

### Startup.cs

- Como o próprio nome diz, a classe Startup.cs é responsável por ser o ponto inicial do projeto
- Dentro dela existem métodos que são responsáveis por configurarem o projeto. São eles:
  - ConfigureServices
    - É responsável por registrar as classes ao contêiner de injeção de dependência, após isso a classe poderá ser usada em qualquer lugar da aplicação desde que seja incluída no construtor da classe em que deseja usar
  - Configure
    - Controla o pipeline da aplicação, é nesse método que são especificados os middlewares que serão utilizados. Se nada for colocado nesse método nem o MVC funcionará pois não foi indicado a aplicação o que utilizar.
    - Deve ser adicionado apenas o que for ser utilizado, ou poderá acontecer perda na performance

## API

### O que é API?

- A sigla API em português significa "interface de programação de aplicações"
- As APIs são uma forma de realizar a integração entre sistemas mesmo que esses possuam linguagens de programação diferente.

### O que REST

- O REST é um conjunto de princípios que quando aplicados de maneira correta em uma aplicação, a beneficia com a arquitetura e padrões da própria web.
- Uma aplicação que implementa tais princípios é chamada de RESTful

### Swagger

- Quando é preciso consumir uma API existente é necessário conhecer as funcionalidades disponíveis e detalhes de como consumir tal funcionalidade.
- Diante dessa necessidade existe o Swagger que é um projeto composto por algumas ferramentas para auxiliar o desenvolvedor de API em algumas tarefas como por exemplo a documentação da API.
