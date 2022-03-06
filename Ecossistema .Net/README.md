# Ecossistema .NET

## O que é .NET e ASP.NET?

- .NET  - Plataforma de desenvolvimento com diversas ferramentas, linguagens de programação  e bibliotecas que permitem o desenvolvimento de diversos tipos de aplicações.
- ASP.NET - Framework que estende .NET para a criação de web apps.
- A plataforma .NET é gratuita?
  - Open-source e gratuito
  - Distribuição livre;
  - Acesso ao código-fonte;
  - Permissão para criação de trabalhos derivados;
  - Integridade do autor do código-fonte;
  - Não discriminação contra pessoas ou grupos;
  - Não discriminação contra áreas de atuação;
  - Distribuição da licença;
  - Licença não específica a um produto;
  - Licença não restritiva a outros programas;
  - Licença neutra em relação à tecnologia.

## .NET Standard

- Especificação das APIs que são comuns às implementações .NET.

## Suporte ao desenvolvedor

- IDE:
  - Visual Studio (Mac e Windows)
  - Visual Studio Code
  - Codespaces (Online)
- Linguagens de Programação:
  - C#
  - F#
  - Visual Basic
- Bibliotecas para desenvolvimento e execução de aplicações .NET:
  - SDK
  - Runtime
  - NUGET: Gerenciador de pacotes.
- Acesso a dados:
  - ORM - Entity Framework Core
  - LINQ - consulta integrada à linguagem
- Ambientes CI/CD:
  - Ambientes CI/CD
  - GitHub Actions
  - Azure Devops
  - Cake / Fake
- Gerenciamento automático de memória

## Sobre ASP.NET e ASP.NET Core

- Aplicações Web
  - Páginas web
  - REST APIs
  - Microservices
  - Hubs
