using AdventOfCode2021.Tasks.Misc;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode2021.Tasks.Tasks
{
    public abstract class TaskBase<TResult>
    {
        public static IEnumerable<TInput> GetInputData<TInput>(string resourceName)
        {
            IInputDataParser<IEnumerable<TInput>> parser = ParserFactory<TInput>.Create();

            return parser.Parse(ReadFile(resourceName));
        }

        public abstract TResult Excercise1();

        public abstract TResult Excercise2();

        private static string ReadFile(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            using Stream stream = assembly.GetManifestResourceStream($"AdventOfCode2021.Tasks.Files.{resourceName}.txt");
            using StreamReader reader = new(stream);

            return reader.ReadToEnd();
        }
    }
}