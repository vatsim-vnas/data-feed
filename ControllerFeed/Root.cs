namespace Vatsim.Nas.DataFeed.ControllerFeed;

public class Root
{
	public required DateTime UpdatedAt { get; init; }
	public required List<Controller> Controllers { get; init; }
}
