using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SamoraesClinica
{
    class dao
    {
        private MySqlConnection conexao;
        public void cadastro(modelos mo)
        {
            string banco = "SERVER=localhost;Database=samoraesclinica;UID=root;PASSAWORD=;";
            try
            {
                conexao = new MySqlConnection(banco);
                conexao.Open();

                string inserir = "INSERT INTO projclinica(nome,email,telefone)values('" + mo.Nome + "','" + mo.Email + "','" + mo.Telefone + "')";

                MySqlCommand comandos = new MySqlCommand(inserir, conexao);

                comandos.ExecuteNonQuery();
                conexao.Close();
            }

            catch(Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }
        }

    }
}
