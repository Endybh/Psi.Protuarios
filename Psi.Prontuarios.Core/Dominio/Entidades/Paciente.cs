namespace Psi.Eliane.Core.Domain.Entities
{
    public class Paciente:BaseEntity
    {
        public required string Name{get;set;}
        public required string Phone{get;set;}
        public required string Document{get;set;}
        public required string ReferencePhoneOne{get;set;}
        public required string ReferencePhoneTwo{get;set;}
        public required string Address{get;set;}
    }  
}
