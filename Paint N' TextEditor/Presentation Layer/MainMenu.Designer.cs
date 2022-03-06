
namespace Presentation_Layer
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnOp1 = new System.Windows.Forms.Button();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnOp3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnOp1
            // 
            this.btnOp1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOp1.BackgroundImage")));
            this.btnOp1.Location = new System.Drawing.Point(184, 69);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(111, 36);
            this.btnOp1.TabIndex = 0;
            this.btnOp1.Text = "Editor de texto";
            this.btnOp1.UseVisualStyleBackColor = true;
            this.btnOp1.Click += new System.EventHandler(this.textEditorWindow);
            // 
            // btnOp2
            // 
            this.btnOp2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOp2.BackgroundImage")));
            this.btnOp2.Location = new System.Drawing.Point(184, 133);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(111, 36);
            this.btnOp2.TabIndex = 0;
            this.btnOp2.Text = "Paint";
            this.btnOp2.UseVisualStyleBackColor = true;
            this.btnOp2.Click += new System.EventHandler(this.paintWindow);
            // 
            // btnOp3
            // 
            this.btnOp3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOp3.BackgroundImage")));
            this.btnOp3.Location = new System.Drawing.Point(184, 195);
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.Size = new System.Drawing.Size(111, 36);
            this.btnOp3.TabIndex = 0;
            this.btnOp3.Text = "Informacion";
            this.btnOp3.UseVisualStyleBackColor = true;
            this.btnOp3.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 357);
            this.Controls.Add(this.btnOp3);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnOp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "mMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnOp1;
        private System.Windows.Forms.Button btnOp3;
        private System.Windows.Forms.Button btnOp2;
    }
}

