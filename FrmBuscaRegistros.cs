using historico_consumo_combustivel.Classes;
using historico_consumo_combustivel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace historico_consumo_combustivel
{
    public partial class FrmBuscaRegistros : Form
    {
        public FrmBuscaRegistros()
        {
            InitializeComponent();
        }

        public Registros RegistroSelecionado { get; private set; }

        private void FrmBuscaRegistros_Load(object sender, EventArgs e)
        {
            // Configurar as cores zebradas
            dgvRegistros.DefaultCellStyle.BackColor = Color.White; // Cor das linhas normais
            dgvRegistros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Cor das linhas alternadas

            // Outras configurações (opcionais)
            dgvRegistros.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistros.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dgvRegistros.AutoGenerateColumns = false;
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "idRegistro", HeaderText = "ID" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "destino", HeaderText = "Destino" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "colaborador", HeaderText = "Colaborador" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "veiculo", HeaderText = "Veículo" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "combustivel", HeaderText = "Combustível" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "dataIda", HeaderText = "Data Ida" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "dataVolta", HeaderText = "Data Volta" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "kmRodados", HeaderText = "Km Rodados" });
            dgvRegistros.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "valor", HeaderText = "Valor" });
            // Adicione outras colunas conforme necessário

            dgvRegistros.AllowUserToOrderColumns = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string criterio = txtSearch.Text.ToLower();

            // Filtra a lista com base no critério
            var resultadosFiltrados = ClsUteis.Registros.Where(r =>
                r.destino.ToLower().Contains(criterio) ||
                r.colaborador.ToLower().Contains(criterio) ||
                r.veiculo.ToLower().Contains(criterio) ||
                r.combustivel.ToLower().Contains(criterio)).OrderByDescending(ord => ord.idRegistro).ToList();

            // Atualiza o DataGridView com os resultados filtrados
            dgvRegistros.DataSource = resultadosFiltrados;
            
            dgvRegistros.AllowUserToOrderColumns = true;
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Captura o registro selecionado a partir da linha do DataGridView
                RegistroSelecionado = (Registros)dgvRegistros.Rows[e.RowIndex].DataBoundItem;

                // Fechar a tela de busca
                this.DialogResult = DialogResult.OK;  // Define o resultado como OK para indicar que a seleção foi feita
                this.Close();  // Fecha a tela de busca
            }
        }
    }
}
