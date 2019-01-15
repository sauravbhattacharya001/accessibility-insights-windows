// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Globalization;
using AccessibilityInsights.Core.Bases;
using AccessibilityInsights.Core.Enums;
using AccessibilityInsights.Rules.PropertyConditions;
using AccessibilityInsights.Rules.Resources;
using static AccessibilityInsights.Rules.PropertyConditions.ControlType;

namespace AccessibilityInsights.Rules.Library
{
    [RuleInfo(ID = RuleId.ControlViewCheckBoxStructure)]
    class ControlViewCheckBoxStructure: Rule
    {
        public ControlViewCheckBoxStructure()
        {
            this.Info.Description = string.Format(CultureInfo.InvariantCulture, Descriptions.Structure, ControlView.CheckBoxStructure);
            this.Info.Standard = A11yCriteriaId.InfoAndRelationships;
        }

        public override EvaluationCode Evaluate(IA11yElement e)
        {
            if (e == null) throw new ArgumentException(nameof(e));

            return ControlView.CheckBoxStructure.Matches(e) ? EvaluationCode.Pass : EvaluationCode.Note;
        }

        protected override Condition CreateCondition()
        {
            return CheckBox;
        }
    } // class
} // namespace
