using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class TextDocument : IDocument, IEditable
    {
        public int Name
        {
            get { throw new NotImplementedException(); }
        }

        public int Content
        {
            get { throw new NotImplementedException(); }
        }

        public int Charset
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void LoadProperty(string key, string value)
        {
            throw new NotImplementedException();
        }

        public void SaveAllProperty(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }

        public void ChangeContent(string newContent)
        {
            throw new NotImplementedException();
        }
    }
}
