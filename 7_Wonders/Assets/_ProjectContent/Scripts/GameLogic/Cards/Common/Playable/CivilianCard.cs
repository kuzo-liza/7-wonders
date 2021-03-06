﻿using WhiteTeam.GameLogic.Cards.Effects;
using WhiteTeam.GameLogic.Resources;

namespace WhiteTeam.GameLogic.Cards
{
    public class CivilianCard : SpecialCard<VictoryEffect>
    {
        public CivilianCard(string id, string name, CardType type, int epoch, Resource.CurrencyItem[] costInfo,
            string requirementBuildCardId, VictoryEffect currentEffect) : base(id, name, type, epoch, costInfo,
            requirementBuildCardId, currentEffect)
        {
        }
    }
}