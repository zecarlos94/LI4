using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interrail.classes
{
    public class Utilizador
    {
        private string email;
        private string password;
        private string primeiroNome;
        private string ultimoNome;

        public Utilizador(string email, string password, string primeiroNome, string ultimoNome)
        {
            this.email = email;
            this.password = password;
            this.primeiroNome = primeiroNome;
            this.ultimoNome = ultimoNome;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getPrimeiroNome()
        {
            return this.primeiroNome;
        }

        public string getUltimoNome()
        {
            return this.ultimoNome;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setPrimeiroNome(string primeiroNome)
        {
            this.primeiroNome = primeiroNome;
        }

        public void setUltimoNome(string ultimoNome)
        {
            this.ultimoNome = ultimoNome;
        }
    }
}