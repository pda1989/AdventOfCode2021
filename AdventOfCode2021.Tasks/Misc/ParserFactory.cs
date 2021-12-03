using System.Collections.Generic;

namespace AdventOfCode2021.Tasks.Misc
{
    public class ParserFactory<TInput>
    {
        public static IInputDataParser<IEnumerable<TInput>> Create()
        {
            return typeof(TInput) switch
            {
                _ => new CollectionParser<TInput>()
            };
        }
    }
}