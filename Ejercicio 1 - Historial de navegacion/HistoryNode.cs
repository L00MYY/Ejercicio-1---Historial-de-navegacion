using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1___Historial_de_navegacion
{
    internal class HistoryNode
    {
        // Atributos privados: solo la clase puede modificarlos directamente
        private string url;
        private HistoryNode previousNode;
        private HistoryNode nextNode;

        // Constructor: inicializa el nodo con una URL y sin vecinos
        public HistoryNode(string url)
        {
            this.url = url;
            previousNode = null; // aún no tiene página anterior
            nextNode = null; // aún no tiene página siguiente
        }

        // Properties públicas: permiten leer y escribir desde fuera de la clase
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public HistoryNode PreviousNode
        {
            get { return previousNode; }
            set { previousNode = value; }
        }

        public HistoryNode NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }
    }
}
