using System;


namespace R5T.D0116.A0001
{
    public static class IUsingDirectivesFormatterAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IUsingDirectivesFormatterAggregation other)
            where T : IUsingDirectivesFormatterAggregation
        {
            (aggregation as IUsingDirectivesFormatterAggregationIncrement).FillFrom(other);

            return aggregation;
        }
    }
}
