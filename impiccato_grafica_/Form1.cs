using System;

namespace impiccato_grafica_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int punti = 0;
        int i = 0, j = 0, l = 0;
        Random random = new Random();
        string parola = "abc";
        int ntentativi = 0;
        string lettere_provate = "";
        
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string x = "Stati.txt";
            parola = stampaparola(x, ref ntentativi, ref punti);

        }
        string stampaparola(string x, ref int n, ref int punti)
        {
            string[] lines = File.ReadAllLines(x); // Legge tutte le righe e le mette in un vettore
            int r = random.Next(i, j);
            return lines[r].Substring(l);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string x = "Cantanti.txt";
            parola = stampaparola(x, ref ntentativi, ref punti);

        }

        private void serie_CheckedChanged(object sender, EventArgs e)
        {
            string x = "Serie.txt";
            parola = stampaparola(x, ref ntentativi, ref punti);
        }

        private void film_CheckedChanged(object sender, EventArgs e)
        {
            string x = "Film.txt";
            parola = stampaparola(x, ref ntentativi, ref punti);
        }

        private void facile_CheckedChanged(object sender, EventArgs e)
        {
            j = 5;
            l = 9;
            ntentativi = 5;
            punti = 3;
        }

        private void media_CheckedChanged(object sender, EventArgs e)
        {
            i = 5;
            j = 10;
            l = 8;
            ntentativi = 7;
            punti = 5;
        }

        private void difficile_CheckedChanged(object sender, EventArgs e)
        {
            i = 10;
            j = 15;
            l = 12;
            ntentativi = 10;
            punti = 7;
        }
        string stamparray(string[] a)
        {
            string e = "";
            for (int i = 0; i < a.Length; i++)
            {
                e += (a[i] + " ");
            }
            return e;
        }
        void trattini(string parola, ref string[] par)
        {
            for (int i = 0; i < parola.Length; i++)
            {
                par[i] = "_";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] par = new string[parola.Length];
            trattini(parola, ref par);
            label3.Text = stamparray(par);
        }
        void provalettera(string[] par, string[] r, string parola,int ntentativi,string lettere_provate,string x)
        {
            lettere_provate = lettere_provate + x + ", ";
            if (parola.Contains(x) == true)
            {
                for (int i = 0; i < r.Length; i++)
                {
                    if (r[i] == x)
                    {
                        par[i] = x;
                    }
                    else
                    {
                        par[i] = "_";
                    }
                }
            }
            else
            {
                ntentativi--;
            }
            ntentativi--;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] r = new string[parola.Length];
            for (int i = 0; i < parola.Length; i++)
            {
                r[i] = parola[i].ToString();
            }
            string[] par = new string[parola.Length];
            string x = "a";
            provalettera(par, r, parola, ntentativi, lettere_provate, x);
            label3.Text = stamparray(par);
        }

    }
           
}
