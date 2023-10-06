
using ContinentalFoods.Domain.Exceptions;
using ContinentalFoods.Domain.Validators.MealInfoValidator;

namespace Domain.Aggregates.MealAggregate
{
    public class Meal
    {
        private Meal()
        {
        }
        public Guid IdMeal { get; private set; }
        public string IdentityId { get; private set; }
        public string? StrMeal { get; private set; }
        public string? StrCategory { get; private set; }
        public string? StrArea { get; private set; }
        public string? StrInstructions { get; private set; }
        public string? StrMealThumb { get; private set; }
        public string? StrTags { get; private set; }
        public string? StrYoutube { get; private set; }
        public string? StrIngredient1 { get; private set; }
        public string? StrIngredient2 { get; private set; }
        public string? StrIngredient3 { get; private set; }
        public string? StrIngredient4 { get; private set; }
        public string? StrIngredient5 { get; private set; }
        public string? StrIngredient6 { get; private set; }
        public string? StrIngredient7 { get; private set; }
        public string? StrIngredient8 { get; private set; }
        public string? StrIngredient9 { get; private set; }
        public string? StrIngredient10 { get; private set; }
        public string? StrIngredient11 { get; private set; }
        public string? StrIngredient12 { get; private set; }
        public string? StrIngredient13 { get; private set; }
        public string? StrIngredient14 { get; private set; }
        public string? StrIngredient15 { get; private set; }
        public string? StrIngredient16 { get; private set; }
        public string? StrIngredient17 { get; private set; }
        public string? StrIngredient18 { get; private set; }
        public string? StrIngredient19 { get; private set; }
        public string? StrIngredient20 { get; private set; }
        public string? StrIngredient21 { get; private set; }
        public string? StrIngredient22 { get; private set; }
        public string? StrIngredient23 { get; private set; }
        public string? StrIngredient24 { get; private set; }
        public string? StrIngredient25 { get; private set; }
        public string? StrIngredient26 { get; private set; }
        public string? StrIngredient27 { get; private set; }
        public string? StrIngredient28 { get; private set; }
        public string? StrIngredient29 { get; private set; }
        public string? StrIngredient30 { get; private set; }
        public string? StrMeasure1 { get; private set; }
        public string? StrMeasure2 { get; private set; }
        public string? StrMeasure3 { get; private set; }
        public string? StrMeasure4 { get; private set; }
        public string? StrMeasure5 { get; private set; }
        public string? StrMeasure6 { get; private set; }
        public string? StrMeasure7 { get; private set; }
        public string? StrMeasure8 { get; private set; }
        public string? StrMeasure9 { get; private set; }
        public string? StrMeasure10 { get; private set; }
        public string? StrMeasure11 { get; private set; }
        public string? StrMeasure12 { get; private set; }
        public string? StrMeasure13 { get; private set; }
        public string? StrMeasure14 { get; private set; }
        public string? StrMeasure15 { get; private set; }
        public string? StrMeasure16 { get; private set; }
        public string? StrMeasure17 { get; private set; }
        public string? StrMeasure18 { get; private set; }
        public string? StrMeasure19 { get; private set; }
        public string? StrMeasure20 { get; private set; }
        public string? StrMeasure21 { get; private set; }
        public string? StrMeasure22 { get; private set; }
        public string? StrMeasure23 { get; private set; }
        public string? StrMeasure24 { get; private set; }
        public string? StrMeasure25 { get; private set; }
        public string? StrMeasure26 { get; private set; }
        public string? StrMeasure27 { get; private set; }
        public string? StrMeasure28 { get; private set; }
        public string? StrMeasure29 { get; private set; }
        public string? StrMeasure30 { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }

