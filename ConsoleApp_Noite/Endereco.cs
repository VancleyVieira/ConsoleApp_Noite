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

    }
}
