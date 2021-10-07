using UnityEngine;

namespace Environment
{
    public class GenerateMapTiles : MonoBehaviour
    {
        public GameObject[] tiles;
        private Vector2 _tilePlacement;
        
        public int total;
        public int lineBreakNum;

        private void Start()
        {
            var linebreak = lineBreakNum;
            for (int i = 0; i < total; i++)
            {
                var chosen = Random.Range(0, tiles.Length);
                var tile = Instantiate(tiles[chosen]);
                tile.transform.position = new Vector3(_tilePlacement.x, 0, _tilePlacement.y);
                _tilePlacement.x += 30;
                
                if (i == linebreak -1)
                {
                    _tilePlacement.x = 0;
                    _tilePlacement.y += 30;
                    linebreak += lineBreakNum;
                }
            }
        }
    }
}
