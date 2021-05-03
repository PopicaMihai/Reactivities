namespace Application.Core
{
    public class Result<T>
    {
        public bool isSucces { get; set; }
        public T Value { get; set; }
        public string Error { get; set; }
        
        public static Result<T> Succes(T value) => new Result<T> {isSucces = true, Value = value};
        public static Result<T> Failure(string error) => new Result<T> {isSucces = false, Error = error};
    }
}