using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Analizadorlexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(424, 489);
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_texto.Clear();
            txt_texto.Focus();
            dgt_resultado.Rows.Clear();
            this.Size = new Size(424, 489);
        }

        private void btn_analizar_Click(object sender, EventArgs e)
        {
            if (txt_texto.Text == "")
            {
                MessageBox.Show("introducir texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_texto.Focus();
            }
            else
            {
                this.Size = new Size(767, 489);
                dgt_resultado.Rows.Clear();

                int i = 1;

                string ident = (@"(_|[a-zA-Z])(_|[a-zA-Z]|[0-9])*");
                string numero = (@"-?[0-9]+");
                string operador = (@"[\=\+\-/*%]");
                string comparador = (@">|<|==|>=|<=|!");
                string ope_logico = (@"([\|\|\&]{1})");
                string delimitador = (@"[\(\)\{\}\[\];,]");
                string cadena = ("\".*?\"");


                string texto = txt_texto.Text;

                string[] reservadas = new string[10] { "Program", "Para", "Class", "Char", "Int", "Imp", "Leer", "Ter", "Float", "Min" };

                foreach (Match identificador in Regex.Matches(texto, ident, RegexOptions.IgnoreCase))
                {

                    for (int cont = 0; cont <= 9; cont++)
                    {
                        if (identificador.Value == reservadas[cont])
                        {
                            dgt_resultado.Rows.Add();
                            dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                            dgt_resultado.Rows[i - 1].Cells[1].Value = identificador.Value;
                            dgt_resultado.Rows[i - 1].Cells[2].Value = "Reservado";
                            i = i + 1;
                        }

                    }

                }
                foreach (Match num in Regex.Matches(texto, numero, RegexOptions.IgnoreCase))
                {
                    dgt_resultado.Rows.Add();
                    dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                    dgt_resultado.Rows[i - 1].Cells[1].Value = num.Value;
                    dgt_resultado.Rows[i - 1].Cells[2].Value = "Numero";
                    i = i + 1;
                }
                foreach (Match ope in Regex.Matches(texto, operador, RegexOptions.IgnoreCase))
                {
                    dgt_resultado.Rows.Add();
                    dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                    dgt_resultado.Rows[i - 1].Cells[1].Value = ope.Value;
                    dgt_resultado.Rows[i - 1].Cells[2].Value = "Operador Aritmetico";
                    i = i + 1;
                }
                foreach (Match comp in Regex.Matches(texto, comparador, RegexOptions.IgnoreCase))
                {
                    dgt_resultado.Rows.Add();
                    dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                    dgt_resultado.Rows[i - 1].Cells[1].Value = comp.Value;
                    dgt_resultado.Rows[i - 1].Cells[2].Value = "Comparador";
                    i = i + 1;
                }
                foreach (Match ope_l in Regex.Matches(texto, ope_logico, RegexOptions.IgnoreCase))
                {
                    dgt_resultado.Rows.Add();
                    dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                    dgt_resultado.Rows[i - 1].Cells[1].Value = ope_l.Value;
                    dgt_resultado.Rows[i - 1].Cells[2].Value = "Operador Logico";
                    i = i + 1;
                }
                foreach (Match dele in Regex.Matches(texto, delimitador, RegexOptions.IgnoreCase))
                {
                    dgt_resultado.Rows.Add();
                    dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                    dgt_resultado.Rows[i - 1].Cells[1].Value = dele.Value;
                    dgt_resultado.Rows[i - 1].Cells[2].Value = "Delimitador";
                    i = i + 1;
                }
                foreach (Match can in Regex.Matches(texto, cadena, RegexOptions.IgnoreCase))
                {
                    dgt_resultado.Rows.Add();
                    dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                    dgt_resultado.Rows[i - 1].Cells[1].Value = can.Value;
                    dgt_resultado.Rows[i - 1].Cells[2].Value = "Cadena";
                    i = i + 1;
                }
                foreach (Match error in Regex.Matches(texto, ident, RegexOptions.IgnoreCase))
                {


                    dgt_resultado.Rows.Add();
                    dgt_resultado.Rows[i - 1].Cells[0].Value = i;
                    dgt_resultado.Rows[i - 1].Cells[1].Value = error.Value;
                    dgt_resultado.Rows[i - 1].Cells[2].Value = "Error";
                    i = i + 1;


                }
            }

        }
    }
 }
