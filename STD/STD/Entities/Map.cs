

using Otter;
namespace STD.Entities
{
    public class Map : Entity
    {
        public Tilemap Tilemap;

        public Map()
        {
            Layer = (int)Global.LayerPriority.Map;
            Tilemap = new Tilemap(Resources.Sprites.TILE_IMG, Global.WIDTH, Global.HEIGHT, 32, 32);
            Tilemap.CenterOrigin();
            AddGraphic(Tilemap);
            //Graphic.CenterOrigin();
            Tilemap.SetTile(0, 0, 0);
            Tilemap.SetTile(1, 0, 0);
            Tilemap.SetTile(2, 0, 0);
            Tilemap.SetTile(0, 4, 1);
            Tilemap.SetTile(2, 12, 3);
        }
    }
}
