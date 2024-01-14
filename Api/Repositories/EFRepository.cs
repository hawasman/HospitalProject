using Api.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories;

public interface IEFRepository<T> where T : BaseModel
{
    Task<IEnumerable<T>> GetAll();
    Task<T?> GetById(int id);
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task Delete(int id);

    Task<bool> Exists(int id);
}

public class EFRepository<T> : IEFRepository<T> where T : BaseModel
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _DbSet;

    public EFRepository(AppDbContext context)
    {
        _context = context;
        _DbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _DbSet.ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
        return await _DbSet.FindAsync(id);
    }

    public async Task<T> Add(T entity)
    {
        await _DbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        _DbSet.Update(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(int id)
    {
        var entity = await _DbSet.FindAsync(id);
        if (entity == null) return;
        entity.ActiveField = false;
        _DbSet.Update(entity);
        await _context.SaveChangesAsync();
        return;
    }

    public async Task<bool> Exists(int id)
    {
        return await _DbSet.AnyAsync(x => x.Id == id);
    }
}