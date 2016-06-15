using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interrail.classes
{
    public class SubSection
    {
        private string titulo;
        // Fotografia
        // Audio
        // Coordenadas
        private DateTime data;
        private string texto;

        public SubSection(string titulo, DateTime data)
        {
            this.titulo = titulo;
            this.data = data;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public string getTexto()
        {
            return this.texto;
        }
    }
}