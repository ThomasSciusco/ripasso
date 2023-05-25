using ripasso.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ripasso
{
    public struct prodotto
    {
        public string nome; 
        public float prezzo;
    }
    public partial class Form1 : Form
    {
        public prodotto[] p ;
        public int dim;
        string nomefile;
        Class1 f;
        Aggiunta c;
        public Form1()
        {
            InitializeComponent();
            p= new prodotto[100];
            dim = 0;
            nomefile = @"file.csv";
            f = new Class1();
            c = new Aggiunta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void SalvaFile(prodotto[] p,int dim,string filename)
        {
            using(StreamWriter sw= new StreamWriter(filename)) 
            {
                for (int i=0;i<dim;i++) 
                {
                    sw.WriteLine(p[i].nome + ";" + p[i].prezzo);
                }
                sw.Close();
            }
        }
        public void Aggiunta(prodotto[] p, ref int di,string nome1, float prezzo1)
        {
            p[dim].nome = nome1;
            p[dim].prezzo = prezzo1;
            dim++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           c.Aggiunta(p,ref dim,textBox1.Text,float.Parse(textBox2.Text)); 
                
        }
    }
}
