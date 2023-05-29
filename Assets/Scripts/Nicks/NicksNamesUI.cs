using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Random = System.Random;

public class NicksNamesUI : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private TextMeshProUGUI _nicknamesText;

    private string _wordName = "";
    
    private Dictionary<GameObject, TextMeshProUGUI> _nicknamesDictionary = new Dictionary<GameObject, TextMeshProUGUI>();
    private readonly string[] _words =
    {
        "Tom",
        "Tommy",
        "Tim",
        "Mofi",
        "Ro",
        "Ko",
        "To",
        "Omi",
        "Nayuta",
        "Lor",
        "Art",
        "T",
        "Dim",
        "Seyu",
        "Teeg"
    };
    
    public void AddPlayer()
    {
        
        GameObject player = Instantiate(_playerPrefab);
        var randomNames = RandomNames();
        player.name = randomNames;
        
        _nicknamesDictionary.Add(player, _nicknamesText);
        
        _nicknamesText.text = randomNames;
    }

    public void RemovePlayer(GameObject player)
    {
        _nicknamesDictionary.Remove(player, out _nicknamesText);
    }
    
    private string RandomNames()
    {
        foreach (var t in _words)
        {
            var randomIndex = UnityEngine.Random.Range(0,_words.Length);
            _wordName = _words[randomIndex];
        }
        return _wordName;
    }
}

