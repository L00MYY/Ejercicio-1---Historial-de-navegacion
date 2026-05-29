using Ejercicio_1___Historial_de_navegacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1___Historial_de_navegacion
{
    internal class BrowserHistory
    {
        // Atributos privados
        private HistoryNode head;  // primera página del historial
        private HistoryNode tail;  // última página visitada
        private HistoryNode current;  // página que se muestra ahora
        private int size;  //cantidad de páginas en el historial

        // Constructor: crea un historial vacío
        public BrowserHistory()
        {
            head = null;
            tail = null;
            current = null;
            size = 0;
        }

        // Properties públicas (solo lectura desde fuera)
        public HistoryNode Current
        {
            get { return current; }
        }

        public int Size
        {
            get { return size; }
        }

        public void VisitPage(string url)
        {
            // Se crea el nuevo nodo con la URL recibida
            HistoryNode newNode = new HistoryNode(url);

            if (head == null)
            {
                // Caso 1: la lista está vacía, el nodo es el único elemeto
                head = newNode;
                tail = newNode;
                current = newNode;
            }
            else
            {
                // Caso 2: se enlaza el nuevo nodo al final de la lista
                newNode.PreviousNode = tail; // el nuevo nodo apunta hacia atrás a tail
                tail.NextNode = newNode; // tail apunta hacia adelante al nuevo nodo
                tail = newNode; // tail ahora es el nuevo nodo
                current = newNode; // el usuario ve la página recién visitada
            }

            size++;
        }

        public string GoBack()
        {
            // ¿Existe una página anterior a la actual?
            if (current.PreviousNode != null)
            {
                current = current.PreviousNode; // se retrocede un nodo
                return current.Url;
            }

            // TODO: completar la condición que falta
            // Si current es null (historial vacío) o no hay página anterior,
            // el método debe retornar el mensaje apropiado.
            // Pista: ¿qué ocurre si el usuario presiona Atrás cuando el historial
            // está vacío? ¿Y si ya está en la primera página?


        }

        public void PrintHistory()
        {
            if (head == null)
            {
                Console.WriteLine("El historial está vacío.");
                return;
            }

            Console.WriteLine("Historial de navegación:");

            // Se usa un nodo auxiliar para no perder la referencia a current
            HistoryNode pointer = head;

            while (pointer != null)
            {
                if (pointer == current)
                    Console.WriteLine("-> " + pointer.Url + " (página actual)"); // se marca la página actual con una flecha
                else
                    Console.WriteLine("   " + pointer.Url); // las demás páginas se muestran sin marca

                pointer = pointer.NextNode; // se avanza al siguiente nodo
            }

            Console.WriteLine("===============================");

        }

        public string GoBack()
        {
            // Caso: historial vacío
            if (current == null)
            {
                return "El historial está vacío.";
            }

            // ¿Existe una página anterior a la actual?
            if (current.PreviousNode != null)
            {
                current = current.PreviousNode; // se retrocede un nodo
                return current.Url;
            }

            // Caso: ya estamos en la primera página
            return "Ya estás en la primera página del historial.";
        }
        public string GoForward()
        {
            if (current == null)
            {
                return "El historial está vacío.";
            }

            if (current.NextNode != null)
            {
                current = current.NextNode;
                return current.Url;
            }

            return "Ya estás en la última página del historial.";
        }


    }
}
