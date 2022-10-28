namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.imgPassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randPic = new System.Windows.Forms.LinkLabel();
            this.LogIn = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.MaskedTextBox();
            this.randPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.randPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(87, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(87, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(87, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weryfikacja";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(223, 38);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(144, 20);
            this.userBox.TabIndex = 3;
            // 
            // imgPassBox
            // 
            this.imgPassBox.Location = new System.Drawing.Point(223, 236);
            this.imgPassBox.Name = "imgPassBox";
            this.imgPassBox.Size = new System.Drawing.Size(144, 20);
            this.imgPassBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wpisz znaki, które widzisz na poniższym obrazku, aby kontynuować";
            // 
            // randPic
            // 
            this.randPic.AutoSize = true;
            this.randPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.randPic.Location = new System.Drawing.Point(218, 269);
            this.randPic.Name = "randPic";
            this.randPic.Size = new System.Drawing.Size(56, 13);
            this.randPic.TabIndex = 8;
            this.randPic.TabStop = true;
            this.randPic.Text = "losuj nowy";
            this.randPic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.randPic_LinkClicked);
            // 
            // LogIn
            // 
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogIn.Location = new System.Drawing.Point(361, 293);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 9;
            this.LogIn.Text = "Zaloguj";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Error.Location = new System.Drawing.Point(87, 132);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 10;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(221, 87);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(146, 20);
            this.passwordBox.TabIndex = 11;
            // 
            // randPicBox
            // 
            this.randPicBox.Image = global::WindowsFormsApp1.Properties.Resources._1;
            this.randPicBox.Location = new System.Drawing.Point(117, 224);
            this.randPicBox.Name = "randPicBox";
            this.randPicBox.Size = new System.Drawing.Size(100, 32);
            this.randPicBox.TabIndex = 7;
            this.randPicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.randPic);
            this.Controls.Add(this.randPicBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgPassBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sekretariat";
            ((System.ComponentModel.ISupportInitialize)(this.randPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox imgPassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox randPicBox;
        private System.Windows.Forms.LinkLabel randPic;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.MaskedTextBox passwordBox;
    }
}

