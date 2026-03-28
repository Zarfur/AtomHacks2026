using UnityEngine;

public static class GameConstants
{
    // Player settings
    public const float PlayerSpeed = 5f;
    public const float JumpForce = 10f;
    public const int MaxHealth = 100;

    // Enemy settings
    public const float EnemySpeed = 3f;
    public const int EnemyDamage = 20;

    // Game settings
    public const int MaxLives = 3;
    public const int PointsPerCoin = 10;

    // Tags and Layers
    public const string PlayerTag = "Player";
    public const string EnemyTag = "Enemy";
    public const string GroundLayer = "Ground";

    // Scenes
    public const string MainMenuScene = "MainMenu";
    public const string GameScene = "Level1";

    // Utility constants
    public static readonly Color PlayerColor = Color.green;
    public static readonly Vector3 SpawnPosition = new Vector3(0f, 1f, 0f);
}