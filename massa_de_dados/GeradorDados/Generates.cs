using Bogus;
using Bogus.Extensions.Brazil;
using GeradorDados.Models;

namespace GeradorDados;

public class Generates
{
    public List<Empresa> Empresas(List<TipoEmpresa> tipoEmpresas, int quantidade)
    {
        var faker = new Faker<Empresa>("pt_BR")
            .RuleFor(c => c.Empresaid, f => f.IndexFaker)
            .RuleFor(c => c.Cnpj, f => f.Company.Cnpj(false))
            .RuleFor(c => c.Nome, f => f.Company.CompanyName())
            .RuleFor(c => c.Endereco, f => f.Address.StreetAddress())
            .RuleFor(c => c.Telefone, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.Tipoempresaid, f => f.Random.Int(1, 21))
            .RuleFor(c => c.Tipoempresaid, f => f.PickRandom(tipoEmpresas.Select(x => x.Tipoempresaid)));
        
        var empresas = faker.Generate(quantidade);
        
        var uniqueEmpresas = new Dictionary<string, Empresa>();
        foreach (var empresa in empresas.Where(empresa => !uniqueEmpresas.ContainsKey(empresa.Cnpj)))
        {
            uniqueEmpresas.Add(empresa.Cnpj, empresa);
        }
        
        return uniqueEmpresas.Values.ToList();
    }

    public async Task<List<Funcionario>> Funcionarios(List<Empresa> empresas, int quantidade)
    {
        return await Task.Run(() =>
        {
            var funcionarios = new Faker<Funcionario>("pt_BR")
                .RuleFor(c => c.Funcionarioid, f => f.IndexFaker)
                .RuleFor(c => c.Nome, f => f.Person.FullName)
                .RuleFor(c => c.Datanascimento, f => f.Date.Past(18))
                .RuleFor(c => c.Cargoid, faker => faker.Random.Int(1, 40))
                .RuleFor(c => c.Empresaid, f => f.PickRandom(empresas.Select(x => x.Empresaid)));
            return funcionarios.Generate(quantidade);
        } );
        
    }
    
    public async Task<List<FuncionarioRisco>> FuncionarioRisco(List<Funcionario> funcionarios,List<RiscoOcupacional> riscos, int quantidade)
    {
        return await Task.Run(() =>
        {
            var funcionarioRisco = new Faker<FuncionarioRisco>("pt_BR")
                .RuleFor(c => c.Funcionarioid, f => f.PickRandom(funcionarios.Select(x => x.Funcionarioid)))
                .RuleFor(c => c.RiscoOcupacionalid, f => f.PickRandom(riscos.Select(x => x.Riscoocupacionalid)));
            return funcionarioRisco.Generate(quantidade);
        } );
        
    }

    public List<Clinica> Clinicas(List<Empresa> empresas, int quantidade)
    {
        var empresasId = empresas.Select(x => x.Empresaid);
        var clienteFaker = new Faker<Clinica>("pt_BR")
            .RuleFor(c => c.Clinicaid, f => f.IndexFaker)
            .RuleFor(c => c.Cnpj, f => f.Company.Cnpj())
            .RuleFor(c => c.Nome, f => "Clinica " + f.Company.CompanyName())
            .RuleFor(c => c.Empresaid, f => f.PickRandom(empresasId));
        return clienteFaker.Generate(quantidade);
    }
    
    public async Task<List<Medico>> Medicos(List<Clinica> clinicas, int quantidade)
    {
        
        return await Task.Run(() =>
        {
            var faker = new Faker<Medico>("pt_BR")
                .RuleFor(c => c.Medicoid, f => f.IndexFaker)
                .RuleFor(c => c.Nome, f => f.Name.FullName())
                .RuleFor(c => c.Crm, f => $"{f.Random.Int(10000, 99999)}/{f.Address.StateAbbr()}");
            //.RuleFor(c => c.ClinicaId, f => f.PickRandom(clinicas.Select(x => x.ClinicaId)));
            var medicos = faker.Generate(quantidade);

            // Utiliza um dicionário para filtrar por CNPJ único
            var uniqueMedicos = new Dictionary<string, Medico>();
            foreach (var medico in medicos.Where(medico => !uniqueMedicos.ContainsKey(medico.Crm)))
            {
                uniqueMedicos.Add(medico.Crm, medico);
            }
            
            return uniqueMedicos.Values.ToList();;
        });
        
    }

