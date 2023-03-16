using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempoPilhaDinamica
{
    internal class BookPile
    {
        public Book Top { get; set; }

        public BookPile()
        {
            this.Top = null;
            Console.WriteLine("Pilha criada com sucesso!");
        }

        public void Push(Book aux)
        {
            aux.Previous = Top;
            this.Top = aux;
        }

        public void Print()
        {
            Book aux;

            if (IsEmpty())
            {
                Console.WriteLine("Impossível imprimir pilha vazia!");
                return;
            }

            aux = Top;

            Console.WriteLine("Os elementos na pilha são: \n");

            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.Previous;
            } while (aux != null);

            Console.WriteLine("Final da pilha");
        }

        private bool IsEmpty()
        {
            //if (Top == null)
            //{
            //    return true;
            //}
            //return false;

            return (Top == null) ? true : false;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Impossível remover item de pilha vazia!");
                return;
            }

            Top = Top.Previous;
        }
    }
}
