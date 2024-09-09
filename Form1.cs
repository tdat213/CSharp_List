namespace CSharp_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(int.Parse(txtNhap.Text));
            string kq = "";
            foreach (int i in list)
            {
                kq += i.ToString() + " ";

            }
            MessageBox.Show(kq);
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimLe_Click(object sender, EventArgs e)
        {
            foreach (int i in list)
            {
                if(i % 2 != 0)
                {
                    txtSoLe.Text += i.ToString() + " ";
                }
            }

            
        }
    }
}
