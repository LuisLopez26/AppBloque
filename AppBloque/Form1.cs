using AppBloque.Models;
using AppBloque.Algoritmos;

namespace AppBloque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;
            if (numero <= 3)
                return true;
            if (numero % 2 == 0 || numero % 3 == 0)
                return false;

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            // Paso 0: Condic�on de vac�o
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
                textBox4.Text.Equals("") ||
                textBox5.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser NO VACÍOS");
                return;

            }
            int m = Convert.ToInt32(textBox3.Text);

            if ( EsPrimo(m) == false)
            {
                MessageBox.Show("m tiene que ser un valor primo");
                return;
            }

            int a = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);
            // int m = Convert.ToInt32(textBox3.Text);
            int x0 = Convert.ToInt32(textBox4.Text);
            int total = Convert.ToInt32(textBox5.Text);

            // Paso 0: Condic�on de vac�o
            if (a <= 0 ||
                c <= 0 || m <= 0 ||
                x0 <= 0 ||
                total <= 0)
            {
                MessageBox.Show("Los números deben ser mayor que CERO");
                return;

            }

            AlgoritmoGenerador algoritmo = new AlgoritmoGenerador();
            List<int> listaValoresPseudoAleatorios = algoritmo.
                AlgoritmoCongruenciaLineal(a, m, c, x0, total);
            //textBox2.Text = media.ToString();

            llenarGrid3(listaValoresPseudoAleatorios);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void llenarGrid2(List<Viaje> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].Costo.ToString();
                //dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();

            }
        }

        public void llenarGrid3(List<int> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";


            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //int i = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}