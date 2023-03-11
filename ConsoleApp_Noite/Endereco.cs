using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    internal class Endereco
    {
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cep;
        private string Cidade;
        private string Estado;

        public Endereco(string Rua, string Numero, string Bairro, string Cep, string Cidade, string Estado) 
        { 
            this.Rua = Rua;
            this.Numero = Numero;
            this.Bairro = Bairro;
            this.Cep = Cep;
            this.Cidade = Cidade;
            this.Estado = Estado;

        }

        public string getRua() 
        {
            return this.Rua;
        }
        public string getNumero() 
        {
            return this.Numero;
        }
        public string getBairro() 
        {
            return this.Bairro;
        }
        public string getCep() 
        {
            return this.Cidade;
        }
        public string getCidade() 
        {
            return this.Cidade;
        }
        public string getEstado()
        { 
            return this.Estado; 
        }

        public void setRua(string Rua)
        {
            this.Rua = Rua;        
        }
        public void setNumero(string Numero)
        {
            this.Numero = Numero;
        }
        public void setBairro(string Bairro)
        {
            this.Bairro = Bairro;
        }
        public void setCep(string Cep)
        {
            this.Cep = Cep;
        }
        public void setCidade(string Cidade)
        {
            this.Cidade = Cidade;
        }
        public void setEstado(string Estado)
        {
            this.Estado = Estado;
        }

    }
}
