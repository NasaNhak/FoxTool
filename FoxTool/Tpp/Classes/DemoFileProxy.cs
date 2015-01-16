using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class DemoFileProxy
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr FmdlFiles { get; set; }
        public FoxFilePtr PartsFiles { get; set; }
    }
}