    public List<TipoRisco> TipoRiscos => new()
    {
        new(1, "Químico"),
        new(2, "Físico"),
        new(3, "Biológico"),
        new(4, "Ergonômico"),
        new(5, "Acidental")
    };

    public List<RiscoOcupacional> RiscoOcupacionals => new()
    {
        new(1, "Choque Elétrico", 5),
        new(2, "Exposição a Agentes Biológicos", 3),
        new(3, "L.E.R. (Lesão por Esforço Repetitivo)", 4),
        new(4, "Ruídos Constantes", 2),
        new(5, "Inalação de Produtos Químicos", 1),
        new(6, "Queda de Altura", 5),
        new(7, "Cortes", 2),
        new(8, "Queimaduras", 1),
        new(9, "Exposição Solar", 3),
        new(10, "Stress Térmico", 4),
        new(11, "Choque Elétrico em Áreas Úmidas", 5),
        new(12, "Contaminação por Radiação", 3),
        new(13, "Lesões Oculares por Solda", 4),
        new(14, "Perda Auditiva Induzida por Ruído", 2),
        new(15, "Dermatites por Contato Químico", 1),
        new(16, "Esmagamento por Equipamento Pesado", 5),
        new(17, "Intoxicação Alimentar por Manipulação", 3),
        new(18, "Distúrbios Psicológicos por Pressão", 4),
        new(19, "Riscos Ergonômicos em Escritório", 2),
        new(20, "Asfixia em Espaços Confinados", 1)
    };

    public List<Cargo> Cargos => new()
    {
        new(1, "Desenvolvedor de Software", 19),
        new(2, "Analista de Sistemas", 19),
        new(3, "Gerente de Projetos", 18),
        new(4, "Designer Gráfico", 19),
        new(5, "Engenheiro Civil", 16),
        new(6, "Arquiteto", 16),
        new(7, "Contador", 18),
        new(8, "Advogado", 18),
        new(9, "Médico", 2),
        new(10, "Enfermeiro", 2),
        new(11, "Dentista", 2),
        new(12, "Farmacêutico", 5),
        new(13, "Professor", 18),
        new(14, "Diretor de Escola", 18),
        new(15, "Cientista de Dados", 19),
        new(16, "Analista de Marketing", 19),
        new(17, "Executivo de Vendas", 18),
        new(18, "Gerente de Recursos Humanos", 18),
        new(19, "Consultor Financeiro", 18),
        new(20, "Jornalista", 18),
        new(21, "Editor", 18),
        new(22, "Fotógrafo", 18),
        new(23, "Chef de Cozinha", 17),
        new(24, "Nutricionista", 3),
        new(25, "Psicólogo", 18),
        new(26, "Fisioterapeuta", 3),
        new(27, "Personal Trainer", 13),
        new(28, "Barista", 17),
        new(29, "Recepcionista", 18),
        new(30, "Assistente Administrativo", 19),
        new(31, "Operador de Caixa", 17),
        new(32, "Mecânico", 16),
        new(33, "Eletricista", 1),
        new(34, "Pintor", 7),
        new(35, "Carpinteiro", 7),
        new(36, "Soldador", 13),
        new(37, "Motorista", 16),
        new(38, "Piloto", 16),
        new(39, "Comissário de Bordo", 18),
        new(40, "Agente de Viagens", 18),
    };

    public List<TipoEmpresa> TipoEmpresas => new()
    {
        new(1, "Startup"),
        new(2, "Multinacional"),
        new(3, "Pequena e Média Empresa (PME)"),
        new(4, "Empresa de Tecnologia"),
        new(5, "Consultoria"),
        new(6, "ONG"),
        new(7, "Autônomo"),
        new(8, "Educação"),
        new(9, "Saúde"),
        new(10, "Governo"),
        new(11, "Microempreendedor Individual (MEI)"),
        new(12, "Empresa Individual de Responsabilidade Limitada (EIRELI)"),
        new(13, "Sociedade Limitada (Ltda.)"),
        new(14, "Sociedade Anônima (S.A.)"),
        new(15, "Sociedade Simples"),
        new(16, "Sociedade Empresária Limitada"),
        new(17, "Cooperativa"),
        new(18, "Microempresa (ME)"),
        new(19, "Empresa de Pequeno Porte (EPP)"),
        new(20, "Sociedade Unipessoal"),
        new(21, "Sociedade de Propósito Específico (SPE)")
    };

