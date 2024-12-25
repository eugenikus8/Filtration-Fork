using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class WaystoneTierBlockItem : NumericFilterPredicateBlockItem
    {
        public WaystoneTierBlockItem()
        {
        }

        public WaystoneTierBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand)
            : base(predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "WaystoneTier";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "WaystoneTier(POE2)";
        public override string SummaryText => "Waystone Tier " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.DarkSlateGray;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.WaystoneTier;
        public override int Minimum => 1;
        public override int Maximum => 16;
    }
}
