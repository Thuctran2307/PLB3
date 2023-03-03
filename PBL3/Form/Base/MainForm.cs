using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.Win32;
using CustomControls;
using MySql.Data.MySqlClient;
using PBLLibrary.DataAccess;
using System.Windows.Controls;
using Mysqlx.Crud;
using System.Windows.Controls.Primitives;
using System.Reflection;
using PBLLibrary.Models;
using PBLLibrary;
using System.Threading;

namespace PBL3
{
    public partial class MainForm : Form
    {
        
        public enum StackType
        {
            Replace, Push, Dispose, None
        }

        public LoginForm LoginForm { get; private set; }
        public FormHome HomeForm { get; private set; }
        public Form TopicForm { get; private set; }
        public FormNotebook NotebookForm { get; private set; }
        public Form MinigameForm { get; private set; }
        public FormSetting SettingForm { get; private set; }
        public FormTranslanteText f = new FormTranslanteText();


        private IconButton _currentBtn;
        private Form _currentChildForm;

        private bool _searchBarIsDirty = false;
        private IconButton[] _searchOptions;
        private int _currentSearchOptionIndex;


        public MainForm()
        {
            InitializeComponent();
            SettingFormProperties();
            InitializeChildForm();
            InitializeVariables();

            fadeInFormAnim.Start();

            // FormHome for default
            ActivateButton(btnHome, Color.FromArgb(97, 110, 254));
            OpenChildForm(HomeForm, FormStack.FormType.Strong);

            //vScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;
            //vScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            //vScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
        }
        
        private void InitializeChildForm()
        {
            HomeForm = new FormHome(this);
            NotebookForm = new FormNotebook();
            SettingForm = new FormSetting();
        }

        public void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                _currentBtn = (IconButton)sender;

                _currentBtn.Enabled = false;

                // background
                btnOverlaySelectedBtn.Visible = true;
                btnOverlaySelectedBtn.Location = new Point(btnOverlaySelectedBtn.Location.X, _currentBtn.Location.Y);

                // icon
                iconOverlaySelectedBtn.Visible = true;
                iconOverlaySelectedBtn.Location = new Point(iconOverlaySelectedBtn.Location.X,
                    _currentBtn.Location.Y + 10);
                iconOverlaySelectedBtn.IconChar = _currentBtn.IconChar;
                iconOverlaySelectedBtn.IconColor = color;

                // panel
                rightPanelBtn.BackColor = color;
                rightPanelBtn.Location = new Point(190, _currentBtn.Location.Y);
                rightPanelAnim.Start();

                // childform
                iconChildForm.IconChar = _currentBtn.IconChar;
                iconChildForm.IconColor = color;
                lblChildForm.Text = _currentBtn.Text.ToUpper();
                lblChildForm.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (_currentBtn != null)
            {
                _currentBtn.Enabled = true;
                rightPanelBtn.Location = new Point(190, _currentBtn.Location.Y);
            }

        }

        public void OpenChildForm(Form childForm, /*StackType stackType = StackType.None*/FormStack.FormType formType = FormStack.FormType.Weak)
        {
            if (_currentChildForm != null)
            {
                if (_currentChildForm.GetType() == childForm.GetType())
                {
                    return;
                }

                _currentChildForm.Visible = false;
                //switch (stackType)
                //{
                //    case StackType.Push:
                //        FormStack.Push(_currentChildForm);
                //        break;
                //    case StackType.Replace:
                //        FormStack.Pop();
                //        FormStack.Push(_currentChildForm);
                //        break;
                //    case StackType.Dispose:
                //        _currentChildForm.Close();
                //        break;
                //}

                switch (FormStack.CurrentFormType)
                {
                    case FormStack.FormType.Strong:
                        FormStack.Pop();
                        FormStack.Push(_currentChildForm);
                        break;
                    case FormStack.FormType.Weak:
                        FormStack.Push(_currentChildForm);
                        break;
                    case FormStack.FormType.Neutral:
                        _currentChildForm.Close();
                        break;
                }

            }

            FormStack.CurrentFormType = formType;
            Console.WriteLine(FormStack.Peek() + " " + FormStack.Count().ToString());
            Console.WriteLine(FormStack.CurrentFormType);

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Bottom;
            panelBase.Controls.Add(childForm);
            panelBase.Tag = childForm;
            childForm.Location = new Point(0, 132);
            childForm.SendToBack();
            childForm.Show();
        }

        private void InitializeVariables()
        {
            _searchOptions = new IconButton[10];
            _searchOptions[0] = btnSearchFound1;
            _searchOptions[1] = btnSearchFound2;
            _searchOptions[2] = btnSearchFound3;
            _searchOptions[3] = btnSearchFound4;
            _searchOptions[4] = btnSearchFound5;
            _searchOptions[5] = btnSearchFound6;
            _searchOptions[6] = btnSearchFound7;
            _searchOptions[7] = btnSearchFound8;
            _searchOptions[8] = btnSearchFound9;
            _searchOptions[9] = btnSearchFound10;
        }

