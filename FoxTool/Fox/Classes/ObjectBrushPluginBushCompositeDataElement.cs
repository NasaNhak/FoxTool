using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ObjectBrushPluginBushCompositeDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxFilePtr ModelFile { get; set; }
        public FoxVector3 ModelBounding { get; set; }
        public List<FoxEntityPtr> OffsetArray { get; set; }
    }
}
