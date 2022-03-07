using System;


namespace R5T.D0116.A0001
{
    public static class IUsingDirectivesFormatterAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IUsingDirectivesFormatterAggregationIncrement other)
            where T : IUsingDirectivesFormatterAggregationIncrement
        {
            aggregation.UsingNameAliasDirectiveBlockLabelProviderAction = other.UsingNameAliasDirectiveBlockLabelProviderAction;
            aggregation.UsingNameAliasDirectiveBlockSortOrderProviderAction = other.UsingNameAliasDirectiveBlockSortOrderProviderAction;
            aggregation.UsingNameAliasDirectiveComparerProviderAction = other.UsingNameAliasDirectiveComparerProviderAction;
            aggregation.UsingNamespaceDirectiveBlockLabelProviderAction = other.UsingNamespaceDirectiveBlockLabelProviderAction;
            aggregation.UsingNamespaceDirectiveBlockSortOrderProviderAction = other.UsingNamespaceDirectiveBlockSortOrderProviderAction;
            aggregation.UsingNamespaceDirectiveComparerProviderAction = other.UsingNamespaceDirectiveComparerProviderAction;

            return aggregation;
        }
    }
}
