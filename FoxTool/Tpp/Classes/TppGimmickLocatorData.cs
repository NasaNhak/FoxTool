using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppGimmickLocatorData : Data
    {
        // Static properties
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public FoxEntityHandle Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public FoxInt32 Types { get; set; }
        public FoxFilePtr PartsFile { get; set; }
    }
}
