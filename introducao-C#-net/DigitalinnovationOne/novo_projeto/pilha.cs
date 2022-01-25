using System;

namespace EstruturaDoPrograma.Exemplos
{
    public class Pilha
    {
        Posicao primeiro;
        public void Empilha(object item) 
        { //passamos para variavel primeiro uma nova posicao, e o item.
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha() 
        {  //se a primeiraposicaofornula ou vazia
            if (primeiro == null)
            {  //lance um novo tratamento de execoes!
                throw new InvalidOperationException("A pilha está vazia...");
            }
            //objeto resultado é passado oprimeiro item
            object resultado = primeiro.item;
            //primeiro recebe oproximo item
            primeiro = primeiro.proximo;
            //retornamos a variavel resultado como novo primeiro lugar
            return resultado;
        }
        
        class Posicao
        {
            public Posicao proximo;
            public object item;
            public Posicao(Posicao proximo, object item)
            {  //este proximo é o proximo
                this.proximo = proximo;
                //este item é o item
                this.item = item;
            }
        }
    }
}