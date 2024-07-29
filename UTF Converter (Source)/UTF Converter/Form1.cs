using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;


namespace UTF_Converter
{
    public partial class Form1 : Form
    {
        private string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbExUTF.Items.Add("utf8mb4_0900_ai_ci");
            cmbExChar.Items.Add("CHARSET=utf8mb4");
            cmbNewUTF.Items.Add("utf8mb4_unicode_ci");
            cmbNewUTF.Items.Add("utf8_general_ci");
            cmbNewUTF.Items.Add("utf8mb4_0900_ai_ci");
            cmbNewChar.Items.Add("CHARSET=utf8");
            cmbNewChar.Items.Add("CHARSET=utf8mb4");
            lblFile.ForeColor = Color.Red;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "SQL files (*.sql)|*.sql|Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                lblFile.Text = "File Attached";
                lblFile.ForeColor = Color.Green;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("No file was attached!");
                return;
            }

            string exUTF = cmbExUTF.SelectedItem.ToString();
            string exChar = cmbExChar.SelectedItem.ToString();
            string newUTF = cmbNewUTF.SelectedItem.ToString();
            string newChar = cmbNewChar.SelectedItem.ToString();

            string content = File.ReadAllText(fileName);

            content = content.Replace(exUTF, newUTF);
            content = content.Replace(exChar, newChar);

            if (checkAE.Checked)
            {
                content = Regex.Replace(content, @"AUTO_INCREMENT=\d+", "AUTO_INCREMENT=1");
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SQL files (*.sql)|*.sql|Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, content);
                MessageBox.Show("Successfully Saved");

                checkAE.Checked = false;
                cmbExChar.Text = string.Empty;
                cmbExUTF.Text = string.Empty;
                cmbNewChar.Text = string.Empty;
                cmbNewUTF.Text = string.Empty;
            }
        }
    }
}
