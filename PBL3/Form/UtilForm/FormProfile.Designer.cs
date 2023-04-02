﻿namespace PBL3
{
    partial class FormProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnAdjust1 = new FontAwesome.Sharp.IconButton();
            this.btnAdjust2 = new FontAwesome.Sharp.IconButton();
            this.btnAdjust3 = new FontAwesome.Sharp.IconButton();
            this.btnAdjust4 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton3 = new CustomControls.RJButton();
            this.datePicker = new CustomControls.RJDatePicker();
            this.cmbBoxGender = new CustomControls.RJComboBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(93, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông Tin Cá Nhân";
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnReturn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 30;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(128, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtName.Location = new System.Drawing.Point(287, 143);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(314, 33);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "name";
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(128, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Liên Hệ";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtEmail.Location = new System.Drawing.Point(287, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(314, 33);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Text = "email@gmail.com";
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(128, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày Sinh";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtDate.Location = new System.Drawing.Point(287, 231);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(314, 33);
            this.txtDate.TabIndex = 14;
            this.txtDate.Text = "01/01/2003";
            this.txtDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtDate.Leave += new System.EventHandler(this.txtDate_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(128, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giới Tính";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGender.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.txtGender.Location = new System.Drawing.Point(287, 279);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(314, 33);
            this.txtGender.TabIndex = 16;
            this.txtGender.Text = "Nam";
            this.txtGender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            // 
            // btnAdjust1
            // 
            this.btnAdjust1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjust1.FlatAppearance.BorderSize = 0;
            this.btnAdjust1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjust1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnAdjust1.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAdjust1.IconColor = System.Drawing.Color.Transparent;
            this.btnAdjust1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdjust1.IconSize = 20;
            this.btnAdjust1.Location = new System.Drawing.Point(668, 138);
            this.btnAdjust1.Name = "btnAdjust1";
            this.btnAdjust1.Size = new System.Drawing.Size(146, 42);
            this.btnAdjust1.TabIndex = 17;
            this.btnAdjust1.Text = "Chỉnh Sửa";
            this.btnAdjust1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjust1.UseVisualStyleBackColor = true;
            this.btnAdjust1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAdjust1_MouseClick);
            this.btnAdjust1.MouseEnter += new System.EventHandler(this.btnAdjust1_MouseEnter);
            this.btnAdjust1.MouseLeave += new System.EventHandler(this.btnAdjust1_MouseLeave);
            // 
            // btnAdjust2
            // 
            this.btnAdjust2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjust2.FlatAppearance.BorderSize = 0;
            this.btnAdjust2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjust2.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnAdjust2.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAdjust2.IconColor = System.Drawing.Color.Transparent;
            this.btnAdjust2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdjust2.IconSize = 20;
            this.btnAdjust2.Location = new System.Drawing.Point(668, 181);
            this.btnAdjust2.Name = "btnAdjust2";
            this.btnAdjust2.Size = new System.Drawing.Size(146, 42);
            this.btnAdjust2.TabIndex = 18;
            this.btnAdjust2.Text = "Chỉnh Sửa";
            this.btnAdjust2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjust2.UseVisualStyleBackColor = true;
            this.btnAdjust2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAdjust2_MouseClick);
            this.btnAdjust2.MouseEnter += new System.EventHandler(this.btnAdjust1_MouseEnter);
            this.btnAdjust2.MouseLeave += new System.EventHandler(this.btnAdjust1_MouseLeave);
            // 
            // btnAdjust3
            // 
            this.btnAdjust3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjust3.FlatAppearance.BorderSize = 0;
            this.btnAdjust3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjust3.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnAdjust3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAdjust3.IconColor = System.Drawing.Color.Transparent;
            this.btnAdjust3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdjust3.IconSize = 20;
            this.btnAdjust3.Location = new System.Drawing.Point(668, 226);
            this.btnAdjust3.Name = "btnAdjust3";
            this.btnAdjust3.Size = new System.Drawing.Size(146, 42);
            this.btnAdjust3.TabIndex = 19;
            this.btnAdjust3.Text = "Chỉnh Sửa";
            this.btnAdjust3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjust3.UseVisualStyleBackColor = true;
            this.btnAdjust3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAdjust3_MouseClick);
            this.btnAdjust3.MouseEnter += new System.EventHandler(this.btnAdjust1_MouseEnter);
            this.btnAdjust3.MouseLeave += new System.EventHandler(this.btnAdjust1_MouseLeave);
            // 
            // btnAdjust4
            // 
            this.btnAdjust4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdjust4.FlatAppearance.BorderSize = 0;
            this.btnAdjust4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdjust4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjust4.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjust4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.btnAdjust4.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAdjust4.IconColor = System.Drawing.Color.Transparent;
            this.btnAdjust4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdjust4.IconSize = 20;
            this.btnAdjust4.Location = new System.Drawing.Point(668, 274);
            this.btnAdjust4.Name = "btnAdjust4";
            this.btnAdjust4.Size = new System.Drawing.Size(146, 42);
            this.btnAdjust4.TabIndex = 20;
            this.btnAdjust4.Text = "Chỉnh Sửa";
            this.btnAdjust4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdjust4.UseVisualStyleBackColor = true;
            this.btnAdjust4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAdjust4_MouseClick);
            this.btnAdjust4.MouseEnter += new System.EventHandler(this.btnAdjust1_MouseEnter);
            this.btnAdjust4.MouseLeave += new System.EventHandler(this.btnAdjust1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panel1.Location = new System.Drawing.Point(99, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 5);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panel2.Location = new System.Drawing.Point(181, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 5);
            this.panel2.TabIndex = 22;
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 30;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton3.Location = new System.Drawing.Point(820, 410);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(208, 60);
            this.rjButton3.TabIndex = 56;
            this.rjButton3.TabStop = false;
            this.rjButton3.Text = "LƯU THÔNG TIN";
            this.rjButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // datePicker
            // 
            this.datePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker.BorderSize = 0;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.datePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(601, 226);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(35, 35);
            this.datePicker.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.datePicker.TabIndex = 55;
            this.datePicker.TabStop = false;
            this.datePicker.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.datePicker.Visible = false;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.cmbBoxGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.cmbBoxGender.BorderSize = 0;
            this.cmbBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGender.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.cmbBoxGender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không"});
            this.cmbBoxGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.cmbBoxGender.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(253)))));
            this.cmbBoxGender.Location = new System.Drawing.Point(272, 270);
            this.cmbBoxGender.MinimumSize = new System.Drawing.Size(200, 0);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(349, 41);
            this.cmbBoxGender.TabIndex = 23;
            this.cmbBoxGender.Texts = "Nam";
            this.cmbBoxGender.Visible = false;
            this.cmbBoxGender.OnSelectedIndexChanged += new System.EventHandler(this.cmbBoxGender_OnSelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(25, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 59;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.cmbBoxGender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdjust4);
            this.Controls.Add(this.btnAdjust3);
            this.Controls.Add(this.btnAdjust2);
            this.Controls.Add(this.btnAdjust1);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGender;
        private FontAwesome.Sharp.IconButton btnAdjust1;
        private FontAwesome.Sharp.IconButton btnAdjust2;
        private FontAwesome.Sharp.IconButton btnAdjust3;
        private FontAwesome.Sharp.IconButton btnAdjust4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJComboBox cmbBoxGender;
        private CustomControls.RJDatePicker datePicker;
        private CustomControls.RJButton rjButton3;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Panel panel3;
    }
}