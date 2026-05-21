// NOTE: Parts of the code below are based on
// https://www.mooict.com/wpf-c-tutorial-create-a-space-battle-shooter-game-in-visual-studio/7/

using DrawnUi.Gaming;

namespace SpaceShooter.Game;

/// <summary>
/// MAUI-specific partial: declares DrawnGame base class, initializes XAML component.
/// All game logic lives in Shared/Game/SpaceShooter.cs.
/// SpaceShooter.xaml demonstrates the XAML approach to building DrawnUI game UI.
/// </summary>
public partial class SpaceShooter : DrawnGame
{
    public SpaceShooter()
    {
        InitializeComponent();

        BindingContext = this;

        Instance = this;
    }
}
