namespace BelejkiProject
{
    public partial class Form1 : Form
    {

        int noteNumber = 1;
        string saveFolder = "C:\\Notes";

        public Form1()
        {
            InitializeComponent();

            noteTextBox.Multiline = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            
        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string fileName = "belejka" + noteNumber + ".txt";
            string filePath = Path.Combine(saveFolder, fileName);
            File.WriteAllText(filePath, dateTime + Environment.NewLine + noteTextBox.Text);

            noteNumber++;
            noteTextBox.Clear();
        }

        private void folderButton_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    saveFolder = fbd.SelectedPath;
                }
            }
        }
    }
}