using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppTrapFrontLineCallbackDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString FuncName { get; set; }
        public FoxEntityLink CombatLocator { get; set; }
    }
}
