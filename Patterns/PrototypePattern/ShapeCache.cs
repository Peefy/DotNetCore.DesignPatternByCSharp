using System.Collections.Generic;

using VsCodeProOne.Patterns.FactoryPattern;

namespace VsCodeProOne.Patterns.PrototypePattern
{
    public class ShapeCache
    {
        private static Dictionary<string,IShape> _shapeMap
            = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeId)
        {
            if(_shapeMap.TryGetValue(shapeId,out var shape) == true)
                return shape;
            return null;
        }

        public static void LoadCache()
        {
            _shapeMap.Add(nameof(Circle),new Circle());
            _shapeMap.Add(nameof(Rectangle),new Rectangle());
            _shapeMap.Add(nameof(Square),new Square());
        }

    }

}
