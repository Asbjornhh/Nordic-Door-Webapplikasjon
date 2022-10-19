﻿using bacit_dotnet.MVC.Entities;

namespace bacit_dotnet.MVC.Repositories
{
    public interface ISuggestionRepository
    {
        void AddSuggestion(SuggestionEntity user);
        List<SuggestionEntity> GetSuggestions();
        void Delete(string email);
    }
}