﻿using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class BaseArmourBlockItem : NumericFilterPredicateBlockItem
    {
        public BaseArmourBlockItem()
        {
        }

        public BaseArmourBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "BaseArmour";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "BaseArmour";
        public override string SummaryText => "Base AR " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.PaleVioletRed;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.BaseArmour;
        public override int Minimum => 0;
        public override int Maximum => 9999;
    }
}