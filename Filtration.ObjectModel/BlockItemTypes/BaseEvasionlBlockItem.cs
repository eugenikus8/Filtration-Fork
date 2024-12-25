using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class BaseEvasionBlockItem : NumericFilterPredicateBlockItem
    {
        public BaseEvasionBlockItem()
        {
        }

        public BaseEvasionBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "BaseEvasion";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "BaseEvasion";
        public override string SummaryText => "Base EV " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.DarkOliveGreen;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.BaseEvasion;
        public override int Minimum => 0;
        public override int Maximum => 9999;
    }
}
