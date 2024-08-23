using FormRx.Button;

namespace PKHeXUtilForms.Application
{
    public static class PKHeXToolsMenuFactory
    {
        public static IPKHeXToolsMenu Create(
            IButton openNameParserEditorButton)
        {
            return new Internal.PKHeXToolsMenu { 
                OpenNameParserEditorButton = openNameParserEditorButton,
            };
        }
    }
}