        private void SettingFormProperties()
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Region = System.Drawing.Region.FromHrgn(ExternalImport.CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            // Reduce Flicker
            this.DoubleBuffered = true;

            typeof(System.Windows.Forms.Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panelBase, new object[] { true });

            typeof(System.Windows.Forms.Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panelDrag, new object[] { true });
        }
        private void panelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ExternalImport.ReleaseCapture();
            ExternalImport.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form messageBox = new MessageBox("XÁC NHẬN", "Muốn Rời Khỏi?", MessageBox.MessageType.Option);

            messageBox.StartPosition = FormStartPosition.CenterScreen;
            messageBox.ShowDialog();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            // Collapse
            if (panelButton.Size.Width > 180)
            {
                if (expandAnim.Enabled)
                    return;

                btnCollapse.Dock = DockStyle.Top;
                btnCollapse.ImageAlign = ContentAlignment.MiddleCenter;
                btnCollapse.Size = new Size(btnCollapse.Size.Width, 60);
                btnLogo.Visible = false;
                btnPremium.Size = new Size(0, 80);
                btnPremium.Dock = DockStyle.Bottom;
                lblVersion.Visible = false;

                // buttons
                btnHome.Text = string.Empty;

                btnTopic.Text = string.Empty;

                btnNotebook.Text = string.Empty;

                btnGame.Text = string.Empty;

                btnSetting.Text = string.Empty;

                lblChildForm.Text = "";

                collapseAnim.Start();
            }
            // Expand
            else
            {
                if (collapseAnim.Enabled)
                    return;

                btnCollapse.Dock = DockStyle.None;
                btnCollapse.Size = new Size(40, 40);
                // buttons
                btnHome.ImageAlign = ContentAlignment.MiddleLeft;
                btnHome.Padding = new Padding(20, 0, 0, 0);

                btnTopic.ImageAlign = ContentAlignment.MiddleLeft;
                btnTopic.Padding = new Padding(20, 0, 0, 0);

                btnNotebook.ImageAlign = ContentAlignment.MiddleLeft;
                btnNotebook.Padding = new Padding(20, 0, 0, 0);

                btnGame.ImageAlign = ContentAlignment.MiddleLeft;
                btnGame.Padding = new Padding(20, 0, 0, 0);

                btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
                btnSetting.Padding = new Padding(20, 0, 0, 0);

                btnPremium.Size = new Size(150, 40);
                btnPremium.Dock = DockStyle.None;
                lblVersion.Visible = true;
                iconSub.Visible = false;
                expandAnim.Start();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(97, 110, 254));
            OpenChildForm(HomeForm, FormStack.FormType.Strong);
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(127, 135, 255));
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 191, 159));
            OpenChildForm(NotebookForm, FormStack.FormType.Strong);
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 108, 131));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(60, 150, 255));
            OpenChildForm(SettingForm, FormStack.FormType.Strong);
        }

        private void collapseAnim_Tick(object sender, EventArgs e)
        {
            if (panelButton.Size.Width > 80)
            {
                panelButton.Size = new Size(panelButton.Size.Width - 20, panelButton.Size.Height);
            }
            else
            {
                collapseAnim.Stop();
                iconSub.Visible = true;
            }
        }
        private void expandAnim_Tick(object sender, EventArgs e)
        {
            if (panelButton.Size.Width < 200)
            {
                panelButton.Size = new Size(panelButton.Size.Width + 20, panelButton.Size.Height);
            }
            else
            {
                expandAnim.Stop();
                btnLogo.Visible = true;
                btnHome.Text = "Home";
                btnTopic.Text = "Topics";
                btnNotebook.Text = "Notebook";
                btnGame.Text = "Minigames";
                btnSetting.Text = "Settings";

                lblChildForm.Text = _currentBtn.Text.ToUpper();
            }
        }
        private void rightPanelAnim_Tick(object sender, EventArgs e)
        {
            if (rightPanelBtn.Location.X > 60)
            {
                rightPanelBtn.Location = new Point(rightPanelBtn.Location.X - 10, rightPanelBtn.Location.Y);
            }
            else
            {
                rightPanelAnim.Stop();
            }
        }

        private void fadeInFormAnim_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += 0.2;
            else
                fadeInFormAnim.Stop();
        }

        private void fadeOutFormAnim_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
                Opacity -= 0.2;
            else
            {
                fadeInFormAnim.Stop();
                Application.Exit();
            }

        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            //RegistryKey rk = Registry.CurrentUser.OpenSubKey
            //    ("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            //if (chkStartup.Checked)
            //    rk.SetValue("PBL3", Application.ExecutablePath);
            //else
            //    rk.DeleteValue("PBL3", false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                panelSearchFound.Visible = false;
                return;
            }

            List<WordModel> words = GlobalConfig.GetWord_ByFilter(txtSearch.Text.Replace(' ', '_') + "%", 10, true);

            if (words != null)
            {
                panelSearchFound.Size = new Size(panelSearchFound.Size.Width, 25 + 30 * words.Count);

                int i = 0;
                foreach (WordModel w in words)
                {
                    _searchOptions[i++].Text = w.Word.Replace('_', ' ');
                }
            }
            else
            {
                panelSearchFound.Size = new Size(panelSearchFound.Size.Width, 55);
                _searchOptions[0].Text = txtSearch.Text;
            }

            _currentSearchOptionIndex = 0;
            ActiveSearchOption();

            panelSearchFound.Visible = true;

        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            _searchBarIsDirty = txtSearch.Text.Length != 0;
            if (!_searchBarIsDirty)
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.FromArgb(119, 112, 156);
            }

            panelSearchFound.Visible = false;
        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                panelSearchFound.Visible = false;
                _searchOptions[_currentSearchOptionIndex].BackColor = Color.FromArgb(60, 50, 99);

                // When press enter, application make a Ting sound, so this is a little trick
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (GlobalConfig.GetWord_ByFilter(_searchOptions[_currentSearchOptionIndex].Text.Replace(' ', '_')) == null)
                {
                    OpenChildForm(new WordForm_None(this, txtSearch.Text.Replace(' ', '_')), FormStack.FormType.Neutral);
                }
                else
                {
                    OpenChildForm(new WordForm(this, _searchOptions[_currentSearchOptionIndex].Text.Replace(' ', '_')),
                        FormStack.FormType.Neutral);
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                ResetSearchOption();
                _currentSearchOptionIndex = (_currentSearchOptionIndex + 1) % 10;
                ActiveSearchOption();
            }

            if (e.KeyCode == Keys.Up)
            {
                ResetSearchOption();
                _currentSearchOptionIndex = (_currentSearchOptionIndex == 0) ? 9 : _currentSearchOptionIndex - 1;
                ActiveSearchOption();
            }

        }

        private void ActiveSearchOption()
        {
            _searchOptions[_currentSearchOptionIndex].BackColor = Color.FromArgb(50, 40, 80);
        }

        private void ResetSearchOption()
        {
            _searchOptions[_currentSearchOptionIndex].BackColor = Color.FromArgb(60, 50, 99);
        }
        private void btnSearchFound_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.GetWord_ByFilter(_searchOptions[_currentSearchOptionIndex].Text.Replace(' ', '_')) == null)
            {
                OpenChildForm(new WordForm_None(this, ((IconButton)sender).Text.Replace(' ', '_')), FormStack.FormType.Neutral);
            }
            else
            {
                OpenChildForm(new WordForm(this, ((IconButton)sender).Text.Replace(' ', '_')), FormStack.FormType.Neutral);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!_searchBarIsDirty)
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.FromArgb(240, 237, 252);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;

            if (LoginForm == null)
            {
                LoginForm = new LoginForm();
                ((LoginForm)LoginForm).MainForm = this;
            }

            LoginForm.Show();

            this.Hide();
        }


        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = !panelPersonal.Visible;
        }

        private void btnPersonalSetting_MouseClick(object sender, MouseEventArgs e)
        {
            panelPersonal.Visible = false;

            ActivateButton(btnSetting, Color.FromArgb(60, 150, 255));
            OpenChildForm(SettingForm, FormStack.FormType.Strong);
        }

        private void btnLogo_MouseClick(object sender, MouseEventArgs e)
        {
            ActivateButton(btnHome, Color.FromArgb(97, 110, 254));

            OpenChildForm(HomeForm, FormStack.FormType.Strong);
        }

        private void btnPersonalInfo_MouseClick(object sender, MouseEventArgs e)
        {
            panelPersonal.Visible = false;

            OpenChildForm(new FormProfile(this), FormStack.FormType.Neutral);
        }

        private void btnPremium_MouseClick(object sender, MouseEventArgs e)
        {
            Form premiumForm = new FormPremium();
            premiumForm.ShowDialog();
        }

        private void btnSearchType_CheckedChanged(object sender, EventArgs e)
        {
            if (lblSearchType.Text.CompareTo("ANH - ANH") == 0)
            {
                lblSearchType.Text = "ANH - VIET";
            }    
            else
            {
                lblSearchType.Text = "ANH - ANH";
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(f, FormStack.FormType.Strong);
            f.exitForm += OpenChildForm;
        }
    }
}