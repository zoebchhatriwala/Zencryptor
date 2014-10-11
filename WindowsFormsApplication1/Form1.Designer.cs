namespace WindowsFormsApplication1
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
            this.input = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decrypt = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.Encryption = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Location = new System.Drawing.Point(10, 16);
            this.input.MaxLength = 2592;
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.input.Size = new System.Drawing.Size(744, 121);
            this.input.TabIndex = 0;
            this.input.Text = "Input";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(111, 143);
            this.key.MaxLength = 22;
            this.key.Multiline = true;
            this.key.Name = "key";
            this.key.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.key.Size = new System.Drawing.Size(128, 31);
            this.key.TabIndex = 2;
            this.key.Text = "0";
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encryption Key:-";
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(389, 143);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(138, 31);
            this.decrypt.TabIndex = 4;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(245, 143);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(138, 31);
            this.encrypt.TabIndex = 5;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(533, 143);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(138, 31);
            this.copy.TabIndex = 6;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(677, 143);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 31);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear X";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(661, 310);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(67, 22);
            this.about.TabIndex = 8;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Encryption
            // 
            this.Encryption.Location = new System.Drawing.Point(13, 345);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(745, 22);
            this.Encryption.TabIndex = 9;
            this.Encryption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // output
            // 
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(10, 180);
            this.output.MaxLength = 2592;
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(744, 162);
            this.output.TabIndex = 10;
            this.output.Text = "output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(762, 372);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.about);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.key);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(782, 415);
            this.Name = "Form1";
            this.Text = "ZEncryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label Encryption;
        private System.Windows.Forms.TextBox output;
    }
}

