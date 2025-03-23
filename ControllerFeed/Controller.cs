namespace Vatsim.Nas.DataFeed.ControllerFeed;

public class Controller
{
	public required string ArtccId { get; init; }
	public required string PrimaryFacilityId { get; init; }
	public required string PrimaryPositionId { get; init; }
	public required Role Role { get; init; }
	public required List<Position> Positions { get; init; }
	public required bool IsActive { get; init; }
	public required bool IsObserver { get; init; }
	public required DateTime LoginTime { get; init; }
	public required VatsimData VatsimData { get; init; }
}
