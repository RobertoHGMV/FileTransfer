namespace FileTransfer
{
    partial class TransferForm
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
            this.txtSouceFile = new System.Windows.Forms.TextBox();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.btnSouceFile = new System.Windows.Forms.Button();
            this.btnTargetPath = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.btnDestFolder = new System.Windows.Forms.Button();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSouceFile
            // 
            this.txtSouceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSouceFile.Location = new System.Drawing.Point(15, 28);
            this.txtSouceFile.Name = "txtSouceFile";
            this.txtSouceFile.Size = new System.Drawing.Size(293, 20);
            this.txtSouceFile.TabIndex = 0;
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetPath.Location = new System.Drawing.Point(15, 54);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(293, 20);
            this.txtTargetPath.TabIndex = 1;
            // 
            // btnSouceFile
            // 
            this.btnSouceFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouceFile.Location = new System.Drawing.Point(314, 25);
            this.btnSouceFile.Name = "btnSouceFile";
            this.btnSouceFile.Size = new System.Drawing.Size(75, 23);
            this.btnSouceFile.TabIndex = 2;
            this.btnSouceFile.Text = "Arquivo";
            this.btnSouceFile.UseVisualStyleBackColor = true;
            this.btnSouceFile.Click += new System.EventHandler(this.btnSouceFile_Click);
            // 
            // btnTargetPath
            // 
            this.btnTargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTargetPath.Location = new System.Drawing.Point(314, 52);
            this.btnTargetPath.Name = "btnTargetPath";
            this.btnTargetPath.Size = new System.Drawing.Size(75, 23);
            this.btnTargetPath.TabIndex = 3;
            this.btnTargetPath.Text = "Salvar em:";
            this.btnTargetPath.UseVisualStyleBackColor = true;
            this.btnTargetPath.Click += new System.EventHandler(this.btnTargetPath_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(314, 81);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSouceFile);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.txtTargetPath);
            this.groupBox1.Controls.Add(this.btnTargetPath);
            this.groupBox1.Controls.Add(this.btnSouceFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copiar arquivo";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtSourceFolder);
            this.groupBox2.Controls.Add(this.btnCopyAll);
            this.groupBox2.Controls.Add(this.txtDestFolder);
            this.groupBox2.Controls.Add(this.btnDestFolder);
            this.groupBox2.Controls.Add(this.btnSourceFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Copiar Tudo";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(15, 29);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(293, 20);
            this.txtSourceFolder.TabIndex = 5;
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyAll.Location = new System.Drawing.Point(314, 82);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(75, 23);
            this.btnCopyAll.TabIndex = 9;
            this.btnCopyAll.Text = "Copiar";
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestFolder.Location = new System.Drawing.Point(15, 55);
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.Size = new System.Drawing.Size(293, 20);
            this.txtDestFolder.TabIndex = 6;
            // 
            // btnDestFolder
            // 
            this.btnDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestFolder.Location = new System.Drawing.Point(314, 53);
            this.btnDestFolder.Name = "btnDestFolder";
            this.btnDestFolder.Size = new System.Drawing.Size(75, 23);
            this.btnDestFolder.TabIndex = 8;
            this.btnDestFolder.Text = "Salvar em:";
            this.btnDestFolder.UseVisualStyleBackColor = true;
            this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceFolder.Location = new System.Drawing.Point(314, 26);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSourceFolder.TabIndex = 7;
            this.btnSourceFolder.Text = "Origem";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOk.Location = new System.Drawing.Point(12, 265);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 10;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 300);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSouceFile;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.Button btnSouceFile;
        private System.Windows.Forms.Button btnTargetPath;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Button btnDestFolder;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.Button cmdOk;
    }
}