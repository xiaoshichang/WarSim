using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WarSim
{
    public class Application : MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(gameObject);
            ApplicationGlobals.CurrentApplication = this;
            
            _InitAllManagers();
            _StartNextGamePhase();
        }

        void Update()
        {
            var dt = Time.deltaTime;
            _GamePhaseManager.Tick(dt);
            
        }

        private void OnDestroy()
        {
            _ReleaseAllManagers();
            ApplicationGlobals.CurrentApplication = null;
        }

        private void _InitAllManagers()
        {
            _GamePhaseManager.Init();
        }
        

        private void _ReleaseAllManagers()
        {
            _GamePhaseManager.Release();
        }
        
        private void _StartNextGamePhase()
        {
            _GamePhaseManager.EnterGamePhaseAssetLoad();
        }

        private readonly GamePhaseManager _GamePhaseManager = new();

    }
}
