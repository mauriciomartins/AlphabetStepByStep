using AlphabetStepByStep.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetStepByStep.Model.Service
{
    class ContentDirectoryService
    {
        public static ContentDirectory LoadContentDirectory()
        {
            string[] contents = {"Vowel","Consonant","Alphabet" };

            ContentDirectory ContentDiretory = new ContentDirectory();
            ObservableCollection<Content> contentList = new ObservableCollection<Content>();
            
            for (int i = 0; i < contents.Length; i++)
            {
                Content Content = new Content();
                Content.Value       = contents[i] ;
                Content.Description = contents[i];
                contentList.Add(Content);
            }

            ContentDiretory.ContentList = contentList;
            return ContentDiretory;
        }
    }
}
