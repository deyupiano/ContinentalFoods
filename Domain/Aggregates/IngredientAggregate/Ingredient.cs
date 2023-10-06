using ContinentalFoods.Domain.Aggregates.UserProfileAggregate;
using ContinentalFoods.Domain.Exceptions;
using ContinentalFoods.Domain.Validators.IngredientValidator;
using ContinentalFoods.Domain.Validators.PostValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContinentalFoods.Domain.Aggregates.IngredientAggregate
{
    public class Ingredient
    {
        private Ingredient()
        {
        }
        public Guid IdIngredient { get; private set; }
        public string StrIngredient { get; private set; }
        public string StrDescription { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }

        //Factories
        /// <summary>
        public static Ingredient CreateIngredient(string strIngredient, string strDescription)
        {
            var validator = new IngredientValidator();
            var objectToValidate = new Ingredient
            {
                StrIngredient = strIngredient,
                StrDescription = strDescription,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow,
            };

            var validationResult = validator.Validate(objectToValidate);
            
            if (validationResult.IsValid) return objectToValidate;

            var exception = new IngredientNotValidException("Ingredient is not valid");
            validationResult.Errors.ForEach(vr => exception.ValidationErrors.Add(vr.ErrorMessage));
            throw exception;
        }

        public void UpdateIngredient(string strIngredient, string strDescription)
        {
            if (string.IsNullOrWhiteSpace(strIngredient) || string.IsNullOrWhiteSpace(strDescription))
            {
                var exception = new PostNotValidException("Cannot update ingredient." +
                                                          "Ingredient name or description is/are not valid");
                exception.ValidationErrors.Add("The provided ingredient or description is/are either null or contains only white space");
                throw exception;
            }
            StrIngredient = strIngredient;
            StrDescription = StrDescription;
            LastModified = DateTime.UtcNow;
        }


    }
}
