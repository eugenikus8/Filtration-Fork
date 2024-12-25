using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class EnchantmentPassiveNumBlockItem : NumericFilterPredicateBlockItem
    {
        public EnchantmentPassiveNumBlockItem()
        {
        }

        public EnchantmentPassiveNumBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "EnchantmentPassiveNum";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "ClusterJewelsPassive";
        public override string SummaryText => "Cluster Jewels Passive " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.DarkSlateBlue;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.EnchantmentPassiveNum;
        public override int Minimum => 2;
        public override int Maximum => 12;
    }
}
