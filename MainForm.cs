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
            int start = -1;
            int end = -1;
            try
            {
                start = int.Parse(start_page.Text) - 1;
                end = int.Parse(end_page.Text) - 1;

            } catch
            {

            }
            if (start != -1 && end != -1)
            {
                slicer.pdf_slicer(start, end);
            }
            else
            {
                MessageBox.Show("�y�[�W�ԍ��𐳂������͂��Ă��������B");
            }
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
