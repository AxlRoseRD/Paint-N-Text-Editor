
namespace Presentation_Layer
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.paintText = new System.Windows.Forms.ToolStripButton();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileWatcher = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionAtras = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionAdelante = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionEliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.filePath = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusNotify = new System.Windows.Forms.ToolStripLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // paintText
            // 
            this.paintText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paintText.Image = ((System.Drawing.Image)(resources.GetObject("paintText.Image")));
            this.paintText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paintText.Name = "paintText";
            this.paintText.Size = new System.Drawing.Size(23, 22);
            this.paintText.Text = "toolStripButton1";
            this.paintText.ToolTipText = "Text Color";
            this.paintText.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(0, 49);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(684, 401);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "";
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileWatcher
            // 
            this.fileWatcher.EnableRaisingEvents = true;
            this.fileWatcher.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionGuardar,
            this.opcionGuardarComo,
            this.opcionAbrir,
            this.opcionNuevo});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // opcionGuardar
            // 
            this.opcionGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.opcionGuardar.Image = ((System.Drawing.Image)(resources.GetObject("opcionGuardar.Image")));
            this.opcionGuardar.Name = "opcionGuardar";
            this.opcionGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.opcionGuardar.Size = new System.Drawing.Size(238, 22);
            this.opcionGuardar.Tag = "guardar";
            this.opcionGuardar.Text = "Guardar";
            this.opcionGuardar.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // opcionGuardarComo
            // 
            this.opcionGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("opcionGuardarComo.Image")));
            this.opcionGuardarComo.Name = "opcionGuardarComo";
            this.opcionGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.opcionGuardarComo.Size = new System.Drawing.Size(238, 22);
            this.opcionGuardarComo.Tag = "Guardar_Como";
            this.opcionGuardarComo.Text = "Guardar como";
            this.opcionGuardarComo.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // opcionAbrir
            // 
            this.opcionAbrir.Image = ((System.Drawing.Image)(resources.GetObject("opcionAbrir.Image")));
            this.opcionAbrir.Name = "opcionAbrir";
            this.opcionAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opcionAbrir.Size = new System.Drawing.Size(238, 22);
            this.opcionAbrir.Tag = "Abrir";
            this.opcionAbrir.Text = "Abrir";
            this.opcionAbrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // opcionNuevo
            // 
            this.opcionNuevo.Image = ((System.Drawing.Image)(resources.GetObject("opcionNuevo.Image")));
            this.opcionNuevo.Name = "opcionNuevo";
            this.opcionNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.opcionNuevo.Size = new System.Drawing.Size(238, 22);
            this.opcionNuevo.Tag = "Nuevo";
            this.opcionNuevo.Text = "Nuevo";
            this.opcionNuevo.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionAtras,
            this.opcionAdelante,
            this.toolStripSeparator3,
            this.opcionCopiar,
            this.opcionCortar,
            this.opcionPegar,
            this.toolStripSeparator2,
            this.opcionSeleccionarTodo,
            this.opcionEliminarTodo});
            this.edicionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("edicionToolStripMenuItem.Image")));
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // opcionAtras
            // 
            this.opcionAtras.Image = ((System.Drawing.Image)(resources.GetObject("opcionAtras.Image")));
            this.opcionAtras.Name = "opcionAtras";
            this.opcionAtras.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.opcionAtras.Size = new System.Drawing.Size(233, 22);
            this.opcionAtras.Text = "Atras";
            this.opcionAtras.Click += new System.EventHandler(this.opcionAtras_Click);
            // 
            // opcionAdelante
            // 
            this.opcionAdelante.Image = ((System.Drawing.Image)(resources.GetObject("opcionAdelante.Image")));
            this.opcionAdelante.Name = "opcionAdelante";
            this.opcionAdelante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.opcionAdelante.Size = new System.Drawing.Size(233, 22);
            this.opcionAdelante.Text = "Adelante";
            this.opcionAdelante.Click += new System.EventHandler(this.opcionAdelante_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(230, 6);
            // 
            // opcionCopiar
            // 
            this.opcionCopiar.Image = ((System.Drawing.Image)(resources.GetObject("opcionCopiar.Image")));
            this.opcionCopiar.Name = "opcionCopiar";
            this.opcionCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.opcionCopiar.Size = new System.Drawing.Size(233, 22);
            this.opcionCopiar.Text = "Copiar";
            this.opcionCopiar.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // opcionCortar
            // 
            this.opcionCortar.Image = ((System.Drawing.Image)(resources.GetObject("opcionCortar.Image")));
            this.opcionCortar.Name = "opcionCortar";
            this.opcionCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.opcionCortar.Size = new System.Drawing.Size(233, 22);
            this.opcionCortar.Text = "Cortar";
            this.opcionCortar.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // opcionPegar
            // 
            this.opcionPegar.Image = ((System.Drawing.Image)(resources.GetObject("opcionPegar.Image")));
            this.opcionPegar.Name = "opcionPegar";
            this.opcionPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.opcionPegar.Size = new System.Drawing.Size(233, 22);
            this.opcionPegar.Text = "Pegar";
            this.opcionPegar.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // opcionSeleccionarTodo
            // 
            this.opcionSeleccionarTodo.Name = "opcionSeleccionarTodo";
            this.opcionSeleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.opcionSeleccionarTodo.Size = new System.Drawing.Size(233, 22);
            this.opcionSeleccionarTodo.Text = "Seleccionar Todo";
            this.opcionSeleccionarTodo.Click += new System.EventHandler(this.opcionSeleccionarTodo_Click);
            // 
            // opcionEliminarTodo
            // 
            this.opcionEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("opcionEliminarTodo.Image")));
            this.opcionEliminarTodo.Name = "opcionEliminarTodo";
            this.opcionEliminarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.opcionEliminarTodo.Size = new System.Drawing.Size(233, 22);
            this.opcionEliminarTodo.Text = "Eliminar Todo";
            this.opcionEliminarTodo.Click += new System.EventHandler(this.opcionEliminarTodo_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            this.formatoToolStripMenuItem.Click += new System.EventHandler(this.formatoToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filePath,
            this.toolStripSeparator1,
            this.statusNotify});
            this.toolStrip2.Location = new System.Drawing.Point(0, 425);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(684, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // filePath
            // 
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusNotify
            // 
            this.statusNotify.Name = "statusNotify";
            this.statusNotify.Size = new System.Drawing.Size(0, 22);
            this.statusNotify.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextEditor_FormClosed);
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileWatcher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionGuardar;
        private System.Windows.Forms.ToolStripMenuItem opcionGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem opcionAbrir;
        private System.Windows.Forms.ToolStripMenuItem opcionNuevo;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionCopiar;
        private System.Windows.Forms.ToolStripMenuItem opcionCortar;
        private System.Windows.Forms.ToolStripMenuItem opcionPegar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel filePath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel statusNotify;
        private System.Windows.Forms.ToolStripButton paintText;
        private System.Windows.Forms.ToolStripMenuItem opcionAtras;
        private System.Windows.Forms.ToolStripMenuItem opcionAdelante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opcionSeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem opcionEliminarTodo;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}