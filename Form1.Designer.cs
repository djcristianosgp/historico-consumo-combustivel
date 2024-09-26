namespace historico_consumo_combustivel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtColaborador = new TextBox();
            label9 = new Label();
            dtDataVolta = new DateTimePicker();
            label3 = new Label();
            dtDataIda = new DateTimePicker();
            label2 = new Label();
            txtDestino = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbxCombustivel = new ComboBox();
            label11 = new Label();
            txtVeiculo = new TextBox();
            label10 = new Label();
            txtPrecoCombustivel = new TextBox();
            label8 = new Label();
            txtMediaConsumo = new TextBox();
            label7 = new Label();
            txtKMRodados = new TextBox();
            label6 = new Label();
            txtKMFinal = new TextBox();
            label5 = new Label();
            txtKMInicial = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtResumo = new RichTextBox();
            btnSalvar = new Button();
            panel1 = new Panel();
            btnBusca = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtColaborador);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dtDataVolta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtDataIda);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDestino);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Viagem";
            // 
            // txtColaborador
            // 
            txtColaborador.CharacterCasing = CharacterCasing.Upper;
            txtColaborador.Location = new Point(6, 81);
            txtColaborador.MaxLength = 200;
            txtColaborador.Name = "txtColaborador";
            txtColaborador.Size = new Size(419, 23);
            txtColaborador.TabIndex = 1;
            txtColaborador.TextChanged += txtColaborador_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 63);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 6;
            label9.Text = "Colaborador:";
            // 
            // dtDataVolta
            // 
            dtDataVolta.CustomFormat = "";
            dtDataVolta.Format = DateTimePickerFormat.Short;
            dtDataVolta.Location = new Point(119, 125);
            dtDataVolta.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtDataVolta.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtDataVolta.Name = "dtDataVolta";
            dtDataVolta.Size = new Size(107, 23);
            dtDataVolta.TabIndex = 3;
            dtDataVolta.ValueChanged += dtDataVolta_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 107);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Data da Volta:";
            // 
            // dtDataIda
            // 
            dtDataIda.CustomFormat = "";
            dtDataIda.Format = DateTimePickerFormat.Short;
            dtDataIda.Location = new Point(6, 125);
            dtDataIda.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtDataIda.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtDataIda.Name = "dtDataIda";
            dtDataIda.Size = new Size(107, 23);
            dtDataIda.TabIndex = 2;
            dtDataIda.ValueChanged += dtDataIda_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Data da Ida:";
            // 
            // txtDestino
            // 
            txtDestino.CharacterCasing = CharacterCasing.Upper;
            txtDestino.Location = new Point(6, 37);
            txtDestino.MaxLength = 300;
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(419, 23);
            txtDestino.TabIndex = 0;
            txtDestino.TextChanged += txtDestino_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Destino:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxCombustivel);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtVeiculo);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtPrecoCombustivel);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMediaConsumo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtKMRodados);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtKMFinal);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtKMInicial);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 207);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Do Veículo";
            // 
            // cbxCombustivel
            // 
            cbxCombustivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCombustivel.FormattingEnabled = true;
            cbxCombustivel.Items.AddRange(new object[] { "Alcool", "Diesel", "Gasolina", "Gasolina Aditivada", "Gás" });
            cbxCombustivel.Location = new Point(6, 171);
            cbxCombustivel.Name = "cbxCombustivel";
            cbxCombustivel.Size = new Size(163, 23);
            cbxCombustivel.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 153);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 25;
            label11.Text = "Combustível:";
            // 
            // txtVeiculo
            // 
            txtVeiculo.CharacterCasing = CharacterCasing.Upper;
            txtVeiculo.Location = new Point(6, 127);
            txtVeiculo.MaxLength = 200;
            txtVeiculo.Name = "txtVeiculo";
            txtVeiculo.Size = new Size(274, 23);
            txtVeiculo.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 109);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 23;
            label10.Text = "Veículo:";
            // 
            // txtPrecoCombustivel
            // 
            txtPrecoCombustivel.Location = new Point(220, 83);
            txtPrecoCombustivel.Name = "txtPrecoCombustivel";
            txtPrecoCombustivel.Size = new Size(205, 23);
            txtPrecoCombustivel.TabIndex = 3;
            txtPrecoCombustivel.TextAlign = HorizontalAlignment.Center;
            txtPrecoCombustivel.TextChanged += txtPrecoCombustivel_TextChanged;
            txtPrecoCombustivel.KeyPress += txtPrecoCombustivel_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(220, 65);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 21;
            label8.Text = "Preço Combustível:";
            // 
            // txtMediaConsumo
            // 
            txtMediaConsumo.Location = new Point(6, 83);
            txtMediaConsumo.Name = "txtMediaConsumo";
            txtMediaConsumo.Size = new Size(205, 23);
            txtMediaConsumo.TabIndex = 2;
            txtMediaConsumo.TextAlign = HorizontalAlignment.Center;
            txtMediaConsumo.TextChanged += txtMediaConsumo_TextChanged;
            txtMediaConsumo.KeyPress += txtMediaConsumo_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 65);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 18;
            label7.Text = "Média de Consumo:";
            // 
            // txtKMRodados
            // 
            txtKMRodados.BackColor = Color.White;
            txtKMRodados.Location = new Point(286, 39);
            txtKMRodados.Name = "txtKMRodados";
            txtKMRodados.ReadOnly = true;
            txtKMRodados.Size = new Size(139, 23);
            txtKMRodados.TabIndex = 17;
            txtKMRodados.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(286, 21);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 16;
            label6.Text = "KM Rodados:";
            // 
            // txtKMFinal
            // 
            txtKMFinal.Location = new Point(146, 39);
            txtKMFinal.Name = "txtKMFinal";
            txtKMFinal.Size = new Size(134, 23);
            txtKMFinal.TabIndex = 1;
            txtKMFinal.TextAlign = HorizontalAlignment.Center;
            txtKMFinal.TextChanged += txtKMFinal_TextChanged;
            txtKMFinal.KeyPress += txtKMFinal_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 21);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 14;
            label5.Text = "KM Final:";
            // 
            // txtKMInicial
            // 
            txtKMInicial.Location = new Point(6, 39);
            txtKMInicial.Name = "txtKMInicial";
            txtKMInicial.Size = new Size(134, 23);
            txtKMInicial.TabIndex = 0;
            txtKMInicial.TextAlign = HorizontalAlignment.Center;
            txtKMInicial.TextChanged += txtKMInicial_TextChanged;
            txtKMInicial.KeyPress += txtKMInicial_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 21);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 12;
            label4.Text = "KM Inicial:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtResumo);
            groupBox3.Controls.Add(btnSalvar);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 370);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(438, 120);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumo";
            // 
            // txtResumo
            // 
            txtResumo.AutoWordSelection = true;
            txtResumo.BackColor = Color.White;
            txtResumo.Dock = DockStyle.Fill;
            txtResumo.Font = new Font("Segoe UI", 12F);
            txtResumo.Location = new Point(3, 19);
            txtResumo.Name = "txtResumo";
            txtResumo.ReadOnly = true;
            txtResumo.Size = new Size(317, 98);
            txtResumo.TabIndex = 1;
            txtResumo.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Right;
            btnSalvar.Enabled = false;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(320, 19);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 98);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar Registro";
            btnSalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBusca);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 44);
            panel1.TabIndex = 3;
            // 
            // btnBusca
            // 
            btnBusca.Dock = DockStyle.Right;
            btnBusca.Image = (Image)resources.GetObject("btnBusca.Image");
            btnBusca.Location = new Point(286, 0);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(152, 44);
            btnBusca.TabIndex = 0;
            btnBusca.Text = "Buscar Registros";
            btnBusca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 534);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de consumo de combustível";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtDataVolta;
        private Label label3;
        private DateTimePicker dtDataIda;
        private Label label2;
        private TextBox txtDestino;
        private GroupBox groupBox2;
        private TextBox txtKMRodados;
        private Label label6;
        private TextBox txtKMFinal;
        private Label label5;
        private TextBox txtKMInicial;
        private Label label4;
        private TextBox txtMediaConsumo;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private RichTextBox txtResumo;
        private Button btnSalvar;
        private Panel panel1;
        private TextBox txtColaborador;
        private Label label9;
        private TextBox txtPrecoCombustivel;
        private ComboBox cbxCombustivel;
        private Label label11;
        private TextBox txtVeiculo;
        private Label label10;
        private Button btnBusca;
    }
}
