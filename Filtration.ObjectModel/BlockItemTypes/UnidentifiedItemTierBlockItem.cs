using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class UnidentifiedItemTierBlockItem : NumericFilterPredicateBlockItem
    {
        public UnidentifiedItemTierBlockItem()
        {
        }

        public UnidentifiedItemTierBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand)
            : base(predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "UnidentifiedItemTier";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "UnidentifiedItemTier(POE2)";
        public override string SummaryText => "Unidentified Item Tier " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.DarkSlateGray;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.UnidentifiedItemTier;
        public override int Minimum => 1;
        public override int Maximum => 16;
    }
}
