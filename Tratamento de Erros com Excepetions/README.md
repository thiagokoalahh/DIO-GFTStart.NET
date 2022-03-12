# Tratamento de Erro em C# com Exceptions

## O que é uma exceção?

- Qualquer condição de erro ou comportamento inesperado por uma programa em execução.
  - Falha de codificação
  - Falta de recursos disponíveis
  - Condições inesperadas pelo runtime
- Tipos de erros possíveis
  - Erros de sintaxe
    - Erro de tempo de execução que não pode ser tratado programaticamente de maneira significativa.
      - Falta de recursos

  - Erros em tempo de execução
    - Erros em tempo de execução que não estão necessariamente relacionados à código mal escrito.
      - Comum em caso de leitura/escrita de arquivos
  - Erros lógicos
    - Exceção provocada por falha lógica do desenvolvedor.
    - Deve ser tratado a partir da correção do código falho.

## Importância do tratamento de erros

- Evitar parada súbita do sistema
- Mensagens amigáveis para usuário final
- Melhor comunicação com desenvolvedores para tratar rapidamente o problema

## Classe System.Exception

- Toda exceção em .NET herda da classe System.Exception
- Propriedades importantes herdadas:
  - Message: descrição legível para humanos com a causa da exceção
  - InnerException: obtém conjunto de exceções superiores ou exceção que levou à exceção atual.
  - StackTrace: rastreamento do caminho até chegar ao erro
  - Source: relacionada à aplicação ou objeto que causou o erro
  - TargetSite: relacionada ao método que lançou a exceção atual
- Métodos:
  - GetBaseException():
    - Dada uma cadeia de exceções, somente uma delas pode ser a causa raiz para todas as outras, portanto é a ‘exceção base’
  - GetObjectData():
    - Configuração de informações relacionadas à exceção lançada.
      - info: guarda objeto de dados serializados
      - context: contém informação de contexto sobre origem ou destino dos dados a serem transmitidos
    - GetType():
      - Retorna tipo da instância atual em tempo de execução
    - ToString():
      - Retorna representação da atual exceção em forma de string

## Comandos para lançar e tratar exceções

- Comando try
  - Provê mecanismo para capturar exceções que ocorrem durante a execução de certo bloco de código.
- Comando catch
  - Após a captura, o sistema procura pelo comando catch mais próximo que pode lidar com a exceção.
- Comando finally
  - Bloco útil para liberação de recursos, pois sempre é executado, independente da captura e tratamento da exceção.
- Comando throw
  - Lança uma exceção em código explicitamente.
    - Utilizar o comando em um contexto de exceção já capturada, faz o “relançamento” da exceção dentro do catch, provendo assim mais informação para depuração.
- Comando when
  - Trata exceções de acordo com requerimentos  específicos que você define para dada exceção.
    - Útil quando uma exceção pode ser tratada igualmente para múltiplos erros sob determinadas condições.

## Customizando exceções

- Apesar da hierarquia de classes existentes com base na classe Exception, é possível criar sua própria classe de exceção de acordo com a necessidade.
- Motivações:
  - Quando uma exceção reflete um erro específico que não foi mapeado por uma classe de exceção existente
  - Quando a exceção necessita de um tratamento diferenciado
- Procedimento:
  - Definir uma classe que herda de Exception
  - Definir construtores da classe
  - Se necessário, sobrescreva membros cujo comportamento queira modificar
  - Definir se a exceção será serializável

## Melhores práticas para tratamento de exceções

- Use try/catch/finally em trechos de códigos que podem potencialmente gerar exceções e que de fato seu próprio código também consegue tratar.
- Nos blocos catch , sempre ordene os tratamentos das exceções das classes mais específicas para mais genéricas.
- Faça limpeza automática de recursos alocados com using .
- Caso o objeto não implemente IDisposable utilize finally.
- Caso exista uma condição com grandes chances de erro, verifique a viabilidade de checar a condição antes de somente tratar a exceção.
- Projete classes de forma que as exceções sejam evitadas ou minimizadas.
- Lance exceções ao invés de somente retornar um status code.
- Somente crie novas classes de exceções, caso as pré-definidas não satisfaçam as necessidades do código.
- Crie classes com a terminação Exception e derivadas diretamente da classe base Exception.
- Utilize no mínimo os construtores já definidos na classe base.
- Escreva mensagens de erros claras e sucintas.
- É uma boa prática incluir strings traduzidas de acordo com a linguagem do usuário da aplicação através de sattelites assemblies.
- Em exceções customizadas forneça propriedades adicionais conforme necessidade.
- Utilize o comando throw para que o stack trace seja mais útil, pois o rastreio começa a partir do lançamento até a  captura da exceção.
- Utilize métodos construtores de exceções.
- Restaure o estado da aplicação caso os métodos completem sua execução devido à exceções.

## Teste de unidade para exceções

- O que são teste unitários?
  - São testes que fazem verificação de unidades/componentes da aplicação, comparando a um retorno esperado com o retorno atual do código testado.
  - Padrão AAA
    - Arrange
    - Act
    - Assert
- Como testar exceções?
  - O padrão e estruturação de testes não se modifica, contudo, o mecanismo de chamada da exceção pode variar de acordo com o framework utilizado.
    - MSTest V2
    - XUnit
    - NUnit
