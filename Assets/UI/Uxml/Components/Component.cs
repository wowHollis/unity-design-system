using UnityEngine.UIElements;

namespace VFS.Components
{
    [UxmlElement]
    public partial class Component : VisualElement
    {
        [UxmlAttribute]
        public string Varianat { get; set; }
        
        [UxmlAttribute]
        public string Color { get; set; }

        [UxmlAttribute]
        public string Size { get; set; }

        [UxmlAttribute]
        public string Disabled { get; set; }
    }
}