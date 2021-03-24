using System;
using System.Drawing;
using System.Windows.Forms;

namespace OndalıkTarihBulucu
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb7 = new System.Windows.Forms.ComboBox();
            this.cmb6 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSonucGun = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSonucAy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSonucSene = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHicri = new System.Windows.Forms.Label();
            this.lblMiladi = new System.Windows.Forms.Label();
            this.miladiAy = new System.Windows.Forms.ComboBox();
            this.hicriAy = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbHaftaGunu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSonucHaftaGunu = new System.Windows.Forms.Label();
            this.txtYil = new OndalıkTarihBulucu.PlaceHolderTextBox();
            this.txtGun = new OndalıkTarihBulucu.PlaceHolderTextBox();
            this.miladiYil = new OndalıkTarihBulucu.PlaceHolderTextBox();
            this.miladiGun = new OndalıkTarihBulucu.PlaceHolderTextBox();
            this.hicriYil = new OndalıkTarihBulucu.PlaceHolderTextBox();
            this.hicriGun = new OndalıkTarihBulucu.PlaceHolderTextBox();
            this.cmbTaban = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 7);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 437);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ondalık Tarih Çevir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox3.Controls.Add(this.cmb7);
            this.groupBox3.Controls.Add(this.cmb6);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblSonucGun);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(8, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 86);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GÜN";
            // 
            // cmb7
            // 
            this.cmb7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb7.FormattingEnabled = true;
            this.cmb7.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث"});
            this.cmb7.Location = new System.Drawing.Point(241, 34);
            this.cmb7.Name = "cmb7";
            this.cmb7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb7.Size = new System.Drawing.Size(121, 24);
            this.cmb7.TabIndex = 20;
            // 
            // cmb6
            // 
            this.cmb6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb6.FormattingEnabled = true;
            this.cmb6.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث",
            "الرابع",
            "الخامس",
            "السادس",
            "السابع",
            "الثامن",
            "التاسع",
            "العاشر"});
            this.cmb6.Location = new System.Drawing.Point(504, 34);
            this.cmb6.Name = "cmb6";
            this.cmb6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb6.Size = new System.Drawing.Size(121, 24);
            this.cmb6.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label16.Location = new System.Drawing.Point(398, 33);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "من الثلث ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label17.Location = new System.Drawing.Point(653, 35);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(43, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "العشر";
            // 
            // lblSonucGun
            // 
            this.lblSonucGun.AutoSize = true;
            this.lblSonucGun.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblSonucGun.Location = new System.Drawing.Point(7, 35);
            this.lblSonucGun.Name = "lblSonucGun";
            this.lblSonucGun.Size = new System.Drawing.Size(24, 18);
            this.lblSonucGun.TabIndex = 4;
            this.lblSonucGun.Text = "00";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.cmb5);
            this.groupBox2.Controls.Add(this.cmb4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblSonucAy);
            this.groupBox2.Location = new System.Drawing.Point(8, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 77);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AY";
            // 
            // cmb5
            // 
            this.cmb5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb5.FormattingEnabled = true;
            this.cmb5.Items.AddRange(new object[] {
            "الأول",
            "الثاني"});
            this.cmb5.Location = new System.Drawing.Point(241, 31);
            this.cmb5.Name = "cmb5";
            this.cmb5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb5.Size = new System.Drawing.Size(121, 24);
            this.cmb5.TabIndex = 19;
            // 
            // cmb4
            // 
            this.cmb4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb4.FormattingEnabled = true;
            this.cmb4.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث",
            "الرابع",
            "الخامس",
            "السادس"});
            this.cmb4.Location = new System.Drawing.Point(504, 31);
            this.cmb4.Name = "cmb4";
            this.cmb4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb4.Size = new System.Drawing.Size(121, 24);
            this.cmb4.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(398, 35);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "من النصف";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(631, 30);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "من السدس";
            // 
            // lblSonucAy
            // 
            this.lblSonucAy.AutoSize = true;
            this.lblSonucAy.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblSonucAy.Location = new System.Drawing.Point(7, 34);
            this.lblSonucAy.Name = "lblSonucAy";
            this.lblSonucAy.Size = new System.Drawing.Size(23, 18);
            this.lblSonucAy.TabIndex = 4;
            this.lblSonucAy.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.cmbTaban);
            this.groupBox1.Controls.Add(this.cmb3);
            this.groupBox1.Controls.Add(this.cmb2);
            this.groupBox1.Controls.Add(this.cmb1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblSonucSene);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(8, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YIL";
            // 
            // cmb3
            // 
            this.cmb3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb3.FormattingEnabled = true;
            this.cmb3.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث",
            "الرابع",
            "الخامس",
            "السادس",
            "السابع",
            "الثامن",
            "التاسع",
            "العاشر"});
            this.cmb3.Location = new System.Drawing.Point(65, 32);
            this.cmb3.Name = "cmb3";
            this.cmb3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb3.Size = new System.Drawing.Size(121, 24);
            this.cmb3.TabIndex = 19;
            // 
            // cmb2
            // 
            this.cmb2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث",
            "الرابع",
            "الخامس",
            "السادس",
            "السابع",
            "الثامن",
            "التاسع",
            "العاشر"});
            this.cmb2.Location = new System.Drawing.Point(267, 32);
            this.cmb2.Name = "cmb2";
            this.cmb2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb2.Size = new System.Drawing.Size(121, 24);
            this.cmb2.TabIndex = 18;
            // 
            // cmb1
            // 
            this.cmb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث",
            "الرابع",
            "الخامس",
            "السادس",
            "السابع",
            "الثامن",
            "التاسع",
            "العاشر"});
            this.cmb1.Location = new System.Drawing.Point(526, 31);
            this.cmb1.Name = "cmb1";
            this.cmb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb1.Size = new System.Drawing.Size(121, 24);
            this.cmb1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(192, 35);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "من العشر ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(451, 31);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "من العشر ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(653, 32);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "من العشر";
            // 
            // lblSonucSene
            // 
            this.lblSonucSene.AutoSize = true;
            this.lblSonucSene.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lblSonucSene.Location = new System.Drawing.Point(4, 29);
            this.lblSonucSene.Name = "lblSonucSene";
            this.lblSonucSene.Size = new System.Drawing.Size(24, 18);
            this.lblSonucSene.TabIndex = 4;
            this.lblSonucSene.Text = "00";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(311, 366);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(126, 28);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "BUL";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbAy);
            this.tabPage2.Controls.Add(this.lblTarih);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtYil);
            this.tabPage2.Controls.Add(this.txtGun);
            this.tabPage2.ForeColor = System.Drawing.Color.Maroon;
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarihi Ondalık Yazıya Dönüştür";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbAy
            // 
            this.cmbAy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAy.ForeColor = System.Drawing.Color.Gray;
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Items.AddRange(new object[] {
            "محرم",
            "صفر",
            "ربيع الأول",
            "ربيع الآخر",
            "جمادي الأول",
            "جمادي الآخر",
            "رجب",
            "شعبان",
            "رمضان",
            "شوال",
            "ذي القعدة",
            "ذي الحجة"});
            this.cmbAy.Location = new System.Drawing.Point(242, 92);
            this.cmbAy.MaxDropDownItems = 12;
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbAy.Size = new System.Drawing.Size(130, 27);
            this.cmbAy.TabIndex = 8;
            this.cmbAy.Text = "           Ay";
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(52, 183);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTarih.Size = new System.Drawing.Size(648, 199);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "تاريخ";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(497, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dönüştür";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSonuc);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(743, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ebced Tarih Çevir";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Green;
            this.lblSonuc.Location = new System.Drawing.Point(357, 278);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(24, 19);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBox1.Location = new System.Drawing.Point(57, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(623, 94);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(89, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesaplanmasını istediğiniz metni Arapça klavye ile buraya yazınız. ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.lblHicri);
            this.tabPage4.Controls.Add(this.lblMiladi);
            this.tabPage4.Controls.Add(this.miladiAy);
            this.tabPage4.Controls.Add(this.hicriAy);
            this.tabPage4.Controls.Add(this.miladiYil);
            this.tabPage4.Controls.Add(this.miladiGun);
            this.tabPage4.Controls.Add(this.hicriYil);
            this.tabPage4.Controls.Add(this.hicriGun);
            this.tabPage4.Location = new System.Drawing.Point(4, 36);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(743, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hicri ve Miladi ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(314, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hicriye Çevir";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(309, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Miladiye Çevir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHicri
            // 
            this.lblHicri.AutoSize = true;
            this.lblHicri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHicri.ForeColor = System.Drawing.Color.Green;
            this.lblHicri.Location = new System.Drawing.Point(255, 309);
            this.lblHicri.Name = "lblHicri";
            this.lblHicri.Size = new System.Drawing.Size(24, 19);
            this.lblHicri.TabIndex = 18;
            this.lblHicri.Text = "...";
            this.lblHicri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiladi
            // 
            this.lblMiladi.AutoSize = true;
            this.lblMiladi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiladi.ForeColor = System.Drawing.Color.Green;
            this.lblMiladi.Location = new System.Drawing.Point(255, 160);
            this.lblMiladi.Name = "lblMiladi";
            this.lblMiladi.Size = new System.Drawing.Size(24, 19);
            this.lblMiladi.TabIndex = 17;
            this.lblMiladi.Text = "...";
            this.lblMiladi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miladiAy
            // 
            this.miladiAy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.miladiAy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.miladiAy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miladiAy.ForeColor = System.Drawing.Color.Gray;
            this.miladiAy.FormattingEnabled = true;
            this.miladiAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.miladiAy.Location = new System.Drawing.Point(303, 261);
            this.miladiAy.MaxDropDownItems = 12;
            this.miladiAy.Name = "miladiAy";
            this.miladiAy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.miladiAy.Size = new System.Drawing.Size(130, 27);
            this.miladiAy.TabIndex = 16;
            this.miladiAy.Text = "           Ay";
            this.miladiAy.SelectedIndexChanged += new System.EventHandler(this.miladiAy_SelectedIndexChanged);
            // 
            // hicriAy
            // 
            this.hicriAy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.hicriAy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.hicriAy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hicriAy.ForeColor = System.Drawing.Color.Gray;
            this.hicriAy.FormattingEnabled = true;
            this.hicriAy.Items.AddRange(new object[] {
            "Muharrem",
            "Safer",
            "Rebiülevvel",
            "Rebiülâhir",
            "Cemâziyelevvel",
            "Cemâziyelâhir",
            "Receb",
            "Şâban",
            "Ramazan",
            "Şevval",
            "Zilkâde",
            "Zilhicce"});
            this.hicriAy.Location = new System.Drawing.Point(303, 109);
            this.hicriAy.MaxDropDownItems = 12;
            this.hicriAy.Name = "hicriAy";
            this.hicriAy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hicriAy.Size = new System.Drawing.Size(130, 27);
            this.hicriAy.TabIndex = 12;
            this.hicriAy.Text = "           Ay";
            this.hicriAy.SelectedIndexChanged += new System.EventHandler(this.hicriAy_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox4.Controls.Add(this.cmbHaftaGunu);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.labelSonucHaftaGunu);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(8, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(726, 80);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HAFTANIN GÜNÜ";
            // 
            // cmbHaftaGunu
            // 
            this.cmbHaftaGunu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHaftaGunu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHaftaGunu.FormattingEnabled = true;
            this.cmbHaftaGunu.Items.AddRange(new object[] {
            "الأول",
            "الثاني",
            "الثالث",
            "الرابع",
            "الخامس",
            "السادس",
            "السابع"});
            this.cmbHaftaGunu.Location = new System.Drawing.Point(504, 34);
            this.cmbHaftaGunu.Name = "cmbHaftaGunu";
            this.cmbHaftaGunu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbHaftaGunu.Size = new System.Drawing.Size(121, 24);
            this.cmbHaftaGunu.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(653, 35);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "السبع";
            // 
            // labelSonucHaftaGunu
            // 
            this.labelSonucHaftaGunu.AutoSize = true;
            this.labelSonucHaftaGunu.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelSonucHaftaGunu.Location = new System.Drawing.Point(7, 35);
            this.labelSonucHaftaGunu.Name = "labelSonucHaftaGunu";
            this.labelSonucHaftaGunu.Size = new System.Drawing.Size(23, 18);
            this.labelSonucHaftaGunu.TabIndex = 4;
            this.labelSonucHaftaGunu.Text = "...";
            // 
            // txtYil
            // 
            this.txtYil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.txtYil.ForeColor = System.Drawing.Color.Gray;
            this.txtYil.Location = new System.Drawing.Point(378, 92);
            this.txtYil.Name = "txtYil";
            this.txtYil.PlaceHolderText = "Yil";
            this.txtYil.Size = new System.Drawing.Size(113, 27);
            this.txtYil.TabIndex = 7;
            this.txtYil.Text = "Yil";
            this.txtYil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYil_KeyPress);
            // 
            // txtGun
            // 
            this.txtGun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.txtGun.ForeColor = System.Drawing.Color.Gray;
            this.txtGun.Location = new System.Drawing.Point(130, 92);
            this.txtGun.Name = "txtGun";
            this.txtGun.PlaceHolderText = "Gun";
            this.txtGun.Size = new System.Drawing.Size(105, 27);
            this.txtGun.TabIndex = 5;
            this.txtGun.Text = "Gun";
            this.txtGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGun.TextChanged += new System.EventHandler(this.txtGun_TextChanged);
            this.txtGun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGun_KeyPress);
            // 
            // miladiYil
            // 
            this.miladiYil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.miladiYil.ForeColor = System.Drawing.Color.Gray;
            this.miladiYil.Location = new System.Drawing.Point(439, 261);
            this.miladiYil.Name = "miladiYil";
            this.miladiYil.PlaceHolderText = "Yil";
            this.miladiYil.Size = new System.Drawing.Size(113, 27);
            this.miladiYil.TabIndex = 15;
            this.miladiYil.Text = "Yil";
            this.miladiYil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.miladiYil.TextChanged += new System.EventHandler(this.miladiYil_TextChanged);
            this.miladiYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miladiYil_KeyPress);
            // 
            // miladiGun
            // 
            this.miladiGun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.miladiGun.ForeColor = System.Drawing.Color.Gray;
            this.miladiGun.Location = new System.Drawing.Point(191, 261);
            this.miladiGun.Name = "miladiGun";
            this.miladiGun.PlaceHolderText = "Gun";
            this.miladiGun.Size = new System.Drawing.Size(105, 27);
            this.miladiGun.TabIndex = 14;
            this.miladiGun.Text = "Gun";
            this.miladiGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.miladiGun.TextChanged += new System.EventHandler(this.miladiGun_TextChanged);
            this.miladiGun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miladiGun_KeyPress);
            // 
            // hicriYil
            // 
            this.hicriYil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.hicriYil.ForeColor = System.Drawing.Color.Gray;
            this.hicriYil.Location = new System.Drawing.Point(439, 109);
            this.hicriYil.Name = "hicriYil";
            this.hicriYil.PlaceHolderText = "Yil";
            this.hicriYil.Size = new System.Drawing.Size(113, 27);
            this.hicriYil.TabIndex = 11;
            this.hicriYil.Text = "Yil";
            this.hicriYil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hicriYil.TextChanged += new System.EventHandler(this.hicriYil_TextChanged);
            this.hicriYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hicriYil_KeyPress);
            // 
            // hicriGun
            // 
            this.hicriGun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic);
            this.hicriGun.ForeColor = System.Drawing.Color.Gray;
            this.hicriGun.Location = new System.Drawing.Point(191, 109);
            this.hicriGun.Name = "hicriGun";
            this.hicriGun.PlaceHolderText = "Gun";
            this.hicriGun.Size = new System.Drawing.Size(105, 27);
            this.hicriGun.TabIndex = 10;
            this.hicriGun.Text = "Gun";
            this.hicriGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hicriGun.TextChanged += new System.EventHandler(this.hicriGun_TextChanged);
            this.hicriGun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hicriGun_KeyPress);
            // 
            // cmbTaban
            // 
            this.cmbTaban.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTaban.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTaban.FormattingEnabled = true;
            this.cmbTaban.Items.AddRange(new object[] {
            "العشر",
            "الربع"});
            this.cmbTaban.Location = new System.Drawing.Point(399, 31);
            this.cmbTaban.Name = "cmbTaban";
            this.cmbTaban.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTaban.Size = new System.Drawing.Size(121, 24);
            this.cmbTaban.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(756, 441);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(772, 480);
            this.Name = "Form1";
            this.Text = "DateTool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb7;
        private System.Windows.Forms.ComboBox cmb6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSonucGun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSonucAy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb3;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSonucSene;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTarih;
        private PlaceHolderTextBox txtGun;
        private PlaceHolderTextBox txtYil;
        private ComboBox cmbAy;
        private TabPage tabPage3;
        private Label label2;
        private Label lblSonuc;
        private RichTextBox richTextBox1;
        private TabPage tabPage4;
        private Label lblHicri;
        private Label lblMiladi;
        private ComboBox miladiAy;
        private PlaceHolderTextBox miladiYil;
        private PlaceHolderTextBox miladiGun;
        private ComboBox hicriAy;
        private PlaceHolderTextBox hicriYil;
        private PlaceHolderTextBox hicriGun;
        private Label label4;
        private Label label3;
        private GroupBox groupBox4;
        private ComboBox cmbHaftaGunu;
        private Label label6;
        private Label labelSonucHaftaGunu;
        private ComboBox cmbTaban;
    }
    public class PlaceHolderTextBox : TextBox
    {

        bool isPlaceHolder = true;
        string _placeHolderText;
        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        public new string Text
        {
            get => isPlaceHolder ? string.Empty : base.Text;
            set => base.Text = value;
        }

        //when the control loses focus, the placeholder is shown
        private void setPlaceholder()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = PlaceHolderText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Italic);
                isPlaceHolder = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolder()
        {

            if (isPlaceHolder)
            {
                base.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            }
        }
        public PlaceHolderTextBox()
        {
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }
    }

}

