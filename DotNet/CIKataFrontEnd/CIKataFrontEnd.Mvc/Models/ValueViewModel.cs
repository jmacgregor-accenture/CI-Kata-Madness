namespace CIKataFrontEnd.Mvc.Models
{
    public class ValueViewModel
    {
        public string ResponseValue { get; }

        public ValueViewModel(string responseValue)
        {
            ResponseValue = responseValue;
        }
    }
}