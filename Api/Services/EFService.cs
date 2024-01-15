using Api.Helpers;
using Api.Repositories;

namespace Api.Services;

public interface IEFService<T> where T : BaseModel
{
    Task<T?> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task Delete(int id);
    Task<bool> Exists(int id);
    IEnumerable<T> Where(Func<T, bool> func);
}

public class EFService<T>(EFRepository<T> repository) : IEFService<T> where T : BaseModel
{
    public async Task<T> Create(T entity)
    {
        var newEntity = await repository.Add(entity);
        return newEntity;
    }

    public async Task Delete(int id)
    {
        if (await repository.GetById(id) != null)
        {
            await repository.Delete(id);
        }
        return;
    }

    public async Task<bool> Exists(int id)
    {
        return await repository.Exists(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        var entities = await repository.GetAll();
        return entities;
    }

    public async Task<T?> GetById(int id)
    {
        var entity = await repository.GetById(id);

        return entity;
    }

    public async Task<T> Update(T entity)
    {
        var newEntity = await repository.Update(entity);

        return newEntity;
    }
    
    public IEnumerable<T> Where(Func<T, bool> func)
    {
        return repository.Where(func);
    }
}