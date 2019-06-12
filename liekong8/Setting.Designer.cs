namespace liekong8
{
    partial class Setting
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.yindaqi = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.runtype = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chusuduclik = new System.Windows.Forms.Button();
            this.chusudu = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.yindaqi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(266, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 52);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "加速度设置";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(226, 17);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 27;
            this.button10.Text = "确定";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(97, 21);
            this.textBox6.TabIndex = 26;
            this.textBox6.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 23;
            this.label20.Text = "加速度";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(333, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "速度控制";
            // 
            // yindaqi
            // 
            this.yindaqi.Controls.Add(this.button7);
            this.yindaqi.Controls.Add(this.label14);
            this.yindaqi.Controls.Add(this.textBox3);
            this.yindaqi.Location = new System.Drawing.Point(266, 176);
            this.yindaqi.Name = "yindaqi";
            this.yindaqi.Size = new System.Drawing.Size(290, 60);
            this.yindaqi.TabIndex = 26;
            this.yindaqi.TabStop = false;
            this.yindaqi.Text = "应答器";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(211, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "确定";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "限制速度";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // runtype
            // 
            this.runtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runtype.FormattingEnabled = true;
            this.runtype.Items.AddRange(new object[] {
            "加速",
            "正常运行"});
            this.runtype.Location = new System.Drawing.Point(418, 347);
            this.runtype.Name = "runtype";
            this.runtype.Size = new System.Drawing.Size(116, 20);
            this.runtype.TabIndex = 25;
            this.runtype.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chusuduclik);
            this.groupBox1.Controls.Add(this.chusudu);
            this.groupBox1.Location = new System.Drawing.Point(329, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 46);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初速度设置";
            // 
            // chusuduclik
            // 
            this.chusuduclik.Location = new System.Drawing.Point(133, 14);
            this.chusuduclik.Name = "chusuduclik";
            this.chusuduclik.Size = new System.Drawing.Size(75, 23);
            this.chusuduclik.TabIndex = 14;
            this.chusuduclik.Text = "确定";
            this.chusuduclik.UseVisualStyleBackColor = true;
            // 
            // chusudu
            // 
            this.chusudu.Location = new System.Drawing.Point(6, 14);
            this.chusudu.Name = "chusudu";
            this.chusudu.Size = new System.Drawing.Size(106, 21);
            this.chusudu.TabIndex = 13;
            this.chusudu.TextChanged += new System.EventHandler(this.Chusudu_TextChanged);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.yindaqi);
            this.Controls.Add(this.runtype);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.yindaqi.ResumeLayout(false);
            this.yindaqi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox yindaqi;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.ComboBox runtype;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chusuduclik;
        public System.Windows.Forms.TextBox chusudu;
    }
}