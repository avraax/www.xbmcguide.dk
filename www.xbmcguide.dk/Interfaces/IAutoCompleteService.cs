using System.Collections.Generic;

namespace www.xbmcguide.dk.Interfaces
{
    public interface IAutoCompleteService
    {
        List<SearchAutoCompleteResult> GetSearchResult(string q);
    }
}