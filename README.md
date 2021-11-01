## ASP .NET MVC





### **Pastas**

**Estrutura do projeto**

- App_Data** – Fonte de dados
- **App_Start** – Configurações
- **Controllers** – Classes do Controlador
- **Models** – Classes de dados
- **Views** – Arquivos de UI – (Html,cshtml,etc.)
- **Packages.****config** – Configurações Nuget
- **Global.****asax** – inicializa a aplicação
- **Web.****Config** – Configurações do site
- **Scripts** – Arquivos javascripts
- **fonts** – template bootstratp
- **Content** – arquivos CSS, imagens





### **Requisições HTTP:**



•**GET** – Requisita dados de um recurso específico

•Usa a própria Url para enviar dados(só texto, 255 caracteres)

•Não for alterar dados no servidor; buscas e consultas

•Ex: **http://www.macoratti.net/?nome=****valor&nome****=valor**

•

•**POST** – Envia dados para ser processado em um recurso específico

•Envia os dados no corpo da mensagem, separando a URL dos dados 

•Alterar dados , enviar arquivos, proteger dados






Atividade 1

1 O que significa MVC ?

2 Descreva resumidamente o padrão MVC .

3 Em qual pasta do projeto são colocados as classes que representam os controladores de uma aplicação
ASP .NET MVC ?

4 Em qual pasta do projeto são colocados as classes que representam o modelo de dados de uma
aplicação ASP .NET MVC ?

5 Qual a convenção adotada pelo Framework ASP .NET MVC para definir o nome dos controladores ?

6 Qual a convenção usada para definir o local onde as visões serão armazenadas em um projeto ASP .NET
MVC ?

7 Qual a rota padrão definida quando criamos um projeto ASP .NET MVC ?

8 A rota para se chamar uma Action no Controller é sempre definida como controller action /id e não pode
ser customizada? Onde esta rota esta definida ?

9 Que tipo de dado retorna um Controlador ?

10 O Controller é uma classe comum que herda de Controller ? Verdadeiro ou Falso

11 Qual é o papel da View em um projeto ASP .NET MVC ?

12 Quais códigos podem conter numa View ?

13 Para que ser o ViewData e o ViewBag

14 Que tipo de dado é o ViewBag ?

15 Que tipo de dado é o ViewData

16 O que é Razor

17 Qual o símbolo usado pelo Razor para iniciar expressões e blocos de código ?




Atividade 2

Crie um projeto ASP .NET MVC 5 com chamado Atividade2

Utilize o template Empty --> MVC

Crie um controlador chamado Atividade2 usando o Scaffold MVC 5 Controller Empty

Defina uma propriedade chamada Nome usando ViewData e atribua a ela o seu nome no método Action
Index

Defina uma propriedade chamada Atividade usando ViewBag e atribua a ela a string “Atividade 2” no
método Action Index

Defina uma propriedade chamada Curso usando ViewBag atribua a ela a string “Curso ASP .NET MVC 5” no
método Action Index

Crie uma view a partir do método Action Index do controle que você acabou de criar usando o template
Empty e desmarque a opção : use a Layout page

Defina o código na view para receber os dados atribuídos às propriedades Nome e Curso

A saída HTML da view deverá ser a seguinte: (Observe que os valores recebidos devem estar em

Parabéns Seu Nome, você concluiu a Atividade 2 do Curso ASP .NET MVC 5

Para executar a aplicação selecione o controlador criado e pressione F5

1 Qual será o resultado obtido ?

2 Porque não obtemos o resultado esperado ?

3 O que você tem que fazer para executar a sua aplicação e obter o resultado esperado ?

## *Criando pasta no visula studio code*

dotnet new mvc -o nome da pasta - cria uma pasta 
       code -r nome da pasta - carrega a pasta

- `dotnet new mvc -o MvcMovie`: cria um novo ASP.NET Core MVC na *pasta MvcMovie.*
- `code -r MvcMovie`: carrega o *arquivo de projeto MvcMovie.csproj* no Visual Studio Code.

**dotnet dev-certs https --trust -**

- A barra de endereços mostra `localhost:port:5001` e não algo como `example.com`. O nome do host padrão para o computador local é `localhost` . Localhost serve somente solicitações da Web do computador local.

Iniciar o aplicativo sem depuração selecionando Ctrl+F5 permite que você:

- Realize alterações de código.
- Salve o arquivo.
- Atualize rapidamente o navegador e veja as alterações de código.

**dotnet run - para rodar no navegador**
