using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEngine.Core.EngineCoreSystems;
using MEngine.Core.ModuleSystems;
using Microsoft.Xna.Framework.Graphics;

namespace Fel59GameLauncher.Ui
{
    public class UiModule : Module
    {
        public override void Initialize()
        {
            base.Initialize();
            GameInstance.EventBus.SubscribeEvent("Draw", Data => Ui.Draw(Data as SpriteBatch));
        }

        public override void Tick()
        {
            base.Tick();
            Ui.Update();
        }
    }
}
