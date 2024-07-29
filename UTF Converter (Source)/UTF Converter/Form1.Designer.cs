namespace UTF_Converter
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
            this.btnFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbExUTF = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExChar = new System.Windows.Forms.ComboBox();
            this.cmbNewUTF = new System.Windows.Forms.ComboBox();
            this.cmbNewChar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkAE = new System.Windows.Forms.CheckBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 41);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(129, 40);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Add the file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(426, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Converte and Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbExUTF
            // 
            this.cmbExUTF.FormattingEnabled = true;
            this.cmbExUTF.Location = new System.Drawing.Point(160, 32);
            this.cmbExUTF.Name = "cmbExUTF";
            this.cmbExUTF.Size = new System.Drawing.Size(121, 21);
            this.cmbExUTF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Existing Type";
            // 
            // cmbExChar
            // 
            this.cmbExChar.FormattingEnabled = true;
            this.cmbExChar.Location = new System.Drawing.Point(160, 59);
            this.cmbExChar.Name = "cmbExChar";
            this.cmbExChar.Size = new System.Drawing.Size(121, 21);
            this.cmbExChar.TabIndex = 3;
            // 
            // cmbNewUTF
            // 
            this.cmbNewUTF.FormattingEnabled = true;
            this.cmbNewUTF.Location = new System.Drawing.Point(287, 32);
            this.cmbNewUTF.Name = "cmbNewUTF";
            this.cmbNewUTF.Size = new System.Drawing.Size(121, 21);
            this.cmbNewUTF.TabIndex = 2;
            // 
            // cmbNewChar
            // 
            this.cmbNewChar.FormattingEnabled = true;
            this.cmbNewChar.Location = new System.Drawing.Point(287, 59);
            this.cmbNewChar.Name = "cmbNewChar";
            this.cmbNewChar.Size = new System.Drawing.Size(121, 21);
            this.cmbNewChar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type to be converted";
            // 
            // checkAE
            // 
            this.checkAE.AutoSize = true;
            this.checkAE.Location = new System.Drawing.Point(430, 13);
            this.checkAE.Name = "checkAE";
            this.checkAE.Size = new System.Drawing.Size(129, 17);
            this.checkAE.TabIndex = 5;
            this.checkAE.Text = "Reset Auto Increment";
            this.checkAE.UseVisualStyleBackColor = true;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(34, 14);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(82, 13);
            this.lblFile.TabIndex = 7;
            this.lblFile.Text = "No file attached";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 93);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.checkAE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNewChar);
            this.Controls.Add(this.cmbNewUTF);
            this.Controls.Add(this.cmbExChar);
            this.Controls.Add(this.cmbExUTF);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SQL UTF Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbExUTF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExChar;
        private System.Windows.Forms.ComboBox cmbNewUTF;
        private System.Windows.Forms.ComboBox cmbNewChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkAE;
        private System.Windows.Forms.Label lblFile;
    }
}

