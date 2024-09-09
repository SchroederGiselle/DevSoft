//Minimal APIs em C#
//Testar API 
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Endpoints - Funcionalidades
//Requisição - URL e método/verbo HHTP
app.MapGet("/", () => "C#");

app.MapGet("/segundafuncionalidade", () => "Segunda funcionalidade");

app.Run();

//Exercicios para a próxima aula
// - Criar um endpoint para receber informação pela URL.
// - Criar um endpoint para receber informação pelo Corpo.
