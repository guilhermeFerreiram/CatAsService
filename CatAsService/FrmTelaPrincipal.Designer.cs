namespace CatAsService
{
    partial class FrmTelaPrincipal
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
            menuStrip1 = new ToolStrip();
            buscarRacasToolStripMenuItem = new ToolStripLabel();
            meusFavoritosToolStripMenuItem = new ToolStripLabel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscarRacasToolStripMenuItem, meusFavoritosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "toolStrip1";
            // 
            // buscarRacasToolStripMenuItem
            // 
            buscarRacasToolStripMenuItem.Name = "buscarRacasToolStripMenuItem";
            buscarRacasToolStripMenuItem.Size = new Size(75, 22);
            buscarRacasToolStripMenuItem.Text = "Buscar Raças";
            buscarRacasToolStripMenuItem.Click += buscarRacasToolStripMenuItem_Click;
            // 
            // meusFavoritosToolStripMenuItem
            // 
            meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            meusFavoritosToolStripMenuItem.Size = new Size(87, 22);
            meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            meusFavoritosToolStripMenuItem.Click += meusFavoritosToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gato_preto;
            pictureBox1.Location = new Point(165, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "FrmTelaPrincipal";
            Text = "Cat As Service";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip menuStrip1;
        private ToolStripLabel buscarRacasToolStripMenuItem;
        private ToolStripLabel meusFavoritosToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
