namespace Vatsim.Nas.DataFeed.ControllerFeed;

public class VatsimData
{
	public required string Cid { get; init; }
	public required string RealName { get; init; }
	public required string ControllerInfo { get; init; }
	public required UserRating UserRating { get; init; }
	public required UserRating RequestedRating { get; init; }
	public required string Callsign { get; init; }
	public required VatsimFacilityType FacilityType { get; init; }
	public required int PrimaryFrequency { get; init; }
}
