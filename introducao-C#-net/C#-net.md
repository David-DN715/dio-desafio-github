
# introdução ao c sharp 

* namespace
Os namespace são usados para organizar classes.
Para usar uma classe de outro namespace, colocamos using no começo do codigo.

* classe e objeto
Pode ter campos, propriedades, metodos e eventos dentro dela que são denominados menbros.
Quando uma classe é instanciada, essa instancia é chama de objeto, e nesse objeto podem ser criados os valores de acordo com os campos da classe.

* inteface
È como uma classe base que serve de molde para varias classes.
uma classe que implementa uma interface deve implementar todos os membros.

* enum
Declara um conjunto de constantes nomeadas que começasm do 0 e aumenta de 1 em 1.

* debugging
a depuração pode ser feita colocando um breakpoint no canto esquerdo do codigo ou apertando o f9 e executando ele.
o codigo vai parar aonde foi colocado o breakpoint e então o codigo poderá ser inspecionado.

## Estrutura de progama!

Progamas C sharp consistem em um ou mais arquivos.
Os progamas declarados tipos, que contem membros e podem ser organizados em namespaces.

Classes e interfaces são exemplos de tipos.

Campos, metodos, propriedades e eventos são exemplos de membros.

Quando os progamas C sharps são 
compilados, eles são fisicamente empacotados emasmbleies.

Os assemblies, geralmente tem a extensão de arquivo .exe ou dll, dependendo se são aplicações ou bibliotecas.

* Tipos e variaveis

Variaveisde tipos de valor contem diretamente seus dados.

as variaveis tem sua prorpia copia dos dadose não épossivel que as operações afetem outra variavel(exeto no caso das variaveis de parametro ref e out).

tipos:

Numericos: sbytes, shiirt,int,long, byte, ushort, uint, ulong.

caracteres Unicode: char.

Pontos flutuantes:float, double, decimal.

booleano: bool, enum, struct e tipos nullable (Exemplo int(?)).

## Classes e objetos

CLasses são tipos mais fundamentais de Csharp.

uma classe é uma estrutura de dados que combina estado (campos) e ações (metodos).

Objetos são instancias de uma classe.

as classes suportam herançã e polimorfismo, mecanismos pelos quais as classes derivadas podem estender e especializar as classes base.

instancias de classes (objetos) são criadas usando o operador new, que aloca memoria para umanova instancia, chama um construtor para inicializar a instancia e retorna uma referencia à instancia.

exemplo:

ponto p1 = new Ponto(0, 0);

ponto p2 = new Ponto(10, 20);


A memoria oculpada por um objetoé recuperada automaticamente quando não está mais acessivel. Não é necessario nem possivel deslocar explicitamente objetos em Csharp.

* membros 

Os membros de uma classe podem ser estaticos ou membros da instancia.

Membros estaticos pertencem a classe e membros de instancia pertence ao objeto.

Constantes, variaveis, metodos, propriedades, construtores, etc...

* acessibilidade

cada membro de uma classe tem uma acessibilidade associada, que controla as regioes do texto doprogama que podem acessar o membro.

podem ser:

public, protected, internal, private.

* Herança 

Uma declaração de classe pode especificar uma classe base, herdando os membros public, internal e protected da classe base.

Omitir uma especificaçãode classe base é é omesmo que derivar do tipo object.

* Metodos:

Um metodo é um membro que implementa uma computação ou ação que se pode ser executada por um objeto ou classe.

Os metodospodem ter uma lista de parametros, que representam valores ou referencias de variaveis passadas por metodos, e um tipo de retorno, que especifica o tipo de valor calculado e retornado pelo metodo.

## Structs!

Como as classes, as structs são estruturas de dados que podem conter membrosde dados e membros de ação, mas, diferente das classes, as structs são tipos de valor e não requerem alocação de heap.

Uma variavel de um tipo de struct armazena diretamente os dados da estrutura, enquanto uma variavel de um tipo de classe armazena uma referencia a um objeto alocado na memoria.

Não aceitamherança determinada pelo desenvolvedor.

São uteis para pequenas estruturas de dados que possuem semantica de valor: numeros complexos, pontosem um sitemade coordenadas ou pares de chave-valor em um dicionario são bons exemplos de utilização.

O uso de structs em vez de classes para pequenas estruturas de dados pode fazer uma grande diferença no numero de alocações de memoria.

exemplo:

public class Ponto
{

    public int x, y;
    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}



public static voidMain()
{

    Ponto[] pontos = new Ponto[100];
    for (int i =0; i < 100; i++)
    pontos[i] =  new Ponto(i, i)
}

se fosse com structs:


public struct Ponto
{

    public int x, y;
    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}


* Interfaces 

Uma inteface define um contrato que pode ser implementado por classes e structs.

Uma interface pode conter metodos, propriedades, eventos e indexadores.

Umainteface não fornece implemetações  dos membros que define - apenas suas "assinaturas".

As interfaces podem empregar herança mutipla.

* Unums 

Um enum é um tipo de valor distintocom um conjunto de constantes nomeadas.

Voce define enumeradores quando precisa definir um tipo que pode ter um conjunto de valores discretos.

Eles Usam umdos tipos de valor integral como armazenamento subjacente. eles fornecem significado semantico aos valores discretos.

