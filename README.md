# Injeção de Dependência em Windows Forms

Este repositório demonstra como implementar o padrão de Injeção de Dependência (Dependency Injection) em aplicações Windows Forms utilizando C#. O objetivo é apresentar boas práticas de arquitetura, tornando o código mais flexível, testável e de fácil manutenção.

## ✨ Visão Geral

A injeção de dependência facilita a separação de responsabilidades e o desacoplamento entre as classes de sua aplicação. Com ela, você pode trocar facilmente implementações, promover testes automatizados e manter seu projeto preparado para crescer de forma sustentável.

## 📂 Estrutura do Projeto

```
InjecaoDependenciaWinForms/
├── .gitattributes
├── .gitignore
├── Form1.Designer.cs      # Código gerado pelo designer do formulário
├── Form1.cs               # Formulário principal, recebe dependências pelo construtor
├── Form1.resx             # Recursos do formulário
├── InjecaoDependenciaWinForms.csproj
├── InjecaoDependenciaWinForms.sln
├── Program.cs             # Ponto de entrada e configuração do DI
└── Services/
    ├── IMessageService.cs # Interface do serviço de mensagens
    └── MessageService.cs  # Implementação concreta do serviço de mensagens
```

## 🧑‍💻 Passo a Passo para Implementar Dependency Injection

### 1. Defina Interfaces e Serviços

No diretório `Services`, você encontra a interface e a implementação do serviço:

- `Services/IMessageService.cs`  
  ```csharp
  public interface IMessageService
  {
      void ShowMessage(string message);
  }
  ```
- `Services/MessageService.cs`  
  ```csharp
  public class MessageService : IMessageService
  {
      public void ShowMessage(string message)
      {
          MessageBox.Show(message);
      }
  }
  ```

### 2. Configure o Container de Injeção

No arquivo `Program.cs`, registre as dependências e inicialize o formulário principal usando o provider:

```csharp
using InjecaoDependenciaWinForms.Services;
using Microsoft.Extensions.DependencyInjection;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();
        services.AddScoped<IMessageService, MessageService>();
        services.AddScoped<Form1>();

        using (ServiceProvider serviceProvider = services.BuildServiceProvider())
        {
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}
```

### 3. Injete as Dependências no Formulário

No `Form1.cs`, receba o serviço via construtor:

```csharp
public partial class Form1 : Form
{
    private readonly IMessageService _messageService;

    public Form1(IMessageService messageService)
    {
        InitializeComponent();
        _messageService = messageService;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _messageService.ShowMessage("Olá, DI no WinForms!");
    }
}
```

## ▶️ Como Executar

1. Clone este repositório.
2. Abra a solução `InjecaoDependenciaWinForms.sln` no Visual Studio.
3. Certifique-se de restaurar os pacotes NuGet.
4. Compile e execute (F5).

## 📦 Dependências

As principais dependências estão descritas em `InjecaoDependenciaWinForms.csproj`:

- `Microsoft.Extensions.DependencyInjection`
- `System.Windows.Forms` (parte do .NET Desktop)

## 📚 Referências

- [Dependency Injection .NET - Microsoft Docs](https://docs.microsoft.com/pt-br/dotnet/core/extensions/dependency-injection)
- [Windows Forms Overview](https://learn.microsoft.com/pt-br/dotnet/desktop/winforms/overview/)
- [Microsoft.Extensions.DependencyInjection NuGet](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/)

---

Desenvolvido por [Edson L. Candido](https://github.com/edsonlcandido)