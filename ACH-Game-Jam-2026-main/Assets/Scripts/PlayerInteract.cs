using TarodevController;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    PlayerController _playerController;
    private ScriptableStats _playerStats;
    private float _originalJumpPower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerController = GetComponent<PlayerController>();
        _playerStats = _playerController.GetStats();
        
        GetOriginalStats();
    }

    void GetOriginalStats()
    {
        _originalJumpPower = _playerStats.JumpPower;
    }

    public void AddJumpPower(float jumpPower)
    {
        _playerStats.JumpPower += jumpPower;
    }
    
    public void ResetStats()
    {
        _playerStats.JumpPower = _originalJumpPower;
    }
}
