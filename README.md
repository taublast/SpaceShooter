# Space Shooter Game Etude

_.NET MAUI / Blazor_  simple yet heavily animated arcade cross-platform game runs on Android, Windows, iOS, Mac (Catalyst) and in Browser (WebAssembly), all from a single code base.  
Desktop and browser versions also support both mouse and keyboard along with touch.

* [Try in browser](https://taublast.github.io/SpaceShooter) 

https://github.com/taublast/AppoMobi.Maui.DrawnUi.SpaceShooter/assets/25801194/30523e94-12d5-4740-8af3-bebf11ef317f

Built with [DrawnUI for .NET](https://github.com/taublast/DrawnUi)

Don't miss another Blazor/MAUI game with AUDIO and more perks [Bricks Breaker](https://github.com/taublast/DrawnUi.Breakout) !

## _Implementation_

Driven by [one](https://github.com/mooict/WPF-Space-shooter-game) of the awesome [ICT MOO tutorials](https://www.youtube.com/@mooict/videos), much content to play with, knowing we can do it all with .NET MAUI.  

Free [Lottie animations](https://lottiefiles.com/) quickly fulfilled the need for animated content.

[DrawnUI](https://github.com/taublast/DrawnUi.Maui) was used to draw virtual controls on a Skia canvas.

## _Recap_

* Repo updated with latest DrawnUI nuget providing fluid game timing
* Android is hardware-accelerated with GL
* iOS and Mac Catalyst are hardware-accelerated with Apple Metal
* Windows is using hardware acceleration with Angle.

Desktop versions present non-resizable windows, capturing keyboard input.  

[Lottie animations](https://lottiefiles.com/) have proven themselves to be very useful to quickly implement animations.

Attained result and FPS are fine.  

With an optimized design, especially in regards to control caching, we could imagine more games and fancy animations built with [#dotnetmaui](https://twitter.com/search?q=%23dotnetmaui).  

## _Licencing_

This code and the DrawnUI nuget are provided under the [MIT license](https://github.com/taublast/AppoMobi.Maui.DrawnUi.SpaceShooter?tab=MIT-1-ov-file#readme). ICT MOO space ships sprites come under the [Apache 2.0 license](https://github.com/mooict/WPF-Space-shooter-game?tab=Apache-2.0-1-ov-file#readme).
