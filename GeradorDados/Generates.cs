using Bogus;
using Bogus.Extensions.Brazil;
using GeradorDados.Models;

namespace GeradorDados;

public class Generates
{
    public List<Empresa> Empresas()
    {
        var empresas = new Faker<Empresa>("pt_BR")
            .RuleFor(c => c.EmpresaId, f => f.IndexFaker)
            .RuleFor(c => c.Cnpj, f => f.Company.Cnpj())
            .RuleFor(c => c.Nome, f => f.Company.CompanyName())
            .RuleFor(c => c.Endereco, f => f.Address.StreetAddress())
            .RuleFor(c => c.Telefone, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.TipoEmpresaId, f => f.Random.Int(1,21));
        return empresas.Generate(10);
    }
    
    public List<Funcionario> Funcionarios(List<Empresa> empresas)
    {
        var funcionarios = new Faker<Funcionario>("pt_BR")
            .RuleFor(c => c.FuncionarioId, f => f.IndexFaker)
            .RuleFor(c => c.CPF, f => f.Person.Cpf())
            .RuleFor(c => c.DataNascimento, f => f.Date.Past(18))
            .RuleFor(c => c.CargoId, faker => faker.Random.Int(1,40))
            .RuleFor(c => c.EmpresaId, f => f.PickRandom(empresas.Select(x => x.EmpresaId)));
        return funcionarios.Generate(10);
    }

    public List<Clinica> Clinicas(List<Empresa> empresas)
    {
        var empresasId = empresas.Select(x => x.EmpresaId);
        var clienteFaker = new Faker<Clinica>("pt_BR")
            .RuleFor(c => c.ClinicaId, f => f.IndexFaker)
            .RuleFor(c => c.Cnpj, f => f.Company.Cnpj())
            .RuleFor(c => c.Nome, f => "Clinica " + f.Company.CompanyName())
            .RuleFor(c => c.EmpresaId, f => f.PickRandom(empresasId));
        return clienteFaker.Generate(10);
    }

    public List<Medico> Medicos(List<Medico> clinicas)
    {
        var clienteFaker = new Faker<Medico>("pt_BR")
            .RuleFor(c => c.MedicoId, f => f.IndexFaker)
            .RuleFor(c => c.Nome, f => f.Name.FullName())
            .RuleFor(c => c.Crm, f => $"{f.Random.Int(10000, 99999)}/{f.Address.State()}")
            .RuleFor(c => c.ClinicaId, f => f.PickRandom(clinicas.Select(x => x.ClinicaId)));
        return clienteFaker.Generate(10);
    }

    public List<TipoRisco> TipoRiscos => new List<TipoRisco>
    {
        new(1, "Químico"),
        new(2, "Físico"),
        new(3, "Biológico"),
        new(4, "Ergonômico"),
        new(5, "Acidental")
    };

    public List<RiscoOcupacional> RiscoOcupacionals => new List<RiscoOcupacional>()
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

    public List<Cargo> Cargos => new List<Cargo>()
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
    
    public List<TipoEmpresa> TipoEmpresas => new List<TipoEmpresa>()
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
}