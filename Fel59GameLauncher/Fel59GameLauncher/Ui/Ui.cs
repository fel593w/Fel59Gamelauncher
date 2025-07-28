using MEngine.Core.EngineCoreSystems;
using MEngine.Core.ModuleSystems.EventBusSystems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Fel59GameLauncher.Ui
{
    public static class Ui
    {
        public static List<UiElement> Elements = new List<UiElement>();

        public static void Update()
        {
            UiElement[] tempElements = Elements.ToArray();
            foreach (UiElement element in tempElements)
            {
                if (element.active)
                    element.UpdateFunc();
            }
        }

        public static void Draw(SpriteBatch batch)
        {
            foreach (UiElement element in Elements)
            {
                if (element.active)
                    element.DrawFunc(batch);
            }
        }
    }

    public class UiElement
    {
        public Vector2 position;
        public Vector2 Size;
        public bool active = true;

        public List<UiElement> Elements = new List<UiElement>();

        public virtual void Draw(SpriteBatch batch)
        {

        }

        public virtual void Update()
        {

        }

        public void DrawFunc(SpriteBatch batch)
        {
            Draw(batch);
            foreach (UiElement element in Elements)
            {
                if (element.active)
                    element.DrawFunc(batch);
            }
        }

        public void UpdateFunc()
        {
            Update();
            foreach (UiElement element in Elements)
            {
                if (element.active)
                    element.UpdateFunc();
            }
        }

    }

    public class InteractebleElement : UiElement
    {
        private string Event;

        public void setEvent(string Event)
        {
            this.Event = Event;
        }

        public void runEvent()
        {
            GameInstance.EventBus.Publish(Event, new object());
        }
    }

    public class ButtonElement : InteractebleElement
    {
        public Color color = Color.White;
        public string DefaultButton = "FNATexture";
        public string PressedButton = "FNATexture";
        public bool pressed;
        public bool IsCenterdOrigin = true;

        public override void Update()
        {
            bool tempPressed = false;
            base.Update();
            Vector2 mousePosition = new Vector2(MouseInput.mouse.X, MouseInput.mouse.Y);
            if (mousePosition.X > position.X - Size.X * 0.5 && mousePosition.X < position.X + Size.X * 0.5 &&
              mousePosition.Y > position.Y - Size.Y * 0.5 && mousePosition.Y < position.Y + Size.Y * 0.5)
            {
                if (MouseInput.mousePrev.LeftButton == ButtonState.Pressed)
                {

                    tempPressed = true;

                    if (MouseInput.mouse.LeftButton == ButtonState.Released)
                    {
                        runEvent();
                    }
                }

            }

            pressed = tempPressed;

        }

        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);

            Vector2 Size = this.Size == Vector2.Zero ? new Vector2(TextureManeger.getTexture(pressed ? PressedButton : DefaultButton).Width, TextureManeger.getTexture(pressed ? PressedButton : DefaultButton).Height) : this.Size;
            batch.Draw(TextureManeger.getTexture(pressed ? PressedButton : DefaultButton), new Rectangle((int)(position.X - (IsCenterdOrigin ? Size.X * 0.5f : 0)), (int)(position.Y - (IsCenterdOrigin ? Size.Y * 0.5f : 0)), (int)Size.X, (int)Size.Y), new Rectangle(0, 0, TextureManeger.getTexture(pressed ? PressedButton : DefaultButton).Width, TextureManeger.getTexture(pressed ? PressedButton : DefaultButton).Height), color);
        }
    }

    public class ImageElement : UiElement
    {
        public string Image = "FNATexture";
        public Color color = Color.White;
        public bool IsCenterdOrigin = true;

        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);

            Vector2 Size = this.Size == Vector2.Zero ? new Vector2(TextureManeger.getTexture(Image).Width, TextureManeger.getTexture(Image).Height) : this.Size;
            batch.Draw(TextureManeger.getTexture(Image), new Rectangle((int)(position.X - (IsCenterdOrigin ? Size.X * 0.5f : 0)), (int)(position.Y - (IsCenterdOrigin ? Size.Y * 0.5f : 0)), (int)Size.X, (int)Size.Y), new Rectangle(0, 0, TextureManeger.getTexture(Image).Width, TextureManeger.getTexture(Image).Height), color);
        }
    }

    /*public class PopupElement : UiElement
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popupMessage"></param>
        /// <param name="OptionA">get button input with eventbus with the name "popub_button_{name}"</param>
        /// <param name="OptionB">get button input with eventbus with the name "popub_button_{name}"</param>
        public PopupElement(string popupMessage, string OptionA, string OptionB = null)
        {
            position = new Vector2(500, 300);
            Size = new Vector2(500, 400);
            Elements.Add(new ButtonElement());
            if(OptionB == null)
                Elements[0].position = new Vector2(500, 450);
            else
                Elements[0].position = new Vector2(350, 450);
            Elements[0].Size = new Vector2(150, 50);
            (Elements[0] as ButtonElement).PressedButton = "BlankButtonPressed";
            (Elements[0] as ButtonElement).DefaultButton = "BlankButtonDefault";
            (Elements[0] as ButtonElement).setEvent(data => { EventBus.Instance.Publish("popup_button_"+OptionA, null); active = false; });
            if (OptionB != null)
            {
                Elements.Add(new ButtonElement());
                Elements[1].position = new Vector2(650, 450);
                Elements[1].Size = new Vector2(150, 50);
                (Elements[1] as ButtonElement).PressedButton = "BlankButtonPressed";
                (Elements[1] as ButtonElement).DefaultButton = "BlankButtonDefault";
                (Elements[1] as ButtonElement).setEvent(data => { EventBus.Instance.Publish("popup_button_" + OptionA, null); active = false; });
            }

        }

        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
            batch.Draw(TextureManeger.Textures["BlankButtonDefault"], new Rectangle((int)(position.X - (Size.X * 0.5f)), (int)(position.Y - (Size.Y * 0.5f)), (int)Size.X, (int)Size.Y), new Rectangle(0, 0, TextureManeger.Textures["BlankButtonDefault"].Width, TextureManeger.Textures["BlankButtonDefault"].Height), Color.Black);
        }
    }*/
}
