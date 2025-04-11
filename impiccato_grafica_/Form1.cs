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
        string paroleindovinate = "";
        int puntitot = 0;
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
            ultima();
        }
        
        private void button37_Click(object sender, EventArgs e)
        {
            ultima();
            int x = 0;
            indizi(x);
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
            label11.Text = ntentativi.ToString();
        }

        private void media_CheckedChanged(object sender, EventArgs e)
        {
            i = 5;
            j = 10;
            l = 8;
            ntentativi = 7;
            punti = 5;
            label11.Text = ntentativi.ToString();
        }

        private void difficile_CheckedChanged(object sender, EventArgs e)
        {
            i = 10;
            j = 15;
            l = 12;
            ntentativi = 10;
            punti = 7;
            label11.Text = ntentativi.ToString();
        }
        string stamparray(string[] a)
        {
            string e = "";
            for (int i = 0; i < a.Length; i++)
            {
                e += a[i] + " ";
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
            label12.Text = "";
            button8.Enabled = true;
            button31.Enabled = true;
            button28.Enabled = true;
            button18.Enabled = true;
            button16.Enabled = true;
            button20.Enabled = true;
            button12.Enabled = true;
            button19.Enabled = true;
            button32.Enabled = true;
            button29.Enabled = true;
            button22.Enabled = true;
            button9.Enabled = true;
            button17.Enabled = true;
            button11.Enabled = true;
            button13.Enabled = true;
            button33.Enabled = true;
            button26.Enabled = true;
            button30.Enabled = true;
            button25.Enabled = true;
            button21.Enabled = true;
            button24.Enabled = true;
            button15.Enabled = true;
            button27.Enabled = true;
            button23.Enabled = true;
            button10.Enabled = true;
            button14.Enabled = true;
        }
        void provalettera(string[] par, string[] r, string parola, ref int ntentativi, string x)
        {
            if (parola.Contains(x) == true)
            {
                for (int i = 0; i < r.Length; i++)
                {
                    if (r[i] == x)
                    {
                        par[i] = x;
                    }
                }
                label11.Text = ntentativi.ToString();
            }
            else
            {
                ntentativi--;
                label11.Text = ntentativi.ToString();
            }

        }
        private void lettere(string a)
        {
            if (ntentativi > 0)
            {
                string[] r = new string[parola.Length];
                for (int i = 0; i < r.Length; i++)
                {
                    r[i] = parola[i].ToString();
                }
                string z = label3.Text.Replace(" ", "");
                string[] arr = new string[z.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = z[i].ToString();
                }
                string[] par = new string[label3.Text.Length];
                string x = a;
                provalettera(arr, r, parola, ref ntentativi, x);
                label3.Text = stamparray(arr);
                if (label3.Text.Replace(" ", "") == parola)
                {
                    puntitot += punti;
                    label14.Text = puntitot.ToString();
                    label12.Text = "Hai Vinto!!!";
                    label3.Text = parola;
                    paroleindovinate += parola + " ";
                    label13.Text = paroleindovinate;
                }
            }
            else
            {
                label12.Text = "Hai Perso!!!";
                label3.Text = parola;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string x = "a";
            lettere(x);
            button8.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string x = "b";
            lettere(x);
            button31.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string x = "c";
            lettere(x);
            button28.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string x = "d";
            lettere(x);
            button18.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string x = "e";
            lettere(x);
            button16.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string x = "f";
            lettere(x);
            button20.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string x = "i";
            lettere(x);
            button12.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string x = "j";
            lettere(x);
            button19.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string x = "k";
            lettere(x);
            button32.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            string x = "l";
            lettere(x);
            button29.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string x = "m";
            lettere(x);
            button17.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string x = "n";
            lettere(x);
            button9.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string x = "o";
            lettere(x);
            button22.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string x = "z";
            lettere(x);
            button26.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string x = "s";
            lettere(x);
            button33.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string x = "t";
            lettere(x);
            button13.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string x = "u";
            lettere(x);
            button11.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string x = "w";
            lettere(x);
            button30.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string x = "v";
            lettere(x);
            button21.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string x = "x";
            lettere(x);
            button25.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string x = "r";
            lettere(x);
            button27.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string x = "p";
            lettere(x);
            button15.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string x = "g";
            lettere(x);
            button24.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string x = "h";
            lettere(x);
            button14.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string x = "q";
            lettere(x);
            button23.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string x = "y";
            lettere(x);
            button10.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ntentativi > 0)
            {
                if (textBox1.Text == parola)
                {
                    label12.Text = "Hai Vinto!!!";
                    label3.Text = parola;
                    paroleindovinate += parola + " ";
                    label13.Text = paroleindovinate;
                    puntitot += punti;
                    label14.Text = puntitot.ToString();
                }
                else
                {
                    label12.Text = "Hai sbagliato parola!!!";
                    ntentativi--;
                    label11.Text = ntentativi.ToString();
                }
            }
            else
            {
                label12.Text = "Hai Perso!!!";
                label3.Text = parola;
            }
        }
        private void indizi(int x)
        {
            if (ntentativi > 0)
            {
                string[] r = new string[parola.Length];
                for (int i = 0; i < r.Length; i++)
                {
                    r[i] = parola[i].ToString();
                }
                string z = label3.Text.Replace(" ", "");
                string[] arr = new string[z.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = z[i].ToString();
                }
                string[] par = new string[label3.Text.Length];
                arr[x] = r[x];
                ntentativi--;
                label11.Text = ntentativi.ToString();
                label3.Text = stamparray(arr);
            }
            else
            {
                label12.Text = "Hai Perso!!!";
                label3.Text = parola;
            }
            if (label3.Text.Replace(" ", "") == parola)
            {
                puntitot += punti;
                label14.Text = puntitot.ToString();
                label12.Text = "Hai Vinto!!!";
                label3.Text = parola;
                paroleindovinate += parola + " ";
                label13.Text = paroleindovinate;
            }
        }
        private void button36_Click(object sender, EventArgs e)
        {
            int x = 0;
            indizi(x);
        }
        private void ultima()
        {
            if (ntentativi > 0)
            {
                string[] r = new string[parola.Length];
                for (int i = 0; i < r.Length; i++)
                {
                    r[i] = parola[i].ToString();
                }
                string z = label3.Text.Replace(" ", "");
                string[] arr = new string[z.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = z[i].ToString();
                }
                string[] par = new string[label3.Text.Length];
                arr[arr.Length - 1] = r[arr.Length - 1];
                ntentativi--;
                label11.Text = ntentativi.ToString();
                label3.Text = stamparray(arr);
            }
            else
            {
                label12.Text = "Hai Perso!!!";
                label3.Text = parola;
            }
            if (label3.Text.Replace(" ", "") == parola)
            {
                puntitot += punti;
                label14.Text = puntitot.ToString();
                label12.Text = "Hai Vinto!!!";
                label3.Text = parola;
                paroleindovinate += parola + " ";
                label13.Text = paroleindovinate;
            }
        }
    }

}
