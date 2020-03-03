using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string stringConexao = "Data Source=DEV4\\SQLEXPRESS; initial catalog=InLock_Games_Tarde; user Id=sa; pwd=sa@132";

        public void Cadastrar(JogoDomain jogo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = $"INSERT INTO Jogos(NomeJogo, Descricao, DataLancamento, Valor, IdEstudio)" +
                                     $"VALUES ('{jogo.NomeJogo}', '{jogo.Descricao}', '{jogo.DataLancamento}', '{jogo.Valor}', '{jogo.IdEstudio}')";

                SqlCommand cmd = new SqlCommand(queryInsert, con);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public List<JogoDomain> Listar()
        {
            List<JogoDomain> jogos = new List<JogoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string query = "SELECT IdJogo, NomeJogo, Descricao, DataLancamento, Valor, Jogos.IdEstudio, Estudios.IdEstudio, Estudios.NomeEstudio " +
                               "FROM Jogos " +
                               "INNER JOIN Estudios ON Estudios.IdEstudio = Jogos.IdEstudio";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        JogoDomain jogo = new JogoDomain
                        {
                            IdJogo = Convert.ToInt32(rdr["IdJogo"]),
                            NomeJogo = rdr["NomeJogo"].ToString(),
                            Descricao = rdr["Descricao"].ToString(),
                            DataLancamento = Convert.ToDateTime(rdr["DataLancamento"]),
                            Valor = Convert.ToDouble(rdr["Valor"]),
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),
                            Estudio = new EstudioDomain
                            {
                                NomeEstudio = rdr["NomeEstudio"].ToString(),
                                IdEstudio = Convert.ToInt32(rdr["IdEstudio"])
                            }
                        };

                        jogos.Add(jogo);
                    }
                }

                return jogos;
            }
        }
    }
}
