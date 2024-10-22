namespace historico_consumo_combustivel.Classes
{
    public class Calculos
    {
        public async Task<double> CalculaKMRodado(string txtKMInicial, string txtKMFinal)
        {
                double kmInicial = Convert.ToDouble(txtKMInicial);
                double kmFinal = Convert.ToDouble(txtKMFinal);
                double kmPercorrido = kmFinal - kmInicial;
                if (kmPercorrido > 0)
                    return Math.Round(kmPercorrido, 2);
                else
                    return 0;
        }

        public async Task<double> CalculaConsumo(string txtMediaConsumo, string txtPrecoCombustivel, double kmPercorrido)
        {
            double mediaConsumo = Convert.ToDouble(txtMediaConsumo);
            double precoCombustivel = Convert.ToDouble(txtPrecoCombustivel);
            var resultado = (kmPercorrido / mediaConsumo) * precoCombustivel;
            return Math.Round(resultado, 2);
        }
    }
}
