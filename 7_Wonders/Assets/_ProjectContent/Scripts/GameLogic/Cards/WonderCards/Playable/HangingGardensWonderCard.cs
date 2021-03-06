﻿using WhiteTeam.GameLogic.Cards.Effects;

namespace WhiteTeam.GameLogic.Cards.Wonder
{
    public class HangingGardensWonderCard : SpecialWonderCard<VictoryEffect, SelectableScienceEffect, VictoryEffect>
        // TODO -- END GAME selectable science
    {
        public HangingGardensWonderCard(string id, string name, StepBuildWithEffect<VictoryEffect> stepBuild1,
            StepBuildWithEffect<SelectableScienceEffect> stepBuild2, StepBuildWithEffect<VictoryEffect> stepBuild3) :
            base(id, name, stepBuild1, stepBuild2, stepBuild3)
        {
        }

        public override void ActivatedUse(PlayerData player)
        {
            base.ActivatedUse(player);
            var bonusBuildEffect = SecondStepBuild;
            if (!bonusBuildEffect.IsCompleted) return;
            bonusBuildEffect.CardEffect.Select(player);
        }
    }
}