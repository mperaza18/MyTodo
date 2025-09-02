namespace TodoApp.Application.Interfaces;

using TodoApp.Application.DTOs;

public interface ITodoService
{
    Task<IEnumerable<TodoDto>> GetAllTodosAsync();
    Task<TodoDto?> GetTodoByIdAsync(Guid id);
    Task<TodoDto> CreateTodoAsync(CreateTodoDto createTodoDto);
    Task<TodoDto?> UpdateTodoAsync(Guid id, UpdateTodoDto updateTodoDto);
    Task<bool> DeleteTodoAsync(Guid id);
    Task<bool> CompleteTodoAsync(Guid id);
    Task<bool> ResetTodoAsync(Guid id);
}