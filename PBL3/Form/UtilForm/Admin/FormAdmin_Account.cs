﻿using BLL.Workflows;
using PBL3.Utilities;
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

    public partial class FormAdmin_Account : Form
    {

        private string[] placeholder =
        {
            "ID: 1",
            "UserName: phuongthao1204",
            "Name: Phương Thảo",
            "BirthDate: 12/04/2003",
            "Email: phuongthao1204@gmail.com"
        };

        private enum SearchBy
        {
            None,
            ID,
            UserName,
            Name,
            BirthDate,
            Email,
        };

        public FormAdmin_Account()
        {
            InitializeComponent();
            SetUpUI();
        }

        

        private void SetUpUI()
        {
            ShowListAccount(SearchBy.None);

            rjComboBox1.SelectedIndex = 0;
            setPlaceholder();
        }

        private void setPlaceholder()
        {
            txtSearch.ForeColor = Color.FromArgb(119, 112, 156);
            txtSearch.Text = placeholder[rjComboBox1.SelectedIndex];
        }
        private void ShowListAccount(SearchBy searchBy)
        {
            DataManager dataManager = new DataManager();
            try
            {
                switch (searchBy)
                {
                    case SearchBy.None:
                        {
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.ID:
                        {
                            int id = Convert.ToInt32(txtSearch.Text);
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.AccountID == id).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.UserName:
                        {
                            string userName = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.UserName == userName).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.Name:
                        {
                            string name = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.Name.Contains(name)).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.BirthDate:
                        {
                            DateTime birthDate = Convert.ToDateTime(txtSearch.Text);
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.BirthDate == birthDate).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    case SearchBy.Email:
                        {
                            string email = txtSearch.Text;
                            dataGridView1.DataSource = dataManager.AccountManager.GetListAccounts().Where(p => p.Email == email).Select(p => new
                            {
                                p.AccountID,
                                p.UserName,
                                p.Name,
                                p.BirthDate,
                                p.Email,
                                Gender = (p.Gender) ? "Nam" : "Nữ",
                                Balance = dataManager.AccountManager.GetAccountDetail(p.AccountID).Balance,
                            }).ToList();
                            break;
                        }

                    

                }
            }
            catch (Exception ex)
            {
                FormMessageBox f = new FormMessageBox("Vui lòng nhập lại", "Định dạng thông tin nhập không  hợp lệ", FormMessageBox.MessageType.Info);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }


        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            FormAdmin_Account_Add form = new FormAdmin_Account_Add();
            form.ShowListAccount += (Object, EventArgs) => {
                btnSearch_Click(this, new EventArgs());
            };
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "" || placeholder.Any(i => i == txtSearch.Text))
            {
                ShowListAccount(SearchBy.None);
                return;
            }

            switch(rjComboBox1.SelectedItem.ToString())
            {
                case "ID":
                    {
                        ShowListAccount(SearchBy.ID);
                        break;
                    }

                case "UserName":
                    {
                        ShowListAccount(SearchBy.UserName);
                        break;
                    }

                case "Name":
                    {
                        ShowListAccount(SearchBy.Name);
                        break;
                    }

                case "BirthDate":
                    {
                        ShowListAccount(SearchBy.BirthDate);
                        break;
                    }

                case "Email":
                    {
                        ShowListAccount(SearchBy.Email);
                        break;
                    }

            }
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (!placeholder.Any(i => i == txtSearch.Text))
            {
                return;
            }
            txtSearch.ForeColor = Color.White;
            txtSearch.Text = "";
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = dataGridView1.SelectedRows.Count;
            if (selectedRowsCount > 0)
            {
                DataManager dataManager = new DataManager();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if(!dataManager.AccountManager.DeleteAccount((int)row.Cells[0].Value))
                    {
                        new FormMessageBox("Lỗi", "Xóa tài khoản không thành công", FormMessageBox.MessageType.Info);
                    }
                }
                ShowListAccount(SearchBy.None);
            }
        }
    }
}
