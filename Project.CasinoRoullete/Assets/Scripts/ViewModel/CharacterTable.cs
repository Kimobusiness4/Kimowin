using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Components;

namespace ViewModel
{
    [CreateAssetMenu(fileName = "New Character Table", menuName = "Scriptable/Character Table")]
    public class CharacterTable : ScriptableObject
    {
        [Header("Parameters")]
        public string tableName;
        public GameObject chipPrefab;
        public CharacterMoney characterMoney;
        
        [Header("Runtime Execution")]
        public int currentTableCounter;
        public Chip currentChipSelected;
        public List<ChipGame> currentTable = new List<ChipGame>();
        public List<int> currentNumbers = new List<int>();
        public IntReactiveProperty lastNumber;
        public List<GameObject> lastTable = new List<GameObject>();

        // Events observables
        public ISubject<ChipGame> OnDestroyChip = new Subject<ChipGame>();
        public ISubject<bool> OnActiveButton = new Subject<bool>();
        public ISubject<bool> OnRoundFinished = new Subject<bool>();
        public ISubject<bool> OnSaveGame = new Subject<bool>();

    }
}
