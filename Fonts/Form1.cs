using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fonts
{
    public partial class Form1 : Form
    {
        ComboBox.ObjectCollection fontAllowedItems;
        ComboBox.ObjectCollection colorAllowedItems;
        int size;

        public Form1()
        {
            InitializeComponent();

            fontAllowedItems = comboBoxFonts.Items;
            colorAllowedItems = comboBoxColor.Items;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                size = int.Parse(textBoxSize.Text);
            }
            catch
            {
                MessageBox.Show(
                    "Размер шрифта должен быть положительным целым числом",
                    "Нет, не так",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

                textBoxSize.Text = string.Empty;
                return;
            }

            textBoxText.Font = new Font(comboBoxFonts.Text, size);
            
            switch (comboBoxColor.Text)
            {
                case "Чёрный":
                    textBoxText.ForeColor = Color.Black;
                    break;
                case "Синий":
                    textBoxText.ForeColor = Color.Blue;
                    break;
                case "Жёлтый":
                    textBoxText.ForeColor = Color.Yellow;
                    break;
                case "Красный":
                    textBoxText.ForeColor = Color.Red;
                    break;
                case "Зелёный":
                    textBoxText.ForeColor = Color.Green;
                    break;
            }
        }

    }
}
