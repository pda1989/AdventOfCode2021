using System;
using System.Collections.Generic;

namespace AdventOfCode2021.Tasks.Misc
{
    public class CollectionParser<T> : IInputDataParser<IEnumerable<T>>
    {
        public CollectionParser()
        {
        }

        public IEnumerable<T> Parse(string inputData)
        {
            if (string.IsNullOrWhiteSpace(inputData))
                throw new ArgumentNullException(nameof(inputData));

            var stringValues = inputData.Split('\n');

            var result = new List<T>();
            foreach (var value in stringValues)
            {
                var convertedValue = ConvertValue(value);
                result.Add(convertedValue);
            }

            return result;
        }

        protected virtual T ConvertValue(string value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}