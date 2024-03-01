namespace CatAsService
{
    partial class FrmBuscarRacas
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
            panel1 = new Panel();
            lblDescricao = new Label();
            label6 = new Label();
            lblOrigem = new Label();
            label4 = new Label();
            lblTemperamento = new Label();
            label2 = new Label();
            cbListaRacas = new ComboBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnFavoritar = new Button();
            pictureCatImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCatImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescricao);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblOrigem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblTemperamento);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbListaRacas);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 234);
            panel1.TabIndex = 0;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(149, 168);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(59, 15);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Resultado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 168);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 6;
            label6.Text = "Descrição";
            // 
            // lblOrigem
            // 
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new Point(149, 134);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(59, 15);
            lblOrigem.TabIndex = 5;
            lblOrigem.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 134);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Origem";
            // 
            // lblTemperamento
            // 
            lblTemperamento.AutoSize = true;
            lblTemperamento.Location = new Point(149, 89);
            lblTemperamento.Name = "lblTemperamento";
            lblTemperamento.Size = new Size(59, 15);
            lblTemperamento.TabIndex = 3;
            lblTemperamento.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 89);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "Temperamento";
            // 
            // cbListaRacas
            // 
            cbListaRacas.FormattingEnabled = true;
            cbListaRacas.Items.AddRange(new object[] { "Selecione uma Raça", "Abyssinian", "Aegean", "American Bobtail", "American Curl", "American Shorthair", "American Wirehair", "Arabian Mau", "Australian Mist", "Balinese" });
            cbListaRacas.Location = new Point(149, 48);
            cbListaRacas.Name = "cbListaRacas";
            cbListaRacas.Size = new Size(121, 23);
            cbListaRacas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 51);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Raça do Gato";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(35, 388);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnFavoritar
            // 
            btnFavoritar.Location = new Point(151, 388);
            btnFavoritar.Name = "btnFavoritar";
            btnFavoritar.Size = new Size(75, 23);
            btnFavoritar.TabIndex = 2;
            btnFavoritar.Text = "Favoritar";
            btnFavoritar.UseVisualStyleBackColor = true;
            btnFavoritar.Visible = false;
            btnFavoritar.Click += btnFavoritar_Click;
            // 
            // pictureCatImage
            // 
            pictureCatImage.ImageLocation = "";
            pictureCatImage.Location = new Point(375, 34);
            pictureCatImage.Name = "pictureCatImage";
            pictureCatImage.Size = new Size(361, 338);
            pictureCatImage.TabIndex = 3;
            pictureCatImage.TabStop = false;
            pictureCatImage.WaitOnLoad = true;
            // 
            // FrmBuscarRacas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureCatImage);
            Controls.Add(btnFavoritar);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Name = "FrmBuscarRacas";
            Text = "FrmBuscarRacas";
            Load += FrmBuscarRacas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCatImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescricao;
        private Label label6;
        private Label lblOrigem;
        private Label label4;
        private Label lblTemperamento;
        private Label label2;
        private ComboBox cbListaRacas;
        private Label label1;
        private Button btnBuscar;
        private Button btnFavoritar;
        private PictureBox pictureCatImage;
    }
}