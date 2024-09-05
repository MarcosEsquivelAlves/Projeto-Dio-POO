# Programação Orientada a Objetos (POO)

A Programação Orientada a Objetos (POO) é um dos paradigmas mais amplamente utilizados no desenvolvimento de software. Ela facilita a criação de sistemas complexos ao organizar o código em torno de objetos, que representam entidades do mundo real. A POO é sustentada por quatro pilares fundamentais: **Abstração**, **Polimorfismo**, **Herança** e **Encapsulamento**.

## Abstração
A abstração é o conceito de ocultar os detalhes internos de um objeto e expor apenas as informações essenciais. O objetivo é simplificar a complexidade, permitindo que o programador trabalhe com um modelo limpo e focado nas características importantes de um objeto. Por exemplo, um objeto **Carro** pode ter atributos como `modelo` e `cor`, e métodos como `acelerar()` e `frear()`, sem expor os detalhes de como o motor funciona ou como o sistema de direção é projetado.

A abstração ajuda a reduzir a complexidade ao representar objetos reais com uma interface simplificada, permitindo que o programador foque no que é importante para o contexto da aplicação.

## Polimorfismo
O polimorfismo permite que objetos de diferentes classes sejam tratados de forma uniforme por meio de uma interface comum. Em termos práticos, o polimorfismo permite que métodos com o mesmo nome possam ter diferentes comportamentos dependendo do tipo do objeto que os invoca. Isso promove a flexibilidade do código e facilita sua manutenção e extensão.

Por exemplo, uma função `EmitirSom()` pode ser implementada de maneiras diferentes para a classe `Cachorro` e a classe `Gato`. Ambas podem ser tratadas como objetos do tipo `Animal`, mas a execução da função `EmitirSom()` resultará em um som de latido para `Cachorro` e um som de miado para `Gato`.

## Herança
Herança é o mecanismo que permite que uma classe herde atributos e comportamentos de outra classe. A classe "pai" passa suas propriedades e métodos para a classe "filha", promovendo a reutilização de código. Com a herança, as classes derivadas podem estender ou modificar o comportamento herdado da classe pai, mantendo a consistência e evitando duplicação de código.

Por exemplo, uma classe `CarroEsportivo` pode herdar de uma classe `Carro`, adquirindo todos os atributos e métodos da classe pai, como `modelo`, `cor`, `acelerar()` e `frear()`, mas adicionando novos comportamentos específicos, como `usarTurbo()`.

## Encapsulamento
O encapsulamento é o princípio de esconder os detalhes internos de uma classe e proteger seu estado, permitindo o acesso e a modificação de atributos apenas por meio de métodos públicos (getters e setters). Esse conceito ajuda a manter a integridade dos dados, garantindo que o estado de um objeto seja alterado apenas de forma controlada.

Por exemplo, uma classe `ContaBancaria` pode ter um atributo privado `saldo`, acessível apenas por métodos como `Depositar()` e `Sacar()`. Dessa forma, o saldo só pode ser modificado respeitando as regras definidas, evitando acessos indevidos ou inconsistentes.

## Conclusão
Os quatro pilares da POO — abstração, polimorfismo, herança e encapsulamento — fornecem uma base sólida para o desenvolvimento de software orientado a objetos. Esses conceitos permitem a criação de sistemas mais flexíveis, organizados e fáceis de manter, promovendo a reutilização de código e facilitando a expansão e a modificação de funcionalidades ao longo do tempo.
