# Injeção de Dependência em WPF

Este repositório apresenta um exemplo prático de como implementar o padrão de Injeção de Dependência (Dependency Injection) em aplicações WPF utilizando C#. O objetivo é demonstrar como desacoplar componentes da interface gráfica dos serviços de aplicação, promovendo testabilidade, manutenção e organização do código.

## ✨ Visão Geral

A Injeção de Dependência é uma técnica essencial para manter o código modular e facilitar a troca de implementações sem alterar a lógica principal da aplicação. No contexto do WPF, ela permite que janelas e componentes recebam suas dependências de forma automática, utilizando um container de DI.

## 📂 Estrutura do Projeto

```
InjecaoDependenciaWPF/
├── App.xaml               
├── App.xaml.cs            # Configuração inicial da aplicação e do container de DI
├── MainWindow.xaml        
├── MainWindow.xaml.cs     # Janela principal, recebe dependências via construtor
├── InjecaoDependenciaWPF.csproj
└── Services/
    ├── IMessageService.cs # Interface do serviço de mensagens
    └── MessageService.cs  # Implementação concreta do serviço de mensagens
```

## 🛠️ Como Implementar Dependency Injection no WPF

### 1. Crie Interfaces e Serviços

Implemente as interfaces dos serviços dentro do diretório `Services`. Por exemplo, um serviço de mensagens pode ser definido por meio de uma interface e uma implementação concreta.

### 2. Configure o Container de DI

No arquivo `App.xaml.cs`, configure o container de dependências (por exemplo, usando `Microsoft.Extensions.DependencyInjection`) e registre os serviços e janelas principais.

### 3. Injete Dependências nas Views

Utilize o construtor das suas Views para receber as dependências registradas no container. No WPF, isso permite associar os serviços diretamente à interface gráfica.

## ▶️ Como Executar

1. Clone este repositório.
2. Abra a solução no Visual Studio.
3. Restaure os pacotes NuGet.
4. Compile e execute a aplicação.

## 📦 Dependências

As principais dependências utilizadas são:

- `Microsoft.Extensions.DependencyInjection` para o gerenciamento do container de DI.
- `System.Windows` (WPF), parte do .NET Desktop.

## 📚 Referências

- [Dependency Injection em .NET (Microsoft Docs)](https://learn.microsoft.com/pt-br/dotnet/core/extensions/dependency-injection)
- [Introdução ao WPF](https://learn.microsoft.com/pt-br/dotnet/desktop/wpf/getting-started/)
- [Microsoft.Extensions.DependencyInjection NuGet](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/)

---

Desenvolvido por [Edson L. Candido](https://github.com/edsonlcandido)