namespace PKHeXUtilForms.Pokemon.NameParser.Internal
{
    internal static class NameParserEditorEntryExtensions
    {
        internal static bool IsValid(this NameParserEditorEntry entry)
        {
            if (string.IsNullOrEmpty(entry.PokemonName)
                || string.IsNullOrEmpty(entry.FormWord)
                || string.IsNullOrEmpty(entry.DexIndex)
                || string.IsNullOrEmpty(entry.FormIndex))
            {
                return false;
            }
            int dexIndex, formIndex;
            if (!int.TryParse(entry.DexIndex, out dexIndex))
            {
                return false;
            }
            if (!int.TryParse(entry.FormIndex, out formIndex))
            {
                return false;
            }
            return true;
        }
    }
}
