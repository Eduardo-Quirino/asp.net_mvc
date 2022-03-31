## <img src="https://ichi.pro/assets/images/max/724/0*whPt9R9BXJ5xotoh.jpg" alt="7 melhores cursos online para aprender ASP .NET Core e MVC em profundidade" style="zoom:25%;" />     ASP .NET MVC

YouTube :https://youtube.com/playlist?list=PLxNM4ef1BpxhqxiU8TRVtNlLgUeYolLdm

"Aula" :

## Criar um aplicativo Web

- Abra o [terminal integrado](https://code.visualstudio.com/docs/editor/integrated-terminal).

- Altere para o diretório ( `cd` ) que conterá o projeto.

- Execute o seguinte comando:

  CLI do .NETCopiar

  ```dotnetcli
  dotnet new mvc -o MvcMovie
  code -r MvcMovie
  ```

  - Se uma caixa de diálogo aparecer com **ativos necessários para compilação e depuração estiverem ausentes em ' MvcMovie '. Adicioná-los?**, selecione **Sim**
  - `dotnet new mvc -o MvcMovie`: cria um novo projeto ASP.NET Core MVC na pasta *MvcMovie*
  - `code -r MvcMovie`: Carrega o `MvcMovie.csproj` arquivo de projeto em Visual Studio Code.

## Executar o aplicativo

- Selecione CTRL + F5 para executar sem o depurador.

  - Confie no certificado de desenvolvimento HTTPS executando o seguinte comando:

    CLI do .NETCopiar

    ```dotnetcli
    dotnet dev-certs https --trust
    ```

    O comando anterior não funciona no Linux. Veja a documentação da distribuição do Linux para confiar em um certificado.

    O comando anterior exibe a caixa de diálogo a seguir, desde que o certificado não tenha sido confiável anteriormente:

    ![Security warning dialog](https://docs.microsoft.com/pt-br/aspnet/core/getting-started/_static/cert.png?view=aspnetcore-6.0)

  - Selecione **Sim** se você concordar com confiar no certificado de desenvolvimento.

    Para obter mais informações, veja [Confiar no certificado de desenvolvimento HTTPS do ASP.NET Core](https://docs.microsoft.com/pt-br/aspnet/core/security/enforcing-ssl?view=aspnetcore-6.0#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos).

  Para obter informações sobre como confiar no navegador Firefox, consulte [erro de certificado do firefox SEC_ERROR_INADEQUATE_KEY_USAGE](https://docs.microsoft.com/pt-br/aspnet/core/security/enforcing-ssl?view=aspnetcore-6.0#trust-ff).

  Visual Studio Code:

  - É [Kestrel](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/servers/kestrel?view=aspnetcore-6.0)
  - Inicia um navegador.
  - Navega para `https://localhost:5001` .

  A barra de endereços mostra `localhost:port:5001` e não algo como `example.com`. O nome do host padrão para seu computador local é `localhost` . Localhost serve somente solicitações da Web do computador local.

Iniciar o aplicativo sem depuração selecionando CTRL + F5 permite que você:

- Realize alterações de código.

- Salve o arquivo.

- Atualize rapidamente o navegador e veja as alterações no código.

  ![Home or Index page](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/start-mvc/_static/home50-port5001.png?view=aspnetcore-6.0)

 

---

##                                          Padrão de uso MVC



![Economize com MVC no PHP](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTskXHoHMi9nGwZBHJP4jZDEAhnIuwu9nC_deYiWSG52vptxZWasE5C1q-vHMCDv6pFCQo&usqp=CAU)

> Model : Cuida do banco de dados, informações 
>
>  View: Pode receber informações do MODEL, e exibe na tela 
>
> Controller: Monitora a VIEW  e o MODEL 

- #### Aula 05 - Criando o projeto em ASP MVC

- #### Aula 06 - Pastas e arquivos do Projeto



















  
