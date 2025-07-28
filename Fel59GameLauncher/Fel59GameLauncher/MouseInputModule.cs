using MEngine.Core.ModuleSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fel59GameLauncher
{
    public class MouseInputModule : Module
    {

        public override void Tick()
        {
            base.Tick();
            MouseInput.Update();
        }
    }
}
