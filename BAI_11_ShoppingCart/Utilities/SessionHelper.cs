using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BAI_11_ShoppingCart.Utilities
{
    public static class SessionHelper
    {
        public static void setObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
