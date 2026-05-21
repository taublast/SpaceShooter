namespace SpaceShooter.Game;

/// <summary>
/// Reusable model, to avoid GC
/// </summary>
public interface IReusableSprite
{
    bool IsActive { get; set; }

    Guid Uid { get; }

    void ResetAnimationState();

    Task AnimateDisappearing();
}
