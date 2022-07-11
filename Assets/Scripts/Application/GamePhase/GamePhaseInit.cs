namespace WarSim
{
    public class GamePhaseInit : GamePhase
    {
        public GamePhaseInit() : base(GamePhaseType.Init)
        {
        }

        public override void Init()
        {
            WarSimDebug.Info("GamePhaseInit Init");
        }

        public override void Release()
        {
            WarSimDebug.Info("GamePhaseInit Release");
        }

        public override void Enter()
        {
            WarSimDebug.Info("GamePhaseInit Enter");
        }

        public override void Leave()
        {
            WarSimDebug.Info("GamePhaseInit Leave");
        }
    }
}