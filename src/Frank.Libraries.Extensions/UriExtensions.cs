using System;

namespace Frank.Libraries.Extensions
{
    public static class UriExtensions
    {
        public static Uri AddSegment(this Uri uri, string segment)
        {
            return new Uri(uri, segment);
        }
    }
}