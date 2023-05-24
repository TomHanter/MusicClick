using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
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

    private void Start()
    {
        var randomIndex = UnityEngine.Random.Range(0, _words.Length);
        _wordName = _words[randomIndex];
    }

    public void AddPlayer()
    {
        GameObject player = Instantiate(_playerPrefab);
        player.name = _wordName;

        TextMeshProUGUI nicknamesInstantiate = Instantiate(_nicknamesText,player.transform.position,player.transform.rotation,player.transform);
        nicknamesInstantiate.text = _wordName;
        _nicknamesText.text = _wordName;
        _nicknamesDictionary.Add(player, nicknamesInstantiate);
    }

    public void RemovePlayer(GameObject player)
    {
        if (_nicknamesDictionary.ContainsKey(player))
        {
            _nicknamesDictionary.Remove(player);
        }
    }
}

