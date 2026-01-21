# Identificador-de-Plantas

Aplicação de console desenvolvida em C# que simula uma chave de identificação dicotômica para classificação vegetal. O sistema realiza perguntas ao usuário para determinar o tipo da planta (Briófita, Pteridófita, Gimnosperma, Angiosperma dicotiledônea e Angiosperma monocotiledônea) e apresenta exemplos nativos ou adaptados à região do nordeste brasileiro, juntamente com curiosidades específicas de cada grupo.

## Sobre o Projeto

Este projeto foi desenvolvido como trabalho final da disciplina de Programação Orientada a Objetos. O objetivo principal é demonstrar a aplicação prática de conceitos de POO na modelagem de um sistema biológico.

O programa funciona através de uma árvore de decisão:

    O usuário responde a perguntas de "sim" ou "não" sobre características visuais da planta (vasos, sementes, flores).

    O algoritmo classifica a planta em um dos quatro grandes grupos: Briófitas, Pteridófitas, Gimnospermas ou Angiospermas (divididas em Monocotiledôneas e Dicotiledôneas).

    Após a identificação, o sistema consulta um repositório local e exibe espécies correspondentes cadastradas, além de uma curiosidade sobre o grupo identificado.

## Estrutura Técnica e Conceitos de POO

O sistema foi arquitetado para evidenciar os pilares da Orientação a Objetos:

    Abstração: A classe base Planta define o contrato para todas as espécies, contendo propriedades comuns (Nome Popular, Nome Científico) e declarando o comportamento abstrato ObterCuriosidade().

    Herança: As classes Briofita, Pteridofita, Gimnosperma e Angiosperma herdam da classe base Planta, reutilizando código e especializando comportamentos.

    Polimorfismo: O método ObterCuriosidade() é sobrescrito em cada subclasse. Embora o programa principal trate todos os objetos genericamente como Planta, a execução retorna o texto específico de cada grupo.

    Encapsulamento: As propriedades das plantas são gerenciadas através de métodos construtores e acessores, protegendo a integridade dos dados.

Estrutura de Arquivos

    Program.cs: Contém a lógica principal (Main), o fluxo de perguntas ao usuário (Frontend do console) e a lógica de filtragem dos resultados.

    RepositorioPlantas.cs: Simula um banco de dados em memória. Contém uma lista estática pré-populada com espécies.

    TiposDePlanta/: Pasta contendo as definições das classes:

        Planta.cs (Classe Abstrata)

        Briofita.cs

        Pteridofita.cs

        Gimnosperma.cs

        Angiosperma.cs
