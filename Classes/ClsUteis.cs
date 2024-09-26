using historico_consumo_combustivel.Model;
using Newtonsoft.Json;
//using System.Threading.Tasks;

namespace historico_consumo_combustivel.Classes
{
    public class ClsUteis

    {
        public ClsUteis()
        {
            CriaPastas();
            AlimentarListaDados();
        }
        public static string PastaPadrao = @"C:\Risco\HistoricoConsumo\";
        public static string PastaBD = @"C:\Risco\HistoricoConsumo\BD\";

        public static string BDJson = Path.Combine(PastaBD, "BDHistorico.json");
        public static string BDJsonColaboradores = Path.Combine(PastaBD, "BDColaboradore.json");
        public static string BDJsonVeiculos = Path.Combine(PastaBD, "BDVeiculo.json");
        public static string BDJsonDestinos = Path.Combine(PastaBD, "BDDestino.json");
        public static string BDJsonCombustiveis = Path.Combine(PastaBD, "BDCombustivel.json");

        public static List<Registros> Registros = new List<Registros>();
        public static List<Colaboradores> Colaboradores = new List<Colaboradores>();
        public static List<Veiculos> Veiculos = new List<Veiculos>();
        public static List<Destinos> Destinos = new List<Destinos>();
        public static List<Combustivel> Combustiveis = new List<Combustivel>();

        public async Task CriaPastas()
        {
            List<string> Pastas = new List<string>() { PastaPadrao, PastaBD };
            foreach (string Pasta in Pastas)
            {
                if (!Directory.Exists(Pasta))
                    Directory.CreateDirectory(Pasta);
            }
        }

        public static async Task AlimentarListaDados()
        {
            try
            {
                if (File.Exists(BDJson))
                    Registros = JsonConvert.DeserializeObject<List<Registros>>(File.ReadAllText(BDJson)).ToList();
                
                if (File.Exists(BDJsonColaboradores))
                    Colaboradores = JsonConvert.DeserializeObject<List<Colaboradores>>(File.ReadAllText(BDJsonColaboradores)).ToList();

                if (File.Exists(BDJsonVeiculos))
                    Veiculos = JsonConvert.DeserializeObject<List<Veiculos>>(File.ReadAllText(BDJsonVeiculos)).ToList();

                if (File.Exists(BDJsonDestinos))
                    Destinos = JsonConvert.DeserializeObject<List<Destinos>>(File.ReadAllText(BDJsonDestinos)).ToList();

                if (File.Exists(BDJsonCombustiveis))
                    Combustiveis = JsonConvert.DeserializeObject<List<Combustivel>>(File.ReadAllText(BDJsonCombustiveis)).ToList();
            }
            catch (Exception ex)
            {
            }
        }

