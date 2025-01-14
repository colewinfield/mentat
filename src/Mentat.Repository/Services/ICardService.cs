﻿using Mentat.Repository.Models;

namespace Mentat.Repository.Services
{
    public interface ICardService
    {
        List<Card> GetCards();

        Card GetCard(string id);
        
        void RemoveCard(string id);

        void SaveCard(string id, Card card);
    }
}
