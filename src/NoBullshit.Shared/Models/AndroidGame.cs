using static NoBullshit.Shared.Models.Game.GamePlatform;

namespace NoBullshit.Shared.Models;

public class AndroidGame : Game
{
    public override GamePlatform Platform => Android;
}
