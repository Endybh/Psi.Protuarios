namespace Psi.Prontuarios.Core;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
