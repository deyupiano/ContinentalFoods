namespace ContinentalFoods.WebApi.Routes
{
    public static class ApiRoutes
    {
        public const string BaseRoute = "api/v{version:apiVersion}/[controller]";

        public static class UserProfiles
        {
            public const string IdRoute = "{id}";
        }

        public static class Friendships
        {
            public const string FriendRequestCreate = "friendRequest";
            public const string FriendRequestAccept = "friendRequest/{friendRequestId}/accept";
            public const string FriendRequestReject = "friendRequest/{friendRequestId}/reject";
        }

        public static class Posts
        {
            public const string IdRoute = "{id}";
            public const string PostComments = "{postId}/comments";
            public const string CommentById = "{postId}/comments/{commentId}";
            public const string InteractionById = "{postId}/interactions/{interactionId}";
            public const string PostInteractions = "{postId}/interactions";
        }
        public static class Meals
        {
            public const string IdRoute = "{id}";
            public const string UpateInstruction = "UpateInstructionById/{id}";
            public const string UpateMealBasicInfo = "UpateMealBasicInfoById/{id}";
            public const string UpateMealImage = "UpateMealImageById/{id}";
            public const string UpateMealVideo = "UpateMealVideoById/{id}";
            public const string UpateIngredient = "UpateIngredientById/{id}";
            public const string UpateIngredientMeasure = "UpateIngredientMeasureById/{id}";
            public const string Random = "random";
            public const string Letter = "searchMealByLetter/{letter}";
            public const string Ingredient = "searchMealByIngredient/{ingredient}";
        }
        public static class Ingredients
        {
            public const string IdRoute = "{id}";
            public const string UpateIngredient = "UpateIngredientById/{id}";

        }
        public static class Identity
        {
            public const string Login = "login";
            public const string Registration = "registration";
            public const string IdentityById = "{identityUserId}";
            public const string CurrentUser = "currentuser";
            public const string SignOut = "sign-out";
            public const string Refresh = "refresh";
        }
    }
}
