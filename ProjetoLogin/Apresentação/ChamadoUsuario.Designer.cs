namespace ProjetoLogin.Apresentação
{
    partial class ChamadoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarexcluirUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.Label();
            this.userdataGridView = new System.Windows.Forms.DataGridView();
            this.chamadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoLoginDataSetUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoLoginDataSetUsuario = new ProjetoLogin.ProjetoLoginDataSetUsuario();
            this.meus_chamadosToolStrip = new System.Windows.Forms.ToolStrip();
            this.nomeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.meus_chamadosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.chamadoTableAdapter = new ProjetoLogin.ProjetoLoginDataSetUsuarioTableAdapters.chamadoTableAdapter();
            this.meus_chamadosToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nomeToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nomeToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.meus_chamadosToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.ID_chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_chamado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DT_abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_fechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atribuicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSetUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSetUsuario)).BeginInit();
            this.meus_chamadosToolStrip.SuspendLayout();
            this.meus_chamadosToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTile1.Location = new System.Drawing.Point(1214, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(93, 40);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 20;
            this.metroTile1.Text = "Sair";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirChamadoToolStripMenuItem,
            this.todosOsChamadosToolStripMenuItem,
            this.alterarexcluirUsuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // abrirChamadoToolStripMenuItem
            // 
            this.abrirChamadoToolStripMenuItem.Name = "abrirChamadoToolStripMenuItem";
            this.abrirChamadoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.abrirChamadoToolStripMenuItem.Text = "Abrir chamado";
            this.abrirChamadoToolStripMenuItem.Click += new System.EventHandler(this.abrirChamadoToolStripMenuItem_Click);
            // 
            // todosOsChamadosToolStripMenuItem
            // 
            this.todosOsChamadosToolStripMenuItem.Name = "todosOsChamadosToolStripMenuItem";
            this.todosOsChamadosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.todosOsChamadosToolStripMenuItem.Text = "Meus chamados";
            this.todosOsChamadosToolStripMenuItem.Click += new System.EventHandler(this.todosOsChamadosToolStripMenuItem_Click);
            // 
            // alterarexcluirUsuarioToolStripMenuItem
            // 
            this.alterarexcluirUsuarioToolStripMenuItem.Name = "alterarexcluirUsuarioToolStripMenuItem";
            this.alterarexcluirUsuarioToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.alterarexcluirUsuarioToolStripMenuItem.Text = "Alterar meus dados";
            this.alterarexcluirUsuarioToolStripMenuItem.Click += new System.EventHandler(this.alterarexcluirUsuarioToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(431, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 33);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.Text = "nome";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userdataGridView
            // 
            this.userdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userdataGridView.AutoGenerateColumns = false;
            this.userdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_chamado,
            this.descricao,
            this.categoria_chamado,
            this.status_chamado,
            this.DT_abertura,
            this.DT_fechamento,
            this.tipo_chamado,
            this.cpf,
            this.atribuicao});
            this.userdataGridView.DataSource = this.chamadoBindingSource;
            this.userdataGridView.Location = new System.Drawing.Point(0, 100);
            this.userdataGridView.Name = "userdataGridView";
            this.userdataGridView.RowTemplate.ReadOnly = true;
            this.userdataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userdataGridView.Size = new System.Drawing.Size(1307, 432);
            this.userdataGridView.TabIndex = 26;
            this.userdataGridView.Visible = false;
            this.userdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
            // 
            // chamadoBindingSource
            // 
            this.chamadoBindingSource.DataMember = "chamado";
            this.chamadoBindingSource.DataSource = this.projetoLoginDataSetUsuarioBindingSource;
            // 
            // projetoLoginDataSetUsuarioBindingSource
            // 
            this.projetoLoginDataSetUsuarioBindingSource.DataSource = this.projetoLoginDataSetUsuario;
            this.projetoLoginDataSetUsuarioBindingSource.Position = 0;
            // 
            // projetoLoginDataSetUsuario
            // 
            this.projetoLoginDataSetUsuario.DataSetName = "ProjetoLoginDataSetUsuario";
            this.projetoLoginDataSetUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meus_chamadosToolStrip
            // 
            this.meus_chamadosToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.meus_chamadosToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.meus_chamadosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripLabel,
            this.nomeToolStripTextBox,
            this.meus_chamadosToolStripButton});
            this.meus_chamadosToolStrip.Location = new System.Drawing.Point(134, 57);
            this.meus_chamadosToolStrip.Name = "meus_chamadosToolStrip";
            this.meus_chamadosToolStrip.Size = new System.Drawing.Size(105, 25);
            this.meus_chamadosToolStrip.TabIndex = 27;
            this.meus_chamadosToolStrip.Text = "meus_chamadosToolStrip";
            this.meus_chamadosToolStrip.Visible = false;
            // 
            // nomeToolStripLabel
            // 
            this.nomeToolStripLabel.Name = "nomeToolStripLabel";
            this.nomeToolStripLabel.Size = new System.Drawing.Size(41, 22);
            this.nomeToolStripLabel.Text = "nome:";
            this.nomeToolStripLabel.Visible = false;
            // 
            // nomeToolStripTextBox
            // 
            this.nomeToolStripTextBox.Name = "nomeToolStripTextBox";
            this.nomeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // meus_chamadosToolStripButton
            // 
            this.meus_chamadosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.meus_chamadosToolStripButton.Name = "meus_chamadosToolStripButton";
            this.meus_chamadosToolStripButton.Size = new System.Drawing.Size(100, 22);
            this.meus_chamadosToolStripButton.Text = "Meus_chamados";
            this.meus_chamadosToolStripButton.ToolTipText = "Meus chamados";
            this.meus_chamadosToolStripButton.Visible = false;
            // 
            // chamadoTableAdapter
            // 
            this.chamadoTableAdapter.ClearBeforeFill = true;
            // 
            // meus_chamadosToolStrip1
            // 
            this.meus_chamadosToolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.meus_chamadosToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.meus_chamadosToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripLabel1,
            this.nomeToolStripTextBox1,
            this.meus_chamadosToolStripButton1});
            this.meus_chamadosToolStrip1.Location = new System.Drawing.Point(1021, 576);
            this.meus_chamadosToolStrip1.Name = "meus_chamadosToolStrip1";
            this.meus_chamadosToolStrip1.Size = new System.Drawing.Size(255, 25);
            this.meus_chamadosToolStrip1.TabIndex = 28;
            this.meus_chamadosToolStrip1.Text = "meus_chamadosToolStrip1";
            this.meus_chamadosToolStrip1.Visible = false;
            this.meus_chamadosToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.meus_chamadosToolStrip1_ItemClicked);
            // 
            // nomeToolStripLabel1
            // 
            this.nomeToolStripLabel1.Name = "nomeToolStripLabel1";
            this.nomeToolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.nomeToolStripLabel1.Text = "nome:";
            // 
            // nomeToolStripTextBox1
            // 
            this.nomeToolStripTextBox1.Name = "nomeToolStripTextBox1";
            this.nomeToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // meus_chamadosToolStripButton1
            // 
            this.meus_chamadosToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.meus_chamadosToolStripButton1.Name = "meus_chamadosToolStripButton1";
            this.meus_chamadosToolStripButton1.Size = new System.Drawing.Size(100, 22);
            this.meus_chamadosToolStripButton1.Text = "Meus_chamados";
            this.meus_chamadosToolStripButton1.Click += new System.EventHandler(this.meus_chamadosToolStripButton1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.RoyalBlue;
            this.metroTile3.ForeColor = System.Drawing.Color.Yellow;
            this.metroTile3.Location = new System.Drawing.Point(437, 48);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(151, 43);
            this.metroTile3.TabIndex = 34;
            this.metroTile3.Text = "Informações ";
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Visible = false;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(177, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Você selecionou o chamado:";
            this.label2.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(275, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(20, 16);
            this.label.TabIndex = 31;
            this.label.Text = "---";
            this.label.Visible = false;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTile4.BackColor = System.Drawing.Color.Yellow;
            this.metroTile4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.metroTile4.Location = new System.Drawing.Point(12, 538);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(92, 50);
            this.metroTile4.TabIndex = 35;
            this.metroTile4.Text = "Voltar";
            this.metroTile4.TileImage = global::ProjetoLogin.Properties.Resources.fundo_de_linhas_de_zoom_em_quadrinhos_amarelo_1017_151361;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Visible = false;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // ID_chamado
            // 
            this.ID_chamado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_chamado.DataPropertyName = "ID_chamado";
            this.ID_chamado.HeaderText = "ID chamado";
            this.ID_chamado.Name = "ID_chamado";
            this.ID_chamado.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // categoria_chamado
            // 
            this.categoria_chamado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoria_chamado.DataPropertyName = "categoria_chamado";
            this.categoria_chamado.HeaderText = "Categoria do Chamado";
            this.categoria_chamado.Name = "categoria_chamado";
            this.categoria_chamado.ReadOnly = true;
            // 
            // status_chamado
            // 
            this.status_chamado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_chamado.DataPropertyName = "status_chamado";
            this.status_chamado.HeaderText = "Chamado Ativo?";
            this.status_chamado.Name = "status_chamado";
            this.status_chamado.ReadOnly = true;
            // 
            // DT_abertura
            // 
            this.DT_abertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DT_abertura.DataPropertyName = "DT_abertura";
            this.DT_abertura.HeaderText = "Data Abertura";
            this.DT_abertura.Name = "DT_abertura";
            this.DT_abertura.ReadOnly = true;
            // 
            // DT_fechamento
            // 
            this.DT_fechamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DT_fechamento.DataPropertyName = "DT_fechamento";
            this.DT_fechamento.HeaderText = "Data de Fechamento";
            this.DT_fechamento.Name = "DT_fechamento";
            this.DT_fechamento.ReadOnly = true;
            // 
            // tipo_chamado
            // 
            this.tipo_chamado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_chamado.DataPropertyName = "tipo_chamado";
            this.tipo_chamado.HeaderText = "Prioridade";
            this.tipo_chamado.Name = "tipo_chamado";
            this.tipo_chamado.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF do requisitante";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // atribuicao
            // 
            this.atribuicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.atribuicao.DataPropertyName = "atribuicao";
            this.atribuicao.HeaderText = "Técnico Responsável";
            this.atribuicao.Name = "atribuicao";
            this.atribuicao.ReadOnly = true;
            // 
            // ChamadoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::ProjetoLogin.Properties.Resources.fabric_7680x5120_blue_texture_pattern_hd_4k_8k_111011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 600);
            this.Controls.Add(this.userdataGridView);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.meus_chamadosToolStrip);
            this.Controls.Add(this.meus_chamadosToolStrip1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChamadoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChamadoUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChamadoUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSetUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoLoginDataSetUsuario)).EndInit();
            this.meus_chamadosToolStrip.ResumeLayout(false);
            this.meus_chamadosToolStrip.PerformLayout();
            this.meus_chamadosToolStrip1.ResumeLayout(false);
            this.meus_chamadosToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsChamadosToolStripMenuItem;
        private System.Windows.Forms.Label linkLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ToolStripMenuItem alterarexcluirUsuarioToolStripMenuItem;
        private System.Windows.Forms.DataGridView userdataGridView;
        private System.Windows.Forms.BindingSource projetoLoginDataSetUsuarioBindingSource;
        private ProjetoLoginDataSetUsuario projetoLoginDataSetUsuario;
        private System.Windows.Forms.BindingSource chamadoBindingSource;
        private ProjetoLoginDataSetUsuarioTableAdapters.chamadoTableAdapter chamadoTableAdapter;
        private System.Windows.Forms.ToolStrip meus_chamadosToolStrip;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton meus_chamadosToolStripButton;
        private System.Windows.Forms.ToolStrip meus_chamadosToolStrip1;
        private System.Windows.Forms.ToolStripLabel nomeToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nomeToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton meus_chamadosToolStripButton1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_chamado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status_chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_fechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn atribuicao;
    }
}