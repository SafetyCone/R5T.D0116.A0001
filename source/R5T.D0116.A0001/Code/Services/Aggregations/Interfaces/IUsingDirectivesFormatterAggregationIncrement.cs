using System;

using R5T.T0063;


namespace R5T.D0116.A0001
{
    public interface IUsingDirectivesFormatterAggregationIncrement
    {
        IServiceAction<IUsingDirectivesFormatter> UsingDirectivesFormatterAction { get; set; }
        IServiceAction<IUsingNameAliasDirectiveBlockLabelProvider> UsingNameAliasDirectiveBlockLabelProviderAction { get; set; }
        IServiceAction<IUsingNameAliasDirectiveBlockSortOrderProvider> UsingNameAliasDirectiveBlockSortOrderProviderAction { get; set; }
        IServiceAction<IUsingNameAliasDirectiveComparerProvider> UsingNameAliasDirectiveComparerProviderAction { get; set; }
        IServiceAction<IUsingNamespaceDirectiveBlockLabelProvider> UsingNamespaceDirectiveBlockLabelProviderAction { get; set; }
        IServiceAction<IUsingNamespaceDirectiveBlockSortOrderProvider> UsingNamespaceDirectiveBlockSortOrderProviderAction { get; set; }
        IServiceAction<IUsingNamespaceDirectiveComparerProvider> UsingNamespaceDirectiveComparerProviderAction { get; set; }
    }
}
