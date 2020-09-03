using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamoraesClinica
{
    class modelos
    {
        private int ncodigo;
        private string nnome;
        private string nEmail;
        private int ntelefone;

        public int Codigo
        {
            get { return ncodigo; }
            set { ncodigo = value; }

        }

        public string Nome
        {
            get { return nnome; }
            set { nnome = value; }
        }
        public string Email

        {
            get { return nEmail; }
            set { nEmail = value; }  

            }

        public int Telefone
        {
            get { return ntelefone; }
            set { ntelefone = value; }
        }
    }
}
