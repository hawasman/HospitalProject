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
}

public class EFService<T>(EFRepository<T> repository) : IEFService<T> where T : BaseModel
{

    private readonly EFRepository<T> _repository = repository;

    public async Task<T> Create(T entity)
    {
        var newEntity = await _repository.Add(entity);
        return newEntity;
    }

    public async Task Delete(int id)
    {
        if (await _repository.GetById(id) != null)
        {
            await _repository.Delete(id);
        }
        return;
    }

    public async Task<bool> Exists(int id)
    {
        return await _repository.Exists(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        var entities = await _repository.GetAll();
        return entities;
    }

    public async Task<T?> GetById(int id)
    {
        var entity = await _repository.GetById(id);

        return entity;
    }

    public async Task<T> Update(T entity)
    {
        var newEntity = await _repository.Update(entity);

        return newEntity;
    }
}