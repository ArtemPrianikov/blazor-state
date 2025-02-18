namespace TestApp.Client.Features.Counter;

using BlazorState;
using System.Text.Json.Serialization;

public partial class CounterState : State<CounterState>
{

  public int Count { get; private set; }

  public CounterState() { }

  [JsonConstructor]
  public CounterState(Guid guid, int count)
  {
    Guid = guid;
    Count = count;
  }

  /// <summary>
  /// Set the Initial State
  /// </summary>
  public override void Initialize() => Count = 3;
}
