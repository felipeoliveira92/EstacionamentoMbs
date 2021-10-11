namespace EstacionamentoMbs
{
    partial class Backup
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
            this.labelCaminho = new System.Windows.Forms.Label();
            this.textBoxCaminhoCriar = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.groupBoxCriarBackup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRestaurar = new System.Windows.Forms.GroupBox();
            this.buttonProcurarArq = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.textBoxImportar = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxCriarBackup.SuspendLayout();
            this.groupBoxRestaurar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCaminho
            // 
            this.labelCaminho.AutoSize = true;
            this.labelCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaminho.Location = new System.Drawing.Point(32, 36);
            this.labelCaminho.Name = "labelCaminho";
            this.labelCaminho.Size = new System.Drawing.Size(55, 13);
            this.labelCaminho.TabIndex = 15;
            this.labelCaminho.Text = "Caminho";
            // 
            // textBoxCaminhoCriar
            // 
            this.textBoxCaminhoCriar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCaminhoCriar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCaminhoCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaminhoCriar.Location = new System.Drawing.Point(23, 40);
            this.textBoxCaminhoCriar.Name = "textBoxCaminhoCriar";
            this.textBoxCaminhoCriar.Size = new System.Drawing.Size(458, 20);
            this.textBoxCaminhoCriar.TabIndex = 12;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(487, 83);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(95, 37);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.Location = new System.Drawing.Point(487, 40);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(95, 37);
            this.buttonProcurar.TabIndex = 15;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // groupBoxCriarBackup
            // 
            this.groupBoxCriarBackup.Controls.Add(this.buttonProcurar);
            this.groupBoxCriarBackup.Controls.Add(this.buttonSalvar);
            this.groupBoxCriarBackup.Controls.Add(this.textBoxCaminhoCriar);
            this.groupBoxCriarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCriarBackup.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCriarBackup.Name = "groupBoxCriarBackup";
            this.groupBoxCriarBackup.Size = new System.Drawing.Size(599, 136);
            this.groupBoxCriarBackup.TabIndex = 18;
            this.groupBoxCriarBackup.TabStop = false;
            this.groupBoxCriarBackup.Text = "Exportar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Caminho";
            // 
            // groupBoxRestaurar
            // 
            this.groupBoxRestaurar.Controls.Add(this.label1);
            this.groupBoxRestaurar.Controls.Add(this.buttonProcurarArq);
            this.groupBoxRestaurar.Controls.Add(this.buttonImportar);
            this.groupBoxRestaurar.Controls.Add(this.textBoxImportar);
            this.groupBoxRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRestaurar.Location = new System.Drawing.Point(12, 165);
            this.groupBoxRestaurar.Name = "groupBoxRestaurar";
            this.groupBoxRestaurar.Size = new System.Drawing.Size(599, 136);
            this.groupBoxRestaurar.TabIndex = 20;
            this.groupBoxRestaurar.TabStop = false;
            this.groupBoxRestaurar.Text = "Importar";
            // 
            // buttonProcurarArq
            // 
            this.buttonProcurarArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurarArq.Location = new System.Drawing.Point(487, 40);
            this.buttonProcurarArq.Name = "buttonProcurarArq";
            this.buttonProcurarArq.Size = new System.Drawing.Size(95, 37);
            this.buttonProcurarArq.TabIndex = 15;
            this.buttonProcurarArq.Text = "Procurar";
            this.buttonProcurarArq.UseVisualStyleBackColor = true;
            this.buttonProcurarArq.Click += new System.EventHandler(this.buttonProcurarArq_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportar.Location = new System.Drawing.Point(487, 83);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(95, 37);
            this.buttonImportar.TabIndex = 3;
            this.buttonImportar.Text = "Restaurar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxImportar
            // 
            this.textBoxImportar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxImportar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImportar.Location = new System.Drawing.Point(23, 40);
            this.textBoxImportar.Name = "textBoxImportar";
            this.textBoxImportar.Size = new System.Drawing.Size(458, 20);
            this.textBoxImportar.TabIndex = 12;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 323);
            this.Controls.Add(this.groupBoxRestaurar);
            this.Controls.Add(this.labelCaminho);
            this.Controls.Add(this.groupBoxCriarBackup);
            this.Name = "Backup";
            this.Text = "Backup";
            this.groupBoxCriarBackup.ResumeLayout(false);
            this.groupBoxCriarBackup.PerformLayout();
            this.groupBoxRestaurar.ResumeLayout(false);
            this.groupBoxRestaurar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCaminho;
        private System.Windows.Forms.TextBox textBoxCaminhoCriar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.GroupBox groupBoxCriarBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRestaurar;
        private System.Windows.Forms.Button buttonProcurarArq;
        private System.Windows.Forms.Button buttonImportar;
        private System.Windows.Forms.TextBox textBoxImportar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}