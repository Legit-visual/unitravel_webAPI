using System;

namespace unitravel_webAPI.Models.Responses
{
    public static class Validate
    {
        public static string PaymentMode(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "Limit";

            value = value.Trim();

            if (string.Equals(value, "limit", StringComparison.OrdinalIgnoreCase))
                return "Limit";

            if (string.Equals(value, "savedcard", StringComparison.OrdinalIgnoreCase))
                return "SavedCard";

            if (string.Equals(value, "newcard", StringComparison.OrdinalIgnoreCase))
                return "NewCard";

            return "Limit"; // Fallback to default
        }
        public static void PaxType(string paxType)
        {
            if (string.IsNullOrEmpty(paxType)) throw new Exception("PaxType cannot be null or empty");

            paxType = paxType.Trim().ToLower();

            if ((!string.Equals(paxType, "adult", StringComparison.OrdinalIgnoreCase) || !string.Equals(paxType, "child", StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Invalid PaxType. Allowed values are 'Adult' or 'Child'.");
            }
        }
        public static void MealType(string? mealType)
        {
            if (string.IsNullOrEmpty(mealType)) throw new Exception("MealType cannot be null or empty");

            mealType = mealType.Trim().ToLower();

            if (   string.Equals(mealType, "breakfast", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "lunch", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "dinner", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "all", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else
            {
                throw new Exception("Invalid MealType. Allowed values are 'Breakfast', 'Lunch' or 'Dinner'.");
            }
        }

    }
}
