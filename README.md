
# Observabilidade - Open Telemetry

Bem-vindo ao Projeto Open Telemetry! Este repositório contém tudo o que estou estudando sobre o assunto de Observabilidade.

## Sumário

- [Introdução](#introdução)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Serviços](#Serviços)
- [Licença](#licença)

## Introdução

A observabilidade é uma prática essencial para garantir a saúde e a performance das aplicações. Nosso sistema de observabilidade coleta, analisa e visualiza dados em tempo real, permitindo uma rápida identificação e resolução de problemas.

## Pré-requisitos

Antes de começar, certifique-se de ter os seguintes requisitos instalados:

- [Docker](https://www.docker.com/get-started)
- [.Net](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0) (opcional, para desenvolvimento)

## Instalação

1. Clone este repositório para sua máquina local:
    ```bash
    git clone https://github.com/leopaduad/OTL.git
    ```
2. Navegue até o diretório do projeto:
    ```bash
    cd projeto-observabilidade
    ```

3. Execute o Docker para iniciar os serviços:
    ```bash
    docker run --name jaeger -p 13133:13133 -p 16686:16686 -p 4317:4317 -d --restart=unless-stopped jaegertracing/opentelemetry-all-in-one
    ```

### Serviços

Este projeto inclui os seguintes serviços:

- **Jaeger**: Para rastreamento distribuído.


### Acessando os Dashboards

- **Jaeger**: Acesse `http://localhost:16686`.


## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
