using System.Drawing;

namespace NotepadApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            onToolStripMenuItem.BackColor = Color.White;
            offToolStripMenuItem.BackColor = Color.LightGray;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open File";
            open.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                writingArea.Text = read.ReadToEnd();
                read.Dispose();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "Text Files (*.txt)|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(writingArea.Text);

                write.Dispose();
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.Text = "";
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.BackColor = Color.DarkGray;
            onToolStripMenuItem.BackColor = Color.LightGray;
            offToolStripMenuItem.BackColor = Color.White;

        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.BackColor = Color.White;
            onToolStripMenuItem.BackColor = Color.White;
            offToolStripMenuItem.BackColor = Color.LightGray;

        }
    }
}
