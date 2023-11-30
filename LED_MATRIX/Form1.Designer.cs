namespace LED_MATRIX
{
    partial class LEDMATRIX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEDMATRIX));
            controll = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // controll
            // 
            controll.AccessibleRole = AccessibleRole.None;
            controll.Anchor = AnchorStyles.None;
            controll.BackColor = Color.Transparent;
            controll.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            controll.Location = new Point(134, 103);
            controll.Name = "controll";
            controll.Size = new Size(418, 46);
            controll.TabIndex = 0;
            controll.Text = "CONTROL LED MATRIX";
            controll.TextAlign = ContentAlignment.TopCenter;
            controll.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.HotTrack;
            textBox2.Location = new Point(245, 161);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 25);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(145, 163);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 3;
            label2.Text = "Text";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(145, 194);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 5;
            label3.Text = "Effect ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(245, 195);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 25);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(385, 283);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 8;
            label1.Text = "Humidity : 80%";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(87, 283);
            label4.Name = "label4";
            label4.Size = new Size(199, 23);
            label4.TabIndex = 7;
            label4.Text = "Temperature : 31 C";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(223, 343);
            label5.Name = "label5";
            label5.Size = new Size(231, 23);
            label5.TabIndex = 9;
            label5.Text = "DAY  :           24/11/2023";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(220, 366);
            label6.Name = "label6";
            label6.Size = new Size(174, 23);
            label6.TabIndex = 10;
            label6.Text = "TIME :          22:29";
            // 
            // LEDMATRIX
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CausesValidation = false;
            ClientSize = new Size(651, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(controll);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            ImeMode = ImeMode.On;
            Name = "LEDMATRIX";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += LEDMATRIX_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label controll;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}