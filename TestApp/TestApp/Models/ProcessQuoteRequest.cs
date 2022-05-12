using System.Reflection;

namespace TestApp.Models
{
    public class ProcessQuoteRequest : Quote
    {
        public int product = 1;

        public ProcessQuoteRequest(Quote quote)
        {
            foreach (PropertyInfo piBase in typeof(Quote).GetProperties())
            {
                PropertyInfo piThis = GetType().GetProperty(piBase.Name);
                piThis.SetValue(this, piBase.GetValue(quote, null), null);
            }
        }
    }
}
