﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public int id_jogador_banco;
        public Pergunta1(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbResposta2.Checked == true)
            {
                MessageBox.Show("ACERTOU MIZERAVIII!!");

                //cadastrar no banco de dados a p
                using (SqlConnection conexao = new SqlConnection("Server=AME0556345W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta,resposta_correta,id_jogador) values(@PERGUNTA,@RESPOSTA_CORRETA,@TB_JOGADOR)", conexao))
                    {
                        comando.Parameters.AddWithValue("PERGUNTA", lblPergunta.Text);
                        comando.Parameters.AddWithValue("RESPOSTA_CORRETA", rdbResposta2.Text);
                        comando.Parameters.AddWithValue("TB_JOGADOR", id_jogador_banco);
                        conexao.Open();
                        //comando.ExecuteNonQuery();

                        if (comando.ExecuteNonQuery() == 1) 
                        {
                            //MessageBox.Show("SALVO");

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


        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }
    
    }
}
