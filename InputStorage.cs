using System;

namespace Part1__Final_ST10157545
{
	internal class InputStorage
	{
		private string[] ingredientsName = new string[100], unitOfMeasurement = new string[100], ingredientSteps = new string[100];
		private double[] ingredientQualtity = new double[100], DoubleIndendints = new double[1000], HalfedIndedients = new double[100], TripleIndedients = new double[100];
		private int numOfIngredints = 0, numOfSteps;

		public int NumOfIngredints { get { return numOfIngredints; } set { numOfIngredints = value; } }

		public string[] IngredientsName { get { return ingredientsName; } set { ingredientsName = value; } }
		public string[] UnitOfMeasurement { get { return unitOfMeasurement; } set { unitOfMeasurement = value; } }
		public double[] IngredientQualtity { get { return ingredientQualtity; } set { ingredientQualtity = value; } }
		public double[] DoubleIndendints1 { get { return DoubleIndendints; } set { DoubleIndendints = value; } }
		public double[] HalfedIndedients1 { get { return HalfedIndedients; } set { HalfedIndedients = value; } }
		public double[] TripleIndedients1 { get { return TripleIndedients; } set { TripleIndedients = value; } }
		public int NumOfSteps { get { return numOfSteps; } set { numOfSteps = value; } }

		/// <summary>
		/// author : Ronewa maselesele ST10157545
		/// </summary>
		public string[] IngredientSteps { get { return ingredientSteps; } set { ingredientSteps = value; } }

		public void Details()
		{
			int counter = 1;
			int counter2 = 1;
			for (int i = 0; i < numOfIngredints; i++)
			{
				Console.WriteLine($"Ingredient {counter++}\n" +
					"\tIngredient name : " + ingredientsName[i] + "\n" +
					"\t\tIngredient qualtity:  " + ingredientQualtity[i] + "\n" +
					"\t\t\tUnit of Measurement:  " + unitOfMeasurement[i] + "\n");
			}
			Console.WriteLine($"\t\t ============ Steps numbered list ==========\n");
			for (int i = 0; i < numOfSteps; i++)
			{
				Console.WriteLine($"\t\tStep {counter2++}: " + ingredientSteps[i] + "\n"
					);
			}
			/*foreach (string item in ingredientSteps)
			{.
				Console.WriteLine($"Steps: {counter2++}\n" +
					$"{item}");
			}*/
		}

		public void ModifiedDouble()
		{
			int counter = 1;

			for (int i = 0; i < numOfIngredints; i++)
			{
				Console.WriteLine($"Ingredient {counter++}\n" +
					"Ingredient name : " + ingredientsName[i] + "\n" +
					"Ingredient qualtity:  " + DoubleIndendints1[i] + "\n" +
					"Unit of Measurement:  " + unitOfMeasurement[i] + "\n");
			}
		}

		public void ModifiedHalfed()
		{
			int counter = 1;

			for (int i = 0; i < numOfIngredints; i++)
			{
				Console.WriteLine($"Ingredient {counter++}\n" +
					"Ingredient name : " + ingredientsName[i] + "\n" +
					"Ingredient qualtity:  " + HalfedIndedients1[i] + "\n" +
					"Unit of Measurement:  " + unitOfMeasurement[i] + "\n");
			}
		}
		public void ModifiedTriple()
		{
			int counter = 1;

			for (int i = 0; i < numOfIngredints; i++)
			{
				Console.WriteLine($"Ingredient {counter++}\n" +
					"Ingredient name : " + ingredientsName[i] + "\n" +
					"Ingredient qualtity:  " + TripleIndedients1[i] + "\n" +
					"Unit of Measurement:  " + unitOfMeasurement[i] + "\n");
			}
		}
	}
	/// <summary>
	/// author : Ronewa maselesele ST10157545
	/// </summary>
}
