﻿namespace Ruyi.SDK.Online
{
    internal abstract class TrueSkillFactorGraphLayer<TPlayer, TInputVariable, TFactor, TOutputVariable>
        : FactorGraphLayer<TrueSkillFactorGraph<TPlayer>, GaussianDistribution, Variable<GaussianDistribution>, TInputVariable, TFactor, TOutputVariable>
        where TInputVariable : Variable<GaussianDistribution>
        where TFactor : Factor<GaussianDistribution>
        where TOutputVariable : Variable<GaussianDistribution>
    {
        public TrueSkillFactorGraphLayer(TrueSkillFactorGraph<TPlayer> parentGraph)
            : base(parentGraph)
        {
        }
    }
}
