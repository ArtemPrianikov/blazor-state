namespace Junk.Client.Pages;

using Microsoft.AspNetCore.Components;
using Junk.Client.Features.Counter;
using Junk.Client.Features.Counter2;
using System.Threading.Tasks;

public partial class CounterPage
{
  [Inject] private IStore Store { get; set; } = null!;

  CounterState CounterState => GetState<CounterState>();
  Counter2State Counter2State => GetState<Counter2State>();

  async Task IncrementCount() => await Mediator.Send(new CounterState.IncrementCount.Action { Amount = 5 });
  async Task IncrementCount2() => await Mediator.Send(new Counter2State.IncrementCount.Action { Amount = 3 });
}
