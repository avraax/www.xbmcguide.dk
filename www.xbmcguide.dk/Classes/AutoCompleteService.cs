using System;
using System.Collections.Generic;
using System.Linq;
using www.xbmcguide.dk.Interfaces;

namespace www.xbmcguide.dk.Areas.AutoComplete.Classes
{
    public class AutoCompleteService : IAutoCompleteService
    {
        private readonly XbmcGuideDataContext _xbmcDatabase;

        public AutoCompleteService()
        {
            _xbmcDatabase = new XbmcGuideDataContext();
        }

        public List<SearchAutoCompleteResult> GetSearchResult(string q)
        {
            return _xbmcDatabase.SearchAutoComplete(q).ToList();
        }
    }
}