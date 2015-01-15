// Type: Game
// Assembly: Assembly-CSharp, Version=1.0.0.0, Culture=neutral
// MVID: A420B99E-82C2-4667-B0ED-6D612B779462
// Assembly location: C:\KSP_DEV\KSP_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;

public class Game
{
    public const int lastCompatibleMajor = 0;
    public const int lastCompatibleMinor = 21;
    public const int lastCompatibleRev = 0;
    public string Title;
    public string Description;
    public string linkURL;
    public string linkCaption;

    /// <summary>
    /// Contains the current mode of the game. Career, sandbox, etc.
    /// </summary>
    public Game.Modes Mode;

    public Game.GameStatus Status;
    public GameScenes startScene;
    public EditorFacility editorFacility;
    public FlightState flightState;
    public GameParameters Parameters;
    public KerbalRoster CrewRoster;
    public List<ProtoScenarioModule> scenarios;
    public ConfigNode additionalSystems;
    public ConfigNode config;
    public bool compatible;
    public int file_version_major;
    public int file_version_minor;
    public int file_version_revision;
    public string flagURL;
    public uint launchID;
    public extern Game();
    public extern Game(ConfigNode root);
    public extern Game Updated();
    public extern void Save(ConfigNode rootNode);
    public extern void Start();
    public extern void Load();
    public extern bool IsResumable();
    public static extern Game GetCloneOf(Game g);
    public extern ProtoScenarioModule AddProtoScenarioModule(System.Type typeOfScnModule, params GameScenes[] scenes);
    public extern bool RemoveProtoScenarioModule(System.Type typeOfScnModule);
    public extern ProtoVessel AddVessel(ConfigNode protoVesselNode);
    public extern bool DestroyVessel(Vessel v);
    public override extern string ToString();
    public extern double UniversalTime { get; }

    public enum Modes
    {
        SANDBOX,
        CAREER,
        SCENARIO,
        SCENARIO_NON_RESUMABLE,
        SCIENCE_SANDBOX,
    }

    public enum GameStatus
    {
        UNSTARTED,
        ONGOING,
        FAILED_OR_ABORTED,
        COMPLETED,
    }
}