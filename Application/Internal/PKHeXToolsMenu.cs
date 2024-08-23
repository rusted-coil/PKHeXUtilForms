using FormRx.Button;

namespace PKHeXUtilForms.Application.Internal
{
    internal sealed class PKHeXToolsMenu : IPKHeXToolsMenu
    {
        public required IButton OpenNameParserEditorButton { get; init; }
    }
}
