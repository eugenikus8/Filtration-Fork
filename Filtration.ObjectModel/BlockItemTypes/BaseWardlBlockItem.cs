using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class BaseWardBlockItem : NumericFilterPredicateBlockItem
    {
        public BaseWardBlockItem()
        {
        }

        public BaseWardBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "BaseWard";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "BaseWard";
        public override string SummaryText => "Base Ward " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.BlueViolet;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.BaseWard;
        public override int Minimum => 0;
        public override int Maximum => 9999;
    }
}
