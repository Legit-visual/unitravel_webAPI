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
        public static void BookingType(string bookingType)
        {
            if (string.IsNullOrEmpty(bookingType))
                throw new Exception("BookingType cannot be null or empty");

            bookingType = bookingType.Trim().ToLower();

            if (string.Equals(bookingType, "voucher", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else
            {
                throw new Exception("Invalid BookingType. Allowed value is 'Voucher'.");
            }
        }

        public static void MealPlan(string mealPlan)
        {
            if (string.IsNullOrEmpty(mealPlan))
                throw new Exception("MealPlan cannot be null or empty");

            mealPlan = mealPlan.Trim().ToLower();

            if (string.Equals(mealPlan, "all", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealPlan, "withmeal", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealPlan, "roomonly", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else
            {
                throw new Exception(
                    "Invalid MealPlan. Allowed values are 'All', 'WithMeal', 'RoomOnly'.");
            }
        }


        public static void MealType(string mealType)
        {
            if (string.IsNullOrEmpty(mealType))
                throw new Exception("MealType cannot be null or empty");

            mealType = mealType.Trim().ToLower();

            if (string.Equals(mealType, "all_inclusive_all_meal", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "full_board", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "half_board", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "room_only", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "breakfast", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "lunch", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "dinner", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "breakfast_lunch", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "breakfast_for_1", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "breakfast_for_2", StringComparison.OrdinalIgnoreCase)
                || string.Equals(mealType, "all", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else
            {
                throw new Exception(
                    "Invalid MealType. Allowed values are: " +
                    "'All_Inclusive_All_Meal', 'Full_Board', 'Half_Board', 'Room_Only', " +
                    "'BreakFast', 'Lunch', 'Dinner', 'BreakFast_Lunch', " +
                    "'Breakfast_For_1', 'Breakfast_For_2'.");
            }
        }

        public static void StarRating(string starRating)
        {
            if (string.IsNullOrEmpty(starRating))
                throw new Exception("StarRating cannot be null or empty");

            starRating = starRating.Trim().ToLower();

            if (string.Equals(starRating, "all", StringComparison.OrdinalIgnoreCase)
                || string.Equals(starRating, "onestar", StringComparison.OrdinalIgnoreCase)
                || string.Equals(starRating, "twostar", StringComparison.OrdinalIgnoreCase)
                || string.Equals(starRating, "threestar", StringComparison.OrdinalIgnoreCase)
                || string.Equals(starRating, "fourstar", StringComparison.OrdinalIgnoreCase)
                || string.Equals(starRating, "fivestar", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else
            {
                throw new Exception("Invalid StarRating. Allowed values are 'All', 'OneStar', 'TwoStar', 'ThreeStar' or 'FourStar'.");
            }
        }
        public static void BookingStatus(string bookingStatus)
        {
            if (string.IsNullOrEmpty(bookingStatus))
                throw new Exception("BookingStatus cannot be null or empty");

            bookingStatus = bookingStatus.Trim().ToLower();

            if (string.Equals(bookingStatus, "confirmed", StringComparison.OrdinalIgnoreCase)
                || string.Equals(bookingStatus, "cancelled", StringComparison.OrdinalIgnoreCase)
                || string.Equals(bookingStatus, "cancellationinprogress", StringComparison.OrdinalIgnoreCase)
                || string.Equals(bookingStatus, "cancelpending", StringComparison.OrdinalIgnoreCase)
                || string.Equals(bookingStatus, "cxlrequestsenttohotel", StringComparison.OrdinalIgnoreCase)
                || string.Equals(bookingStatus, "cancelledandrefundawaited", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            else
            {
                throw new Exception(
                    "Invalid BookingStatus. Allowed values are: " +
                    "'Confirmed', 'Cancelled', 'CancellationInProgress', " +
                    "'CancelPending', 'CxlRequestSentToHotel', 'CancelledAndRefundAwaited'.");
            }
        }

    }
}
