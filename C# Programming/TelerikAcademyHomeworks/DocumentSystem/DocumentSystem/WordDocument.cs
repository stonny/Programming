using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class WordDocument : OfficeDocuments, IEditable
    {
        public int NumberOfCharacters
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void ChangeContent(string newContent)
        {
            throw new NotImplementedException();
        }
    }
}
