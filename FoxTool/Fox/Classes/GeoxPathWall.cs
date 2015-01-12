using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GeoxPathWall
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public List<FoxEntityHandle> Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public FoxFloat Height { get; set; }
        public FoxBool IsVisibleGeom { get; set; }
        public FoxInt32 FaceFlag { get; set; }
        public List<FoxString> CollisionAttributeTags { get; set; }
    }
}
