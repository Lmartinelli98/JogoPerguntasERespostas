using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JogoDesktop
{
    public partial class Pergunta3 : Form
    {
        public int id_jogador_banco;
        public Pergunta3(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;

        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (rdbResposta1.Checked == true)
            {
                MessageBox.Show("ACERTOU MIZERAVIII!!");

                //cadastrar no banco de dados a p
                using (SqlConnection conexao = new SqlConnection("Server=AME0556345W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta,resposta_correta,id_jogador) values(@PERGUNTA,@RESPOSTA_CORRETA,@TB_JOGADOR)", conexao))
                    {
                        comando.Parameters.AddWithValue("PERGUNTA", lblPergunta.Text);
                        comando.Parameters.AddWithValue("RESPOSTA_CORRETA", rdbResposta1.Text);
                        comando.Parameters.AddWithValue("TB_JOGADOR", id_jogador_banco);
                        conexao.Open();
                       // comando.ExecuteNonQuery();

                        if (comando.ExecuteNonQuery() == 1) 
                        {
                            MessageBox.Show("SALVO");
                            this.Close();
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("ERROOOOUUUUU!!");
            }
        }

        private void rdbResposta4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbResposta1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}
