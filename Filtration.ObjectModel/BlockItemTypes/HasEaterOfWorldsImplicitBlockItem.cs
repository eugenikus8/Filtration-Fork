using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class HasEaterOfWorldsImplicitBlockItem : NumericFilterPredicateBlockItem
    {
        public HasEaterOfWorldsImplicitBlockItem()
        {
        }

        public HasEaterOfWorldsImplicitBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "HasEaterOfWorldsImplicit";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "EaterOfWorldsImplicit";
        public override string SummaryText => "EaterOfWorldsImplicit " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.IndianRed;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.HasEaterOfWorldsImplicit;
        public override int Minimum => 1;
        public override int Maximum => 6;
    }
}
