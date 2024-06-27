namespace DisposeVSFinalizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clone1_Click(object sender, EventArgs e)
        {
            using Clone clone1 = new(1);
        }

        private void Clone2_Click(object sender, EventArgs e)
        {
            Clone clone2 = new(2);
            clone2 = null;
        }

        private void GarbageCollector_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}