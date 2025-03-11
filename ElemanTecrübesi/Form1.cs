namespace ElemanTecrübesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkSifirBes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim=txtIsim.Text;
            string soyIsim=txtSoyIsim.Text;

            if (chkSifirBes.Checked)
            {
                MessageBox.Show("Tecrübesiz");

            }
            if (chkBesOnYil.Checked)
            {
                MessageBox.Show("Tecrübeli");
            }
            else
            {
                MessageBox.Show("Çok Tecrübeli");
            }
        }
    }
}
