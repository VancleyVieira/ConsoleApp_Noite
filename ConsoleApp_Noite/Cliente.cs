using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Cliente
    {
        private string Nome;
        private int Id;
        private string Telefone;


        public Cliente(string Nome, int Id, string Telefone) {
            this.Nome = Nome;
            this.Id = Id;
            this.Telefone = Telefone;  
        }

        public string getNome()
        {
            return Nome;
        }

        public int getId()
        {
            return this.Id;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public void setId(int Id) 
        {
            this.Id = Id;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }
    }
}
