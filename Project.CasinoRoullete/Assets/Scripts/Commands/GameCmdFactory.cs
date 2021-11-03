using System.Collections;
using System.Collections.Generic;
using Components;
using Infrastructure;
using Managers;
using UnityEngine;
using ViewModel;

namespace Commands
{    
    [CreateAssetMenu(fileName = "New GameCmdFactory", menuName = "Factory/Game Command Factory")]
    public class GameCmdFactory : ScriptableObject
    {   
        // Game roullete        
        public ButtonTurnCmd ButtonTableTurn(GameObject chipInstance, GameObject chipsContainer, CharacterTable characterTable, ButtonTable buttonData)
        {
            return new ButtonTurnCmd(chipInstance, chipsContainer, characterTable, buttonData);
        }    
        public ChipSelectTurnCmd ChipSelect(CharacterTable characterTable, Chip arrayValue)
        {
            return new ChipSelectTurnCmd(characterTable, arrayValue);
        }      
        public PlayTurnCmd PlayTurn(CharacterTable characterTable, GameRoullete gameRoullete)
        {
            return new PlayTurnCmd(GameManager.Instance, characterTable, gameRoullete, new PlayRoundGateway());
        }

        public RewardTurnCmd RewardTurn()
        {
            return new RewardTurnCmd();
        }      
        public MusicTurnCmd MusicTurnCmd(GameSound gameSound, bool isOn, float value = 0)
        {
            return new MusicTurnCmd(gameSound, isOn, value);
        }    

        public ResetTurnCmd ResetTableTurn(MagnetDestroyerDisplay magnetDestroyerDisplay, CharacterTable characterTable, int delayTime = 0)
        {
            return new ResetTurnCmd(magnetDestroyerDisplay, characterTable, delayTime);
        }      
        public UndoTurnCmd UndoTableTurn()
        {
            return new UndoTurnCmd();
        }      
        public RestoreTurnCmd RestoreTableTurn()
        {
            return new RestoreTurnCmd();
        } 
    }
}
