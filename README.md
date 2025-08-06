# Atividade6 Blazor

Este é um projeto Blazor WebAssembly configurado para deploy automático no GitHub Pages.

## Como usar

1. Faça push do código para o repositório GitHub
2. O GitHub Actions irá automaticamente fazer o build e deploy para GitHub Pages
3. Acesse sua aplicação em: `https://[seu-usuario].github.io/Atividade6_Blazor/`

## Desenvolvimento Local

Para executar localmente:

```bash
dotnet run
```

## Deploy Manual

Para fazer deploy manual:

```bash
dotnet publish -c Release -o release
```