using Fel59GameLauncher;
using Fel59GameLauncher.Rendering;
using Fel59GameLauncher.Ui;
using MEngine.Core.EngineCoreSystems;
using Microsoft.Xna.Framework;

Console.WriteLine("hello world");

GameInstance instance = new GameInstance();
instance.tags.Add("launcher");
instance.name = "launcher0";
instance.modules.loadModule<UiModule>();
instance.modules.loadModule<MouseInputModule>();
instance.modules.loadModule<RenderingModule>();
Thread.Sleep(1000);
instance.modules.loadModule<GameLauncherModule>();

instance.StartInstanceOnThread(out Thread thread);