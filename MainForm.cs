namespace PDFoperator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slicer_button_Click(object sender, EventArgs e)
        {
            Slicer slicer = new Slicer();
            Console.WriteLine(start_page.Text);
            slicer.pdf_slicer(int.Parse(start_page.Text) - 1, int.Parse(end_page.Text) - 1);
        }

        private void texNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }

            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                //�����ꂽ�L�[�� 0�`9�łȂ��ꍇ�́A�C�x���g���L�����Z������
                e.Handled = true;
            }
        }
    }
}