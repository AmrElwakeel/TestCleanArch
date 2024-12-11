using Microsoft.Extensions.Logging;
using TestCleanArch.Domain.Events;

namespace TestCleanArch.Application.TodoItems.EventHandlers;
public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("TestCleanArch Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