    public List<ExameTipo> ExameTipos => new()
    {
        new ExameTipo(1, "Hemograma Completo"),
        new ExameTipo(2, "Glicemia de Jejum"),
        new ExameTipo(3, "Perfil Lipídico"),
        new ExameTipo(4, "Exame de Urina"),
        new ExameTipo(5, "Exame de Fezes"),
        new ExameTipo(6, "Eletrocardiograma"),
        new ExameTipo(7, "Ultrassonografia"),
        new ExameTipo(8, "Tomografia Computadorizada"),
        new ExameTipo(9, "Ressonância Magnética"),
        new ExameTipo(10, "Biopsia"),
        new ExameTipo(11, "Teste Ergométrico"),
        new ExameTipo(12, "Endoscopia"),
        new ExameTipo(13, "Colonoscopia"),
        new ExameTipo(14, "Espirometria"),
        new ExameTipo(15, "Raio-X"),
        new ExameTipo(16, "Mamografia"),
        new ExameTipo(17, "Densitometria Óssea"),
        new ExameTipo(18, "Ecocardiograma"),
        new ExameTipo(19, "Mapa (Monitorização Ambulatorial da Pressão Arterial)"),
        new ExameTipo(20, "Holter 24 horas"),
        new ExameTipo(21, "Teste de Tilt"),
        new ExameTipo(22, "Cintilografia"),
        new ExameTipo(23, "Angiografia"),
        new ExameTipo(24, "Polissonografia"),
        new ExameTipo(25, "Teste de Função Pulmonar"),
        new ExameTipo(26, "Teste de Esforço Cardíaco"),
        new ExameTipo(27, "PET Scan (Tomografia por Emissão de Pósitrons)"),
        new ExameTipo(28, "Teste de audição"),
        new ExameTipo(29, "Oftalmologia Exame Fundo de Olho"),
        new ExameTipo(30, "Eletroneuromiografia")
    };

    public async Task<List<Exame>> Exames(int quantidade, List<ExameTipo> exameTipos, List<Funcionario> funcionarios, List<Medico> medicos)
    {
        return await Task.Run(() =>
        {
            var exames = new Faker<Exame>("pt_BR")
                .RuleFor(c => c.Exameid, f => f.IndexFaker)
                .RuleFor(c => c.Exametipoid, f => f.PickRandom(exameTipos.Select(x => x.Exametipoid)))
                .RuleFor(c => c.Dataexame, f => f.Date.Recent())
                .RuleFor(c => c.Funcionarioid, f => f.PickRandom(funcionarios.Select(x => x.Funcionarioid)))
                .RuleFor(c => c.Medicoid, f => f.PickRandom(medicos.Select(x => x.Medicoid)))
                .FinishWith((f, u) =>
                {
                    Console.WriteLine("Exame Criado! Id={0}", u.Exameid);
                });;
            return exames.GenerateForever().Take(quantidade).ToList();
        });
    }

    public async Task<List<Atestado>> Atestados(int quantidade, List<Funcionario> funcionarios, List<Medico> medicos)
    {
        return await Task.Run((() =>
        {
            var atestados = new Faker<Atestado>("pt_BR")
                .RuleFor(c => c.Atestadoid, f => f.IndexFaker)
                .RuleFor(c => c.Funcionarioid, f => f.PickRandom(funcionarios.Select(x => x.Funcionarioid)))
                .RuleFor(c => c.Medicoid, f => f.PickRandom(medicos.Select(x => x.Medicoid))).FinishWith((f, u) =>
                {
                    Console.WriteLine("Atestado Criado! Id={0}", u.Atestadoid);
                });;
            return atestados.Generate(quantidade);
        }));
    }
}