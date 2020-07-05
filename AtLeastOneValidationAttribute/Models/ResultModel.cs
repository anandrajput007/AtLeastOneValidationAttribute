using System.Collections.Generic;

namespace AtLeastOneValidationAttribute.Models
{
    public class ResultModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Model { get; set; }
        public List<T> LstModel { get; set; }
    }
}
