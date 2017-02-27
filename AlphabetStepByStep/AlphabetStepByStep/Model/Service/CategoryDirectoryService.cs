using AlphabetStepByStep.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetStepByStep.Model.Service
{
    class CategoryDirectoryService
    {
        public static  CategoryDirectory LoadCategoryDirectory()
        {
            string[] categories = {"Vowel","Consonant","Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet", "Vowel", "Consonant", "Alphabet" };

            CategoryDirectory categoryDirectory = new CategoryDirectory();
            ObservableCollection<Category> categoryList = new ObservableCollection<Category>();
            
            for (int i = 0; i < categories.Length; i++)
            {
                Category category    = new Category();
                category.Value       = categories[i] ;
                category.Description = categories[i];
                categoryList.Add(category);
            }

            categoryDirectory.CategoryList = categoryList;
            return categoryDirectory;
        }
    }
}
