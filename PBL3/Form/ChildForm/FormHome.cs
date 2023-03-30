﻿using PBLLibrary;
using PBLLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormHome : Form
    {
        private const int _suggestedWordCount = 10;

        private int _currentWordEveryDayIndex = 0;
        private List<WordModel> _wordsEveryDay;

        private bool _reverseState = false;

        public FormHome()
        {
            InitializeComponent();
            InitializeVariables();

            btnSugWord.Text = _wordsEveryDay[0].Word;
        }

        private void InitializeVariables()
        {
            _wordsEveryDay = GlobalConfig.GetWord_Random(_suggestedWordCount);
            foreach (WordModel word in _wordsEveryDay)
            {
                word.Word = word.Word.ToUpper().Replace('_', ' ');
            }
        }

        private void swapWordAnim_Tick(object sender, EventArgs e)
        {
            _currentWordEveryDayIndex = (_currentWordEveryDayIndex + 1) % _wordsEveryDay.Count;

            _reverseState = false;
            sugWordLeftAnim.Start();
        }

        private void btnForward_MouseClick(object sender, MouseEventArgs e)
        {
            _currentWordEveryDayIndex = (_currentWordEveryDayIndex + 1) % _wordsEveryDay.Count;

            _reverseState = false;
            sugWordLeftAnim.Start();
        }

        private void btnBackward_MouseClick(object sender, MouseEventArgs e)
        {
            _currentWordEveryDayIndex = (_currentWordEveryDayIndex - 1) < 0 ? _wordsEveryDay.Count - 1 : (_currentWordEveryDayIndex - 1);

            _reverseState = false;
            sugWordRightAnim.Start();
        }

        private void sugWordLeftAnim_Tick(object sender, EventArgs e)
        {
            if (btnSugWord.Location.X <= -400)
            {
                _reverseState = true;
                btnSugWord.Location = new Point(400, 0);
                btnSugWord.Text = _wordsEveryDay[_currentWordEveryDayIndex].Word;
            }
            else
            {
                if (_reverseState && btnSugWord.Location.X == 0)
                {
                    sugWordLeftAnim.Stop();
                    _reverseState = false;
                    return;
                }
                btnSugWord.Location = new Point(btnSugWord.Location.X - 50, 0);
            }

        }

        private void sugWordRightAnim_Tick(object sender, EventArgs e)
        {
            if (btnSugWord.Location.X >= 400)
            {
                _reverseState = true;
                btnSugWord.Location = new Point(-400, 0);
                btnSugWord.Text = _wordsEveryDay[_currentWordEveryDayIndex].Word;
            }
            else
            {
                if (_reverseState && btnSugWord.Location.X == 0)
                {
                    sugWordRightAnim.Stop();
                    _reverseState = false;
                    return;
                }
                btnSugWord.Location = new Point(btnSugWord.Location.X + 50, 0);
            }
        }

        private void btnSugWord_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.OpenChildForm(new WordForm(btnSugWord.Text.Replace(' ', '_').ToLower()),
                FormStack.FormType.Neutral);
        }

        private void btnGotoNtebk_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.ActivateButton(
                GlobalForm.MainForm.btnNotebook,
                Color.FromArgb(0, 191, 159));
            GlobalForm.MainForm.OpenChildForm(
                GlobalForm.MainForm.NotebookForm,
                FormStack.FormType.Strong);
        }

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            ExternalImport.HideCaret(((NumericUpDown)sender).Handle);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void numericUpDown1_MouseClick_1(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

        private void btnSetGoal_MouseClick(object sender, MouseEventArgs e)
        {
            GlobalForm.MainForm.OpenChildForm(new FormSetGoal(), FormStack.FormType.Neutral);
        }
    }
}
