using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Naninovel.Commands
{
    [CommandAlias("memoryGame")]
    public class MemoryGame : Command
    {
        public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            var gameManager = Engine.GetService<MemoryGameManager>();
            gameManager.PlayGame();
            
            return UniTask.CompletedTask;
        }
    }
}