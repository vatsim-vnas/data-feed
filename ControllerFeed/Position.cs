namespace Vatsim.Nas.DataFeed.ControllerFeed;

public class Position
{
	public required string FacilityId { get; init; }
	public required string FacilityName { get; init; }
	public required string PositionId { get; init; }
	public required string PositionName { get; init; }
	public required PositionType PositionType { get; init; }
	public required string RadioName { get; init; }
	public required string DefaultCallsign { get; init; }
	public required int Frequency { get; init; }
	public required bool IsPrimary { get; init; }
	public required bool IsActive { get; init; }
	public EramPositionData? EramData { get; init; }
	public StarsPositionData? StarsData { get; init; }
}
