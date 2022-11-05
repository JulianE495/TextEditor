namespace TextEditor
{
    partial class frTextEditor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTextEditor));
            this.pnLeftSide = new System.Windows.Forms.Panel();
            this.pnTextTools = new System.Windows.Forms.Panel();
            this.btnTextStyle = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnTextTools = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.pnLeftSide.SuspendLayout();
            this.pnTextTools.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeftSide
            // 
            this.pnLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnLeftSide.Controls.Add(this.pnTextTools);
            this.pnLeftSide.Controls.Add(this.btnTextTools);
            this.pnLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnLeftSide.Name = "pnLeftSide";
            this.pnLeftSide.Size = new System.Drawing.Size(172, 461);
            this.pnLeftSide.TabIndex = 0;
            // 
            // pnTextTools
            // 
            this.pnTextTools.Controls.Add(this.btnTextStyle);
            this.pnTextTools.Controls.Add(this.btnSaveFile);
            this.pnTextTools.Controls.Add(this.btnOpenFile);
            this.pnTextTools.Controls.Add(this.btnNewFile);
            this.pnTextTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTextTools.Location = new System.Drawing.Point(0, 39);
            this.pnTextTools.Name = "pnTextTools";
            this.pnTextTools.Size = new System.Drawing.Size(172, 160);
            this.pnTextTools.TabIndex = 1;
            // 
            // btnTextStyle
            // 
            this.btnTextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnTextStyle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTextStyle.FlatAppearance.BorderSize = 0;
            this.btnTextStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextStyle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextStyle.ForeColor = System.Drawing.Color.White;
            this.btnTextStyle.Image = ((System.Drawing.Image)(resources.GetObject("btnTextStyle.Image")));
            this.btnTextStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextStyle.Location = new System.Drawing.Point(0, 120);
            this.btnTextStyle.Name = "btnTextStyle";
            this.btnTextStyle.Size = new System.Drawing.Size(172, 40);
            this.btnTextStyle.TabIndex = 4;
            this.btnTextStyle.Text = "Tipografia";
            this.btnTextStyle.UseVisualStyleBackColor = false;
            this.btnTextStyle.Click += new System.EventHandler(this.btnTextStyle_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnSaveFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.Image")));
            this.btnSaveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFile.Location = new System.Drawing.Point(0, 80);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(172, 40);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = " Guardar";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(0, 40);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(172, 40);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Abrir";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnNewFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewFile.FlatAppearance.BorderSize = 0;
            this.btnNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFile.ForeColor = System.Drawing.Color.White;
            this.btnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("btnNewFile.Image")));
            this.btnNewFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewFile.Location = new System.Drawing.Point(0, 0);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(172, 40);
            this.btnNewFile.TabIndex = 1;
            this.btnNewFile.Text = "Nuevo";
            this.btnNewFile.UseVisualStyleBackColor = false;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnTextTools
            // 
            this.btnTextTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnTextTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTextTools.FlatAppearance.BorderSize = 0;
            this.btnTextTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextTools.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextTools.ForeColor = System.Drawing.Color.White;
            this.btnTextTools.Location = new System.Drawing.Point(0, 0);
            this.btnTextTools.Name = "btnTextTools";
            this.btnTextTools.Size = new System.Drawing.Size(172, 39);
            this.btnTextTools.TabIndex = 0;
            this.btnTextTools.Text = "Herramientas";
            this.btnTextTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextTools.UseVisualStyleBackColor = false;
            this.btnTextTools.Click += new System.EventHandler(this.btnTextTools_Click);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.txtText);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(172, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(562, 461);
            this.pnMain.TabIndex = 1;
            // 
            // txtText
            // 
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(562, 461);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "";
            // 
            // frTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeftSide);
            this.Name = "frTextEditor";
            this.Text = "TextEditor";
            this.pnLeftSide.ResumeLayout(false);
            this.pnTextTools.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeftSide;
        private System.Windows.Forms.Panel pnTextTools;
        private System.Windows.Forms.Button btnTextStyle;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnTextTools;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.RichTextBox txtText;
    }
}

