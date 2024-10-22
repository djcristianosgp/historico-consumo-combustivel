using historico_consumo_combustivel.Classes;
using historico_consumo_combustivel.Model;

namespace historico_consumo_combustivel
{
    public partial class Form1 : Form
    {
        private Calculos calculos {get;set;}
        public Form1()
        {
            InitializeComponent();
            calculos = new Calculos();
        }
        bool bCalculado = false;
        long iCodigoEdit = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializa();
        }

        public bool Valida()
        {
            bCalculado = false;
            btnSalvar.Enabled = bCalculado;
            if (string.IsNullOrEmpty(txtKMInicial.Text))
                return false;

            if (string.IsNullOrEmpty(txtKMFinal.Text))
                return false;

            if (string.IsNullOrEmpty(txtDestino.Text))
                return false;

            if (string.IsNullOrEmpty(txtColaborador.Text))
                return false;

            if (string.IsNullOrEmpty(txtKMRodados.Text))
                return false;

            if (string.IsNullOrEmpty(txtMediaConsumo.Text))
                return false;

            if (string.IsNullOrEmpty(txtPrecoCombustivel.Text))
                return false;

            if (dtDataVolta.Value.Date < dtDataIda.Value.Date)
                return false;

            bCalculado = true;
            btnSalvar.Enabled = bCalculado;
            return true;

        }

        public void Inicializa()
        {
            iCodigoEdit = 0;
            bCalculado = false;
            btnSalvar.Enabled = bCalculado;
            txtDestino.Text = string.Empty;
            txtColaborador.Text = string.Empty;
            dtDataIda.Value = DateTime.Now;
            dtDataVolta.Value = DateTime.Now;
            txtKMInicial.Text = string.Empty;
            txtKMFinal.Text = string.Empty;
            txtKMRodados.Text = string.Empty;
            txtMediaConsumo.Text = string.Empty;
            txtPrecoCombustivel.Text = string.Empty;
            txtVeiculo.Text = string.Empty;
            txtResumo.Text = string.Empty;
            cbxCombustivel.SelectedIndex = 0;
        }

        private void txtKMInicial_TextChanged(object sender, EventArgs e)
        {
            CalculaKMRodadoConsumo();
            Valida();
        }

        private void txtKMFinal_TextChanged(object sender, EventArgs e)
        {
            CalculaKMRodadoConsumo();
            Valida();
        }

        public async Task Salvar()
        {
            var lListaRegistros = new List<Registros>();
            var registro = new Registros();
            registro.idRegistro = iCodigoEdit;
            registro.destino = txtDestino.Text;
            registro.colaborador = txtColaborador.Text;
            registro.dataRegistro = DateTime.Now;
            registro.dataIda = dtDataIda.Value.Date;
            registro.dataVolta = dtDataVolta.Value.Date;
            registro.kmInicial = Convert.ToDouble(txtKMInicial.Text);
            registro.kmFinal = Convert.ToDouble(txtKMFinal.Text);
            registro.kmRodados = Convert.ToDouble(txtKMRodados.Text);
            registro.mediaConsumo = Convert.ToDouble(txtMediaConsumo.Text);
            registro.consumo = registro.kmRodados / registro.mediaConsumo;
            registro.precoLitroCombustivel = Convert.ToDouble(txtPrecoCombustivel.Text);
            registro.valor = Math.Round((registro.kmRodados/ registro.mediaConsumo) * registro.precoLitroCombustivel, 2);
            registro.veiculo = txtVeiculo.Text;
            registro.combustivel = cbxCombustivel.SelectedItem.ToString();

            var retorno = await ClsUteis.SalvaListaRegistros(registro);
            if (retorno.Item1)
            {
                MessageBox.Show(retorno.Item2);
                Inicializa();
            }
            else
                MessageBox.Show(retorno.Item2);

        }

        private void CalculaKMRodadoConsumo()
        {
            if (!string.IsNullOrEmpty(txtKMInicial.Text) && !string.IsNullOrEmpty(txtKMFinal.Text))
            {
                var kmPercorrido = calculos.CalculaKMRodado(txtKMInicial.Text, txtKMFinal.Text).Result;               
                
                if (kmPercorrido > 0)
                {
                    txtKMRodados.Text = Math.Round(kmPercorrido, 2).ToString();
                    if (!string.IsNullOrEmpty(txtMediaConsumo.Text) && !string.IsNullOrEmpty(txtPrecoCombustivel.Text))
                    {  
                        var resultado = calculos.CalculaConsumo(txtMediaConsumo.Text, txtPrecoCombustivel.Text, kmPercorrido).Result;                            
                        txtResumo.Clear();
                        txtResumo.Text = $"Total consumido:{Environment.NewLine}R$ {Math.Round(resultado, 2)}";
                    }
                }
            }
        }

        private void txtKMInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bloqueia a tecla se não for permitida
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Bloqueia se já existir um ponto
            }
        }

        private void txtKMFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bloqueia a tecla se não for permitida
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Bloqueia se já existir um ponto
            }
        }

        private void txtMediaConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bloqueia a tecla se não for permitida
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Bloqueia se já existir um ponto
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            await Salvar();
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void txtMediaConsumo_TextChanged(object sender, EventArgs e)
        {
            CalculaKMRodadoConsumo();
            Valida();
        }

        private void txtColaborador_TextChanged(object sender, EventArgs e)
        {
            Valida();
        }

        private void txtPrecoCombustivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bloqueia a tecla se não for permitida
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true; // Bloqueia se já existir um ponto
            }
        }

        private void txtPrecoCombustivel_TextChanged(object sender, EventArgs e)
        {
            CalculaKMRodadoConsumo();
            Valida();
        }
        private void dtDataIda_ValueChanged(object sender, EventArgs e)
        {
            if (dtDataVolta.Value < dtDataIda.Value)
                dtDataVolta.Value = dtDataIda.Value;
            if (dtDataIda.Value > dtDataVolta.Value)
                dtDataIda.Value = dtDataVolta.Value;
        }

        private void dtDataVolta_ValueChanged(object sender, EventArgs e)
        {
            if (dtDataVolta.Value < dtDataIda.Value)
                dtDataVolta.Value = dtDataIda.Value;
            if (dtDataIda.Value > dtDataVolta.Value)
                dtDataIda.Value = dtDataVolta.Value;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {

            using (FrmBuscaRegistros telaBusca = new FrmBuscaRegistros())
            {
                if (telaBusca.ShowDialog() == DialogResult.OK)
                {
                    // Aqui, você pode acessar o registro selecionado
                    Registros registroSelecionado = telaBusca.RegistroSelecionado;

                    // Você pode preencher os campos da tela anterior com os dados do registro selecionado
                    iCodigoEdit = registroSelecionado.idRegistro;
                    txtDestino.Text = registroSelecionado.destino;
                    txtColaborador.Text = registroSelecionado.colaborador;
                    dtDataIda.Value = registroSelecionado.dataIda;
                    dtDataVolta.Value = registroSelecionado.dataVolta;
                    txtKMInicial.Text = registroSelecionado.kmInicial.ToString();
                    txtKMFinal.Text = registroSelecionado.kmFinal.ToString();
                    txtMediaConsumo.Text = registroSelecionado.mediaConsumo.ToString();
                    txtPrecoCombustivel.Text = registroSelecionado.precoLitroCombustivel.ToString();
                    txtVeiculo.Text = registroSelecionado.veiculo;
                    cbxCombustivel.Text = registroSelecionado.combustivel;
                }
            }
        }

    }
}
