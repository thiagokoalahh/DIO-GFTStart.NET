# Trabalhando com Arquivos e Streams

## System.IO

Namespace que agrega um conjunto de classes, estruturas,  enumeradores e delegates, relativos a operações de Entrada e Saída de dados (Input/Output)

### Principais Classes

- File e FileInfo
  - Fornece suporte para criar, copiar apagar, mover e abrir arquivos de forma individual
    - FileAccess, FileShare, FileMode
- Directory e DirectoryInfo
  - Fornece suporte para criar, mover e percorrer diretórios e subdiretórios
    - Propriedades:
      - Exists
        - Boolean que indica se o diretório existe.
      - Name
        - Nome do diretório, e para obter o caminho “Path” FullName
      - Parent
        - Retorna o diretório Pai, pode retornar null se estivermos em uma pasta raiz “root”
      - Root
        - Retorna uma instância de DirectoryInfo que representa o diretório raiz

- FileSystemWatcher
  - Monitora mudança no sistema de arquivos, através de disparo de eventos quando um arquivo ou diretório muda.
    - OnChanged, OnCreated, OnDeleted, OnRenamed, OnError

- FileStream, MemoryStream, StreamReader
  - Stream é uma classe abstrata que fornece uma visão genérica de uma sequência de bytes.
  - Existe uma grande vantagem de se utilizar Streams, pois os dados são escritos, lidos ou modificados através de um Buffer.

## Importação de dados

- Sistemas precisam se comunicar e isso pode ocorrer de diversas formas, como por exemplo: APIs Rest, Mensageria e até mesmo troca de arquivo
- O formato mais utilizado na atualidade é o Json
  - Java Script Object Notation
- Mas temos outros como:
  - XML, Positional, Tab Delimited e CSV
    - Comma-Separeted Value:
      - Os dados são separados por vírgula;
      - Podem ou não conter aspas para ajudar na identificação do formato contido em cada coluna;
      - Podem ou não possuir cabeçalho;
      - Podem utilizar outro tipo de delimitador;
