namespace WinForm_ControlsAndGraphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Amount = new System.Windows.Forms.NumericUpDown();
            this.tb_PriceAll = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_PricePerOne = new System.Windows.Forms.TextBox();
            this.tb_Desc = new System.Windows.Forms.TextBox();
            this.tb_GoodName = new System.Windows.Forms.TextBox();
            this.listOfGoods = new System.Windows.Forms.ListBox();
            this.tabAnalitics = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabAnalitics);
            this.tabControl.ItemSize = new System.Drawing.Size(200, 20);
            this.tabControl.Location = new System.Drawing.Point(2, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1125, 748);
            this.tabControl.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabHome.Controls.Add(this.button1);
            this.tabHome.Controls.Add(this.panel1);
            this.tabHome.Controls.Add(this.groupBox1);
            this.tabHome.Controls.Add(this.listOfGoods);
            this.tabHome.Location = new System.Drawing.Point(4, 24);
            this.tabHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabHome.Size = new System.Drawing.Size(1117, 720);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Загальне";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 634);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(538, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Друкувати чек";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateAndSaveReceiptToXml);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(7, 321);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 271);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(24, 187);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(538, 56);
            this.button4.TabIndex = 2;
            this.button4.Text = "Видалити товар";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.RomoveGoodFromList);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(24, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(538, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "Змінити товар";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.EditGoodItem);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(24, 19);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(538, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "Додати товар";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.AddGood_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NUD_Amount);
            this.groupBox1.Controls.Add(this.tb_PriceAll);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.tb_PricePerOne);
            this.groupBox1.Controls.Add(this.tb_Desc);
            this.groupBox1.Controls.Add(this.tb_GoodName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(589, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "ДАТА";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "ЗАГАЛЬНА ЦІНА";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(242, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "ЦІНА ЗА ШТ.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "КІЛЬКІСТЬ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ОПИС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "НАЗВА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(518, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ГРН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(518, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ГРН";
            // 
            // NUD_Amount
            // 
            this.NUD_Amount.Enabled = false;
            this.NUD_Amount.Location = new System.Drawing.Point(168, 135);
            this.NUD_Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUD_Amount.Name = "NUD_Amount";
            this.NUD_Amount.Size = new System.Drawing.Size(66, 34);
            this.NUD_Amount.TabIndex = 5;
            this.NUD_Amount.ValueChanged += new System.EventHandler(this.AmountChanged);
            // 
            // tb_PriceAll
            // 
            this.tb_PriceAll.Enabled = false;
            this.tb_PriceAll.Location = new System.Drawing.Point(229, 183);
            this.tb_PriceAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_PriceAll.Name = "tb_PriceAll";
            this.tb_PriceAll.Size = new System.Drawing.Size(271, 34);
            this.tb_PriceAll.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(168, 240);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(399, 34);
            this.dateTimePicker.TabIndex = 3;
            // 
            // tb_PricePerOne
            // 
            this.tb_PricePerOne.Enabled = false;
            this.tb_PricePerOne.Location = new System.Drawing.Point(385, 135);
            this.tb_PricePerOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_PricePerOne.Name = "tb_PricePerOne";
            this.tb_PricePerOne.Size = new System.Drawing.Size(115, 34);
            this.tb_PricePerOne.TabIndex = 2;
            this.tb_PricePerOne.TextChanged += new System.EventHandler(this.PricePerOneChanged);
            // 
            // tb_Desc
            // 
            this.tb_Desc.Location = new System.Drawing.Point(168, 91);
            this.tb_Desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Desc.Name = "tb_Desc";
            this.tb_Desc.Size = new System.Drawing.Size(399, 34);
            this.tb_Desc.TabIndex = 1;
            // 
            // tb_GoodName
            // 
            this.tb_GoodName.Location = new System.Drawing.Point(168, 45);
            this.tb_GoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_GoodName.Name = "tb_GoodName";
            this.tb_GoodName.Size = new System.Drawing.Size(399, 34);
            this.tb_GoodName.TabIndex = 0;
            this.tb_GoodName.TextChanged += new System.EventHandler(this.NameChanged);
            // 
            // listOfGoods
            // 
            this.listOfGoods.FormattingEnabled = true;
            this.listOfGoods.ItemHeight = 20;
            this.listOfGoods.Location = new System.Drawing.Point(602, 0);
            this.listOfGoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listOfGoods.Name = "listOfGoods";
            this.listOfGoods.Size = new System.Drawing.Size(512, 724);
            this.listOfGoods.TabIndex = 0;
            this.listOfGoods.SelectedValueChanged += new System.EventHandler(this.SelectedValue);
            // 
            // tabAnalitics
            // 
            this.tabAnalitics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabAnalitics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAnalitics.Location = new System.Drawing.Point(4, 24);
            this.tabAnalitics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAnalitics.Name = "tabAnalitics";
            this.tabAnalitics.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAnalitics.Size = new System.Drawing.Size(1117, 720);
            this.tabAnalitics.TabIndex = 1;
            this.tabAnalitics.Text = "Аналітика";
            this.tabAnalitics.ToolTipText = "Загальна сторінка інформації";
            this.tabAnalitics.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "1";
            this.toolTip1.ToolTipTitle = "Підказка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1122, 748);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1140, 795);
            this.MinimumSize = new System.Drawing.Size(1140, 795);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foxtrot 2.0";
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabHome;
        private TabPage tabAnalitics;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker;
        private TextBox tb_PricePerOne;
        private TextBox tb_Desc;
        private TextBox tb_GoodName;
        private ListBox listOfGoods;
        private Label label2;
        private Label label1;
        private NumericUpDown NUD_Amount;
        private TextBox tb_PriceAll;
        private ToolTip toolTip1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}