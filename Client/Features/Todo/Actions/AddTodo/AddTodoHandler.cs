﻿namespace BlazorRedux.Client.Features.Todo
{
    using System.Threading;
    using System.Threading.Tasks;
    using BlazorState;
    using MediatR;

    public partial class TodoState
    {
        public class AddTodoHandler : ActionHandler<TodoState.AddTodoAction>
        {
            public AddTodoHandler(IStore aStore) : base(aStore) { }

            TodoState State => Store.GetState<TodoState>();

            public override Task<Unit> Handle(TodoState.AddTodoAction aTodoAction, CancellationToken aCancellationToken)
            {
                State.TheList.Add(aTodoAction.payload);
                return Unit.Task;
            }
        }
    }
}
