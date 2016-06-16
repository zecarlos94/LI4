using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interrail.classes
{
    public class SubSection
    {
        private string titulo;
        private byte[] image;
        // Audio
        private string coordinates;
        private DateTime data;
        private string texto;

        public SubSection(byte[] image, string titulo, string coordinates, DateTime data)
        {
            this.image = image;
            this.titulo = titulo;
            this.data = data;
            this.coordinates = coordinates;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public byte[] getImage()
        {
            return this.image;
        }

        public string getTexto()
        {
            return this.texto;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public string getCoordinates()
        {
            return this.coordinates;
        }
    }
}