        // Factory method
        public static Meal CreateMeal(
        string identityId,
        string strMeal ,
        string strCategory ,
        string strArea ,
        string strInstructions ,
        string strMealThumb ,
        string strTags ,
        string strYoutube ,
        string strIngredient1 ,
        string strIngredient2 ,
        string strIngredient3 ,
        string strIngredient4 ,
        string strIngredient5 ,
        string strIngredient6 ,
        string strIngredient7 ,
        string strIngredient8 ,
        string strIngredient9 ,
        string strIngredient10 ,
        string strIngredient11 ,
        string strIngredient12 ,
        string strIngredient13 ,
        string strIngredient14 ,
        string strIngredient15 ,
        string strIngredient16 ,
        string strIngredient17 ,
        string strIngredient18 ,
        string strIngredient19 ,
        string strIngredient20 ,
        string strIngredient21 ,
        string strIngredient22 ,
        string strIngredient23 ,
        string strIngredient24 ,
        string strIngredient25 ,
        string strIngredient26 ,
        string strIngredient27 ,
        string strIngredient28 ,
        string strIngredient29 ,
        string strIngredient30 ,
        string strMeasure1 ,
        string strMeasure2 ,
        string strMeasure3 ,
        string strMeasure4 ,
        string strMeasure5 ,
        string strMeasure6 ,
        string strMeasure7 ,
        string strMeasure8 ,
        string strMeasure9 ,
        string strMeasure10 ,
        string strMeasure11 ,
        string strMeasure12 ,
        string strMeasure13 ,
        string strMeasure14 ,
        string strMeasure15 ,
        string strMeasure16 ,
        string strMeasure17 ,
        string strMeasure18 ,
        string strMeasure19 ,
        string strMeasure20 ,
        string strMeasure21 ,
        string strMeasure22 ,
        string strMeasure23 ,
        string strMeasure24 ,
        string strMeasure25 ,
        string strMeasure26 ,
        string strMeasure27 ,
        string strMeasure28 ,
        string strMeasure29 ,
        string strMeasure30)
        {
            var validator = new MealInfoValidator();

            var objToValidate = new Meal
            {
                IdentityId = identityId,
                StrMeal = strMeal,
                StrCategory = strCategory,
                StrArea = strArea,
                StrInstructions = strInstructions,
                StrMealThumb = strMealThumb,
                StrTags = strTags,
                StrYoutube = strYoutube,
                StrIngredient1 = strIngredient1,
                StrIngredient2 = strIngredient2,
                StrIngredient3 = strIngredient3,
                StrIngredient4 = strIngredient4,
                StrIngredient5 = strIngredient5,
                StrIngredient6 = strIngredient6,
                StrIngredient7 = strIngredient7,
                StrIngredient8 = strIngredient8,
                StrIngredient9 = strIngredient9,
                StrIngredient10 = strIngredient10,
                StrIngredient11 = strIngredient11,
                StrIngredient12 = strIngredient12,
                StrIngredient13 = strIngredient13,
                StrIngredient14 = strIngredient14,
                StrIngredient15 = strIngredient15,
                StrIngredient16 = strIngredient16,
                StrIngredient17 = strIngredient17,
                StrIngredient18 = strIngredient18,
                StrIngredient19 = strIngredient19,
                StrIngredient20 = strIngredient20,
                StrIngredient21 = strIngredient21,
                StrIngredient22 = strIngredient22,
                StrIngredient23 = strIngredient23,
                StrIngredient24 = strIngredient24,
                StrIngredient25 = strIngredient25,
                StrIngredient26 = strIngredient26,
                StrIngredient27 = strIngredient27,
                StrIngredient28 = strIngredient28,
                StrIngredient29 = strIngredient29,
                StrIngredient30 = strIngredient30,
                StrMeasure1 = strMeasure1,
                StrMeasure2 = strMeasure2,
                StrMeasure3 = strMeasure3,
                StrMeasure4 = strMeasure4,
                StrMeasure5 = strMeasure5,
                StrMeasure6 = strMeasure6,
                StrMeasure7 = strMeasure7,
                StrMeasure8 = strMeasure8,
                StrMeasure9 = strMeasure9,
                StrMeasure10 = strMeasure10,
                StrMeasure11 = strMeasure11,
                StrMeasure12 = strMeasure12,
                StrMeasure13 = strMeasure13,
                StrMeasure14 = strMeasure14,
                StrMeasure15 = strMeasure15,
                StrMeasure16 = strMeasure16,
                StrMeasure17 = strMeasure17,
                StrMeasure18 = strMeasure18,
                StrMeasure19 = strMeasure19,
                StrMeasure20 = strMeasure20,
                StrMeasure21 = strMeasure21,
                StrMeasure22 = strMeasure22,
                StrMeasure23 = strMeasure23,
                StrMeasure24 = strMeasure24,
                StrMeasure25 = strMeasure25,
                StrMeasure26 = strMeasure26,
                StrMeasure27 = strMeasure27,
                StrMeasure28 = strMeasure28,
                StrMeasure29 = strMeasure29,
                StrMeasure30 = strMeasure30,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };

            var validationResult = validator.Validate(objToValidate);

            if (validationResult.IsValid) return objToValidate;

            var exception = new MealInfoNotValidException("The meal information is not valid");
            foreach (var error in validationResult.Errors)
            {
                exception.ValidationErrors.Add(error.ErrorMessage);
            }

            throw exception;
        }

