# Programação Orientada a Objetos em C#: Guia Detalhado

---

## 1. O que é Programação Orientada a Objetos (POO)?

A Programação Orientada a Objetos (POO) é um paradigma de desenvolvimento baseado na organização do código em **objetos**. Cada objeto representa uma entidade do mundo real ou um conceito, encapsulando dados (propriedades) e comportamentos (métodos).

**Benefícios da POO**:
- Reutilização de código através de herança e composição.
- Organização e legibilidade, modelando soluções mais próximas do mundo real.
- Facilita manutenção e extensão do sistema.

---

## 2. Técnicas para Identificar Objetos e Métodos

### Etapas para Identificação

1. **Análise do Problema**:
   - Leia os requisitos do sistema.
   - Identifique os substantivos como potenciais **objetos** e os verbos como potenciais **métodos**.

   **Exemplo**:
   - Requisito: *“O sistema deve gerenciar contas bancárias, clientes e permitir transações como saque, depósito e transferência.”*
     - Substantivos: **ContaBancaria**, **Cliente**, **Transacao**.
     - Verbos: **Sacar**, **Depositar**, **Transferir**.

2. **Refinamento**:
   - Agrupe atributos relacionados a um objeto.
   - Identifique relações entre objetos.

3. **Relacionamento entre Objetos**:
   - **Composição**: Cliente possui uma ContaBancaria.
   - **Herança**: Caso houvesse tipos específicos de contas, como ContaPoupanca ou ContaCorrente.

---

## 3. Os Quatro Pilares da Orientação a Objetos

### a) **Encapsulamento**
- **Definição**: Esconde os detalhes internos de uma classe, expondo apenas o necessário através de métodos ou propriedades públicas.

- **Benefício**: Garante controle sobre o estado interno da classe, evitando inconsistências.

#### Modificadores de Acesso
Os modificadores de acesso controlam a visibilidade de classes, métodos e propriedades. Os mais comuns em C# são:

| Modificador | Descrição                                                                                  |
|-------------|------------------------------------------------------------------------------------------|
| `public`    | O membro ou classe é acessível de qualquer lugar.                                        |
| `private`   | O membro é acessível apenas dentro da própria classe.                                    |
| `protected` | O membro é acessível dentro da classe e suas classes derivadas.                          |
| `internal`  | O membro é acessível apenas dentro do mesmo assembly.                                    |
| `protected internal` | O membro é acessível dentro do mesmo assembly ou por classes derivadas.             |

---

### b) **Herança**
- **Definição**: Permite que uma classe herde propriedades e métodos de outra, formando uma relação "é um".

---

### c) **Polimorfismo**
- **Definição**: Permite que diferentes classes implementem o mesmo método de formas distintas.

**Tipos**:
1. **Sobrescrita**:
   - Redefine um método de uma classe base.

2. **Sobrecarga**:
   - Métodos com o mesmo nome, mas assinaturas diferentes.

---

### d) **Abstração**
- **Definição**: Simplifica sistemas complexos ao expor apenas os detalhes necessários para o uso.

- **Uso**: Classes abstratas são usadas para definir modelos genéricos, deixando detalhes para as classes concretas.

---

## 4. Diferença entre Herança e Composição

### Herança
- **Relação "é um"**:
  - Exemplo: ContaCorrente é uma ContaBancaria.
- **Quando usar**:
  - Quando você quer reutilizar comportamento de uma classe base.
- **Riscos**:
  - Torna o código menos flexível, dificultando mudanças futuras.

### Composição
- **Relação "tem um"**:
  - Exemplo: ContaCorrente tem um Titular (Cliente).
- **Quando usar**:
  - Quando você quer combinar comportamentos de forma flexível.