- Processamento de requisições web ( C# e F#)
- Criação de páginas da web de forma dinâmica
- Bibliotecas para web patterns (MVC)
- Sistema de autenticação
- Extensões para produtividade

## O que é .NET Framework?

- Ambiente de desenvolvimento e execução focado em Windows
- Common language runtime + .NET Class Library

### Características principais

- Gerenciamento de memória
- Sistema de tipos comum - > Tipos definidos pelo próprio framework
- Grande e específicas bibliotecas de classes utilitárias
- Interoperabilidade entre linguagens
- Compatibilidade de versões
- Uso do .NET Standard

## O que é .NET Core/.NET

### Sobre .NET Core e .NET

- Plataforma cruzada : Linux, Windows e Mac OS
- Produzir um produto com base de código única
- Open Source -> MIT e Apache 2
- .NET = .NET Core + .NET Framework + Xamarin + Mono
- Aquisição facilitada a partir do NUGET
- Modular e com melhor desempenho
- Ciclos de lançamentos mais rápidos

### Sobre ASP.NET Core

- Construção de aplicações web, IoT apps e aplicações backend para mobile
- Funcionalidades para construção de aplicações com renderização no servidor
  - Uso do MVC -> ASP.NET Core MVC
    - Uso de Padrão MVC ( Model-View-Controller)
      - Model: Representa o estado da aplicação, encapsulando lógica de negócio.
      - View: Responsável por apresentar dados através de interface.
      - Controller: Componentes que lidam com a interação do usuário a partir da View e trabalham com model para apresentar respostas para o usuário.
    - Model Binding
      - Mapeamento automático de dados de requisições HTTP para parâmetros de métodos de ação
    - Model Validation : Validação automática no lado do cliente e servidor
    - Razor Pages e Razor markup
      - Modelo baseado em páginas -> simplificado
      - Interface e lógica de negócio são separados, mas dentro da página.
      - Sintaxe de marcação para inserir código baseado em .NET em páginas WEB = Razor markup + C# + HTML
    - Tag Helpers
      - Permite que o código do lado do servidor participe da criação e renderização de elementos HTML em arquivos Razor
      - Experiência de desenvolvimento com HTML mais amigável
      - IntelliSense no ambiente para sintaxe HTML e Razor
      - Manutenção de código usando somente informações do servidor
- Funcionalidades para construção de aplicações com renderização no cliente
  - Blazor
    - Framework para construir aplicativos do lado do cliente, que são executados direto no navegador com WebAssembly(WASM) usando C#.
    - Uso da interoperabilidade com Javascript para lidar com manipulação da DOM e chamadas de API.
  - Integração com frameworks como Angular, React e Bootstrap

## O que é Xamarin?

### Sobre Xamarin

- Plataforma para desenvolvimento de aplicações mobile modernas com alto desempenho
- Baseado no projeto Mono, implementação open source baseada no .NET Framework
- Criação de interface nativa em cada plataforma(Android, iOS, MacOS e Windows apps) e código de lógica compartilhado
- Possui todos os benefícios já citados da plataforma .NET

## Qualidade de Código

### Porque e como devemos padronizar?

- Ser confiável
- Ser sustentável
- Ser eficiente
- Melhorar comunicação entre equipe
- Facilitar manutenção de códigos
- Utilizar documentação e boas práticas de codificação, como clean code

### Clean Code

- Conjunto de boas práticas na escrita de software para obtenção de maior legibilidade e manutenibilidade de código.
- Regras Gerais:
  - Siga SEMPRE as convenções adotadas pela equipe!
  - KISS : Keep It Stupid Simple (Matenha isto estupidamente simples)
  - Devolva o código mais limpo do que você encontrou
  - Busque sempre entender e solucionar os problemas a partir de sua raiz.
- Regras para entendimento do código:
  - Seja consistente na escrita de todo o código
  - Utilize variáveis concisas e que realmente passem a informação necessária
  - Observe a necessidade de criação de objetos de valor ao invés do uso de tipos primitivos
  - Evite dependências lógicas
  - Evite condicionais negativas
- Regras para nomeação:
  - Escolher nomes descritivos para classes, variáveis e métodos
  - Para variáveis semelhantes, faça uma distinção identificável
  - Utilizar nomes de fácil leitura e busca
  - Utilize constantes para guardar strings a serem comparadas
  - Não use prefixos ou caracteres especiais
- Regras para métodos:
  - Métodos não devem ser grandes e devem possuir somente um objetivo/responsabilidade
  - Métodos devem possuir nomes descritivos
  - Evite a exigência de muitos parâmetros dentro do método
  - Evite que uma função altere valores de outra classe sem ser a própria classe
  - Evite utilização de flags desnecessárias
- Regras para comentários:
  - Evite comentários desnecessário, torne seu código autoexplicativo
  - Não seja redundante
  - Não deixe código desnecessário comentado
  - Comentários podem ser úteis para falar sobre a intenção de uma classe ou método
  - Comentários podem explanar regras mais complexas e alertas sobre consequências mais sérias
- Regras para estruturação de código:
  - Declare variáveis próximas de seu uso
  - Agrupe métodos similares
  - Declare funções de cima pra baixo
  - Mantenha poucas e curtas linhas
  - Use espaçamentos e identação corretamente
- Convenções de nomenclatura
  - camelCase:
    - Escrever palavras ou frases compostas considerando a primeira letra da primeira palavra sempre minúscula e as subsequentes maiúsculas.
  - PascalCase:
    - Escrever palavras ou frases compostas considerando a primeira letra de cada palavra sempre maiúscula.
  - Padrão C#?
    - Não há uma regra obrigatória, porém grande maioria dos desenvolvedores convenciona da seguinte forma:
      - Nomes de classes e métodos -> PascalCase
      - Nomes de variáveis e parâmetros -> CamelCase
    - No caso de interfaces recomenda-se o uso do prefixo “ I “
      - Ex: IEntidade, IRepositorioCliente
