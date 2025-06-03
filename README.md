# Prova Técnica - Estágio Aperam

Este projeto é um desafio prático enviado pela Aperam, com ele é possível desmontrar conceitos de programação orientada a objetos, estrutura de projetos, manipulação de dados e tratamento de exceções.

Ele simula um módulo de cadastro de produtos, com foco na camada controlador e na representação de dados para a visualização.

## AVISO

A resolução da PARTE 3 se encontra no final deste REAMDE.md

# Índice

- [Estrutura do Projeto](#estrutura-do-projeto)
- [Tecnologias Usadas](#tecnologias-usadas)
- [Como Executar o Projeto](#como-executar-o-projeto)
- [Passos de Execução](#passos-de-execução)
- [Decisões de Projeto](#decisões-de-projeto)
- [Resolução Parte 3](#resolução-parte-3)

## Estrutura do Projeto

O projeto foi estruturado para simular uma arquitetura MVC, eu utilizei de pastas para organizar:

```
Estágio Aperam/
├── .git/                             # Pasta de controle de versão do Git (oculta)
├── ProvaEstagio/                     # Pasta principal do projeto
|    |__ Parte1/
│       ├── Base/                     # Contém as classes base para herança
│       │   └── BaseController.cs
│       ├── Controllers/              # Contém as classes controladoras
│       │   └── ProdutoControllers.cs
│       ├── Grids/                    # Contém o modelo de dado (Grid)
│       │   ├── ProdutoGrid.cs
|       |__ Models                    # Contém o modelo de dado (View)
│       │   └── ProdutoViewModel.cs
│       ├── Services/                 # Contém classes de lógica de negócio (serviços)
│       │   └── ProdutoService.cs
|       |__ Util/                     # Classe utilitária para simular usuário logado
│       |   ├── UsuarioLogado.cs
│       └── Program.cs                # Ponto de entrada da aplicação console para testes
|__ProvaEstagio.sln                   # Solução do Visual Studio
|
└── README.md                         # Este arquivo!
```

## Tecnologias Utilizadas

- Linguagem de Programação: C#
- Framework: .NET (.NET 8.0)
- IDE: Visual Studio

## Como Executar o Projeto

Siga os passos abaixo para configurar e executar este projeto no seu ambiente.

### Pré-requisitos

- Visual Studio (versão 2022 ou superior recomendada) instalado com a carga de trabalho "Desenvolvimento de desktop com .NET".
- SDK do .NET (versão 8.0 ou superior) instalado.

### Passos de Execução

1. Clone o Repositório (ou Baixe o Código):
   Se você estiver usando Git, clone o repositório para o seu computador:

```
Bash

git clone https://github.com/EARNascimento/ProvaEstagioAperam.git
```

Caso contrário, baixe o arquivo ZIP do projeto e extraia-o para uma pasta.

2. Abra o Projeto no Visual Studio:

- No Visual Studio, vá em Arquivo > Abrir > Projeto/Solução....
  Navegue até a pasta onde você clonou/extraiu o projeto.
  Selecione o arquivo da solução (ProvaEstagio.sln) e clique em Abrir.

3. Compilar o Projeto:

- No Visual Studio, vá em Compilar > Compilar Solução (ou use o atalho Ctrl+Shift+B). Isso garantirá que todas as dependências sejam resolvidas e o código seja compilado corretamente.

4. Executar o Projeto:

- Pressione F5 ou clique no botão Iniciar (geralmente um triângulo verde) na barra de ferramentas do Visual Studio.
- Uma janela de console será aberta, mostrando a saída do programa com os resultados dos testes dos controladores e da listagem de produtos.

- Pressione qualquer tecla para fechar a janela do console quando terminar.

## Decisões de Projeto

Durante o desenvolvimento, diversas decisões foram tomadas para demonstrar conceitos importantes em C# e boas práticas de desenvolvimento:

1. Estrutura e Organização do Código
2. Classes e Herança
3. Injeção de Dependências
4. Modelo de Dados
5. Modelo Lódigo
6. Tratamento de Exceções
7. Retorno JSON

## Resolução Parte 3

```
3.1) Analise o trecho de código abaixo. Qual será o valor impresso no console? Justifique
sua resposta com base no conceito de atribuição de variáveis.
    int x = 10;
    int y = x;
    x = 5;
Console.WriteLine(y);

```

**Resposta**: O valor impresso no console será 10. Isso acontece porque quando a variável 'int x' é criada, o valor 10 é atribuído a ela, ou seja, 'x' está apontando para um local na memória que contém 10. Quando o 'int y' é criado, o valor de 'x' é copiado para 'y', agora cada um possui seu local na memória e as duas varíaveis contém o valor 10.<br>
Mesmo após a alteração da variável 'x', ela afeta apenas e unicamente a variável 'x', como 'y' recebeu o valor na etapa anterior, ele não é afetado.

---

```
3.2) Explique com suas palavras:
● Qual é a diferença entre uma classe pública (public) e uma classe privada
(private)?
● Quando é indicado utilizar cada tipo de visibilidade?
```

**Resposta**:

- A diferença entre uma **classe pública** e uma privada é que, a **classe pública**, pode ser acessada por qualquer lugar e por qualquer um que consiga visualizá-la. Já a **classe privada**, não pode ser acessada por ninguém a não ser por ela mesma, isso significa que essa classe só pode ser acessada de dentro.
- É indicado utilizar a classe pública quando é necessário expor ela para ser utilizada em outras classes, como se fosse uma interface, outras classes podem "usar" de suas funções. E é indicado utilizar a classe privada quando é necessário cortar a exposição e proteção de seus dados(encapsulamento).

---

```
3.3) Para que serve o bloco try/catch em C#?
● Quais boas práticas devem ser adotadas ao lidar com exceções no código?

```

**Resposta**: O bloco try/catch serve para tratamento de exceções, gerenciar erros e como respondê-los. Ele permite que, se por algum acaso seu código der errado, ele capture esse erro e execute um código para lidar com ele, assim impedindo que seu código dê erro e quebre no meio da execução.
Algumas boas práticas que podem ser adotadas são:

1. Capturar exceções específicas primeiro
2. Evitar o 'catch' genérico que captura qualquer erro
3. Usar o bloco 'finally' para evitar vazamento de recursos
4. Fornecer mensagens de erro claras para ajudar na correção

---

```
3.4) O que significa o modificador override em C#?
● Diferencie os usos de virtual, override e new em herança de classes.
```

**Resposta**: O modificador 'override' é usado para estender ou modificar a implementação de um método ou propriedade, que foi declarado com o modificador 'virtual' na classe pai.

- Diferenças entre os usos:<br>

1. **Virtual**: Deve ser usado em um membro da classe, esse termo indica que ele pode ser sobrescrito por uma classe derivada. Deve ser quando quando um comportamento da classe padrão é necessário, mas que ainda assim permita que classes especializadas o mudem.

2. **Override**: Seu uso é em um membro da classe derivada. Indica que esse membro consegue fazer uma nova implementação, é chamado de poliformismo. Deve ser usado quando é necessário que uma classe forneça uma lógica própria que foi projeto para ser estendido pela classe base.

3. **New**: Ele é aplicado em um membro da classe derivada. Indica que o membro oculta um membro com o mesmo nome, não há poliformismo. É usado quando você deseja introduzir um novo membro na classe, mas sem sobrescrevê-lo