        public static async Task<Tuple<bool, string>> SalvaListaRegistros(Registros registros)
        {
            try
            {
                if (registros.idRegistro == null || registros.idRegistro == 0)
                {
                    // Novo registro
                    registros.idRegistro = DateTime.Now.Ticks;
                    if (Registros == null)
                        Registros = new List<Registros>();

                    Registros.Add(registros);

                    var dados = JsonConvert.SerializeObject(Registros, Formatting.Indented);
                    File.WriteAllText(BDJson, dados);

                    await AlimentarListaDados();
                    return new Tuple<bool, string>(true, "Registro inserido com sucesso!!");
                }
                else
                {
                    // Atualização de registro existente
                    var index = Registros.FindIndex(xx => xx.idRegistro == registros.idRegistro);
                    if (index >= 0)
                    {
                        // Substitui o objeto na lista
                        Registros[index] = registros;

                        var dados = JsonConvert.SerializeObject(Registros, Formatting.Indented);
                        File.WriteAllText(BDJson, dados);
                        await AlimentarListaDados();
                        return new Tuple<bool, string>(true, "Registro atualizado com sucesso!!");
                    }
                    else
                    {
                        return new Tuple<bool, string>(false, "Registro não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
        }

        public static async Task<Tuple<bool, string>> SalvaListaColaboradores(Colaboradores colaborador)
        {
            try
            {
                if (colaborador.idColaborador == null || colaborador.idColaborador == 0)
                {
                    // Novo registro
                    colaborador.idColaborador = DateTime.Now.Ticks;
                    if (Colaboradores == null)
                        Colaboradores = new List<Colaboradores>();

                    Colaboradores.Add(colaborador);

                    var dados = JsonConvert.SerializeObject(Colaboradores, Formatting.Indented);
                    File.WriteAllText(BDJsonColaboradores, dados);

                    await AlimentarListaDados();
                    return new Tuple<bool, string>(true, "Registro inserido com sucesso!!");
                }
                else
                {
                    // Atualização de registro existente
                    var index = Colaboradores.FindIndex(xx => xx.idColaborador == colaborador.idColaborador);
                    if (index >= 0)
                    {
                        // Substitui o objeto na lista
                        Colaboradores[index] = colaborador;

                        var dados = JsonConvert.SerializeObject(Colaboradores, Formatting.Indented);
                        File.WriteAllText(BDJsonColaboradores, dados);
                        await AlimentarListaDados();
                        return new Tuple<bool, string>(true, "Registro atualizado com sucesso!!");
                    }
                    else
                    {
                        return new Tuple<bool, string>(false, "Registro não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
        }

        public static async Task<Tuple<bool, string>> SalvaListaVeiculo(Veiculos veiculo)
        {
            try
            {
                if (veiculo.idVeiculo == null || veiculo.idVeiculo == 0)
                {
                    // Novo registro
                    veiculo.idVeiculo = DateTime.Now.Ticks;
                    if (Veiculos == null)
                        Veiculos = new List<Veiculos>();

                    Veiculos.Add(veiculo);

                    var dados = JsonConvert.SerializeObject(Veiculos, Formatting.Indented);
                    File.WriteAllText(BDJsonVeiculos, dados);

                    await AlimentarListaDados();
                    return new Tuple<bool, string>(true, "Registro inserido com sucesso!!");
                }
                else
                {
                    // Atualização de registro existente
                    var index = Veiculos.FindIndex(xx => xx.idVeiculo == veiculo.idVeiculo);
                    if (index >= 0)
                    {
                        // Substitui o objeto na lista
                        Veiculos[index] = veiculo;

                        var dados = JsonConvert.SerializeObject(Veiculos, Formatting.Indented);
                        File.WriteAllText(BDJsonVeiculos, dados);
                        await AlimentarListaDados();
                        return new Tuple<bool, string>(true, "Registro atualizado com sucesso!!");
                    }
                    else
                    {
                        return new Tuple<bool, string>(false, "Registro não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
        }

        public static async Task<Tuple<bool, string>> SalvaListaCombustivel(Combustivel combustivel)
        {
            try
            {
                if (combustivel.idCombustivel == null || combustivel.idCombustivel == 0)
                {
                    // Novo registro
                    combustivel.idCombustivel = DateTime.Now.Ticks;
                    if (Combustiveis == null)
                        Combustiveis = new List<Combustivel>();

                    Combustiveis.Add(combustivel);

                    var dados = JsonConvert.SerializeObject(Combustiveis, Formatting.Indented);
                    File.WriteAllText(BDJsonCombustiveis, dados);

                    await AlimentarListaDados();
                    return new Tuple<bool, string>(true, "Registro inserido com sucesso!!");
                }
                else
                {
                    // Atualização de registro existente
                    var index = Combustiveis.FindIndex(xx => xx.idCombustivel == combustivel.idCombustivel);
                    if (index >= 0)
                    {
                        // Substitui o objeto na lista
                        Combustiveis[index] = combustivel;

                        var dados = JsonConvert.SerializeObject(Combustiveis, Formatting.Indented);
                        File.WriteAllText(BDJsonCombustiveis, dados);
                        await AlimentarListaDados();
                        return new Tuple<bool, string>(true, "Registro atualizado com sucesso!!");
                    }
                    else
                    {
                        return new Tuple<bool, string>(false, "Registro não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
        }

        public static async Task<Tuple<bool, string>> SalvaListaDestino(Destinos destino)
        {
            try
            {
                if (destino.idDestino == null || destino.idDestino == 0)
                {
                    // Novo registro
                    destino.idDestino = DateTime.Now.Ticks;
                    if (Destinos == null)
                        Destinos = new List<Destinos>();

                    Destinos.Add(destino);

                    var dados = JsonConvert.SerializeObject(Destinos, Formatting.Indented);
                    File.WriteAllText(BDJsonDestinos, dados);

                    await AlimentarListaDados();
                    return new Tuple<bool, string>(true, "Registro inserido com sucesso!!");
                }
                else
                {
                    // Atualização de registro existente
                    var index = Destinos.FindIndex(xx => xx.idDestino == destino.idDestino);
                    if (index >= 0)
                    {
                        // Substitui o objeto na lista
                        Destinos[index] = destino;

                        var dados = JsonConvert.SerializeObject(Destinos, Formatting.Indented);
                        File.WriteAllText(BDJsonDestinos, dados);
                        await AlimentarListaDados();
                        return new Tuple<bool, string>(true, "Registro atualizado com sucesso!!");
                    }
                    else
                    {
                        return new Tuple<bool, string>(false, "Registro não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
        }
    }
}
