using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class HasSearingExarchImplicitBlockItem : NumericFilterPredicateBlockItem
    {
        public HasSearingExarchImplicitBlockItem()
        {
        }

        public HasSearingExarchImplicitBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "HasSearingExarchImplicit";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "SearingExarchImplicit";
        public override string SummaryText => "SearingExarchImplicit " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.MidnightBlue;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.HasSearingExarchImplicit;
        public override int Minimum => 1;
        public override int Maximum => 6;
    }
}
