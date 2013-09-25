using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEducativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Ultima tela


        private void button3DadoCertoSq1_Click(object sender, EventArgs e)
        {            
            pictureBox2AcertoSq1.Visible = true;          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
              pictureBox2AcertoSq1.Visible = false;
              pictureBox1ErradoSq1.Visible = false;
        }

        private void button2DadoErradoSq1_Click(object sender, EventArgs e)
        {
            pictureBox1ErradoSq1.Visible = true;
        }

        private void button1DadoErradoSq1_Click(object sender, EventArgs e)
        {
            pictureBox1ErradoSq1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Penultima tela


        private void button4CertoSq2_Click(object sender, EventArgs e)
        {
            pictureBox1AcertoSq2.Visible = true;            
        }

        private void button5ErradoSq2_Click(object sender, EventArgs e)
        {
            pictureBox2ErroSq2.Visible = true;
        }

        private void button3ErradoSq2_Click(object sender, EventArgs e)
        {
            pictureBox2ErroSq2.Visible = true;;
        }

        private void panel2Sq2_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1AcertoSq2.Visible = false;
            pictureBox2ErroSq2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1Sq1.Visible = true;
            panel2Sq2.Visible = false;
        }
        #endregion

        #region Primeira tela das figuras de sequencias

        private void button6CertoSq3_Click(object sender, EventArgs e)
        {
            pictureBox1CertoSq3.Visible = true;
        }

        private void button5ErradoSq3_Click(object sender, EventArgs e)
        {
            pictureBox2ErradoSq3.Visible = true;
        }

        private void button4ErradoSq3_Click(object sender, EventArgs e)
        {
            pictureBox2ErradoSq3.Visible = true;
        }

        private void panel1Sq3_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1CertoSq3.Visible = false;
            pictureBox2ErradoSq3.Visible = false;
        }
        private void button3ProximaTelaSq3_Click(object sender, EventArgs e)
        {
            panel2Sq2.Visible = true;
            panel1Sq3.Visible = false;
        }
        #endregion

        #region Tela Inicial
        private void button2Sair_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button2Comecar_Click(object sender, EventArgs e)
        {
            panel1Sq3.Visible = true;
            panel2Sq2.Visible = true;
            panel1Sq1.Visible = true;
            button2Comecar.Visible = false;
            label12.Visible = false;
            button2Sair.Visible = false;
            pictureBox1TelaInicial.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1Sq1.Visible = false;
            panel2Sq2.Visible = false;
            panel1Sq3.Visible = false;
        }
        #endregion

       
    }
}
