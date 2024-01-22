namespace Psi.Eliane.Core.Domain.Entities;

public class BaseEntity
{
    public Guid Id{get;set;}
    public DateTime CreatedOn{get;set;}
    public DateTime UpdateOn{get;set;}
    public DateTime DeletedOn{get;set;}
}