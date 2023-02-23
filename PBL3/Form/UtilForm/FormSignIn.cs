﻿using System;
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
    public partial class FormSignIn : Form
    {
        private Form _parentForm;

        private bool[] _barIsDirtys = new bool[2] { false, false };

        private readonly string[] _barStrings = new string[] { "Tên Tài Khoản", "Mật Khẩu" };

        private TextBox[] _txtPHHolders = new TextBox[2];

        public FormSignIn(Form parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;

            _txtPHHolders[0] = txtUsername;
            _txtPHHolders[1] = txtPasswrd;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ((LoginForm)_parentForm).OpenChildForm(new FormSignUp(_parentForm));
        }

        private void txtPH_Enter(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;
            if (!_barIsDirtys[index])
            {
                _txtPHHolders[index].Text = string.Empty;
                _txtPHHolders[index].ForeColor = Color.FromArgb(240, 237, 254);

                if (index == 1)
                {
                    _txtPHHolders[index].PasswordChar = '*';
                }
            }
        }

        private void txtPH_Leave(object sender, EventArgs e)
        {
            int index = ((TextBox)sender).TabIndex - 1;
            _barIsDirtys[index] = _txtPHHolders[index].Text.Length != 0;

            if (!_barIsDirtys[index])
            {
                _txtPHHolders[index].Text = _barStrings[index];
                _txtPHHolders[index].ForeColor = Color.FromArgb(119, 112, 156);

                if (index == 1)
                {
                    _txtPHHolders[index].PasswordChar = '\0';
                }
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!_barIsDirtys[1])
            {
                return;
            }

            if (_txtPHHolders[1].PasswordChar == '*')
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
                _txtPHHolders[1].PasswordChar = '\0';
            }
            else
            {
                btnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                _txtPHHolders[1].PasswordChar = '*';
            }
        }

        private void FormSignIn_MouseCaptureChanged(object sender, EventArgs e)
        {
            ActiveControl = null;
            ActiveControl = fakeTabStop;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = (LoginForm)_parentForm;

            LoginForm.MainForm.StartPosition = FormStartPosition.CenterScreen;
            LoginForm.MainForm.Show();

            _parentForm.Hide();
        }
    }
}
