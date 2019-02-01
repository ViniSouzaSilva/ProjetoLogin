using System;

namespace ProjetoLogin
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTsenha = new MetroFramework.Controls.MetroTextBox();
            this.btnentrar = new MetroFramework.Controls.MetroTile();
            this.btnsair = new MetroFramework.Controls.MetroTile();
            this.btncadastrar = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.TXTlogin = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TXTsenha
            // 
            this.TXTsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.TXTsenha.CustomButton.Image = null;
            this.TXTsenha.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.TXTsenha.CustomButton.Name = "";
            this.TXTsenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTsenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTsenha.CustomButton.TabIndex = 1;
            this.TXTsenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTsenha.CustomButton.UseSelectable = true;
            this.TXTsenha.CustomButton.Visible = false;
            this.TXTsenha.Lines = new string[0];
            this.TXTsenha.Location = new System.Drawing.Point(299, 290);
            this.TXTsenha.MaxLength = 32767;
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.PasswordChar = '*';
            this.TXTsenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTsenha.SelectedText = "";
            this.TXTsenha.SelectionLength = 0;
            this.TXTsenha.SelectionStart = 0;
            this.TXTsenha.ShortcutsEnabled = true;
            this.TXTsenha.Size = new System.Drawing.Size(117, 23);
            this.TXTsenha.TabIndex = 11;
            this.TXTsenha.UseSelectable = true;
            this.TXTsenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTsenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTsenha.Click += new System.EventHandler(this.txtboxsenha_Click);
            this.TXTsenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxsenha_KeyUp);
            // 
            // btnentrar
            // 
            this.btnentrar.ActiveControl = null;
            this.btnentrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnentrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnentrar.Location = new System.Drawing.Point(216, 356);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(127, 49);
            this.btnentrar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnentrar.TabIndex = 12;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.TileImage = global::ProjetoLogin.Properties.Resources.fundo_de_linhas_de_zoom_em_quadrinhos_amarelo_1017_151361;
            this.btnentrar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnentrar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnentrar.UseCustomForeColor = true;
            this.btnentrar.UseSelectable = true;
            this.btnentrar.UseStyleColors = true;
            this.btnentrar.UseTileImage = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // btnsair
            // 
            this.btnsair.ActiveControl = null;
            this.btnsair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsair.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnsair.Location = new System.Drawing.Point(600, 12);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(93, 42);
            this.btnsair.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnsair.TabIndex = 16;
            this.btnsair.Text = "Sair";
            this.btnsair.TileImage = global::ProjetoLogin.Properties.Resources.fundo_de_linhas_de_zoom_em_quadrinhos_amarelo_1017_151361;
            this.btnsair.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnsair.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnsair.UseCustomForeColor = true;
            this.btnsair.UseSelectable = true;
            this.btnsair.UseTileImage = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.ActiveControl = null;
            this.btncadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncadastrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btncadastrar.Location = new System.Drawing.Point(541, 525);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(152, 54);
            this.btncadastrar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btncadastrar.TabIndex = 15;
            this.btncadastrar.Text = "Cadastre-se";
            this.btncadastrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btncadastrar.TileImage = global::ProjetoLogin.Properties.Resources.fundo_de_linhas_de_zoom_em_quadrinhos_amarelo_1017_151361;
            this.btncadastrar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btncadastrar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btncadastrar.UseCustomForeColor = true;
            this.btncadastrar.UseSelectable = true;
            this.btncadastrar.UseTileImage = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile1.BackColor = System.Drawing.Color.Transparent;
            this.metroTile1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.metroTile1.Location = new System.Drawing.Point(384, 356);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(155, 49);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 14;
            this.metroTile1.Text = "Esqueci minha senha";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbllogin.Location = new System.Drawing.Point(241, 239);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(49, 18);
            this.lbllogin.TabIndex = 15;
            this.lbllogin.Text = "Login";
            // 
            // lblsenha
            // 
            this.lblsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsenha.Location = new System.Drawing.Point(230, 290);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(55, 18);
            this.lblsenha.TabIndex = 16;
            this.lblsenha.Text = "Senha";
            // 
            // TXTlogin
            // 
            this.TXTlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXTlogin.Location = new System.Drawing.Point(299, 240);
            this.TXTlogin.Mask = "999.999.999-99";
            this.TXTlogin.Name = "TXTlogin";
            this.TXTlogin.Size = new System.Drawing.Size(117, 20);
            this.TXTlogin.TabIndex = 10;
            this.TXTlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTlogin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TXTlogin_MaskInputRejected);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 591);
            this.Controls.Add(this.TXTlogin);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.TXTsenha);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox TXTsenha;
        private MetroFramework.Controls.MetroTile btnentrar;
        private MetroFramework.Controls.MetroTile btnsair;
        private MetroFramework.Controls.MetroTile btncadastrar;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.MaskedTextBox TXTlogin;
    }
}

