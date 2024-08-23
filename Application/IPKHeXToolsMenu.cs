using FormRx.Button;

namespace PKHeXUtilForms.Application
{
    public interface IPKHeXToolsMenu
    {
        /// <summary>
        /// NameParserEditorを開くボタンを取得します。
        /// </summary>
        IButton OpenNameParserEditorButton { get; }
    }
}
