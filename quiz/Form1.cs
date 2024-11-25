namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if(radioButton2.Checked) s++;
            if(checkBox1.Checked) s++;
            if(checkBox2.Checked) s++;
            if(checkBox3.Checked) s=1;
            if (s == 3) MessageBox.Show("Felicitari! Punctajul este " + s.ToString());
            else MessageBox.Show("Punctajul este " + s.ToString());             
        }
    }
}
