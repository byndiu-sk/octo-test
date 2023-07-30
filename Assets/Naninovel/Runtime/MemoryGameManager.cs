using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


    [InitializeAtRuntime]
    public class MemoryGameManager : IEngineService
    {
        public virtual MemoryGameConfiguration Configuration { get; }

        private GameObject serviceObject;
        private GameObject board;

        public MemoryGameManager(MemoryGameConfiguration config)
        {
            Configuration = config;
        }
        public void DestroyService()
        {
            throw new System.NotImplementedException();

        }

        public UniTask InitializeServiceAsync()
        {
            serviceObject = Engine.CreateObject(nameof(MemoryGameManager));
            Engine.Instantiate(Configuration.board, parent: serviceObject.transform);
            return UniTask.CompletedTask;
        }

        public UniTask PlayGame()
        {
        
            serviceObject.transform.GetChild(0).gameObject.SetActive(true);
           // board.SetActive(true);
            Debug.Log("Game started");
            return UniTask.CompletedTask;
        }

        public void ResetService()
        {

        }
    }
