using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;
using Filtration.ObjectModel.Extensions;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class GemQualityTypeBlockItem : NumericFilterPredicateBlockItem
    {
        public GemQualityTypeBlockItem()
        {
        }

        public GemQualityTypeBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand)
    : base(predicateOperator, predicateOperand)
        {
        }

        public GemQualityTypeBlockItem(FilterPredicateOperator predicateOperator, GemQualityType predicateOperand)
    : base(predicateOperator, (int)predicateOperand)
        {
        }

        public override string PrefixText => "GemQualityType";
        public override string OutputText => PrefixText + " " + ((GemQualityType) FilterPredicate.PredicateOperand).GetAttributeDescription();
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "GemQualityType";
        public override string SummaryText => "Gem Quality Type" + ": " +
                                              ((GemQualityType) FilterPredicate.PredicateOperand).GetAttributeDescription();
        public override Color SummaryBackgroundColor => Colors.PaleGreen;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.GemQualityType;
        public override int Minimum => 0;
        public override int Maximum => (int)GemQualityType.Phantasmal;
    }
}
