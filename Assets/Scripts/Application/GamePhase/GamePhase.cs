namespace WarSim
{
    public abstract class GamePhase
    {
        protected GamePhase(GamePhaseType gpt)
        {
            GamePhaseType = gpt;
        }
        
        public abstract void Init();
        public abstract void Release();
        public abstract void Enter();
        public abstract void Leave();


        public GamePhaseType GamePhaseType;
    }
}