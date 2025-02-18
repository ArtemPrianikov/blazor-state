namespace TestApp.Client.Features.Counter;

using BlazorState;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TestApp.Client.Features.Base;
using static TestApp.Client.Features.Counter.WrongNesting;

public partial class CounterState
{
  internal class ImproperNestedHandler : BaseActionHandler<ImproperNestedAction>
  {
    public ImproperNestedHandler(IStore store) : base(store) { }

    public override Task<Unit> Handle
    (
      ImproperNestedAction aImproperNestedAction,
      CancellationToken aCancellationToken
    ) => Unit.Task;
  }
}
