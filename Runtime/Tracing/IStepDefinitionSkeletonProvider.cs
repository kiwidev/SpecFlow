﻿using TechTalk.SpecFlow.Bindings;

namespace TechTalk.SpecFlow.Tracing
{
    public interface IStepDefinitionSkeletonProvider
    {
        string GetStepDefinitionSkeleton(StepArgs stepArgs);
        string GetBindingClassSkeleton(string stepDefinitions);
    }
}