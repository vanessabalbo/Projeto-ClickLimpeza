using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using ClickLimpeza.Classes;
using System.Threading.Tasks;

namespace ClickLimpeza.Banco
{
    static internal class ClienteDAO
    {
        //Cadastro
        public static bool Cadastrar(Cliente c)
        {
            string comando;
            comando = "INSERT INTO clientes (nome_completo, telefone, email, endereco) VALUES (@nome, @telefone, @email, @endereco)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", c.NomeCompleto);
            cmd.Parameters.AddWithValue("@telefone", c.Telefone);
            cmd.Parameters.AddWithValue("@email", c.Email);
            cmd.Parameters.AddWithValue("@endereco", c.Endereco);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT id, nome_completo, telefone, email , endereco FROM clientes";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        // Modificar
        public static bool Modificar(Cliente c)
        {
            string comando = "UPDATE clientes SET nome_completo = @nome, telefone = @telefone, email = @email, endereco = @endereco WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@nome", c.NomeCompleto);
            cmd.Parameters.AddWithValue("@telefone", c.Telefone);
            cmd.Parameters.AddWithValue("@email", c.Email);
            cmd.Parameters.AddWithValue("@endereco", c.Endereco);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Apagar
        public static bool ApagarPorId(int id)
        {
            string comando;
            comando = "DELETE FROM clientes WHERE id = @id";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", id);


            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
    
}
