using System;

using R5T.T0063;


namespace R5T.D0116.A0001
{
    public class UsingDirectivesFormatterAggregation : IUsingDirectivesFormatterAggregation
    {
        public IServiceAction<IUsingDirectivesFormatter> UsingDirectivesFormatterAction { get; set; }
        public IServiceAction<IUsingNameAliasDirectiveBlockLabelProvider> UsingNameAliasDirectiveBlockLabelProviderAction { get; set; }
        public IServiceAction<IUsingNameAliasDirectiveBlockSortOrderProvider> UsingNameAliasDirectiveBlockSortOrderProviderAction { get; set; }
        public IServiceAction<IUsingNameAliasDirectiveComparerProvider> UsingNameAliasDirectiveComparerProviderAction { get; set; }
        public IServiceAction<IUsingNamespaceDirectiveBlockLabelProvider> UsingNamespaceDirectiveBlockLabelProviderAction { get; set; }
        public IServiceAction<IUsingNamespaceDirectiveBlockSortOrderProvider> UsingNamespaceDirectiveBlockSortOrderProviderAction { get; set; }
        public IServiceAction<IUsingNamespaceDirectiveComparerProvider> UsingNamespaceDirectiveComparerProviderAction { get; set; }
    }
}
