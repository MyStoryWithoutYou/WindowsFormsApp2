using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onOffBtn_Click(object sender, EventArgs e)
        {
            if (linkLabel.Enabled == true)
            {
                linkLabel.Enabled = false;
            }
            else
            {
                linkLabel.Enabled = true;
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(changeTxt.Text) || changeTxt.TextLength > 10)
            {
                MessageBox.Show("Неверное значение");
            }
            else
            {
                linkLabel.Text = changeTxt.Text;
            }
        }

        private void changeTxt_Leave(object sender, EventArgs e)
        {
            changeTxt.Text = changeTxt.Text.Trim();
        }

        private void sizeChange_Click(object sender, EventArgs e)
        {
            int max_x = ClientSize.Height - linkLabel.Height;
            int max_y = ClientSize.Width - linkLabel.Width;
            int i;
            if (string.IsNullOrEmpty(lengthTxt.Text) || string.IsNullOrEmpty(widthTxt.Text) || !int.TryParse(lengthTxt.Text, out i) || !int.TryParse(widthTxt.Text, out i))
            {
                MessageBox.Show("Неверное значение");
            }
            else
            {
                int new_height = Convert.ToInt32(lengthTxt.Text);
                int new_width = Convert.ToInt32(widthTxt.Text);
                if (new_height <= 0 || new_width <= 0 || new_width > max_x || new_height > max_y)
                {
                    MessageBox.Show("Неверное значение");
                }
                else
                {
                    linkLabel.Height = new_height;
                    linkLabel.Width = new_width;
                }
            }
        }

        private void locationChange_Click(object sender, EventArgs e)
        {
            int max_x = ClientSize.Height - linkLabel.Height;
            int max_y = ClientSize.Width - linkLabel.Width;
            int i;
            if (string.IsNullOrEmpty(x_change.Text) || string.IsNullOrEmpty(y_change.Text) || !int.TryParse(x_change.Text, out i) || !int.TryParse(y_change.Text, out i))
            {
                MessageBox.Show("Неверное значение");
            }
            else
            {
                int new_x = Convert.ToInt32(x_change.Text);
                int new_y = Convert.ToInt32(y_change.Text);
                if (new_x >= max_x || new_y >= max_y)
                {
                    MessageBox.Show("Вы вышли за пределы формы");
                }
                else
                {
                    linkLabel.Location = new Point(new_x, new_y);
                }

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int max_x = ClientSize.Height - linkLabel.Height;
            int max_y = ClientSize.Width - linkLabel.Width;
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            if (Cursor.Position.X > max_x || Cursor.Position.Y > max_y)
            {
                MessageBox.Show("Вы вышли за пределы формы");
            }
            else
            {
                linkLabel.Location = new Point(x, y);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
