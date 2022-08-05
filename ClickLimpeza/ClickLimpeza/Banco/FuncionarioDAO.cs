using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ClickLimpeza.Banco;
using MySqlConnector;

namespace ClickLimpeza.Banco
{
    static internal class FuncionarioDAO
    {
        //Cadastro
        public static bool Cadastrar(Funcionario f)
        {
            string comando;
            comando = "INSERT INTO funcionarios (nome_completo, email, telefone, cargo_id) VALUES (@nome, @email, @telefone, @cargo_id)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", f.NomeCompleto);
            cmd.Parameters.AddWithValue("@email", f.Email);
            cmd.Parameters.AddWithValue("@telefone", f.Telefone);
            cmd.Parameters.AddWithValue("@cargo_id", f.IdCargo);

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

        // ListarTodos
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT id, nome_completo, email, telefone , cargos_id FROM funcionarios";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public static DataTable ListarNome()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT id, nome_completo FROM funcionarios";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        // Modificar
        public static bool Modificar(Funcionario f)
        {
            string comando = "UPDATE funcionarios SET nome_completo = @nome, email = @email, telefone = @telefone, cargos_id = @cargo WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", f.Id); 
            cmd.Parameters.AddWithValue("@nome", f.NomeCompleto);
            cmd.Parameters.AddWithValue("@email", f.Email);
            cmd.Parameters.AddWithValue("@telefone", f.Telefone);
            cmd.Parameters.AddWithValue("@cargo", f.IdCargo);

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
            comando = "DELETE FROM funcionarios WHERE id = @id";

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
