using SkiaSharp;

namespace SpaceShooter.Game;

public interface IWithHitBox
{
    /// <summary>
    /// Calculate hitbox etc for the current frame
    /// </summary>
    void UpdateState(long time);

    /// <summary>
    /// Precalculated
    /// </summary>
    SKRect HitBox { get; }
}
