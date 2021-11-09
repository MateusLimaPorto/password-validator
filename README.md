# Password Validator

API que realiza a verificação da senha fornecida pelo usuário. Sendo considerada como válida após as validações contendo as seguintes regras. Conforme abaixo:


## Regras

- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial
  - Considere como especial os seguintes caracteres: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

Exemplos:  

```c#
IsValid("") // false  
IsValid("aa") // false  
IsValid("ab") // false  
IsValid("AAAbbbCc") // false  
IsValid("AbTp9!foo") // false  
IsValid("AbTp9!foA") // false
IsValid("AbTp9 fok") // false
IsValid("AbTp9!fok") // true
```

## Instruções básicas para execução do projeto

- Clone este repositório [password-validator](https://github.com/MateusLimaPorto/password-validator.git)\
- Certifique-se de ter a versão [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) instalada \
- Abra a solução em sua IDE de preferencia. No VS Code basta executar no prompt de comando `code .` na pasta do projeto. Em seguida execute a aplicação digitando o seguinte comando no shell de comando `dotnet run`

```bash
git clone https://github.com/MateusLimaPorto/password-validator.git
```

```bash
cd code .
```

```bash
cd dotnet run
```

## Como utilizar

Para utilizar é bem simples, ao subir a aplicação elá é exposta a URL `/v1/password/validate` onde pode ser feitas as requisições utilizando o metodo HTTP POST.

Input: Uma senha (string).
Output: Um boolean indicando se a senha é válida.

Request:
```
{
  "password": "AbTp9!fok"
}
```

Response:
```bash
{
  "valid": true
}
```

Abaixo um exemplo em CURL:
```bash
curl -X POST "https://localhost:44388/v1/password/validate" -H  "accept: */*" -H  "Content-Type: application/json" -d "{\"password\":\"AbTp9!fok\"}"
```

#### Swagger

Após iniciar a aplicação o swagger estará disponivel em `https://localhost:44388/swagger/index.html`
  
  
## Solução

Conceitos do Clean Architecture a arquitetura do projeto consiste em uma aplicação própria com sua regra de negócio isolada e abstraida por uma interface, assim possibilitando implementações de novos critérios e reduzindo o acoplamento.
Solução implementanda em .NetCore e Testes utilizando xUnit. Para simplificar as validações foi utilizado mecanismo de expressões regulares Regex.