        //public methods

        public void UpdateMeal(
        Guid idMeal,
        string identityId,
        string strMeal,
        string strCategory,
        string strArea,
        string strInstructions,
        string strMealThumb,
        string strTags,
        string strYoutube,
        string strIngredient1,
        string strIngredient2,
        string strIngredient3,
        string strIngredient4,
        string strIngredient5,
        string strIngredient6,
        string strIngredient7,
        string strIngredient8,
        string strIngredient9,
        string strIngredient10,
        string strIngredient11,
        string strIngredient12,
        string strIngredient13,
        string strIngredient14,
        string strIngredient15,
        string strIngredient16,
        string strIngredient17,
        string strIngredient18,
        string strIngredient19,
        string strIngredient20,
        string strIngredient21,
        string strIngredient22,
        string strIngredient23,
        string strIngredient24,
        string strIngredient25,
        string strIngredient26,
        string strIngredient27,
        string strIngredient28,
        string strIngredient29,
        string strIngredient30,
        string strMeasure1,
        string strMeasure2,
        string strMeasure3,
        string strMeasure4,
        string strMeasure5,
        string strMeasure6,
        string strMeasure7,
        string strMeasure8,
        string strMeasure9,
        string strMeasure10,
        string strMeasure11,
        string strMeasure12,
        string strMeasure13,
        string strMeasure14,
        string strMeasure15,
        string strMeasure16,
        string strMeasure17,
        string strMeasure18,
        string strMeasure19,
        string strMeasure20,
        string strMeasure21,
        string strMeasure22,
        string strMeasure23,
        string strMeasure24,
        string strMeasure25,
        string strMeasure26,
        string strMeasure27,
        string strMeasure28,
        string strMeasure29,
        string strMeasure30)
        {
            if (string.IsNullOrWhiteSpace(strMeal))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal name is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strCategory))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal category is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strCategory))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal category is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strArea))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal geographical area is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strInstructions))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal instruction is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strMealThumb))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal image is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strYoutube))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal video is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            IdMeal = idMeal;
                IdentityId = identityId;
                StrMeal = strMeal;
                StrCategory = strCategory;
                StrArea = strArea;
                StrInstructions = strInstructions;
                StrMealThumb = strMealThumb;
                StrTags = strTags;
                StrYoutube = strYoutube;
                StrIngredient1 = strIngredient1;
                StrIngredient2 = strIngredient2;
                StrIngredient3 = strIngredient3;
                StrIngredient4 = strIngredient4;
                StrIngredient5 = strIngredient5;
                StrIngredient6 = strIngredient6;
                StrIngredient7 = strIngredient7;
                StrIngredient8 = strIngredient8;
                StrIngredient9 = strIngredient9;
                StrIngredient10 = strIngredient10;
                StrIngredient11 = strIngredient11;
                StrIngredient12 = strIngredient12;
                StrIngredient13 = strIngredient13;
                StrIngredient14 = strIngredient14;
                StrIngredient15 = strIngredient15;
                StrIngredient16 = strIngredient16;
                StrIngredient17 = strIngredient17;
                StrIngredient18 = strIngredient18;
                StrIngredient19 = strIngredient19;
                StrIngredient20 = strIngredient20;
                StrIngredient21 = strIngredient21;
                StrIngredient22 = strIngredient22;
                StrIngredient23 = strIngredient23;
                StrIngredient24 = strIngredient24;
                StrIngredient25 = strIngredient25;
                StrIngredient26 = strIngredient26;
                StrIngredient27 = strIngredient27;
                StrIngredient28 = strIngredient28;
                StrIngredient29 = strIngredient29;
                StrIngredient30 = strIngredient30;
                StrMeasure1 = strMeasure1;
                StrMeasure2 = strMeasure2;
                StrMeasure3 = strMeasure3;
                StrMeasure4 = strMeasure4;
                StrMeasure5 = strMeasure5;
                StrMeasure6 = strMeasure6;
                StrMeasure7 = strMeasure7;
                StrMeasure8 = strMeasure8;
                StrMeasure9 = strMeasure9;
                StrMeasure10 = strMeasure10;
                StrMeasure11 = strMeasure11;
                StrMeasure12 = strMeasure12;
                StrMeasure13 = strMeasure13;
                StrMeasure14 = strMeasure14;
                StrMeasure15 = strMeasure15;
                StrMeasure16 = strMeasure16;
                StrMeasure17 = strMeasure17;
                StrMeasure18 = strMeasure18;
                StrMeasure19 = strMeasure19;
                StrMeasure20 = strMeasure20;
                StrMeasure21 = strMeasure21;
                StrMeasure22 = strMeasure22;
                StrMeasure23 = strMeasure23;
                StrMeasure24 = strMeasure24;
                StrMeasure25 = strMeasure25;
                StrMeasure26 = strMeasure26;
                StrMeasure27 = strMeasure27;
                StrMeasure28 = strMeasure28;
                StrMeasure29 = strMeasure29;
                StrMeasure30 = strMeasure30;
                DateCreated = DateTime.UtcNow;
                LastModified = DateTime.UtcNow;
        }



        public void UpdateMealInstruction(
        Guid idMeal,
        string identityId,
        string strInstructions)
        {
            if (string.IsNullOrWhiteSpace(strInstructions))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal instruction is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
          
            IdMeal = idMeal;
            IdentityId = identityId;
            StrInstructions = strInstructions;            
            DateCreated = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;
        }

        public void UpdateMealBasicInfo(
            Guid idMeal,
            string identityId,
            string strMeal,
            string strCategory,
            string strTags,
            string strArea)
        {
            if (string.IsNullOrWhiteSpace(strMeal))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal name is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strCategory))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal category is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strCategory))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal category is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            if (string.IsNullOrWhiteSpace(strArea))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal geographical area is not valid");
                exception.ValidationErrors.Add("The provided text is either null or contains only white space");
                throw exception;
            }
            IdMeal = idMeal;
            IdentityId = identityId;
            StrMeal = strMeal;  
            StrCategory = strCategory;
            StrTags = strTags;
            StrArea = strArea;
            DateCreated = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;
        }

        public void UpdateMealIngredients(
            Guid idMeal,
            string identityId,
            string strIngredient1,
            string strIngredient2,
            string strIngredient3,
            string strIngredient4,
            string strIngredient5,
            string strIngredient6,
            string strIngredient7,
            string strIngredient8,
            string strIngredient9,
            string strIngredient10,
            string strIngredient11,
            string strIngredient12,
            string strIngredient13,
            string strIngredient14,
            string strIngredient15,
            string strIngredient16,
            string strIngredient17,
            string strIngredient18,
            string strIngredient19,
            string strIngredient20,
            string strIngredient21,
            string strIngredient22,
            string strIngredient23,
            string strIngredient24,
            string strIngredient25,
            string strIngredient26,
            string strIngredient27,
            string strIngredient28,
            string strIngredient29,
            string strIngredient30)
        {

            IdMeal = idMeal;
            IdentityId = identityId;
            StrIngredient1 = strIngredient1;
            StrIngredient2 = strIngredient2;
            StrIngredient3 = strIngredient3;
            StrIngredient4 = strIngredient4;
            StrIngredient5 = strIngredient5;
            StrIngredient6 = strIngredient6;
            StrIngredient7 = strIngredient7;
            StrIngredient8 = strIngredient8;
            StrIngredient9 = strIngredient9;
            StrIngredient10 = strIngredient10;
            StrIngredient11 = strIngredient11;
            StrIngredient12 = strIngredient12;
            StrIngredient13 = strIngredient13;
            StrIngredient14 = strIngredient14;
            StrIngredient15 = strIngredient15;
            StrIngredient16 = strIngredient16;
            StrIngredient17 = strIngredient17;
            StrIngredient18 = strIngredient18;
            StrIngredient19 = strIngredient19;
            StrIngredient20 = strIngredient20;
            StrIngredient21 = strIngredient21;
            StrIngredient22 = strIngredient22;
            StrIngredient23 = strIngredient23;
            StrIngredient24 = strIngredient24;
            StrIngredient25 = strIngredient25;
            StrIngredient26 = strIngredient26;
            StrIngredient27 = strIngredient27;
            StrIngredient28 = strIngredient28;
            StrIngredient29 = strIngredient29;
            StrIngredient30 = strIngredient30;
            DateCreated = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;
        }


        public void UpdateMealIngredientsMeasure(
            Guid idMeal,
            string identityId,
            string strMeasure1,
            string strMeasure2,
            string strMeasure3,
            string strMeasure4,
            string strMeasure5,
            string strMeasure6,
            string strMeasure7,
            string strMeasure8,
            string strMeasure9,
            string strMeasure10,
            string strMeasure11,
            string strMeasure12,
            string strMeasure13,
            string strMeasure14,
            string strMeasure15,
            string strMeasure16,
            string strMeasure17,
            string strMeasure18,
            string strMeasure19,
            string strMeasure20,
            string strMeasure21,
            string strMeasure22,
            string strMeasure23,
            string strMeasure24,
            string strMeasure25,
            string strMeasure26,
            string strMeasure27,
            string strMeasure28,
            string strMeasure29,
            string strMeasure30)
        {

            IdMeal = idMeal;
            IdentityId = identityId;
            StrMeasure1 = strMeasure1;
            StrMeasure2 = strMeasure2;
            StrMeasure3 = strMeasure3;
            StrMeasure4 = strMeasure4;
            StrMeasure5 = strMeasure5;
            StrMeasure6 = strMeasure6;
            StrMeasure7 = strMeasure7;
            StrMeasure8 = strMeasure8;
            StrMeasure9 = strMeasure9;
            StrMeasure10 = strMeasure10;
            StrMeasure11 = strMeasure11;
            StrMeasure12 = strMeasure12;
            StrMeasure13 = strMeasure13;
            StrMeasure14 = strMeasure14;
            StrMeasure15 = strMeasure15;
            StrMeasure16 = strMeasure16;
            StrMeasure17 = strMeasure17;
            StrMeasure18 = strMeasure18;
            StrMeasure19 = strMeasure19;
            StrMeasure20 = strMeasure20;
            StrMeasure21 = strMeasure21;
            StrMeasure22 = strMeasure22;
            StrMeasure23 = strMeasure23;
            StrMeasure24 = strMeasure24;
            StrMeasure25 = strMeasure25;
            StrMeasure26 = strMeasure26;
            StrMeasure27 = strMeasure27;
            StrMeasure28 = strMeasure28;
            StrMeasure29 = strMeasure29;
            StrMeasure30 = strMeasure30;
            DateCreated = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;
        }

        public void UpdateMealImage(
            Guid idMeal,
            string identityId,
            string strMealThumb)
        {
            if (string.IsNullOrWhiteSpace(strMealThumb))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal image data is not valid");
                exception.ValidationErrors.Add("Please upload image again");
                throw exception;
            }

            IdMeal = idMeal;
            IdentityId = identityId;
            StrMealThumb = strMealThumb;
            DateCreated = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;
        }
        public void UpdateMealVideo(
            Guid idMeal,
            string identityId,
            string strYoutube)
        {
            if (string.IsNullOrWhiteSpace(strYoutube))
            {
                var exception = new MealInfoNotValidException("Cannot update meal." +
                                                          "Meal video data is not valid");
                exception.ValidationErrors.Add("Please upload video again");
                throw exception;
            }

            IdMeal = idMeal;
            IdentityId = identityId;
            StrYoutube = strYoutube;
            DateCreated = DateTime.UtcNow;
            LastModified = DateTime.UtcNow;
        }
    }
}
