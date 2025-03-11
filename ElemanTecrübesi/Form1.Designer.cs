namespace ElemanTecrübesi
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblCalismaYili = new Label();
            txtIsim = new TextBox();
            txtSoyIsim = new TextBox();
            chkSifirBes = new CheckBox();
            chkBesOnYil = new CheckBox();
            chkOndanFazla = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(161, 65);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(51, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Adınız";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(161, 104);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(76, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyadınız:";
            // 
            // lblCalismaYili
            // 
            lblCalismaYili.AutoSize = true;
            lblCalismaYili.Location = new Point(161, 182);
            lblCalismaYili.Name = "lblCalismaYili";
            lblCalismaYili.Size = new Size(107, 20);
            lblCalismaYili.TabIndex = 2;
            lblCalismaYili.Text = "Çalışma Yılınız:";
            lblCalismaYili.Click += label3_Click;
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(251, 62);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(154, 27);
            txtIsim.TabIndex = 3;
            // 
            // txtSoyIsim
            // 
            txtSoyIsim.Location = new Point(252, 115);
            txtSoyIsim.Name = "txtSoyIsim";
            txtSoyIsim.Size = new Size(153, 27);
            txtSoyIsim.TabIndex = 4;
            // 
            // chkSifirBes
            // 
            chkSifirBes.AutoSize = true;
            chkSifirBes.Location = new Point(295, 178);
            chkSifirBes.Name = "chkSifirBes";
            chkSifirBes.Size = new Size(73, 24);
            chkSifirBes.TabIndex = 5;
            chkSifirBes.Text = "0-5 Yıl";
            chkSifirBes.UseVisualStyleBackColor = true;
            chkSifirBes.CheckedChanged += chkSifirBes_CheckedChanged;
            // 
            // chkBesOnYil
            // 
            chkBesOnYil.AutoSize = true;
            chkBesOnYil.Location = new Point(295, 212);
            chkBesOnYil.Name = "chkBesOnYil";
            chkBesOnYil.Size = new Size(85, 24);
            chkBesOnYil.TabIndex = 6;
            chkBesOnYil.Text = "5- 10 Yıl";
            chkBesOnYil.UseVisualStyleBackColor = true;
            // 
            // chkOndanFazla
            // 
            chkOndanFazla.AutoSize = true;
            chkOndanFazla.Location = new Point(295, 242);
            chkOndanFazla.Name = "chkOndanFazla";
            chkOndanFazla.Size = new Size(57, 24);
            chkOndanFazla.TabIndex = 7;
            chkOndanFazla.Text = "10+";
            chkOndanFazla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(326, 272);
            button1.Name = "button1";
            button1.Size = new Size(146, 42);
            button1.TabIndex = 8;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(chkOndanFazla);
            Controls.Add(chkBesOnYil);
            Controls.Add(chkSifirBes);
            Controls.Add(txtSoyIsim);
            Controls.Add(txtIsim);
            Controls.Add(lblCalismaYili);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblCalismaYili;
        private TextBox txtIsim;
        private TextBox txtSoyIsim;
        private CheckBox chkSifirBes;
        private CheckBox chkBesOnYil;
        private CheckBox chkOndanFazla;
        private Button button1;
    }
}
