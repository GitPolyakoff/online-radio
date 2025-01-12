using System;
using System.Windows.Forms;

namespace OnlineRadio
{
    public partial class AddForm : Form
    {
        public string StationName { get; private set; }
        public string StreamUrl { get; private set; }

        public AddForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void addCodeeloButton_Click(object sender, EventArgs e)
        {
            StationName = codeeloNameTextBox.Text;
            StreamUrl = codeeloLinkTextBox.Text;

            if (!string.IsNullOrEmpty(StationName) && !string.IsNullOrEmpty(StreamUrl))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelCcodeeloButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}