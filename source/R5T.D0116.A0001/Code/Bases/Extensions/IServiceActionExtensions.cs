using System;

using R5T.T0062;

using R5T.D0116.I0001;
using R5T.D0116.I001;


namespace R5T.D0116.A0001
{
    public static class IServiceActionExtensions
    {
        public static IUsingDirectivesFormatterAggregation AddUsingDirectivesFormatterActions(this IServiceAction _)
        {
            // Level 01.
            var usingNameAliasDirectiveBlockLabelProviderAction = _.AddUsingNameAliasDirectiveBlockLabelProviderAction();
            var usingNameAliasDirectiveBlockSortOrderProviderAction = _.AddRivetUsingNameAliasDirectiveBlockSortOrderProviderAction();
            var usingNameAliasDirectiveComparerProviderAction = _.AddAlphabeticalUsingNameAliasDirectiveComparerProviderAction();
            var usingNamespaceDirectiveBlockLabelProviderAction = _.AddUsingNamespaceDirectiveBlockLabelProviderAction();
            var usingNamespaceDirectiveBlockSortOrderProviderAction = _.AddRivetUsingNamespaceDirectiveBlockSortOrderProviderAction();
            var usingNamespaceDirectiveComparerProviderAction = _.AddAlphabeticalUsingNamespaceDirectiveComparerProviderAction();

            // Level 02.
            var usingDirectivesFormatterAction = _.AddUsingDirectivesFormatterAction(
                usingNameAliasDirectiveBlockLabelProviderAction,
                usingNameAliasDirectiveBlockSortOrderProviderAction,
                usingNameAliasDirectiveComparerProviderAction,
                usingNamespaceDirectiveBlockLabelProviderAction,
                usingNamespaceDirectiveBlockSortOrderProviderAction,
                usingNamespaceDirectiveComparerProviderAction);

            var output = new UsingDirectivesFormatterAggregation
            {
                UsingDirectivesFormatterAction = usingDirectivesFormatterAction,
                UsingNameAliasDirectiveBlockLabelProviderAction = usingNameAliasDirectiveBlockLabelProviderAction,
                UsingNameAliasDirectiveBlockSortOrderProviderAction = usingNameAliasDirectiveBlockSortOrderProviderAction,
                UsingNameAliasDirectiveComparerProviderAction = usingNameAliasDirectiveComparerProviderAction,
                UsingNamespaceDirectiveBlockLabelProviderAction = usingNamespaceDirectiveBlockLabelProviderAction,
                UsingNamespaceDirectiveBlockSortOrderProviderAction = usingNamespaceDirectiveBlockSortOrderProviderAction,
                UsingNamespaceDirectiveComparerProviderAction = usingNamespaceDirectiveComparerProviderAction,
            };

            return output;
        }
    }
}
