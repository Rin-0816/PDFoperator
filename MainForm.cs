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
            slicer.pdf_slicer(null);
        }
        private void slicer_button_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void slicer_button_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            Slicer slicer = new Slicer();
            slicer.pdf_slicer(fileName);
        }
    }
}
