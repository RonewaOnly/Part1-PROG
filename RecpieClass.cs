using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1__Final_ST10157545
{
	/// <summary>
	 /// author : Ronewa maselesele ST10157545
	 /// </summary>
	internal class RecipeClass
	{
		string[] ingredientsName, unitOfMeasurement, ingredientSteps;
		double[] ingredientQualtity, DoubleIndendints, HalfedIndedients, TripleIndedients;// those arrays are used to save mulitple values enterd and sent the InputStorage
		int numOfIngredints, numOfSteps;// this variables are used for the loops 
		string options, optionFactor;// these are variables that used for option choice questions
		InputStorage obj = new InputStorage();// this object calls the class for the getters and setters to store and retrive 

		public RecipeClass()
		{
			MainOptions();
		}

		public void MainOptions()
		{
			while (true)
			{
				Console.WriteLine("Choose one of the following: \n" +
					"1. Enter the ingredients for the recipe.. \n" +
					"2. Display the whole recipe...\n" +
					"3. Scale the Unit of measurement....\n" +
					"4. Restart \n" +
					"5. Clear ");
				options = (Console.ReadLine());

				switch (options)
				{
					case "1":
						Option1();
						break;
					case "2":
						Option2();
						break;
					case "3":
						Option3();
						break;
					case "4":
						Option4();
						break;
					case "5":
						Clear();
						break;


				}
			}
		}

		public void Option1()// this takes in the ingredients needed for the recipe
		{
			Console.WriteLine("Enter the name of the recipe: ");
			string recipeName = Console.ReadLine();
			Console.WriteLine($"Recipe name : {recipeName}");
			Console.WriteLine("How many ingredients: ");
			numOfIngredints = Convert.ToInt32(Console.ReadLine());

			ingredientsName = new string[1000];
			ingredientQualtity = new double[1000];
			unitOfMeasurement = new string[1000];
			int counter = 1;
			for (int i = 0; i < numOfIngredints; i++)
			{
				Console.WriteLine($"Ingredient: {counter++} ");
				Console.WriteLine("Enter ingredient name: ");
				ingredientsName[i] = Console.ReadLine();
				Console.WriteLine("Enter the ingredient qualtity: ");
				ingredientQualtity[i] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter the unit of measurement: ");
				unitOfMeasurement[i] = Console.ReadLine();
				Console.Beep();

			}
			Steps();
		}
		public void Option2()// this methods details all the information entered by the user
		{

			for (int i = 0; i < numOfIngredints; i++)
			{
				/*Console.WriteLine($"Ingredient {counter++}\n"+"Ingredient name : " + ingredientsName[i]+"\n" +
					"Ingredient qualtity:  " + ingredientQualtity[i]+"\n" +
					"Unit of Measurement:  "+ unitOfMeasurement[i]+"\n");*/
				obj.NumOfIngredints = numOfIngredints;
				obj.IngredientsName[i] = ingredientsName[i];
				obj.IngredientQualtity[i] = ingredientQualtity[i];
				obj.UnitOfMeasurement[i] = unitOfMeasurement[i];

			}
			obj.Details();

		}
		public void Option3()// this method sets the factor to used to measure the ingredient qualtity
		{
			int Double = 2;
			double half = 0.5;
			int triple = 3;
			Console.WriteLine("Do you want factor the unit of Measurement \n" +
				"1. Double(2)\n" +
				"2. Halfen (0.5)\n" +
				"3. Trpile (3)");
			optionFactor = Console.ReadLine();
			DoubleIndendints = new double[numOfIngredints];
			HalfedIndedients = new double[numOfIngredints];
			TripleIndedients = new double[numOfIngredints];
			switch (optionFactor)
			{
				case "1":
					Console.WriteLine("============ before ===============");
					obj.Details();
					Console.WriteLine("============== End =============");

					Console.WriteLine("============ After ===============");
					for (int i = 0; i < numOfIngredints; i++)
					{
						obj.IngredientQualtity[i] = ingredientQualtity[i];
						obj.DoubleIndendints1[i] = obj.IngredientQualtity[i];
						obj.DoubleIndendints1[i] *= Double;

						/*Console.WriteLine(
							$"ingredient no: {i} \n" + $"Ingredient name: {ingredientsName[i]} \n" +
							$"Ingredient Qualtity: {DoubleIndendints[i]}\n " +
							$"Unit of Measurement {unitOfMeasurement[i]}\n"
							);*/
					}
					obj.ModifiedDouble();
					//Option2();
					Console.WriteLine("============== End =============");

					break;
				case "2":
					Console.WriteLine("============ before ===============");
					obj.Details();
					Console.WriteLine("============== End =============");

					Console.WriteLine("============ After ===============");

					for (int i = 0; i < numOfIngredints; i++)
					{
						obj.HalfedIndedients1[i] = ingredientQualtity[i];
						obj.HalfedIndedients1[i] *= half;
						/*Console.WriteLine(
						$"ingredient no: {i} \n" + $"Ingredient name: {ingredientsName[i]} \n" +
						$"Ingredient Qualtity: {HalfedIndedients[i]} \n " +
						$"Unit of Measurement {unitOfMeasurement[i]}\n");*/
					}
					obj.ModifiedHalfed();
					//Option2();
					Console.WriteLine("============== End =============");
					break;
				case "3":
					Console.WriteLine("============ before ===============");
					obj.Details();
					Console.WriteLine("============== End =============");

					Console.WriteLine("============ After ===============");
					for (int i = 0; i < numOfIngredints; i++)
					{
						obj.TripleIndedients1[i] = ingredientQualtity[i];
						obj.TripleIndedients1[i] *= triple;

						/*Console.WriteLine(
							$"ingredient no: {i} \n" + $"Ingredient name: {ingredientsName[i]} \n" +
							$"Ingredient Qualtity: {TripleIndedients[i]}\n " +
							$"Unit of Measurement {unitOfMeasurement[i]}\n");*/
					}
					//
					//Option2();
					obj.ModifiedTriple();
					Console.WriteLine("============== End =============");
					break;
			}


		}
		public void Option4()// this method restarts all the values modified by factors set
		{
			Console.WriteLine("Do you want to restart to the original [yes/no");
			options = Console.ReadLine();
			switch (options)
			{
				case "yes":
					Console.WriteLine("-------- Modified values -----------");
					if (optionFactor == "1")
					{

						obj.ModifiedDouble();

						Console.WriteLine("-------- Restarted to original value from doubled --------");
						for (int i = 0; i < numOfIngredints; i++)
						{
							obj.DoubleIndendints1[i] = ingredientQualtity[i];
						}
						obj.ModifiedDouble();
					}
					else if (optionFactor == "2")
					{

						obj.ModifiedHalfed();

						Console.WriteLine("-------- Restarted to original value  from halfed --------");

						for (int i = 0; i < numOfIngredints; i++)
						{
							obj.HalfedIndedients1[i] = ingredientQualtity[i];
						}
						obj.ModifiedHalfed();
					}
					else if (optionFactor == "3")
					{
						obj.ModifiedTriple();

						Console.WriteLine("-------- Restarted to original value from Tripled --------");
						for (int i = 0; i < numOfIngredints; i++)
						{
							obj.TripleIndedients1[i] = ingredientQualtity[i];

						}
						obj.ModifiedTriple();

					}
					break;
			}
		}

		public void Steps()//this method sets the steps of the recipe
		{
			Console.WriteLine("How many steps are needed for your recipe: ");
			numOfSteps = Convert.ToInt32(Console.ReadLine());
			ingredientSteps = new string[numOfSteps];
			obj.NumOfSteps = numOfSteps;// this declaring sends the number of step needed to the InputStorage to use in the for loop
			int counter = 1;
			for (int i = 0; i < numOfSteps; i++)
			{
				Console.WriteLine($"Ingredient step: {counter++}");
				ingredientSteps[i] = Console.ReadLine();
				obj.IngredientSteps[i] = ingredientSteps[i];// this declartion is the set method from InputStorage class 
				/*Console.WriteLine("++++++++++Steps+++++++++++++\n" +
					$"step {counter++} \n" +
					  ingredientSteps[i]);*/
			}
		}
		public void Clear()//this method clears all the data stored before
		{
			Console.WriteLine("Do you want to clear all data  [yes/no]: ");
			options = Console.ReadLine();

			int maxLength = numOfIngredints + numOfSteps;
			switch (options)
			{
				case "yes":
					for (int i = 0; i < maxLength; i++)
					{
						ingredientsName[i] = "";
						ingredientQualtity[i] = 0;
						unitOfMeasurement[i] = "";

						obj.DoubleIndendints1[i] = ingredientQualtity[i];
						obj.HalfedIndedients1[i] = ingredientQualtity[i];
						obj.TripleIndedients1[i] = ingredientQualtity[i];

						obj.IngredientSteps[i] = "";
						obj.IngredientsName[i] = "";
						obj.IngredientQualtity[i] = ingredientQualtity[i];
						obj.UnitOfMeasurement[i] = "";
					}
					obj.Details();
					obj.ModifiedDouble();
					obj.ModifiedHalfed();
					obj.ModifiedTriple();
					break;
				case "no":
					break;

			}

		}
	}
}
/// <summary>
/// author : Ronewa maselesele ST10157545
/// </summary>

