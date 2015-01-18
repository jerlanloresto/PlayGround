namespace PlayGround
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(769, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(2, 307);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.c1FlexGrid1.Location = new System.Drawing.Point(12, 12);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 19;
            this.c1FlexGrid1.Size = new System.Drawing.Size(240, 150);
            this.c1FlexGrid1.TabIndex = 3;
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.Caption = "";
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.Location = new System.Drawing.Point(769, 42);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(121, 21);
            this.c1Combo1.TabIndex = 4;
            this.c1Combo1.Text = "c1Combo1";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(464, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(319, 257);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "radButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 394);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1Combo1);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1List.C1Combo c1Combo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}

