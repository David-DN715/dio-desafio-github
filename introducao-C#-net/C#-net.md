
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

