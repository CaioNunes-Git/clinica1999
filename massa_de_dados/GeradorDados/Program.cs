using GeradorDados;

var generate = new Generates();

var tipoRiscos = generate.TipoRiscos;
var riscoOcupacional = generate.RiscoOcupacionals;
var cargos = generate.Cargos;
var tipoEmpresas = generate.TipoEmpresas;
var exameTipo = generate.ExameTipos;
var empresas = generate.Empresas(5000);
var clinicas = generate.Clinicas(empresas, 1000);

var funcionarios = generate.Funcionarios(empresas, 100000);
var medicos = generate.Medicos(clinicas, 50000);

await Task.WhenAll(funcionarios, medicos);


var exames = generate.Exames(10000000,exameTipo, funcionarios.Result, medicos.Result);
var atestados = generate.Atestados(1000000, funcionarios.Result,medicos.Result);

await Task.WhenAll(exames, atestados);

Console.WriteLine();
