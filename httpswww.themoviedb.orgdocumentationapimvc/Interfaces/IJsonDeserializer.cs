namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces
{
    public interface IJsonDeserializer
    {
        TmdbEasyModel DeserializeTo<TmdbEasyModel>(string json);
    }
}
