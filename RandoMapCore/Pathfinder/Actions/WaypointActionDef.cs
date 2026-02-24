using Newtonsoft.Json;
using RandomizerCore.Logic;

namespace RandoMapCore.Pathfinder.Actions;

public record WaypointActionDef
{
    /// <summary>
    /// The name of the term that corresponds to the starting position. Doesn't strictly have to be a waypoint but it must be state-valued.
    /// </summary>
    [JsonProperty]
    public string Start { get; init; }

    /// <summary>
    /// Must be a transition that is recognised by the Pathfinder's LocalLM.
    /// Most exotic destination transition gates such as Abyss_06_Core[door_dreamReturn] are well-defined in this mod's logic.
    /// </summary>
    [JsonProperty]
    public string Destination { get; init; }

    /// <summary>
    /// The text for the instruction that should be displayed in the top left/top right of the UI.
    /// </summary>
    [JsonProperty]
    public string Text { get; init; }

    // The following are only for API users and not for built-in waypoints

    /// <summary>
    /// The prerequisite for the action to be possible.
    /// Both the logic for reaching the start position and any item requirements from that position should be included.
    /// Propagation of state should also be done.
    /// </summary>
    [JsonProperty]
    public RawLogicDef Logic { get; init; }
}
