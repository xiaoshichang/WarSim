
namespace WarSim
{
    
    /// <summary>
    /// GamePhase管理器。
    /// GamePhase 的概念一般用来描述游戏的进程状态，通常伴随大量资源加卸载、游戏模式改变、主界面改变等等。
    /// </summary>
    public class GamePhaseManager : IManager, ITickable
    {
        public void Init()
        {
            WarSimDebug.Assert(_CurrentGamePhase == null, "_CurrentGamePhase is not null!");
            
            WarSimDebug.Info("GamePhaseManager Init");
            _GamePhaseInit.Init();
            _GamePhaseAssetLoad.Init();

            _EnterGamePhaseInit();
        }

        public void Release()
        {
            _GamePhaseAssetLoad.Release();
            _GamePhaseInit.Release();
            WarSimDebug.Info("GamePhaseManager Release");
        }

        public void Tick(float dt)
        {
        }

        private void _EnterGamePhaseInit()
        {
            _CurrentGamePhase = _GamePhaseInit;
            _CurrentGamePhase.Enter();
        }

        public void EnterGamePhaseAssetLoad()
        {
            _CurrentGamePhase.Leave();
            _CurrentGamePhase = _GamePhaseAssetLoad;
            _CurrentGamePhase.Enter();
        }
        

        private readonly GamePhaseInit _GamePhaseInit = new();
        private readonly GamePhaseAssetLoad _GamePhaseAssetLoad = new();

        private GamePhase _CurrentGamePhase;


    }
}