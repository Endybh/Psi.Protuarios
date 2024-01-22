namespace Psi.Eliane.Core.Domain.Entities;

public class Prontuario:BaseEntity
{
    public DateTime DataSessao{get;set;}
    public string Memo{get;set;}
    public Guid PacienteFkId{get;set;}
    public Paciente Paciente{get;set;}
}