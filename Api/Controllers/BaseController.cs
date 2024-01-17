using Api.Helpers;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public interface IBaseController<T>
{
    public Task<ActionResult<T?>> GetById(int id);
    public Task<ActionResult<IEnumerable<T>>> GetAll();
    public Task<ActionResult<T>> Create(T entity);
    public Task<ActionResult<T>> Update(int id, T entity);
    public Task<IActionResult> Delete(T entity);
}

public class BaseController<T> : ControllerBase, IBaseController<T> where T : BaseModel
{

    private readonly EFService<T> _service;

    public BaseController(EFService<T> service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<T>>> GetAll()
    {
        var entities = await _service.GetAll();
        if (entities == null || !entities.Any())
        {
            return NotFound();
        }
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<T?>> GetById(int id)
    {
        var entity = await _service.GetById(id);
        if (entity == null)
        {
            return NotFound();
        }

        return entity;
    }

    [HttpPost]
    public async Task<ActionResult<T>> Create(T entity)
    {
        entity = await _service.Create(entity);

        return Ok(entity);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(T entity)
    {

        if (await _service.Exists(entity.Id))
        {
            return NotFound();
        }

        await _service.Delete(entity.Id);
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<T>> Update(int id, T entity)
    {
        if (id != entity.Id)
        {
            return BadRequest();
        }

        if (!await _service.Exists(id))
        {
            return NotFound();
        }

        return NoContent();
    }
}