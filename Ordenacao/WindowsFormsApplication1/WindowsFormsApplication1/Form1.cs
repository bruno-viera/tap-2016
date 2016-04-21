using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numPosicoes = Convert.ToInt32(txtbox1.Text);

            if(numPosicoes > 99)
            {
                for (int i = 0; i < numPosicoes; i++)
                {
                    listBox1.Items.Add(random.Next(numPosicoes).ToString());
                }
            }
            else
            {
                MessageBox.Show("O vetor precisa ter no mínimo 100 posições!");
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            Stopwatch tempo = new Stopwatch();

            foreach (var item in listBox1.Items)
            {
                list.Add(Convert.ToInt32(item));
            }

            if (radioButton1.Checked)
            {
                tempo.Start();
                clsOrdenacao.Shell(list);
                tempo.Stop();
            }
            else if (radioButton2.Checked)
            {
                tempo.Start();
                clsOrdenacao.Cocktail(list);
                tempo.Stop();
            }
            else if (radioButton3.Checked)
            {
                tempo.Start();
                clsOrdenacao.Insercao(list);
                tempo.Stop();
            }
            else if (radioButton4.Checked)
            {
                tempo.Start();
                clsOrdenacao.Comb(list);
                tempo.Stop();
            }
            else
            {
                tempo.Start();
                clsOrdenacao.Gnome(list);
                tempo.Stop();
            }

            listBox1.Items.Clear();
            foreach (var item in list)
            {
                listBox1.Items.Add(item.ToString());
            }

            label2.Text = tempo.Elapsed.ToString();
        }
    }
}
