namespace EstacionamentoMbs
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dataGridViewEstatus = new System.Windows.Forms.DataGridView();
            this.buttonSaida = new System.Windows.Forms.Button();
            this.labelAlerta = new System.Windows.Forms.Label();
            this.buttonRelatorios = new System.Windows.Forms.Button();
            this.groupBoxCadastrarVeiculos = new System.Windows.Forms.GroupBox();
            this.labelHoraEntrada = new System.Windows.Forms.Label();
            this.textBoxHoraEntrada = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNao = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelValorCobrar = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstatus)).BeginInit();
            this.groupBoxCadastrarVeiculos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelo.Location = new System.Drawing.Point(32, 108);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(189, 20);
            this.textBoxModelo.TabIndex = 0;
            // 
            // textBoxCor
            // 
            this.textBoxCor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCor.Location = new System.Drawing.Point(32, 160);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(189, 20);
            this.textBoxCor.TabIndex = 1;
            // 
            // maskedTextBoxPlaca
            // 
            this.maskedTextBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPlaca.Location = new System.Drawing.Point(32, 214);
            this.maskedTextBoxPlaca.Mask = "&&&-####";
            this.maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            this.maskedTextBoxPlaca.Size = new System.Drawing.Size(89, 20);
            this.maskedTextBoxPlaca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(115, 135);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(95, 50);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // dataGridViewEstatus
            // 
            this.dataGridViewEstatus.AllowUserToAddRows = false;
            this.dataGridViewEstatus.AllowUserToDeleteRows = false;
            this.dataGridViewEstatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstatus.Location = new System.Drawing.Point(18, 24);
            this.dataGridViewEstatus.Name = "dataGridViewEstatus";
            this.dataGridViewEstatus.ReadOnly = true;
            this.dataGridViewEstatus.RowHeadersVisible = false;
            this.dataGridViewEstatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstatus.Size = new System.Drawing.Size(412, 326);
            this.dataGridViewEstatus.TabIndex = 7;
            this.dataGridViewEstatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstatus_CellContentClick);
            // 
            // buttonSaida
            // 
            this.buttonSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaida.ForeColor = System.Drawing.Color.Red;
            this.buttonSaida.Location = new System.Drawing.Point(367, 356);
            this.buttonSaida.Name = "buttonSaida";
            this.buttonSaida.Size = new System.Drawing.Size(63, 36);
            this.buttonSaida.TabIndex = 8;
            this.buttonSaida.Text = "Saida";
            this.buttonSaida.UseVisualStyleBackColor = true;
            this.buttonSaida.Visible = false;
            this.buttonSaida.Click += new System.EventHandler(this.buttonSaida_Click);
            // 
            // labelAlerta
            // 
            this.labelAlerta.AutoSize = true;
            this.labelAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlerta.ForeColor = System.Drawing.Color.Red;
            this.labelAlerta.Location = new System.Drawing.Point(15, 359);
            this.labelAlerta.Name = "labelAlerta";
            this.labelAlerta.Size = new System.Drawing.Size(0, 20);
            this.labelAlerta.TabIndex = 9;
            // 
            // buttonRelatorios
            // 
            this.buttonRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelatorios.Location = new System.Drawing.Point(108, 12);
            this.buttonRelatorios.Name = "buttonRelatorios";
            this.buttonRelatorios.Size = new System.Drawing.Size(90, 39);
            this.buttonRelatorios.TabIndex = 4;
            this.buttonRelatorios.Text = "Relatórios";
            this.buttonRelatorios.UseVisualStyleBackColor = true;
            this.buttonRelatorios.Click += new System.EventHandler(this.buttonRelatorios_Click);
            // 
            // groupBoxCadastrarVeiculos
            // 
            this.groupBoxCadastrarVeiculos.Controls.Add(this.labelHoraEntrada);
            this.groupBoxCadastrarVeiculos.Controls.Add(this.textBoxHoraEntrada);
            this.groupBoxCadastrarVeiculos.Controls.Add(this.buttonCadastrar);
            this.groupBoxCadastrarVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrarVeiculos.Location = new System.Drawing.Point(12, 65);
            this.groupBoxCadastrarVeiculos.Name = "groupBoxCadastrarVeiculos";
            this.groupBoxCadastrarVeiculos.Size = new System.Drawing.Size(235, 229);
            this.groupBoxCadastrarVeiculos.TabIndex = 11;
            this.groupBoxCadastrarVeiculos.TabStop = false;
            this.groupBoxCadastrarVeiculos.Text = "CADASTAR VEÍCULOS";
            // 
            // labelHoraEntrada
            // 
            this.labelHoraEntrada.AutoSize = true;
            this.labelHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraEntrada.Location = new System.Drawing.Point(20, 178);
            this.labelHoraEntrada.Name = "labelHoraEntrada";
            this.labelHoraEntrada.Size = new System.Drawing.Size(84, 13);
            this.labelHoraEntrada.TabIndex = 14;
            this.labelHoraEntrada.Text = "Entrada/Hora";
            this.labelHoraEntrada.Visible = false;
            // 
            // textBoxHoraEntrada
            // 
            this.textBoxHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoraEntrada.Location = new System.Drawing.Point(20, 194);
            this.textBoxHoraEntrada.Name = "textBoxHoraEntrada";
            this.textBoxHoraEntrada.Size = new System.Drawing.Size(129, 20);
            this.textBoxHoraEntrada.TabIndex = 14;
            this.textBoxHoraEntrada.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNao);
            this.groupBox1.Controls.Add(this.dataGridViewEstatus);
            this.groupBox1.Controls.Add(this.labelAlerta);
            this.groupBox1.Controls.Add(this.buttonSaida);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 398);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTATUS DE VEÍCULOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonNao
            // 
            this.buttonNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonNao.Location = new System.Drawing.Point(297, 356);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(62, 36);
            this.buttonNao.TabIndex = 10;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = true;
            this.buttonNao.Visible = false;
            this.buttonNao.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.Location = new System.Drawing.Point(12, 12);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(90, 39);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelValorCobrar
            // 
            this.labelValorCobrar.AutoSize = true;
            this.labelValorCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelValorCobrar.Location = new System.Drawing.Point(50, 358);
            this.labelValorCobrar.Name = "labelValorCobrar";
            this.labelValorCobrar.Size = new System.Drawing.Size(0, 33);
            this.labelValorCobrar.TabIndex = 13;
            this.labelValorCobrar.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(52, 334);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(56, 24);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "Total";
            this.labelTotal.Visible = false;
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.Location = new System.Drawing.Point(204, 12);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(90, 39);
            this.buttonUsuarios.TabIndex = 15;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.Location = new System.Drawing.Point(300, 12);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(90, 39);
            this.buttonBackup.TabIndex = 16;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 474);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonUsuarios);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelValorCobrar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonRelatorios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxPlaca);
            this.Controls.Add(this.textBoxCor);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.groupBoxCadastrarVeiculos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamento MBS";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstatus)).EndInit();
            this.groupBoxCadastrarVeiculos.ResumeLayout(false);
            this.groupBoxCadastrarVeiculos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.DataGridView dataGridViewEstatus;
        private System.Windows.Forms.Button buttonSaida;
        private System.Windows.Forms.Label labelAlerta;
        private System.Windows.Forms.Button buttonRelatorios;
        private System.Windows.Forms.GroupBox groupBoxCadastrarVeiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelHoraEntrada;
        private System.Windows.Forms.TextBox textBoxHoraEntrada;
        private System.Windows.Forms.Button buttonNao;
        private System.Windows.Forms.Label labelValorCobrar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonBackup;
    }
}

