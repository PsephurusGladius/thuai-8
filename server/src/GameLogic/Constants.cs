namespace Thuai.Server.GameLogic;

/// <summary>
/// Constants used in the game.
/// </summary>
public static class Constants
{
    //Armor
    public const int INITIAL_ARMOR_VALUE = 0;
    public const int ARMOR_VALUE_INCREASE = 1;
    public const int INITIAL_HEALTH_VALUE = 1;
    public const int INITIAL_DODGE_PERCENTAGE = 0;          // 0%
    public const int DODGE_PERCENTAGE_INCREASE = 10;        // 10%

    //Weapon
    public const double INITIAL_ATTACK_SPEED = 0.1;
    public const double ATTACK_SPEED_INCREASE = 0.025;
    public const double INITIAL_BULLET_SPEED = 3;
    public const double BULLET_SPEED_INCREASE = 0.5;
    public const int INITIAL_DAMAGE = 1;
    public const int DAMAGE_INCREASE = 1;
    public const int INITIAL_BULLETS = 10;
    public const int BULLETS_INCREASE = 1;

    //Skill
    public const int SKILL_MAX_COOLDOWN = 200;

    //Player
    public const double MOVE_SPEED = 2;
    public const double TURN_SPEED = Math.PI / 18;
    public const double PLAYER_RADIO = 0.1;

    //Map
    public const int WALL_LENGTH = 10;
    public const double WALL_THICK = 0.1;
}
