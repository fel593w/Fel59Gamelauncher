using Fel59GameLauncher.Ui;
using MEngine.Core.ModuleSystems;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fel59GameLauncher
{
    public class GameLauncherModule : Module
    {
        public override void Initialize()
        {
            base.Initialize();

            InitalizeUi();
        }

        private UiElement Background;
        private UiElement GameInteractionBottom;
        private UiElement GameList;
        private UiElement PopupOverlay;

        private void InitalizeUi()
        {
            Background = new ImageElement();
            Ui.Ui.Elements.Add(Background);
            
            Background.Size = new Vector2(1000, 600);
            Background.position = new Vector2(500, 300);

            GameList = new UiElement();
            Ui.Ui.Elements.Add(GameList);
            
            GameList.Elements.Add(new ImageElement());
            GameList.Elements[0].Size = new Vector2(150, 600);
            GameList.Elements[0].position = new Vector2(75, 300);
            (GameList.Elements[0] as ImageElement).Image = "GameListBackground";


            GameInteractionBottom = new UiElement();
            Ui.Ui.Elements.Add(GameInteractionBottom);

            GameInteractionBottom.Elements.Add(new UiElement());
            GameInteractionBottom.Elements[0].active = false;
            GameInteractionBottom.Elements[0].Elements.Add(new ButtonElement());
            (GameInteractionBottom.Elements[0].Elements[0] as ButtonElement).DefaultButton = "DownloadButton";
            (GameInteractionBottom.Elements[0].Elements[0] as ButtonElement).PressedButton = "DownloadButton";
            (GameInteractionBottom.Elements[0].Elements[0] as ButtonElement).IsCenterdOrigin = false;
            (GameInteractionBottom.Elements[0].Elements[0] as ButtonElement).color = new Color(102, 211, 255);
            (GameInteractionBottom.Elements[0].Elements[0] as ButtonElement).setEvent("download_button_press");
            GameInteractionBottom.Elements[0].Elements[0].position = new Vector2(430, 515);

            GameInteractionBottom.Elements.Add(new UiElement());
            GameInteractionBottom.Elements[1].active = true;
            GameInteractionBottom.Elements[1].Elements.Add(new ButtonElement());
            (GameInteractionBottom.Elements[1].Elements[0] as ButtonElement).DefaultButton = "PlayButton";
            (GameInteractionBottom.Elements[1].Elements[0] as ButtonElement).PressedButton = "PlayButton";
            (GameInteractionBottom.Elements[1].Elements[0] as ButtonElement).IsCenterdOrigin = false;
            (GameInteractionBottom.Elements[1].Elements[0] as ButtonElement).color = new Color(58, 255, 81);
            (GameInteractionBottom.Elements[1].Elements[0] as ButtonElement).setEvent("play_button_press");
            GameInteractionBottom.Elements[1].Elements[0].position = new Vector2(430, 515);

            GameInteractionBottom.Elements.Add(new UiElement());
            GameInteractionBottom.Elements[2].active = false;
            GameInteractionBottom.Elements[2].Elements.Add(new ButtonElement());
            (GameInteractionBottom.Elements[2].Elements[0] as ButtonElement).DefaultButton = "UpdateButton";
            (GameInteractionBottom.Elements[2].Elements[0] as ButtonElement).PressedButton = "UpdateButton";
            (GameInteractionBottom.Elements[2].Elements[0] as ButtonElement).IsCenterdOrigin = false;
            (GameInteractionBottom.Elements[2].Elements[0] as ButtonElement).color = new Color(102, 211, 255);
            (GameInteractionBottom.Elements[2].Elements[0] as ButtonElement).setEvent("download_button_press");
            GameInteractionBottom.Elements[2].Elements[0].position = new Vector2(430, 515);
            GameInteractionBottom.Elements[2].Elements.Add(new ButtonElement());
            (GameInteractionBottom.Elements[2].Elements[1] as ButtonElement).DefaultButton = "SmallPlayButton";
            (GameInteractionBottom.Elements[2].Elements[1] as ButtonElement).PressedButton = "SmallPlayButton";
            (GameInteractionBottom.Elements[2].Elements[1] as ButtonElement).IsCenterdOrigin = false;
            (GameInteractionBottom.Elements[2].Elements[1] as ButtonElement).color = new Color(58, 255, 81);
            (GameInteractionBottom.Elements[2].Elements[1] as ButtonElement).setEvent("play_button_press");
            GameInteractionBottom.Elements[2].Elements[1].position = new Vector2(526, 515);

            GameInteractionBottom.Elements.Add(new UiElement());
            GameInteractionBottom.Elements[3].active = false;
            GameInteractionBottom.Elements[3].Elements.Add(new ButtonElement());
            (GameInteractionBottom.Elements[3].Elements[0] as ButtonElement).DefaultButton = "WaitButton";
            (GameInteractionBottom.Elements[3].Elements[0] as ButtonElement).PressedButton = "WaitButton";
            (GameInteractionBottom.Elements[3].Elements[0] as ButtonElement).IsCenterdOrigin = false;
            (GameInteractionBottom.Elements[3].Elements[0] as ButtonElement).color = new Color(50, 50, 50);
            (GameInteractionBottom.Elements[3].Elements[0] as ButtonElement).setEvent("nil");
            GameInteractionBottom.Elements[3].Elements[0].position = new Vector2(430, 515);

            GameInteractionBottom.Elements.Add(new ButtonElement());
            (GameInteractionBottom.Elements[4] as ButtonElement).DefaultButton = "ItchLinkButton";
            (GameInteractionBottom.Elements[4] as ButtonElement).PressedButton = "ItchLinkButton";
            (GameInteractionBottom.Elements[4] as ButtonElement).IsCenterdOrigin = false;
            (GameInteractionBottom.Elements[4] as ButtonElement).color = new Color(250, 92, 91);
            (GameInteractionBottom.Elements[4] as ButtonElement).setEvent("itch_link");
            GameInteractionBottom.Elements[4].position = new Vector2(600, 516);

            ButtonElement button0 = new ButtonElement();
            button0.setEvent("play_button_press");
            button0.PressedButton = "PlayButtonPressed";
            button0.DefaultButton = "PlayButtonDefault";
            button0.position = new Vector2(550, 550);
            button0.Size = new Vector2(150, 60);
          //  Ui.Ui.Elements.Add(button0);
        }
    }
}
