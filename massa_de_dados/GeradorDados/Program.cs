using GeradorDados;
using GeradorDados.Models;

var generate = new Generates();

var database = new PostgresDataAccess();

var tipoRiscos = generate.TipoRiscos;
var riscoOcupacional = generate.RiscoOcupacionals;
var cargos = generate.Cargos;
var tipoEmpresas = generate.TipoEmpresas;
var exameTipo = generate.ExameTipos;

database.BulkInsert(tipoRiscos,
    @"INSERT INTO public.tiporisco(tiporiscoid, descricao) VALUES(@Tiporiscoid, @Descricao);");
database.BulkInsert(riscoOcupacional,
    @"INSERT INTO public.riscoocupacional(riscoocupacionalid, descricao, tiporiscoid)VALUES(@Riscoocupacionalid, @Descricao, @Tiporiscoid);");
database.BulkInsert(cargos,
    @"INSERT INTO public.cargo(cargoid, nome)VALUES(@Cargoid, @Nome);");
database.BulkInsert(tipoEmpresas, @"INSERT INTO public.tipoempresa(tipoempresaid, nome)VALUES(@Tipoempresaid, @Nome);");
database.BulkInsert(exameTipo,
    @"INSERT INTO public.exametipo(exametipoid, descricao)VALUES(@Exametipoid, @Descricao);");

var empresas = generate.Empresas(tipoEmpresas, 5_000);
var clinicas = generate.Clinicas(empresas, 1_000);

database.BulkInsert(empresas,
    @"INSERT INTO public.empresa(empresaid, cnpj, nome, endereco, telefone, tipoempresaid)VALUES(@Empresaid,@Cnpj,@Nome,@Endereco,@Telefone,@Tipoempresaid);");
database.BulkInsert(clinicas,
    @"INSERT INTO public.clinica(clinicaid, cnpj, nome, empresaid)VALUES(@Clinicaid, @Cnpj,@Nome, @Empresaid);");

var funcionarios = generate.Funcionarios(empresas, 100_000);
var medicos = generate.Medicos(clinicas, 5_000);

await Task.WhenAll(funcionarios, medicos);

database.BulkInsert(funcionarios.Result,
    @"INSERT INTO public.funcionario(funcionarioid, nome, datanascimento, cargoid, empresaid)VALUES(@Funcionarioid, @Nome, @Datanascimento, @Cargoid, @Empresaid);");
database.BulkInsert(medicos.Result, @"INSERT INTO public.medico(medicoid, nome, crm)VALUES(@Medicoid, @Nome, @Crm);");

var funcionarioRisco = await generate.FuncionarioRisco(funcionarios.Result, riscoOcupacional, 50_000);
database.BulkInsert(funcionarioRisco, "INSERT INTO public.funcionariorisco(funcionarioid, riscoocupacionalid)VALUES(@Funcionarioid, @Riscoocupacionalid);");

var exames = generate.Exames(5_000_000,exameTipo, funcionarios.Result, medicos.Result);
var atestados = generate.Atestados(2_000_000, funcionarios.Result,medicos.Result);



await Task.WhenAll(exames, atestados);

database.BulkInsert(exames.Result, @"INSERT INTO public.exame(exameid, dataexame, funcionarioid, exametipoid, medicoid)VALUES(@Exameid, @Dataexame, @Funcionarioid, @Exametipoid, @Medicoid);");
database.BulkInsert(atestados.Result, @"INSERT INTO public.atestado(atestadoid, dataemissao, qtddias, funcionarioid, medicoid)VALUES(@Atestadoid, @Dataemissao, @Qtddias, @Funcionarioid, @Medicoid);");

Console.WriteLine();
