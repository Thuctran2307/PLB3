using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormProfile : Form
    {
        private Form _parentForm;

        private Font _overFont;
        private Font _primaryFont;

        // TO-DO
        //private PersonModel ;

        public FormProfile(Form parentForm)
        {
            _parentForm = parentForm;

            InitializeComponent();

            _primaryFont = btnAdjust1.Font;
            _overFont = new Font(_primaryFont.FontFamily, _primaryFont.Size, FontStyle.Underline);
        }

        private bool ValidateDate()
        {
            string[] split = txtDate.Text.Split('/');
            int[] date = new int[3];

            if (split.Length != 3)
            {
                return false;
            }
            else
            {
                int i = 0;
                foreach (string s in split)
                {
                    if (!int.TryParse(s, out date[i++]))
                    {
                        return false;
                    }
                }

                try
                {
                    DateTime dateTime = new DateTime(date[2], date[1], date[0]);
                }
                catch
                {
                    return false;
                }

            }

            return true;
        }
        private void btnAdjust1_MouseEnter(object sender, EventArgs e)
        {
            ((IconButton)sender).Font = _overFont;
            ((IconButton)sender).IconColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust1_MouseLeave(object sender, EventArgs e)
        {
            ((IconButton)sender).Font = _primaryFont;
            ((IconButton)sender).IconColor = Color.Transparent;
        }

        private void btnReturn_MouseClick(object sender, MouseEventArgs e)
        {
            ((MainForm)_parentForm).panelPersonal.Visible = false;
            ((MainForm)_parentForm).OpenChildForm(FormStack.Pop(), FormStack.FormType.Strong);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).ReadOnly)
            {
                HideCaret(((TextBox)sender).Handle);
                ActiveControl = null;
            }
        }

        private void btnAdjust1_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            ActiveControl = txtName;

            txtName.ReadOnly = false;
            txtName.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust2_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            ActiveControl = txtEmail;

            txtEmail.ReadOnly = false;
            txtEmail.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust3_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            datePicker.Visible = true;
            ActiveControl = txtDate;

            txtDate.ReadOnly = false;
            txtDate.ForeColor = Color.FromArgb(240, 237, 254);
        }

        private void btnAdjust4_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonToDefault();

            cmbBoxGender.Text = txtGender.Text;
            cmbBoxGender.Visible = true;
            ActiveControl = cmbBoxGender;

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActiveControl = null;
            }
        }

        private void ResetButtonToDefault()
        {
            datePicker.Visible = false;
            cmbBoxGender.Visible = false;

            txtName.ForeColor = Color.FromArgb(119, 112, 156);
            txtEmail.ForeColor = Color.FromArgb(119, 112, 156);
            txtDate.ForeColor = Color.FromArgb(119, 112, 156);
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            if (txtDate.ReadOnly || ActiveControl == datePicker)
            {
                return;
            }
            
            if (ValidateDate())
            {
                string[] split = txtDate.Text.Split('/');
                int[] date = new int[3];

                int i = 0;
                foreach (string s in split)
                {

                    date[i++] = Convert.ToInt32(s);
                }

                DateTime dateTime = new DateTime(date[2], date[1], date[0]);
                datePicker.Value = dateTime;
                txtDate.ForeColor = Color.FromArgb(119, 112, 156);
                txtDate.ReadOnly = true;
                datePicker.Visible = false;
            }
            else
            {
                Form messageBox = new MessageBox("NHẬP SAI", "Nhập Sai Ngày Sinh", MessageBox.MessageType.Info);
                messageBox.ShowDialog();
                txtDate.Text = "01/01/2003";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!txtName.ReadOnly)
            {
                ((TextBox)sender).ReadOnly = true;
                ((TextBox)sender).ForeColor = Color.FromArgb(119, 112, 156);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!txtEmail.ReadOnly)
            {
                string[] splits = txtEmail.Text.Split('@');
                if (splits.Length != 2)
                {
                    Form messageBox = new MessageBox("NHẬP SAI", "Nhập Sai Email", MessageBox.MessageType.Info);
                    messageBox.ShowDialog();
                    txtEmail.Text = "email@gmail.com";
                }
                else
                {
                    txtEmail.ReadOnly = true;
                    txtEmail.ForeColor = Color.FromArgb(119, 112, 156);
                }
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = datePicker.Text;
            txtDate.ReadOnly = true;
            txtDate.ForeColor = Color.FromArgb(119, 112, 156);
        }

        private void cmbBoxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtGender.Text = cmbBoxGender.SelectedItem.ToString();
            cmbBoxGender.Visible = false;
        }

        private void btnChangeImage_MouseClick(object sender, MouseEventArgs e)
        {
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            fileDialog.ShowDialog();
            btnImage.BackgroundImage = Image.FromStream(fileDialog.OpenFile());
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
