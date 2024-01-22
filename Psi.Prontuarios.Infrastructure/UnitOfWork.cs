using Psi.Prontuarios.Core;

namespace Psi.Eliane.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly PsiContext _context;

    public UnitOfWork(PsiContext context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
