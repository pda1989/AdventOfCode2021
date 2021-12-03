namespace AdventOfCode2021.Tasks.Misc
{
    public interface IInputDataParser<T>
    {
        public T Parse(string inputData);
    }
}