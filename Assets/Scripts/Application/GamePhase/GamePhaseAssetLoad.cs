namespace WarSim
{
    public class GamePhaseAssetLoad : GamePhase
    {
        public GamePhaseAssetLoad() : base(GamePhaseType.AssetLoad)
        {
        }

        public override void Init()
        {
            WarSimDebug.Info("GamePhaseAssetLoad Init");
        }

        public override void Release()
        {
            WarSimDebug.Info("GamePhaseAssetLoad Release");
        }

        public override void Enter()
        {
            WarSimDebug.Info("GamePhaseAssetLoad Enter");
        }

        public override void Leave()
        {
            WarSimDebug.Info("GamePhaseAssetLoad Leave");
        }
    }
}