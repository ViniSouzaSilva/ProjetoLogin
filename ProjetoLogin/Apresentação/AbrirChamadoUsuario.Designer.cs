namespace ProjetoLogin.Apresentação
{
    partial class AbrirChamadoUsuario
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
            this.TXTstatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTcpf2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTdescricao = new System.Windows.Forms.TextBox();
            this.BOXcategoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TXBdata = new System.Windows.Forms.TextBox();
            this.datachamadoLabel = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TXTstatus
            // 
            this.TXTstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXTstatus.FormattingEnabled = true;
            this.TXTstatus.Items.AddRange(new object[] {
            "Normal ",
            "Urgente"});
            this.TXTstatus.Location = new System.Drawing.Point(292, 120);
            this.TXTstatus.Name = "TXTstatus";
            this.TXTstatus.Size = new System.Drawing.Size(224, 21);
            this.TXTstatus.TabIndex = 43;
            this.TXTstatus.Text = "Status...";
            this.TXTstatus.SelectedIndexChanged += new System.EventHandler(this.TXTstatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(398, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXTcpf2
            // 
            this.TXTcpf2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXTcpf2.Location = new System.Drawing.Point(292, 53);
            this.TXTcpf2.Name = "TXTcpf2";
            this.TXTcpf2.Size = new System.Drawing.Size(224, 20);
            this.TXTcpf2.TabIndex = 41;
            this.TXTcpf2.TextChanged += new System.EventHandler(this.TXTcpf2_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(340, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Descrição do chamado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTdescricao
            // 
            this.TXTdescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXTdescricao.Location = new System.Drawing.Point(292, 267);
            this.TXTdescricao.Multiline = true;
            this.TXTdescricao.Name = "TXTdescricao";
            this.TXTdescricao.Size = new System.Drawing.Size(224, 98);
            this.TXTdescricao.TabIndex = 39;
            this.TXTdescricao.TextChanged += new System.EventHandler(this.TXTdescricao_TextChanged);
            // 
            // BOXcategoria
            // 
            this.BOXcategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BOXcategoria.FormattingEnabled = true;
            this.BOXcategoria.Items.AddRange(new object[] {
            "PC não liga",
            "Teclado não funciona",
            "Usb não reconhece pen drive"});
            this.BOXcategoria.Location = new System.Drawing.Point(292, 193);
            this.BOXcategoria.Name = "BOXcategoria";
            this.BOXcategoria.Size = new System.Drawing.Size(224, 21);
            this.BOXcategoria.TabIndex = 38;
            this.BOXcategoria.Text = "Categorias...";
            this.BOXcategoria.SelectedIndexChanged += new System.EventHandler(this.BOXcategoria_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(334, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 43);
            this.button1.TabIndex = 37;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TXBdata
            // 
            this.TXBdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXBdata.Location = new System.Drawing.Point(658, 424);
            this.TXBdata.Name = "TXBdata";
            this.TXBdata.Size = new System.Drawing.Size(136, 20);
            this.TXBdata.TabIndex = 45;
            this.TXBdata.Visible = false;
            // 
            // datachamadoLabel
            // 
            this.datachamadoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datachamadoLabel.AutoSize = true;
            this.datachamadoLabel.BackColor = System.Drawing.Color.Transparent;
            this.datachamadoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.datachamadoLabel.Location = new System.Drawing.Point(688, 408);
            this.datachamadoLabel.Name = "datachamadoLabel";
            this.datachamadoLabel.Size = new System.Drawing.Size(80, 13);
            this.datachamadoLabel.TabIndex = 44;
            this.datachamadoLabel.Text = "Data chamado:";
            this.datachamadoLabel.Visible = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.metroTile1.Location = new System.Drawing.Point(12, 12);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(93, 40);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 21;
            this.metroTile1.Text = "Voltar";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = global::ProjetoLogin.Properties.Resources.fundo_de_linhas_de_zoom_em_quadrinhos_amarelo_1017_151361;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // AbrirChamadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::ProjetoLogin.Properties.Resources.fabric_7680x5120_blue_texture_pattern_hd_4k_8k_111011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXBdata);
            this.Controls.Add(this.datachamadoLabel);
            this.Controls.Add(this.TXTstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTcpf2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTdescricao);
            this.Controls.Add(this.BOXcategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTile1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AbrirChamadoUsuario";
            this.Text = "AbreChamado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AbrirChamadoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TXTstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTcpf2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTdescricao;
        private System.Windows.Forms.ComboBox BOXcategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXBdata;
        private System.Windows.Forms.Label datachamadoLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}