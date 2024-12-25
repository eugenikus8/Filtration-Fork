using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class ReplicaBlockItem : BooleanBlockItem
    {
        public ReplicaBlockItem()
        {
        }

        public ReplicaBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Replica";
        public override string DisplayHeading => "Replica";
        public override Color SummaryBackgroundColor => Colors.MediumVioletRed;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Replica;
    }
}
