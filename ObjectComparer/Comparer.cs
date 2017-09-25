using System.Reflection;

namespace ObjectComparer
{
    public class Comparer
    {
        public bool Compare<T1, T2>(T1 obj1, T2 obj2)
        {
            bool areEqual = true;
            if (obj1.GetType() != obj2.GetType())
                return false;
            foreach (var property in obj1.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var value1 = property.GetValue(obj1);
                var value2 = property.GetValue(obj2);
                areEqual = areEqual && AreEqual(value1, value2);
            }
            return areEqual;
        }

        private bool AreEqual(object value1, object value2)
        {
            bool result;
            
            if (value1 == null && value2 != null || value1 != null && value2 == null)
                result = false;
            else if (object.Equals(value1, value2) == false)
                result = false;
            else
                result = true;
            return result;
        }
    }
}
