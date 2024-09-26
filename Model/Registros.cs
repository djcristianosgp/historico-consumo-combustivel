namespace historico_consumo_combustivel.Model
{
    public class Registros
    {
        public long idRegistro {  get; set; }
        public string destino { get; set; }
        public string colaborador { get; set; }
        public string veiculo { get; set; }
        public string combustivel { get; set; }
        public DateTime dataRegistro { get; set; }
        public DateTime dataIda { get; set; }
        public DateTime dataVolta { get; set; }
        public double kmInicial { get; set; }
        public double kmFinal { get; set; }
        public double kmRodados { get; set; }
        public double mediaConsumo { get; set; }
        public double consumo { get; set; }
        public double precoLitroCombustivel { get; set; }
        public double valor { get; set; }
    }
}
