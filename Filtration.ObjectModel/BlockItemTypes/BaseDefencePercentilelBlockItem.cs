using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class BaseDefencePercentileBlockItem : NumericFilterPredicateBlockItem
    {
        public BaseDefencePercentileBlockItem()
        {
        }

        public BaseDefencePercentileBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "BaseDefencePercentile";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "BaseDefencePercentile";
        public override string SummaryText => "Base DP " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.Gray;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.BaseDefencePercentile;
        public override int Minimum => 0;
        public override int Maximum => 100;
    }
}
