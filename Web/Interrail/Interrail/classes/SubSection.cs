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
        private byte[] audio;
        private string coordinates;
        private DateTime data;
        private byte[] texto;

        public SubSection(byte[] image, byte[] audio, byte[] texto, string titulo, string coordinates, DateTime data)
        {
            this.image = image;
            this.titulo = titulo;
            this.data = data;
            this.coordinates = coordinates;
            this.texto = texto;
            this.audio = audio;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public byte[] getImage()
        {
            return this.image;
        }

        public byte[] getTexto()
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

        public byte[] getAudio()
        {
            return this.audio;
        }
    }
}