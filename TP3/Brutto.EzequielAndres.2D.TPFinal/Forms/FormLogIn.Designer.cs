namespace Forms
{
    partial class FormLogIn
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEnter = new Forms.Customs.MyButtons();
            this.btnTest = new Forms.Customs.MyButtons();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Great Vibes", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Violet;
            this.lblUsername.Location = new System.Drawing.Point(12, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.Violet;
            this.panelUsername.Location = new System.Drawing.Point(12, 66);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(150, 1);
            this.panelUsername.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtUsername.Location = new System.Drawing.Point(12, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.Size = new System.Drawing.Size(150, 17);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Courgette", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtPassword.Location = new System.Drawing.Point(12, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.Size = new System.Drawing.Size(150, 17);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.Violet;
            this.panelPassword.Location = new System.Drawing.Point(12, 127);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(150, 1);
            this.panelPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Great Vibes", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Violet;
            this.lblPassword.Location = new System.Drawing.Point(12, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEnter.BorderColor = System.Drawing.Color.Violet;
            this.btnEnter.BorderRadius = 40;
            this.btnEnter.BorderSize = 2;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Great Vibes", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.ForeColor = System.Drawing.Color.Violet;
            this.btnEnter.Location = new System.Drawing.Point(12, 341);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 40);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.TabStop = false;
            this.btnEnter.Text = "Enter";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnter.TextColor = System.Drawing.Color.Violet;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTest.BorderColor = System.Drawing.Color.Violet;
            this.btnTest.BorderRadius = 40;
            this.btnTest.BorderSize = 2;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(220)))));
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Great Vibes", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTest.ForeColor = System.Drawing.Color.Violet;
            this.btnTest.Location = new System.Drawing.Point(438, 341);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(100, 40);
            this.btnTest.TabIndex = 7;
            this.btnTest.TabStop = false;
            this.btnTest.Text = "Try it!";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTest.TextColor = System.Drawing.Color.Violet;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forms.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(550, 393);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hush & Blow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label lblPassword;
        private Customs.MyButtons btnEnter;
        private Customs.MyButtons btnTest;
    }
}