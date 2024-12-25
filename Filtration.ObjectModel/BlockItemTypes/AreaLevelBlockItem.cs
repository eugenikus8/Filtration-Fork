using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class AreaLevelBlockItem : NumericFilterPredicateBlockItem
    {
        public AreaLevelBlockItem()
        {
        }

        public AreaLevelBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "AreaLevel";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "AreaLevel";
        public override string SummaryText => "Area Level " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.IndianRed;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.AreaLevel;
        public override int Minimum => 0;
        public override int Maximum => 100;
    }
}
