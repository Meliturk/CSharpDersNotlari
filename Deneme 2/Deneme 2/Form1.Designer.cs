﻿namespace Deneme_2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            adTxt = new TextBox();
            mesaiTxt = new TextBox();
            unvanCb = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(474, 240);
            button1.Name = "button1";
            button1.Size = new Size(214, 140);
            button1.TabIndex = 0;
            button1.Text = "Ücret Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Mesai Saati :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 139);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Unvan :";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(131, 34);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 4;
            // 
            // mesaiTxt
            // 
            mesaiTxt.Location = new Point(131, 82);
            mesaiTxt.Name = "mesaiTxt";
            mesaiTxt.Size = new Size(125, 27);
            mesaiTxt.TabIndex = 5;
            // 
            // unvanCb
            // 
            unvanCb.FormattingEnabled = true;
            unvanCb.Items.AddRange(new object[] { "Mühendis ", "İşçi" });
            unvanCb.Location = new Point(131, 131);
            unvanCb.Name = "unvanCb";
            unvanCb.Size = new Size(125, 28);
            unvanCb.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(unvanCb);
            Controls.Add(mesaiTxt);
            Controls.Add(adTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox adTxt;
        private TextBox mesaiTxt;
        private ComboBox unvanCb;
    }
}