namespace CatAsService
{
    partial class FrmRelatorioFavoritos
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
            listBoxFavourites = new ListBox();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // listBoxFavourites
            // 
            listBoxFavourites.FormattingEnabled = true;
            listBoxFavourites.ItemHeight = 15;
            listBoxFavourites.Location = new Point(213, 74);
            listBoxFavourites.Name = "listBoxFavourites";
            listBoxFavourites.Size = new Size(369, 259);
            listBoxFavourites.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(213, 358);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 23);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir Favorito";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmRelatorioFavoritos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(listBoxFavourites);
            Name = "FrmRelatorioFavoritos";
            Text = "Meus Favoritos";
            Load += FrmRelatorioFavoritos_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxFavourites;
        private Button btnExcluir;
    }
}