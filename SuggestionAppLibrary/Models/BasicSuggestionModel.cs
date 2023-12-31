﻿namespace SuggestionAppLibrary.Models;

public class BasicSuggestionModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id {  get; set; }
    public string Suggestion { get; set; }

    public BasicSuggestionModel()
    {
        
    }
    public BasicSuggestionModel(SuggestionModel suggestions)
    {
        Id = suggestions.Id;
        Suggestion = suggestions.Suggestion;
    }
}
