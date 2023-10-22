namespace deneme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            adTxt = new TextBox();
            soyadTxt = new TextBox();
            ePostaTxt = new TextBox();
            label4 = new Label();
            adresTxt = new TextBox();
            label5 = new Label();
            yasTxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 20);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 73);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 121);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "E-Posta :";
            // 
            // adTxt
            // 
            adTxt.BackColor = SystemColors.Info;
            adTxt.Location = new Point(121, 13);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 3;
            // 
            // soyadTxt
            // 
            soyadTxt.BackColor = SystemColors.Info;
            soyadTxt.Location = new Point(121, 66);
            soyadTxt.Name = "soyadTxt";
            soyadTxt.Size = new Size(125, 27);
            soyadTxt.TabIndex = 4;
            // 
            // ePostaTxt
            // 
            ePostaTxt.BackColor = SystemColors.Info;
            ePostaTxt.Location = new Point(121, 114);
            ePostaTxt.Name = "ePostaTxt";
            ePostaTxt.Size = new Size(125, 27);
            ePostaTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 184);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Adres :";
            // 
            // adresTxt
            // 
            adresTxt.BackColor = SystemColors.Info;
            adresTxt.Location = new Point(121, 160);
            adresTxt.Multiline = true;
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(125, 92);
            adresTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 278);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 9;
            label5.Text = "Yaş :";
            label5.Click += label5_Click;
            // 
            // yasTxt
            // 
            yasTxt.BackColor = SystemColors.Info;
            yasTxt.Location = new Point(121, 271);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(125, 27);
            yasTxt.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(609, 123);
            button1.Name = "button1";
            button1.Size = new Size(224, 100);
            button1.TabIndex = 11;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(994, 520);
            Controls.Add(button1);
            Controls.Add(yasTxt);
            Controls.Add(label5);
            Controls.Add(adresTxt);
            Controls.Add(label4);
            Controls.Add(ePostaTxt);
            Controls.Add(soyadTxt);
            Controls.Add(adTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox adTxt;
        private TextBox soyadTxt;
        private TextBox ePostaTxt;
        private Label label4;
        private TextBox adresTxt;
        private Label label5;
        private TextBox yasTxt;
        private Button button1;
    }
}