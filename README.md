# AlunosAPI
## Introdução
Bem vindo!

Este repositório é referente a um sistema de cadastro de alunos.

Aqui você vai encontrar a documentação do projeto.

## Sobre o projeto
Este projeto criado com o propósito de validação de nota para a disciplina de Linguagem de Programação 3 do curso de Engenharia de Computação do Centro Universitário SENAI CIMATEC.

## Stack
- C#
- JavaScript
- HTML
- CSS
- SQL Server

## Funcionalidades
O projeto trata-se de um sistema web para o registro de alunos.
Nele, é possível cadastrar o nome, idade e email de uma pessoa, além de poder editar ou excluir os registros.

## Detalhes do Projeto
O back end do projeto foi realizado seguindo a estrutura de projetos multicamadas consumindo API, utilizando o framework .Net em C#.
O front end do projeto foi construido utilizando react e bootstrap com Javascript, HTML, e CSS.
Para fazer a conexão dos dois, foi utilizado o Axios.
O banco de dados utilizado foi um SQL Server local, como parte da camada de dados do projeto.

## API
A API utilizada foi deselvolvida para esse projeto e é constituida de 4 metodos:
- Get: Recupera os dados do banco solicitados, podendo ser o retorno de todos os dados ou de instancias especificas por meio de nome ou id;
- Post: Insere os dados cadastrados na pagina web no banco local da aplicação;
- Put: Atualiza dos dados cadastrados na pagina web referentes a um id especifico no banco local da aplicação;
- Delete: Deleta os dados selecionados na pagina web referentes a um id especifico do banco local da aplicação.
