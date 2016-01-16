using Otter;

namespace STD.Scenes
{
    public class FirstScene : Scene
    {
        public Image tileImage = new Image(Resources.Img.TILE_IMG);
        public Text titleText = new Text("Super Tower Defense", Resources.Fonts.FONT_MAIN, 60);
        public Text enterText = new Text("Press Enter", Resources.Fonts.FONT_MAIN, 40);
        public Music introSong = new Music(Resources.Music.INTRO_MUSIC, true);

        public FirstScene()
        {
            tileImage.CenterOrigin();
            tileImage.X = Global.GAME.HalfWidth;
            tileImage.Y = 1000;
            AddGraphic(tileImage);

            // Set the text's outline color to the 
            // hex color #7FA8D2 (Otter2d.com Blue)
            titleText.OutlineColor = new Otter.Color("7FA8D2");
            titleText.OutlineThickness = 3; // Set the outline thickness to 3 pixels
            titleText.CenterOrigin();
            titleText.X = Global.GAME.HalfWidth;
            titleText.Y = -1000;
            this.AddGraphic(titleText);


            enterText.OutlineColor = new Otter.Color("7FA8D2");
            enterText.OutlineThickness = 2;
            enterText.CenterOrigin();
            enterText.X = Global.GAME.HalfWidth;
            enterText.Y = 1000;
            this.AddGraphic(enterText);


            Tweener.Tween(titleText, new { Y = 25 }, 100f, 10f).Ease(Ease.BackOut);
            Tweener.Tween(tileImage, new { Y = 250 }, 100f, 10f).Ease(Ease.BackOut);
            Tweener.Tween(enterText, new { Y = 450 }, 100f, 10f).Ease(Ease.BackOut);
            introSong.Play();
        }

        public override void Update()
        {
            base.Update();

            if (Global.PlayerSession.Controller.Button(Key.Return).Pressed)
            {
                introSong.Stop();
                Global.GAME.RemoveScene();
                Global.GAME.AddScene(new FirstScene());
            }
            if (Global.PlayerSession.Controller.Button("Left").Down)
            {
                titleText.X -= 3;
            }
            if (Global.PlayerSession.Controller.Button("Right").Down)
            {
                titleText.X += 3;
            }
        }
    }
}
