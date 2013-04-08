using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public interface IDocument
    {
        int Name
        {
            get;
        }

        int Content
        {
            get;
        }

        void LoadProperty(string key, string value);

        void SaveAllProperty(IList<KeyValuePair<string, object>> output);

        string ToString();
    }
}
